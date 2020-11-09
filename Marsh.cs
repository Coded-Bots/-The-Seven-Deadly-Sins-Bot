using Nettention.Proud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCSharp
{
    class Marshaler : Nettention.Proud.Marshaler
    {
        public static void Write(Nettention.Proud.Message msg, MailHistoryInfo value)
        {
            msg.Write(value.mailSN);
            msg.Write(value.itemID);
            msg.Write(value.itemCount);
            msg.Write(value.mailContentsType);
            Write(msg,value.openDate);
        }
        public static void Read(Nettention.Proud.Message msg, out MailHistoryInfo value)
        {
            MailHistoryInfo tmp = new MailHistoryInfo();
            msg.Read(out tmp.mailSN);
            msg.Read(out tmp.itemID);
            msg.Read(out tmp.itemCount);
            msg.Read(out tmp.mailContentsType);
            Read(msg, out tmp.openDate);
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out MissionClearResultInfo value)
        {
            MissionClearResultInfo tmp = new MissionClearResultInfo();
            Read(msg, out tmp.successChainIDList);
            msg.Read(out tmp.getUserExp);
            Read(msg, out tmp.itemResultInfoList);
            Read(msg, out tmp.missionResult);
            Read(msg, out tmp.apRewardInfoList);
            Read(msg, out tmp.errorType);
            Read(msg, out tmp.invalidRequestType);
            value = tmp;
        }
        public static void Write(Nettention.Proud.Message msg, MissionClearResultInfo value)
        {
            Write(msg, value.successChainIDList);
            msg.Write(value.getUserExp);
            Write(msg, value.itemResultInfoList);
            Write(msg, value.missionResult);
            Write(msg, value.apRewardInfoList);
            Write(msg, value.errorType);
            Write(msg, value.invalidRequestType);
        }
        public static void Write(Nettention.Proud.Message msg, EventMissionClearRequestInfo value)
        {
            msg.Write(value.eventSeq);
            msg.Write(value.chainID);
            msg.Write(value.chainIndex);
        }

        public static void Read(Nettention.Proud.Message msg, out NetmarbleSDKInfo value)
        {
            NetmarbleSDKInfo tmp = new NetmarbleSDKInfo();
            msg.Read(out tmp.sdkJson);
            msg.Read(out tmp.storeType);
            msg.Read(out tmp.countryCode);
            msg.Read(out tmp.joinedCountryCode);
            msg.Read(out tmp.languageCode);
            msg.Read(out tmp.platformADID);
            msg.Read(out tmp.UDID);
            msg.Read(out tmp.OS);
            msg.Read(out tmp.timeZone);
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out PacketError value)
        {
            byte tmp;
            msg.Read(out tmp);
            value = (PacketError)tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out InvalidRequestType value)
        {
            byte tmp;
            msg.Read(out tmp);
            value = (InvalidRequestType)tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out MaintenanceInfo value)
        {
            MaintenanceInfo tmp = new MaintenanceInfo();
            msg.Read(out tmp.remainSec);
            msg.Read(out tmp.message);
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out DateTime value)
        {
            try
            {
                long v0;
                int v1;
                msg.Read(out v0);
                msg.Read(out v1);
                value = new DateTime(v0, (DateTimeKind)v1);
            }
            catch { value=new DateTime(); }
        }
        public static void Read(Nettention.Proud.Message msg, out OSType value)
        {
            byte tmp;
            msg.Read(out tmp);
            value = (OSType)tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out NoticeType value)
        {
            byte tmp;
            msg.Read(out tmp);
            value = (NoticeType)tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out LanguageType value)
        {
            byte tmp;
            msg.Read(out tmp);
            value = (LanguageType)tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out NoticeLanguageData value)
        {
            NoticeLanguageData tmp = new NoticeLanguageData();
            Read(msg, out tmp.languageType);
            msg.Read(out tmp.imageURL);
            msg.Read(out tmp.linkURL);
            msg.Read(out tmp.description);
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out List<NoticeLanguageData> v)
        {
            var t = new List<NoticeLanguageData>();
            int a = 0;
            msg.ReadScalar(ref a); if (a < 1) { v = t; return; }
            for (int i = 0; i < a; i++)
            {
                var t1 = new NoticeLanguageData();
                Read(msg, out t1);
                t.Add(t1);
            }
            v = t;
        }
        public static void Read(Nettention.Proud.Message msg, out NoticeSpecificData value)
        {
            NoticeSpecificData tmp = new NoticeSpecificData();
            msg.Read(out tmp.title);
            msg.Read(out tmp.imageURL);
            msg.Read(out tmp.linkURL);
            msg.Read(out tmp.description);
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out NoticeInfo value)
        {
            NoticeInfo tmp = new NoticeInfo();
            msg.Read(out tmp.seq);
            Read(msg, out tmp.fromDate);
            Read(msg, out tmp.toDate);
            msg.Read(out tmp.noticeTimeColor);
            msg.Read(out tmp.descriptionColor);
            msg.Read(out tmp.priority);
            Read(msg, out tmp.targetOSType);
            Read(msg, out tmp.noticeStartTime);
            Read(msg, out tmp.noticeEndTime);
            Read(msg, out tmp.noticeType);
            msg.Read(out tmp.languageSet);
            Read(msg, out tmp.noticeLanguageDataList);
            Read(msg, out tmp.specificData);
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out List<NoticeInfo> v)
        {
            var t = new List<NoticeInfo>();
            int a = 0;
            msg.ReadScalar(ref a); if (a < 1) { v = t; return; }
            for (int i = 0; i < a; i++)
            {
                var t1 = new NoticeInfo();
                Read(msg, out t1);
                t.Add(t1);
            }
            v = t;
        }
        public static void Read(Nettention.Proud.Message msg, out UserHero value)
        {
            UserHero tmp = new UserHero();
            msg.Read(out tmp.heroID);
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out List<UserHero> v)
        {
            var t = new List<UserHero>();
            int a = 0;
            msg.ReadScalar(ref a); if (a < 1) { v = t; return; }
            for (int i = 0; i < a; i++)
            {
                var t1 = new UserHero();
                Read(msg, out t1);
                t.Add(t1);
            }
            v = t;
        }
        public static void Read(Nettention.Proud.Message msg, out UserSkin value)
        {
            UserSkin tmp = new UserSkin();
            /*
            msg.Read(out tmp.getSkinID);//0x2191
            msg.Read(out tmp.goldBuffValue);//21d
            msg.Read(out tmp.dropBuffValue);//221
            msg.Read(out tmp.expBuffValue);//225
            msg.Read(out tmp.skinMaterialCount);//226
            msg.Read(out tmp.isFellowshipMax);//227
            msg.Read(out tmp.heroContentsPassiveID);//228
            */
            msg.Read(out tmp.skinOwnerHeroID);
            msg.Read(out tmp.skinID);
            msg.Read(out tmp.skinExp);
            msg.Read(out tmp.skinFellowshipExp);
            msg.Read(out tmp.lastFellowRewardIndex);
            msg.Read(out tmp.awaken);
            msg.Read(out tmp.skillLevelUpCount);
            msg.Read(out tmp.maxLevelCount);
            msg.Read(out tmp.passiveSkillLevel);
            Read(msg, out tmp.equipWeaponList);
            Read(msg, out tmp.researchList);
            msg.Read(out tmp.skinCostumeGroupID);
            msg.Read(out tmp.weaponCostumeGroupID);
            msg.Read(out tmp.headCostumeGroupID);
            msg.Read(out tmp.isHeadStyleChanged);
            msg.Read(out tmp.firstResearchType);
            msg.Read(out tmp.firstResearchSlot);
            Read(msg, out tmp.registeredCostumeGroupList);
            msg.Read(out tmp.trainingStagePlayCount);
            msg.Read(out tmp.usedGuildBossSeq);
            msg.Read(out tmp.usedEventChallengeBossSeq);
            msg.Read(out tmp.transcend);
            value = tmp;
        }

        public static void Write(Message msg, List<UserTeamSlot> v)
        {
            msg.WriteScalar(v.Count);
            for (int i = 0; i < v.Count; i++)
            {
                Write(msg, v[i]);
            }
        }

        public static void Read(Nettention.Proud.Message msg, out List<UserSkin> v)
        {
            //0x214
            var t = new List<UserSkin>();
            int a = 0;
            msg.ReadScalar(ref a); if (a < 1) { v = t; return; }
            //0x215
            for (int i = 0; i < a; i++)
            {
                var t1 = new UserSkin();
                Read(msg, out t1);
                t.Add(t1);
            }
            v = t;
        }
        public static void Read(Nettention.Proud.Message msg, out UserWeaponPassiveSkill value)
        {
            UserWeaponPassiveSkill tmp = new UserWeaponPassiveSkill();
            msg.Read(out tmp.passiveID);
            msg.Read(out tmp.passiveValue);
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out List<UserWeaponPassiveSkill> v)
        {
            var t = new List<UserWeaponPassiveSkill>();
            int a = 0;
            msg.ReadScalar(ref a); if (a < 1) { v = t; return; }
            for (int i = 0; i < a; i++)
            {
                var t1 = new UserWeaponPassiveSkill();
                Read(msg, out t1);
                t.Add(t1);
            }
            v = t;
        }
        public static void Read(Nettention.Proud.Message msg, out UserWeapon value)
        {
            UserWeapon tmp = new UserWeapon();
            msg.Read(out tmp.weaponSerial);
            msg.Read(out tmp.weaponBaseID);
            msg.Read(out tmp.upgrade);
            msg.Read(out tmp.evolution);
            Read(msg, out tmp.addPassiveSkillList);
            Read(msg, out tmp.addMagicSkill);
            Read(msg, out tmp.getWeaponTime);
            msg.Read(out tmp.isEquip);
            msg.Read(out tmp.defaultOptionValue);
            msg.Read(out tmp.isLock);
            msg.Read(out tmp.carveHeroGroup);
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out List<UserWeapon> v)
        {
            var t = new List<UserWeapon>();
            int a = 0;
            msg.ReadScalar(ref a); if (a < 1) { v = t; return; }
            for (int i = 0; i < a; i++)
            {
                var t1 = new UserWeapon();
                Read(msg, out t1);
                t.Add(t1);
            }
            v = t;
        }
        public static void Read(Nettention.Proud.Message msg, out UserCommonItem value)
        {
            UserCommonItem tmp = new UserCommonItem();
            msg.Read(out tmp.ItemID);
            msg.Read(out tmp.ItemCount);
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out List<UserCommonItem> v)
        {
            var t = new List<UserCommonItem>();
            int a = 0;
            msg.ReadScalar(ref a); if (a < 1) { v = t; return; }
            for (int i = 0; i < a; i++)
            {
                var t1 = new UserCommonItem();
                Read(msg, out t1);
                t.Add(t1);
            }
            v = t;
        }
        public static void Read(Nettention.Proud.Message msg, out UserExtensionData value)
        {
            UserExtensionData tmp = new UserExtensionData();
            msg.Read(out tmp.itemInventoryMax);//0x64
            msg.Read(out tmp.weaponInventoryMax);//0x32
            value = tmp;
        }
        public static void Write(Nettention.Proud.Message msg, ClientSendMissionInfo value)
        {
            msg.Write(value.chainID);
            msg.Write(value.rewardChainIndex);
            msg.Write(value.progressValue);
        }
        public static void Write(Nettention.Proud.Message msg, List<ClientSendMissionInfo> v)
        {
            msg.WriteScalar(v.Count);
            for (int i = 0; i < v.Count; i++)
            {
                Write(msg, v[i]);
            }
        }
        public static void Write(Nettention.Proud.Message msg, MissionType value)
        {
            msg.Write((byte)value);
        }
        public static void Write(Nettention.Proud.Message msg, MarketMissionInfo value)
        {
            Write(msg, value.missionType);
            msg.Write(value.missionValue);
        }
        public static void Write(Nettention.Proud.Message msg, List<MarketMissionInfo> v)
        {
            msg.WriteScalar(v.Count);
            for (int i = 0; i < v.Count; i++)
            {
                Write(msg, v[i]);
            }
        }
        public static void Write(Nettention.Proud.Message msg, ItemType value)
        {
            msg.Write((byte)value);
        }
        public static void Write(Nettention.Proud.Message msg, UserCommonItem value)
        {
            msg.Write(value.ItemID);
            msg.Write(value.ItemCount);
        }
        public static void Write(Nettention.Proud.Message msg, UserHero value)
        {
            msg.Write(value.heroID);
        }
        public static void Write(Nettention.Proud.Message msg, UserSkin value)
        {
            msg.Write(value.getSkinID);
            msg.Write(value.goldBuffValue);
            msg.Write(value.dropBuffValue);
            msg.Write(value.expBuffValue);
            msg.Write(value.skinMaterialCount);
            msg.Write(value.isFellowshipMax);
            msg.Write(value.heroContentsPassiveID);
            msg.Write(value.skinOwnerHeroID);
            msg.Write(value.skinID);
            msg.Write(value.skinExp);
            msg.Write(value.skinFellowshipExp);
            msg.Write(value.lastFellowRewardIndex);
            msg.Write(value.awaken);
            msg.Write(value.skillLevelUpCount);
            msg.Write(value.maxLevelCount);
            msg.Write(value.passiveSkillLevel);
            Write(msg, value.equipWeaponList);
            Write(msg, value.researchList);
            msg.Write(value.skinCostumeGroupID);
            msg.Write(value.weaponCostumeGroupID);
            msg.Write(value.headCostumeGroupID);
            msg.Write(value.isHeadStyleChanged);
            msg.Write(value.firstResearchType);
            msg.Write(value.firstResearchSlot);
            Write(msg, value.registeredCostumeGroupList);
            msg.Write(value.trainingStagePlayCount);
            msg.Write(value.usedGuildBossSeq);
            msg.Write(value.usedEventChallengeBossSeq);
        }
        public static void Write(Nettention.Proud.Message msg, UserWeaponPassiveSkill value)
        {
            msg.Write(value.passiveID);
            msg.Write(value.passiveValue);
        }
        public static void Write(Nettention.Proud.Message msg, List<UserWeaponPassiveSkill> v)
        {
            msg.WriteScalar(v.Count);
            for (int i = 0; i < v.Count; i++)
            {
                Write(msg, v[i]);
            }
        }
        public static void Write(Nettention.Proud.Message msg, UserWeapon value)
        {
            msg.Write(value.weaponSerial);
            msg.Write(value.weaponBaseID);
            msg.Write(value.upgrade);
            msg.Write(value.evolution);
            Write(msg, value.addPassiveSkillList);
            Write(msg, value.addMagicSkill);
            Write(msg, value.getWeaponTime);
            msg.Write(value.isEquip);
            msg.Write(value.defaultOptionValue);
            msg.Write(value.isLock);
            msg.Write(value.carveHeroGroup);
        }
        public static void Write(Nettention.Proud.Message msg, UserCostumeSkin value)
        {
            msg.Write(value.costumeID);
            msg.Write(value.exp);
            msg.Write(value.upgrade);
            msg.Write(value.heroGroupID);
            msg.Write(value.costumeGroupID);
        }

        public static void Write(Message msg, List<ArenaRealTimePvpLastRankerStatueInfo> v)
        {
            msg.WriteScalar(v.Count);
            for (int i = 0; i < v.Count; i++)
            {
                Write(msg, v[i]);
            }
        }
        public static void Write(Nettention.Proud.Message msg, ArenaRealTimePvpLastRankerStatueInfo value)
        {
            msg.Write(value.lastRank);
            msg.Write(value.usn);
            msg.Write(value.nickname);
            msg.Write(value.userExp);
            msg.Write(value.mainSkinID);
            msg.Write(value.skinCostumeGroup);
            msg.Write(value.weaponCostumeGroup);
            msg.Write(value.headCostumeGroup);
            msg.Write(value.isHelmetOpen);
            msg.Write(value.guildName);
            msg.Write(value.guildIconID);
            msg.Write(value.guildSubIconID);
            msg.Write(value.guildBackgroundID);
            Write(msg, value.grade);
            msg.Write(value.gradeNumber);
            msg.Write(value.rankPoint);
            msg.Write(value.playTitleID);
        }

        public static void Write(Nettention.Proud.Message msg, UserCostumeWeapon value)
        {
            msg.Write(value.costumeID);
            msg.Write(value.exp);
            msg.Write(value.upgrade);
            msg.Write(value.heroGroupID);
            msg.Write(value.costumeGroupID);
        }
        public static void Write(Nettention.Proud.Message msg, UserCostumeHead value)
        {
            msg.Write(value.costumeID);
            msg.Write(value.exp);
            msg.Write(value.upgrade);
            msg.Write(value.heroGroupID);
            msg.Write(value.costumeGroupID);
        }
        public static void Write(Nettention.Proud.Message msg, DropBoxGrade value)
        {
            msg.Write((byte)value);
        }
        public static void Write(Nettention.Proud.Message msg, ItemResultInfo value)
        {
            Write(msg, value.itemType);
            Write(msg, value.userItemInfo);
            Write(msg, value.userHeroInfo);
            Write(msg, value.userSkinInfo);
            Write(msg, value.userWeaponInfo);
            Write(msg, value.userCostumeSkin);
            Write(msg, value.userCostumeWeapon);
            Write(msg, value.userCostumeHead);
            msg.Write(value.getItemCount);
            Write(msg, value.ingameResultDropBoxGrade);
            msg.Write(value.ownerSkinID);
            msg.Write(value.ownerCostumeID);
            msg.Write(value.skinExp);
            msg.Write(value.buffAddCount);
        }
        public static void Write(Nettention.Proud.Message msg, MercenaryInfo value)
        {
            Write(msg, value.mercenaryLastUseTime);
            msg.Write(value.mercenaryUsn);
            msg.Write(value.mercenaryNickname);
            msg.Write(value.mercenaryUserExp);
            msg.Write(value.mercenaryRemainUsingSec);
            Write(msg, value.mercenaryState);
            Write(msg, value.mercenarySlotInfoList);
            msg.Write(value.guildName);
            msg.Write(value.guildIconID);
            msg.Write(value.guildSubIconID);
            msg.Write(value.guildBGIconID);
        }

        public static void Write(Message msg, List<MercenarySlotInfo> v)
        {
            msg.WriteScalar(v.Count);
            for (int i = 0; i < v.Count; i++)
            {
                Write(msg, v[i]);
            }
        }
        public static void Read(Nettention.Proud.Message msg, out BillingVerifyType value)
        {
            byte tmp;
            msg.Read(out tmp);
            value = (BillingVerifyType)tmp;
        }

        public static void Write(Nettention.Proud.Message msg, MercenarySlotInfo value)
        {
            msg.Write(value.mercenaryHeroID);
            msg.Write(value.mercenarySkinID);
            msg.Write(value.mercenarySkinExp);
            msg.Write(value.mercenarySkinAwaken);
            Write(msg, value.mercenarySkinResearchList);
            msg.Write(value.isHeadStyleChanged);
            msg.Write(value.skinCostumeGroupID);
            msg.Write(value.weaponCostumeGroupID);
            msg.Write(value.headCostumeGroupID);
        }
        public static void Read(Nettention.Proud.Message msg, out StageStartRequestInfo value)
        {
            StageStartRequestInfo tmp = new StageStartRequestInfo();
            msg.Read(out tmp.stageID);
            msg.Read(out tmp.mercenaryUSN);
            msg.Read(out tmp.mercenarySkinID);
            Read(msg, out tmp.mercenaryState);
            msg.Read(out tmp.teamIndex);
            msg.Read(out tmp.eventSEQ);
            msg.Read(out tmp.battlePowerPoint);
            Read(msg, out tmp.skinStatInfoList);
            Read(msg, out tmp.stageNpcIDList);
            msg.Read(out tmp.stageIndex);
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out SkinStatInfo value)
        {
            SkinStatInfo tmp = new SkinStatInfo();
            msg.Read(out tmp.attack);
            msg.Read(out tmp.defence);
            msg.Read(out tmp.life);
            msg.Read(out tmp.currentLife);
            value = tmp;
        }

        public static void Read(Message msg, out List<SkinStatInfo> v)
        {
            var t = new List<SkinStatInfo>();
            int a = 0;
            msg.ReadScalar(ref a); if (a < 1) { v = t; return; }
            for (int i = 0; i < a; i++)
            {
                var t1 = new SkinStatInfo();
                Read(msg, out t1);
                t.Add(t1);
            }
            v = t;
        }

        public static void Write(Message msg, List<MercenaryInfo> v)
        {
            msg.WriteScalar(v.Count);
            for (int i = 0; i < v.Count; i++)
            {
                Write(msg, v[i]);
            }
        }

        public static void Write(Nettention.Proud.Message msg, List<ItemResultInfo> v)
        {
            msg.WriteScalar(v.Count);
            for (int i = 0; i < v.Count; i++)
            {
                Write(msg, v[i]);
            }
        }
        public static void Write(Nettention.Proud.Message msg, QuestState value)
        {
            msg.Write((byte)value);
        }
        public static void Write(Nettention.Proud.Message msg, QuestProgressInfo value)
        {
            msg.Write(value.questID);
            Write(msg, value.state);
            Write(msg, value.progressCountList);
            msg.Write(value.interactionFlag);
        }
        public static void Write(Nettention.Proud.Message msg, List<QuestProgressInfo> v)
        {
            msg.WriteScalar(v.Count);
            for (int i = 0; i < v.Count; i++)
            {
                Write(msg, v[i]);
            }
        }
        public static void Write(Nettention.Proud.Message msg, ClientSendEventMissionInfo value)
        {
            msg.Write(value.eventSeq);
            msg.Write(value.eventSubIndex);
            msg.Write(value.chainID);
            msg.Write(value.rewardChainIndex);
            msg.Write(value.progressValue);
        }
        public static void Write(Nettention.Proud.Message msg, List<ClientSendEventMissionInfo> v)
        {
            msg.WriteScalar(v.Count);
            for (int i = 0; i < v.Count; i++)
            {
                Write(msg, v[i]);
            }
        }
        public static void Write(Nettention.Proud.Message msg, GuildMissionInfo value)
        {
            msg.Write(value.guildMissionID);
            msg.Write(value.progressValue);
            msg.Write(value.isReward);
        }
        public static void Write(Nettention.Proud.Message msg, List<GuildMissionInfo> v)
        {
            msg.WriteScalar(v.Count);
            for (int i = 0; i < v.Count; i++)
            {
                Write(msg, v[i]);
            }
        }
        public static void Write(Nettention.Proud.Message msg, BillingVerifyType value)
        {
            msg.Write((byte)value);
        }
        public static void Read(Nettention.Proud.Message msg, out BillingResCode value)
        {
            byte tmp;
            msg.Read(out tmp);
            value = (BillingResCode)tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out BillingResultCode value)
        {
            byte tmp;
            msg.Read(out tmp);
            value = (BillingResultCode)tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out StageClearResultInfo value)
        {
            StageClearResultInfo tmp = new StageClearResultInfo();
            msg.Read(out tmp.userExp);
            Read(msg, out tmp.apInfo);
            msg.Read(out tmp.isWin);
            Read(msg, out tmp.battleSkinResultInfoList);
            Read(msg, out tmp.npcResultList);
            Read(msg, out tmp.goldItemResultInfo);
            Read(msg, out tmp.ingameItemResultInfoList);
            Read(msg, out tmp.questItemResultInfoList);
            Read(msg, out tmp.firstItemResultInfo);
            Read(msg, out tmp.clearItemResultInfo);
            Read(msg, out tmp.globalDropItemResultInfoList);
            Read(msg, out tmp.gaugeRewardItemResultInfo);
            Read(msg, out tmp.passiveDropItemInfo);
            Read(msg, out tmp.additionalItemResultInfo);
            msg.Read(out tmp.isFirstClear);
            msg.Read(out tmp.playStageID);
            Read(msg, out tmp.stageInfo);
            Read(msg, out tmp.questProgressInfoList);
            Read(msg, out tmp.missionResult);
            Read(msg, out tmp.playCountEventInfoList);
            msg.Read(out tmp.ingameGoldBuffAddValue);
            msg.Read(out tmp.usedFoodID);
            Read(msg, out tmp.updateUserGlobalDropEventInfoList);
            Read(msg, out tmp.adViewRouletteInfo);
            value = tmp;
        }

        public static void Read(Message msg, out List<UserNpcResult> v)
        {
            var t = new List<UserNpcResult>();
            int a = 0;
            msg.ReadScalar(ref a); if (a < 1) { v = t; return; }
            for (int i = 0; i < a; i++)
            {
                var t1 = new UserNpcResult();
                Read(msg, out t1);
                t.Add(t1);
            }
            v = t;
        }
        public static void Read(Nettention.Proud.Message msg, out UserNpcResult value)
        {
            UserNpcResult tmp = new UserNpcResult();
            msg.Read(out tmp.guestID);
            msg.Read(out tmp.lovePoint);
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out BattleSkinResultInfo value)
        {
            BattleSkinResultInfo tmp = new BattleSkinResultInfo();
            msg.Read(out tmp.heroID);
            msg.Read(out tmp.skinID);
            msg.Read(out tmp.skinExp);
            msg.Read(out tmp.skinGetExp);
            msg.Read(out tmp.skinBuffExp);
            msg.Read(out tmp.isBestPlayer);
            value = tmp;
        }

        public static void Read(Message msg, out List<BattleSkinResultInfo> v)
        {
            var t = new List<BattleSkinResultInfo>();
            int a = 0;
            msg.ReadScalar(ref a); if (a < 1) { v = t; return; }
            for (int i = 0; i < a; i++)
            {
                var t1 = new BattleSkinResultInfo();
                Read(msg, out t1);
                t.Add(t1);
            }
            v = t;
        }

        public static void Read(Nettention.Proud.Message msg, out QuestClearResultInfo value)
        {
            QuestClearResultInfo tmp = new QuestClearResultInfo();
            msg.Read(out tmp.questID);
            msg.Read(out tmp.userExp);
            Read(msg, out tmp.getItemResultInfoList);
            Read(msg, out tmp.removeItemResultInfoList);
            Read(msg, out tmp.questProgressInfoList);
            Read(msg, out tmp.missionResult);
            msg.Read(out tmp.basepointGetExp);
            Read(msg, out tmp.basepointInfo);
            Read(msg, out tmp.apRewardInfoList);
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out AttendanceResult value)
        {
            AttendanceResult tmp = new AttendanceResult();
            Read(msg, out tmp.attendanceInfo);
            Read(msg, out tmp.rewardItemInfoList);
            Read(msg, out tmp.apRewardInfoList);
            Read(msg, out tmp.missionResult);
            Read(msg, out tmp.preRegistationRewardList);
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out ApRewardInfo value)
        {
            ApRewardInfo tmp = new ApRewardInfo();
            Read(msg, out tmp.apInfo);
            msg.Read(out tmp.getApCount);
            value = tmp;
        }
        public static void Read(Message msg, out List<ApRewardInfo> v)
        {
            var t = new List<ApRewardInfo>();
            int a = 0;
            msg.ReadScalar(ref a); if (a < 1) { v = t; return; }
            for (int i = 0; i < a; i++)
            {
                var t1 = new ApRewardInfo();
                Read(msg, out t1);
                t.Add(t1);
            }
            v = t;
        }

        public static void Read(Nettention.Proud.Message msg, out BillingVerifyResultInfo value)
        {
            BillingVerifyResultInfo tmp = new BillingVerifyResultInfo();
            Read(msg, out tmp.resCode);
            Read(msg, out tmp.resultCode);
            msg.Read(out tmp.transactionID);
            msg.Read(out tmp.resultString);
            msg.Read(out tmp.isPurchase);
            msg.Read(out tmp.promoFlag);
            msg.Read(out tmp.gppFlag);
            value = tmp;
        }

        public static void Write(Nettention.Proud.Message msg, ClientSendPlayTitleMissionInfo value)
        {
            msg.Write(value.missionID);
            msg.Write(value.progressValue);
        }
        public static void Write(Nettention.Proud.Message msg, AttendanceResult value)
        {
            Write(msg, value.attendanceInfo);
            Write(msg, value.rewardItemInfoList);
            Write(msg, value.apRewardInfoList);
            Write(msg, value.missionResult);
            Write(msg, value.preRegistationRewardList);
        }

        public static void Write(Nettention.Proud.Message msg, List<ClientSendPlayTitleMissionInfo> v)
        {
            msg.WriteScalar(v.Count);
            for (int i = 0; i < v.Count; i++)
            {
                Write(msg, v[i]);
            }
        }
        public static void Write(Nettention.Proud.Message msg, MissionResult value)
        {
            Write(msg, value.userMissionInfoList);
            Write(msg, value.marketMissionInfoList);
            Write(msg, value.eventMissionInfoList);
            Write(msg, value.guildMissionInfoList);
            Write(msg, value.titleMissionInfoList);
        }
        public static void Write(Nettention.Proud.Message msg, BasePointInfo value)
        {
            msg.Write(value.basePointID);
            msg.Write(value.fellowshipExp);
            msg.Write(value.trigger);
            msg.Write(value.uniqueInteractiveFlag);
            msg.Write(value.lastClearLoopQuestID);
            msg.Write(value.loopRandomQuestID);
            msg.Write(value.overDonationValue);
            Write(msg, value.disableDropInteractiveList);
        }
        public static void Write(Nettention.Proud.Message msg, APType value)
        {
            msg.Write((byte)value);
        }
        public static void Write(Nettention.Proud.Message msg, APInfo value)
        {
            Write(msg, value.type);
            msg.Write(value.count);
            Write(msg, value.updateTime);
            msg.Write(value.remainSecondToRecharge);
        }
        public static void Write(Nettention.Proud.Message msg, ApRewardInfo value)
        {
            Write(msg, value.apInfo);
            msg.Write(value.getApCount);
        }
        public static void Write(Nettention.Proud.Message msg, List<ApRewardInfo> v)
        {
            msg.WriteScalar(v.Count);
            for (int i = 0; i < v.Count; i++)
            {
                Write(msg, v[i]);
            }
        }
        public static void Read(Nettention.Proud.Message msg, out ItemType value)
        {
            byte tmp;
            msg.Read(out tmp);
            value = (ItemType)tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out UserCostumeSkin value)
        {
            UserCostumeSkin tmp = new UserCostumeSkin();
            msg.Read(out tmp.costumeID);
            msg.Read(out tmp.exp);
            msg.Read(out tmp.upgrade);
            msg.Read(out tmp.heroGroupID);
            msg.Read(out tmp.costumeGroupID);
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out UserCostumeWeapon value)
        {
            UserCostumeWeapon tmp = new UserCostumeWeapon();
            msg.Read(out tmp.costumeID);
            msg.Read(out tmp.exp);
            msg.Read(out tmp.upgrade);
            msg.Read(out tmp.heroGroupID);
            msg.Read(out tmp.costumeGroupID);
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out UserCostumeHead value)
        {
            UserCostumeHead tmp = new UserCostumeHead();
            msg.Read(out tmp.costumeID);
            msg.Read(out tmp.exp);
            msg.Read(out tmp.upgrade);
            msg.Read(out tmp.heroGroupID);
            msg.Read(out tmp.costumeGroupID);
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out DropBoxGrade value)
        {
            byte tmp;
            msg.Read(out tmp);
            value = (DropBoxGrade)tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out ItemResultInfo value)
        {
            ItemResultInfo tmp = new ItemResultInfo();

            Read(msg, out tmp.itemType);
            //Console.WriteLine("itemType:{0}", tmp.itemType);
            switch (tmp.itemType)
            {
                case ItemType.Costume_Head:
                    Read(msg, out tmp.userCostumeHead);
                    break;
                case ItemType.Hero:
                    Read(msg, out tmp.userHeroInfo);
                    break;
                case ItemType.Skin:
                    Read(msg, out tmp.userSkinInfo);
                    break;
                case ItemType.Costume_Skin:
                    Read(msg, out tmp.userCostumeSkin);
                    break;
                case ItemType.Weapon:
                    Read(msg, out tmp.userWeaponInfo);
                    break;
                case ItemType.Costume_Weapon:
                    Read(msg, out tmp.userCostumeWeapon);
                    break;
                case ItemType.None:
                    break;
                default:
                    Read(msg, out tmp.userItemInfo);
                    break;
            }
            msg.Read(out tmp.getItemCount);
            Read(msg, out tmp.ingameResultDropBoxGrade);
            msg.Read(out tmp.ownerSkinID);
            msg.Read(out tmp.ownerCostumeID);
            msg.Read(out tmp.skinExp);
            msg.Read(out tmp.buffAddCount);
            value = tmp;
        }

        public static void Write(Nettention.Proud.Message msg, QuestClearResultInfo value)
        {
            msg.Write(value.questID);
            msg.Write(value.userExp);
            Write(msg, value.getItemResultInfoList);
            Write(msg, value.removeItemResultInfoList);
            Write(msg, value.questProgressInfoList);
            Write(msg, value.missionResult);
            msg.Write(value.basepointGetExp);
            Write(msg, value.basepointInfo);
            Write(msg, value.apRewardInfoList);
        }
        public static void Read(Nettention.Proud.Message msg, out UserTeamSlot value)
        {
            UserTeamSlot tmp = new UserTeamSlot();
            msg.Read(out tmp.index);
            msg.Read(out tmp.heroID);
            msg.Read(out tmp.heroGroupID);
            msg.Read(out tmp.skinID);
            msg.Read(out tmp.fateHeroID);
            msg.Read(out tmp.fateHeroGroupID);
            msg.Read(out tmp.fateSkinID);
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out List<UserTeamSlot> v)
        {
            var t = new List<UserTeamSlot>();
            int a = 0;
            msg.ReadScalar(ref a); if (a < 1) { v = t; return; }
            for (int i = 0; i < a; i++)
            {
                var t1 = new UserTeamSlot();
                Read(msg, out t1);
                t.Add(t1);
            }
            v = t;
        }
        public static void Read(Nettention.Proud.Message msg, out UserTeam value)
        {
            UserTeam tmp = new UserTeam();
            msg.Read(out tmp.index);
            msg.Read(out tmp.name);
            Read(msg, out tmp.teamSlotList);
            msg.Read(out tmp.defenceBuffID);
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out List<UserTeam> v)
        {
            var t = new List<UserTeam>();
            int a = 0;
            msg.ReadScalar(ref a); if (a < 1) { v = t; return; }
            for (int i = 0; i < a; i++)
            {
                var t1 = new UserTeam();
                Read(msg, out t1);
                t.Add(t1);
            }
            v = t;
        }
        public static void Read(Nettention.Proud.Message msg, out APType value)
        {
            byte tmp;
            msg.Read(out tmp);
            value = (APType)tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out APInfo value)
        {
            APInfo tmp = new APInfo();
            Read(msg, out tmp.type);
            msg.Read(out tmp.count);
            Read(msg, out tmp.updateTime);
            msg.Read(out tmp.remainSecondToRecharge);
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out List<APInfo> v)
        {
            var t = new List<APInfo>();
            int a = 0;
            msg.ReadScalar(ref a); if (a < 1) { v = t; return; }
            for (int i = 0; i < a; i++)
            {
                var t1 = new APInfo();
                Read(msg, out t1);
                t.Add(t1);
            }
            v = t;
        }
        public static void Read(Nettention.Proud.Message msg, out SideStageClearInfo value)
        {
            SideStageClearInfo tmp = new SideStageClearInfo();
            msg.Read(out tmp.region);
            msg.Read(out tmp.sideStageID1);
            msg.Read(out tmp.sideStageID2);
            msg.Read(out tmp.sideStageID3);
            msg.Read(out tmp.sideStageID4);
            msg.Read(out tmp.sideStageID5);
            msg.Read(out tmp.freeStage);
            msg.Read(out tmp.bossStage);
            msg.Read(out tmp.limitedStage);
            msg.Read(out tmp.areaFirstClearInfo);
            msg.Read(out tmp.hawkRunStage);
            msg.Read(out tmp.finalBossStage);
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out List<SideStageClearInfo> v)
        {
            var t = new List<SideStageClearInfo>();
            int a = 0;
            msg.ReadScalar(ref a); if (a < 1) { v = t; return; }
            for (int i = 0; i < a; i++)
            {
                var t1 = new SideStageClearInfo();
                Read(msg, out t1);
                t.Add(t1);
            }
            v = t;
        }
        public static void Read(Nettention.Proud.Message msg, out StagePlayCountInfo value)
        {
            StagePlayCountInfo tmp = new StagePlayCountInfo();
            msg.Read(out tmp.stageLimitIndex);
            msg.Read(out tmp.stagePlayCount);
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out List<StagePlayCountInfo> v)
        {
            var t = new List<StagePlayCountInfo>();
            int a = 0;
            msg.ReadScalar(ref a); if (a < 1) { v = t; return; }
            for (int i = 0; i < a; i++)
            {
                var t1 = new StagePlayCountInfo();
                Read(msg, out t1);
                t.Add(t1);
            }
            v = t;
        }
        public static void Read(Nettention.Proud.Message msg, out DayOfWeek value)
        {
            byte tmp;
            msg.Read(out tmp);
            value = (DayOfWeek)tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out UserExtraStageInfo value)
        {
            UserExtraStageInfo tmp = new UserExtraStageInfo();
            msg.Read(out tmp.extraGroupID);
            msg.Read(out tmp.clearID);
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out List<UserExtraStageInfo> v)
        {
            var t = new List<UserExtraStageInfo>();
            int a = 0;
            msg.ReadScalar(ref a); if (a < 1) { v = t; return; }
            for (int i = 0; i < a; i++)
            {
                var t1 = new UserExtraStageInfo();
                Read(msg, out t1);
                t.Add(t1);
            }
            v = t;
        }
        public static void Read(Nettention.Proud.Message msg, out TrainingStageState value)
        {
            byte tmp;
            msg.Read(out tmp);
            value = (TrainingStageState)tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out TrainingStageSlotInfo value)
        {
            TrainingStageSlotInfo tmp = new TrainingStageSlotInfo();
            msg.Read(out tmp.stageIndex);
            msg.Read(out tmp.stageID);
            Read(msg, out tmp.state);
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out List<TrainingStageSlotInfo> v)
        {
            var t = new List<TrainingStageSlotInfo>();
            int a = 0;
            msg.ReadScalar(ref a); if (a < 1) { v = t; return; }
            for (int i = 0; i < a; i++)
            {
                var t1 = new TrainingStageSlotInfo();
                Read(msg, out t1);
                t.Add(t1);
            }
            v = t;
        }
        public static void Read(Nettention.Proud.Message msg, out OtherPlayerWeapon value)
        {
            OtherPlayerWeapon tmp = new OtherPlayerWeapon();
            msg.Read(out tmp.weaponSerial);
            msg.Read(out tmp.weaponBaseID);
            msg.Read(out tmp.upgrade);
            msg.Read(out tmp.evolution);
            Read(msg, out tmp.addPassiveSkillList);
            Read(msg, out tmp.addMagicSkill);
            msg.Read(out tmp.defaultOptionValue);
            msg.Read(out tmp.carveHeroGroup);
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out List<OtherPlayerWeapon> v)
        {
            var t = new List<OtherPlayerWeapon>();
            int a = 0;
            msg.ReadScalar(ref a); if (a < 1) { v = t; return; }
            for (int i = 0; i < a; i++)
            {
                var t1 = new OtherPlayerWeapon();
                Read(msg, out t1);
                t.Add(t1);
            }
            v = t;
        }
        public static void Read(Nettention.Proud.Message msg, out OtherPlayerSlotInfo value)
        {
            OtherPlayerSlotInfo tmp = new OtherPlayerSlotInfo();
            msg.Read(out tmp.index);
            msg.Read(out tmp.heroID);
            msg.Read(out tmp.skinID);
            msg.Read(out tmp.skinExp);
            msg.Read(out tmp.skinAwaken);
            Read(msg, out tmp.researchList);
            Read(msg, out tmp.equipWeaponList);
            msg.Read(out tmp.skinCostumeGroupID);
            msg.Read(out tmp.weaponCostumeGroupID);
            msg.Read(out tmp.headCostumeGroupID);
            msg.Read(out tmp.isHeadStyleChanged);
            msg.Read(out tmp.skillLevelUpCount);
            msg.Read(out tmp.maxLevelCount);
            msg.Read(out tmp.passiveSkillLevel);
            Read(msg, out tmp.registeredCostumeGroupList);
            value = tmp;
        }

        public static void Read(Message msg, out List<byte> v)
        {
            var t = new List<byte>();
            int a = 0;
            msg.ReadScalar(ref a); if (a < 1) { v = t; return; }
            for (int i = 0; i < a; i++)
            {
                byte t1;
                msg.Read(out t1);
                t.Add(t1);
            }
            v = t;
        }

        public static void Read(Nettention.Proud.Message msg, out List<OtherPlayerSlotInfo> v)
        {
            var t = new List<OtherPlayerSlotInfo>();
            int a = 0;
            msg.ReadScalar(ref a); if (a < 1) { v = t; return; }
            for (int i = 0; i < a; i++)
            {
                var t1 = new OtherPlayerSlotInfo();
                Read(msg, out t1);
                t.Add(t1);
            }
            v = t;
        }
        public static void Read(Nettention.Proud.Message msg, out IngameMissionProgressRequest value)
        {
            IngameMissionProgressRequest tmp = new IngameMissionProgressRequest();
            msg.Read(out tmp.isSupporterBest);
            msg.Read(out tmp.cardUseCount_lv2);
            msg.Read(out tmp.cardUseCount_lv3);
            msg.Read(out tmp.cardUseCount_specical);
            msg.Read(out tmp.cardUseCount_heal);
            msg.Read(out tmp.cardUseCount_debuff);
            msg.Read(out tmp.allyTurnCount);
            msg.Read(out tmp.cardUseCount_lv1);
            msg.Read(out tmp.cardUseCount_counterPose);
            msg.Read(out tmp.cardUseCount_Shild);
            msg.Read(out tmp.cardUseCount_AtkStaDown);
            msg.Read(out tmp.cardUseCount_Stun);
            msg.Read(out tmp.cardUseCount_Stone);
            msg.Read(out tmp.cardUseCount_Ice);
            msg.Read(out tmp.cardUseCount_specialCoop);
            msg.Read(out tmp.debuffBleedDeadCount);
            msg.Read(out tmp.staminaDecreaseCount);
            msg.Read(out tmp.staminaIncreaseCount);
            msg.Read(out tmp.cardLevelDownCount);
            msg.Read(out tmp.weakAttributeAttackCount);
            msg.Read(out tmp.winTeamPower);
            msg.Read(out tmp.isAllHeroAlive);
            msg.Read(out tmp.isAllSSR);
            msg.Read(out tmp.isAllUR);
            msg.Read(out tmp.isAllWoman);
            msg.Read(out tmp.isAllMan);
            msg.Read(out tmp.isNoneWeaponWin);
            msg.Read(out tmp.buffIceDeadCount);
            msg.Read(out tmp.lastAttackerSkinID);
            msg.Read(out tmp.debuffShockKillCount);
            msg.Read(out tmp.debuffPoisonKillCount);
            msg.Read(out tmp.maxDamage);
            msg.Read(out tmp.handicapSkillCount);
            msg.Read(out tmp.minHPRatio);
            msg.Read(out tmp.skillCombineByUserInputCount);
            msg.Read(out tmp.counterPoseKillCount);
            msg.Read(out tmp.skillLockCount);
            msg.Read(out tmp.isUsedTargeting);
            msg.Read(out tmp.isUsedCardReset);
            msg.Read(out tmp.isUsedBalorEye);
            msg.Read(out tmp.debuffPetrifactionCount);
            msg.Read(out tmp.debuffFreezingCount);
            msg.Read(out tmp.debuffPreventposeCount);
            msg.Read(out tmp.debuffInfectionCount);
            msg.Read(out tmp.buffImmuneCount);
            msg.Read(out tmp.decreaseGaugeCount);
            msg.Read(out tmp.skillDissipationCount);
            msg.Read(out tmp.skillBustCount);
            msg.Read(out tmp.skillWeaknessCount);
            msg.Read(out tmp.eraseBuffCount);
            msg.Read(out tmp.erasePoseCount);
            msg.Read(out tmp.recoveryDebuffCount);
            msg.Read(out tmp.cardDisuseCount);
            msg.Read(out tmp.beAttackedCountBySpecialCard);
            msg.Read(out tmp.useCountDropMamaSkill);
            msg.Read(out tmp.isFinishedByDropMamaSkill);
            value = tmp;
        }

        public static void Read(Nettention.Proud.Message msg, out StageClearRequestInfo value)
        {
            StageClearRequestInfo tmp = new StageClearRequestInfo();
            msg.Read(out tmp.stageID);
            msg.Read(out tmp.isWin);
            Read(msg, out tmp.battleSkinInfoList);
            msg.Read(out tmp.teamIndex);
            msg.Read(out tmp.eventSEQ);
            msg.Read(out tmp.mercenaryUSN);
            msg.Read(out tmp.battlePowerPoint);
            Read(msg, out tmp.missionRequest);
            Read(msg, out tmp.skinStatInfoList);
            msg.Read(out tmp.isAutoPlay);
            msg.Read(out tmp.turnCount);
            msg.Read(out tmp.clientTimeSec);
            Read(msg, out tmp.deltaTime);
            msg.Read(out tmp.packetSendTick);
            msg.Read(out tmp.tickCount);
            msg.Read(out tmp.stopwatch);
            msg.Read(out tmp.dateTime);
            msg.Read(out tmp.stageIndex);
            msg.Read(out tmp.battlePoint);
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out HeroAliveStatus value)
        {
            byte tmp;
            msg.Read(out tmp);
            value = (HeroAliveStatus)tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out BattleSkinInfo value)
        {
            BattleSkinInfo tmp = new BattleSkinInfo();
            msg.Read(out tmp.skinID);
            Read(msg, out tmp.heroAliveStatus);
            msg.Read(out tmp.isBestPlayer);
            msg.Read(out tmp.power);
            value = tmp;
        }

        public static void Read(Message msg, out List<BattleSkinInfo> v)
        {
            var t = new List<BattleSkinInfo>();
            int a = 0;
            msg.ReadScalar(ref a); if (a < 1) { v = t; return; }
            for (int i = 0; i < a; i++)
            {
                var t1 = new BattleSkinInfo();
                Read(msg, out t1);
                t.Add(t1);
            }
            v = t;
        }

        public static void Write(Nettention.Proud.Message msg, StageClearRequestInfo value)
        {
            msg.Write(value.stageID);
            msg.Write(value.isWin);
            Write(msg, value.battleSkinInfoList);
            msg.Write(value.teamIndex);
            msg.Write(value.eventSEQ);
            msg.Write(value.mercenaryUSN);
            msg.Write(value.battlePowerPoint);
            Write(msg, value.missionRequest);
            Write(msg, value.skinStatInfoList);
            msg.Write(value.isAutoPlay);
            msg.Write(value.turnCount);
            msg.Write(value.clientTimeSec);
            msg.Write(value.deltaTime);
            msg.Write(value.packetSendTick);
            msg.Write(value.tickCount);
            msg.Write(value.stopwatch);
            msg.Write(value.dateTime);
            msg.Write(value.stageIndex);
            msg.Write(value.battlePoint);
        }
        public static void Write(Nettention.Proud.Message msg, PackageBannerInfo value)
        {
            msg.Write(value.packageID);
            msg.Write(value.priority);
            msg.Write(value.packageImageUrl);
        }
        public static void Write(Nettention.Proud.Message msg, FinalBossGroupInfo value)
        {
            msg.Write(value.id);
            msg.Write(value.groupID);
            msg.Write(value.remainActiveStartSec);
            msg.Write(value.remainActiveEndSec);
            msg.Write(value.currentPlayCount);
        }
        public static void Write(Nettention.Proud.Message msg, List<FinalBossGroupInfo> v)
        {
            msg.WriteScalar(v.Count);
            for (int i = 0; i < v.Count; i++)
            {
                Write(msg, v[i]);
            }
        }
        public static void Write(Nettention.Proud.Message msg, FinalBossSeasonInfo value)
        {
            msg.Write(value.seasonID);
            msg.Write(value.remainSeasonStartSec);
            msg.Write(value.remainSeasonEndSec);
        }
        public static void Write(Nettention.Proud.Message msg, List<FinalBossSeasonInfo> v)
        {
            msg.WriteScalar(v.Count);
            for (int i = 0; i < v.Count; i++)
            {
                Write(msg, v[i]);
            }
        }
        public static void Write(Nettention.Proud.Message msg, FinalBossBattleScoreInfo value)
        {
            msg.Write(value.finalBossScoreGroupID);
            msg.Write(value.missionGroupID);
            msg.Write(value.battleScoreGroupID);
            msg.Write(value.remainSec);
        }
        public static void Write(Nettention.Proud.Message msg, List<FinalBossBattleScoreInfo> v)
        {
            msg.WriteScalar(v.Count);
            for (int i = 0; i < v.Count; i++)
            {
                Write(msg, v[i]);
            }
        }
        public static void Write(Nettention.Proud.Message msg, ClientSendFinalBossSeasonInfo value)
        {
            msg.Write(value.currentSeasonID);
            msg.Write(value.currentFinalBossStageFlag);
            Write(msg, value.finalBossGroupInfoList);
            msg.Write(value.remainFinalBossInitSec);
            msg.Write(value.currentFinalBossPointItemCount);
            Write(msg, value.finalBossSeasonInfoList);
            Write(msg, value.finalBossBattleScoreInfoList);
            msg.Write(value.prevSeasonID);
            msg.Write(value.finalBossRankRewardOccured);
        }
        public static void Write(Nettention.Proud.Message msg, NeedItemInfo value)
        {
            msg.Write(value.itemID);
            msg.Write(value.itemCount);
        }
        public static void Write(Nettention.Proud.Message msg, List<NeedItemInfo> v)
        {
            msg.WriteScalar(v.Count);
            for (int i = 0; i < v.Count; i++)
            {
                Write(msg, v[i]);
            }
        }
        public static void Write(Nettention.Proud.Message msg, FinalBossSeasonShopInfo value)
        {
            msg.Write(value.seasonID);
            msg.Write(value.remainSeasonShopStartSec);
            msg.Write(value.remainSeasonShopEndSec);
            Write(msg, value.currentSeasonShopNeedItemList);
        }
        public static void Write(Nettention.Proud.Message msg, List<FinalBossSeasonShopInfo> v)
        {
            msg.WriteScalar(v.Count);
            for (int i = 0; i < v.Count; i++)
            {
                Write(msg, v[i]);
            }
        }
        public static void Write(Nettention.Proud.Message msg, FinalBossSeasonShopBuyInfo value)
        {
            msg.Write(value.seasonID);
            msg.Write(value.productID);
            msg.Write(value.dailyBuyCount);
            msg.Write(value.seasonBuyCount);
        }
        public static void Write(Nettention.Proud.Message msg, List<FinalBossSeasonShopBuyInfo> v)
        {
            msg.WriteScalar(v.Count);
            for (int i = 0; i < v.Count; i++)
            {
                Write(msg, v[i]);
            }
        }
        public static void Write(Nettention.Proud.Message msg, ClientSendFinalBossSeasonShopInfo value)
        {
            Write(msg, value.finalBossSeasonShopInfoList);
            Write(msg, value.finalBossSeasonShopBuyInfoList);
        }

        public static void Write(Nettention.Proud.Message msg, LobbyInfo value)
        {
            Write(msg, value.lobbyVRSearchList);
            Write(msg, value.lobbyReddotInfo);
            Write(msg, value.userNpcInfoList);
            Write(msg, value.guestNPCList);
            msg.Write(value.currentVisitGuestID);
            msg.Write(value.currentVisitGuestIndex);
            msg.Write(value.newHeroVisit);
            msg.Write(value.remainHeroVisitTimeSec);
            msg.Write(value.hawkCollectAble);
            Write(msg, value.eventPacketInfo);
            Write(msg, value.noticeList);
            Write(msg, value.packageBannerInfoList);
            Write(msg, value.disableDropInteractiveList);
            msg.Write(value.isGuildKickOut);
            Write(msg, value.guildMemberInfo);
            Write(msg, value.maintenanceInfo);
            msg.Write(value.remainDailyResetTimeSEC);
            Write(msg, value.questProgressInfoList);
            msg.Write(value.didDailyResetToday);
            Write(msg, value.randomShopInfo);
            Write(msg, value.clientSendFinalBossSeasonInfo);
            Write(msg, value.clientSendFinalBossSeasonShopInfo);
            Write(msg, value.userHeroGachaGaugeInfoList);
            Write(msg, value.currentServerTime);
            msg.Write(value.userAgeLevel);
            Write(msg, value.monthlyInfo);
            msg.Write(value.gaugeEventFreeChargeAble);
            msg.Write(value.currentSeasonGroup);
            Write(msg, value.tournamentDiplayInfoList);
            Write(msg, value.userAdViewInfoList);
            Write(msg, value.clientSendBossWarInfo);
            Write(msg, value.arenaRealTimePvpLowGrade);
            msg.Write(value.arenaRealTimePvpLowGradeNumber);
            Write(msg, value.updateUserFurnitureList);
            msg.Write(value.firstDiaBuy);
            msg.Write(value.isGuildWarRejoinInfoExists);
        }

        public static void Write(Message msg, List<PackageBannerInfo> v)
        {
            msg.WriteScalar(v.Count);
            for (int i = 0; i < v.Count; i++)
            {
                Write(msg, v[i]);
            }
        }

        public static void Write(Nettention.Proud.Message msg, BossWarGroupInfo value)
        {
            msg.Write(value.groupID);
            msg.Write(value.remainEndSec);
        }
        public static void Write(Nettention.Proud.Message msg, List<BossWarGroupInfo> v)
        {
            msg.WriteScalar(v.Count);
            for (int i = 0; i < v.Count; i++)
            {
                Write(msg, v[i]);
            }
        }
        public static void Write(Nettention.Proud.Message msg, SubdueBossPlayInfo value)
        {
            msg.Write(value.groupID);
            msg.Write(value.playCount);
            msg.Write(value.initRemainSec);
            msg.Write(value.playSeq);
        }
        public static void Write(Nettention.Proud.Message msg, List<SubdueBossPlayInfo> v)
        {
            msg.WriteScalar(v.Count);
            for (int i = 0; i < v.Count; i++)
            {
                Write(msg, v[i]);
            }
        }
        public static void Write(Nettention.Proud.Message msg, ClientSendBossWarInfo value)
        {
            Write(msg, value.bossWarInfoList);
            Write(msg, value.subdueBossPlayInfoList);
        }
        public static void Write(Nettention.Proud.Message msg, TournamentState value)
        {
            msg.Write((byte)value);
        }
        public static void Write(Nettention.Proud.Message msg, TournamentDisplayInfo value)
        {
            msg.Write(value.SEQ);
            msg.Write(value.title);
            msg.Write(value.bannerURL);
            msg.Write(value.contents);
            msg.Write(value.rewardGroupID);
            msg.Write(value.isWeaponUse);
            msg.Write(value.damageRate);
            msg.Write(value.damageIncRate);
            Write(msg, value.startTime);
            Write(msg, value.endTime);
            msg.Write(value.startRemainSec);
            msg.Write(value.endRemainSec);
            msg.Write(value.isPlayer);
            Write(msg, value.tournamentState);
            msg.Write(value.stateRemainSec);
        }

        public static void Write(Message msg, List<TournamentDisplayInfo> v)
        {
            msg.WriteScalar(v.Count);
            for (int i = 0; i < v.Count; i++)
            {
                Write(msg, v[i]);
            }
        }
        public static void Write(Nettention.Proud.Message msg, HeroAliveStatus value)
        {
            msg.Write((byte)value);
        }
        public static void Write(Nettention.Proud.Message msg, BattleSkinInfo value)
        {
            msg.Write(value.skinID);
            Write(msg, value.heroAliveStatus);
            msg.Write(value.isBestPlayer);
            msg.Write(value.power);
        }

        public static void Write(Message msg, List<BattleSkinInfo> v)
        {
            msg.WriteScalar(v.Count);
            for (int i = 0; i < v.Count; i++)
            {
                Write(msg, v[i]);
            }
        }
        public static void Write(Nettention.Proud.Message msg, IngameMissionProgressRequest value)
        {
            msg.Write(value.isSupporterBest);
            msg.Write(value.cardUseCount_lv2);
            msg.Write(value.cardUseCount_lv3);
            msg.Write(value.cardUseCount_specical);
            msg.Write(value.cardUseCount_heal);
            msg.Write(value.cardUseCount_debuff);
            msg.Write(value.allyTurnCount);
            msg.Write(value.cardUseCount_lv1);
            msg.Write(value.cardUseCount_counterPose);
            msg.Write(value.cardUseCount_Shild);
            msg.Write(value.cardUseCount_AtkStaDown);
            msg.Write(value.cardUseCount_Stun);
            msg.Write(value.cardUseCount_Stone);
            msg.Write(value.cardUseCount_Ice);
            msg.Write(value.cardUseCount_specialCoop);
            msg.Write(value.debuffBleedDeadCount);
            msg.Write(value.staminaDecreaseCount);
            msg.Write(value.staminaIncreaseCount);
            msg.Write(value.cardLevelDownCount);
            msg.Write(value.weakAttributeAttackCount);
            msg.Write(value.winTeamPower);
            msg.Write(value.isAllHeroAlive);
            msg.Write(value.isAllSSR);
            msg.Write(value.isAllUR);
            msg.Write(value.isAllWoman);
            msg.Write(value.isAllMan);
            msg.Write(value.isNoneWeaponWin);
            msg.Write(value.buffIceDeadCount);
            msg.Write(value.lastAttackerSkinID);
            msg.Write(value.debuffShockKillCount);
            msg.Write(value.debuffPoisonKillCount);
            msg.Write(value.maxDamage);
            msg.Write(value.handicapSkillCount);
            msg.Write(value.minHPRatio);
            msg.Write(value.skillCombineByUserInputCount);
            msg.Write(value.counterPoseKillCount);
            msg.Write(value.skillLockCount);
            msg.Write(value.isUsedTargeting);
            msg.Write(value.isUsedCardReset);
            msg.Write(value.isUsedBalorEye);
            msg.Write(value.debuffPetrifactionCount);
            msg.Write(value.debuffFreezingCount);
            msg.Write(value.debuffPreventposeCount);
            msg.Write(value.debuffInfectionCount);
            msg.Write(value.buffImmuneCount);
            msg.Write(value.decreaseGaugeCount);
            msg.Write(value.skillDissipationCount);
            msg.Write(value.skillBustCount);
            msg.Write(value.skillWeaknessCount);
            msg.Write(value.eraseBuffCount);
            msg.Write(value.erasePoseCount);
            msg.Write(value.recoveryDebuffCount);
            msg.Write(value.cardDisuseCount);
            msg.Write(value.beAttackedCountBySpecialCard);
            msg.Write(value.useCountDropMamaSkill);
            msg.Write(value.isFinishedByDropMamaSkill);
        }
        public static void Read(Nettention.Proud.Message msg, out List<UserCostumeSkin> v)
        {
            var t = new List<UserCostumeSkin>();
            int a = 0;
            msg.ReadScalar(ref a); if (a < 1) { v = t; return; }
            for (int i = 0; i < a; i++)
            {
                var t1 = new UserCostumeSkin();
                Read(msg, out t1);
                t.Add(t1);
            }
            v = t;
        }
        public static void Read(Nettention.Proud.Message msg, out List<UserCostumeWeapon> v)
        {
            var t = new List<UserCostumeWeapon>();
            int a = 0;
            msg.ReadScalar(ref a); if (a < 1) { v = t; return; }
            for (int i = 0; i < a; i++)
            {
                var t1 = new UserCostumeWeapon();
                Read(msg, out t1);
                t.Add(t1);
            }
            v = t;
        }
        public static void Read(Nettention.Proud.Message msg, out List<UserCostumeHead> v)
        {
            var t = new List<UserCostumeHead>();
            int a = 0;
            msg.ReadScalar(ref a); if (a < 1) { v = t; return; }
            for (int i = 0; i < a; i++)
            {
                var t1 = new UserCostumeHead();
                Read(msg, out t1);
                t.Add(t1);
            }
            v = t;
        }
        public static void Read(Nettention.Proud.Message msg, out OtherPlayerTeamInfo value)
        {
            OtherPlayerTeamInfo tmp = new OtherPlayerTeamInfo();
            msg.Read(out tmp.usn);
            msg.Read(out tmp.foodBuffItemID);
            Read(msg, out tmp.teamSlotList);
            Read(msg, out tmp.fateSlotList);
            Read(msg, out tmp.skinCostumeList);
            Read(msg, out tmp.weaponCostumeList);
            Read(msg, out tmp.headCostumeList);
            Read(msg, out tmp.lobbyBuffItemIDList);
            Read(msg, out tmp.guildSkillUseList);
            msg.Read(out tmp.aiLevel);
            Read(msg, out tmp.playTitleIDList);
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out TrainingStageInfo value)
        {
            TrainingStageInfo tmp = new TrainingStageInfo();
            msg.Read(out tmp.remainSecToReset);
            msg.Read(out tmp.remainSecToClose);
            Read(msg, out tmp.stageList);
            msg.Read(out tmp.rewardGauge);
            msg.Read(out tmp.point);
            Read(msg, out tmp.mirrorTeamInfo);
            msg.Read(out tmp.trainingTaskID);
            msg.Read(out tmp.trainingTaskCount);
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out StageInfo value)
        {
            StageInfo tmp = new StageInfo();
            msg.Read(out tmp.mainStageTopClearID);
            msg.Read(out tmp.anotherMainStageTopClearID);
            Read(msg, out tmp.sideStageClearInfoList);
            Read(msg, out tmp.weeklyStageFirstClearInfoList);
            Read(msg, out tmp.questStageFirstClearInfo);
            Read(msg, out tmp.descentStageFirstClearInfo);
            Read(msg, out tmp.stagePlayCountInfoList);
            Read(msg, out tmp.dayofWeek);
            Read(msg, out tmp.extraStageInfoList);
            msg.Read(out tmp.eventGauge);
            msg.Read(out tmp.goldGauge);
            msg.Read(out tmp.upgradeGauge1);
            msg.Read(out tmp.upgradeGauge2);
            msg.Read(out tmp.upgradeGauge3);
            msg.Read(out tmp.evolutionGauge1);
            msg.Read(out tmp.evolutionGauge2);
            msg.Read(out tmp.evolutionGauge3);
            Read(msg, out tmp.trainingStageInfo);
            value = tmp;
        }

        public static void Read(Message msg, out List<long> v)
        {
            var t = new List<long>();
            int a = 0;
            msg.ReadScalar(ref a); if (a < 1) { v = t; return; }
            for (int i = 0; i < a; i++)
            {
                long t1;
                msg.Read(out t1);
                t.Add(t1);
            }
            v = t;
        }

        public static void Read(Nettention.Proud.Message msg, out QuestState value)
        {
            byte tmp;
            msg.Read(out tmp);
            value = (QuestState)tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out QuestProgressInfo value)
        {
            QuestProgressInfo tmp = new QuestProgressInfo();
            msg.Read(out tmp.questID);
            Read(msg, out tmp.state);
            Read(msg, out tmp.progressCountList);
            msg.Read(out tmp.interactionFlag);
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out List<QuestProgressInfo> v)
        {
            var t = new List<QuestProgressInfo>();
            int a = 0;
            msg.ReadScalar(ref a); if (a < 1) { v = t; return; }
            for (int i = 0; i < a; i++)
            {
                var t1 = new QuestProgressInfo();
                Read(msg, out t1);
                t.Add(t1);
            }
            v = t;
        }
        public static void Read(Nettention.Proud.Message msg, out AttendanceType value)
        {
            byte tmp;
            msg.Read(out tmp);
            value = (AttendanceType)tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out ClientSendUserAttendanceInfo value)
        {
            ClientSendUserAttendanceInfo tmp = new ClientSendUserAttendanceInfo();
            msg.Read(out tmp.isRewardedToday);//0xFDF
            Read(msg, out tmp.attendanceType);//0xFE0
            msg.Read(out tmp.attendanceGroup);//0xFE1
            msg.Read(out tmp.rewardIndex);//0xFE2
            msg.Read(out tmp.welcomeRewardIndex);//0xFE3
            msg.Read(out tmp.comebackMissionEnable);//0xFE4
            msg.Read(out tmp.combackEndRemainSec);//0xFE8
            msg.Read(out tmp.pvpComebackMissionEnable);//0xFE9
            msg.Read(out tmp.pvpCombackEndRemainSec);//0xFED
            Read(msg, out tmp.lastRewardedType);//0xFEE
            msg.Read(out tmp.lastRewardedGroup);//0xFEF
            msg.Read(out tmp.lastRewardedIndex);
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out UserPackageInfo value)
        {
            UserPackageInfo tmp = new UserPackageInfo();
            msg.Read(out tmp.packageID);
            msg.Read(out tmp.buyCount);
            Read(msg, out tmp.buyTime);
            Read(msg, out tmp.expireTIme);
            msg.Read(out tmp.remainResetTimeSEC);
            msg.Read(out tmp.rewardValue);
            msg.Read(out tmp.dayCount);
            msg.Read(out tmp.rewardAble);
            msg.Read(out tmp.isExpire);
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out List<UserPackageInfo> v)
        {
            var t = new List<UserPackageInfo>();
            int a = 0;
            msg.ReadScalar(ref a); if (a < 1) { v = t; return; }
            for (int i = 0; i < a; i++)
            {
                var t1 = new UserPackageInfo();
                Read(msg, out t1);
                t.Add(t1);
            }
            v = t;
        }
        public static void Read(Nettention.Proud.Message msg, out ShopBuyInfo value)
        {
            ShopBuyInfo tmp = new ShopBuyInfo();
            //msg.Read(out tmp.serverNoDailyReset);//1
            msg.Read(out tmp.shopProductID);
            msg.Read(out tmp.basepointID);
            msg.Read(out tmp.buyCount);
            msg.Read(out tmp.freeBuyCount);
            msg.Read(out tmp.startRemainSec);
            msg.Read(out tmp.endRemainSec);
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out List<ShopBuyInfo> v)
        {
            var t = new List<ShopBuyInfo>();
            int a = 0;
            msg.ReadScalar(ref a); if (a < 1) { v = t; return; }//0x14CB
            for (int i = 0; i < a; i++)
            {
                var t1 = new ShopBuyInfo();
                Read(msg, out t1);
                t.Add(t1);
            }
            v = t;
        }
        public static void Read(Nettention.Proud.Message msg, out CoinShopRotationInfo value)
        {
            CoinShopRotationInfo tmp = new CoinShopRotationInfo();
            msg.Read(out tmp.groupID);//0x14C6
            msg.Read(out tmp.remainSec);//0x14CA
            Read(msg, out tmp.coinShopBuyInfoList);//0x14DD
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out CoinShopRotationTabInfo value)
        {
            CoinShopRotationTabInfo tmp = new CoinShopRotationTabInfo();
            Read(msg, out tmp.platinumCoinTab);//1
            Read(msg, out tmp.goldCoinTab);//2
            Read(msg, out tmp.silverCoinTab);//2
            Read(msg, out tmp.friendCoinTab);//2
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out GuildMissionInfo value)
        {
            GuildMissionInfo tmp = new GuildMissionInfo();
            msg.Read(out tmp.guildMissionID);
            msg.Read(out tmp.progressValue);
            msg.Read(out tmp.isReward);
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out List<GuildMissionInfo> v)
        {
            var t = new List<GuildMissionInfo>();
            int a = 0;
            msg.ReadScalar(ref a); if (a < 1) { v = t; return; }
            for (int i = 0; i < a; i++)
            {
                var t1 = new GuildMissionInfo();
                Read(msg, out t1);
                t.Add(t1);
            }
            v = t;
        }
        public static void Read(Nettention.Proud.Message msg, out ServerEventType value)
        {
            int tmp;
            msg.Read(out tmp);
            value = (ServerEventType)tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out EventOpenType value)
        {
            byte tmp;
            msg.Read(out tmp);
            value = (EventOpenType)tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out ServerEventInfo value)
        {
            ServerEventInfo tmp = new ServerEventInfo();
            msg.Read(out tmp.seq);
            Read(msg, out tmp.eventType);
            msg.Read(out tmp.eventJson);
            msg.Read(out tmp.eventTitle);
            msg.Read(out tmp.eventSubTitle);
            msg.Read(out tmp.imgURL);
            msg.Read(out tmp.linkURL);
            msg.Read(out tmp.priority);
            msg.Read(out tmp.description);
            msg.Read(out tmp.tabNumber);
            msg.Read(out tmp.tabName);
            msg.Read(out tmp.tabPriority);
            msg.Read(out tmp.startRemainSec);
            msg.Read(out tmp.endRemainSec);
            Read(msg, out tmp.toDate);
            Read(msg, out tmp.fromDate);
            Read(msg, out tmp.eventOpenType);
            msg.Read(out tmp.nextOpenReaminSec);
            msg.Read(out tmp.playAbleRemainSec);
            msg.Read(out tmp.timeIndex);
            msg.Read(out tmp.maintenance);
            msg.Read(out tmp.emphasis);
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out List<ServerEventInfo> v)
        {
            var t = new List<ServerEventInfo>();
            int a = 0;
            msg.ReadScalar(ref a); if (a < 1) { v = t; return; }
            for (int i = 0; i < a; i++)
            {
                var t1 = new ServerEventInfo();
                Read(msg, out t1);
                t.Add(t1);
            }
            v = t;
        }
        public static void Read(Nettention.Proud.Message msg, out UserExchangeEventInfo value)
        {
            UserExchangeEventInfo tmp = new UserExchangeEventInfo();
            msg.Read(out tmp.eventSEQ);
            msg.Read(out tmp.exchangeID);
            msg.Read(out tmp.dailyExchangeCount);
            msg.Read(out tmp.totalExchangeCount);
            Read(msg, out tmp.eventType);
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out List<UserExchangeEventInfo> v)
        {
            var t = new List<UserExchangeEventInfo>();
            int a = 0;
            msg.ReadScalar(ref a); if (a < 1) { v = t; return; }
            for (int i = 0; i < a; i++)
            {
                var t1 = new UserExchangeEventInfo();
                Read(msg, out t1);
                t.Add(t1);
            }
            v = t;
        }
        public static void Read(Nettention.Proud.Message msg, out UserWorldAreaStageEventInfo value)
        {
            UserWorldAreaStageEventInfo tmp = new UserWorldAreaStageEventInfo();
            msg.Read(out tmp.eventSEQ);
            msg.Read(out tmp.regionID);
            msg.Read(out tmp.mainStageID);
            Read(msg, out tmp.sideStageIDList);
            msg.Read(out tmp.freeStageValue);
            msg.Read(out tmp.lastClearStageID);
            msg.Read(out tmp.limitedStageValue);
            msg.Read(out tmp.bossStageValue);
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out List<UserWorldAreaStageEventInfo> v)
        {
            var t = new List<UserWorldAreaStageEventInfo>();
            int a = 0;
            msg.ReadScalar(ref a); if (a < 1) { v = t; return; }
            for (int i = 0; i < a; i++)
            {
                var t1 = new UserWorldAreaStageEventInfo();
                Read(msg, out t1);
                t.Add(t1);
            }
            v = t;
        }
        public static void Read(Nettention.Proud.Message msg, out UserFreeStageEventInfo value)
        {
            UserFreeStageEventInfo tmp = new UserFreeStageEventInfo();
            msg.Read(out tmp.eventSEQ);
            msg.Read(out tmp.eventSubIndex);
            msg.Read(out tmp.freeStageValue);
            msg.Read(out tmp.lastClearStageID);
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out List<UserFreeStageEventInfo> v)
        {
            var t = new List<UserFreeStageEventInfo>();
            int a = 0;
            msg.ReadScalar(ref a); if (a < 1) { v = t; return; }
            for (int i = 0; i < a; i++)
            {
                var t1 = new UserFreeStageEventInfo();
                Read(msg, out t1);
                t.Add(t1);
            }
            v = t;
        }
        public static void Read(Nettention.Proud.Message msg, out UserPlayCountEventInfo value)
        {
            UserPlayCountEventInfo tmp = new UserPlayCountEventInfo();
            msg.Read(out tmp.eventSEQ);
            msg.Read(out tmp.eventSubIndex);
            msg.Read(out tmp.playCount);
            msg.Read(out tmp.getReward);
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out List<UserPlayCountEventInfo> v)
        {
            var t = new List<UserPlayCountEventInfo>();
            int a = 0;
            msg.ReadScalar(ref a); if (a < 1) { v = t; return; }
            for (int i = 0; i < a; i++)
            {
                var t1 = new UserPlayCountEventInfo();
                Read(msg, out t1);
                t.Add(t1);
            }
            v = t;
        }
        public static void Read(Nettention.Proud.Message msg, out UserGachaEventInfo value)
        {
            UserGachaEventInfo tmp = new UserGachaEventInfo();
            msg.Read(out tmp.eventSEQ);
            msg.Read(out tmp.eventSubIndex);
            msg.Read(out tmp.buyCount);
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out List<UserGachaEventInfo> v)
        {
            var t = new List<UserGachaEventInfo>();
            int a = 0;
            msg.ReadScalar(ref a); if (a < 1) { v = t; return; }
            for (int i = 0; i < a; i++)
            {
                var t1 = new UserGachaEventInfo();
                Read(msg, out t1);
                t.Add(t1);
            }
            v = t;
        }
        public static void Read(Nettention.Proud.Message msg, out UserStepupGachaEventInfo value)
        {
            UserStepupGachaEventInfo tmp = new UserStepupGachaEventInfo();
            msg.Read(out tmp.eventSEQ);
            msg.Read(out tmp.groupID);
            msg.Read(out tmp.stepNo);
            msg.Read(out tmp.stepCount);
            msg.Read(out tmp.mileage);
            msg.Read(out tmp.mileageReward);
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out List<UserStepupGachaEventInfo> v)
        {
            var t = new List<UserStepupGachaEventInfo>();
            int a = 0;
            msg.ReadScalar(ref a); if (a < 1) { v = t; return; }
            for (int i = 0; i < a; i++)
            {
                var t1 = new UserStepupGachaEventInfo();
                Read(msg, out t1);
                t.Add(t1);
            }
            v = t;
        }
        public static void Read(Nettention.Proud.Message msg, out ClientSendEventAttendanceInfo value)
        {
            ClientSendEventAttendanceInfo tmp = new ClientSendEventAttendanceInfo();
            msg.Read(out tmp.eventSEQ);
            msg.Read(out tmp.eventSubIndex);
            msg.Read(out tmp.lastRewardIndex);
            msg.Read(out tmp.dayFixRewardDay);
            msg.Read(out tmp.isRewardedToday);
            value = tmp;
        }

        public static void Write(Nettention.Proud.Message msg, NetmarbleSDKInfo value)
        {
            msg.Write(value.sdkJson);
            msg.Write(value.storeType);
            msg.Write(value.countryCode);
            msg.Write(value.joinedCountryCode);
            msg.Write(value.languageCode);
            msg.Write(value.platformADID);
            msg.Write(value.UDID);
            msg.Write(value.OS);
            msg.Write(value.timeZone);
        }
        public static void Write(Nettention.Proud.Message msg, VersionInfo value)
        {
            msg.Write(value.clientVersion);
            msg.Write(value.cdnVersion);
        }
        public static void Write(Nettention.Proud.Message msg, ClientDeviceType value)
        {
            msg.Write((byte)value);
        }
        public static void Write(Nettention.Proud.Message msg, NetmarbleAccountInfo value)
        {
            msg.Write(value.netmarblePlayerID);
            msg.Write(value.usn);
            msg.Write(value.banStatus);
            msg.Write(value.banReason);
            msg.Write(value.banCode);
            msg.Write(value.banLimitSec);
            msg.Write(value.nickName);
            msg.Write(value.languageChangeAble);
        }
        public static void Read(Nettention.Proud.Message msg, out NetmarbleAccountInfo value)
        {
            NetmarbleAccountInfo tmp = new NetmarbleAccountInfo();
            msg.Read(out tmp.netmarblePlayerID);
            msg.Read(out tmp.usn);
            msg.Read(out tmp.banStatus);
            msg.Read(out tmp.banReason);
            msg.Read(out tmp.banCode);
            msg.Read(out tmp.banLimitSec);
            msg.Read(out tmp.nickName);
            msg.Read(out tmp.languageChangeAble);
            value = tmp;
        }
        public static void Write(Nettention.Proud.Message msg, OSType value)
        {
            msg.Write((byte)value);
        }
        public static void Write(Nettention.Proud.Message msg, NoticeType value)
        {
            msg.Write((byte)value);
        }
        public static void Write(Nettention.Proud.Message msg, LanguageType value)
        {
            msg.Write((byte)value);
        }
        public static void Write(Nettention.Proud.Message msg, NoticeLanguageData value)
        {
            Write(msg, value.languageType);
            msg.Write(value.imageURL);
            msg.Write(value.linkURL);
            msg.Write(value.description);
        }
        public static void Write(Nettention.Proud.Message msg, List<NoticeLanguageData> v)
        {
            msg.WriteScalar(v.Count);
            for (int i = 0; i < v.Count; i++)
            {
                Write(msg, v[i]);
            }
        }
        public static void Write(Nettention.Proud.Message msg, NoticeSpecificData value)
        {
            msg.Write(value.title);
            msg.Write(value.imageURL);
            msg.Write(value.linkURL);
            msg.Write(value.description);
        }
        public static void Write(Nettention.Proud.Message msg, NoticeInfo value)
        {
            msg.Write(value.seq);
            Write(msg, value.fromDate);
            Write(msg, value.toDate);
            msg.Write(value.noticeTimeColor);
            msg.Write(value.descriptionColor);
            msg.Write(value.priority);
            Write(msg, value.targetOSType);
            Write(msg, value.noticeStartTime);
            Write(msg, value.noticeEndTime);
            Write(msg, value.noticeType);
            msg.Write(value.languageSet);
            Write(msg, value.noticeLanguageDataList);
            Write(msg, value.specificData);
        }
        public static void Write(Nettention.Proud.Message msg, List<NoticeInfo> v)
        {
            msg.WriteScalar(v.Count);
            for (int i = 0; i < v.Count; i++)
            {
                Write(msg, v[i]);
            }
        }
        public static void Write(Nettention.Proud.Message msg, List<UserHero> v)
        {
            msg.WriteScalar(v.Count);
            for (int i = 0; i < v.Count; i++)
            {
                Write(msg, v[i]);
            }
        }
        public static void Write(Message msg, List<byte> v)
        {
            msg.WriteScalar(v.Count);
            for (int i = 0; i < v.Count; i++)
            {
                Write(msg, v[i]);
            }
        }

        public static void Write(Nettention.Proud.Message msg, List<UserSkin> v)
        {
            msg.WriteScalar(v.Count);
            for (int i = 0; i < v.Count; i++)
            {
                Write(msg, v[i]);
            }
        }
        public static void Write(Nettention.Proud.Message msg, List<UserWeapon> v)
        {
            msg.WriteScalar(v.Count);
            for (int i = 0; i < v.Count; i++)
            {
                Write(msg, v[i]);
            }
        }
        public static void Write(Nettention.Proud.Message msg, List<UserCommonItem> v)
        {
            msg.WriteScalar(v.Count);
            for (int i = 0; i < v.Count; i++)
            {
                Write(msg, v[i]);
            }
        }
        public static void Write(Nettention.Proud.Message msg, UserExtensionData value)
        {
            msg.Write(value.itemInventoryMax);
            msg.Write(value.weaponInventoryMax);
        }
        public static void Write(Nettention.Proud.Message msg, UserTeamSlot value)
        {
            msg.Write(value.index);
            msg.Write(value.heroID);
            msg.Write(value.heroGroupID);
            msg.Write(value.skinID);
            msg.Write(value.fateHeroID);
            msg.Write(value.fateHeroGroupID);
            msg.Write(value.fateSkinID);
        }
        public static void Write(Nettention.Proud.Message msg, UserTeam value)
        {
            msg.Write(value.index);
            msg.Write(value.name);
            Write(msg, value.teamSlotList);
            msg.Write(value.defenceBuffID);

        }
        public static void Write(Nettention.Proud.Message msg, List<UserTeam> v)
        {
            msg.WriteScalar(v.Count);
            for (int i = 0; i < v.Count; i++)
            {
                Write(msg, v[i]);
            }
        }
        public static void Write(Nettention.Proud.Message msg, List<APInfo> v)
        {
            msg.WriteScalar(v.Count);
            for (int i = 0; i < v.Count; i++)
            {
                Write(msg, v[i]);
            }
        }
        public static void Write(Nettention.Proud.Message msg, SideStageClearInfo value)
        {
            msg.Write(value.region);
            msg.Write(value.sideStageID1);
            msg.Write(value.sideStageID2);
            msg.Write(value.sideStageID3);
            msg.Write(value.sideStageID4);
            msg.Write(value.sideStageID5);
            msg.Write(value.freeStage);
            msg.Write(value.bossStage);
            msg.Write(value.limitedStage);
            msg.Write(value.areaFirstClearInfo);
            msg.Write(value.hawkRunStage);
            msg.Write(value.finalBossStage);

        }
        public static void Write(Nettention.Proud.Message msg, List<SideStageClearInfo> v)
        {
            msg.WriteScalar(v.Count);
            for (int i = 0; i < v.Count; i++)
            {
                Write(msg, v[i]);
            }
        }
        public static void Write(Nettention.Proud.Message msg, StagePlayCountInfo value)
        {
            msg.Write(value.stageLimitIndex);
            msg.Write(value.stagePlayCount);

        }
        public static void Write(Nettention.Proud.Message msg, List<StagePlayCountInfo> v)
        {
            msg.WriteScalar(v.Count);
            for (int i = 0; i < v.Count; i++)
            {
                Write(msg, v[i]);
            }
        }
        public static void Write(Nettention.Proud.Message msg, DayOfWeek value)
        {
            msg.Write((byte)value);
        }
        public static void Write(Nettention.Proud.Message msg, UserExtraStageInfo value)
        {
            msg.Write(value.extraGroupID);
            msg.Write(value.clearID);

        }
        public static void Write(Nettention.Proud.Message msg, List<UserExtraStageInfo> v)
        {
            msg.WriteScalar(v.Count);
            for (int i = 0; i < v.Count; i++)
            {
                Write(msg, v[i]);
            }
        }
        public static void Write(Nettention.Proud.Message msg, TrainingStageState value)
        {
            msg.Write((byte)value);
        }
        public static void Write(Nettention.Proud.Message msg, CostumeAutoRegisterInfo value)
        {
            msg.Write(value.targetSkinID);
            Write(msg, value.targetCostumeIDList);
            Write(msg, value.slotIndexList);
        }

        public static void Write(Message msg, List<CostumeAutoRegisterInfo> v)
        {
            msg.WriteScalar(v.Count);
            for (int i = 0; i < v.Count; i++)
            {
                Write(msg, v[i]);
            }
        }

        public static void Write(Nettention.Proud.Message msg, TrainingStageSlotInfo value)
        {
            msg.Write(value.stageIndex);
            msg.Write(value.stageID);
            Write(msg, value.state);

        }
        public static void Write(Nettention.Proud.Message msg, List<TrainingStageSlotInfo> v)
        {
            msg.WriteScalar(v.Count);
            for (int i = 0; i < v.Count; i++)
            {
                Write(msg, v[i]);
            }
        }
        public static void Write(Nettention.Proud.Message msg, OtherPlayerWeapon value)
        {
            msg.Write(value.weaponSerial);
            msg.Write(value.weaponBaseID);
            msg.Write(value.upgrade);
            msg.Write(value.evolution);
            Write(msg, value.addPassiveSkillList);
            Write(msg, value.addMagicSkill);
            msg.Write(value.defaultOptionValue);
            msg.Write(value.carveHeroGroup);

        }
        public static void Write(Nettention.Proud.Message msg, List<OtherPlayerWeapon> v)
        {
            msg.WriteScalar(v.Count);
            for (int i = 0; i < v.Count; i++)
            {
                Write(msg, v[i]);
            }
        }
        public static void Write(Nettention.Proud.Message msg, OtherPlayerSlotInfo value)
        {
            msg.Write(value.index);
            msg.Write(value.heroID);
            msg.Write(value.skinID);
            msg.Write(value.skinExp);
            msg.Write(value.skinAwaken);
            Write(msg, value.researchList);
            Write(msg, value.equipWeaponList);
            msg.Write(value.skinCostumeGroupID);
            msg.Write(value.weaponCostumeGroupID);
            msg.Write(value.headCostumeGroupID);
            msg.Write(value.isHeadStyleChanged);
            msg.Write(value.skillLevelUpCount);
            msg.Write(value.maxLevelCount);
            msg.Write(value.passiveSkillLevel);
            Write(msg, value.registeredCostumeGroupList);

        }
        public static void Write(Nettention.Proud.Message msg, List<OtherPlayerSlotInfo> v)
        {
            msg.WriteScalar(v.Count);
            for (int i = 0; i < v.Count; i++)
            {
                Write(msg, v[i]);
            }
        }
        public static void Write(Nettention.Proud.Message msg, List<UserCostumeSkin> v)
        {
            msg.WriteScalar(v.Count);
            for (int i = 0; i < v.Count; i++)
            {
                Write(msg, v[i]);
            }
        }
        public static void Write(Nettention.Proud.Message msg, List<UserCostumeWeapon> v)
        {
            msg.WriteScalar(v.Count);
            for (int i = 0; i < v.Count; i++)
            {
                var t1 = new UserCostumeWeapon();
                Write(msg, t1);
            }
        }
        public static void Write(Nettention.Proud.Message msg, List<UserCostumeHead> v)
        {
            msg.WriteScalar(v.Count);
            for (int i = 0; i < v.Count; i++)
            {
                Write(msg, v[i]);
            }
        }


        public static void Write(Nettention.Proud.Message msg, OtherPlayerTeamInfo value)
        {
            msg.Write(value.usn);
            msg.Write(value.foodBuffItemID);
            Write(msg, value.teamSlotList);
            Write(msg, value.fateSlotList);
            Write(msg, value.skinCostumeList);
            Write(msg, value.weaponCostumeList);
            Write(msg, value.headCostumeList);
            Write(msg, value.lobbyBuffItemIDList);
            Write(msg, value.guildSkillUseList);
            msg.Write(value.aiLevel);
            Write(msg, value.playTitleIDList);
        }
        public static void Write(Nettention.Proud.Message msg, TrainingStageInfo value)
        {
            msg.Write(value.remainSecToReset);
            msg.Write(value.remainSecToClose);
            Write(msg, value.stageList);
            msg.Write(value.rewardGauge);
            msg.Write(value.point);
            Write(msg, value.mirrorTeamInfo);
            msg.Write(value.trainingTaskID);
            msg.Write(value.trainingTaskCount);
        }
        public static void Write(Nettention.Proud.Message msg, StageInfo value)
        {
            msg.Write(value.mainStageTopClearID);
            msg.Write(value.anotherMainStageTopClearID);
            Write(msg, value.sideStageClearInfoList);
            Write(msg, value.weeklyStageFirstClearInfoList);
            Write(msg, value.questStageFirstClearInfo);
            Write(msg, value.descentStageFirstClearInfo);
            Write(msg, value.stagePlayCountInfoList);
            Write(msg, value.dayofWeek);
            Write(msg, value.extraStageInfoList);
            msg.Write(value.eventGauge);
            msg.Write(value.goldGauge);
            msg.Write(value.upgradeGauge1);
            msg.Write(value.upgradeGauge2);
            msg.Write(value.upgradeGauge3);
            msg.Write(value.evolutionGauge1);
            msg.Write(value.evolutionGauge2);
            msg.Write(value.evolutionGauge3);
            Write(msg, value.trainingStageInfo);
        }

        public static void Write(Message msg, List<long> v)
        {
            msg.WriteScalar(v.Count);
            for (int i = 0; i < v.Count; i++)
            {
                Write(msg, v[i]);
            }
        }
        public static void Write(Nettention.Proud.Message msg, AttendanceType value)
        {
            msg.Write((byte)value);
        }
        public static void Write(Nettention.Proud.Message msg, ClientSendUserAttendanceInfo value)
        {
            msg.Write(value.isRewardedToday);
            Write(msg, value.attendanceType);
            msg.Write(value.attendanceGroup);
            msg.Write(value.rewardIndex);
            msg.Write(value.welcomeRewardIndex);
            msg.Write(value.comebackMissionEnable);
            msg.Write(value.combackEndRemainSec);
            msg.Write(value.pvpComebackMissionEnable);
            msg.Write(value.pvpCombackEndRemainSec);
            Write(msg, value.lastRewardedType);
            msg.Write(value.lastRewardedGroup);
            msg.Write(value.lastRewardedIndex);

        }
        public static void Write(Nettention.Proud.Message msg, UserPackageInfo value)
        {
            msg.Write(value.packageID);
            msg.Write(value.buyCount);
            Write(msg, value.buyTime);
            Write(msg, value.expireTIme);
            msg.Write(value.remainResetTimeSEC);
            msg.Write(value.rewardValue);
            msg.Write(value.dayCount);
            msg.Write(value.rewardAble);
            msg.Write(value.isExpire);

        }
        public static void Write(Nettention.Proud.Message msg, List<UserPackageInfo> v)
        {
            msg.WriteScalar(v.Count);
            for (int i = 0; i < v.Count; i++)
            {
                Write(msg, v[i]);
            }
        }
        public static void Write(Nettention.Proud.Message msg, ShopBuyInfo value)
        {
            msg.Write(value.serverNoDailyReset);
            msg.Write(value.shopProductID);
            msg.Write(value.basepointID);
            msg.Write(value.buyCount);
            msg.Write(value.freeBuyCount);
            msg.Write(value.startRemainSec);
            msg.Write(value.endRemainSec);

        }
        public static void Write(Nettention.Proud.Message msg, List<ShopBuyInfo> v)
        {
            msg.WriteScalar(v.Count);
            for (int i = 0; i < v.Count; i++)
            {
                Write(msg, v[i]);
            }
        }
        public static void Write(Nettention.Proud.Message msg, CoinShopRotationInfo value)
        {
            msg.Write(value.groupID);
            msg.Write(value.remainSec);
            Write(msg, value.coinShopBuyInfoList);

        }
        public static void Write(Nettention.Proud.Message msg, CoinShopRotationTabInfo value)
        {
            Write(msg, value.platinumCoinTab);
            Write(msg, value.goldCoinTab);
            Write(msg, value.silverCoinTab);
            Write(msg, value.friendCoinTab);

        }
        public static void Write(Nettention.Proud.Message msg, ServerEventType value)
        {
            msg.Write((byte)value);
        }
        public static void Write(Nettention.Proud.Message msg, EventOpenType value)
        {
            msg.Write((byte)value);
        }
        public static void Write(Nettention.Proud.Message msg, ServerEventInfo value)
        {
            msg.Write(value.seq);
            Write(msg, value.eventType);
            msg.Write(value.eventJson);
            msg.Write(value.eventTitle);
            msg.Write(value.eventSubTitle);
            msg.Write(value.imgURL);
            msg.Write(value.linkURL);
            msg.Write(value.priority);
            msg.Write(value.description);
            msg.Write(value.tabNumber);
            msg.Write(value.tabName);
            msg.Write(value.tabPriority);
            msg.Write(value.startRemainSec);
            msg.Write(value.endRemainSec);
            Write(msg, value.toDate);
            Write(msg, value.fromDate);
            Write(msg, value.eventOpenType);
            msg.Write(value.nextOpenReaminSec);
            msg.Write(value.playAbleRemainSec);
            msg.Write(value.timeIndex);
            msg.Write(value.maintenance);
            msg.Write(value.emphasis);

        }
        public static void Write(Nettention.Proud.Message msg, List<ServerEventInfo> v)
        {
            msg.WriteScalar(v.Count);
            for (int i = 0; i < v.Count; i++)
            {
                Write(msg, v[i]);
            }
        }
        public static void Write(Nettention.Proud.Message msg, UserExchangeEventInfo value)
        {
            msg.Write(value.eventSEQ);
            msg.Write(value.exchangeID);
            msg.Write(value.dailyExchangeCount);
            msg.Write(value.totalExchangeCount);
            Write(msg, value.eventType);

        }
        public static void Write(Nettention.Proud.Message msg, List<UserExchangeEventInfo> v)
        {
            msg.WriteScalar(v.Count);
            for (int i = 0; i < v.Count; i++)
            {
                Write(msg, v[i]);
            }
        }
        public static void Write(Nettention.Proud.Message msg, UserWorldAreaStageEventInfo value)
        {
            msg.Write(value.eventSEQ);
            msg.Write(value.regionID);
            msg.Write(value.mainStageID);
            Write(msg, value.sideStageIDList);
            msg.Write(value.freeStageValue);
            msg.Write(value.lastClearStageID);
            msg.Write(value.limitedStageValue);
            msg.Write(value.bossStageValue);

        }
        public static void Write(Nettention.Proud.Message msg, List<UserWorldAreaStageEventInfo> v)
        {
            msg.WriteScalar(v.Count);
            for (int i = 0; i < v.Count; i++)
            {
                Write(msg, v[i]);
            }
        }
        public static void Write(Nettention.Proud.Message msg, UserFreeStageEventInfo value)
        {
            msg.Write(value.eventSEQ);
            msg.Write(value.eventSubIndex);
            msg.Write(value.freeStageValue);
            msg.Write(value.lastClearStageID);

        }
        public static void Write(Nettention.Proud.Message msg, List<UserFreeStageEventInfo> v)
        {
            msg.WriteScalar(v.Count);
            for (int i = 0; i < v.Count; i++)
            {
                Write(msg, v[i]);
            }
        }
        public static void Write(Nettention.Proud.Message msg, UserPlayCountEventInfo value)
        {
            msg.Write(value.eventSEQ);
            msg.Write(value.eventSubIndex);
            msg.Write(value.playCount);
            msg.Write(value.getReward);

        }
        public static void Write(Nettention.Proud.Message msg, List<UserPlayCountEventInfo> v)
        {
            msg.WriteScalar(v.Count);
            for (int i = 0; i < v.Count; i++)
            {
                Write(msg, v[i]);
            }
        }
        public static void Write(Nettention.Proud.Message msg, UserGachaEventInfo value)
        {
            msg.Write(value.eventSEQ);
            msg.Write(value.eventSubIndex);
            msg.Write(value.buyCount);
        }
        public static void Write(Nettention.Proud.Message msg, List<UserGachaEventInfo> v)
        {
            msg.WriteScalar(v.Count);
            for (int i = 0; i < v.Count; i++)
            {
                Write(msg, v[i]);
            }
        }
        public static void Write(Nettention.Proud.Message msg, UserStepupGachaEventInfo value)
        {
            msg.Write(value.eventSEQ);
            msg.Write(value.groupID);
            msg.Write(value.stepNo);
            msg.Write(value.stepCount);
            msg.Write(value.mileage);
            msg.Write(value.mileageReward);
        }
        public static void Write(Nettention.Proud.Message msg, List<UserStepupGachaEventInfo> v)
        {
            msg.WriteScalar(v.Count);
            for (int i = 0; i < v.Count; i++)
            {
                Write(msg, v[i]);
            }
        }
        public static void Write(Nettention.Proud.Message msg, ClientSendEventAttendanceInfo value)
        {
            msg.Write(value.eventSEQ);
            msg.Write(value.eventSubIndex);
            msg.Write(value.lastRewardIndex);
            msg.Write(value.dayFixRewardDay);
            msg.Write(value.isRewardedToday);
        }
        public static void Write(Nettention.Proud.Message msg, List<ClientSendEventAttendanceInfo> v)
        {
            msg.WriteScalar(v.Count);
            for (int i = 0; i < v.Count; i++)
            {
                Write(msg, v[i]);
            }
        }
        public static void Write(Nettention.Proud.Message msg, UserListStageEventInfo value)
        {
            msg.Write(value.eventSEQ);
            msg.Write(value.eventSubIndex);
            msg.Write(value.freeStageValue);
            msg.Write(value.mainStageTopClearID);
            msg.Write(value.lastClearStageID);
        }
        public static void Write(Nettention.Proud.Message msg, List<UserListStageEventInfo> v)
        {
            msg.WriteScalar(v.Count);
            for (int i = 0; i < v.Count; i++)
            {
                Write(msg, v[i]);
            }
        }
        public static void Write(Nettention.Proud.Message msg, UserFinalBossStageEventInfo value)
        {
            msg.Write(value.eventSEQ);
            msg.Write(value.eventSubIndex);
            msg.Write(value.bossStageValue);
            msg.Write(value.mainBossStageTopClearID);
            msg.Write(value.lastClearStageID);
        }
        public static void Write(Nettention.Proud.Message msg, List<UserFinalBossStageEventInfo> v)
        {
            msg.WriteScalar(v.Count);
            for (int i = 0; i < v.Count; i++)
            {
                Write(msg, v[i]);
            }
        }
        public static void Write(Nettention.Proud.Message msg, UserDonationEventInfo value)
        {
            msg.Write(value.eventSEQ);
            msg.Write(value.eventSubIndex);
            msg.Write(value.basepointID);
            msg.Write(value.donationValue);
            msg.Write(value.rewardFlag);
        }
        public static void Write(Nettention.Proud.Message msg, List<UserDonationEventInfo> v)
        {
            msg.WriteScalar(v.Count);
            for (int i = 0; i < v.Count; i++)
            {
                Write(msg, v[i]);
            }
        }
        public static void Write(Nettention.Proud.Message msg, DiaBuyInfo value)
        {
            msg.Write(value.shopMoneyID);
            msg.Write(value.buyCount);
        }
        public static void Write(Nettention.Proud.Message msg, List<DiaBuyInfo> v)
        {
            msg.WriteScalar(v.Count);
            for (int i = 0; i < v.Count; i++)
            {
                Write(msg, v[i]);
            }
        }
        public static void Write(Nettention.Proud.Message msg, UserDiaBuyEventInfo value)
        {
            msg.Write(value.eventSEQ);
            Write(msg, value.diaBuyInfoList);
            msg.Write(value.totalBuyCount);
        }
        public static void Write(Nettention.Proud.Message msg, List<UserDiaBuyEventInfo> v)
        {
            msg.WriteScalar(v.Count);
            for (int i = 0; i < v.Count; i++)
            {
                Write(msg, v[i]);
            }
        }
        public static void Write(Nettention.Proud.Message msg, SeasonPassRankRewardSlotInfo value)
        {
            msg.Write(value.rank);
            msg.Write(value.rewardFlag);
        }
        public static void Write(Nettention.Proud.Message msg, List<SeasonPassRankRewardSlotInfo> v)
        {
            msg.WriteScalar(v.Count);
            for (int i = 0; i < v.Count; i++)
            {
                Write(msg, v[i]);
            }
        }
        public static void Write(Nettention.Proud.Message msg, ClientSeasonPassRankRewardInfo value)
        {
            msg.Write(value.eventSEQ);
            Write(msg, value.eventType);
            msg.Write(value.eventSubIndex);
            msg.Write(value.buySeasonPassPackageID);
            Write(msg, value.rankRewardInfoList);
        }
        public static void Write(Nettention.Proud.Message msg, List<ClientSeasonPassRankRewardInfo> v)
        {
            msg.WriteScalar(v.Count);
            for (int i = 0; i < v.Count; i++)
            {
                Write(msg, v[i]);
            }
        }
        public static void Write(Nettention.Proud.Message msg, UserEventCollaborCoinShopBuyInfo value)
        {
            msg.Write(value.eventSEQ);
            msg.Write(value.eventSubIndex);
            Write(msg, value.buyInfo);
        }
        public static void Write(Nettention.Proud.Message msg, List<UserEventCollaborCoinShopBuyInfo> v)
        {
            msg.WriteScalar(v.Count);
            for (int i = 0; i < v.Count; i++)
            {
                Write(msg, v[i]);
            }
        }
        public static void Write(Nettention.Proud.Message msg, UserPaybackEventInfo value)
        {
            msg.Write(value.eventSEQ);
            msg.Write(value.paybackGroupID);
            msg.Write(value.progress);
            msg.Write(value.rewardID);
        }
        public static void Write(Nettention.Proud.Message msg, List<UserPaybackEventInfo> v)
        {
            msg.WriteScalar(v.Count);
            for (int i = 0; i < v.Count; i++)
            {
                Write(msg, v[i]);
            }
        }
        public static void Write(Nettention.Proud.Message msg, UserGagueEventInfo value)
        {
            msg.Write(value.eventSEQ);
            msg.Write(value.gagueGroupID);
            msg.Write(value.progress);
            msg.Write(value.rewardIndex);
        }
        public static void Write(Nettention.Proud.Message msg, List<UserGagueEventInfo> v)
        {
            msg.WriteScalar(v.Count);
            for (int i = 0; i < v.Count; i++)
            {
                Write(msg, v[i]);
            }
        }
        public static void Write(Nettention.Proud.Message msg, ChallengeBossEventInfoToClientSend value)
        {
            msg.Write(value.eventSEQ);
            msg.Write(value.eventSubIndex);
            Write(msg, value.expireDate);
            msg.Write(value.bossStage);
            msg.Write(value.rewardIndex);
            msg.Write(value.currentEventChallengeBossSeq);
            msg.Write(value.remainSkinUsedSEQResetSec);
            msg.Write(value.currentMissionGroupID);
        }
        public static void Write(Nettention.Proud.Message msg, List<ChallengeBossEventInfoToClientSend> v)
        {
            msg.WriteScalar(v.Count);
            for (int i = 0; i < v.Count; i++)
            {
                Write(msg, v[i]);
            }
        }
        public static void Write(Nettention.Proud.Message msg, UserBingoGachaEventInfo value)
        {
            msg.Write(value.eventSEQ);
            msg.Write(value.eventSubIndex);
            msg.Write(value.reward);
            msg.Write(value.progress);
            Write(msg, value.slotList);
        }
        public static void Write(Nettention.Proud.Message msg, List<UserBingoGachaEventInfo> v)
        {
            msg.WriteScalar(v.Count);
            for (int i = 0; i < v.Count; i++)
            {
                Write(msg, v[i]);
            }
        }
        public static void Write(Nettention.Proud.Message msg, UserGlobalDropEventInfo value)
        {
            msg.Write(value.eventSeq);
            Write(msg, value.globalDropSlotItemCountList);
        }
        public static void Write(Nettention.Proud.Message msg, List<UserGlobalDropEventInfo> v)
        {
            msg.WriteScalar(v.Count);
            for (int i = 0; i < v.Count; i++)
            {
                Write(msg, v[i]);
            }
        }
        public static void Write(Nettention.Proud.Message msg, UserChallengeDestroyEventInfo value)
        {
            msg.Write(value.eventSEQ);
            msg.Write(value.eventSubIndex);
            msg.Write(value.point);
            msg.Write(value.rewardIndex);
            msg.Write(value.isWorldReward);
        }
        public static void Write(Nettention.Proud.Message msg, List<UserChallengeDestroyEventInfo> v)
        {
            msg.WriteScalar(v.Count);
            for (int i = 0; i < v.Count; i++)
            {
                Write(msg, v[i]);
            }
        }
        public static void Write(Nettention.Proud.Message msg, ClientSendTimeMissionEventInfo value)
        {
            msg.Write(value.eventSeq);
            msg.Write(value.remainSec);
        }
        public static void Write(Nettention.Proud.Message msg, List<ClientSendTimeMissionEventInfo> v)
        {
            msg.WriteScalar(v.Count);
            for (int i = 0; i < v.Count; i++)
            {
                Write(msg, v[i]);
            }
        }
        public static void Write(Nettention.Proud.Message msg, ClientSendEventLobbyGiftInfo value)
        {
            msg.Write(value.eventSEQ);
            msg.Write(value.eventSubIndex);
            msg.Write(value.lastRewardIndex);
            msg.Write(value.isRewardedToday);
        }
        public static void Write(Nettention.Proud.Message msg, List<ClientSendEventLobbyGiftInfo> v)
        {
            msg.WriteScalar(v.Count);
            for (int i = 0; i < v.Count; i++)
            {
                Write(msg, v[i]);
            }
        }
        public static void Write(Nettention.Proud.Message msg, UserSnsShareEventInfo value)
        {
            msg.Write(value.eventSEQ);
            msg.Write(value.eventSubIndex);
            msg.Write(value.shareCount);
            msg.Write(value.rewardYN);
        }
        public static void Write(Nettention.Proud.Message msg, List<UserSnsShareEventInfo> v)
        {
            msg.WriteScalar(v.Count);
            for (int i = 0; i < v.Count; i++)
            {
                Write(msg, v[i]);
            }
        }
        public static void Write(Nettention.Proud.Message msg, UserEventLobbyDecorationInfo value)
        {
            msg.Write(value.eventSEQ);
            msg.Write(value.eventSubIndex);
            msg.Write(value.rewardFlag);

        }
        public static void Write(Nettention.Proud.Message msg, List<UserEventLobbyDecorationInfo> v)
        {
            msg.WriteScalar(v.Count);
            for (int i = 0; i < v.Count; i++)
            {
                Write(msg, v[i]);
            }
        }
        public static void Write(Nettention.Proud.Message msg, EventPacketInfo value)
        {
            Write(msg, value.serverEventInfoList);
            Write(msg, value.userExchangeInfoList);
            Write(msg, value.userWorldAreaStageEventInfoList);
            Write(msg, value.userFreeStageEventInfoList);
            Write(msg, value.userPlayCountEventInfoList);
            Write(msg, value.userGachaEventInfoList);
            Write(msg, value.userStepupGachaEventInfoList);
            Write(msg, value.userAttendanceEventInfoList);
            Write(msg, value.userMissionEventInfoList);
            Write(msg, value.userListStageEventInfoList);
            Write(msg, value.userFinalBossStageEventInfoList);
            Write(msg, value.userDonationEventInfoList);
            Write(msg, value.userDiaBuyEventInfoList);
            Write(msg, value.userSeasonPassRankRewardInfoList);
            Write(msg, value.userCollaborationCoinShopBuyInfoList);
            Write(msg, value.userPaybackInfoList);
            Write(msg, value.userGagueEventInfoList);
            Write(msg, value.userChallengeBossEventInfoClientSendList);
            Write(msg, value.userBingGachaEventInfoList);
            Write(msg, value.userGlobalDropEventInfoList);
            Write(msg, value.userChallengeDestroyEventInfoList);
            Write(msg, value.userTimeMissionEventInfoList);
            Write(msg, value.userLobbyGiftEventInfoList);
            Write(msg, value.userSnsShareEventInfoList);
            Write(msg, value.userLobbyDecorationEventInfoList);
        }
        public static void Write(Nettention.Proud.Message msg, LobbyGuestInfo value)
        {
            Write(msg, value.heroGuestIDList);
            msg.Write(value.currentVisitGuestID);
            msg.Write(value.newHeroVisit);
            msg.Write(value.remainHeroVisitTimeSec);
            msg.Write(value.currentVisitGuestIndex);

        }
        public static void Write(Nettention.Proud.Message msg, ADViewContentType value)
        {
            msg.Write((byte)value);
        }
        public static void Write(Nettention.Proud.Message msg, UserADViewInfo value)
        {
            Write(msg, value.adViewContentType);
            msg.Write(value.viewCount);
            msg.Write(value.coolRemainSec);
            msg.Write(value.roulettePoint);
            msg.Write(value.lastViewUnxs);

        }
        public static void Write(Nettention.Proud.Message msg, List<UserADViewInfo> v)
        {
            msg.WriteScalar(v.Count);
            for (int i = 0; i < v.Count; i++)
            {
                Write(msg, v[i]);
            }
        }
        public static void Read(Nettention.Proud.Message msg, out GuildMemberGrade value)
        {
            byte tmp;
            msg.Read(out tmp);
            value = (GuildMemberGrade)tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out UserLoginState value)
        {
            byte tmp;
            msg.Read(out tmp);
            value = (UserLoginState)tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out GuildMemberInfo value)
        {
            GuildMemberInfo tmp = new GuildMemberInfo();
            msg.Read(out tmp.guildSN);
            msg.Read(out tmp.usn);
            Read(msg, out tmp.grade);
            msg.Read(out tmp.nickname);
            msg.Read(out tmp.userExp);
            msg.Read(out tmp.skinID);
            msg.Read(out tmp.remainSecToJoinEnable);
            Read(msg, out tmp.joinEnableTime);
            Read(msg, out tmp.joinTime);
            msg.Read(out tmp.afterLoginMin);
            msg.Read(out tmp.accumdContribution);
            msg.Read(out tmp.weeklyContribution);
            msg.Read(out tmp.prevWeeklyContirbution);
            msg.Read(out tmp.weeklySeq);
            Read(msg, out tmp.loginState);
            Read(msg, out tmp.lastAttendTime);
            msg.Read(out tmp.bTodayAttend);
            msg.Read(out tmp.stageClearCount);
            msg.Read(out tmp.joinTimeWeeklySeq);
            msg.Read(out tmp.playTitleID);
            //Read(msg, out tmp.attendRewardTime);
            //msg.Read(out tmp.netmarblePID);
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out LobbyReddotInfo value)
        {
            LobbyReddotInfo tmp = new LobbyReddotInfo();
            msg.Read(out tmp.mailListCount);
            msg.Read(out tmp.friendMailListCount);
            msg.Read(out tmp.destroyInviteCount);
            msg.Read(out tmp.friendReddot);
            msg.Read(out tmp.friendApplyReddot);
            msg.Read(out tmp.guildReddot);
            msg.Read(out tmp.noticeMailCount);
            msg.Read(out tmp.packageMailCount);
            msg.Read(out tmp.itemGambleShopFreeReddot);
            msg.Read(out tmp.coinDailyShopFreeReddot);
            msg.Read(out tmp.friendlyMatchInviteCount);
            msg.Read(out tmp.realTimePvpRewardAble);
            msg.Read(out tmp.guildReddot1);
            msg.Read(out tmp.guildReddot2);
            msg.Read(out tmp.guildReddot3);
            msg.Read(out tmp.guildAttendableReddot);
            msg.Read(out tmp.guildRankRewardReddot);
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out RedisRankInfo value)
        {
            RedisRankInfo tmp = new RedisRankInfo();
            msg.Read(out tmp.rank);
            msg.Read(out tmp.guildSN);
            msg.Read(out tmp.rankPoint);
            msg.Read(out tmp.totolRankUpCount);
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out GuildJoiningApprovalType value)
        {
            byte tmp;
            msg.Read(out tmp);
            value = (GuildJoiningApprovalType)tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out GuildInfo value)
        {
            GuildInfo tmp = new GuildInfo();
            msg.Read(out tmp.guildSN);
            msg.Read(out tmp.guildName);
            msg.Read(out tmp.guildExp);
            msg.Read(out tmp.masterUSN);
            msg.Read(out tmp.description);
            msg.Read(out tmp.notice);
            msg.Read(out tmp.emblemIconID);
            msg.Read(out tmp.emblemSubIconID);
            msg.Read(out tmp.emblemBgID);
            msg.Read(out tmp.guildPoint);
            msg.Read(out tmp.skillPoint);
            Read(msg, out tmp.joiningApprovalType);
            msg.Read(out tmp.joiningLevelCondition);
            msg.Read(out tmp.memberCount);
            msg.Read(out tmp.applicantCount);
            msg.Read(out tmp.masterName);
            msg.Read(out tmp.attendSeq);
            msg.Read(out tmp.attendCount);
            msg.Read(out tmp.prevAttendCount);
            Read(msg, out tmp.skillUseList);
            /*msg.Read(out tmp.level);
            msg.Read(out tmp.lastGuildMissionResetSeq);
            msg.Read(out tmp.lastGuildMissionResetExp);
            Read(msg, out tmp.languageType);*/
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out ClientSendGuildRankInfo value)
        {
            ClientSendGuildRankInfo tmp = new ClientSendGuildRankInfo();
            Read(msg, out tmp.redisRankInfo);
            Read(msg, out tmp.guildInfo);
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out List<ClientSendGuildRankInfo> v)
        {
            var t = new List<ClientSendGuildRankInfo>();
            int a = 0;
            msg.ReadScalar(ref a); if (a < 1) { v = t; return; }
            for (int i = 0; i < a; i++)
            {
                var t1 = new ClientSendGuildRankInfo();
                Read(msg, out t1);
                t.Add(t1);
            }
            v = t;
        }
        public static void Read(Nettention.Proud.Message msg, out RandomShopSchedule value)
        {
            RandomShopSchedule tmp = new RandomShopSchedule();
            msg.Read(out tmp.basepointID);
            msg.Read(out tmp.openRemainSec);
            msg.Read(out tmp.closeRemainSec);
            Read(msg, out tmp.openDateTime);
            Read(msg, out tmp.closeDateTime);
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out List<RandomShopSchedule> v)
        {
            var t = new List<RandomShopSchedule>();
            int a = 0;
            msg.ReadScalar(ref a); if (a < 1) { v = t; return; }
            for (int i = 0; i < a; i++)
            {
                var t1 = new RandomShopSchedule();
                Read(msg, out t1);
                t.Add(t1);
            }
            v = t;
        }
        public static void Read(Nettention.Proud.Message msg, out LobbyRandomShopInfo value)
        {
            LobbyRandomShopInfo tmp = new LobbyRandomShopInfo();
            msg.Read(out tmp.dailySeq);
            msg.Read(out tmp.visitRewardYN);
            Read(msg, out tmp.remainRandomShopScheduleList);
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out BasePointRefreshInfo value)
        {
            BasePointRefreshInfo tmp = new BasePointRefreshInfo();
            msg.Read(out tmp.isGuildKickOut);
            Read(msg, out tmp.guildMemberInfo);
            Read(msg, out tmp.lobbyReddotInfo);
            Read(msg, out tmp.prevTopGuildRankInfoList);
            Read(msg, out tmp.lobbyRandomShopInfo);
            value = tmp;
        }

        public static void Write(Nettention.Proud.Message msg, UserDailyReset value)
        {
            msg.Write(value.barrelCount);
            msg.Write(value.friendDeleteCount);
            msg.Write(value.floorSearchValue1);
            msg.Write(value.floorSearchValue2);
            msg.Write(value.floorSearchValue3);
            msg.Write(value.floorSearchValue4);
            Write(msg, value.lobbyQuestProgressInfoList);
            Write(msg, value.attendanceInfo);
            Write(msg, value.birthdayGuestIDList);
            msg.Write(value.basepointDailyReward);
            msg.Write(value.cleanTableCount);
            msg.Write(value.serveBeerCount);
            msg.Write(value.playJukeboxCount);
            msg.Write(value.elizabethTouchCount);
            msg.Write(value.hawkAngerCount);
            msg.Write(value.meliodasCookingCount);
            msg.Write(value.barrelFellowCount);
            msg.Write(value.friendPointGainCount);
            msg.Write(value.heroGachaOneDiaCount);
            msg.Write(value.helbramCount);
            msg.Write(value.friendCookingEatCount);
            msg.Write(value.guildDonationCount1);
            msg.Write(value.guildDonationCount2);
            msg.Write(value.guildShopResetCount);
            msg.Write(value.eventExchangeBoxGachaResetCount);
            msg.Write(value.eventGagueChargeFreeCount);
            msg.Write(value.eventGagueChargetPoint);
            msg.Write(value.guildDonationContribution);
            Write(msg, value.stageInfo);
            Write(msg, value.userPackageInfoList);
            Write(msg, value.userDiaShopPackageInfoList);
            Write(msg, value.coinShopRotationInfo);
            Write(msg, value.coinShopDailyBuyInfoList);
            Write(msg, value.guildMissionInfoList);
            Write(msg, value.eventPacketInfo);
            msg.Write(value.inviteSpecialGuestCount);
            msg.Write(value.trainingStageRefreshCount);
            Write(msg, value.lobbyGuestInfo);
            Write(msg, value.userAdViewInfoList);
            Write(msg, value.subdueBossPlayInfoList);

        }
        public static void Write(Nettention.Proud.Message msg, UserRecipeInfo value)
        {
            msg.Write(value.recipeID);
            msg.Write(value.recipeExp);
            msg.Write(value.recipeActive);

        }
        public static void Write(Nettention.Proud.Message msg, List<UserRecipeInfo> v)
        {
            msg.WriteScalar(v.Count);
            for (int i = 0; i < v.Count; i++)
            {
                Write(msg, v[i]);
            }
        }
        public static void Write(Nettention.Proud.Message msg, List<BasePointInfo> v)
        {
            msg.WriteScalar(v.Count);
            for (int i = 0; i < v.Count; i++)
            {
                Write(msg, v[i]);
            }
        }
        public static void Write(Nettention.Proud.Message msg, RandomShopSchedule value)
        {
            msg.Write(value.basepointID);
            msg.Write(value.openRemainSec);
            msg.Write(value.closeRemainSec);
            Write(msg, value.openDateTime);
            Write(msg, value.closeDateTime);
        }

        public static void Write(Message msg, DateTime value)
        {
            msg.Write(value.Ticks);
        }
        public static void Write(Nettention.Proud.Message msg, PvpSeasonHistoryInfo value)
        {
            msg.Write(value.seasonID);
            msg.Write(value.seasonPoint);
            msg.Write(value.seasonRank);
            msg.Write(value.nickname);
            msg.Write(value.userRankExp);
            msg.Write(value.mainSkinID);
            msg.Write(value.costumeSkinGroupID);
            msg.Write(value.costumeWeaponGroupID);
            msg.Write(value.costumeHeadGroupID);
            msg.Write(value.isHelmetOpen);
            msg.Write(value.guildName);
            msg.Write(value.guildIconID);
            msg.Write(value.guildSubIconID);
            msg.Write(value.guildBackgroundID);
        }


        public static void Write(Nettention.Proud.Message msg, List<RandomShopSchedule> v)
        {
            msg.WriteScalar(v.Count);
            for (int i = 0; i < v.Count; i++)
            {
                Write(msg, v[i]);
            }
        }
        public static void Write(Nettention.Proud.Message msg, LobbyRandomShopInfo value)
        {
            msg.Write(value.dailySeq);
            msg.Write(value.visitRewardYN);
            Write(msg, value.remainRandomShopScheduleList);
        }
        public static void Write(Nettention.Proud.Message msg, BasePointRefreshInfo value)
        {
            msg.Write(value.isGuildKickOut);
            Write(msg, value.guildMemberInfo);
            Write(msg, value.lobbyReddotInfo);
            Write(msg, value.prevTopGuildRankInfoList);
            Write(msg, value.lobbyRandomShopInfo);
        }
        public static void Write(Nettention.Proud.Message msg, RedisRankInfo value)
        {
            msg.Write(value.rank);
            msg.Write(value.guildSN);
            msg.Write(value.rankPoint);
            msg.Write(value.totolRankUpCount);
        }
        public static void Write(Nettention.Proud.Message msg, GuildJoiningApprovalType value)
        {
            msg.Write((byte)value);
        }

        public static void Write(Nettention.Proud.Message msg, GuildInfo value)
        {
            msg.Write(value.guildSN);
            msg.Write(value.guildName);
            msg.Write(value.guildExp);
            msg.Write(value.masterUSN);
            msg.Write(value.description);
            msg.Write(value.notice);
            msg.Write(value.emblemIconID);
            msg.Write(value.emblemSubIconID);
            msg.Write(value.emblemBgID);
            msg.Write(value.guildPoint);
            msg.Write(value.skillPoint);
            Write(msg, value.joiningApprovalType);
            msg.Write(value.joiningLevelCondition);
            msg.Write(value.memberCount);
            msg.Write(value.applicantCount);
            msg.Write(value.masterName);
            msg.Write(value.attendSeq);
            msg.Write(value.attendCount);
            msg.Write(value.prevAttendCount);
            Write(msg, value.skillUseList);
            msg.Write(value.level);
            msg.Write(value.lastGuildMissionResetSeq);
            msg.Write(value.lastGuildMissionResetExp);
            Write(msg, value.languageType);
        }
        public static void Write(Nettention.Proud.Message msg, ClientSendGuildRankInfo value)
        {
            Write(msg, value.redisRankInfo);
            Write(msg, value.guildInfo);
        }

        public static void Write(Message msg, List<ClientSendGuildRankInfo> v)
        {
            msg.WriteScalar(v.Count);
            for (int i = 0; i < v.Count; i++)
            {
                Write(msg, v[i]);
            }
        }
        public static void Read(Nettention.Proud.Message msg, out StageMonsterGrade value)
        {
            byte tmp;
            msg.Read(out tmp);
            value = (StageMonsterGrade)tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out StageMonsterInfo value)
        {
            StageMonsterInfo tmp = new StageMonsterInfo();
            //Read(msg, out tmp.privateDropBoxGrade);
            msg.Read(out tmp.monsterID);
            msg.Read(out tmp.bossColumnNumber);
            Read(msg, out tmp.dropBoxGrade);
            Read(msg, out tmp.stageMonsterGrade);
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out List<StageMonsterInfo> v)
        {
            var t = new List<StageMonsterInfo>();
            int a = 0;
            msg.ReadScalar(ref a); if (a < 1) { v = t; return; }
            for (int i = 0; i < a; i++)
            {
                var t1 = new StageMonsterInfo();
                Read(msg, out t1);
                t.Add(t1);
            }
            v = t;
        }
        public static void Read(Nettention.Proud.Message msg, out ClientSendMissionInfo value)
        {
            ClientSendMissionInfo tmp = new ClientSendMissionInfo();
            msg.Read(out tmp.chainID);
            msg.Read(out tmp.rewardChainIndex);
            msg.Read(out tmp.progressValue);
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out List<ClientSendMissionInfo> v)
        {
            var t = new List<ClientSendMissionInfo>();
            int a = 0;
            msg.ReadScalar(ref a); if (a < 1) { v = t; return; }
            for (int i = 0; i < a; i++)
            {
                var t1 = new ClientSendMissionInfo();
                Read(msg, out t1);
                t.Add(t1);
            }
            v = t;
        }
        public static void Read(Nettention.Proud.Message msg, out MissionType value)
        {
            short tmp;
            msg.Read(out tmp);
            value = (MissionType)tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out MarketMissionInfo value)
        {
            MarketMissionInfo tmp = new MarketMissionInfo();
            Read(msg, out tmp.missionType);
            msg.Read(out tmp.missionValue);
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out List<MarketMissionInfo> v)
        {
            var t = new List<MarketMissionInfo>();
            int a = 0;
            msg.ReadScalar(ref a); if (a < 1) { v = t; return; }
            for (int i = 0; i < a; i++)
            {
                var t1 = new MarketMissionInfo();
                Read(msg, out t1);
                t.Add(t1);
            }
            v = t;
        }
        public static void Read(Nettention.Proud.Message msg, out ClientSendEventMissionInfo value)
        {
            ClientSendEventMissionInfo tmp = new ClientSendEventMissionInfo();
            msg.Read(out tmp.eventSeq);
            msg.Read(out tmp.eventSubIndex);
            msg.Read(out tmp.chainID);
            msg.Read(out tmp.rewardChainIndex);
            msg.Read(out tmp.progressValue);
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out List<ClientSendEventMissionInfo> v)
        {
            var t = new List<ClientSendEventMissionInfo>();
            int a = 0;
            msg.ReadScalar(ref a); if (a < 1) { v = t; return; }
            for (int i = 0; i < a; i++)
            {
                var t1 = new ClientSendEventMissionInfo();
                Read(msg, out t1);
                t.Add(t1);
            }
            v = t;
        }
        public static void Read(Nettention.Proud.Message msg, out ClientSendPlayTitleMissionInfo value)
        {
            ClientSendPlayTitleMissionInfo tmp = new ClientSendPlayTitleMissionInfo();
            msg.Read(out tmp.missionID);
            msg.Read(out tmp.progressValue);
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out List<ClientSendPlayTitleMissionInfo> v)
        {
            var t = new List<ClientSendPlayTitleMissionInfo>();
            int a = 0;
            msg.ReadScalar(ref a); if (a < 1) { v = t; return; }
            for (int i = 0; i < a; i++)
            {
                var t1 = new ClientSendPlayTitleMissionInfo();
                Read(msg, out t1);
                t.Add(t1);
            }
            v = t;
        }
        public static void Read(Nettention.Proud.Message msg, out MissionResult value)
        {
            MissionResult tmp = new MissionResult();
            Read(msg, out tmp.userMissionInfoList);
            Read(msg, out tmp.marketMissionInfoList);
            Read(msg, out tmp.eventMissionInfoList);
            Read(msg, out tmp.guildMissionInfoList);
            Read(msg, out tmp.titleMissionInfoList);
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out FoodBuffInfo value)
        {
            FoodBuffInfo tmp = new FoodBuffInfo();
            msg.Read(out tmp.foodItemID);
            msg.Read(out tmp.useCount);
            msg.Read(out tmp.isAutoFoodUse);
            value = tmp;
        }
        public static void Write(Nettention.Proud.Message msg, PaybackEventResultInfo value)
        {
            msg.Write(value.eventSEQ);
            msg.Write(value.paybackGroupID);
            msg.Write(value.addValue);
        }

        public static void Write(Nettention.Proud.Message msg, StageStartResultInfo value)
        {
            msg.Write(value.stageID);
            msg.Write(value.ingameGold);
            msg.Write(value.isGoldManta);
            Write(msg, value.stageMonsterList);
            Write(msg, value.apInfo);
            Write(msg, value.missionResult);
            msg.Write(value.isBuffUsed);
            Write(msg, value.foodBuffInfo);
            Write(msg, value.useItemResultInfo);
            msg.Write(value.isRejoinEnable);
            msg.Write(value.rejoinData);
            msg.Write(value.playKey);
            msg.Write(value.playMode);
            Write(msg, value.questProgressInfoList);
            msg.Write(value.stageIndex);
            Write(msg, value.guildSkillUseList);
        }
        public static void Write(Nettention.Proud.Message msg, StageMonsterGrade value)
        {
            msg.Write((byte)value);
        }
        public static void Write(Nettention.Proud.Message msg, StageMonsterInfo value)
        {
            Write(msg, value.privateDropBoxGrade);
            msg.Write(value.monsterID);
            msg.Write(value.bossColumnNumber);
            Write(msg, value.dropBoxGrade);
            Write(msg, value.stageMonsterGrade);
        }
        public static void Write(Nettention.Proud.Message msg, FriendState value)
        {
            msg.Write((byte)value);
        }
        public static void Write(Nettention.Proud.Message msg, SkinStatInfo value)
        {
            msg.Write(value.attack);
            msg.Write(value.defence);
            msg.Write(value.life);
            msg.Write(value.currentLife);
        }
        public static void Write(Nettention.Proud.Message msg, List<SkinStatInfo> v)
        {
            msg.WriteScalar(v.Count);
            for (int i = 0; i < v.Count; i++)
            {
                Write(msg, v[i]);
            }
        }

        public static void Write(Nettention.Proud.Message msg, StageStartRequestInfo value)
        {
            Write(msg, value.stageID);
            Write(msg, value.mercenaryUSN);
            Write(msg, value.mercenarySkinID);
            Write(msg, value.mercenaryState);
            Write(msg, value.teamIndex);
            Write(msg, value.eventSEQ);
            Write(msg, value.battlePowerPoint);
            Write(msg, value.skinStatInfoList);
            Write(msg, value.stageNpcIDList);
            Write(msg, value.stageIndex);
        }

        public static void Write(Message msg, List<StageMonsterInfo> v)
        {
            msg.WriteScalar(v.Count);
            for (int i = 0; i < v.Count; i++)
            {
                Write(msg, v[i]);
            }
        }
        public static void Write(Nettention.Proud.Message msg, StageClearResultInfo value)
        {
            msg.Write(value.userExp);
            Write(msg, value.apInfo);
            msg.Write(value.isWin);
            Write(msg, value.battleSkinResultInfoList);
            Write(msg, value.npcResultList);
            Write(msg, value.goldItemResultInfo);
            Write(msg, value.ingameItemResultInfoList);
            Write(msg, value.questItemResultInfoList);
            Write(msg, value.firstItemResultInfo);
            Write(msg, value.clearItemResultInfo);
            Write(msg, value.globalDropItemResultInfoList);
            Write(msg, value.gaugeRewardItemResultInfo);
            Write(msg, value.passiveDropItemInfo);
            Write(msg, value.additionalItemResultInfo);
            msg.Write(value.isFirstClear);
            msg.Write(value.playStageID);
            Write(msg, value.stageInfo);
            Write(msg, value.questProgressInfoList);
            Write(msg, value.missionResult);
            Write(msg, value.playCountEventInfoList);
            msg.Write(value.ingameGoldBuffAddValue);
            msg.Write(value.usedFoodID);
            Write(msg, value.updateUserGlobalDropEventInfoList);
            Write(msg, value.adViewRouletteInfo);
        }
        public static void Write(Nettention.Proud.Message msg, BattleSkinResultInfo value)
        {
            msg.Write(value.heroID);
            msg.Write(value.skinID);
            msg.Write(value.skinExp);
            msg.Write(value.skinGetExp);
            msg.Write(value.skinBuffExp);
            msg.Write(value.isBestPlayer);
        }

        public static void Write(Nettention.Proud.Message msg, UserNpcResult value)
        {
            msg.Write(value.guestID);
            msg.Write(value.lovePoint);
        }

        public static void Write(Message msg, List<UserNpcResult> v)
        {
            msg.WriteScalar(v.Count);
            for (int i = 0; i < v.Count; i++)
            {
                Write(msg, v[i]);
            }
        }

        public static void Write(Message msg, List<BattleSkinResultInfo> v)
        {
            msg.WriteScalar(v.Count);
            for (int i = 0; i < v.Count; i++)
            {
                Write(msg, v[i]);
            }
        }

        public static void Read(Nettention.Proud.Message msg, out StageStartResultInfo value)
        {
            StageStartResultInfo tmp = new StageStartResultInfo();
            msg.Read(out tmp.stageID);
            msg.Read(out tmp.ingameGold);
            msg.Read(out tmp.isGoldManta);
            Read(msg, out tmp.stageMonsterList);
            Read(msg, out tmp.apInfo);
            Read(msg, out tmp.missionResult);//
            msg.Read(out tmp.isBuffUsed);
            Read(msg, out tmp.foodBuffInfo);
            Read(msg, out tmp.useItemResultInfo);
            msg.Read(out tmp.isRejoinEnable);
            msg.Read(out tmp.rejoinData);
            msg.Read(out tmp.playKey);
            msg.Read(out tmp.playMode);
            Read(msg, out tmp.questProgressInfoList);
            msg.Read(out tmp.stageIndex);
            Read(msg, out tmp.guildSkillUseList);
            value = tmp;
        }

        public static void Write(Nettention.Proud.Message msg, LobbyReddotInfo value)
        {
            msg.Write(value.mailListCount);
            msg.Write(value.friendMailListCount);
            msg.Write(value.destroyInviteCount);
            msg.Write(value.friendReddot);
            msg.Write(value.friendApplyReddot);
            msg.Write(value.guildReddot);
            msg.Write(value.noticeMailCount);
            msg.Write(value.packageMailCount);
            msg.Write(value.itemGambleShopFreeReddot);
            msg.Write(value.coinDailyShopFreeReddot);
            msg.Write(value.friendlyMatchInviteCount);
            msg.Write(value.realTimePvpRewardAble);
            msg.Write(value.guildReddot1);
            msg.Write(value.guildReddot2);
            msg.Write(value.guildReddot3);
            msg.Write(value.guildAttendableReddot);
            msg.Write(value.guildRankRewardReddot);
        }


        public static void Write(Nettention.Proud.Message msg, EventBasepointInfo value)
        {
            msg.Write(value.eventSeq);
            msg.Write(value.basepointID);
            msg.Write(value.lastClearLoopQuestID);

        }
        public static void Write(Nettention.Proud.Message msg, List<EventBasepointInfo> v)
        {
            msg.WriteScalar(v.Count);
            for (int i = 0; i < v.Count; i++)
            {
                Write(msg, v[i]);
            }
        }
        public static void Write(Nettention.Proud.Message msg, UserBasePointContentsInfo value)
        {
            Write(msg, value.basePointInfoList);
            Write(msg, value.eventBasepointInfoList);
        }
        public static void Write(Nettention.Proud.Message msg, GuildMemberGrade value)
        {
            msg.Write((byte)value);
        }
        public static void Write(Nettention.Proud.Message msg, UserLoginState value)
        {
            msg.Write((byte)value);
        }
        public static void Write(Nettention.Proud.Message msg, GuildMemberInfo value)
        {
            msg.Write(value.guildSN);
            msg.Write(value.usn);
            Write(msg, value.grade);
            msg.Write(value.nickname);
            msg.Write(value.userExp);
            msg.Write(value.skinID);
            msg.Write(value.remainSecToJoinEnable);
            Write(msg, value.joinEnableTime);
            Write(msg, value.joinTime);
            msg.Write(value.afterLoginMin);
            msg.Write(value.accumdContribution);
            msg.Write(value.weeklyContribution);
            msg.Write(value.prevWeeklyContirbution);
            msg.Write(value.weeklySeq);
            Write(msg, value.loginState);
            Write(msg, value.lastAttendTime);
            msg.Write(value.bTodayAttend);
            msg.Write(value.stageClearCount);
            msg.Write(value.joinTimeWeeklySeq);
            msg.Write(value.playTitleID);
            Write(msg, value.attendRewardTime);
            msg.Write(value.netmarblePID);
        }
        public static void Write(Nettention.Proud.Message msg, BillingResCode value)
        {
            msg.Write((byte)value);
        }
        public static void Write(Nettention.Proud.Message msg, BillingResultCode value)
        {
            msg.Write((byte)value);
        }
        public static void Read(Nettention.Proud.Message msg, out PaybackEventResultInfo value)
        {
            PaybackEventResultInfo tmp = new PaybackEventResultInfo();
            msg.Read(out tmp.eventSEQ);
            msg.Read(out tmp.paybackGroupID);
            msg.Read(out tmp.addValue);
            value = tmp;
        }

        public static void Write(Nettention.Proud.Message msg, BillingVerifyResultInfo value)
        {
            Write(msg, value.resCode);
            Write(msg, value.resultCode);
            msg.Write(value.transactionID);
            msg.Write(value.resultString);
            msg.Write(value.isPurchase);
            msg.Write(value.promoFlag);
            msg.Write(value.gppFlag);
        }

        public static void Write(Nettention.Proud.Message msg, DestroyDiscoverInfo value)
        {
            msg.Write(value.region);
            msg.Write(value.discoverCount);
            msg.Write(value.gaugePoint);
            msg.Write(value.pickGroupID);
            msg.Write(value.isClear);
            Write(msg, value.closeDate);
            msg.Write(value.remainSecToClose);
        }
        public static void Write(Nettention.Proud.Message msg, List<DestroyDiscoverInfo> v)
        {
            msg.WriteScalar(v.Count);
            for (int i = 0; i < v.Count; i++)
            {
                Write(msg, v[i]);
            }
        }
        public static void Write(Nettention.Proud.Message msg, TutorialType value)
        {
            msg.Write((byte)value);
        }
        public static void Write(Nettention.Proud.Message msg, TutorialStatus value)
        {
            msg.Write((byte)value);
        }
        public static void Write(Nettention.Proud.Message msg, UserTutorialInfo value)
        {
            Write(msg, value.tutorialType);
            Write(msg, value.tutorialStatus);
            msg.Write(value.tutorialStep);
        }
        public static void Write(Nettention.Proud.Message msg, List<UserTutorialInfo> v)
        {
            msg.WriteScalar(v.Count);
            for (int i = 0; i < v.Count; i++)
            {
                Write(msg, v[i]);
            }
        }
        public static void Write(Nettention.Proud.Message msg, ChatQuickMessageInfo value)
        {
            msg.Write(value.slotNumber);
            msg.Write(value.message);
        }
        public static void Write(Nettention.Proud.Message msg, List<ChatQuickMessageInfo> v)
        {
            msg.WriteScalar(v.Count);
            for (int i = 0; i < v.Count; i++)
            {
                Write(msg, v[i]);
            }
        }
        public static void Write(Nettention.Proud.Message msg, ChatStampBookmarkInfo value)
        {
            msg.Write(value.stampSlot);
            Write(msg, value.stampIDList);
        }
        public static void Write(Nettention.Proud.Message msg, List<ChatStampBookmarkInfo> v)
        {
            msg.WriteScalar(v.Count);
            for (int i = 0; i < v.Count; i++)
            {
                Write(msg, v[i]);
            }
        }
        public static void Write(Nettention.Proud.Message msg, InteractiveChoice value)
        {
            msg.Write((byte)value);
        }
        public static void Write(Nettention.Proud.Message msg, NpcGiftState value)
        {
            msg.Write((byte)value);
        }
        public static void Write(Nettention.Proud.Message msg, UserNpc value)
        {
            Write(msg, value.serverTalkAnswered);
            msg.Write(value.guestID);
            msg.Write(value.giftIndex);
            msg.Write(value.costumeID);
            msg.Write(value.talkCount);
            msg.Write(value.questionID);
            msg.Write(value.goodTalkCount);
            msg.Write(value.lovePoint);
            Write(msg, value.giftState);
        }
        public static void Write(Nettention.Proud.Message msg, List<UserNpc> v)
        {
            msg.WriteScalar(v.Count);
            for (int i = 0; i < v.Count; i++)
            {
                Write(msg, v[i]);
            }
        }
        public static void Write(Nettention.Proud.Message msg, FoodBuffInfo value)
        {
            msg.Write(value.foodItemID);
            msg.Write(value.useCount);
            msg.Write(value.isAutoFoodUse);
        }
        public static void Write(Nettention.Proud.Message msg, DestroyInviteOption value)
        {
            msg.Write((byte)value);
        }
        public static void Write(Nettention.Proud.Message msg, UserBuffType value)
        {
            msg.Write((byte)value);
        }
        public static void Write(Nettention.Proud.Message msg, UserBuffInfo value)
        {
            Write(msg, value.buffType);
            msg.Write(value.targetID);
            msg.Write(value.passiveID);
            msg.Write(value.remainSecToRemove);
        }
        public static void Write(Nettention.Proud.Message msg, List<UserBuffInfo> v)
        {
            msg.WriteScalar(v.Count);
            for (int i = 0; i < v.Count; i++)
            {
                Write(msg, v[i]);
            }
        }
        public static void Write(Nettention.Proud.Message msg, UserHeroGachaGaugeInfo value)
        {
            msg.Write(value.gambleGroup);
            msg.Write(value.eventSeq);
            msg.Write(value.gauge);

        }
        public static void Write(Nettention.Proud.Message msg, List<UserHeroGachaGaugeInfo> v)
        {
            msg.WriteScalar(v.Count);
            for (int i = 0; i < v.Count; i++)
            {
                Write(msg, v[i]);
            }
        }
        public static void Write(Nettention.Proud.Message msg, UserFurniture value)
        {
            msg.Write(value.furnitureGroup);
            msg.Write(value.furnitureID);
            msg.Write(value.buffFurnitureID);

        }
        public static void Write(Nettention.Proud.Message msg, List<UserFurniture> v)
        {
            msg.WriteScalar(v.Count);
            for (int i = 0; i < v.Count; i++)
            {
                Write(msg, v[i]);
            }
        }
        public static void Write(Nettention.Proud.Message msg, FriendInfo value)
        {
            msg.Write(value.friendUSN);
            msg.Write(value.friendNickname);
            msg.Write(value.friendWantToSay);
            msg.Write(value.friendExp);
            msg.Write(value.friendHeroID);
            msg.Write(value.friendSkinID);
            msg.Write(value.friendAfterLoginMin);
            Write(msg, value.friendState);
            Write(msg, value.loginState);
            msg.Write(value.isFriendPointSend);
            msg.Write(value.guildName);
            msg.Write(value.guildIconID);
            msg.Write(value.guildSubIconID);
            msg.Write(value.guildBGIconID);
            msg.Write(value.friendCookingEatAlready);
            msg.Write(value.friendRecipeOrderCount);
            msg.Write(value.playTitleID);
            msg.Write(value.cookingEatDailySeq);
            msg.Write(value.friendCookingEatDailySeq);

        }
        public static void Write(Nettention.Proud.Message msg, List<FriendInfo> v)
        {
            msg.WriteScalar(v.Count);
            for (int i = 0; i < v.Count; i++)
            {
                Write(msg, v[i]);
            }
        }
        public static void Write(Nettention.Proud.Message msg, UserFrozenAsset value)
        {
            msg.Write(value.seq);
            msg.Write(value.contentTypeID);
            Write(msg, value.needItemInfoList);

        }
        public static void Read(Nettention.Proud.Message msg, out StageControlType value)
        {
            byte tmp;
            msg.Read(out tmp);
            value = (StageControlType)tmp;
        }
        public static void Write(Nettention.Proud.Message msg, List<UserFrozenAsset> v)
        {
            msg.WriteScalar(v.Count);
            for (int i = 0; i < v.Count; i++)
            {
                Write(msg, v[i]);
            }
        }
        public static void Write(Nettention.Proud.Message msg, ArenaLeagueGrade value)
        {
            msg.Write((byte)value);
        }
        public static void Write(Nettention.Proud.Message msg, RatingType value)
        {
            msg.Write((byte)value);
        }
        public static void Write(Nettention.Proud.Message msg, WeaponUpgradeFailGaugeInfo value)
        {
            Write(msg, value.rating);
            msg.Write(value.gauge);

        }
        public static void Write(Nettention.Proud.Message msg, List<WeaponUpgradeFailGaugeInfo> v)
        {
            msg.WriteScalar(v.Count);
            for (int i = 0; i < v.Count; i++)
            {
                Write(msg, v[i]);
            }
        }
        public static void Write(Nettention.Proud.Message msg, UserMonthlyStageInfo value)
        {
            msg.Write(value.monthlyID);
            msg.Write(value.lastCountRewardIndex);
            Write(msg, value.lastClearStageIDList);
            msg.Write(value.monthlyRemainSec);

        }
        public static void Write(Nettention.Proud.Message msg, GuildMemberRankPoint value)
        {
            msg.Write(value.difficulty);
            msg.Write(value.seq);
            msg.Write(value.topRankPoint);
            msg.Write(value.accumRankPoint);

        }
        public static void Write(Nettention.Proud.Message msg, List<GuildMemberRankPoint> v)
        {
            msg.WriteScalar(v.Count);
            for (int i = 0; i < v.Count; i++)
            {
                Write(msg, v[i]);
            }
        }
        public static void Write(Nettention.Proud.Message msg, GuildMemberRankPointReward value)
        {
            msg.Write(value.seq);
            msg.Write(value.rewardOrder);

        }
        public static void Write(Nettention.Proud.Message msg, UserMusic value)
        {
            msg.Write(value.index);
            msg.Write(value.name);
            msg.Write(value.tempo);
            msg.Write(value.beat);
            msg.Write(value.code);

        }
        public static void Write(Nettention.Proud.Message msg, List<UserMusic> v)
        {
            msg.WriteScalar(v.Count);
            for (int i = 0; i < v.Count; i++)
            {
                Write(msg, v[i]);
            }
        }
        public static void Write(Nettention.Proud.Message msg, PackageMissionStatus value)
        {
            msg.Write((byte)value);
        }
        public static void Write(Nettention.Proud.Message msg, UserPackageMissionInfo value)
        {
            Write(msg, value.packageBuyExpireDate);
            msg.Write(value.progress);
            msg.Write(value.packageMissionID);
            Write(msg, value.packageMissionStatus);
            msg.Write(value.packageBuyExpireRemainSEC);

        }
        public static void Write(Nettention.Proud.Message msg, List<UserPackageMissionInfo> v)
        {
            msg.WriteScalar(v.Count);
            for (int i = 0; i < v.Count; i++)
            {
                Write(msg, v[i]);
            }
        }
        public static void Write(Nettention.Proud.Message msg, UserFinalBossRankPoint value)
        {
            msg.Write(value.seasonID);
            msg.Write(value.groupID);
            msg.Write(value.topRankPoint);
            Write(msg, value.skinIDList);
            msg.Write(value.rank);
            msg.Write(value.totolRankUpCount);
            msg.Write(value.usn);
            msg.Write(value.rewardYN);
            msg.Write(value.topRankUnxs);

        }
        public static void Write(Nettention.Proud.Message msg, List<UserFinalBossRankPoint> v)
        {
            msg.WriteScalar(v.Count);
            for (int i = 0; i < v.Count; i++)
            {
                Write(msg, v[i]);
            }
        }
        public static void Write(Nettention.Proud.Message msg, ReverseGroupInfo value)
        {
            msg.Write(value.seasonID);
            msg.Write(value.groupID);
            msg.Write(value.firstClearFlag);
            msg.Write(value.missionFlag);

        }
        public static void Write(Nettention.Proud.Message msg, List<ReverseGroupInfo> v)
        {
            msg.WriteScalar(v.Count);
            for (int i = 0; i < v.Count; i++)
            {
                Write(msg, v[i]);
            }
        }
        public static void Write(Nettention.Proud.Message msg, ReverseSeasonInfo value)
        {
            msg.Write(value.seasonID);
            msg.Write(value.starRewardIndex);
            msg.Write(value.groupRewardFlag);
            Write(msg, value.reverseGroupInfoList);
        }
        public static void Write(Nettention.Proud.Message msg, List<ReverseSeasonInfo> v)
        {
            msg.WriteScalar(v.Count);
            for (int i = 0; i < v.Count; i++)
            {
                Write(msg, v[i]);
            }
        }
        public static void Write(Nettention.Proud.Message msg, LoginUserResultInfo value)
        {
            msg.Write(value.usn);
            msg.Write(value.sessionKey);
            msg.Write(value.name);
            msg.Write(value.nicknameChangeCount);
            msg.Write(value.exp);
            msg.Write(value.vipExp);
            Write(msg, value.noticeList);
            Write(msg, value.userHeroList);
            Write(msg, value.userSkinList);
            Write(msg, value.userWeaponList);
            Write(msg, value.userCommonItemList);
            Write(msg, value.extensionData);
            Write(msg, value.userTeamList);
            Write(msg, value.userAPInfoList);
            Write(msg, value.userStageInfo);
            msg.Write(value.userWantToSay);
            msg.Write(value.userMaxFriendCount);
            Write(msg, value.userDailyReset);
            Write(msg, value.userRecipeInfoList);
            Write(msg, value.userBasePointContentsInfo);
            Write(msg, value.autoStartQuestIDList);
            Write(msg, value.userQuestProgressInfoList);
            msg.Write(value.missionAchieveRewardIndex);
            Write(msg, value.userGuildMemberInfo);
            msg.Write(value.userGuildName);
            msg.Write(value.frinedCode);
            msg.Write(value.playingDestroyRoomSN);
            Write(msg, value.userDestroyDiscoverInfoList);
            msg.Write(value.userAgeLevel);
            Write(msg, value.userTutorialInfoList);
            Write(msg, value.userQuickMessageInfoList);
            Write(msg, value.userStampBookmarkInfoList);
            msg.Write(value.rePayFlag);
            Write(msg, value.userNpcList);
            Write(msg, value.platformMissionInfoList);
            Write(msg, value.foodBuffInfo);
            Write(msg, value.destroyInviteOption);
            msg.Write(value.userNicknameChangeAvailableRemainSec);
            Write(msg, value.userCostumeSkin);
            Write(msg, value.userCostumeWeapon);
            Write(msg, value.userCostumeHead);
            Write(msg, value.userPackageInfoList);
            Write(msg, value.userDiaShopPackageInfoList);
            msg.Write(value.mainSkinID);
            msg.Write(value.lobbyUniqueInteractiveFlag);
            msg.Write(value.chapterRewardFlag);
            msg.Write(value.anotherChapterRewardFlag);
            msg.Write(value.loveRewardSeq);
            Write(msg, value.userGuildInfo);
            msg.Write(value.isCheatEnable);
            msg.Write(value.realTimePvpRewardAble);
            Write(msg, value.userBuffInfoList);
            Write(msg, value.userHeroGachaGaugeInfoList);
            msg.Write(value.eventMissionAchieveRewardIndex);
            msg.Write(value.restDayCount);
            msg.Write(value.isPvpLowerClear);
            Write(msg, value.accountCreateTime);
            Write(msg, value.userFurnitureList);
            Write(msg, value.friendInfoList);
            Write(msg, value.userFrozenAssetList);
            Write(msg, value.arenaRealTimePvpGrade);
            Write(msg, value.userWeaponUpgradeFailGaugeList);
            Write(msg, value.monthlyInfo);
            Write(msg, value.eventMissionCompleteRewardInfoList);
            Write(msg, value.guildMemberRankPointList);
            Write(msg, value.guildMemberRankPointReward);
            msg.Write(value.isDecisionPlayAble);
            Write(msg, value.userMusicList);
            msg.Write(value.isGuideListRewarded);
            msg.Write(value.playTitleID);
            msg.Write(value.playMusicID);
            msg.Write(value.musicInstrumentID);
            msg.Write(value.freePackageReward);
            Write(msg, value.userPackageMissionInfoList);
            Write(msg, value.userFinalBossRankPointList);
            Write(msg, value.getPlayTitleList);
            Write(msg, value.reverseSeasonInfoList);
        }

        public static void Write(Message msg, List<int> v)
        {
            msg.WriteScalar(v.Count);
            for (int i = 0; i < v.Count; i++)
            {
                msg.Write(v[i]);
            }
        }

        public static void Write(Nettention.Proud.Message msg, ChannelUserInfo value)
        {
            msg.Write(value.netmarblePlayerID);
            msg.Write(value.usn);
            msg.Write(value.userNickName);
            msg.Write(value.rank);
            msg.Write(value.skinID);
            Write(msg, value.lastLoginTime);
            msg.Write(value.isAdditionalDownloadNeeded);
        }

        public static void Write(Nettention.Proud.Message msg, MaintenanceInfo value)
        {
            msg.Write(value.remainSec);
            msg.Write(value.message);
        }

        public static void Write(Nettention.Proud.Message msg, InvalidRequestType value)
        {
            msg.Write((byte)value);
        }
        public static void Write(Nettention.Proud.Message msg, PacketError value)
        {
            msg.Write((byte)value);
        }


        public static void Read(Nettention.Proud.Message msg, out List<ClientSendEventAttendanceInfo> v)
        {
            var t = new List<ClientSendEventAttendanceInfo>();
            int a = 0;
            msg.ReadScalar(ref a); if (a < 1) { v = t; return; }
            for (int i = 0; i < a; i++)
            {
                var t1 = new ClientSendEventAttendanceInfo();
                Read(msg, out t1);
                t.Add(t1);
            }
            v = t;
        }
        public static void Read(Nettention.Proud.Message msg, out UserListStageEventInfo value)
        {
            UserListStageEventInfo tmp = new UserListStageEventInfo();
            msg.Read(out tmp.eventSEQ);
            msg.Read(out tmp.eventSubIndex);
            msg.Read(out tmp.freeStageValue);
            msg.Read(out tmp.mainStageTopClearID);
            msg.Read(out tmp.lastClearStageID);
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out List<UserListStageEventInfo> v)
        {
            var t = new List<UserListStageEventInfo>();
            int a = 0;
            msg.ReadScalar(ref a); if (a < 1) { v = t; return; }
            for (int i = 0; i < a; i++)
            {
                var t1 = new UserListStageEventInfo();
                Read(msg, out t1);
                t.Add(t1);
            }
            v = t;
        }
        public static void Read(Nettention.Proud.Message msg, out UserFinalBossStageEventInfo value)
        {
            UserFinalBossStageEventInfo tmp = new UserFinalBossStageEventInfo();
            msg.Read(out tmp.eventSEQ);
            msg.Read(out tmp.eventSubIndex);
            msg.Read(out tmp.bossStageValue);
            msg.Read(out tmp.mainBossStageTopClearID);
            msg.Read(out tmp.lastClearStageID);
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out List<UserFinalBossStageEventInfo> v)
        {
            var t = new List<UserFinalBossStageEventInfo>();
            int a = 0;
            msg.ReadScalar(ref a); if (a < 1) { v = t; return; }
            for (int i = 0; i < a; i++)
            {
                var t1 = new UserFinalBossStageEventInfo();
                Read(msg, out t1);
                t.Add(t1);
            }
            v = t;
        }
        public static void Read(Nettention.Proud.Message msg, out UserDonationEventInfo value)
        {
            UserDonationEventInfo tmp = new UserDonationEventInfo();
            msg.Read(out tmp.eventSEQ);
            msg.Read(out tmp.eventSubIndex);
            msg.Read(out tmp.basepointID);
            msg.Read(out tmp.donationValue);
            msg.Read(out tmp.rewardFlag);
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out List<UserDonationEventInfo> v)
        {
            var t = new List<UserDonationEventInfo>();
            int a = 0;
            msg.ReadScalar(ref a); if (a < 1) { v = t; return; }
            for (int i = 0; i < a; i++)
            {
                var t1 = new UserDonationEventInfo();
                Read(msg, out t1);
                t.Add(t1);
            }
            v = t;
        }
        public static void Read(Nettention.Proud.Message msg, out DiaBuyInfo value)
        {
            DiaBuyInfo tmp = new DiaBuyInfo();
            msg.Read(out tmp.shopMoneyID);
            msg.Read(out tmp.buyCount);
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out List<DiaBuyInfo> v)
        {
            var t = new List<DiaBuyInfo>();
            int a = 0;
            msg.ReadScalar(ref a); if (a < 1) { v = t; return; }
            for (int i = 0; i < a; i++)
            {
                var t1 = new DiaBuyInfo();
                Read(msg, out t1);
                t.Add(t1);
            }
            v = t;
        }
        public static void Read(Nettention.Proud.Message msg, out UserDiaBuyEventInfo value)
        {
            UserDiaBuyEventInfo tmp = new UserDiaBuyEventInfo();
            msg.Read(out tmp.eventSEQ);
            Read(msg, out tmp.diaBuyInfoList);
            msg.Read(out tmp.totalBuyCount);
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out List<UserDiaBuyEventInfo> v)
        {
            var t = new List<UserDiaBuyEventInfo>();
            int a = 0;
            msg.ReadScalar(ref a); if (a < 1) { v = t; return; }
            for (int i = 0; i < a; i++)
            {
                var t1 = new UserDiaBuyEventInfo();
                Read(msg, out t1);
                t.Add(t1);
            }
            v = t;
        }
        public static void Read(Nettention.Proud.Message msg, out SeasonPassRankRewardSlotInfo value)
        {
            SeasonPassRankRewardSlotInfo tmp = new SeasonPassRankRewardSlotInfo();
            msg.Read(out tmp.rank);
            msg.Read(out tmp.rewardFlag);
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out List<SeasonPassRankRewardSlotInfo> v)
        {
            var t = new List<SeasonPassRankRewardSlotInfo>();
            int a = 0;
            msg.ReadScalar(ref a); if (a < 1) { v = t; return; }
            for (int i = 0; i < a; i++)
            {
                var t1 = new SeasonPassRankRewardSlotInfo();
                Read(msg, out t1);
                t.Add(t1);
            }
            v = t;
        }
        public static void Read(Nettention.Proud.Message msg, out ClientSeasonPassRankRewardInfo value)
        {
            ClientSeasonPassRankRewardInfo tmp = new ClientSeasonPassRankRewardInfo();
            msg.Read(out tmp.eventSEQ);
            Read(msg, out tmp.eventType);
            msg.Read(out tmp.eventSubIndex);
            msg.Read(out tmp.buySeasonPassPackageID);
            Read(msg, out tmp.rankRewardInfoList);
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out List<ClientSeasonPassRankRewardInfo> v)
        {
            var t = new List<ClientSeasonPassRankRewardInfo>();
            int a = 0;
            msg.ReadScalar(ref a); if (a < 1) { v = t; return; }
            for (int i = 0; i < a; i++)
            {
                var t1 = new ClientSeasonPassRankRewardInfo();
                Read(msg, out t1);
                t.Add(t1);
            }
            v = t;
        }
        public static void Read(Nettention.Proud.Message msg, out UserEventCollaborCoinShopBuyInfo value)
        {
            UserEventCollaborCoinShopBuyInfo tmp = new UserEventCollaborCoinShopBuyInfo();
            msg.Read(out tmp.eventSEQ);
            msg.Read(out tmp.eventSubIndex);
            Read(msg, out tmp.buyInfo);
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out List<UserEventCollaborCoinShopBuyInfo> v)
        {
            var t = new List<UserEventCollaborCoinShopBuyInfo>();
            int a = 0;
            msg.ReadScalar(ref a); if (a < 1) { v = t; return; }
            for (int i = 0; i < a; i++)
            {
                var t1 = new UserEventCollaborCoinShopBuyInfo();
                Read(msg, out t1);
                t.Add(t1);
            }
            v = t;
        }
        public static void Read(Nettention.Proud.Message msg, out UserPaybackEventInfo value)
        {
            UserPaybackEventInfo tmp = new UserPaybackEventInfo();
            msg.Read(out tmp.eventSEQ);
            msg.Read(out tmp.paybackGroupID);
            msg.Read(out tmp.progress);
            msg.Read(out tmp.rewardID);
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out List<UserPaybackEventInfo> v)
        {
            var t = new List<UserPaybackEventInfo>();
            int a = 0;
            msg.ReadScalar(ref a); if (a < 1) { v = t; return; }
            for (int i = 0; i < a; i++)
            {
                var t1 = new UserPaybackEventInfo();
                Read(msg, out t1);
                t.Add(t1);
            }
            v = t;
        }
        public static void Read(Nettention.Proud.Message msg, out UserGagueEventInfo value)
        {
            UserGagueEventInfo tmp = new UserGagueEventInfo();
            msg.Read(out tmp.eventSEQ);
            msg.Read(out tmp.gagueGroupID);
            msg.Read(out tmp.progress);
            msg.Read(out tmp.rewardIndex);
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out List<UserGagueEventInfo> v)
        {
            var t = new List<UserGagueEventInfo>();
            int a = 0;
            msg.ReadScalar(ref a); if (a < 1) { v = t; return; }
            for (int i = 0; i < a; i++)
            {
                var t1 = new UserGagueEventInfo();
                Read(msg, out t1);
                t.Add(t1);
            }
            v = t;
        }
        public static void Read(Nettention.Proud.Message msg, out ChallengeBossEventInfoToClientSend value)
        {
            ChallengeBossEventInfoToClientSend tmp = new ChallengeBossEventInfoToClientSend();
            msg.Read(out tmp.eventSEQ);
            msg.Read(out tmp.eventSubIndex);
            Read(msg, out tmp.expireDate);
            msg.Read(out tmp.bossStage);
            msg.Read(out tmp.rewardIndex);
            msg.Read(out tmp.currentEventChallengeBossSeq);
            msg.Read(out tmp.remainSkinUsedSEQResetSec);
            msg.Read(out tmp.currentMissionGroupID);
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out List<ChallengeBossEventInfoToClientSend> v)
        {
            var t = new List<ChallengeBossEventInfoToClientSend>();
            int a = 0;
            msg.ReadScalar(ref a); if (a < 1) { v = t; return; }
            for (int i = 0; i < a; i++)
            {
                var t1 = new ChallengeBossEventInfoToClientSend();
                Read(msg, out t1);
                t.Add(t1);
            }
            v = t;
        }
        public static void Read(Nettention.Proud.Message msg, out UserBingoGachaEventInfo value)
        {
            UserBingoGachaEventInfo tmp = new UserBingoGachaEventInfo();
            msg.Read(out tmp.eventSEQ);
            msg.Read(out tmp.eventSubIndex);
            msg.Read(out tmp.reward);
            msg.Read(out tmp.progress);
            Read(msg, out tmp.slotList);
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out List<UserBingoGachaEventInfo> v)
        {
            var t = new List<UserBingoGachaEventInfo>();
            int a = 0;
            msg.ReadScalar(ref a); if (a < 1) { v = t; return; }
            for (int i = 0; i < a; i++)
            {
                var t1 = new UserBingoGachaEventInfo();
                Read(msg, out t1);
                t.Add(t1);
            }
            v = t;
        }
        public static void Read(Nettention.Proud.Message msg, out UserGlobalDropEventInfo value)
        {
            UserGlobalDropEventInfo tmp = new UserGlobalDropEventInfo();
            msg.Read(out tmp.eventSeq);
            Read(msg, out tmp.globalDropSlotItemCountList);
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out List<UserGlobalDropEventInfo> v)
        {
            var t = new List<UserGlobalDropEventInfo>();
            int a = 0;
            msg.ReadScalar(ref a); if (a < 1) { v = t; return; }
            for (int i = 0; i < a; i++)
            {
                var t1 = new UserGlobalDropEventInfo();
                Read(msg, out t1);
                t.Add(t1);
            }
            v = t;
        }
        public static void Read(Nettention.Proud.Message msg, out UserChallengeDestroyEventInfo value)
        {
            UserChallengeDestroyEventInfo tmp = new UserChallengeDestroyEventInfo();
            msg.Read(out tmp.eventSEQ);
            msg.Read(out tmp.eventSubIndex);
            msg.Read(out tmp.point);
            msg.Read(out tmp.rewardIndex);
            msg.Read(out tmp.isWorldReward);
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out List<UserChallengeDestroyEventInfo> v)
        {
            var t = new List<UserChallengeDestroyEventInfo>();
            int a = 0;
            msg.ReadScalar(ref a); if (a < 1) { v = t; return; }
            for (int i = 0; i < a; i++)
            {
                var t1 = new UserChallengeDestroyEventInfo();
                Read(msg, out t1);
                t.Add(t1);
            }
            v = t;
        }
        public static void Read(Nettention.Proud.Message msg, out ClientSendTimeMissionEventInfo value)
        {
            ClientSendTimeMissionEventInfo tmp = new ClientSendTimeMissionEventInfo();
            msg.Read(out tmp.eventSeq);
            msg.Read(out tmp.remainSec);
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out List<ClientSendTimeMissionEventInfo> v)
        {
            var t = new List<ClientSendTimeMissionEventInfo>();
            int a = 0;
            msg.ReadScalar(ref a); if (a < 1) { v = t; return; }
            for (int i = 0; i < a; i++)
            {
                var t1 = new ClientSendTimeMissionEventInfo();
                Read(msg, out t1);
                t.Add(t1);
            }
            v = t;
        }
        public static void Read(Nettention.Proud.Message msg, out ClientSendEventLobbyGiftInfo value)
        {
            ClientSendEventLobbyGiftInfo tmp = new ClientSendEventLobbyGiftInfo();
            msg.Read(out tmp.eventSEQ);
            msg.Read(out tmp.eventSubIndex);
            msg.Read(out tmp.lastRewardIndex);
            msg.Read(out tmp.isRewardedToday);
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out List<ClientSendEventLobbyGiftInfo> v)
        {
            var t = new List<ClientSendEventLobbyGiftInfo>();
            int a = 0;
            msg.ReadScalar(ref a); if (a < 1) { v = t; return; }
            for (int i = 0; i < a; i++)
            {
                var t1 = new ClientSendEventLobbyGiftInfo();
                Read(msg, out t1);
                t.Add(t1);
            }
            v = t;
        }
        public static void Read(Nettention.Proud.Message msg, out UserSnsShareEventInfo value)
        {
            UserSnsShareEventInfo tmp = new UserSnsShareEventInfo();
            msg.Read(out tmp.eventSEQ);
            msg.Read(out tmp.eventSubIndex);
            msg.Read(out tmp.shareCount);
            msg.Read(out tmp.rewardYN);
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out List<UserSnsShareEventInfo> v)
        {
            var t = new List<UserSnsShareEventInfo>();
            int a = 0;
            msg.ReadScalar(ref a); if (a < 1) { v = t; return; }
            for (int i = 0; i < a; i++)
            {
                var t1 = new UserSnsShareEventInfo();
                Read(msg, out t1);
                t.Add(t1);
            }
            v = t;
        }
        public static void Read(Nettention.Proud.Message msg, out UserEventLobbyDecorationInfo value)
        {
            UserEventLobbyDecorationInfo tmp = new UserEventLobbyDecorationInfo();
            msg.Read(out tmp.eventSEQ);
            msg.Read(out tmp.eventSubIndex);
            msg.Read(out tmp.rewardFlag);
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out List<UserEventLobbyDecorationInfo> v)
        {
            var t = new List<UserEventLobbyDecorationInfo>();
            int a = 0;
            msg.ReadScalar(ref a); if (a < 1) { v = t; return; }
            for (int i = 0; i < a; i++)
            {
                var t1 = new UserEventLobbyDecorationInfo();
                Read(msg, out t1);
                t.Add(t1);
            }
            v = t;
        }
        public static void Read(Nettention.Proud.Message msg, out UserWeeklyStageEventInfo value)
        {
            UserWeeklyStageEventInfo tmp = new UserWeeklyStageEventInfo();
            msg.Read(out tmp.eventSEQ);
            msg.Read(out tmp.eventSubIndex);
            msg.Read(out tmp.firstWeeklyValue);
            msg.Read(out tmp.lastClearStageID);
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out List<UserWeeklyStageEventInfo> v)
        {
            var t = new List<UserWeeklyStageEventInfo>();
            int a = 0;
            msg.ReadScalar(ref a); if (a < 1) { v = t; return; }
            for (int i = 0; i < a; i++)
            {
                var t1 = new UserWeeklyStageEventInfo();
                Read(msg, out t1);
                t.Add(t1);
            }
            v = t;
        }
        public static void Read(Nettention.Proud.Message msg, out EventPacketInfo value)
        {
            EventPacketInfo tmp = new EventPacketInfo();
            Read(msg, out tmp.serverEventInfoList);//0x2FED
            Read(msg, out tmp.userExchangeInfoList);//0x2FEE
            Read(msg, out tmp.userWorldAreaStageEventInfoList);//0x3020
            Read(msg, out tmp.userFreeStageEventInfoList);//0x3031
            Read(msg, out tmp.userPlayCountEventInfoList);//0x3069
            Read(msg, out tmp.userGachaEventInfoList);//0x306A
            Read(msg, out tmp.userStepupGachaEventInfoList);//0x306B
            Read(msg, out tmp.userAttendanceEventInfoList);//0x306C
            Read(msg, out tmp.userMissionEventInfoList);//0x3315
            Read(msg, out tmp.userListStageEventInfoList);//0x3316
            Read(msg, out tmp.userFinalBossStageEventInfoList);//0x3317
            Read(msg, out tmp.userDonationEventInfoList);//0x3318
            Read(msg, out tmp.userDiaBuyEventInfoList);//0x333B
            Read(msg, out tmp.userSeasonPassRankRewardInfoList);//0x334D
            Read(msg, out tmp.userCollaborationCoinShopBuyInfoList);//0x334E
            Read(msg, out tmp.userPaybackInfoList);//0x334F
            Read(msg, out tmp.userGagueEventInfoList);//0x3350
            Read(msg, out tmp.userChallengeBossEventInfoClientSendList);//0x3351
            Read(msg, out tmp.userBingGachaEventInfoList);//0x3352
            Read(msg, out tmp.userGlobalDropEventInfoList);//0x3353
            Read(msg, out tmp.userChallengeDestroyEventInfoList);//0x3354
            Read(msg, out tmp.userTimeMissionEventInfoList);//0x3355
            Read(msg, out tmp.userLobbyGiftEventInfoList);//0x3356
            Read(msg, out tmp.userSnsShareEventInfoList);//0x3362
            Read(msg, out tmp.userLobbyDecorationEventInfoList);//
            Read(msg, out tmp.userWeeklyStageEventInfoList);//
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out LobbyGuestInfo value)
        {
            LobbyGuestInfo tmp = new LobbyGuestInfo();
            Read(msg, out tmp.heroGuestIDList);
            msg.Read(out tmp.currentVisitGuestID);
            msg.Read(out tmp.newHeroVisit);
            msg.Read(out tmp.remainHeroVisitTimeSec);
            msg.Read(out tmp.currentVisitGuestIndex);
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out ADViewContentType value)
        {
            byte tmp;
            msg.Read(out tmp);
            value = (ADViewContentType)tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out UserADViewInfo value)
        {
            UserADViewInfo tmp = new UserADViewInfo();
            Read(msg, out tmp.adViewContentType);
            msg.Read(out tmp.viewCount);
            msg.Read(out tmp.coolRemainSec);
            msg.Read(out tmp.roulettePoint);
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out List<UserADViewInfo> v)
        {
            var t = new List<UserADViewInfo>();
            int a = 0;
            msg.ReadScalar(ref a); if (a < 1) { v = t; return; }
            for (int i = 0; i < a; i++)
            {
                var t1 = new UserADViewInfo();
                Read(msg, out t1);
                t.Add(t1);
            }
            v = t;
        }
        public static void Read(Nettention.Proud.Message msg, out SubdueBossPlayInfo value)
        {
            SubdueBossPlayInfo tmp = new SubdueBossPlayInfo();
            msg.Read(out tmp.groupID);
            msg.Read(out tmp.playCount);
            msg.Read(out tmp.initRemainSec);
            msg.Read(out tmp.playSeq);
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out List<SubdueBossPlayInfo> v)
        {
            var t = new List<SubdueBossPlayInfo>();
            int a = 0;
            msg.ReadScalar(ref a); if (a < 1) { v = t; return; }
            for (int i = 0; i < a; i++)
            {
                var t1 = new SubdueBossPlayInfo();
                Read(msg, out t1);
                t.Add(t1);
            }
            v = t;
        }
        public static void Read(Nettention.Proud.Message msg, out UserDailyReset value)
        {
            UserDailyReset tmp = new UserDailyReset();
            msg.Read(out tmp.barrelCount);//0xFD8
            msg.Read(out tmp.friendDeleteCount);//0xFD9
            msg.Read(out tmp.floorSearchValue1);//0xFDA
            msg.Read(out tmp.floorSearchValue2);//0xFDB
            msg.Read(out tmp.floorSearchValue3);//0xFDC
            msg.Read(out tmp.floorSearchValue4);//0xFDD
            Read(msg, out tmp.lobbyQuestProgressInfoList);//0xFDE
            Read(msg, out tmp.attendanceInfo);//0xFF0
            Read(msg, out tmp.birthdayGuestIDList);//0xFF1
            msg.Read(out tmp.basepointDailyReward);//0xFF5
            msg.Read(out tmp.cleanTableCount);//0xFF6
            msg.Read(out tmp.serveBeerCount);//0xFF7 ------------------------
            msg.Read(out tmp.playJukeboxCount);//0xFF8
            msg.Read(out tmp.elizabethTouchCount);//0xFF9
            msg.Read(out tmp.hawkAngerCount);//0xFFA
            msg.Read(out tmp.meliodasCookingCount);//0xFFB
            msg.Read(out tmp.barrelFellowCount);//0xFFC
            msg.Read(out tmp.friendPointGainCount);//0x1000
            msg.Read(out tmp.heroGachaOneDiaCount);//0x1001
            msg.Read(out tmp.helbramCount);//0x1002
            msg.Read(out tmp.friendCookingEatCount);//0x1003
            msg.Read(out tmp.guildDonationCount1);//0x1004
            msg.Read(out tmp.guildDonationCount2);//0x1005
            msg.Read(out tmp.guildShopResetCount);//0x1006
            msg.Read(out tmp.eventExchangeBoxGachaResetCount);//0x1007
            msg.Read(out tmp.eventGagueChargeFreeCount);//0x1008
            msg.Read(out tmp.eventGagueChargetPoint);//0x1009
            msg.Read(out tmp.guildDonationContribution);//0x100A
            Read(msg, out tmp.stageInfo); //0x14C2
            Read(msg, out tmp.userPackageInfoList); //0x14C3
            Read(msg, out tmp.userDiaShopPackageInfoList);//0x14C4
            Read(msg, out tmp.coinShopRotationInfo);//0x155E
            Read(msg, out tmp.coinShopDailyBuyInfoList);//0x155F
            Read(msg, out tmp.guildMissionInfoList);//0x1560
            Read(msg, out tmp.eventPacketInfo);//0x3363
            msg.Read(out tmp.inviteSpecialGuestCount);//0x3364
            msg.Read(out tmp.trainingStageRefreshCount);//0x3365
            Read(msg, out tmp.lobbyGuestInfo);//0x337F
            Read(msg, out tmp.userAdViewInfoList);//0x338B <------------------------------- -2?
            Read(msg, out tmp.subdueBossPlayInfoList);//
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out UserRecipeInfo value)
        {
            UserRecipeInfo tmp = new UserRecipeInfo();
            msg.Read(out tmp.recipeID);
            msg.Read(out tmp.recipeExp);
            msg.Read(out tmp.recipeActive);
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out List<UserRecipeInfo> v)
        {
            var t = new List<UserRecipeInfo>();
            int a = 0;
            msg.ReadScalar(ref a); if (a < 1) { v = t; return; }
            for (int i = 0; i < a; i++)
            {
                var t1 = new UserRecipeInfo();
                Read(msg, out t1);
                t.Add(t1);
            }
            v = t;
        }
        public static void Read(Nettention.Proud.Message msg, out BasePointInfo value)
        {
            BasePointInfo tmp = new BasePointInfo();
            msg.Read(out tmp.basePointID);
            msg.Read(out tmp.fellowshipExp);
            msg.Read(out tmp.trigger);
            msg.Read(out tmp.uniqueInteractiveFlag);
            msg.Read(out tmp.lastClearLoopQuestID);
            msg.Read(out tmp.loopRandomQuestID);
            msg.Read(out tmp.overDonationValue);
            Read(msg, out tmp.disableDropInteractiveList);
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out List<BasePointInfo> v)
        {
            var t = new List<BasePointInfo>();
            int a = 0;
            msg.ReadScalar(ref a); if (a < 1) { v = t; return; }
            for (int i = 0; i < a; i++)
            {
                var t1 = new BasePointInfo();
                Read(msg, out t1);
                t.Add(t1);
            }
            v = t;
        }
        public static void Read(Nettention.Proud.Message msg, out EventBasepointInfo value)
        {
            EventBasepointInfo tmp = new EventBasepointInfo();
            msg.Read(out tmp.eventSeq);
            msg.Read(out tmp.basepointID);
            msg.Read(out tmp.lastClearLoopQuestID);
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out List<EventBasepointInfo> v)
        {
            var t = new List<EventBasepointInfo>();
            int a = 0;
            msg.ReadScalar(ref a); if (a < 1) { v = t; return; }
            for (int i = 0; i < a; i++)
            {
                var t1 = new EventBasepointInfo();
                Read(msg, out t1);
                t.Add(t1);
            }
            v = t;
        }
        public static void Read(Nettention.Proud.Message msg, out UserBasePointContentsInfo value)
        {
            UserBasePointContentsInfo tmp = new UserBasePointContentsInfo();
            Read(msg, out tmp.basePointInfoList);
            Read(msg, out tmp.eventBasepointInfoList);
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out DestroyDiscoverInfo value)
        {
            DestroyDiscoverInfo tmp = new DestroyDiscoverInfo();
            msg.Read(out tmp.region);
            msg.Read(out tmp.discoverCount);
            msg.Read(out tmp.gaugePoint);
            msg.Read(out tmp.pickGroupID);
            msg.Read(out tmp.isClear);
            Read(msg, out tmp.closeDate);
            msg.Read(out tmp.remainSecToClose);
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out List<DestroyDiscoverInfo> v)
        {
            var t = new List<DestroyDiscoverInfo>();
            int a = 0;
            msg.ReadScalar(ref a); if (a < 1) { v = t; return; }
            for (int i = 0; i < a; i++)
            {
                var t1 = new DestroyDiscoverInfo();
                Read(msg, out t1);
                t.Add(t1);
            }
            v = t;
        }
        public static void Read(Nettention.Proud.Message msg, out TutorialType value)
        {
            byte tmp;
            msg.Read(out tmp);
            value = (TutorialType)tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out TutorialStatus value)
        {
            byte tmp;
            msg.Read(out tmp);
            value = (TutorialStatus)tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out UserTutorialInfo value)
        {
            UserTutorialInfo tmp = new UserTutorialInfo();
            Read(msg, out tmp.tutorialType);
            Read(msg, out tmp.tutorialStatus);
            msg.Read(out tmp.tutorialStep);
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out List<UserTutorialInfo> v)
        {
            var t = new List<UserTutorialInfo>();
            int a = 0;
            msg.ReadScalar(ref a); if (a < 1) { v = t; return; }
            for (int i = 0; i < a; i++)
            {
                var t1 = new UserTutorialInfo();
                Read(msg, out t1);
                t.Add(t1);
            }
            v = t;
        }
        public static void Read(Nettention.Proud.Message msg, out ChatQuickMessageInfo value)
        {
            ChatQuickMessageInfo tmp = new ChatQuickMessageInfo();
            msg.Read(out tmp.slotNumber);
            msg.Read(out tmp.message);
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out List<ChatQuickMessageInfo> v)
        {
            var t = new List<ChatQuickMessageInfo>();
            int a = 0;
            msg.ReadScalar(ref a); if (a < 1) { v = t; return; }
            for (int i = 0; i < a; i++)
            {
                var t1 = new ChatQuickMessageInfo();
                Read(msg, out t1);
                t.Add(t1);
            }
            v = t;
        }
        public static void Read(Nettention.Proud.Message msg, out ChatStampBookmarkInfo value)
        {
            ChatStampBookmarkInfo tmp = new ChatStampBookmarkInfo();
            msg.Read(out tmp.stampSlot);
            Read(msg, out tmp.stampIDList);
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out List<ChatStampBookmarkInfo> v)
        {
            var t = new List<ChatStampBookmarkInfo>();
            int a = 0;
            msg.ReadScalar(ref a); if (a < 1) { v = t; return; }
            for (int i = 0; i < a; i++)
            {
                var t1 = new ChatStampBookmarkInfo();
                Read(msg, out t1);
                t.Add(t1);
            }
            v = t;
        }
        public static void Read(Nettention.Proud.Message msg, out InteractiveChoice value)
        {
            byte tmp;
            msg.Read(out tmp);
            value = (InteractiveChoice)tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out NpcGiftState value)
        {
            byte tmp;
            msg.Read(out tmp);
            value = (NpcGiftState)tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out UserNpc value)
        {
            UserNpc tmp = new UserNpc();
            //Read(msg, out tmp.serverTalkAnswered);
            msg.Read(out tmp.guestID);
            msg.Read(out tmp.giftIndex);
            msg.Read(out tmp.costumeID);
            msg.Read(out tmp.talkCount);
            msg.Read(out tmp.questionID);
            msg.Read(out tmp.goodTalkCount);
            msg.Read(out tmp.lovePoint);
            Read(msg, out tmp.giftState);
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out List<UserNpc> v)
        {
            var t = new List<UserNpc>();
            int a = 0;
            msg.ReadScalar(ref a); if (a < 1) { v = t; return; }
            for (int i = 0; i < a; i++)
            {
                var t1 = new UserNpc();
                Read(msg, out t1);
                t.Add(t1);
            }
            v = t;
        }
        public static void Read(Nettention.Proud.Message msg, out DestroyInviteOption value)
        {
            byte tmp;
            msg.Read(out tmp);
            value = (DestroyInviteOption)tmp;
        }

        public static void Read(Nettention.Proud.Message msg, out UserBuffType value)
        {
            byte tmp;
            msg.Read(out tmp);
            value = (UserBuffType)tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out FinalBossGroupInfo value)
        {
            FinalBossGroupInfo tmp = new FinalBossGroupInfo();
            msg.Read(out tmp.id);
            msg.Read(out tmp.groupID);
            msg.Read(out tmp.remainActiveStartSec);
            msg.Read(out tmp.remainActiveEndSec);
            msg.Read(out tmp.currentPlayCount);
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out List<FinalBossGroupInfo> v)
        {
            var t = new List<FinalBossGroupInfo>();
            int a = 0;
            msg.ReadScalar(ref a); if (a < 1) { v = t; return; }
            for (int i = 0; i < a; i++)
            {
                var t1 = new FinalBossGroupInfo();
                Read(msg, out t1);
                t.Add(t1);
            }
            v = t;
        }
        public static void Read(Nettention.Proud.Message msg, out FinalBossSeasonInfo value)
        {
            FinalBossSeasonInfo tmp = new FinalBossSeasonInfo();
            msg.Read(out tmp.seasonID);
            msg.Read(out tmp.remainSeasonStartSec);
            msg.Read(out tmp.remainSeasonEndSec);
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out List<FinalBossSeasonInfo> v)
        {
            var t = new List<FinalBossSeasonInfo>();
            int a = 0;
            msg.ReadScalar(ref a); if (a < 1) { v = t; return; }
            for (int i = 0; i < a; i++)
            {
                var t1 = new FinalBossSeasonInfo();
                Read(msg, out t1);
                t.Add(t1);
            }
            v = t;
        }
        public static void Read(Nettention.Proud.Message msg, out FinalBossBattleScoreInfo value)
        {
            FinalBossBattleScoreInfo tmp = new FinalBossBattleScoreInfo();
            msg.Read(out tmp.finalBossScoreGroupID);
            msg.Read(out tmp.missionGroupID);
            msg.Read(out tmp.battleScoreGroupID);
            msg.Read(out tmp.remainSec);
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out NeedItemInfo value)
        {
            NeedItemInfo tmp = new NeedItemInfo();
            msg.Read(out tmp.itemID);
            msg.Read(out tmp.itemCount);
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out List<NeedItemInfo> v)
        {
            var t = new List<NeedItemInfo>();
            int a = 0;
            msg.ReadScalar(ref a); if (a < 1) { v = t; return; }
            for (int i = 0; i < a; i++)
            {
                var t1 = new NeedItemInfo();
                Read(msg, out t1);
                t.Add(t1);
            }
            v = t;
        }
        public static void Read(Nettention.Proud.Message msg, out FinalBossSeasonShopInfo value)
        {
            FinalBossSeasonShopInfo tmp = new FinalBossSeasonShopInfo();
            msg.Read(out tmp.seasonID);
            msg.Read(out tmp.remainSeasonShopStartSec);
            msg.Read(out tmp.remainSeasonShopEndSec);
            Read(msg, out tmp.currentSeasonShopNeedItemList);
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out List<FinalBossSeasonShopInfo> v)
        {
            var t = new List<FinalBossSeasonShopInfo>();
            int a = 0;
            msg.ReadScalar(ref a); if (a < 1) { v = t; return; }
            for (int i = 0; i < a; i++)
            {
                var t1 = new FinalBossSeasonShopInfo();
                Read(msg, out t1);
                t.Add(t1);
            }
            v = t;
        }
        public static void Read(Nettention.Proud.Message msg, out FinalBossSeasonShopBuyInfo value)
        {
            FinalBossSeasonShopBuyInfo tmp = new FinalBossSeasonShopBuyInfo();
            msg.Read(out tmp.seasonID);
            msg.Read(out tmp.productID);
            msg.Read(out tmp.dailyBuyCount);
            msg.Read(out tmp.seasonBuyCount);
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out List<FinalBossSeasonShopBuyInfo> v)
        {
            var t = new List<FinalBossSeasonShopBuyInfo>();
            int a = 0;
            msg.ReadScalar(ref a); if (a < 1) { v = t; return; }
            for (int i = 0; i < a; i++)
            {
                var t1 = new FinalBossSeasonShopBuyInfo();
                Read(msg, out t1);
                t.Add(t1);
            }
            v = t;
        }
        public static void Read(Nettention.Proud.Message msg, out ClientSendFinalBossSeasonShopInfo value)
        {
            ClientSendFinalBossSeasonShopInfo tmp = new ClientSendFinalBossSeasonShopInfo();
            Read(msg, out tmp.finalBossSeasonShopInfoList);
            Read(msg, out tmp.finalBossSeasonShopBuyInfoList);
            value = tmp;
        }

        public static void Read(Nettention.Proud.Message msg, out List<FinalBossBattleScoreInfo> v)
        {
            var t = new List<FinalBossBattleScoreInfo>();
            int a = 0;
            msg.ReadScalar(ref a); if (a < 1) { v = t; return; }
            for (int i = 0; i < a; i++)
            {
                var t1 = new FinalBossBattleScoreInfo();
                Read(msg, out t1);
                t.Add(t1);
            }
            v = t;
        }
        public static void Read(Nettention.Proud.Message msg, out ClientSendFinalBossSeasonInfo value)
        {
            ClientSendFinalBossSeasonInfo tmp = new ClientSendFinalBossSeasonInfo();
            msg.Read(out tmp.currentSeasonID);
            msg.Read(out tmp.currentFinalBossStageFlag);
            Read(msg, out tmp.finalBossGroupInfoList);
            msg.Read(out tmp.remainFinalBossInitSec);
            msg.Read(out tmp.currentFinalBossPointItemCount);
            Read(msg, out tmp.finalBossSeasonInfoList);
            Read(msg, out tmp.finalBossBattleScoreInfoList);
            msg.Read(out tmp.prevSeasonID);
            msg.Read(out tmp.finalBossRankRewardOccured);
            value = tmp;
        }

        public static void Read(Nettention.Proud.Message msg, out LobbyInfo value)
        {
            LobbyInfo tmp = new LobbyInfo();
            Read(msg, out tmp.lobbyVRSearchList);
            Read(msg, out tmp.lobbyReddotInfo);
            Read(msg, out tmp.userNpcInfoList);
            Read(msg, out tmp.guestNPCList);
            msg.Read(out tmp.currentVisitGuestID);
            msg.Read(out tmp.currentVisitGuestIndex);
            msg.Read(out tmp.newHeroVisit);
            msg.Read(out tmp.remainHeroVisitTimeSec);
            msg.Read(out tmp.hawkCollectAble);
            Read(msg, out tmp.eventPacketInfo);
            Read(msg, out tmp.noticeList);
            Read(msg, out tmp.packageBannerInfoList);
            Read(msg, out tmp.disableDropInteractiveList);
            msg.Read(out tmp.isGuildKickOut);
            Read(msg, out tmp.guildMemberInfo);
            Read(msg, out tmp.maintenanceInfo);
            msg.Read(out tmp.remainDailyResetTimeSEC);
            Read(msg, out tmp.questProgressInfoList);
            msg.Read(out tmp.didDailyResetToday);
            Read(msg, out tmp.randomShopInfo);
            Read(msg, out tmp.clientSendFinalBossSeasonInfo);
            Read(msg, out tmp.clientSendFinalBossSeasonShopInfo);
            Read(msg, out tmp.userHeroGachaGaugeInfoList);
            Read(msg, out tmp.currentServerTime);
            msg.Read(out tmp.userAgeLevel);
            Read(msg, out tmp.monthlyInfo);
            msg.Read(out tmp.gaugeEventFreeChargeAble);
            msg.Read(out tmp.currentSeasonGroup);
            Read(msg, out tmp.tournamentDiplayInfoList);
            Read(msg, out tmp.userAdViewInfoList);
            Read(msg, out tmp.clientSendBossWarInfo);
            Read(msg, out tmp.arenaRealTimePvpLowGrade);
            msg.Read(out tmp.arenaRealTimePvpLowGradeNumber);
            Read(msg, out tmp.updateUserFurnitureList);
            msg.Read(out tmp.firstDiaBuy);
            msg.Read(out tmp.isGuildWarRejoinInfoExists);
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out PackageBannerInfo value)
        {
            PackageBannerInfo tmp = new PackageBannerInfo();
            msg.Read(out tmp.packageID);
            msg.Read(out tmp.priority);
            msg.Read(out tmp.packageImageUrl);
            value = tmp;
        }

        public static void Read(Message msg, out List<PackageBannerInfo> v)
        {
            var t = new List<PackageBannerInfo>();
            int a = 0;
            msg.ReadScalar(ref a); if (a < 1) { v = t; return; }
            for (int i = 0; i < a; i++)
            {
                var t1 = new PackageBannerInfo();
                Read(msg, out t1);
                t.Add(t1);
            }
            v = t;
        }
        public static void Read(Nettention.Proud.Message msg, out TournamentDisplayInfo value)
        {
            TournamentDisplayInfo tmp = new TournamentDisplayInfo();
            msg.Read(out tmp.SEQ);
            msg.Read(out tmp.title);
            msg.Read(out tmp.bannerURL);
            msg.Read(out tmp.contents);
            msg.Read(out tmp.rewardGroupID);
            msg.Read(out tmp.isWeaponUse);
            msg.Read(out tmp.damageRate);
            msg.Read(out tmp.damageIncRate);
            Read(msg, out tmp.startTime);
            Read(msg, out tmp.endTime);
            msg.Read(out tmp.startRemainSec);
            msg.Read(out tmp.endRemainSec);
            msg.Read(out tmp.isPlayer);
            Read(msg, out tmp.tournamentState);
            msg.Read(out tmp.stateRemainSec);
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out TournamentState value)
        {
            byte tmp;
            msg.Read(out tmp);
            value = (TournamentState)tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out ClientSendBossWarInfo value)
        {
            ClientSendBossWarInfo tmp = new ClientSendBossWarInfo();
            Read(msg, out tmp.bossWarInfoList);
            Read(msg, out tmp.subdueBossPlayInfoList);
            value = tmp;
        }

        public static void Read(Message msg, out List<BossWarGroupInfo> v)
        {
            var t = new List<BossWarGroupInfo>();
            int a = 0;
            msg.ReadScalar(ref a); if (a < 1) { v = t; return; }
            for (int i = 0; i < a; i++)
            {
                var t1 = new BossWarGroupInfo();
                Read(msg, out t1);
                t.Add(t1);
            }
            v = t;
        }
        public static void Read(Nettention.Proud.Message msg, out BossWarGroupInfo value)
        {
            BossWarGroupInfo tmp = new BossWarGroupInfo();
            msg.Read(out tmp.groupID);
            msg.Read(out tmp.remainEndSec);
            value = tmp;
        }

        public static void Read(Message msg, out List<TournamentDisplayInfo> v)
        {
            var t = new List<TournamentDisplayInfo>();
            int a = 0;
            msg.ReadScalar(ref a); if (a < 1) { v = t; return; }
            for (int i = 0; i < a; i++)
            {
                var t1 = new TournamentDisplayInfo();
                Read(msg, out t1);
                t.Add(t1);
            }
            v = t;
        }

        public static void Read(Nettention.Proud.Message msg, out UserBuffInfo value)
        {
            UserBuffInfo tmp = new UserBuffInfo();
            Read(msg, out tmp.buffType);
            msg.Read(out tmp.targetID);
            msg.Read(out tmp.passiveID);
            msg.Read(out tmp.remainSecToRemove);
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out List<UserBuffInfo> v)
        {
            var t = new List<UserBuffInfo>();
            int a = 0;
            msg.ReadScalar(ref a); if (a < 1) { v = t; return; }
            for (int i = 0; i < a; i++)
            {
                var t1 = new UserBuffInfo();
                Read(msg, out t1);
                t.Add(t1);
            }
            v = t;
        }
        public static void Read(Nettention.Proud.Message msg, out UserHeroGachaGaugeInfo value)
        {
            UserHeroGachaGaugeInfo tmp = new UserHeroGachaGaugeInfo();
            msg.Read(out tmp.gambleGroup);
            msg.Read(out tmp.eventSeq);
            msg.Read(out tmp.gauge);
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out List<UserHeroGachaGaugeInfo> v)
        {
            var t = new List<UserHeroGachaGaugeInfo>();
            int a = 0;
            msg.ReadScalar(ref a); if (a < 1) { v = t; return; }
            for (int i = 0; i < a; i++)
            {
                var t1 = new UserHeroGachaGaugeInfo();
                Read(msg, out t1);
                t.Add(t1);
            }
            v = t;
        }
        public static void Read(Nettention.Proud.Message msg, out UserFurniture value)
        {
            UserFurniture tmp = new UserFurniture();
            msg.Read(out tmp.furnitureGroup);
            msg.Read(out tmp.furnitureID);
            msg.Read(out tmp.buffFurnitureID);
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out List<UserFurniture> v)
        {
            var t = new List<UserFurniture>();
            int a = 0;
            msg.ReadScalar(ref a); if (a < 1) { v = t; return; }
            for (int i = 0; i < a; i++)
            {
                var t1 = new UserFurniture();
                Read(msg, out t1);
                t.Add(t1);
            }
            v = t;
        }
        public static void Read(Nettention.Proud.Message msg, out FriendState value)
        {
            byte tmp;
            msg.Read(out tmp);
            value = (FriendState)tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out FriendInfo value)
        {
            FriendInfo tmp = new FriendInfo();
            msg.Read(out tmp.friendUSN);
            msg.Read(out tmp.friendNickname);
            msg.Read(out tmp.friendWantToSay);
            msg.Read(out tmp.friendExp);
            msg.Read(out tmp.friendHeroID);
            msg.Read(out tmp.friendSkinID);
            msg.Read(out tmp.friendAfterLoginMin);
            Read(msg, out tmp.friendState);
            Read(msg, out tmp.loginState);
            msg.Read(out tmp.isFriendPointSend);
            msg.Read(out tmp.guildName);
            msg.Read(out tmp.guildIconID);
            msg.Read(out tmp.guildSubIconID);
            msg.Read(out tmp.guildBGIconID);
            msg.Read(out tmp.friendCookingEatAlready);
            msg.Read(out tmp.friendRecipeOrderCount);
            msg.Read(out tmp.playTitleID);
            msg.Read(out tmp.cookingEatDailySeq);
            msg.Read(out tmp.friendCookingEatDailySeq);
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out List<FriendInfo> v)
        {
            var t = new List<FriendInfo>();
            int a = 0;
            msg.ReadScalar(ref a); if (a < 1) { v = t; return; }
            for (int i = 0; i < a; i++)
            {
                var t1 = new FriendInfo();
                Read(msg, out t1);
                t.Add(t1);
            }
            v = t;
        }
        public static void Read(Nettention.Proud.Message msg, out UserFrozenAsset value)
        {
            UserFrozenAsset tmp = new UserFrozenAsset();
            msg.Read(out tmp.seq);
            msg.Read(out tmp.contentTypeID);
            Read(msg, out tmp.needItemInfoList);
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out List<UserFrozenAsset> v)
        {
            var t = new List<UserFrozenAsset>();
            int a = 0;
            msg.ReadScalar(ref a); if (a < 1) { v = t; return; }
            for (int i = 0; i < a; i++)
            {
                var t1 = new UserFrozenAsset();
                Read(msg, out t1);
                t.Add(t1);
            }
            v = t;
        }
        public static void Read(Nettention.Proud.Message msg, out ClientDeviceType value)
        {
            byte tmp;
            msg.Read(out tmp);
            value = (ClientDeviceType)tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out ChannelUserInfo value)
        {
            ChannelUserInfo tmp = new ChannelUserInfo();
            msg.Read(out tmp.netmarblePlayerID);
            msg.Read(out tmp.usn);
            msg.Read(out tmp.userNickName);
            msg.Read(out tmp.rank);
            msg.Read(out tmp.skinID);
            Read(msg, out tmp.lastLoginTime);
            msg.Read(out tmp.isAdditionalDownloadNeeded);
            value = tmp;
        }

        public static void Read(Nettention.Proud.Message msg, out VersionInfo value)
        {
            VersionInfo tmp = new VersionInfo();
            msg.Read(out tmp.clientVersion);
            msg.Read(out tmp.cdnVersion);
            value = tmp;
        }

        public static void Read(Nettention.Proud.Message msg, out ArenaLeagueGrade value)
        {
            byte tmp;
            msg.Read(out tmp);
            value = (ArenaLeagueGrade)tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out RatingType value)
        {
            byte tmp;
            msg.Read(out tmp);
            value = (RatingType)tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out WeaponUpgradeFailGaugeInfo value)
        {
            WeaponUpgradeFailGaugeInfo tmp = new WeaponUpgradeFailGaugeInfo();
            Read(msg, out tmp.rating);
            msg.Read(out tmp.gauge);
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out List<WeaponUpgradeFailGaugeInfo> v)
        {
            var t = new List<WeaponUpgradeFailGaugeInfo>();
            int a = 0;
            msg.ReadScalar(ref a); if (a < 1) { v = t; return; }
            for (int i = 0; i < a; i++)
            {
                var t1 = new WeaponUpgradeFailGaugeInfo();
                Read(msg, out t1);
                t.Add(t1);
            }
            v = t;
        }
        public static void Read(Nettention.Proud.Message msg, out UserMonthlyStageInfo value)
        {
            UserMonthlyStageInfo tmp = new UserMonthlyStageInfo();
            msg.Read(out tmp.monthlyID);
            msg.Read(out tmp.lastCountRewardIndex);
            Read(msg, out tmp.lastClearStageIDList);
            msg.Read(out tmp.monthlyRemainSec);
            value = tmp;
        }

        public static void Read(Message msg, out List<int> v)
        {
            var t = new List<int>();
            int a = 0;
            msg.ReadScalar(ref a); if (a < 1) { v = t; return; }
            for (int i = 0; i < a; i++)
            {
                int t1;
                msg.Read(out t1);
                t.Add(t1);
            }
            v = t;
        }

        public static void Read(Nettention.Proud.Message msg, out GuildMemberRankPoint value)
        {
            GuildMemberRankPoint tmp = new GuildMemberRankPoint();
            msg.Read(out tmp.difficulty);
            msg.Read(out tmp.seq);
            msg.Read(out tmp.topRankPoint);
            msg.Read(out tmp.accumRankPoint);
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out List<GuildMemberRankPoint> v)
        {
            var t = new List<GuildMemberRankPoint>();
            int a = 0;
            msg.ReadScalar(ref a); if (a < 1) { v = t; return; }
            for (int i = 0; i < a; i++)
            {
                var t1 = new GuildMemberRankPoint();
                Read(msg, out t1);
                t.Add(t1);
            }
            v = t;
        }
        public static void Read(Nettention.Proud.Message msg, out GuildMemberRankPointReward value)
        {
            GuildMemberRankPointReward tmp = new GuildMemberRankPointReward();
            msg.Read(out tmp.seq);
            msg.Read(out tmp.rewardOrder);
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out UserMusic value)
        {
            UserMusic tmp = new UserMusic();
            msg.Read(out tmp.index);
            msg.Read(out tmp.name);
            msg.Read(out tmp.tempo);
            msg.Read(out tmp.beat);
            msg.Read(out tmp.code);
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out List<UserMusic> v)
        {
            var t = new List<UserMusic>();
            int a = 0;
            msg.ReadScalar(ref a); if (a < 1) { v = t; return; }
            for (int i = 0; i < a; i++)
            {
                var t1 = new UserMusic();
                Read(msg, out t1);
                t.Add(t1);
            }
            v = t;
        }
        public static void Read(Nettention.Proud.Message msg, out PackageMissionStatus value)
        {
            byte tmp;
            msg.Read(out tmp);
            value = (PackageMissionStatus)tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out UserPackageMissionInfo value)
        {
            UserPackageMissionInfo tmp = new UserPackageMissionInfo();
            /*Read(msg, out tmp.packageBuyExpireDate);
            msg.Read(out tmp.progress);*/
            msg.Read(out tmp.packageMissionID);
            Read(msg, out tmp.packageMissionStatus);
            msg.Read(out tmp.packageBuyExpireRemainSEC);
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out List<UserPackageMissionInfo> v)
        {
            var t = new List<UserPackageMissionInfo>();
            int a = 0;
            msg.ReadScalar(ref a); if (a < 1) { v = t; return; }
            for (int i = 0; i < a; i++)
            {
                var t1 = new UserPackageMissionInfo();
                Read(msg, out t1);
                t.Add(t1);
            }
            v = t;
        }
        public static void Read(Nettention.Proud.Message msg, out UserFinalBossRankPoint value)
        {
            UserFinalBossRankPoint tmp = new UserFinalBossRankPoint();
            msg.Read(out tmp.seasonID);
            msg.Read(out tmp.groupID);
            msg.Read(out tmp.topRankPoint);
            Read(msg, out tmp.skinIDList);
            msg.Read(out tmp.rank);
            msg.Read(out tmp.totolRankUpCount);
            /*msg.Read(out tmp.usn);
            msg.Read(out tmp.rewardYN);
            msg.Read(out tmp.topRankUnxs);*/
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out List<UserFinalBossRankPoint> v)
        {
            var t = new List<UserFinalBossRankPoint>();
            int a = 0;
            msg.ReadScalar(ref a); if (a < 1) { v = t; return; }
            for (int i = 0; i < a; i++)
            {
                var t1 = new UserFinalBossRankPoint();
                Read(msg, out t1);
                t.Add(t1);
            }
            v = t;
        }
        public static void Read(Nettention.Proud.Message msg, out ReverseGroupInfo value)
        {
            ReverseGroupInfo tmp = new ReverseGroupInfo();
            msg.Read(out tmp.seasonID);
            msg.Read(out tmp.groupID);
            msg.Read(out tmp.firstClearFlag);
            msg.Read(out tmp.missionFlag);
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out List<ReverseGroupInfo> v)
        {
            var t = new List<ReverseGroupInfo>();
            int a = 0;
            msg.ReadScalar(ref a); if (a < 1) { v = t; return; }
            for (int i = 0; i < a; i++)
            {
                var t1 = new ReverseGroupInfo();
                Read(msg, out t1);
                t.Add(t1);
            }
            v = t;
        }
        public static void Read(Nettention.Proud.Message msg, out ReverseSeasonInfo value)
        {
            ReverseSeasonInfo tmp = new ReverseSeasonInfo();
            msg.Read(out tmp.seasonID);
            msg.Read(out tmp.starRewardIndex);
            msg.Read(out tmp.groupRewardFlag);
            Read(msg, out tmp.reverseGroupInfoList);
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out List<ReverseSeasonInfo> v)
        {
            var t = new List<ReverseSeasonInfo>();
            int a = 0;
            msg.ReadScalar(ref a); if (a < 1) { v = t; return; }
            for (int i = 0; i < a; i++)
            {
                var t1 = new ReverseSeasonInfo();
                Read(msg, out t1);
                t.Add(t1);
            }
            v = t;
        }
        public static void Read(Nettention.Proud.Message msg, out List<OtherPlayerTeamInfo> v)
        {
            var t = new List<OtherPlayerTeamInfo>();
            int a = 0;
            msg.ReadScalar(ref a);
            for (int i = 0; i < a; i++)
            {
                var t1 = new OtherPlayerTeamInfo();
                Read(msg, out t1);
                t.Add(t1);
            }
            v = t;
        }
        public static void Read(Nettention.Proud.Message msg, out List<GuildMemberInfo> v)
        {
            var t = new List<GuildMemberInfo>();
            int a = 0;
            msg.ReadScalar(ref a);
            for (int i = 0; i < a; i++)
            {
                var t1 = new GuildMemberInfo();
                Read(msg, out t1);
                t.Add(t1);
            }
            v = t;
        }
        public static void Read(Nettention.Proud.Message msg, out LoginUserResultInfo value)
        {
            LoginUserResultInfo tmp = new LoginUserResultInfo();
            msg.Read(out tmp.usn);
            msg.Read(out tmp.sessionKey);
            msg.Read(out tmp.name);
            msg.Read(out tmp.nicknameChangeCount);
            msg.Read(out tmp.exp);
            msg.Read(out tmp.vipExp);
            Read(msg, out tmp.noticeList);
            Read(msg, out tmp.userHeroList);
            Read(msg, out tmp.userSkinList);
            Read(msg, out tmp.userWeaponList);
            Read(msg, out tmp.userCommonItemList);
            Read(msg, out tmp.extensionData);
            Read(msg, out tmp.userTeamList);
            Read(msg, out tmp.arenaRankingDefenceTeamInfo);
            Read(msg, out tmp.arenaSmashDefenceTeamInfoList);
            Read(msg, out tmp.userAPInfoList);
            Read(msg, out tmp.userStageInfo);
            msg.Read(out tmp.userWantToSay);
            msg.Read(out tmp.userMaxFriendCount);
            Read(msg, out tmp.userDailyReset);
            Read(msg, out tmp.userRecipeInfoList);
            Read(msg, out tmp.userBasePointContentsInfo);
            Read(msg, out tmp.autoStartQuestIDList);
            Read(msg, out tmp.userQuestProgressInfoList);
            msg.Read(out tmp.missionAchieveRewardIndex);
            Read(msg, out tmp.userGuildMemberInfo);
            msg.Read(out tmp.userGuildName);
            msg.Read(out tmp.frinedCode);
            msg.Read(out tmp.playingDestroyRoomSN);
            Read(msg, out tmp.userDestroyDiscoverInfoList);
            msg.Read(out tmp.userAgeLevel);
            Read(msg, out tmp.userTutorialInfoList);
            Read(msg, out tmp.userQuickMessageInfoList);
            Read(msg, out tmp.userStampBookmarkInfoList);
            msg.Read(out tmp.rePayFlag);
            Read(msg, out tmp.userNpcList);
            Read(msg, out tmp.platformMissionInfoList);
            Read(msg, out tmp.foodBuffInfo);
            Read(msg, out tmp.destroyInviteOption);
            msg.Read(out tmp.userNicknameChangeAvailableRemainSec);
            Read(msg, out tmp.userCostumeSkin);
            Read(msg, out tmp.userCostumeWeapon);
            Read(msg, out tmp.userCostumeHead);
            Read(msg, out tmp.userPackageInfoList);
            Read(msg, out tmp.userDiaShopPackageInfoList);
            msg.Read(out tmp.mainSkinID);
            msg.Read(out tmp.lobbyUniqueInteractiveFlag);
            msg.Read(out tmp.chapterRewardFlag);
            msg.Read(out tmp.anotherChapterRewardFlag);
            msg.Read(out tmp.loveRewardSeq);
            Read(msg, out tmp.userGuildInfo);
            Read(msg, out tmp.guildMemberInfoList);
            msg.Read(out tmp.isCheatEnable);
            msg.Read(out tmp.realTimePvpRewardAble);
            Read(msg, out tmp.userBuffInfoList);
            Read(msg, out tmp.userHeroGachaGaugeInfoList);
            msg.Read(out tmp.eventMissionAchieveRewardIndex);
            msg.Read(out tmp.restDayCount);
            msg.Read(out tmp.isPvpLowerClear);
            Read(msg, out tmp.accountCreateTime);
            Read(msg, out tmp.userFurnitureList);
            Read(msg, out tmp.friendInfoList);
            Read(msg, out tmp.userFrozenAssetList);
            Read(msg, out tmp.arenaRealTimePvpGrade);
            Read(msg, out tmp.userWeaponUpgradeFailGaugeList);
            Read(msg, out tmp.monthlyInfo);
            Read(msg, out tmp.eventMissionCompleteRewardInfoList);
            Read(msg, out tmp.guildMemberRankPointList);
            Read(msg, out tmp.guildMemberRankPointReward);
            msg.Read(out tmp.isDecisionPlayAble);
            Read(msg, out tmp.userMusicList);
            msg.Read(out tmp.isGuideListRewarded);
            msg.Read(out tmp.playTitleID);
            msg.Read(out tmp.playMusicID);
            msg.Read(out tmp.musicInstrumentID);
            msg.Read(out tmp.freePackageReward);
            Read(msg, out tmp.userPackageMissionInfoList);
            Read(msg, out tmp.userFinalBossRankPointList);
            Read(msg, out tmp.getPlayTitleList);
            Read(msg, out tmp.reverseSeasonInfoList);
            Read(msg, out tmp.guildWarUserSquadInfo);
            Read(msg, out tmp.destroyDisasterInfo);
            Read(msg, out tmp.userEventBingoInfo);
            Read(msg, out tmp.userStageTicketClearInfoList);
            Read(msg, out tmp.arenaSmashLobbyInfo);
            Read(msg, out tmp.heroPassiveGroupInfoList);
            Read(msg, out tmp.guildWarDefenceTeamInfoList);
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out GuildWarDefenceTeamInfo value)
        {
            GuildWarDefenceTeamInfo tmp = new GuildWarDefenceTeamInfo();
            msg.Read(out tmp.guildSN);
            msg.Read(out tmp.usn);
            msg.Read(out tmp.teamIndex);
            Read(msg, out tmp.otherPlayerTeamInfo);
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out List<GuildWarDefenceTeamInfo> v)
        {
            var t = new List<GuildWarDefenceTeamInfo>();
            int a = 0;
            msg.ReadScalar(ref a);
            for (int i = 0; i < a; i++)
            {
                var t1 = new GuildWarDefenceTeamInfo();
                Read(msg, out t1);
                t.Add(t1);
            }
            v = t;
        }
        public static void Read(Nettention.Proud.Message msg, out UserHeroPassiveGroupInfo value)
        {
            UserHeroPassiveGroupInfo tmp = new UserHeroPassiveGroupInfo();
            msg.Read(out tmp.heroPassiveGroup);
            msg.Read(out tmp.dailyUseCount);
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out List<UserHeroPassiveGroupInfo> v)
        {
            var t = new List<UserHeroPassiveGroupInfo>();
            int a = 0;
            msg.ReadScalar(ref a);
            for (int i = 0; i < a; i++)
            {
                var t1 = new UserHeroPassiveGroupInfo();
                Read(msg, out t1);
                t.Add(t1);
            }
            v = t;
        }
        public static void Read(Nettention.Proud.Message msg, out ArenaSmashUserInfo value)
        {
            ArenaSmashUserInfo tmp = new ArenaSmashUserInfo();
            msg.Read(out tmp.rank);
            msg.Read(out tmp.winRewardPoint);
            msg.Read(out tmp.bestRank);
            msg.Read(out tmp.bestReward);
            msg.Read(out tmp.bestResetRaminSec);
            msg.Read(out tmp.opponentListRemainSec);
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out ArenaSmashLobbyInfo value)
        {
            ArenaSmashLobbyInfo tmp = new ArenaSmashLobbyInfo();
            Read(msg, out tmp.arenaSmashUserInfo);
            msg.Read(out tmp.needJoin);
            msg.Read(out tmp.needTeamSetting);
            msg.Read(out tmp.weeklyResetStartRaminSec);
            msg.Read(out tmp.weeklyResetEndRemainSec);
            Read(msg, out tmp.pvpModeList);
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out StageTicketClearInfo value)
        {
            StageTicketClearInfo tmp = new StageTicketClearInfo();
            Read(msg, out tmp.controlType);
            msg.Read(out tmp.clearCount);
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out List<StageTicketClearInfo> v)
        {
            var t = new List<StageTicketClearInfo>();
            int a = 0;
            msg.ReadScalar(ref a);
            for (int i = 0; i < a; i++)
            {
                var t1 = new StageTicketClearInfo();
                Read(msg, out t1);
                t.Add(t1);
            }
            v = t;
        }
        public static void Read(Nettention.Proud.Message msg, out UserEventBingoInfo value)
        {
            UserEventBingoInfo tmp = new UserEventBingoInfo();
            msg.Read(out tmp.eventSEQ);
            msg.Read(out tmp.eventSubIndex);
            msg.Read(out tmp.reward);
            msg.Read(out tmp.progress);
            Read(msg, out tmp.numberSlotList);
            Read(msg, out tmp.rewardSlotList);
            msg.Read(out tmp.resetCount);
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out GuildWarSquadSlot value)
        {
            GuildWarSquadSlot tmp = new GuildWarSquadSlot();
            msg.Read(out tmp.slot);
            msg.Read(out tmp.heroID);
            msg.Read(out tmp.usn);
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out List<GuildWarSquadSlot> v)
        {
            var t = new List<GuildWarSquadSlot>();
            int a = 0;
            msg.ReadScalar(ref a);
            for (int i = 0; i < a; i++)
            {
                var t1 = new GuildWarSquadSlot();
                Read(msg, out t1);
                t.Add(t1);
            }
            v = t;
        }
        public static void Read(Nettention.Proud.Message msg, out DestroyDisasterGaugeInfo value)
        {
            DestroyDisasterGaugeInfo tmp = new DestroyDisasterGaugeInfo();
            msg.Read(out tmp.seasonID);
            msg.Read(out tmp.disasterArea);
            msg.Read(out tmp.discoverCount);
            msg.Read(out tmp.gaugePoint);
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out List<DestroyDisasterGaugeInfo> v)
        {
            var t = new List<DestroyDisasterGaugeInfo>();
            int a = 0;
            msg.ReadScalar(ref a);
            for (int i = 0; i < a; i++)
            {
                var t1 = new DestroyDisasterGaugeInfo();
                Read(msg, out t1);
                t.Add(t1);
            }
            v = t;
        }
        public static void Read(Nettention.Proud.Message msg, out DestroyDisasterDicoverInfo value)
        {
            DestroyDisasterDicoverInfo tmp = new DestroyDisasterDicoverInfo();
            msg.Read(out tmp.seasonID);
            msg.Read(out tmp.bossStageClearFlag);
            msg.Read(out tmp.pickGroupID);
            msg.Read(out tmp.isClear);
            Read(msg, out tmp.disasterGaugeInfoList);
            msg.Read(out tmp.remainSecToClose);
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out GuildWarUserSquadInfo value)
        {
            GuildWarUserSquadInfo tmp = new GuildWarUserSquadInfo();
            Read(msg, out tmp.guildWarSquadSlotList);
            value = tmp;
        }
        public static void Write(Message msg, List<MailInfo> v)
        {
            msg.WriteScalar(v.Count);
            for (int i = 0; i < v.Count; i++)
            {
                Write(msg, v[i]);
            }
        }

        public static void Write(Nettention.Proud.Message msg, MailInfo value)
        {
            msg.Write(value.mailSN);
            msg.Write(value.mailContentsType);
            Write(msg, value.itemType);
            msg.Write(value.itemID);
            msg.Write(value.itemCount);
            msg.Write(value.eventSN);
            Write(msg, value.expireDate);
        }
        public static void Write(Nettention.Proud.Message msg, NoticeMailInfo value)
        {
            msg.Write(value.noticeMailSEQ);
            msg.Write(value.expireRemainSEC);
            msg.Write(value.noticeTitle);
            msg.Write(value.noticeContents);
            Write(msg, value.getItemList);
            msg.Write(value.rewardGetStatus);
            msg.Write(value.linkURL);
        }


        public static void Write(Message msg, List<NoticeMailInfo> v)
        {
            msg.WriteScalar(v.Count);
            for (int i = 0; i < v.Count; i++)
            {
                Write(msg, v[i]);
            }
        }

        public static void Read(Message msg, out List<MailInfo> v)
        {
            var t = new List<MailInfo>();
            int a = 0;
            msg.ReadScalar(ref a); if (a < 1) { v = t; return; }
            for (int i = 0; i < a; i++)
            {
                var t1 = new MailInfo();
                Read(msg, out t1);
                t.Add(t1);
            }
            v = t;
        }
        public static void Read(Nettention.Proud.Message msg, out MailInfo value)
        {
            MailInfo tmp = new MailInfo();
            msg.Read(out tmp.mailSN);
            msg.Read(out tmp.mailContentsType);
            Read(msg, out tmp.itemType);
            msg.Read(out tmp.itemID);
            msg.Read(out tmp.itemCount);
            msg.Read(out tmp.eventSN);
            Read(msg, out tmp.expireDate);
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out NoticeMailInfo value)
        {
            NoticeMailInfo tmp = new NoticeMailInfo();
            msg.Read(out tmp.noticeMailSEQ);
            msg.Read(out tmp.expireRemainSEC);
            msg.Read(out tmp.noticeTitle);
            msg.Read(out tmp.noticeContents);
            Read(msg, out tmp.getItemList);
            msg.Read(out tmp.rewardGetStatus);
            msg.Read(out tmp.linkURL);
            value = tmp;
        }

        public static void Read(Message msg, out List<NoticeMailInfo> v)
        {
            var t = new List<NoticeMailInfo>();
            int a = 0;
            msg.ReadScalar(ref a); if (a < 1) { v = t; return; }
            for (int i = 0; i < a; i++)
            {
                var t1 = new NoticeMailInfo();
                Read(msg, out t1);
                t.Add(t1);
            }
            v = t;
        }

        public static void Read(Message msg, out List<ItemResultInfo> v)
        {
            var t = new List<ItemResultInfo>();
            int a = 0;
            msg.ReadScalar(ref a); if (a < 1) { v = t; return; }
            for (int i = 0; i < a; i++)
            {
                var t1 = new ItemResultInfo();
                Read(msg, out t1);
                t.Add(t1);
            }
            v = t;
        }
        public static void Read(Nettention.Proud.Message msg, out MercenaryInfo value)
        {
            MercenaryInfo tmp = new MercenaryInfo();
            //Read(msg, out tmp.mercenaryLastUseTime);
            msg.Read(out tmp.mercenaryUsn);
            msg.Read(out tmp.mercenaryNickname);
            msg.Read(out tmp.mercenaryUserExp);
            msg.Read(out tmp.mercenaryRemainUsingSec);
            Read(msg, out tmp.mercenaryState);
            Read(msg, out tmp.mercenarySlotInfoList);
            msg.Read(out tmp.guildName);
            msg.Read(out tmp.guildIconID);
            msg.Read(out tmp.guildSubIconID);
            msg.Read(out tmp.guildBGIconID);
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out MercenarySlotInfo value)
        {
            MercenarySlotInfo tmp = new MercenarySlotInfo();
            msg.Read(out tmp.mercenaryHeroID);
            msg.Read(out tmp.mercenarySkinID);
            msg.Read(out tmp.mercenarySkinExp);
            msg.Read(out tmp.mercenarySkinAwaken);
            Read(msg, out tmp.mercenarySkinResearchList);
            msg.Read(out tmp.isHeadStyleChanged);
            msg.Read(out tmp.skinCostumeGroupID);
            msg.Read(out tmp.weaponCostumeGroupID);
            msg.Read(out tmp.headCostumeGroupID);
            value = tmp;
        }


        public static void Read(Message msg, out List<MercenarySlotInfo> v)
        {
            var t = new List<MercenarySlotInfo>();
            int a = 0;
            msg.ReadScalar(ref a); if (a < 1) { v = t; return; }
            for (int i = 0; i < a; i++)
            {
                var t1 = new MercenarySlotInfo();
                Read(msg, out t1);
                t.Add(t1);
            }
            v = t;
        }

        public static void Read(Message msg, out List<MercenaryInfo> v)
        {
            var t = new List<MercenaryInfo>();
            int a = 0;
            msg.ReadScalar(ref a); if (a < 1) { v = t; return; }
            for (int i = 0; i < a; i++)
            {
                var t1 = new MercenaryInfo();
                Read(msg, out t1);
                t.Add(t1);
            }
            v = t;
        }
        public static void Read(Nettention.Proud.Message msg, out ArenaRealTimePvpLastRankerStatueInfo value)
        {
            ArenaRealTimePvpLastRankerStatueInfo tmp = new ArenaRealTimePvpLastRankerStatueInfo();
            msg.Read(out tmp.lastRank);
            msg.Read(out tmp.usn);
            msg.Read(out tmp.nickname);
            msg.Read(out tmp.userExp);
            msg.Read(out tmp.mainSkinID);
            msg.Read(out tmp.skinCostumeGroup);
            msg.Read(out tmp.weaponCostumeGroup);
            msg.Read(out tmp.headCostumeGroup);
            msg.Read(out tmp.isHelmetOpen);
            msg.Read(out tmp.guildName);
            msg.Read(out tmp.guildIconID);
            msg.Read(out tmp.guildSubIconID);
            msg.Read(out tmp.guildBackgroundID);
            Read(msg, out tmp.grade);
            msg.Read(out tmp.gradeNumber);
            msg.Read(out tmp.rankPoint);
            msg.Read(out tmp.playTitleID);
            value = tmp;
        }
        public static void Read(Message msg, out List<ArenaRealTimePvpLastRankerStatueInfo> v)
        {
            var t = new List<ArenaRealTimePvpLastRankerStatueInfo>();
            int a = 0;
            msg.ReadScalar(ref a); if (a < 1) { v = t; return; }
            for (int i = 0; i < a; i++)
            {
                var t1 = new ArenaRealTimePvpLastRankerStatueInfo();
                Read(msg, out t1);
                t.Add(t1);
            }
            v = t;
        }

        public static void Read(Nettention.Proud.Message msg, out PvpSeasonHistoryInfo value)
        {
            PvpSeasonHistoryInfo tmp = new PvpSeasonHistoryInfo();
            msg.Read(out tmp.seasonID);
            msg.Read(out tmp.seasonPoint);
            msg.Read(out tmp.seasonRank);
            msg.Read(out tmp.nickname);
            msg.Read(out tmp.userRankExp);
            msg.Read(out tmp.mainSkinID);
            msg.Read(out tmp.costumeSkinGroupID);
            msg.Read(out tmp.costumeWeaponGroupID);
            msg.Read(out tmp.costumeHeadGroupID);
            msg.Read(out tmp.isHelmetOpen);
            msg.Read(out tmp.guildName);
            msg.Read(out tmp.guildIconID);
            msg.Read(out tmp.guildSubIconID);
            msg.Read(out tmp.guildBackgroundID);
            value = tmp;
        }
        public static void Read(Nettention.Proud.Message msg, out CostumeAutoRegisterInfo value)
        {
            CostumeAutoRegisterInfo tmp = new CostumeAutoRegisterInfo();
            msg.Read(out tmp.targetSkinID);
            Read(msg, out tmp.targetCostumeIDList);
            Read(msg, out tmp.slotIndexList);
            value = tmp;
        }
        public static void Read(Message msg, out List<CostumeAutoRegisterInfo> v)
        {
            var t = new List<CostumeAutoRegisterInfo>();
            int a = 0;
            msg.ReadScalar(ref a); if (a < 1) { v = t; return; }
            for (int i = 0; i < a; i++)
            {
                var t1 = new CostumeAutoRegisterInfo();
                Read(msg, out t1);
                t.Add(t1);
            }
            v = t;
        }

        public static void Write(Message msg, List<EventMissionClearRequestInfo> v)
        {
            msg.WriteScalar(v.Count);
            for (int i = 0; i < v.Count; i++)
            {
                Write(msg, v[i]);
            }
        }
        public static void Read(Nettention.Proud.Message msg, out EventMissionClearRequestInfo value)
        {
            EventMissionClearRequestInfo tmp = new EventMissionClearRequestInfo();
            msg.Read(out tmp.eventSeq);
            msg.Read(out tmp.chainID);
            msg.Read(out tmp.chainIndex);
            value = tmp;
        }
        public static void Read(Message msg, out List<EventMissionClearRequestInfo> v)
        {
            var t = new List<EventMissionClearRequestInfo>();
            int a = 0;
            msg.ReadScalar(ref a); if (a < 1) { v = t; return; }
            for (int i = 0; i < a; i++)
            {
                var t1 = new EventMissionClearRequestInfo();
                Read(msg, out t1);
                t.Add(t1);
            }
            v = t;
        }
    }
}