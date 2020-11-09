using Nettention.Proud;
using Newtonsoft.Json.Linq;
using SimpleCSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;

namespace SimpleClient
{
    class work: IDisposable
    {
        private static object g_critSec = new object();
        public NetClient netClient;
        private SevenDSGameS2C.Proxy ProxyS2C = new SevenDSGameS2C.Proxy();
        private SevenDSGameC2S.Proxy ProxyC2S = new SevenDSGameC2S.Proxy();

        private SevenDSGameS2C.Stub StubS2C = new SevenDSGameS2C.Stub();
        private SevenDSGameC2S.Stub StubC2S = new SevenDSGameC2S.Stub();

        private string userId = "80D45E848B22497889290CB8E6F353D7";
        private string deviceKey = "31F927DEF8A949CE8145204ADACA61D5";
        private string dk = "8239544030F74DB192F42650180C9C07";
        private string securityToken;
        private string gametoken;
        private string aesInitVec;
        private string secretKey;
        private string gameCode;
        private NetmarbleSDKInfo sdkInfo = new NetmarbleSDKInfo();
        private long usn;
        private long dia;
        private int region;
        private bool keepWorkerThread = true;
        private bool isConnected = false;
        private Thread workerThread;
        public work(int r = 1)
        {
            region = r;
            netClient = new NetClient();

            netClient.JoinServerCompleteHandler = (info, replyFromServer) =>
            {
                lock (g_critSec)
                {
                    if (info.errorType == ErrorType.ErrorType_Ok)
                    {
                        isConnected = true;
                    }
                    else
                    {
                        log("Failed to connect server.\n");
                    }
                }
            };

            netClient.LeaveServerHandler = (errorInfo) =>
            {
                lock (g_critSec)
                {
                    isConnected = false;
                    keepWorkerThread = false;
                }
            };

            // attach RMI proxy and stub to client object.
            netClient.AttachProxy(ProxyC2S);	// Client-to-server =>
            netClient.AttachProxy(ProxyS2C);	// Client-to-server =>
            netClient.AttachStub(StubC2S);		// server-to-client <=
            netClient.AttachStub(StubS2C);		// server-to-client <=

            NetConnectionParam cp = new NetConnectionParam();
            cp.protocolVersion.Set(SimpleCSharp.Vars.m_Version);
            if (region == 1)
            {
                gameCode = "nanagb";
                cp.serverIP = SimpleCSharp.Vars.host;
                //cp.serverIP = SimpleCSharp.Vars.host_gl_asia;
            }
            else
            {
                gameCode = "nanatsunotaizai";
                cp.serverIP = SimpleCSharp.Vars.host_jp;
            }

            cp.serverPort = (ushort)SimpleCSharp.Vars.m_serverPort;

            netClient.Connect(cp);

            workerThread = new Thread(() =>
            {
                while (keepWorkerThread)
                {
                    // Prevent CPU full usage.
                    Thread.Sleep(10);

                    // process received RMI and events.
                    netClient.FrameMove();
                }
            });

            workerThread.Start();

            while (!isConnected)
                Thread.Sleep(1000);
            //Console.WriteLine("connected!");
        }
        public void setAccount(string accs)
        {
            if (accs.Length >= 1)
            {
                string[] sss = accs.Split(',');
                userId = sss[0];
                deviceKey = sss[1];
                dk = sss[2];
            }
        }
        private void popSDK()
        {
            sdkInfo.sdkJson = "";
            sdkInfo.storeType = "appstore";
            sdkInfo.countryCode = "RU";
            sdkInfo.joinedCountryCode = "RU";
            sdkInfo.languageCode = "en-US";
            sdkInfo.platformADID = "00000000-0000-0000-0000-000000000000";
            sdkInfo.UDID = deviceKey;
            sdkInfo.OS = "0";
            sdkInfo.timeZone = "+02:00";
        }
        private void InitStub()
        {
            StubS2C.CG_RequestSecurityTokenOK = (remote, rmiContext, token) =>
            {
                //Console.WriteLine("[S2C] CG_RequestSecurityTokenOK token={0}",  token);
                securityToken = token;
                return true;
            };
            StubS2C.CG_RequestNetmarbleAuthOK = (remote, rmiContext, accountInfo) =>
            {
                //Console.WriteLine("[S2C] StubS2C.CG_RequestNetmarbleAuthOK accountInfo={0}", accountInfo);
                return true;
            };
            StubS2C.CG_RequestLoginOK = (remote, rmiContext, userInfo, serverTime, serviceName, maintenanceInfo, remainResetTimeSEC) =>
            {
                //Console.WriteLine("[S2C] StubS2C.CG_RequestLoginOK userInfo={0}", userInfo);
                foreach (var i in userInfo.userCommonItemList)
                {
                    if (i.ItemID == 0x0007a12b)
                    {
                        dia = i.ItemCount;
                        break;
                    }
                }
                Console.WriteLine("[+] usn {0} diamonds {1}", userInfo.usn, dia);
                //Console.WriteLine("[+] have {0} diamonds", dia);
                return true;
            };
            StubS2C.CG_RequestChannelUserInfoOK = (remote, rmiContext, channelUserInfo) =>
            {
                //Console.WriteLine("[S2C] StubS2C.CG_RequestChannelUserInfoOK channelUserInfo={0}", channelUserInfo);
                usn = channelUserInfo.usn;
                return true;
            };
            StubS2C.CG_RequestMailListOK = (remote, rmiContext, mailList, noticeMailInfoList) =>
            {
                //Console.WriteLine("[S2C] StubS2C.CG_RequestMailListOK mailList={0} noticeMailInfoList={1}",  mailList, noticeMailInfoList);
                foreach (var g in noticeMailInfoList)
                {
                    if (!g.rewardGetStatus)
                    CG_RequestNoticeMailReward(g.noticeMailSEQ);
                }
                return true;
            };
            StubS2C.CG_RequestAuthenticateCreateOK = (remote, rmiContext, info) =>
            {
                //Console.WriteLine("[S2C] StubS2C.CG_RequestAuthenticateCreateOK info={0}", info);
                usn = info.usn;
                return true;
            };
            StubS2C.CG_RequestIngameBattleStartOK = (remote, rmiContext) =>
            {
                //Console.WriteLine("[S2C] StubS2C.CG_RequestIngameBattleStartOK");
                return true;
            };
            StubS2C.CG_RequestNoticeMailRewardOK = (remote, rmiContext, noticeMailSEQ, getItemResultInfoList, apRewardInfoList) =>
            {
                //Console.WriteLine("[S2C] StubS2C.CG_RequestNoticeMailRewardOK");
                return true;
            };
            StubS2C.CG_RequestMercenaryListOK = (remote, rmiContext, mercenaryInfoList) =>
            {
                //Console.WriteLine("[S2C] StubS2C.CG_RequestMercenaryListOK mercenaryInfoList={0}", mercenaryInfoList);
                return true;
            };
            StubS2C.CG_Request_Main_Stage_ClearOK = (remote, rmiContext, adventureClearResultInfo, isFirstMainStageClear, userPackageMissionInfoList) =>
            {
                //Console.WriteLine("[S2C] StubS2C.CG_Request_Main_Stage_ClearOK adventureClearResultInfo={0} isFirstMainStageClear={1} userPackageMissionInfoList={2}", adventureClearResultInfo, isFirstMainStageClear, userPackageMissionInfoList);
                return true;
            };
            StubS2C.GC_NotifyUserLevelUp = (remote, rmiContext) =>
            {
                //Console.WriteLine("[S2C] StubS2C.GC_NotifyUserLevelUp");
                return true;
            };
            StubS2C.CG_RequestMailConfirmOK = (remote, rmiContext, mailSN, mailHistoryInfo, itemResultInfo, apRewardInfo, missionResult) =>
            {
                //Console.WriteLine("[S2C] StubS2C.CG_RequestMailConfirmOK mailSN={0} mailHistoryInfo={1} itemResultInfo={2} apRewardInfo={3} missionResult={4}", mailSN, mailHistoryInfo, itemResultInfo, apRewardInfo, missionResult);
                //Console.WriteLine("[S2C] StubS2C.CG_RequestMailConfirmOK");
                return true;
            };
            StubS2C.CG_RequestQuestStartOK = (remote, rmiContext, progressInfo, questItemInfo) =>
            {
                //Console.WriteLine("[S2C] StubS2C.CG_RequestQuestStartOK progressInfo={0} questItemInfo={1}", progressInfo, questItemInfo);
                return true;
            };
            StubS2C.CG_RequestQuestClearOK = (remote, rmiContext, clearResultInfo, userPackageMissionInfoList) =>
            {
                //Console.WriteLine("[S2C] StubS2C.CG_RequestQuestClearOK progressInfo={0} questItemInfo={1}", clearResultInfo, userPackageMissionInfoList);
                return true;
            };
            StubS2C.CG_RequestTutorialGambleShopBuyOK = (remote, rmiContext, tutorialInfo, useItemResultinfoList, gambleItemResultInfoList, missionResult, userBingoGachaEventInfo, paybackEventResultInfo) =>
            {
                //Console.WriteLine("[S2C] StubS2C.CG_RequestTutorialGambleShopBuyOK tutorialInfo={0} useItemResultinfoList={1} gambleItemResultInfoList={2} missionResult={3} userBingoGachaEventInfo={4} paybackEventResultInfo={5}", tutorialInfo, useItemResultinfoList, gambleItemResultInfoList, missionResult, userBingoGachaEventInfo, paybackEventResultInfo);
                return true;
            };
            StubS2C.CG_RequestChangeNicknameOK = (remote, rmiContext, userNickname, nicknameChangeCount, changeAvailableDateRemainSec) =>
            {
                //Console.WriteLine("[S2C] StubS2C.CG_RequestChangeNicknameOK userNickname={0} nicknameChangeCount={1} changeAvailableDateRemainSec={2}", userNickname, nicknameChangeCount, changeAvailableDateRemainSec);
                return true;
            };
            StubS2C.CG_RequestAttendanceRewardOK = (remote, rmiContext, attendanceResult, userPackageMissionInfoList) =>
            {
                //Console.WriteLine("[S2C] StubS2C.CG_RequestAttendanceRewardOK attendanceResult={0} userPackageMissionInfoList={1}", attendanceResult, userPackageMissionInfoList);
                return true;
            };
            StubS2C.CG_RequestLobbyInfoOK = (remote, rmiContext, lobbyInfo, missionResult, deleteItemResultInfoList, remainResetTimeSEC) =>
            {
                //Console.WriteLine("[S2C] StubS2C.CG_RequestLobbyInfoOK lobbyInfo={0} missionResult={1} deleteItemResultInfoList={2} remainResetTimeSEC={3}", lobbyInfo, missionResult, deleteItemResultInfoList, remainResetTimeSEC);
                return true;
            };
            StubS2C.CG_RequestEventSeasonPassInfoOK = (remote, rmiContext, clientSeasonPassRankRewardInfoList, rankPointItemInfo, currentServerSeasonPassWeek, currentClientSeasonPassWeek) =>
            {
                //Console.WriteLine("[S2C] StubS2C.CG_RequestEventSeasonPassInfoOK clientSeasonPassRankRewardInfoList={0} rankPointItemInfo={1} currentServerSeasonPassWeek={2} currentClientSeasonPassWeek={3}", clientSeasonPassRankRewardInfoList, rankPointItemInfo, currentServerSeasonPassWeek, currentClientSeasonPassWeek);
                return true;
            };
            StubS2C.CG_RequestWorldChattingChannelOK = (remote, rmiContext, worldChattingChannelId) =>
            {
                //Console.WriteLine("[S2C] StubS2C.CG_RequestWorldChattingChannelOK worldChattingChannelId={0}", worldChattingChannelId);
                return true;
            };
            StubS2C.CG_Request_Main_Stage_StartOK = (remote, rmiContext, adventureStageResultInfo, paybackEventResultInfo) =>
            {
                //Console.WriteLine("[S2C] StubS2C.CG_Request_Main_Stage_StartOK adventureStageResultInfo={0} paybackEventResultInfo={1}", adventureStageResultInfo, paybackEventResultInfo);
                return true;
            };
            StubS2C.CG_RequestBillingCouponVerifyOK = (remote, rmiContext, verifyResultInfo, netmarble_reward_id) =>
            {
                //Console.WriteLine("[S2C] StubS2C.CG_RequestBillingCouponVerifyOK verifyResultInfo={0} netmarble_reward_id={1}", verifyResultInfo, netmarble_reward_id);
                return true;
            };
            StubS2C.CG_RequestTutorialAddStepOK = (remote, rmiContext, tutorialInfo, itemResultInfoList, missionResult) =>
            {
                //Console.WriteLine("[S2C] StubS2C.CG_RequestTutorialAddStepOK");// tutorialInfo={0} itemResultInfoList={1} missionResult={2}", tutorialInfo, itemResultInfoList, missionResult);
                ////Console.WriteLine("[S2C] StubS2C.CG_RequestTutorialAddStepOK tutorialInfo={0} itemResultInfoList={1} missionResult={2}", tutorialInfo, itemResultInfoList, missionResult);
                return true;
            };
        }
        private void CG_RequestNetmarbleAuth()
        {
            while (String.IsNullOrEmpty(gametoken)) {
                try
                {
                    signin();
                }
                catch { }
            }
            string securityCertValue = getsecurityCertValue();
            int versionNumber;
            if (region==1)
                versionNumber = 0x2713;
            else
                versionNumber = 0x2797;
            ClientDeviceType deviceType = ClientDeviceType.iOS;
            int signType = 1;
            ProxyC2S.CG_RequestNetmarbleAuth(HostID.HostID_Server, RmiContext.ReliableSend, userId, gametoken, securityCertValue, versionNumber, deviceType, signType, sdkInfo);
        }
        private void CG_RequestBillingCouponVerify()
        {
            var verifyType = BillingVerifyType.RM;
            ProxyC2S.CG_RequestBillingCouponVerify(HostID.HostID_Server, RmiContext.ReliableSend, verifyType); ;
        }
        private void CG_RequestWorldChattingChannel()
        {
            int targetChannelId = 0;
            bool neverFail = true;
            ProxyC2S.CG_RequestWorldChattingChannel(HostID.HostID_Server, RmiContext.ReliableSend, targetChannelId, neverFail); ;
        }
        private void CG_RequestLobbyInfo()
        {
            ProxyC2S.CG_RequestLobbyInfo(HostID.HostID_Server, RmiContext.ReliableSend);
        }
        private void CG_RequestEventSeasonPassInfo()
        {
            byte currentClientSeasonPassWeek = 0;
            ProxyC2S.CG_RequestEventSeasonPassInfo(HostID.HostID_Server, RmiContext.ReliableSend, currentClientSeasonPassWeek);
        }
        private void CG_RequestMailList()
        {
            var languageType = LanguageType.EN;
            ProxyC2S.CG_RequestMailList(HostID.HostID_Server, RmiContext.ReliableSend, languageType);
        }
        private void CG_RequestMailConfirmAll()
        {
            ProxyC2S.CG_RequestMailConfirmAll(HostID.HostID_Server, RmiContext.ReliableSend);
        }
        private void CG_RequestAuthenticateCreate()
        {
            ProxyC2S.CG_RequestAuthenticateCreate(HostID.HostID_Server, RmiContext.ReliableSend, userId, sdkInfo);
        }
        private void CG_RequestTutorialAddStep(int tutorialStep)
        {
            ProxyC2S.CG_RequestTutorialAddStep(HostID.HostID_Server, RmiContext.ReliableSend, tutorialStep); ;
        }
        private void CG_RequestNoticeMailReward(int noticeMailSEQ)
        {
            //Console.WriteLine("CG_RequestNoticeMailReward:{0}", noticeMailSEQ);
            ProxyC2S.CG_RequestNoticeMailReward(HostID.HostID_Server, RmiContext.ReliableSend, noticeMailSEQ); ;
        }
        private void CG_RequestQuestClear(int questID)
        {
            ProxyC2S.CG_RequestQuestClear(HostID.HostID_Server, RmiContext.ReliableSend, questID); ;
        }
        private void CG_RequestQuestStart(int questID)
        {
            ProxyC2S.CG_RequestQuestStart(HostID.HostID_Server, RmiContext.ReliableSend, questID); ;
        }
        private void CG_RequestStoryCostume(List<int> idList)
        {
            ProxyC2S.CG_RequestStoryCostume(HostID.HostID_Server, RmiContext.ReliableSend, idList); ;
        }
        private void CG_RequestLobbyNpcSkin(int npcID, int storyCostumeID)
        {
            ProxyC2S.CG_RequestLobbyNpcSkin(HostID.HostID_Server, RmiContext.ReliableSend, npcID, storyCostumeID); ;
        }
        private void CG_RequestTutorialGambleShopBuy(int tutorialStep)
        {
            ProxyC2S.CG_RequestTutorialGambleShopBuy(HostID.HostID_Server, RmiContext.ReliableSend, tutorialStep); ;
        }
        private void CG_RequestTutorialSetFlag(TutorialType tutorialType)
        {
            ProxyC2S.CG_RequestTutorialSetFlag(HostID.HostID_Server, RmiContext.ReliableSend, tutorialType); ;
        }
        private void CG_RequestChangeNickname(string nickname)
        {
            ProxyC2S.CG_RequestChangeNickname(HostID.HostID_Server, RmiContext.ReliableSend, nickname); ;
        }
        private void CG_RequestAttendanceReward(ClientDeviceType deviceType)
        {
            ProxyC2S.CG_RequestAttendanceReward(HostID.HostID_Server, RmiContext.ReliableSend, deviceType); ;
        }
        private void CG_RequestLogin()
        {
            VersionInfo versionInfo = new VersionInfo();
            if (region == 1)
            {
                versionInfo.clientVersion = 10109;//10009 1.0.9 10100 1.1.0
                versionInfo.cdnVersion = tools.getVersion(1);
            }
            else
            {
                versionInfo.clientVersion = 10135;
                versionInfo.cdnVersion = tools.getVersion(2);
            }
            string rejoinData = "";
            long clientTimeTick = DateTime.Now.Ticks;
            string patchName = "";
            string patchData = "";
            LanguageType languageType = LanguageType.EN;
            ProxyC2S.CG_RequestLogin(HostID.HostID_Server, RmiContext.ReliableSend, usn, sdkInfo, versionInfo, rejoinData, clientTimeTick, patchName, patchData, languageType);
        }
        private void CG_RequestChannelUserInfo()
        {
            ProxyC2S.CG_RequestChannelUserInfo(HostID.HostID_Server, RmiContext.ReliableSend, userId, sdkInfo);
        }
        private void CG_RequestMercenaryList()
        {
            ProxyC2S.CG_RequestMercenaryList(HostID.HostID_Server, RmiContext.ReliableSend);
        }
        private void CG_RequestIngameBattleStart()
        {
            ProxyC2S.CG_RequestIngameBattleStart(HostID.HostID_Server, RmiContext.ReliableSend);
        }
        private void CG_RequestSecurityToken()
        {
            ProxyC2S.CG_RequestSecurityToken(HostID.HostID_Server, RmiContext.ReliableSend);
        }
        private void CG_Request_Main_Stage_Start(StageStartRequestInfo stageStartRequestInfo)
        {
            ProxyC2S.CG_Request_Main_Stage_Start(HostID.HostID_Server, RmiContext.ReliableSend, stageStartRequestInfo);
        }
        private void CG_Request_Main_Stage_Clear(StageClearRequestInfo stageClearRequestInfo)
        {
            ProxyC2S.CG_Request_Main_Stage_Clear(HostID.HostID_Server, RmiContext.ReliableSend, stageClearRequestInfo);
        }
        private string getsecurityCertValue()
        {
            //Console.WriteLine("getsecurityCertValue:{0}", securityToken);
            return Get(String.Format("http://127.0.0.1/{0}:{1}", securityToken, userId));
        }
        private void log(string m)
        {
            //Console.WriteLine(m);
        }
        private void register()
        {
            deviceKey = rnd();
            userId = rnd();
            dk = rnd();
            //Console.WriteLine("deviceKey:{0} userId:{1}", deviceKey, userId);
            var t = String.Format("http://api.at.netmarble.net/ver1/launch?&targetGameCode={0}&deviceKey={1}&userId={2}&pId={3}&deviceOsVer=13.3.1&deviceModel=iPad&deviceBrand=Apple", gameCode, deviceKey, userId, userId);
            using (var client = new WebClient())
            {
                WebProxy wp = new WebProxy(tools.getproxy());
                client.Proxy = wp;
                client.Timeout = 3000;
                client.Headers.Add("NMDeviceKey", deviceKey);
                client.Headers.Add("NMPlatform", "iOS");
                client.Headers.Add("NMWorld", "globallive");
                client.Headers.Add("NMScreenSize", "768.000000, 1024.000000");
                client.Headers.Add("NS_Lang", "en");
                client.Headers.Add("platform", "iOS");
                client.Headers.Add("NS_Region", "GLOBAL");
                client.Headers.Add("Accept", "application/json");
                client.Headers.Add("module", "sdk");
                client.Headers.Add("NMPlayerID", userId);
                client.Headers.Add("locale", "en");
                client.Headers.Add("Accept-Encoding", "gzip, deflate, br");
                client.Headers.Add("ScreenSize", "768.000000, 1024.000000");
                client.Headers.Add("User-Agent", "The%20Seven%20Deadly%20Sins/10003 CFNetwork/1121.2.2 Darwin/19.3.0");
                client.Headers.Add("NMCity", "RU");
                client.Headers.Add("version", "4.4.5.1");
                client.Headers.Add("Cookie", "NMLanguage=en; NS_Lang=en");
                client.Headers.Add("NMTimeZone", "+02:00");
                client.Headers.Add("NMChannelUserID", "%7B%7D");
                client.Headers.Add("NMSDKVersion", "4.4.5.1");
                client.Headers.Add("Accept-Language", "en");
                client.Headers.Add("NMLanguage", "en");
                client.Headers.Add("NMMarketType", "AppStore");
                client.Headers.Add("NMCountryCode", "RU");
                client.Headers.Add("GeoLocation", "RU");
                client.Headers.Add("NMGameCode", gameCode);
                client.Headers.Add("NMDeviceModel", "iPad7,5");
                client.Headers.Add("NMNetworkStatus", "WIFI");
                client.Headers.Add("NMRegion", "GLOBAL");
                client.Headers.Add("NMJoinedCountryCode", "RU");
                client.Headers.Add("NMOSVersion", "13.3.1");
                client.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
                client.Headers.Add("NMDeviceLanguage", "en-DE");
                client.Headers.Add("NMLocalizedLevel", "1");
                client.Headers.Add("TimeZone", "+02:00");
                client.Headers.Add("DeviceModel", "iPad7,5");
                client.Headers.Add("NetworkStatus", "WIFI");
                string res = client.DownloadString(t);
                //Console.WriteLine(res);
            }
        }
        private class WebClient : System.Net.WebClient
        {
            public int Timeout { get; set; }

            protected override WebRequest GetWebRequest(Uri uri)
            {
                WebRequest lWebRequest = base.GetWebRequest(uri);
                lWebRequest.Timeout = Timeout;
                ((HttpWebRequest)lWebRequest).ReadWriteTimeout = Timeout;
                return lWebRequest;
            }
        }
        private void link(string password)
        {
            var key = tools.StringToByteArray(secretKey);
            var iv = tools.StringToByteArray(aesInitVec);
            string transferCode = tools.RandomString(8);
            password = tools.EncryptStringToBytes_Aes(password, key, iv);
            string d = "";
            var t = Uri.EscapeUriString(String.Format("https://mobileauth-global.netmarble.com/transfer/code?gameToken={0}&deviceKey={1}&playerId={2}&gameCode={3}&transferCode={4}&password={5}", gametoken, deviceKey, userId, gameCode, transferCode, password));
            using (var client = new WebClient())
            {
                WebProxy wp = new WebProxy(tools.getproxy());
                client.Proxy = wp;
                client.Timeout = 7000;
                client.Headers.Add("NMDeviceKey", deviceKey);
                client.Headers.Add("NMPlatform", "iOS");
                client.Headers.Add("NMWorld", "globallive");
                client.Headers.Add("NMScreenSize", "768.000000, 1024.000000");
                client.Headers.Add("NS_Lang", "en");
                client.Headers.Add("platform", "iOS");
                client.Headers.Add("NS_Region", "GLOBAL");
                client.Headers.Add("Accept", "application/json");
                client.Headers.Add("module", "sdk");
                client.Headers.Add("NMPlayerID", userId);
                client.Headers.Add("locale", "en");
                client.Headers.Add("Accept-Encoding", "gzip, deflate, br");
                client.Headers.Add("ScreenSize", "768.000000, 1024.000000");
                client.Headers.Add("User-Agent", "The%20Seven%20Deadly%20Sins/10003 CFNetwork/1121.2.2 Darwin/19.3.0");
                client.Headers.Add("NMCity", "RU");
                client.Headers.Add("version", "4.4.5.1");
                client.Headers.Add("Cookie", "NMLanguage=en; NS_Lang=en");
                client.Headers.Add("NMTimeZone", "+02:00");
                client.Headers.Add("NMChannelUserID", "%7B%7D");
                client.Headers.Add("NMSDKVersion", "4.4.5.1");
                client.Headers.Add("Accept-Language", "en");
                client.Headers.Add("NMLanguage", "en");
                client.Headers.Add("NMMarketType", "AppStore");
                client.Headers.Add("NMCountryCode", "RU");
                client.Headers.Add("GeoLocation", "RU");
                client.Headers.Add("NMGameCode", gameCode);
                client.Headers.Add("NMDeviceModel", "iPad7,5");
                client.Headers.Add("NMNetworkStatus", "WIFI");
                client.Headers.Add("NMRegion", "GLOBAL");
                client.Headers.Add("NMJoinedCountryCode", "RU");
                client.Headers.Add("NMOSVersion", "13.3.1");
                client.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
                client.Headers.Add("NMDeviceLanguage", "en-DE");
                client.Headers.Add("NMLocalizedLevel", "1");
                client.Headers.Add("TimeZone", "+02:00");
                client.Headers.Add("DeviceModel", "iPad7,5");
                client.Headers.Add("NetworkStatus", "WIFI");
                string res = client.UploadString(t, d);
                //Console.WriteLine(res);
            }
            addAccount(transferCode);
        }
        private void addAccount(string transferCode)
        {
            var d = String.Format("playerId={0}&nmDeviceKey={1}&deviceKey={2}&usn={3}&transferCode={4}", userId, deviceKey, dk, usn, transferCode);
            var t = "http://127.0.0.1/reg";
            using (var client = new WebClient())
            {
                client.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
                client.Timeout = 7000;
                string res = client.UploadString(t, d);
                //Console.WriteLine(res);
            }
        }
        private void signin()
        {
            var d = String.Format("gameCode={0}&playerId={1}&countryCode=DE&adId=&nmDeviceKey={2}&deviceKey={3}", gameCode, userId, deviceKey, dk);
            var url = "https://mobileauth-rest.netmarble.com/signin";
            using (var client = new WebClient())
            {
                WebProxy wp = new WebProxy(tools.getproxy());
                client.Proxy = wp;
                client.Timeout = 7000;
                client.Headers.Add("NMDeviceKey", deviceKey);
                client.Headers.Add("NMPlatform", "iOS");
                client.Headers.Add("NMWorld", "globallive");
                client.Headers.Add("NMScreenSize", "768.000000, 1024.000000");
                client.Headers.Add("NS_Lang", "en");
                client.Headers.Add("platform", "iOS");
                client.Headers.Add("NS_Region", "GLOBAL");
                client.Headers.Add("Accept", "application/json");
                client.Headers.Add("module", "sdk");
                client.Headers.Add("NMPlayerID", userId);
                client.Headers.Add("locale", "en");
                client.Headers.Add("Accept-Encoding", "gzip, deflate, br");
                client.Headers.Add("ScreenSize", "768.000000, 1024.000000");
                client.Headers.Add("User-Agent", "The%20Seven%20Deadly%20Sins/10003 CFNetwork/1121.2.2 Darwin/19.3.0");
                client.Headers.Add("NMCity", "RU");
                client.Headers.Add("version", "4.4.5.1");
                client.Headers.Add("Cookie", "NMLanguage=en; NS_Lang=en");
                client.Headers.Add("NMTimeZone", "+02:00");
                client.Headers.Add("NMChannelUserID", "%7B%7D");
                client.Headers.Add("NMSDKVersion", "4.4.5.1");
                client.Headers.Add("Accept-Language", "en");
                client.Headers.Add("NMLanguage", "en");
                client.Headers.Add("NMMarketType", "AppStore");
                client.Headers.Add("NMCountryCode", "RU");
                client.Headers.Add("GeoLocation", "RU");
                client.Headers.Add("NMGameCode", gameCode);
                client.Headers.Add("NMDeviceModel", "iPad7,5");
                client.Headers.Add("NMNetworkStatus", "WIFI");
                client.Headers.Add("NMRegion", "GLOBAL");
                client.Headers.Add("NMJoinedCountryCode", "RU");
                client.Headers.Add("NMOSVersion", "13.3.1");
                client.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
                client.Headers.Add("NMDeviceLanguage", "en-DE");
                client.Headers.Add("NMLocalizedLevel", "1");
                client.Headers.Add("TimeZone", "+02:00");
                client.Headers.Add("DeviceModel", "iPad7,5");
                client.Headers.Add("NetworkStatus", "WIFI");

                string res = client.UploadString(url, d);
                //Console.WriteLine(res);
                JObject o = JObject.Parse(res);
                gametoken = (string)o["resultData"]["gameToken"];
                secretKey = (string)o["resultData"]["cipherKeyList"]["keyInfos"][0]["secretKey"];
                aesInitVec = (string)o["resultData"]["cipherKeyList"]["keyInfos"][0]["aesInitVec"];
            }
        }
        private string rnd()
        {
            var t = System.Guid.NewGuid();
            return t.ToString().Replace("-", "").ToUpper();
        }
        private string Get(string uri)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }
        }
        private void reroll()
        {
            register();
            popSDK();
            //Console.WriteLine("calling CG_RequestChannelUserInfo()");
            CG_RequestChannelUserInfo();
            Thread.Sleep(500);
            //Console.WriteLine("calling CG_RequestSecurityToken()");
            CG_RequestSecurityToken();
            Thread.Sleep(500);
            //Console.WriteLine("calling CG_RequestNetmarbleAuth()");
            CG_RequestNetmarbleAuth();
            Thread.Sleep(500);
            //Console.WriteLine("calling CG_RequestAuthenticateCreate()");
            CG_RequestAuthenticateCreate();
            Thread.Sleep(500);
            //Console.WriteLine("calling CG_RequestLogin()");
            CG_RequestLogin();
            Thread.Sleep(500);
            //Console.WriteLine("calling CG_RequestBillingCouponVerify()");
            CG_RequestBillingCouponVerify();
            Thread.Sleep(500);
            //Console.WriteLine("calling CG_RequestTutorialAddStep()");
            CG_RequestTutorialAddStep(100);
            Thread.Sleep(500);
            //Console.WriteLine("calling CG_RequestLobbyInfo()");
            CG_RequestLobbyInfo();
            Thread.Sleep(500);
            //Console.WriteLine("calling CG_RequestWorldChattingChannel()");
            CG_RequestWorldChattingChannel();
            Thread.Sleep(500);
            //CG_RequestEventSeasonPassInfo();
            //Thread.Sleep(500);
            //Console.WriteLine("calling CG_RequestMercenaryList()");
            CG_RequestMercenaryList();
            Thread.Sleep(500);

            var v0 = new StageStartRequestInfo();
            v0.stageID = 0x18705;
            v0.mercenaryUSN = 0;
            v0.mercenarySkinID = 0;
            v0.mercenaryState = FriendState.None;
            v0.teamIndex = 1;
            v0.battlePowerPoint = 5969;
            var v1 = new SkinStatInfo();
            v1.attack = 410;
            v1.defence = 270;
            v1.life = 4330;
            v1.currentLife = 0;
            v0.skinStatInfoList.Add(v1);
            var v2 = new SkinStatInfo();
            v2.attack = 390;
            v2.defence = 250;
            v2.life = 4330;
            v2.currentLife = 0;
            v0.skinStatInfoList.Add(v2);
            v0.stageNpcIDList = new List<int>() { };
            v0.stageIndex = 0;
            //Console.WriteLine("calling CG_Request_Main_Stage_Start()");
            CG_Request_Main_Stage_Start(v0);


            Thread.Sleep(500);
            //Console.WriteLine("calling CG_RequestIngameBattleStart()");
            CG_RequestIngameBattleStart();
            Thread.Sleep(500);
            var v3 = new StageClearRequestInfo();
            v3.stageID = 100101;
            v3.isWin = true;
            var v5 = new BattleSkinInfo();
            v5.skinID = 300104;
            v5.heroAliveStatus = HeroAliveStatus.Alive;
            v5.isBestPlayer = false;
            v5.power = 2926;
            v3.battleSkinInfoList.Add(v5);
            var v6 = new BattleSkinInfo();
            v6.skinID = 310201;
            v6.heroAliveStatus = HeroAliveStatus.Alive;
            v6.isBestPlayer = true;
            v6.power = 3043;
            v3.battleSkinInfoList.Add(v6);
            v3.teamIndex = 1;
            v3.eventSEQ = 0;
            v3.mercenaryUSN = 0;
            v3.battlePowerPoint = 5969;
            var v4 = new IngameMissionProgressRequest();
            v4.isSupporterBest = false;
            v4.cardUseCount_lv2 = 0;
            v4.cardUseCount_lv3 = 0;
            v4.cardUseCount_specical = 1;
            v4.cardUseCount_heal = 0;
            v4.cardUseCount_debuff = 1;
            v4.allyTurnCount = 4;
            v4.cardUseCount_lv1 = 4;
            v4.cardUseCount_counterPose = 0;
            v4.cardUseCount_Shild = 0;
            v4.cardUseCount_AtkStaDown = 0;
            v4.cardUseCount_Stun = 0;
            v4.cardUseCount_Stone = 0;
            v4.cardUseCount_Ice = 0;
            v4.cardUseCount_specialCoop = 0;
            v4.debuffBleedDeadCount = 0;
            v4.staminaDecreaseCount = 0;
            v4.staminaIncreaseCount = 0;
            v4.cardLevelDownCount = 0;
            v4.weakAttributeAttackCount = 0;
            v4.winTeamPower = 5969;
            v4.isAllHeroAlive = true;
            v4.isAllSSR = false;
            v4.isAllUR = false;
            v4.isAllWoman = false;
            v4.isAllMan = false;
            v4.isNoneWeaponWin = true;
            v4.buffIceDeadCount = 0;
            v4.lastAttackerSkinID = 310201;
            v4.debuffShockKillCount = 0;
            v4.debuffPoisonKillCount = 0;
            v4.maxDamage = 2816;
            v4.handicapSkillCount = 1;
            v4.minHPRatio = 55;
            v4.skillCombineByUserInputCount = 2;
            v4.counterPoseKillCount = 0;
            v4.skillLockCount = 0;
            v4.isUsedTargeting = false;
            v4.isUsedCardReset = false;
            v4.isUsedBalorEye = false;
            v4.debuffPetrifactionCount = 0;
            v4.debuffFreezingCount = 0;
            v4.debuffPreventposeCount = 0;
            v4.debuffInfectionCount = 0;
            v4.buffImmuneCount = 0;
            v4.decreaseGaugeCount = 0;
            v4.skillDissipationCount = 0;
            v4.skillBustCount = 0;
            v4.skillWeaknessCount = 0;
            v4.eraseBuffCount = 0;
            v4.erasePoseCount = 0;
            v4.recoveryDebuffCount = 0;
            v4.cardDisuseCount = 0;
            v4.beAttackedCountBySpecialCard = 1;
            v4.useCountDropMamaSkill = 0;
            v4.isFinishedByDropMamaSkill = false;
            v3.missionRequest = v4;
            v3.skinStatInfoList.Add(v1);
            v3.skinStatInfoList.Add(v2);
            v3.isAutoPlay = false;
            v3.turnCount = 7;
            v3.clientTimeSec = 0;
            v3.deltaTime = 0;
            v3.packetSendTick = DateTime.Now.Ticks;
            v3.tickCount = 0;
            v3.stopwatch = 107;
            v3.dateTime = 107;
            v3.stageIndex = 0;
            v3.battlePoint = 0;
            //Console.WriteLine("calling CG_Request_Main_Stage_Clear()");
            CG_Request_Main_Stage_Clear(v3);
            Thread.Sleep(500);
            //Console.WriteLine("calling CG_RequestTutorialAddStep()");
            CG_RequestTutorialAddStep(200);
            Thread.Sleep(500);
            //Console.WriteLine("calling CG_RequestLobbyInfo()");
            CG_RequestLobbyInfo();
            Thread.Sleep(500);
            //Console.WriteLine("calling CG_RequestMercenaryList()");
            CG_RequestMercenaryList();
            Thread.Sleep(500);

            var v7 = new StageStartRequestInfo();
            v7.stageID = 100102;
            v7.mercenaryUSN = 0;
            v7.mercenarySkinID = 0;
            v7.mercenaryState = FriendState.None;
            v7.teamIndex = 1;
            v7.battlePowerPoint = 6617;
            var v8 = new SkinStatInfo();
            v8.attack = 410;
            v8.defence = 306;
            v8.life = 5170;
            v8.currentLife = 0;
            v7.skinStatInfoList.Add(v8);
            var v9 = new SkinStatInfo();
            v9.attack = 480;
            v9.defence = 304;
            v9.life = 5620;
            v9.currentLife = 0;
            v7.skinStatInfoList.Add(v9);
            v7.stageNpcIDList = new List<int>() { };
            v7.stageIndex = 0;
            //Console.WriteLine("calling CG_Request_Main_Stage_Start()");
            CG_Request_Main_Stage_Start(v7);
            Thread.Sleep(500);
            //Console.WriteLine("calling CG_RequestIngameBattleStart()");
            CG_RequestIngameBattleStart();
            Thread.Sleep(500);

            var v10 = new StageClearRequestInfo();
            v10.stageID = 100102;
            v10.isWin = true;
            var v11 = new BattleSkinInfo();
            v11.skinID = 300104;
            v11.heroAliveStatus = HeroAliveStatus.Alive;
            v11.isBestPlayer = false;
            v11.power = 3434;
            v10.battleSkinInfoList.Add(v11);
            var v12 = new BattleSkinInfo();
            v12.skinID = 310201;
            v12.heroAliveStatus = HeroAliveStatus.Alive;
            v12.isBestPlayer = true;
            v12.power = 3434;
            v10.battleSkinInfoList.Add(v12);
            v10.teamIndex = 1;
            v10.eventSEQ = 0;
            v10.mercenaryUSN = 0;
            v10.battlePowerPoint = 6617;
            var v13 = new IngameMissionProgressRequest();
            v13.isSupporterBest = false;
            v13.cardUseCount_lv2 = 2;
            v13.cardUseCount_lv3 = 0;
            v13.cardUseCount_specical = 0;
            v13.cardUseCount_heal = 0;
            v13.cardUseCount_debuff = 0;
            v13.allyTurnCount = 2;
            v13.cardUseCount_lv1 = 2;
            v13.cardUseCount_counterPose = 1;
            v13.cardUseCount_Shild = 0;
            v13.cardUseCount_AtkStaDown = 0;
            v13.cardUseCount_Stun = 0;
            v13.cardUseCount_Stone = 0;
            v13.cardUseCount_Ice = 0;
            v13.cardUseCount_specialCoop = 0;
            v13.debuffBleedDeadCount = 0;
            v13.staminaDecreaseCount = 0;
            v13.staminaIncreaseCount = 7;
            v13.cardLevelDownCount = 0;
            v13.weakAttributeAttackCount = 2;
            v13.winTeamPower = 6617;
            v13.isAllHeroAlive = true;
            v13.isAllSSR = false;
            v13.isAllUR = false;
            v13.isAllWoman = false;
            v13.isAllMan = false;
            v13.isNoneWeaponWin = true;
            v13.buffIceDeadCount = 0;
            v13.lastAttackerSkinID = 300104;
            v13.debuffShockKillCount = 0;
            v13.debuffPoisonKillCount = 0;
            v13.maxDamage = 1783;
            v13.handicapSkillCount = 1;
            v13.minHPRatio = 61;
            v13.skillCombineByUserInputCount = 0;
            v13.counterPoseKillCount = 1;
            v13.skillLockCount = 0;
            v13.isUsedTargeting = false;
            v13.isUsedCardReset = true;
            v13.isUsedBalorEye = false;
            v13.debuffPetrifactionCount = 0;
            v13.debuffFreezingCount = 0;
            v13.debuffPreventposeCount = 0;
            v13.debuffInfectionCount = 0;
            v13.buffImmuneCount = 0;
            v13.decreaseGaugeCount = 0;
            v13.skillDissipationCount = 0;
            v13.skillBustCount = 0;
            v13.skillWeaknessCount = 0;
            v13.eraseBuffCount = 0;
            v13.erasePoseCount = 0;
            v13.recoveryDebuffCount = 0;
            v13.cardDisuseCount = 0;
            v13.beAttackedCountBySpecialCard = 1;
            v13.useCountDropMamaSkill = 0;
            v13.isFinishedByDropMamaSkill = false;
            v10.missionRequest = v13;
            v10.skinStatInfoList.Add(v8);
            v10.skinStatInfoList.Add(v9);
            v10.isAutoPlay = false;
            v10.turnCount = 4;
            v10.clientTimeSec = 0;
            v10.deltaTime = 0;
            v10.packetSendTick = DateTime.Now.Ticks;
            v10.tickCount = 0;
            v10.stopwatch = 87;
            v10.dateTime = 87;
            v10.stageIndex = 0;
            v10.battlePoint = 0;
            //Console.WriteLine("calling CG_Request_Main_Stage_Clear()");
            CG_Request_Main_Stage_Clear(v10);
            Thread.Sleep(500);
            //Console.WriteLine("calling CG_RequestTutorialAddStep()");
            CG_RequestTutorialAddStep(400);
            Thread.Sleep(500);
            //Console.WriteLine("calling CG_RequestQuestClear()");
            CG_RequestQuestClear(1);
            Thread.Sleep(500);
            //Console.WriteLine("calling CG_RequestQuestStart()");
            CG_RequestQuestStart(2);
            Thread.Sleep(500);
            //Console.WriteLine("calling CG_RequestTutorialAddStep()");
            CG_RequestTutorialAddStep(500);
            Thread.Sleep(500);
            //Console.WriteLine("calling CG_RequestStoryCostume()");
            CG_RequestStoryCostume(new List<int>() { 101, 102, 201, 202 });
            Thread.Sleep(500);
            //Console.WriteLine("calling CG_RequestLobbyNpcSkin()");
            CG_RequestLobbyNpcSkin(2001, 102);
            Thread.Sleep(500);
            //Console.WriteLine("calling CG_RequestTutorialAddStep()");
            CG_RequestTutorialAddStep(700);
            Thread.Sleep(500);
            //Console.WriteLine("calling CG_RequestTutorialAddStep()");
            CG_RequestTutorialAddStep(800);
            Thread.Sleep(500);
            //Console.WriteLine("calling CG_RequestTutorialGambleShopBuy()");
            CG_RequestTutorialGambleShopBuy(900);
            Thread.Sleep(500);
            //Console.WriteLine("calling CG_RequestChangeNickname()");
            CG_RequestChangeNickname("Meliodas");
            Thread.Sleep(500);
            //Console.WriteLine("calling CG_RequestTutorialAddStep()");
            CG_RequestTutorialAddStep(1000);
            Thread.Sleep(500);
            //Console.WriteLine("calling CG_RequestTutorialAddStep()");
            CG_RequestTutorialAddStep(1100);
            Thread.Sleep(500);
            //Console.WriteLine("calling CG_RequestAttendanceReward()");
            CG_RequestAttendanceReward(0);
            Thread.Sleep(500);
            //Console.WriteLine("calling CG_RequestTutorialAddStep()");
            CG_RequestTutorialAddStep(10000);
            Thread.Sleep(500);
            //Console.WriteLine("calling CG_RequestMailList()");
            CG_RequestMailList();
            Thread.Sleep(1500);
            //Console.WriteLine("calling CG_RequestMailConfirmAll()");
            CG_RequestMailConfirmAll();
            Thread.Sleep(500);
            //Console.WriteLine("all done :)))))))");
            link("Password");
            //Console.ReadLine();
        }
        private void login()
        {
            popSDK();
            //Console.WriteLine("calling CG_RequestChannelUserInfo()");
            CG_RequestChannelUserInfo();
            Thread.Sleep(500);
            //Console.WriteLine("calling CG_RequestSecurityToken()");
            CG_RequestSecurityToken();
            Thread.Sleep(500);
            //Console.WriteLine("calling CG_RequestNetmarbleAuth()");
            if (securityToken == "") return;
            CG_RequestNetmarbleAuth();
            Thread.Sleep(500);
            //Console.WriteLine("calling CG_RequestLogin()");
            CG_RequestLogin();
            Thread.Sleep(500);
            //Console.WriteLine("calling CG_RequestBillingCouponVerify()");
            CG_RequestBillingCouponVerify();
            Thread.Sleep(500);
            //Console.WriteLine("calling CG_RequestWorldChattingChannel()");
            CG_RequestWorldChattingChannel();
            Thread.Sleep(500);
            //Console.WriteLine("calling CG_RequestLobbyInfo()");
            CG_RequestLobbyInfo();
            Thread.Sleep(500);
            //Console.WriteLine("calling CG_RequestEventSeasonPassInfo()");
            //CG_RequestEventSeasonPassInfo();
            //Thread.Sleep(500);
            //Console.WriteLine("calling CG_RequestAttendanceReward()");
            CG_RequestAttendanceReward(ClientDeviceType.iOS);
            Thread.Sleep(500);
            //Console.WriteLine("calling CG_RequestMailList()");
            CG_RequestMailList();
            Thread.Sleep(500);
            //Console.WriteLine("calling CG_RequestMailConfirmAll()");
            CG_RequestMailConfirmAll();
            Thread.Sleep(500);
            //Console.WriteLine("done");
            //doQuest(100201);
            //doQuest(11002);
            //Console.ReadLine();
        }
        private void doQuest(int stageID)
        {
            CG_RequestMercenaryList();
            Thread.Sleep(500);
            var v0 = new StageStartRequestInfo();
            v0.stageID = stageID;
            v0.mercenaryUSN = 0;
            v0.mercenarySkinID = 0;
            v0.mercenaryState = FriendState.None;
            v0.teamIndex = 1;
            v0.battlePowerPoint = 5969;
            var v1 = new SkinStatInfo();
            v1.attack = 410;
            v1.defence = 270;
            v1.life = 4330;
            v1.currentLife = 0;
            v0.skinStatInfoList.Add(v1);
            var v2 = new SkinStatInfo();
            v2.attack = 390;
            v2.defence = 250;
            v2.life = 4330;
            v2.currentLife = 0;
            v0.skinStatInfoList.Add(v2);
            v0.stageNpcIDList = new List<int>() { };
            v0.stageIndex = 0;
            //Console.WriteLine("calling CG_Request_Main_Stage_Start()");
            CG_Request_Main_Stage_Start(v0);
            Thread.Sleep(500);
            //Console.WriteLine("calling CG_RequestIngameBattleStart()");
            CG_RequestIngameBattleStart();
            Thread.Sleep(500);
            var v3 = new StageClearRequestInfo();
            v3.stageID = stageID;
            v3.isWin = true;
            var v5 = new BattleSkinInfo();
            v5.skinID = 300104;
            v5.heroAliveStatus = HeroAliveStatus.Alive;
            v5.isBestPlayer = false;
            v5.power = 2926;
            v3.battleSkinInfoList.Add(v5);
            var v6 = new BattleSkinInfo();
            v6.skinID = 310201;
            v6.heroAliveStatus = HeroAliveStatus.Alive;
            v6.isBestPlayer = true;
            v6.power = 3043;
            v3.battleSkinInfoList.Add(v6);
            v3.teamIndex = 1;
            v3.eventSEQ = 0;
            v3.mercenaryUSN = 0;
            v3.battlePowerPoint = 5969;
            var v4 = new IngameMissionProgressRequest();
            v4.isSupporterBest = false;
            v4.cardUseCount_lv2 = 0;
            v4.cardUseCount_lv3 = 0;
            v4.cardUseCount_specical = 1;
            v4.cardUseCount_heal = 0;
            v4.cardUseCount_debuff = 1;
            v4.allyTurnCount = 4;
            v4.cardUseCount_lv1 = 4;
            v4.cardUseCount_counterPose = 0;
            v4.cardUseCount_Shild = 0;
            v4.cardUseCount_AtkStaDown = 0;
            v4.cardUseCount_Stun = 0;
            v4.cardUseCount_Stone = 0;
            v4.cardUseCount_Ice = 0;
            v4.cardUseCount_specialCoop = 0;
            v4.debuffBleedDeadCount = 0;
            v4.staminaDecreaseCount = 0;
            v4.staminaIncreaseCount = 0;
            v4.cardLevelDownCount = 0;
            v4.weakAttributeAttackCount = 0;
            v4.winTeamPower = 5969;
            v4.isAllHeroAlive = true;
            v4.isAllSSR = false;
            v4.isAllUR = false;
            v4.isAllWoman = false;
            v4.isAllMan = false;
            v4.isNoneWeaponWin = true;
            v4.buffIceDeadCount = 0;
            v4.lastAttackerSkinID = 310201;
            v4.debuffShockKillCount = 0;
            v4.debuffPoisonKillCount = 0;
            v4.maxDamage = 2816;
            v4.handicapSkillCount = 1;
            v4.minHPRatio = 55;
            v4.skillCombineByUserInputCount = 2;
            v4.counterPoseKillCount = 0;
            v4.skillLockCount = 0;
            v4.isUsedTargeting = false;
            v4.isUsedCardReset = false;
            v4.isUsedBalorEye = false;
            v4.debuffPetrifactionCount = 0;
            v4.debuffFreezingCount = 0;
            v4.debuffPreventposeCount = 0;
            v4.debuffInfectionCount = 0;
            v4.buffImmuneCount = 0;
            v4.decreaseGaugeCount = 0;
            v4.skillDissipationCount = 0;
            v4.skillBustCount = 0;
            v4.skillWeaknessCount = 0;
            v4.eraseBuffCount = 0;
            v4.erasePoseCount = 0;
            v4.recoveryDebuffCount = 0;
            v4.cardDisuseCount = 0;
            v4.beAttackedCountBySpecialCard = 1;
            v4.useCountDropMamaSkill = 0;
            v4.isFinishedByDropMamaSkill = false;
            v3.missionRequest = v4;
            v3.skinStatInfoList.Add(v1);
            v3.skinStatInfoList.Add(v2);
            v3.isAutoPlay = false;
            v3.turnCount = 7;
            v3.clientTimeSec = 0;
            v3.deltaTime = 0;
            v3.packetSendTick = DateTime.Now.Ticks;
            v3.tickCount = 0;
            v3.stopwatch = 107;
            v3.dateTime = 107;
            v3.stageIndex = 0;
            v3.battlePoint = 0;
            //Console.WriteLine("calling CG_Request_Main_Stage_Clear()");
            CG_Request_Main_Stage_Clear(v3);
            Thread.Sleep(500);
        }
        public void dowork(bool islogin = false)
        {
            popSDK();
            InitStub();


            //Console.WriteLine(DateTime.Now.ToString("h:mm:ss tt"));
            if (islogin)
                login();
            else
                reroll();
            //Console.WriteLine(DateTime.Now.ToString("h:mm:ss tt"));

            keepWorkerThread = false;
            workerThread.Join();
            netClient.Disconnect();
        }

        public void Dispose()
        {
            //GC.SuppressFinalize(this);
            //netClient.Disconnect();
            keepWorkerThread = false;
            workerThread.Join();
            netClient.Dispose();
        }
    }
}
