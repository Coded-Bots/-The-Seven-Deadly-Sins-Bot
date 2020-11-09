using Nettention.Proud;
using System;
using System.Collections.Generic;
using static SimpleCSharp.Vars;

namespace SimpleCSharp
{
	public class Vars
	{
		public static System.Guid m_Version = new System.Guid(new byte[] { 0x6E, 0x31, 0xE0, 0x4A, 0x77, 0x4C, 0x05, 0x4A, 0x8C, 0xD1, 0x84, 0xC8, 0xFB, 0xC0, 0xA9, 0x1E });
		public static int m_serverPort = 23071;
		public static string host = "gs-nanagb-real.netmarble.com";
		public static string host_gl_asia = "gs-nanagb-real2.netmarble.com";
		public static string host_jp = "gs-nanatsunotaizai-real.netmarble.com";
	}
	public class MailHistoryInfo // TypeDefIndex: 4716
	{
		public int mailSN; // 0x10
		public int itemID; // 0x14
		public int itemCount; // 0x18
		public int mailContentsType; // 0x1C
		public DateTime openDate; // 0x20
		public MailHistoryInfo() { }
	}
	public class EventMissionClearRequestInfo // TypeDefIndex: 4837
	{
		public int eventSeq; // 0x10
		public int chainID; // 0x14
		public byte chainIndex; // 0x18
		public EventMissionClearRequestInfo() { }
	}
	public class MissionClearResultInfo // TypeDefIndex: 4839
	{
		public List<int> successChainIDList; // 0x10
		public int getUserExp; // 0x18
		public List<ItemResultInfo> itemResultInfoList; // 0x20
		public MissionResult missionResult; // 0x28
		public List<ApRewardInfo> apRewardInfoList; // 0x30
		public PacketError errorType; // 0x38
		public InvalidRequestType invalidRequestType; // 0x3C

		public MissionClearResultInfo() { }
	}
	public class MaintenanceInfo // TypeDefIndex: 4827
	{
		public int remainSec; // 0x10
		public string message; // 0x18
		public MaintenanceInfo() { }
	}
	public enum OSType // TypeDefIndex: 4642
	{
		All, AOS, IOS
	}
	public enum NoticeType // TypeDefIndex: 4644
	{
		None, Maintenance, Emergency, ChattingServer, Client_CDN, Server_CDN, Addition_Patch, Server_Patch, Facebook
	}
	public class NoticeSpecificData // TypeDefIndex: 4676
	{
		public string title; // 0x10
		public string imageURL; // 0x18
		public string linkURL; // 0x20
		public string description; // 0x28
		public NoticeSpecificData() { }
	}
	public class NoticeLanguageData // TypeDefIndex: 4675
	{
		public LanguageType languageType; // 0x10
		public string imageURL; // 0x18
		public string linkURL; // 0x20
		public string description; // 0x28
		public NoticeLanguageData() { }
	}
	public class NoticeInfo // TypeDefIndex: 4677
	{
		public int seq; // 0x10
		public DateTime fromDate; // 0x18
		public DateTime toDate; // 0x28
		public string noticeTimeColor; // 0x38
		public string descriptionColor; // 0x40
		public short priority; // 0x48
		public OSType targetOSType; // 0x4A
		public DateTime noticeStartTime; // 0x50
		public DateTime noticeEndTime; // 0x60
		public NoticeType noticeType; // 0x70
		public byte languageSet; // 0x71
		public List<NoticeLanguageData> noticeLanguageDataList = new List<NoticeLanguageData>(); // 0x78
		public NoticeSpecificData specificData; // 0x80

		public NoticeInfo() { }
	}
	public class UserHero // TypeDefIndex: 4689
	{
		public int heroID; // 0x10
		public UserHero() { }
	}
	public enum DropBoxGrade // TypeDefIndex: 4595
	{
		None, Gold, Silver, Bronze, DestroyChief, Max
	}
	public enum StageMonsterGrade // TypeDefIndex: 4596
	{
		Normal, Boss, BossTeam
	}
	public class ClientSendPlayTitleMissionInfo // TypeDefIndex: 4832
	{
		public int missionID; // 0x10
		public int progressValue; // 0x14

		public ClientSendPlayTitleMissionInfo() { }
	}
	public class StageMonsterInfo // TypeDefIndex: 4735
	{
		// Fields
		public DropBoxGrade privateDropBoxGrade; // 0x10
		public int monsterID; // 0x14
		public int bossColumnNumber; // 0x18
		public DropBoxGrade dropBoxGrade; // 0x1C
		public StageMonsterGrade stageMonsterGrade; // 0x1D

		public StageMonsterInfo() { }
	}
	public class MissionResult // TypeDefIndex: 4830
	{
		public List<ClientSendMissionInfo> userMissionInfoList = new List<ClientSendMissionInfo>(); // 0x10
		public List<MarketMissionInfo> marketMissionInfoList = new List<MarketMissionInfo>(); // 0x18
		public List<ClientSendEventMissionInfo> eventMissionInfoList = new List<ClientSendEventMissionInfo>(); // 0x20
		public List<GuildMissionInfo> guildMissionInfoList = new List<GuildMissionInfo>(); // 0x28
		public List<ClientSendPlayTitleMissionInfo> titleMissionInfoList = new List<ClientSendPlayTitleMissionInfo>(); // 0x30

		public MissionResult() { }
	}
	public class ClientSendMissionInfo // TypeDefIndex: 4831
	{
		public int chainID; // 0x10
		public byte rewardChainIndex; // 0x14
		public int progressValue; // 0x18

		public ClientSendMissionInfo() { }
	}
	public enum ItemType // TypeDefIndex: 4570
	{
		None, Free_Dia, Buy_Dia, Gold, Ruby, Topaz, Friend, Stamina, Grind, AchievePoint, Final_boss_coin, final_boss_hero_point, guild_donation_money, guild_gold, Final_Boss_Bronze_Point, Final_Boss_Silver_Point, Final_Boss_Gold_Point, Final_Boss_single_Point, Gamble, Food_Material, SuperBoss_Ticket, Fairy_Crystal, Pvp_Stamina, Pvp_Coin, HeroCoin, EventCoin, Quest, Food, Skin_Upgrade, Skin_Material, Magic, Book_Material, Upgrade_Stone, Weapon_Book, Gamble_Ticket, Npc_Gift, Guest_Gift, Drop, Use, Refill, evolution_stone, type_pvpstamina, type_stamina, recipe_scroll, skin_capacity, week_key, evolution_key, evolution_book, evolution_break, fellowship_point, awaken_resource, item_box, rank_max, hero_fellowship, basepoint_fellowship, rank_exp, Event, item_gotcha, option_random, option_max, change_option, story_costume_skin, lobby_furniture, event_costume_weapon_ticket, special_gamble_ticket, item_coupon_box, training_stamina, type_trainingstamina, item_gotcha_key, weekly_event_stamina, type_weekly_event_stamina, weekly_gold_stamina, type_weekly_gold_stamina, Carve_Stone, selected_exchange_ticket, gamble_choice_ticket, item_music_use, subdueticket, costume_upgrade, full_awaken, Monster, Hero, Skin, Weapon, Costume_Skin, Costume_Weapon, Costume_Head, Stamp, item_music, final_boss_crown
	}
	public class ItemResultInfo // TypeDefIndex: 4709
	{
		public ItemType itemType; // 0x10
		public UserCommonItem userItemInfo; // 0x18
		public UserHero userHeroInfo; // 0x20
		public UserSkin userSkinInfo; // 0x28
		public UserWeapon userWeaponInfo; // 0x30
		public UserCostumeSkin userCostumeSkin; // 0x38
		public UserCostumeWeapon userCostumeWeapon; // 0x40
		public UserCostumeHead userCostumeHead; // 0x48
		public int getItemCount; // 0x50
		public DropBoxGrade ingameResultDropBoxGrade; // 0x54
		public int ownerSkinID; // 0x58
		public int ownerCostumeID; // 0x5C
		public int skinExp; // 0x60
		public int buffAddCount; // 0x64

		public ItemResultInfo() { }
	}
	public class StageStartResultInfo // TypeDefIndex: 4739
	{
		// Fields
		public int stageID; // 0x10
		public int ingameGold; // 0x14
		public bool isGoldManta; // 0x18
		public List<StageMonsterInfo> stageMonsterList = new List<StageMonsterInfo>(); // 0x20
		public APInfo apInfo; // 0x28
		public MissionResult missionResult; // 0x30
		public bool isBuffUsed; // 0x38
		public FoodBuffInfo foodBuffInfo; // 0x40
		public ItemResultInfo useItemResultInfo; // 0x48
		public bool isRejoinEnable; // 0x50
		public string rejoinData; // 0x58
		public long playKey; // 0x60
		public byte playMode; // 0x68
		public List<QuestProgressInfo> questProgressInfoList = new List<QuestProgressInfo>(); // 0x70
		public byte stageIndex; // 0x78
		public List<int> guildSkillUseList = new List<int>(); // 0x80

		public StageStartResultInfo() { }
	}
	public class UserNpcResult // TypeDefIndex: 4742
	{
		public int guestID; // 0x10
		public int lovePoint; // 0x14

		public UserNpcResult() { }
	}
	public class IngameMissionProgressRequest // TypeDefIndex: 4828
	{
		public bool isSupporterBest; // 0x10
		public short cardUseCount_lv2; // 0x12
		public short cardUseCount_lv3; // 0x14
		public short cardUseCount_specical; // 0x16
		public short cardUseCount_heal; // 0x18
		public short cardUseCount_debuff; // 0x1A
		public short allyTurnCount; // 0x1C
		public short cardUseCount_lv1; // 0x1E
		public short cardUseCount_counterPose; // 0x20
		public short cardUseCount_Shild; // 0x22
		public short cardUseCount_AtkStaDown; // 0x24
		public short cardUseCount_Stun; // 0x26
		public short cardUseCount_Stone; // 0x28
		public short cardUseCount_Ice; // 0x2A
		public short cardUseCount_specialCoop; // 0x2C
		public short debuffBleedDeadCount; // 0x2E
		public short staminaDecreaseCount; // 0x30
		public short staminaIncreaseCount; // 0x32
		public short cardLevelDownCount; // 0x34
		public short weakAttributeAttackCount; // 0x36
		public int winTeamPower; // 0x38
		public bool isAllHeroAlive; // 0x3C
		public bool isAllSSR; // 0x3D
		public bool isAllUR; // 0x3E
		public bool isAllWoman; // 0x3F
		public bool isAllMan; // 0x40
		public bool isNoneWeaponWin; // 0x41
		public short buffIceDeadCount; // 0x42
		public int lastAttackerSkinID; // 0x44
		public short debuffShockKillCount; // 0x48
		public short debuffPoisonKillCount; // 0x4A
		public int maxDamage; // 0x4C
		public short handicapSkillCount; // 0x50
		public short minHPRatio; // 0x52
		public short skillCombineByUserInputCount; // 0x54
		public short counterPoseKillCount; // 0x56
		public short skillLockCount; // 0x58
		public bool isUsedTargeting; // 0x5A
		public bool isUsedCardReset; // 0x5B
		public bool isUsedBalorEye; // 0x5C
		public short debuffPetrifactionCount; // 0x5E
		public short debuffFreezingCount; // 0x60
		public short debuffPreventposeCount; // 0x62
		public short debuffInfectionCount; // 0x64
		public short buffImmuneCount; // 0x66
		public short decreaseGaugeCount; // 0x68
		public short skillDissipationCount; // 0x6A
		public short skillBustCount; // 0x6C
		public short skillWeaknessCount; // 0x6E
		public short eraseBuffCount; // 0x70
		public short erasePoseCount; // 0x72
		public short recoveryDebuffCount; // 0x74
		public short cardDisuseCount; // 0x76
		public short beAttackedCountBySpecialCard; // 0x78
		public short useCountDropMamaSkill; // 0x7A
		public bool isFinishedByDropMamaSkill; // 0x7C

		public IngameMissionProgressRequest() { }
	}
	public class ApRewardInfo // TypeDefIndex: 4768
	{
		public APInfo apInfo; // 0x10
		public int getApCount; // 0x18

		public ApRewardInfo() { }
	}
	public class LobbyReddotInfo // TypeDefIndex: 4822
	{
		public byte mailListCount; // 0x10
		public byte friendMailListCount; // 0x11
		public byte destroyInviteCount; // 0x12
		public bool friendReddot; // 0x13
		public bool friendApplyReddot; // 0x14
		public bool guildReddot; // 0x15
		public byte noticeMailCount; // 0x16
		public byte packageMailCount; // 0x17
		public bool itemGambleShopFreeReddot; // 0x18
		public bool coinDailyShopFreeReddot; // 0x19
		public byte friendlyMatchInviteCount; // 0x1A
		public bool realTimePvpRewardAble; // 0x1B
		public bool guildReddot1; // 0x1C
		public bool guildReddot2; // 0x1D
		public bool guildReddot3; // 0x1E
		public bool guildAttendableReddot; // 0x1F
		public bool guildRankRewardReddot; // 0x20

		public LobbyReddotInfo() { }
	}
	public class LobbyRandomShopInfo // TypeDefIndex: 4825
	{
		public short dailySeq; // 0x10
		public byte visitRewardYN; // 0x12
		public List<RandomShopSchedule> remainRandomShopScheduleList = new List<RandomShopSchedule>(); // 0x18

		public LobbyRandomShopInfo() { }
	}
	public class RandomShopSchedule // TypeDefIndex: 4826
	{
		public int basepointID; // 0x10
		public int openRemainSec; // 0x14
		public int closeRemainSec; // 0x18
		public DateTime openDateTime; // 0x20
		public DateTime closeDateTime; // 0x30

		public RandomShopSchedule() { }
	}
	public class RedisRankInfo // TypeDefIndex: 4985
	{
		public int rank; // 0x10
		public int guildSN; // 0x14
		public int rankPoint; // 0x18
		public int totolRankUpCount; // 0x1C

		public RedisRankInfo() { }
	}
	public class ArenaRealTimePvpLastRankerStatueInfo // TypeDefIndex: 4754
	{
		public byte lastRank; // 0x10
		public long usn; // 0x18
		public string nickname; // 0x20
		public int userExp; // 0x28
		public int mainSkinID; // 0x2C
		public int skinCostumeGroup; // 0x30
		public int weaponCostumeGroup; // 0x34
		public int headCostumeGroup; // 0x38
		public bool isHelmetOpen; // 0x3C
		public string guildName; // 0x40
		public int guildIconID; // 0x48
		public int guildSubIconID; // 0x4C
		public int guildBackgroundID; // 0x50
		public ArenaLeagueGrade grade; // 0x54
		public byte gradeNumber; // 0x55
		public int rankPoint; // 0x58
		public int playTitleID; // 0x5C

		public ArenaRealTimePvpLastRankerStatueInfo() { }
	}
	public class PvpSeasonHistoryInfo // TypeDefIndex: 4660
	{
		public int seasonID; // 0x10
		public int seasonPoint; // 0x14
		public int seasonRank; // 0x18
		public string nickname; // 0x20
		public int userRankExp; // 0x28
		public int mainSkinID; // 0x2C
		public int costumeSkinGroupID; // 0x30
		public int costumeWeaponGroupID; // 0x34
		public int costumeHeadGroupID; // 0x38
		public bool isHelmetOpen; // 0x3C
		public string guildName; // 0x40
		public int guildIconID; // 0x48
		public int guildSubIconID; // 0x4C
		public int guildBackgroundID; // 0x50

		public PvpSeasonHistoryInfo() { }
	}
	public class ClientSendGuildRankInfo // TypeDefIndex: 4986
	{
		public RedisRankInfo redisRankInfo; // 0x10
		public GuildInfo guildInfo; // 0x18

		public ClientSendGuildRankInfo() { }
	}
	public class CostumeAutoRegisterInfo // TypeDefIndex: 4702
	{
		public int targetSkinID; // 0x10
		public List<int> targetCostumeIDList = new List<int>(); // 0x18
		public List<byte> slotIndexList = new List<byte>(); // 0x20

		public CostumeAutoRegisterInfo() { }
	}
	public enum BillingResCode // TypeDefIndex: 4628
	{
		InitializingFailed, InvalidParameter, Exception, UserTypeError, DBError, Success, InvalidProduct, UserReceiveGiftMax, UserGiveGiftMax, UserBillingLimit, NetmarbleIAPUnderMaintenance, InvalidProductSetting, SalePeriodFinished, SaleCountMax, AbusingUserBillingTried
	}
	public enum BillingVerifyType // TypeDefIndex: 4627
	{
		PU, RM
	}
	public class PackageBannerInfo // TypeDefIndex: 4769
	{
		public int packageID; // 0x10
		public byte priority; // 0x14
		public string packageImageUrl; // 0x18

		public PackageBannerInfo() { }
	}
	public class ClientSendFinalBossSeasonInfo // TypeDefIndex: 4955
	{
		public int currentSeasonID; // 0x10
		public int currentFinalBossStageFlag; // 0x14
		public List<FinalBossGroupInfo> finalBossGroupInfoList = new List<FinalBossGroupInfo>(); // 0x18
		public int remainFinalBossInitSec; // 0x20
		public int currentFinalBossPointItemCount; // 0x24
		public List<FinalBossSeasonInfo> finalBossSeasonInfoList = new List<FinalBossSeasonInfo>(); // 0x28
		public List<FinalBossBattleScoreInfo> finalBossBattleScoreInfoList = new List<FinalBossBattleScoreInfo>(); // 0x30
		public int prevSeasonID; // 0x38
		public byte finalBossRankRewardOccured; // 0x3C

		public ClientSendFinalBossSeasonInfo() { }
	}
	public class FinalBossBattleScoreInfo // TypeDefIndex: 4954
	{
		public int finalBossScoreGroupID; // 0x10
		public int missionGroupID; // 0x14
		public int battleScoreGroupID; // 0x18
		public int remainSec; // 0x1C

		public FinalBossBattleScoreInfo() { }
	}
	public class FinalBossSeasonInfo // TypeDefIndex: 4951
	{
		public int seasonID; // 0x10
		public int remainSeasonStartSec; // 0x14
		public int remainSeasonEndSec; // 0x18

		public FinalBossSeasonInfo() { }
	}
	public class FinalBossGroupInfo // TypeDefIndex: 4952
	{
		public int id; // 0x10
		public int groupID; // 0x14
		public int remainActiveStartSec; // 0x18
		public int remainActiveEndSec; // 0x1C
		public byte currentPlayCount; // 0x20

		public FinalBossGroupInfo() { }
	}
	public class FinalBossSeasonShopBuyInfo // TypeDefIndex: 4722
	{
		public int seasonID; // 0x10
		public int productID; // 0x14
		public byte dailyBuyCount; // 0x18
		public short seasonBuyCount; // 0x1A

		public FinalBossSeasonShopBuyInfo() { }
	}
	public class FinalBossSeasonShopInfo // TypeDefIndex: 4953
	{
		public int seasonID; // 0x10
		public int remainSeasonShopStartSec; // 0x14
		public int remainSeasonShopEndSec; // 0x18
		public List<NeedItemInfo> currentSeasonShopNeedItemList = new List<NeedItemInfo>(); // 0x20

		public FinalBossSeasonShopInfo() { }
	}
	public class ClientSendFinalBossSeasonShopInfo // TypeDefIndex: 4956
	{
		public List<FinalBossSeasonShopInfo> finalBossSeasonShopInfoList = new List<FinalBossSeasonShopInfo>(); // 0x10
		public List<FinalBossSeasonShopBuyInfo> finalBossSeasonShopBuyInfoList = new List<FinalBossSeasonShopBuyInfo>(); // 0x18

		public ClientSendFinalBossSeasonShopInfo() { }
	}
	public enum TournamentState // TypeDefIndex: 4648
	{
		Prepare, Open, Post, Replay, Finish
	}
	public class TournamentDisplayInfo // TypeDefIndex: 4995
	{
		public int SEQ; // 0x10
		public string title; // 0x18
		public string bannerURL; // 0x20
		public string contents; // 0x28
		public int rewardGroupID; // 0x30
		public bool isWeaponUse; // 0x34
		public int damageRate; // 0x38
		public int damageIncRate; // 0x3C
		public DateTime startTime; // 0x40
		public DateTime endTime; // 0x50
		public int startRemainSec; // 0x60
		public int endRemainSec; // 0x64
		public bool isPlayer; // 0x68
		public TournamentState tournamentState; // 0x69
		public int stateRemainSec; // 0x6C

		public TournamentDisplayInfo() { }
	}
	public class LobbyInfo // TypeDefIndex: 4821
	{
		public List<int> lobbyVRSearchList = new List<int>(); // 0x10
		public LobbyReddotInfo lobbyReddotInfo; // 0x18
		public List<UserNpc> userNpcInfoList = new List<UserNpc>(); // 0x20
		public List<int> guestNPCList = new List<int>(); // 0x28
		public int currentVisitGuestID; // 0x30
		public int currentVisitGuestIndex; // 0x34
		public bool newHeroVisit; // 0x38
		public int remainHeroVisitTimeSec; // 0x3C
		public bool hawkCollectAble; // 0x40
		public EventPacketInfo eventPacketInfo; // 0x48
		public List<NoticeInfo> noticeList = new List<NoticeInfo>(); // 0x50
		public List<PackageBannerInfo> packageBannerInfoList = new List<PackageBannerInfo>(); // 0x58
		public List<int> disableDropInteractiveList = new List<int>(); // 0x60
		public bool isGuildKickOut; // 0x68
		public GuildMemberInfo guildMemberInfo; // 0x70
		public MaintenanceInfo maintenanceInfo; // 0x78
		public int remainDailyResetTimeSEC; // 0x80
		public List<QuestProgressInfo> questProgressInfoList = new List<QuestProgressInfo>(); // 0x88
		public bool didDailyResetToday; // 0x90
		public LobbyRandomShopInfo randomShopInfo; // 0x98
		public ClientSendFinalBossSeasonInfo clientSendFinalBossSeasonInfo; // 0xA0
		public ClientSendFinalBossSeasonShopInfo clientSendFinalBossSeasonShopInfo; // 0xA8
		public List<UserHeroGachaGaugeInfo> userHeroGachaGaugeInfoList = new List<UserHeroGachaGaugeInfo>(); // 0xB0
		public DateTime currentServerTime; // 0xB8
		public byte userAgeLevel; // 0xC8
		public UserMonthlyStageInfo monthlyInfo; // 0xD0
		public bool gaugeEventFreeChargeAble; // 0xD8
		public byte currentSeasonGroup; // 0xD9
		public List<TournamentDisplayInfo> tournamentDiplayInfoList = new List<TournamentDisplayInfo>(); // 0xE0
		public List<UserADViewInfo> userAdViewInfoList = new List<UserADViewInfo>(); // 0xE8
		public ClientSendBossWarInfo clientSendBossWarInfo; // 0xF0
		public ArenaLeagueGrade arenaRealTimePvpLowGrade; // 0xF8
		public byte arenaRealTimePvpLowGradeNumber; // 0xF9
		public List<UserFurniture> updateUserFurnitureList = new List<UserFurniture>(); // 0x100
		public bool firstDiaBuy; // 0x108
		public bool isGuildWarRejoinInfoExists; // 0x109

		public LobbyInfo() { }
	}
	public class BossWarGroupInfo // TypeDefIndex: 4864
	{
		public int groupID; // 0x10
		public int remainEndSec; // 0x14

		public BossWarGroupInfo() { }
	}
	public class ClientSendBossWarInfo // TypeDefIndex: 4865
	{
		public List<BossWarGroupInfo> bossWarInfoList = new List<BossWarGroupInfo>(); // 0x10
		public List<SubdueBossPlayInfo> subdueBossPlayInfoList = new List<SubdueBossPlayInfo>(); // 0x18

		public ClientSendBossWarInfo() { }
	}
	public enum BillingResultCode // TypeDefIndex: 4629
	{
		Success, DBError, AlreadyProcessed, VerifySuccess_DiffAccountSeq, AlreadyProcessed_DiffAccountSeq, VerifyFailed, InvalidTIDorAlreadyConsumed, DuplicatedMarketSerial, Promotion, InvalidParameter, InvalidStoreType, PurchaseDataParsingFailed, InvalidPurchaseData, NetmarbleIAPServerDBError, InvalidMarketVerifyKey, APIConnectionError, InvalidReceiptFormat, InvalidMarketResponseFormat, ReceiptCryptographyError, ErrorETC
	}
	public class BillingVerifyResultInfo // TypeDefIndex: 4673
	{
		public BillingResCode resCode; // 0x10
		public BillingResultCode resultCode; // 0x14
		public long transactionID; // 0x18
		public string resultString; // 0x20
		public bool isPurchase; // 0x28
		public bool promoFlag; // 0x29
		public bool gppFlag; // 0x2A

		public BillingVerifyResultInfo() { }
	}
	public class AttendanceResult // TypeDefIndex: 4820
	{
		public ClientSendUserAttendanceInfo attendanceInfo; // 0x10
		public List<ItemResultInfo> rewardItemInfoList = new List<ItemResultInfo>(); // 0x18
		public List<ApRewardInfo> apRewardInfoList = new List<ApRewardInfo>(); // 0x20
		public MissionResult missionResult; // 0x28
		public List<ItemResultInfo> preRegistationRewardList = new List<ItemResultInfo>(); // 0x30

		public AttendanceResult() { }
	}
	public class MercenarySlotInfo // TypeDefIndex: 4683
	{
		public int mercenaryHeroID; // 0x10
		public int mercenarySkinID; // 0x14
		public int mercenarySkinExp; // 0x18
		public byte mercenarySkinAwaken; // 0x1C
		public List<byte> mercenarySkinResearchList = new List<byte>(); // 0x20
		public bool isHeadStyleChanged; // 0x28
		public int skinCostumeGroupID; // 0x2C
		public int weaponCostumeGroupID; // 0x30
		public int headCostumeGroupID; // 0x34

		public MercenarySlotInfo() { }
	}
	public class MercenaryInfo // TypeDefIndex: 4684
	{
		public DateTime mercenaryLastUseTime; // 0x10
		public long mercenaryUsn; // 0x20
		public string mercenaryNickname; // 0x28
		public int mercenaryUserExp; // 0x30
		public int mercenaryRemainUsingSec; // 0x34
		public FriendState mercenaryState; // 0x38
		public List<MercenarySlotInfo> mercenarySlotInfoList = new List<MercenarySlotInfo>(); // 0x40
		public string guildName; // 0x48
		public int guildIconID; // 0x50
		public int guildSubIconID; // 0x54
		public int guildBGIconID; // 0x58

		public MercenaryInfo() { }
	}
	public class MailInfo // TypeDefIndex: 4715
	{
		public int mailSN; // 0x10
		public int mailContentsType; // 0x14
		public ItemType itemType; // 0x18
		public int itemID; // 0x1C
		public int itemCount; // 0x20
		public int eventSN; // 0x24
		public DateTime expireDate; // 0x28

		public MailInfo() { }
	}
	public class NoticeMailInfo // TypeDefIndex: 4714
	{
		public int noticeMailSEQ; // 0x10
		public int expireRemainSEC; // 0x14
		public string noticeTitle; // 0x18
		public string noticeContents; // 0x20
		public List<NeedItemInfo> getItemList = new List<NeedItemInfo>(); // 0x28
		public bool rewardGetStatus; // 0x30
		public string linkURL; // 0x38

		public NoticeMailInfo() { }
	}
	public class BasePointRefreshInfo // TypeDefIndex: 4842
	{
		public bool isGuildKickOut; // 0x10
		public GuildMemberInfo guildMemberInfo; // 0x18
		public LobbyReddotInfo lobbyReddotInfo; // 0x20
		public List<ClientSendGuildRankInfo> prevTopGuildRankInfoList = new List<ClientSendGuildRankInfo>(); // 0x28
		public LobbyRandomShopInfo lobbyRandomShopInfo; // 0x30

		public BasePointRefreshInfo() { }
	}
	public class QuestClearResultInfo // TypeDefIndex: 4850
	{
		public int questID; // 0x10
		public int userExp; // 0x14
		public List<ItemResultInfo> getItemResultInfoList = new List<ItemResultInfo>(); // 0x18
		public List<ItemResultInfo> removeItemResultInfoList = new List<ItemResultInfo>(); // 0x20
		public List<QuestProgressInfo> questProgressInfoList = new List<QuestProgressInfo>(); // 0x28
		public MissionResult missionResult; // 0x30
		public int basepointGetExp; // 0x38
		public BasePointInfo basepointInfo; // 0x40
		public List<ApRewardInfo> apRewardInfoList = new List<ApRewardInfo>(); // 0x48

		public QuestClearResultInfo() { }
	}
	public enum HeroAliveStatus // TypeDefIndex: 4582
	{
		Die, Alive
	}
	public class BattleSkinInfo // TypeDefIndex: 4731
	{
		public int skinID; // 0x10
		public HeroAliveStatus heroAliveStatus; // 0x14
		public bool isBestPlayer; // 0x15
		public int power; // 0x18

		public BattleSkinInfo() { }
	}
	public class StageClearRequestInfo // TypeDefIndex: 4740
	{
		public int stageID; // 0x10
		public bool isWin; // 0x14
		public List<BattleSkinInfo> battleSkinInfoList = new List<BattleSkinInfo>(); // 0x18
		public int teamIndex; // 0x20
		public int eventSEQ; // 0x24
		public long mercenaryUSN; // 0x28
		public int battlePowerPoint; // 0x30
		public IngameMissionProgressRequest missionRequest; // 0x38
		public List<SkinStatInfo> skinStatInfoList = new List<SkinStatInfo>(); // 0x40
		public bool isAutoPlay; // 0x48
		public int turnCount; // 0x4C
		public int clientTimeSec; // 0x50
		public double deltaTime; // 0x58
		public long packetSendTick; // 0x60
		public int tickCount; // 0x68
		public int stopwatch; // 0x6C
		public int dateTime; // 0x70
		public byte stageIndex; // 0x74
		public int battlePoint; // 0x78

		public StageClearRequestInfo() { }
	}
	public class BattleSkinResultInfo // TypeDefIndex: 4741
	{
		public int heroID; // 0x10
		public int skinID; // 0x14
		public int skinExp; // 0x18
		public int skinGetExp; // 0x1C
		public int skinBuffExp; // 0x20
		public bool isBestPlayer; // 0x24

		public BattleSkinResultInfo() { }
	}
	public class StageClearResultInfo // TypeDefIndex: 4743
	{
		public int userExp; // 0x10
		public APInfo apInfo; // 0x18
		public bool isWin; // 0x20
		public List<BattleSkinResultInfo> battleSkinResultInfoList = new List<BattleSkinResultInfo>(); // 0x28
		public List<UserNpcResult> npcResultList = new List<UserNpcResult>(); // 0x30
		public ItemResultInfo goldItemResultInfo; // 0x38
		public List<ItemResultInfo> ingameItemResultInfoList = new List<ItemResultInfo>(); // 0x40
		public List<ItemResultInfo> questItemResultInfoList = new List<ItemResultInfo>(); // 0x48
		public ItemResultInfo firstItemResultInfo; // 0x50
		public ItemResultInfo clearItemResultInfo; // 0x58
		public List<ItemResultInfo> globalDropItemResultInfoList = new List<ItemResultInfo>(); // 0x60
		public ItemResultInfo gaugeRewardItemResultInfo; // 0x68
		public ItemResultInfo passiveDropItemInfo; // 0x70
		public ItemResultInfo additionalItemResultInfo; // 0x78
		public bool isFirstClear; // 0x80
		public int playStageID; // 0x84
		public StageInfo stageInfo; // 0x88
		public List<QuestProgressInfo> questProgressInfoList = new List<QuestProgressInfo>(); // 0x90
		public MissionResult missionResult; // 0x98
		public List<UserPlayCountEventInfo> playCountEventInfoList = new List<UserPlayCountEventInfo>(); // 0xA0
		public int ingameGoldBuffAddValue; // 0xA8
		public int usedFoodID; // 0xAC
		public List<UserGlobalDropEventInfo> updateUserGlobalDropEventInfoList = new List<UserGlobalDropEventInfo>(); // 0xB0
		public UserADViewInfo adViewRouletteInfo; // 0xB8

		public StageClearResultInfo() { }
	}
	public class PaybackEventResultInfo // TypeDefIndex: 4775
	{
		public int eventSEQ; // 0x10
		public int paybackGroupID; // 0x14
		public int addValue; // 0x18

		public PaybackEventResultInfo() { }
	}
	public class SkinStatInfo // TypeDefIndex: 4736
	{
		public int attack; // 0x10
		public int defence; // 0x14
		public int life; // 0x18
		public int currentLife; // 0x1C

		public SkinStatInfo() { }
	}
	public class StageStartRequestInfo // TypeDefIndex: 4744
	{
		public int stageID; // 0x10
		public long mercenaryUSN; // 0x18
		public int mercenarySkinID; // 0x20
		public FriendState mercenaryState; // 0x24
		public int teamIndex; // 0x28
		public int eventSEQ; // 0x2C
		public int battlePowerPoint; // 0x30
		public List<SkinStatInfo> skinStatInfoList = new List<SkinStatInfo>(); // 0x38
		public List<int> stageNpcIDList = new List<int>(); // 0x40
		public byte stageIndex; // 0x48

		public StageStartRequestInfo() { }
	}
	public class UserSkin // TypeDefIndex: 4690
	{
		public int getSkinID; // 0x10
		public int goldBuffValue; // 0x14
		public int dropBuffValue; // 0x18
		public int expBuffValue; // 0x1C
		public int skinMaterialCount; // 0x20
		public bool isFellowshipMax; // 0x24
		public int heroContentsPassiveID; // 0x28
		public int skinOwnerHeroID; // 0x2C
		public int skinID; // 0x30
		public int skinExp; // 0x34
		public int skinFellowshipExp; // 0x38
		public byte lastFellowRewardIndex; // 0x3C
		public byte awaken; // 0x3D
		public byte skillLevelUpCount; // 0x3E
		public byte maxLevelCount; // 0x3F
		public byte passiveSkillLevel; // 0x40
		public List<int> equipWeaponList; // 0x48
		public List<byte> researchList; // 0x50
		public int skinCostumeGroupID; // 0x58
		public int weaponCostumeGroupID; // 0x5C
		public int headCostumeGroupID; // 0x60
		public bool isHeadStyleChanged; // 0x64
		public byte firstResearchType; // 0x65
		public byte firstResearchSlot; // 0x66
		public List<int> registeredCostumeGroupList; // 0x68
		public byte trainingStagePlayCount; // 0x70
		public short usedGuildBossSeq; // 0x72
		public short usedEventChallengeBossSeq; // 0x74
		public byte transcend; // 0x76
		public UserSkin() { }
	}
	public class UserWeaponPassiveSkill // TypeDefIndex: 4695
	{
		public int passiveID; // 0x10
		public int passiveValue; // 0x14
		public UserWeaponPassiveSkill() { }
	}
	public class UserCommonItem // TypeDefIndex: 4670
	{
		public int ItemID; // 0x10
		public int ItemCount; // 0x14

		public UserCommonItem() { }
	}
	public class UserWeapon // TypeDefIndex: 4696
	{
		public int weaponSerial; // 0x10
		public int weaponBaseID; // 0x14
		public byte upgrade; // 0x18
		public byte evolution; // 0x19
		public List<UserWeaponPassiveSkill> addPassiveSkillList = new List<UserWeaponPassiveSkill>(); // 0x20
		public UserWeaponPassiveSkill addMagicSkill; // 0x28
		public DateTime getWeaponTime; // 0x30
		public bool isEquip; // 0x40
		public int defaultOptionValue; // 0x44
		public bool isLock; // 0x48
		public byte carveHeroGroup; // 0x49
		public UserWeapon() { }
	}
	public class UserExtensionData // TypeDefIndex: 4730
	{
		public int itemInventoryMax; // 0x10
		public int weaponInventoryMax; // 0x14
		public UserExtensionData() { }
	}
	public class UserTeamSlot // TypeDefIndex: 4728
	{
		public byte index; // 0x10
		public int heroID; // 0x14
		public byte heroGroupID; // 0x18
		public int skinID; // 0x1C
		public int fateHeroID; // 0x20
		public byte fateHeroGroupID; // 0x24
		public int fateSkinID; // 0x28
		public UserTeamSlot() { }
	}
	public class UserTeam // TypeDefIndex: 4727
	{
		public byte index; // 0x10
		public string name; // 0x18
		public List<UserTeamSlot> teamSlotList = new List<UserTeamSlot>(); // 0x20
		public int defenceBuffID; // 0x28

		public UserTeam() { }
	}
	public enum APType // TypeDefIndex: 4583
	{
		None, Stamina, ArenaTicket, TrainingTicket, WeeklyEventStamina, WeeklyGoldStamina
	}
	public class APInfo // TypeDefIndex: 4767
	{
		public APType type; // 0x10
		public int count; // 0x14
		public DateTime updateTime; // 0x18
		public int remainSecondToRecharge; // 0x28

		public APInfo() { }
	}
	public class SideStageClearInfo // TypeDefIndex: 4667
	{
		public int region; // 0x10
		public int sideStageID1; // 0x14
		public int sideStageID2; // 0x18
		public int sideStageID3; // 0x1C
		public int sideStageID4; // 0x20
		public int sideStageID5; // 0x24
		public int freeStage; // 0x28
		public int bossStage; // 0x2C
		public long limitedStage; // 0x30
		public long areaFirstClearInfo; // 0x38
		public int hawkRunStage; // 0x40
		public int finalBossStage; // 0x44

		public SideStageClearInfo() { }
	}
	public class StagePlayCountInfo // TypeDefIndex: 4733
	{
		public short stageLimitIndex; // 0x10
		public byte stagePlayCount; // 0x12

		public StagePlayCountInfo() { }
	}
	public class UserExtraStageInfo // TypeDefIndex: 4666
	{
		public int extraGroupID; // 0x10
		public int clearID; // 0x14

		public UserExtraStageInfo() { }
	}
	public enum TrainingStageState // TypeDefIndex: 4638
	{
		Close, Open, Clear
	}
	public class OtherPlayerWeapon // TypeDefIndex: 4757
	{
		public int weaponSerial; // 0x10
		public int weaponBaseID; // 0x14
		public byte upgrade; // 0x18
		public byte evolution; // 0x19
		public List<UserWeaponPassiveSkill> addPassiveSkillList = new List<UserWeaponPassiveSkill>(); // 0x20
		public UserWeaponPassiveSkill addMagicSkill; // 0x28
		public int defaultOptionValue; // 0x30
		public byte carveHeroGroup; // 0x34

		public OtherPlayerWeapon() { }
	}
	public class OtherPlayerSlotInfo // TypeDefIndex: 4756
	{
		public byte index; // 0x10
		public int heroID; // 0x14
		public int skinID; // 0x18
		public int skinExp; // 0x1C
		public byte skinAwaken; // 0x20
		public List<byte> researchList = new List<byte>(); // 0x28
		public List<OtherPlayerWeapon> equipWeaponList = new List<OtherPlayerWeapon>(); // 0x30
		public int skinCostumeGroupID; // 0x38
		public int weaponCostumeGroupID; // 0x3C
		public int headCostumeGroupID; // 0x40
		public bool isHeadStyleChanged; // 0x44
		public byte skillLevelUpCount; // 0x45
		public byte maxLevelCount; // 0x46
		public byte passiveSkillLevel; // 0x47
		public List<int> registeredCostumeGroupList = new List<int>(); // 0x48

		public OtherPlayerSlotInfo() { }
	}
	public class UserCostumeSkin // TypeDefIndex: 4698
	{
		public int costumeID; // 0x10
		public int exp; // 0x14
		public byte upgrade; // 0x18
		public byte heroGroupID; // 0x19
		public int costumeGroupID; // 0x1C

		public UserCostumeSkin() { }
	}
	public class UserCostumeWeapon // TypeDefIndex: 4699
	{
		public int costumeID; // 0x10
		public int exp; // 0x14
		public byte upgrade; // 0x18
		public byte heroGroupID; // 0x19
		public int costumeGroupID; // 0x1C

		public UserCostumeWeapon() { }
	}
	public class UserCostumeHead // TypeDefIndex: 4700
	{
		public int costumeID; // 0x10
		public int exp; // 0x14
		public byte upgrade; // 0x18
		public byte heroGroupID; // 0x19
		public int costumeGroupID; // 0x1C

		public UserCostumeHead() { }
	}
	public class OtherPlayerTeamInfo // TypeDefIndex: 4755
	{
		public long usn; // 0x10
		public int foodBuffItemID; // 0x18
		public List<OtherPlayerSlotInfo> teamSlotList = new List<OtherPlayerSlotInfo>(); // 0x20
		public List<OtherPlayerSlotInfo> fateSlotList = new List<OtherPlayerSlotInfo>(); // 0x28
		public List<UserCostumeSkin> skinCostumeList = new List<UserCostumeSkin>(); // 0x30
		public List<UserCostumeWeapon> weaponCostumeList = new List<UserCostumeWeapon>(); // 0x38
		public List<UserCostumeHead> headCostumeList = new List<UserCostumeHead>(); // 0x40
		public List<int> lobbyBuffItemIDList = new List<int>(); // 0x48
		public List<int> guildSkillUseList = new List<int>(); // 0x50
		public int aiLevel; // 0x58
		public List<int> playTitleIDList = new List<int>(); // 0x60

		public OtherPlayerTeamInfo() { }
	}
	public class TrainingStageSlotInfo // TypeDefIndex: 4959
	{
		public byte stageIndex; // 0x10
		public int stageID; // 0x14
		public TrainingStageState state; // 0x18

		public TrainingStageSlotInfo() { }
	}
	public class TrainingStageInfo // TypeDefIndex: 4958
	{
		public int remainSecToReset; // 0x10
		public int remainSecToClose; // 0x14
		public List<TrainingStageSlotInfo> stageList = new List<TrainingStageSlotInfo>(); // 0x18
		public int rewardGauge; // 0x20
		public int point; // 0x24
		public OtherPlayerTeamInfo mirrorTeamInfo; // 0x28
		public int trainingTaskID; // 0x30
		public int trainingTaskCount; // 0x34

		public TrainingStageInfo() { }
	}
	public class StageInfo // TypeDefIndex: 4734
	{
		public int mainStageTopClearID; // 0x10
		public int anotherMainStageTopClearID; // 0x14
		public List<SideStageClearInfo> sideStageClearInfoList = new List<SideStageClearInfo>(); // 0x18
		public List<long> weeklyStageFirstClearInfoList = new List<long>(); // 0x20
		public List<long> questStageFirstClearInfo = new List<long>(); // 0x28
		public List<long> descentStageFirstClearInfo = new List<long>(); // 0x30
		public List<StagePlayCountInfo> stagePlayCountInfoList = new List<StagePlayCountInfo>(); // 0x38
		public DayOfWeek dayofWeek; // 0x40
		public List<UserExtraStageInfo> extraStageInfoList = new List<UserExtraStageInfo>(); // 0x48
		public int eventGauge; // 0x50
		public int goldGauge; // 0x54
		public int upgradeGauge1; // 0x58
		public int upgradeGauge2; // 0x5C
		public int upgradeGauge3; // 0x60
		public int evolutionGauge1; // 0x64
		public int evolutionGauge2; // 0x68
		public int evolutionGauge3; // 0x6C
		public TrainingStageInfo trainingStageInfo; // 0x70

		public StageInfo() { }
	}
	public class QuestProgressInfo // TypeDefIndex: 4847
	{
		public int questID; // 0x10
		public QuestState state; // 0x14
		public List<int> progressCountList = new List<int>(); // 0x18
		public byte interactionFlag; // 0x20

		public QuestProgressInfo() { }
	}
	public enum QuestState // TypeDefIndex: 4571
	{
		None, Progress, Clear
	}
	public enum AttendanceType // TypeDefIndex: 4605
	{
		None, Normal, Comeback
	}
	public class ClientSendUserAttendanceInfo // TypeDefIndex: 4854
	{
		public bool isRewardedToday; // 0x10
		public AttendanceType attendanceType; // 0x11
		public byte attendanceGroup; // 0x12
		public byte rewardIndex; // 0x13
		public byte welcomeRewardIndex; // 0x14
		public bool comebackMissionEnable; // 0x15
		public int combackEndRemainSec; // 0x18
		public bool pvpComebackMissionEnable; // 0x1C
		public int pvpCombackEndRemainSec; // 0x20
		public AttendanceType lastRewardedType; // 0x24
		public byte lastRewardedGroup; // 0x25
		public byte lastRewardedIndex; // 0x26

		public ClientSendUserAttendanceInfo() { }
	}
	public class UserPackageInfo // TypeDefIndex: 4703
	{
		public int packageID; // 0x10
		public int buyCount; // 0x14
		public DateTime buyTime; // 0x18
		public DateTime expireTIme; // 0x28
		public int remainResetTimeSEC; // 0x38
		public long rewardValue; // 0x40
		public int dayCount; // 0x48
		public bool rewardAble; // 0x4C
		public bool isExpire; // 0x4D

		public UserPackageInfo() { }
	}
	public class ShopBuyInfo // TypeDefIndex: 4721
	{
		public bool serverNoDailyReset; // 0x10
		public int shopProductID; // 0x14
		public int basepointID; // 0x18
		public byte buyCount; // 0x1C
		public byte freeBuyCount; // 0x1D
		public int startRemainSec; // 0x20
		public int endRemainSec; // 0x24

		public ShopBuyInfo() { }
	}
	public class CoinShopRotationInfo // TypeDefIndex: 4719
	{
		public short groupID; // 0x10
		public int remainSec; // 0x14
		public List<ShopBuyInfo> coinShopBuyInfoList = new List<ShopBuyInfo>(); // 0x18

		public CoinShopRotationInfo() { }
	}
	public class CoinShopRotationTabInfo // TypeDefIndex: 4718
	{
		public CoinShopRotationInfo platinumCoinTab; // 0x10
		public CoinShopRotationInfo goldCoinTab; // 0x18
		public CoinShopRotationInfo silverCoinTab; // 0x20
		public CoinShopRotationInfo friendCoinTab; // 0x28

		public CoinShopRotationTabInfo() { }
	}
	public class GuildMissionInfo // TypeDefIndex: 4972
	{
		public int guildMissionID; // 0x10
		public int progressValue; // 0x14
		public bool isReward; // 0x18

		public GuildMissionInfo() { }
	}
	public enum ServerEventType // TypeDefIndex: 4586
	{
		None, EVENT_BANNER_NOTIFY, EVENT_ACTION_TEST1, EVENT_BUFF, EVENT_STAMINA, EVENT_DROP_GOLDBOX, EVENT_DROP_SILVERBOX, EVENT_GOLD, EVENT_SKIN_EXP, EVENT_SELL_PRICE_UP, EVENT_SKIN_UPGRADE, EVENT_WEAPON_GRIND, EVENT_RANK_EXP, EVENT_ATTENDANCE, EVENT_MISSION, EVENT_GACHA, EVENT_STEPUP_GACHA, EVENT_BINGO_GACHA, EVENT_PLAYERCOUNT, EVENT_EXCHANGE, EVENT_EXCHANGE_RANDOM_BOX, EVENT_WORLD_AREA, EVENT_STAGE, EVENT_LIST_STAGE, EVENT_FINAL_BOSS_STAGE, EVENT_DIA_SHOP_GIVE_PLUS, EVENT_COIN_SHOP_PRICE_DOWN, EVENT_WEAPON_SHOP_PRICE_DOWN, EVENT_COMMON_SHOP_PRICE_DOWN, EVENT_RANDOM_SHOP_PRICE_DOWN, EVENT_PVP_SHOP_PRICE_DOWN, EVENT_GUILD_SHOP_PRICE_DOWN, EVENT_DONATION, EVENT_ONE_PLUS_ONE, EVENT_SEASON_PASS, EVENT_COLLABORATION_COIN_SHOP, EVENT_GLOBAL_DROP, EVENT_NETMARBLE_WEB_EVENT, EVENT_PAYBACK, EVENT_WEAPON_POINT, EVENT_GAGUE_REWARD, EVENT_CHALLENGE_BOSS, EVENT_QUEST_LIST, EVENT_MISSION_TIME_ATTACK, EVENT_LADDER, EVENT_CHALLENGE_DESTROY, EVENT_LOBBY_GIFT, EVENT_SNS_SHARE, EVENT_FURNITURE, EVENT_LOBBY_DECORATION
	}
	public enum EventOpenType // TypeDefIndex: 4637
	{
		AlwaysOpen, CurrentOpen, CurrentClose, EventClose
	}
	public class ServerEventInfo // TypeDefIndex: 4771
	{
		public int seq; // 0x10
		public ServerEventType eventType; // 0x14
		public string eventJson; // 0x18
		public string eventTitle; // 0x20
		public string eventSubTitle; // 0x28
		public string imgURL; // 0x30
		public string linkURL; // 0x38
		public byte priority; // 0x40
		public string description; // 0x48
		public byte tabNumber; // 0x50
		public string tabName; // 0x58
		public byte tabPriority; // 0x60
		public int startRemainSec; // 0x64
		public int endRemainSec; // 0x68
		public DateTime toDate; // 0x70
		public DateTime fromDate; // 0x80
		public EventOpenType eventOpenType; // 0x90
		public int nextOpenReaminSec; // 0x94
		public int playAbleRemainSec; // 0x98
		public int timeIndex; // 0x9C
		public bool maintenance; // 0xA0
		public byte emphasis; // 0xA1

		public ServerEventInfo() { }
	}
	public class UserExchangeEventInfo // TypeDefIndex: 4773
	{
		public int eventSEQ; // 0x10
		public int exchangeID; // 0x14
		public byte dailyExchangeCount; // 0x18
		public byte totalExchangeCount; // 0x19
		public ServerEventType eventType; // 0x1C

		public UserExchangeEventInfo() { }
	}
	public class UserWorldAreaStageEventInfo // TypeDefIndex: 4782
	{
		public int eventSEQ; // 0x10
		public int regionID; // 0x14
		public int mainStageID; // 0x18
		public List<int> sideStageIDList = new List<int>(); // 0x20
		public int freeStageValue; // 0x28
		public int lastClearStageID; // 0x2C
		public int limitedStageValue; // 0x30
		public int bossStageValue; // 0x34

		public UserWorldAreaStageEventInfo() { }
	}
	public class UserFreeStageEventInfo // TypeDefIndex: 4783
	{
		public int eventSEQ; // 0x10
		public int eventSubIndex; // 0x14
		public int freeStageValue; // 0x18
		public int lastClearStageID; // 0x1C

		public UserFreeStageEventInfo() { }
	}
	public class UserPlayCountEventInfo // TypeDefIndex: 4788
	{
		public int eventSEQ; // 0x10
		public int eventSubIndex; // 0x14
		public short playCount; // 0x18
		public bool getReward; // 0x1A

		public UserPlayCountEventInfo() { }
	}
	public class UserStepupGachaEventInfo // TypeDefIndex: 4790
	{
		public int eventSEQ; // 0x10
		public int groupID; // 0x14
		public byte stepNo; // 0x18
		public byte stepCount; // 0x19
		public int mileage; // 0x1C
		public int mileageReward; // 0x20

		public UserStepupGachaEventInfo() { }
	}
	public class ClientSendEventAttendanceInfo // TypeDefIndex: 4792
	{
		public int eventSEQ; // 0x10
		public int eventSubIndex; // 0x14
		public short lastRewardIndex; // 0x18
		public byte dayFixRewardDay; // 0x1A
		public bool isRewardedToday; // 0x1B

		public ClientSendEventAttendanceInfo() { }
	}
	public class UserGachaEventInfo // TypeDefIndex: 4789
	{
		public int eventSEQ; // 0x10
		public int eventSubIndex; // 0x14
		public byte buyCount; // 0x18

		public UserGachaEventInfo() { }
	}
	public class ClientSendEventMissionInfo // TypeDefIndex: 4833
	{
		public int eventSeq; // 0x10
		public int eventSubIndex; // 0x14
		public int chainID; // 0x18
		public byte rewardChainIndex; // 0x1C
		public int progressValue; // 0x20

		public ClientSendEventMissionInfo() { }
	}
	public class UserDonationEventInfo // TypeDefIndex: 4795
	{
		public int eventSEQ; // 0x10
		public int eventSubIndex; // 0x14
		public int basepointID; // 0x18
		public int donationValue; // 0x1C
		public byte rewardFlag; // 0x20

		public UserDonationEventInfo() { }
	}
	public class UserDiaBuyEventInfo // TypeDefIndex: 4801
	{
		public int eventSEQ; // 0x10
		public List<DiaBuyInfo> diaBuyInfoList = new List<DiaBuyInfo>(); // 0x18
		public int totalBuyCount; // 0x20

		public UserDiaBuyEventInfo() { }
	}
	public class DiaBuyInfo // TypeDefIndex: 4798
	{
		public int shopMoneyID; // 0x10
		public byte buyCount; // 0x14

		public DiaBuyInfo() { }
	}
	public class UserListStageEventInfo // TypeDefIndex: 4784
	{
		public int eventSEQ; // 0x10
		public int eventSubIndex; // 0x14
		public int freeStageValue; // 0x18
		public int mainStageTopClearID; // 0x1C
		public int lastClearStageID; // 0x20

		public UserListStageEventInfo() { }
	}
	public class UserFinalBossStageEventInfo // TypeDefIndex: 4785
	{
		public int eventSEQ; // 0x10
		public int eventSubIndex; // 0x14
		public int bossStageValue; // 0x18
		public int mainBossStageTopClearID; // 0x1C
		public int lastClearStageID; // 0x20

		public UserFinalBossStageEventInfo() { }
	}
	public class ClientSeasonPassRankRewardInfo // TypeDefIndex: 4800
	{
		public int eventSEQ; // 0x10
		public ServerEventType eventType; // 0x14
		public int eventSubIndex; // 0x18
		public int buySeasonPassPackageID; // 0x1C
		public List<SeasonPassRankRewardSlotInfo> rankRewardInfoList = new List<SeasonPassRankRewardSlotInfo>(); // 0x20

		public ClientSeasonPassRankRewardInfo() { }
	}
	public class SeasonPassRankRewardSlotInfo // TypeDefIndex: 4799
	{
		public int rank; // 0x10
		public long rewardFlag; // 0x18

		public SeasonPassRankRewardSlotInfo() { }
	}
	public class UserChallengeDestroyEventInfo // TypeDefIndex: 4796
	{
		public int eventSEQ; // 0x10
		public int eventSubIndex; // 0x14
		public int point; // 0x18
		public int rewardIndex; // 0x1C
		public bool isWorldReward; // 0x20

		public UserChallengeDestroyEventInfo() { }
	}
	public class UserEventCollaborCoinShopBuyInfo // TypeDefIndex: 4781
	{
		public int eventSEQ; // 0x10
		public int eventSubIndex; // 0x14
		public ShopBuyInfo buyInfo; // 0x18

		public UserEventCollaborCoinShopBuyInfo() { }
	}
	public class UserBingoGachaEventInfo // TypeDefIndex: 4791
	{
		public int eventSEQ; // 0x10
		public int eventSubIndex; // 0x14
		public int reward; // 0x18
		public int progress; // 0x1C
		public List<int> slotList = new List<int>(); // 0x20

		public UserBingoGachaEventInfo() { }
	}
	public class UserPaybackEventInfo // TypeDefIndex: 4774
	{
		public int eventSEQ; // 0x10
		public int paybackGroupID; // 0x14
		public int progress; // 0x18
		public short rewardID; // 0x1C

		public UserPaybackEventInfo() { }
	}
	public class UserGagueEventInfo // TypeDefIndex: 4776
	{
		public int eventSEQ; // 0x10
		public int gagueGroupID; // 0x14
		public short progress; // 0x18
		public byte rewardIndex; // 0x1A

		public UserGagueEventInfo() { }
	}
	public class ChallengeBossEventInfoToClientSend // TypeDefIndex: 4787
	{
		public int eventSEQ; // 0x10
		public int eventSubIndex; // 0x14
		public DateTime expireDate; // 0x18
		public int bossStage; // 0x28
		public int rewardIndex; // 0x2C
		public short currentEventChallengeBossSeq; // 0x30
		public int remainSkinUsedSEQResetSec; // 0x34
		public int currentMissionGroupID; // 0x38

		public ChallengeBossEventInfoToClientSend() { }
	}
	public class ClientSendEventLobbyGiftInfo // TypeDefIndex: 4793
	{
		public int eventSEQ; // 0x10
		public int eventSubIndex; // 0x14
		public short lastRewardIndex; // 0x18
		public bool isRewardedToday; // 0x1A

		public ClientSendEventLobbyGiftInfo() { }
	}
	public class ClientSendTimeMissionEventInfo // TypeDefIndex: 4779
	{
		public int eventSeq; // 0x10
		public int remainSec; // 0x14

		public ClientSendTimeMissionEventInfo() { }
	}
	public class UserGlobalDropEventInfo // TypeDefIndex: 4778
	{
		public int eventSeq; // 0x10
		public List<int> globalDropSlotItemCountList = new List<int>(); // 0x18

		public UserGlobalDropEventInfo() { }
	}
	public class UserSnsShareEventInfo // TypeDefIndex: 5013
	{
		public int eventSEQ; // 0x10
		public int eventSubIndex; // 0x14
		public short shareCount; // 0x18
		public bool rewardYN; // 0x1A

		public UserSnsShareEventInfo() { }
	}
	public class UserEventLobbyDecorationInfo // TypeDefIndex: 4777
	{
		public int eventSEQ; // 0x10
		public int eventSubIndex; // 0x14
		public int rewardFlag; // 0x18

		public UserEventLobbyDecorationInfo() { }
	}
	public class UserWeeklyStageEventInfo // TypeDefIndex: 4777
	{
		public int eventSEQ; // 0x10
		public int eventSubIndex; // 0x14
		public int firstWeeklyValue; // 0x18
		public int lastClearStageID; // 0x1C

		public UserWeeklyStageEventInfo() { }
	}
	public class EventPacketInfo // TypeDefIndex: 4668
	{
		public List<ServerEventInfo> serverEventInfoList = new List<ServerEventInfo>(); // 0x10
		public List<UserExchangeEventInfo> userExchangeInfoList = new List<UserExchangeEventInfo>(); // 0x18
		public List<UserWorldAreaStageEventInfo> userWorldAreaStageEventInfoList = new List<UserWorldAreaStageEventInfo>(); // 0x20
		public List<UserFreeStageEventInfo> userFreeStageEventInfoList = new List<UserFreeStageEventInfo>(); // 0x28
		public List<UserPlayCountEventInfo> userPlayCountEventInfoList = new List<UserPlayCountEventInfo>(); // 0x30
		public List<UserGachaEventInfo> userGachaEventInfoList = new List<UserGachaEventInfo>(); // 0x38
		public List<UserStepupGachaEventInfo> userStepupGachaEventInfoList = new List<UserStepupGachaEventInfo>(); // 0x40
		public List<ClientSendEventAttendanceInfo> userAttendanceEventInfoList = new List<ClientSendEventAttendanceInfo>(); // 0x48
		public List<ClientSendEventMissionInfo> userMissionEventInfoList = new List<ClientSendEventMissionInfo>(); // 0x50
		public List<UserListStageEventInfo> userListStageEventInfoList = new List<UserListStageEventInfo>(); // 0x58
		public List<UserFinalBossStageEventInfo> userFinalBossStageEventInfoList = new List<UserFinalBossStageEventInfo>(); // 0x60
		public List<UserDonationEventInfo> userDonationEventInfoList = new List<UserDonationEventInfo>(); // 0x68
		public List<UserDiaBuyEventInfo> userDiaBuyEventInfoList = new List<UserDiaBuyEventInfo>(); // 0x70
		public List<ClientSeasonPassRankRewardInfo> userSeasonPassRankRewardInfoList = new List<ClientSeasonPassRankRewardInfo>(); // 0x78
		public List<UserEventCollaborCoinShopBuyInfo> userCollaborationCoinShopBuyInfoList = new List<UserEventCollaborCoinShopBuyInfo>(); // 0x80
		public List<UserPaybackEventInfo> userPaybackInfoList = new List<UserPaybackEventInfo>(); // 0x88
		public List<UserGagueEventInfo> userGagueEventInfoList = new List<UserGagueEventInfo>(); // 0x90
		public List<ChallengeBossEventInfoToClientSend> userChallengeBossEventInfoClientSendList = new List<ChallengeBossEventInfoToClientSend>(); // 0x98
		public List<UserBingoGachaEventInfo> userBingGachaEventInfoList = new List<UserBingoGachaEventInfo>(); // 0xA0
		public List<UserGlobalDropEventInfo> userGlobalDropEventInfoList = new List<UserGlobalDropEventInfo>(); // 0xA8
		public List<UserChallengeDestroyEventInfo> userChallengeDestroyEventInfoList = new List<UserChallengeDestroyEventInfo>(); // 0xB0
		public List<ClientSendTimeMissionEventInfo> userTimeMissionEventInfoList = new List<ClientSendTimeMissionEventInfo>(); // 0xB8
		public List<ClientSendEventLobbyGiftInfo> userLobbyGiftEventInfoList = new List<ClientSendEventLobbyGiftInfo>(); // 0xC0
		public List<UserSnsShareEventInfo> userSnsShareEventInfoList = new List<UserSnsShareEventInfo>(); // 0xC8
		public List<UserEventLobbyDecorationInfo> userLobbyDecorationEventInfoList = new List<UserEventLobbyDecorationInfo>(); // 0xD0
		public List<UserWeeklyStageEventInfo> userWeeklyStageEventInfoList = new List<UserWeeklyStageEventInfo>(); // 0xD0

		public EventPacketInfo() { }
	}
	public class LobbyGuestInfo // TypeDefIndex: 4810
	{
		public List<int> heroGuestIDList = new List<int>(); // 0x10
		public int currentVisitGuestID; // 0x18
		public bool newHeroVisit; // 0x1C
		public int remainHeroVisitTimeSec; // 0x20
		public int currentVisitGuestIndex; // 0x24

		public LobbyGuestInfo() { }
	}
	public enum ADViewContentType // TypeDefIndex: 4652
	{
		None, ad_stanmina_charge, ad_free_gamble, ad_shop_change, ad_hero_fellowship, ad_free_item_gotcha, ad_free_coin_item, ad_daily_reward, ad_stage_roulette_reward
	}
	public class UserADViewInfo // TypeDefIndex: 5014
	{
		public ADViewContentType adViewContentType; // 0x10
		public int viewCount; // 0x14
		public int coolRemainSec; // 0x18
		public short roulettePoint; // 0x1C
		public int lastViewUnxs; // 0x20

		public UserADViewInfo() { }
	}
	public class SubdueBossPlayInfo // TypeDefIndex: 4861
	{
		public int groupID; // 0x10
		public int playCount; // 0x14
		public int initRemainSec; // 0x18
		public int playSeq; // 0x1C

		public SubdueBossPlayInfo() { }
	}
	public class UserDailyReset // TypeDefIndex: 4809
	{
		public byte barrelCount; // 0x10
		public byte friendDeleteCount; // 0x11
		public byte floorSearchValue1; // 0x12
		public byte floorSearchValue2; // 0x13
		public byte floorSearchValue3; // 0x14
		public byte floorSearchValue4; // 0x15
		public List<QuestProgressInfo> lobbyQuestProgressInfoList = new List<QuestProgressInfo>(); // 0x18
		public ClientSendUserAttendanceInfo attendanceInfo; // 0x20
		public List<int> birthdayGuestIDList = new List<int>(); // 0x28
		public int basepointDailyReward; // 0x30
		public byte cleanTableCount; // 0x34
		public byte serveBeerCount; // 0x35
		public byte playJukeboxCount; // 0x36
		public byte elizabethTouchCount; // 0x37
		public byte hawkAngerCount; // 0x38
		public byte meliodasCookingCount; // 0x39
		public byte barrelFellowCount; // 0x3A
		public int friendPointGainCount; // 0x3C
		public byte heroGachaOneDiaCount; // 0x40
		public byte helbramCount; // 0x41
		public byte friendCookingEatCount; // 0x42
		public byte guildDonationCount1; // 0x43
		public byte guildDonationCount2; // 0x44
		public byte guildShopResetCount; // 0x45
		public byte eventExchangeBoxGachaResetCount; // 0x46
		public byte eventGagueChargeFreeCount; // 0x47
		public byte eventGagueChargetPoint; // 0x48
		public byte guildDonationContribution; // 0x49
		public StageInfo stageInfo; // 0x50
		public List<UserPackageInfo> userPackageInfoList = new List<UserPackageInfo>(); // 0x58
		public List<UserPackageInfo> userDiaShopPackageInfoList = new List<UserPackageInfo>(); // 0x60
		public CoinShopRotationTabInfo coinShopRotationInfo; // 0x68
		public List<ShopBuyInfo> coinShopDailyBuyInfoList = new List<ShopBuyInfo>(); // 0x70
		public List<GuildMissionInfo> guildMissionInfoList = new List<GuildMissionInfo>(); // 0x78
		public EventPacketInfo eventPacketInfo; // 0x80
		public byte inviteSpecialGuestCount; // 0x88
		public byte trainingStageRefreshCount; // 0x89
		public LobbyGuestInfo lobbyGuestInfo; // 0x90
		public List<UserADViewInfo> userAdViewInfoList = new List<UserADViewInfo>(); // 0x98
		public List<SubdueBossPlayInfo> subdueBossPlayInfoList = new List<SubdueBossPlayInfo>(); // 0xA0

		public UserDailyReset() { }
	}
	public class UserRecipeInfo // TypeDefIndex: 4815
	{
		public int recipeID; // 0x10
		public int recipeExp; // 0x14
		public bool recipeActive; // 0x18

		public UserRecipeInfo() { }
	}
	public class EventBasepointInfo // TypeDefIndex: 4841
	{
		public int eventSeq; // 0x10
		public int basepointID; // 0x14
		public int lastClearLoopQuestID; // 0x18

		public EventBasepointInfo() { }
	}
	public class BasePointInfo // TypeDefIndex: 4840
	{
		public int basePointID; // 0x10
		public int fellowshipExp; // 0x14
		public int trigger; // 0x18
		public int uniqueInteractiveFlag; // 0x1C
		public int lastClearLoopQuestID; // 0x20
		public int loopRandomQuestID; // 0x24
		public int overDonationValue; // 0x28
		public List<int> disableDropInteractiveList = new List<int>(); // 0x30

		public BasePointInfo() { }
	}
	public class UserBasePointContentsInfo // TypeDefIndex: 4808
	{
		public List<BasePointInfo> basePointInfoList = new List<BasePointInfo>(); // 0x10
		public List<EventBasepointInfo> eventBasepointInfoList = new List<EventBasepointInfo>(); // 0x18

		public UserBasePointContentsInfo() { }
	}
	public enum UserLoginState // TypeDefIndex: 4572
	{
		None, Login, StepOut, Logout
	}
	public enum GuildMemberGrade // TypeDefIndex: 4577
	{
		None, Applicant, Normal, SubMaster, Master
	}
	public class GuildMemberInfo // TypeDefIndex: 4707
	{
		public int guildSN; // 0x10
		public long usn; // 0x18
		public GuildMemberGrade grade; // 0x20
		public string nickname; // 0x28
		public int userExp; // 0x30
		public int skinID; // 0x34
		public int remainSecToJoinEnable; // 0x38
		public DateTime joinEnableTime; // 0x40
		public DateTime joinTime; // 0x50
		public int afterLoginMin; // 0x60
		public int accumdContribution; // 0x64
		public int weeklyContribution; // 0x68
		public int prevWeeklyContirbution; // 0x6C
		public short weeklySeq; // 0x70
		public UserLoginState loginState; // 0x72
		public DateTime lastAttendTime; // 0x78
		public bool bTodayAttend; // 0x88
		public short stageClearCount; // 0x8A
		public short joinTimeWeeklySeq; // 0x8C
		public int playTitleID; // 0x90
		public DateTime attendRewardTime; // 0x98
		public string netmarblePID; // 0xA8

		public GuildMemberInfo() { }
	}
	public class DestroyDiscoverInfo // TypeDefIndex: 4889
	{
		public int region; // 0x10
		public byte discoverCount; // 0x14
		public byte gaugePoint; // 0x15
		public int pickGroupID; // 0x18
		public bool isClear; // 0x1C
		public DateTime closeDate; // 0x20
		public int remainSecToClose; // 0x30

		public DestroyDiscoverInfo() { }
	}
	public enum TutorialStatus // TypeDefIndex: 4623
	{
		None, Start, Reward, Complete
	}
	public enum TutorialType // TypeDefIndex: 4622
	{
		None, Skin_Levelup_Tutorial, Skin_Awaken_Tutorial, Single_Siege_Move_Tutorial, Weapon_Equip_Tutorial, Weapon_Grind_Tutorial, Weapon_Evolution_Tutorial, Costume_Regist_Tutorial, BasePoint_Tutorial, Weapon_Set_Tutorial, Weapon_Upgrade_Tutorial, Cooking_Tutorial, Team_Setting_Tutorial, Town_Move_Tutorial, Auto_Move_Tutorial, Final_Boss_Tutorial_01, Hero_Evolution, Special_levelUp, Area_Reward, Stage_Week_Tutorial, Exchange_Tutorial, Boss_Stage_Tutorial, Destroy_Stage_Tutorial, Ban_Cooking_Tutorial_01, Ban_Cooking_Tutorial_02, Hawk_Recipe_Tutorial, PVP_Join_Tutorial, PVP_Ranking_Tutorial, PVP_Reward_Tutorial, Hero_Fate_Tutorial, Week_Stage_Tutorial, Closet_Tutorial, Quest_Guide_Tutorial, Week_Event_Tutorial_01, Week_Event_Tutorial_02, Town_Fellowship_Tutorial, Lobby_Interaction_Tutorial_01, Lobby_Interaction_Tutorial_02, Storage_Tutorial, Pvp_Hall_Of_Fame, Housing_Tutorial, Guild_Boss_Tutorial, Weapon_Carve_Tutorial, Hero_Road_Tutorial, Reverse_Stage_Tutorial, Seq_Tutorial, Diane_Lobby_Tutorial, Ban_Lobby_Tutorial, King_Lobby_Tutorial, Gowther_Lobby_Tutorial
	}
	public class UserTutorialInfo // TypeDefIndex: 4925
	{
		public TutorialType tutorialType; // 0x10
		public TutorialStatus tutorialStatus; // 0x11
		public int tutorialStep; // 0x14

		public UserTutorialInfo() { }
	}
	public class ChatQuickMessageInfo // TypeDefIndex: 4909
	{
		public byte slotNumber; // 0x10
		public string message; // 0x18

		public ChatQuickMessageInfo() { }
	}
	public class ChatStampBookmarkInfo // TypeDefIndex: 4908
	{
		public byte stampSlot; // 0x10
		public List<int> stampIDList = new List<int>(); // 0x18

		public ChatStampBookmarkInfo() { }
	}
	public class FoodBuffInfo // TypeDefIndex: 4813
	{
		public int foodItemID; // 0x10
		public byte useCount; // 0x14
		public bool isAutoFoodUse; // 0x15

		public FoodBuffInfo() { }
	}
	public enum InteractiveChoice // TypeDefIndex: 4589
	{
		None, Good, Normal, Bad
	}
	public enum NpcGiftState // TypeDefIndex: 4602
	{
		None, Waiting, Received
	}
	public class UserNpc // TypeDefIndex: 4686
	{
		public InteractiveChoice serverTalkAnswered; // 0x10
		public int guestID; // 0x14
		public byte giftIndex; // 0x18
		public int costumeID; // 0x1C
		public byte talkCount; // 0x20
		public int questionID; // 0x24
		public byte goodTalkCount; // 0x28
		public int lovePoint; // 0x2C
		public NpcGiftState giftState; // 0x30

		public UserNpc() { }
	}
	public class MarketMissionInfo // TypeDefIndex: 4834
	{
		public MissionType missionType; // 0x10
		public long missionValue; // 0x18

		public MarketMissionInfo() { }
	}
	public enum MissionType // TypeDefIndex: 4597
	{
		None, User_Rank, Gold_Gain, Hero_Get, HeroSkin_Gain, Equip_Gain, Stage_Destroy_Clear, Stage_Week_Clear, Stage_Story_Clear, Equip_AllSlot, Equip_Mount, FriendCount, Stamina_Use, UpgradeStone_Get, Stage_PVP_Clear, Stage_Low_PVP_Clear, Stage_PVP_Win, Stage_Low_PVP_Win, FriendHero_Use, HeroSkin_Awaken, Weapon_Upgrade_Success, Weapon_Upgrade_Fail, Weapon_Grind, Weapon_Evolution, Buy_DiaShop, Buy_FriendShop, Buy_TownShop_Count, Donation_Town_Count, Cooking_Complete, HeroSkin_Gamble_SpendDia, HeroSkin_Gamble_Count, TownObject_Open, Hero_Get_SevenSin, HeroSkin_Get_SevenSin, Stage_PVP_Lose, Stage_Low_PVP_Lose, Region_Visit, Region_Quest_Clear_Story, Region_Quest_Clear_Side, Butt_Hoke_Count, Reservation_Count, HokeMom_Fly_Count, ChangeClothes_Count, LobbyClothes_Get, Stage_Battle_CardUse_Lv2, Stage_Battle_CardUse_Lv3, Stage_Battle_CardUse_Special, Stage_Battle_CardUse_Heal, Stage_Battle_CardUse_Abnormal, Memorial_Count, Stage_Free_Gain_Dia, Stamp_Get_Count, SupportHero_Finish_Count, Cooking_BestSuccess, Cooking_Leftover_Count, AwakenHero_Victory_Count, Stage_Destroy_AliveCount, Hero_Evolution, HeroCoin_Gain, Food_Eat, Hero_SpecialSkill_LevelUp, Hero_LevelUp, HeroCostume_Get, WeaponCostume_Get, FellowshipPoint_Gain, King_Amber, Recipe_Collect, CoinShop_Buy, Recipe_Active, Recipe_Order, Stage_Boss_Clear, Stage_Free_Clear, HeroSkin_Gain_SSR, HeroSkin_Gain_UR, Stage_Event_AreaMain_Clear, Stage_Event_AreaFree_Clear, Stage_Event_Free_Clear, Weapon_Evolutionstone_get, Stage_Boss_AliveCount, Stage_Boss_Clear_oneperson, Stage_destroy_clear_oneperson, Basepoint_Fellowship_level, buy_Basepoint_shop_count_1, buy_Basepoint_shop_count_2, buy_Basepoint_randomshop_count, Cooking_Complete_delicious, Cooking_Complete_tasteless, Herocostume_skin_Get_SevenSin, Herocostume_weapon_Get_SevenSin, HeroCostume_Gain, Herocostume_skin_Gain, Herocostume_weapon_Gain, HeroSkin_Upgrade_Success, Hero_EvolutionBreak, hero_use_win, dia_gacha_get, event_freestage_clear, event_world_clear, Stage_Battle_CardUse_Lv1, Stage_Battle_Turn_Count, Stage_Battle_Counter_Pose, Stage_Battle_Buff_Shield, Stage_Battle_Debuff_Attack, Stage_Battle_Attack_Down, Stage_Battle_Skill_Attack, Stage_Battle_Special_Down, Stage_Battle_Special_Up, Stage_Battle_Rank_Down, Stage_Battle_Special_Skill, Stage_Battle_Hero_Alive, Stage_Battle_Type_Attack, Stage_Battle_SSR_Hero, Stage_Battle_UR_Hero, Stage_Battle_Woman_Win, Stage_Battle_Man_Win, Stage_Battle_Team_Power_Win, Donation_Town_Value, Stage_Extra_Clear, Stage_FinalBoss_Clear, Stage_FinalBoss_Play, Stage_FinalBoss_AliveCount, FinalBossPoint_Bronze_Gain, FinalBossPoint_Silver_Gain, FinalBossPoint_Gold_Gain, FinalBossSeasonShop_Buy, Costume_Head_Get, Costume_Head_Get_HeroID, CostumeShop_Buy, FellowShip_Reward_Receive, LovePoint_Reward_Receive, FriendlyMatch_Play, FriendlyMatch_Win, FriendlyMatch_Lose, Guild_Join, GuildShop_Buy, FriendCoinShop_Buy, Stage_Battle_None_Weapon_Win, Stage_Battle_Buff_Ice_Attack, Equip_Set_Effect, Equip_Setting_Full, HeroSkin_Level_Max, Stage_Battle_Mvp_Hero_Attribute, Stage_Battle_Mvp_Hero_Kind, Gift_Talk_Npc_Count, Gift_Npc_Count, Jukebox_Music_Change, Table_Clean, Table_Serving, Stage_Pvp_Play, Buy_Pvp_Shop_Count, Cooking_Meliodas_Count, FriendHero_Use_Attribute, FriendHero_Use_Kind, Friend_Coin_Send_Count, Friend_Visit_Food_Eat, Item_Sell_Count, Hawk_Run_Play, Recipe_Collect_Value, Guild_Attendance, Guild_Donation_Gold, Guild_Stage_Destroy_Clear_Together, Event_Hero_Get, Event_Mission_Clear, Event_Quest_Clear, Hero_Power_Set_Clear, Stage_Monster_Kill, Stage_Battle_CardNotUse_Special, Stage_Battle_CardNotUse_Heal, Stage_Battle_CardNotUse_NoMove, Stage_Battle_Under_NoMove_count, Stage_Battle_Under_Hero_Count, Stage_Battle_Under_Special_Count, Stage_Battle_Under_Team_Power_Clear, Stage_Battle_Turn_Count_Over, Stage_Battle_Hero_Kind, Stage_Battle_Hero_Attribute, Stage_Battle_SRBirth_HeroTeam, Stage_Battle_SSRBirth_HeroTeam, Stage_Battle_Debuff_Shock_Kill, Stage_Battle_Debuff_Poison_Kill, Stage_Battle_Max_Damage, Stage_Battle_Use_Food, Stage_Battle_NotUse_Food, Stage_Battle_HandicapSkill_Count, Stage_Battle_Over_HP, Stage_Drop_Item_Box, Dia_Gain, Evolution_Stone_Use, Upgrade_Stone_Use, Option_Random_Use, Stage_Battle_All_Attribute_Win, Stage_Battle_Training_Win, Stage_Destroy_Info_Clear, Stage_Boss_Clear_Region, Stage_Week_Clear_Region, Weapon_Upgrade, Quest_Story_Clear, Cooking_Eat_Battle, Hero_Get_SSR, Weapon_Equip_UR, Weapon_Carve_Count, Weapon_Grind_Once_Get_100, Stage_Destroy_Reject, Stage_Destroy_AI_Play, Gold_Gain_777, Feather_Get, Chess_Get, Anvil_Get, Goldbox_Count, Stamp_Count, Credit_Watch_Complete, Greeting_Text_Change_Count, Stage_High_PVP_Win_1, Stage_Low_PVP_Win_1, AR_Dance_All_Character, Stage_Training_Clear_Color, Stage_Low_PVP_Achievement_Point, stage_battle_over_debuff_petrifaction_count, stage_battle_over_debuff_freezing_count, stage_battle_over_debuff_preventpose_count, stage_battle_over_debuff_infection_count, stage_battle_over_buff_immune_count, stage_battle_over_decrease_gauge_count, stage_battle_over_skill_dissipation_count, stage_battle_over_skill_bust_count, stage_battle_over_skill_weakness_count, stage_battle_over_erase_buff_count, stage_battle_over_erase_pose_count, stage_battle_over_recovery_debuff_count, stage_battle_over_card_disuse_count, Stage_Destroy_Clear_RedDemon, Stage_Destroy_Clear_GrayDemon, Stage_Destroy_Clear_CrimsonDemon, Stage_Destroy_Hell_Clear_1, Stage_Destroy_Hell_Clear_Sr, Stage_Destroy_Extreme_Clear_AI, PVP_Shop_Buy, Stage_High_PVP_Win, FinalBoss_Hard_Clear, FinalBoss_Extreme_Clear, FinalBoss_Hell_Clear, FinalBoss_Costume_Get, FinalBoss_Special_Skill_Hit_By, GuildBoss_Normal_Clear, GuildBoss_Hard_Clear, GuildBoss_Extreme_Clear, GuildBoss_Guild_1, GuildBoss_Normal_Point, GuildBoss_Hard_Point, GuildBoss_Extreme_Point, Stage_Training_Ban_Sevensins_Clear, RedDemon_Horn_Get, GrayDemon_Wing_Get, CrimsonDemon_Ear_Get, TownObject_Open_Lobby, TownObject_Open_Basepoint_1, TownObject_Open_Basepoint_2, TownObject_Open_Basepoint_3, TownObject_Open_Basepoint_4, TownObject_Open_Basepoint_5, TownObject_Open_Basepoint_6, Use_Combined_Attack_Drop_Mama, Stage_Boss_Use_Drop_Mama_Clear, Hwakmama_Worldmap_Move, Hwakmama_Faster_Move, Tavern_Decorations_Master_Hawk_Get, Stage_Boss_Lose, Stage_Free_Lose, Stage_Destroy_Lose, FinalBoss_Lose, Interactive_Talk_Ban, Interactive_Talk_Diane, Interactive_Talk_king, Interactive_Talk_Gowther, Interactive_Talk_Merlin, Interactive_Talk_Escanor, Change_Option_Use, Carve_Stone_Use, GuildBoss_Score_Count, FinalBoss_Score_Count, Mission_Achievepoint_Count, Gamble_Get_SSR_1, SevenSin_All_Get, Stage_Week_Gold_Clear, GuildBoss_Clear, FinalBoss_Clear, Playtime_Count, Stage_PVP_Season_Ranking_1, Stage_PVP_Season_Ranking_2, Stage_PVP_Season_Ranking_3, FinalBoss_Top_Rank_One_Percent, FinalBoss_Platinum_Crown_Get, FinalBoss_Gold_Crown_Get, FinalBoss_Silver_Crown_Get, FinalBoss_Bronze_Crown_Get, HeroSkin_Gain_UR_Count, HeroSkin_Awaken_Count, Stage_PVP_Season_Rank_all, Stage_Low_PVP_Win_Streak, Stage_Low_PVP_Lose_Streak, PVP_Shop_Sell, Stage_High_Challenge_Win_1, Stage_High_Challenge_Lose_1, Stage_High_Challenge_1, GuildBoss_Top_Rank_One_Percent, Stage_Training_Onetime_Light_Clear, Stage_Training_Onetime_Goldbox_Get, Stage_Training_Onetime_Bronzebox_Get, Stage_Destroy_Time_Out, Hero_Team_Power_Achieve
	}
	public enum DestroyInviteOption // TypeDefIndex: 4615
	{
		All, FriendOnly, None
	}
	public enum GuildJoiningApprovalType // TypeDefIndex: 4578
	{
		Free, Request
	}
	public class GuildInfo // TypeDefIndex: 4705
	{
		public int guildSN; // 0x10
		public string guildName; // 0x18
		public int guildExp; // 0x20
		public long masterUSN; // 0x28
		public string description; // 0x30
		public string notice; // 0x38
		public int emblemIconID; // 0x40
		public int emblemSubIconID; // 0x44
		public int emblemBgID; // 0x48
		public int guildPoint; // 0x4C
		public int skillPoint; // 0x50
		public GuildJoiningApprovalType joiningApprovalType; // 0x54
		public byte joiningLevelCondition; // 0x55
		public short memberCount; // 0x56
		public short applicantCount; // 0x58
		public string masterName; // 0x60
		public short attendSeq; // 0x68
		public short attendCount; // 0x6A
		public short prevAttendCount; // 0x6C
		public List<int> skillUseList = new List<int>(); // 0x70
		public byte level; // 0x78
		public short lastGuildMissionResetSeq; // 0x7A
		public int lastGuildMissionResetExp; // 0x7C
		public LanguageType languageType; // 0x80

		public GuildInfo() { }
	}
	public class UserBuffInfo // TypeDefIndex: 4942
	{
		public UserBuffType buffType; // 0x10
		public int targetID; // 0x14
		public int passiveID; // 0x18
		public int remainSecToRemove; // 0x1C

		public UserBuffInfo() { }
	}
	public enum UserBuffType // TypeDefIndex: 4636
	{
		None, Guest, Destroy, Donation
	}
	public class UserHeroGachaGaugeInfo // TypeDefIndex: 4943
	{
		public int gambleGroup; // 0x10
		public int eventSeq; // 0x14
		public int gauge; // 0x18

		public UserHeroGachaGaugeInfo() { }
	}
	public class LoginUserResultInfo // TypeDefIndex: 4669
	{
		public long usn; // 0x10
		public int sessionKey; // 0x18
		public string name; // 0x20
		public int nicknameChangeCount; // 0x28
		public int exp; // 0x2C
		public int vipExp; // 0x30
		public List<NoticeInfo> noticeList; // 0x38
		public List<UserHero> userHeroList; // 0x40
		public List<UserSkin> userSkinList; // 0x48
		public List<UserWeapon> userWeaponList; // 0x50
		public List<UserCommonItem> userCommonItemList; // 0x58
		public UserExtensionData extensionData; // 0x60
		public List<UserTeam> userTeamList; // 0x68
		public OtherPlayerTeamInfo arenaRankingDefenceTeamInfo; // 0x70
		public List<OtherPlayerTeamInfo> arenaSmashDefenceTeamInfoList; // 0x78
		public List<APInfo> userAPInfoList; // 0x80
		public StageInfo userStageInfo; // 0x88
		public string userWantToSay; // 0x90
		public int userMaxFriendCount; // 0x98
		public UserDailyReset userDailyReset; // 0xA0
		public List<UserRecipeInfo> userRecipeInfoList; // 0xA8
		public UserBasePointContentsInfo userBasePointContentsInfo; // 0xB0
		public List<int> autoStartQuestIDList; // 0xB8
		public List<QuestProgressInfo> userQuestProgressInfoList; // 0xC0
		public int missionAchieveRewardIndex; // 0xC8
		public GuildMemberInfo userGuildMemberInfo; // 0xD0
		public string userGuildName; // 0xD8
		public int frinedCode; // 0xE0
		public int playingDestroyRoomSN; // 0xE4
		public List<DestroyDiscoverInfo> userDestroyDiscoverInfoList; // 0xE8
		public byte userAgeLevel; // 0xF0
		public List<UserTutorialInfo> userTutorialInfoList; // 0xF8
		public List<ChatQuickMessageInfo> userQuickMessageInfoList; // 0x100
		public List<ChatStampBookmarkInfo> userStampBookmarkInfoList; // 0x108
		public bool rePayFlag; // 0x110
		public List<UserNpc> userNpcList; // 0x118
		public List<MarketMissionInfo> platformMissionInfoList; // 0x120
		public FoodBuffInfo foodBuffInfo; // 0x128
		public DestroyInviteOption destroyInviteOption; // 0x130
		public int userNicknameChangeAvailableRemainSec; // 0x134
		public List<UserCostumeSkin> userCostumeSkin; // 0x138
		public List<UserCostumeWeapon> userCostumeWeapon; // 0x140
		public List<UserCostumeHead> userCostumeHead; // 0x148
		public List<UserPackageInfo> userPackageInfoList; // 0x150
		public List<UserPackageInfo> userDiaShopPackageInfoList; // 0x158
		public int mainSkinID; // 0x160
		public int lobbyUniqueInteractiveFlag; // 0x164
		public int chapterRewardFlag; // 0x168
		public long anotherChapterRewardFlag; // 0x170
		public byte loveRewardSeq; // 0x178
		public GuildInfo userGuildInfo; // 0x180
		public List<GuildMemberInfo> guildMemberInfoList; // 0x188
		public bool isCheatEnable; // 0x190
		public bool realTimePvpRewardAble; // 0x191
		public List<UserBuffInfo> userBuffInfoList; // 0x198
		public List<UserHeroGachaGaugeInfo> userHeroGachaGaugeInfoList; // 0x1A0
		public int eventMissionAchieveRewardIndex; // 0x1A8
		public byte restDayCount; // 0x1AC
		public bool isPvpLowerClear; // 0x1AD
		public DateTime accountCreateTime; // 0x1B0
		public List<UserFurniture> userFurnitureList; // 0x1C0
		public List<FriendInfo> friendInfoList; // 0x1C8
		public List<UserFrozenAsset> userFrozenAssetList; // 0x1D0
		public ArenaLeagueGrade arenaRealTimePvpGrade; // 0x1D8
		public List<WeaponUpgradeFailGaugeInfo> userWeaponUpgradeFailGaugeList; // 0x1E0
		public UserMonthlyStageInfo monthlyInfo; // 0x1E8
		public List<int> eventMissionCompleteRewardInfoList; // 0x1F0
		public List<GuildMemberRankPoint> guildMemberRankPointList; // 0x1F8
		public GuildMemberRankPointReward guildMemberRankPointReward; // 0x200
		public bool isDecisionPlayAble; // 0x208
		public List<UserMusic> userMusicList; // 0x210
		public bool isGuideListRewarded; // 0x218
		public int playTitleID; // 0x21C
		public int playMusicID; // 0x220
		public byte musicInstrumentID; // 0x224
		public long freePackageReward; // 0x228
		public List<UserPackageMissionInfo> userPackageMissionInfoList; // 0x230
		public List<UserFinalBossRankPoint> userFinalBossRankPointList; // 0x238
		public List<int> getPlayTitleList; // 0x240
		public List<ReverseSeasonInfo> reverseSeasonInfoList; // 0x248
		public GuildWarUserSquadInfo guildWarUserSquadInfo; // 0x250
		public DestroyDisasterDicoverInfo destroyDisasterInfo; // 0x258
		public UserEventBingoInfo userEventBingoInfo; // 0x260
		public List<StageTicketClearInfo> userStageTicketClearInfoList; // 0x268
		public ArenaSmashLobbyInfo arenaSmashLobbyInfo; // 0x270
		public List<UserHeroPassiveGroupInfo> heroPassiveGroupInfoList; // 0x278
		public List<GuildWarDefenceTeamInfo> guildWarDefenceTeamInfoList; // 0x280
		public LoginUserResultInfo() { }
	}
	public class GuildWarDefenceTeamInfo // TypeDefIndex: 6002
	{
		// Fields
		public int guildSN; // 0x10
		public long usn; // 0x18
		public int teamIndex; // 0x20
		public OtherPlayerTeamInfo otherPlayerTeamInfo; // 0x28
		public GuildWarDefenceTeamInfo() { }
	}
	public class UserHeroPassiveGroupInfo // TypeDefIndex: 5650
	{
		// Fields
		public int heroPassiveGroup; // 0x10
		public byte dailyUseCount; // 0x14

		
		public UserHeroPassiveGroupInfo() { }
	}

	public class ArenaSmashUserInfo // TypeDefIndex: 6023
	{
		// Fields
		public int rank; // 0x10
		public byte winRewardPoint; // 0x14
		public int bestRank; // 0x18
		public bool bestReward; // 0x1C
		public int bestResetRaminSec; // 0x20
		public int opponentListRemainSec; // 0x24
		public ArenaSmashUserInfo() { }
	}

	public class ArenaSmashLobbyInfo // TypeDefIndex: 6024
	{
		// Fields
		public ArenaSmashUserInfo arenaSmashUserInfo; // 0x10
		public bool needJoin; // 0x18
		public bool needTeamSetting; // 0x19
		public int weeklyResetStartRaminSec; // 0x1C
		public int weeklyResetEndRemainSec; // 0x20
		public List<int> pvpModeList; // 0x28

		public ArenaSmashLobbyInfo() { }
	}

	public class StageTicketClearInfo // TypeDefIndex: 5696
	{
		// Fields
		public StageControlType controlType; // 0x10
		public byte clearCount; // 0x11
		public StageTicketClearInfo() { }
	
	}
	public enum StageControlType // TypeDefIndex: 5544
	{
		NONE = 0, MAIN = 1, MAIN_ESSENTIAL = 2, SUB_ENEMY_MAIN = 3, SUB_ENEMY_SUB = 4, SUB_REWARD = 5, FREE = 6, QUEST_MAIN = 7, QUEST_SUB = 8, LIMITED_MAIN = 9, LIMITED_DROP = 10, LIMITED_CLEAR = 11, BOSS = 12, UPGRADE = 13, EVOLUTION = 14, GOLD = 15, EVENT = 16, DESTROY = 17, MEMORIAL = 18, SUB_RUN = 19, EXTRA = 20, EXTRA_BOSS = 21, EXTRA_SIEGE_SINGLE = 22, EVENT_FINAL_BOSS_MAIN = 23, EVENT_FINAL_BOSS = 24, EVENT_MAIN = 25, EVENT_SUB_ENEMY = 26, EVENT_LIST_MAIN = 27, EVENT_WORLD_FREE = 28, EVENT_STAGE_FREE = 29, EVENT_STAGE_FREE_EXPERIENCE = 30, FINAL_BOSS = 31, EVENT_DESTROY = 32, EVENT_LIMITED = 33, EVENT_BOSS = 34, TRAINING = 35, EXTRA_MAIN = 36, MONTHLYSTAGE = 37, GUILD_BOSS = 38, CHALLENGEBOSS_EVENT = 39, EVENT_CHALLENGE_DESTROY = 40, ANOTHER_MAIN = 41, DOUBLE_FINAL_BOSS = 42, SUBDUE_BOSS = 43, REVERSE = 44, GUILD_WAR = 45, DISASTER_BOSS = 46, DISASTER_DESTROY = 47, TOWER = 48, TRIPLE_FINAL_BOSS = 49, BLITZ_MAIN = 50, BLITZ_SUB = 51, BLITZ_FREE = 52
	}

	public class UserEventBingoInfo // TypeDefIndex: 6020
	{
		// Fields
		public int eventSEQ; // 0x10
		public int eventSubIndex; // 0x14
		public int reward; // 0x18
		public int progress; // 0x1C
		public List<int> numberSlotList; // 0x20
		public List<int> rewardSlotList; // 0x28
		public byte resetCount; // 0x30
		public UserEventBingoInfo() { }
	}
	public class DestroyDisasterDicoverInfo // TypeDefIndex: 5848
	{
		// Fields
		public int seasonID; // 0x10
		public int bossStageClearFlag; // 0x14
		public int pickGroupID; // 0x18
		public bool isClear; // 0x1C
		public List<DestroyDisasterGaugeInfo> disasterGaugeInfoList; // 0x20
		public int remainSecToClose; // 0x28
		public DestroyDisasterDicoverInfo() { }
	}

	public class DestroyDisasterGaugeInfo // TypeDefIndex: 5849
	{
		public int seasonID; // 0x10
		public byte disasterArea; // 0x14
		public byte discoverCount; // 0x15
		public byte gaugePoint; // 0x16
		public DestroyDisasterGaugeInfo() { }

	}

	public class GuildWarSquadSlot // TypeDefIndex: 6004
	{
		// Fields
		public byte slot; // 0x10
		public int heroID; // 0x14
		public long usn; // 0x18

		public GuildWarSquadSlot() { }
	}

	public class GuildWarUserSquadInfo // TypeDefIndex: 6005
	{
		public List<GuildWarSquadSlot> guildWarSquadSlotList; // 0x10
		public GuildWarUserSquadInfo() { }
	}

	public class NeedItemInfo // TypeDefIndex: 4710
	{
		public int itemID; // 0x10
		public int itemCount; // 0x14

		public NeedItemInfo() { }
	}
	public class UserMonthlyStageInfo // TypeDefIndex: 4980
	{
		public int monthlyID; // 0x10
		public byte lastCountRewardIndex; // 0x14
		public List<int> lastClearStageIDList = new List<int>(); // 0x18
		public int monthlyRemainSec; // 0x20

		public UserMonthlyStageInfo() { }
	}
	public class UserFrozenAsset // TypeDefIndex: 4977
	{
		public int seq; // 0x10
		public byte contentTypeID; // 0x14
		public List<NeedItemInfo> needItemInfoList = new List<NeedItemInfo>(); // 0x18

		public UserFrozenAsset() { }
	}
	public enum RatingType // TypeDefIndex: 4573
	{
		None, C, UC, R, SR, SSR, UR, Max
	}
	public class WeaponUpgradeFailGaugeInfo // TypeDefIndex: 4957
	{
		public RatingType rating; // 0x10
		public short gauge; // 0x12

		public WeaponUpgradeFailGaugeInfo() { }
	}
	public class GuildMemberRankPoint // TypeDefIndex: 4989
	{
		public byte difficulty; // 0x10
		public short seq; // 0x12
		public int topRankPoint; // 0x14
		public int accumRankPoint; // 0x18

		public GuildMemberRankPoint() { }
	}
	public class GuildMemberRankPointReward // TypeDefIndex: 4990
	{
		public short seq; // 0x10
		public short rewardOrder; // 0x12

		public GuildMemberRankPointReward() { }
	}
	public enum ArenaLeagueGrade // TypeDefIndex: 4594
	{
		None, Bronze, Silver, Gold, Platinum, Master, Champion, Challenger, Max
	}
	public enum FriendState // TypeDefIndex: 4576
	{
		None, Send, Receive, Friend, Supporter, Recommend
	}
	public class FriendInfo // TypeDefIndex: 4681
	{
		public long friendUSN; // 0x10
		public string friendNickname; // 0x18
		public string friendWantToSay; // 0x20
		public int friendExp; // 0x28
		public int friendHeroID; // 0x2C
		public int friendSkinID; // 0x30
		public int friendAfterLoginMin; // 0x34
		public FriendState friendState; // 0x38
		public UserLoginState loginState; // 0x39
		public bool isFriendPointSend; // 0x3A
		public string guildName; // 0x40
		public int guildIconID; // 0x48
		public int guildSubIconID; // 0x4C
		public int guildBGIconID; // 0x50
		public bool friendCookingEatAlready; // 0x54
		public byte friendRecipeOrderCount; // 0x55
		public int playTitleID; // 0x58
		public short cookingEatDailySeq; // 0x5C
		public short friendCookingEatDailySeq; // 0x5E

		public FriendInfo() { }
	}
	public class UserMusic // TypeDefIndex: 4993
	{
		public int index; // 0x10
		public string name; // 0x18
		public int tempo; // 0x20
		public byte beat; // 0x24
		public string code; // 0x28

		public UserMusic() { }
	}
	public enum PackageMissionStatus // TypeDefIndex: 4646
	{
		Playing, Success, Cancel, Complete
	}
	public class UserPackageMissionInfo // TypeDefIndex: 4661
	{
		public DateTime packageBuyExpireDate; // 0x10
		public int progress; // 0x20
		public byte packageMissionID; // 0x24
		public PackageMissionStatus packageMissionStatus; // 0x25
		public int packageBuyExpireRemainSEC; // 0x28

		public UserPackageMissionInfo() { }
	}
	public class UserFinalBossRankPoint // TypeDefIndex: 5020
	{
		public int seasonID; // 0x10
		public int groupID; // 0x14
		public int topRankPoint; // 0x18
		public List<int> skinIDList = new List<int>(); // 0x20
		public int rank; // 0x28
		public int totolRankUpCount; // 0x2C
		public long usn; // 0x30
		public byte rewardYN; // 0x38
		public int topRankUnxs; // 0x3C

		public UserFinalBossRankPoint() { }
	}
	public class ReverseGroupInfo // TypeDefIndex: 5024
	{
		public short seasonID; // 0x10
		public short groupID; // 0x12
		public short firstClearFlag; // 0x14
		public int missionFlag; // 0x18

		public ReverseGroupInfo() { }
	}
	public class ReverseSeasonInfo // TypeDefIndex: 5023
	{
		public short seasonID; // 0x10
		public byte starRewardIndex; // 0x12
		public int groupRewardFlag; // 0x14
		public List<ReverseGroupInfo> reverseGroupInfoList = new List<ReverseGroupInfo>(); // 0x18

		public ReverseSeasonInfo() { }
	}
	public class UserFurniture // TypeDefIndex: 4701
	{
		public byte furnitureGroup; // 0x10
		public int furnitureID; // 0x14
		public int buffFurnitureID; // 0x18

		public UserFurniture() { }
	}
	public struct NetmarbleSDKInfo // TypeDefIndex: 4664
	{
		// Fields
		public string sdkJson; // 0x10
		public string storeType; // 0x18
		public string countryCode; // 0x20
		public string joinedCountryCode; // 0x28
		public string languageCode; // 0x30
		public string platformADID; // 0x38
		public string UDID; // 0x40
		public string OS; // 0x48
		public string timeZone; // 0x50
	}
	public struct VersionInfo // TypeDefIndex: 4931
	{
		// Fields
		public int clientVersion; // 0x10
		public int cdnVersion; // 0x14
	}
	public struct NetmarbleAccountInfo // TypeDefIndex: 4663
	{
		// Fields
		public string netmarblePlayerID; // 0x10
		public long usn; // 0x18
		public byte banStatus; // 0x20
		public short banReason; // 0x22
		public short banCode; // 0x24
		public int banLimitSec; // 0x28
		public string nickName; // 0x30
		public bool languageChangeAble; // 0x38
	}
	public class ChannelUserInfo // TypeDefIndex: 4923
	{
		public string netmarblePlayerID; // 0x10
		public long usn; // 0x18
		public string userNickName; // 0x20
		public int rank; // 0x28
		public int skinID; // 0x2C
		public DateTime lastLoginTime; // 0x30
		public bool isAdditionalDownloadNeeded; // 0x40
	}
	public enum LanguageType // TypeDefIndex: 4645
	{
		NONE, KR, JP, EN, CN_TD, CN_SP, TH, ID, IT, ES, PT, RU, DE, FR, MAX
	}
	public enum ClientDeviceType
	{
		iOS, Android
	}
	public enum PacketError
	{
		None, DB_System_Error, System_Error, Security_Verify_Failed, User_Max, Duplication, Invalid_User, Invalid_Connection, Invalid_USN, Invalid_Session, Invalid_TableInfo, Need_QA_Auth, Invalid_Auth, Already_AuthCreate, Need_Client_Update, Need_Cdn_Update, Under_Maintenance, Stage_Time_Error, Invalid_ReconnectRequest, Invalid_UserType, Invalid_Request, NotEnough_Item, NotEnough_AP, WeekStage_NotOpen, WeekStage_NewOpen, ArenaLeague_NotOpen, ArenaLeague_NotJoinCurrentLeague, Stage_NotComplete_Quest, Guild_Cannot_JoinOrCreateTime, Cannot_Connect_Redis, Need_DailyReset, ReconnectRequest_Wating, Destroy_NotExist_Room, Destroy_Not_Owner, Destroy_Not_Member, Destroy_Not_Found, Destroy_Not_JoinAnyRoom, Destroy_Already_TimeOver, Destroy_Already_Started, Destroy_Already_Finished, Destroy_Max_Member, Destroy_Invalid_RoomSerial, Destroy_Invalid_RoomState, Destroy_Invalid_UserSerial, Destroy_Invalid_Difficulty, Destroy_Cannot_CreateRoom, Destroy_Cannot_KickUserReady, Destroy_Cannot_ChangeTeamReady, Destroy_Not_ReadyAllMember, Destroy_Already_Created, Destroy_Already_Cleared, Destroy_Cannot_CreateUserBattle, Destroy_Invalid_RoundID, Destroy_Already_RoundFinished, Relay_NotExist_Room, Relay_Cannot_ListMember, Relay_Invalid_RoomState, Relay_Invalid_RoomSerial, Relay_Invalid_UserSerial, Relay_Not_Owner, Relay_Not_Member, Relay_Max_Member, Relay_Cannot_Connect, Relay_Not_JoinAnyRoom, Relay_Already_JoinOrCreate, Relay_Invalid_BattleExit, Relay_Already_Changed_Mode, Relay_Already_Join, Friend_Delete_Daily_Max, Event_Already_Closed, Event_Exchange_Max_Count, Event_Already_Reward, Event_Gacha_Max_Count, Event_Time_Over, Event_SeasonPass_Not_Buy_Package, Event_SeasonPass_Already_Buy_Package, Event_SeasonPass_Invalid_Rank_Reward, Event_SeasonPass_Buy_Package_Invalid_Time, Event_SeasonPass_Max_Rank, Recipe_Collect_Empty, Inventory_Full, Item_Count_Full, WeaponInventory_Full, Stamina_Full, PvpStamina_Full, TrainingStamina_Full, Gold_Full, Free_Dia_Full, Buy_Dia_Full, FriendPoint_Full, PvpCoin_Full, AchievePoint_Full, FellowshipPoint_Full, FinalBossCoin_Full, FinalBossPoint_Bronze_Full, FinalBossPoint_Silver_Full, FinalBossPoint_Gold_Full, GuildDonationMoney_Full, GuildGold_Full, Weekkey_Full, Mission_Max_Count, TrainingStage_NotOpen, Redis_Master_Change, Get_Item, Contents_Maintenance, FriendPoint_Daily_Full, WeaponLocked, Shop_Refresh_Reset_Count_Daily_Max, ItemBoxCodeIncorrect, BoxGacha_Empty, BoxGacha_Reset_UnAble, BoxGacha_Reset_Count_Over, ReTry_Send, NotEnough_AP_Event, NotEnough_AP_Evolution, NotEnough_AP_Gold, Weekly_Event_Item_Full, Weekly_Gold_Item_Full, TimeMission_End, TimeMission_Already_Started, RandomShop_Already_Closed, Shop_Invalid_Avilable_Time, Free_Package_Already_Reward, Free_Package_Need_Condition, PackageMission_Check_Condition, PackageMission_TimeOver, Contents_OFF_InApp_AD, Guild_Already_JoinOrCreate, Guild_Not_JoinOrCreate, Guild_Not_Applicant, Guild_Invalid_Serial, Guild_Invalid_GuildName, Guild_Invalid_ApprovalType, Guild_NotEnough_Grade, Guild_Cannot_Leave, Guild_Cannot_Apply, Guild_Room_NotOpen, Guild_Attend_First, Guild_NotExists_PrevAttendCount, Guild_NotExists_AttendanceTableInfo, Guild_Already_Attend_Reward, Guild_Cannot_Apply_LevelLimit, Guild_Shop_Seq_Changed, Guild_Shop_Buy_Count_Max, Guild_Not_Applicant_Member, Guild_NotEnough_GuildLevel, Guild_NotEnough_SkillPoint, Guild_Already_SkillUse, Guild_NotExists_OwnSkill, Guild_Working_OtherMember, GuildBoss_Seq_Change, GuildBoss_IsLocked, GuildWar_NotJoinedGuildMember, GuildWar_NotInSeason, GuildWar_SeasonChange, GuildWar_NotInBattleSetting, GuildWar_RegionBonusScoreAlreadyMax, GuildWar_RegionBonusScoreLimit, GuildWar_InTranRegionBonusScore, GuildWar_NotSelectionGuild, GuildWar_NotInBattleAndInBattleSetting, GuildWar_NotInBattle, GuildWar_InBattleAnotherUser, GuildWar_InvalidGuildSelectionInfo, GuildWar_InvalidGuildSquadInfo, GuildWar_NotInSquadUseHeroID, GuildWar_NotAliveUseHeroID, GuildWar_ExistUsedHeroID, GuildWar_RejoinTimeOut, GuildWar_NotClearNeedStage, GuildWar_InBattleRejoinTimeOut, GuildWar_AllowSeasonEnd, FriendlyMatch_Cannot_CreateRoom, FriendlyMatch_Invalid_Invite, FriendlyMatch_Invalid_Room, FriendlyMatch_Already_Start, FriendlyMatch_Room_Max, FriendlyMatch_Not_Enough_Member_Count, FriendlyMatch_Invalid_Ready, FriendlyMatch_Invalid_Team_Info, ArenaRealTimePvp_NotOpen, ArenaRealTimePvp_Need_Reload, ArenaRealTimePvp_AlreayMatching, ArenaRealTimePvp_MatchingServerError, ArenaRealTimePvp_OpponentUserError, ArenaRealTimePvp_NotEnough_UserLevel, ArenaRealTimePvp_PvpServerMaintenance, ArenaRealTimeDecision_NeedGrade, ArenaRealTimeDecision_NotOpen, ArenaRealTimeLower_NeedBattlePoint, ArenaDecision_MatchingList_Error, ArenaDecision_Check_Target_Status, ArenaDecision_Already_MatchingList, ArenaDecision_AttackCount_Overt, FinalBoss_Limit_PlayCount, FinalBoss_Not_In_Season, FinalBoss_Inactive, FinalBoss_Season_Change, FinalBoss_Mission_Rotation_Cool, FinalBoss_Mission_Rotation_Change, ADView_DailyLimited, ADView_NotCool, Guild_Mission_Already_Reward, Guild_Mission_Not_Achieve, TrainingStage_PlayCount_Over, TrainingStage_OpenCount_Over, TrainingStage_Already_Opend, Billing_Invalid_ItemID, Billing_Invalid_TransactionID, Billing_Already_Buy, Billing_Fail_InitScript, Billing_Fail_Parsing, Billing_Fail_Coupon, Billing_Fail_CrossPromotion, Billing_Fail_MarbleRequest, Billing_Fail_Invalied_Itemid, Billing_Need_Condition_Item, Billing_System_Error, Billing_Check_Age, Billing_Time_Over, SubdueBoss_NotExist_Game, SubdueBoss_NotCreate_Game, SubdueBoss_Not_Owner, SubdueBoss_Not_Member, SubdueBoss_Not_Found, SubdueBoss_Invalid_GameSerial, SubdueBoss_Invalid_NotInvite, SubdueBoss_Invalid_NotLobbyWait, SubdueBoss_Invalid_UserSerial, SubdueBoss_Not_ReadyAllMember, SubdueBoss_NotEnough_Member, SubdueBoss_NotEnough_Ticket, SubdueBoss_NotEnough_PlayCount, SubdueBoss_Close, SubdueBoss_Join_Fail, SubdueBoss_Invalid_QuestRequireLv, SubdueBoss_NotRewardEnableState, SubdueBoss_AlreayRewarded, SubdueBoss_NotInBattleState, SubdueBoss_Now_Allow_KickOut, SubdueBoss_Disconnect, SubdueBoss_Create_Fail_Invalid_SN, SubdueBoss_Join_Fail_UserFull, SubdueBoss_Join_Fail_HostLeave, SubdueBoss_Join_Fail_AlreadyJoin, SubdueBoss_Change_Time_Wait, NetmarbleQuest_Invalid_Request, NetmarbleQuest_Invalid_Result, NetmarbleQuest_Invalid_QuestSeq, NetmarbleQuest_Already_Achieved, NetmarbleQuest_NotEnough_Reward, NetmarbleSDK_Security_Fail, WestSide_Channel_Invalid_ID, WestSide_Channel_MaxUser, WestSide_UserDataLoadFail, WestSide_Server_Maintenance, WorldChatting_Channel_MaxUser, Tournament_Invalid_SEQ, Tournament_Invalid_Player, Tournament_Invalid_MatchIndex, Tournament_Not_Progress, Tournament_Not_Prepare, Tournament_Not_Open, Tournament_Not_Post, Tournament_Not_Replay, Tournament_Not_OpenRound, Tournament_Not_MatchWait, Tournament_Not_ExistRoom, Tournament_Not_ExistOpponent, Tournament_Invalid_MatchMemberCount, Tournament_Invalid_MatcState, Tournament_Already_Reward, Tournament_Invalid_Reward, Tournament_Already_Cheer, Tournament_Not_ExistPlayerTeam, Tournament_Not_ExistReplayInfo, AuthDB_Error, AuthDB_Nickname_Duplication, Auth_NicknameLength, UserDB_Error, UserDB_Already_Open, UserDB_Not_Enough_Item, UserDB_Nothing_Target, UserDB_Nothing_Material, UserDB_Skill_Level_Max, UserDB_Expired_Mail, UserDB_Too_Many_Get_Request, UserDB_No_Attached_Item, UserDB_Hero_Info_Not_Exist, UserDB_Skin_Info_Not_Exist, ArenaDB_Error, FriendDB_Error, FriendDB_Apply_Send_Max, FriendDB_Apply_Receive_Max, FriendDB_My_Friend_Max, FriendDB_Target_Friend_Max, FriendDB_Apply_Send_Already, FriendDB_Apply_Receive_Already, FriendDB_Already_Friend, FriendDB_State_Error, FriendDB_Target_Info_Invalid, FriendDB_Apply_Send_Invalid, FriendDB_Not_My_Friend, FriendDB_Already_Send_Point, FriendDB_Not_Found_User, GuildDB_Error, GuildDB_Cannot_Create_AlreadyJoin, GuildDB_Cannot_Create_NameDuplication, GuildDB_Guild_Not_Found, GuildDB_Cannot_Disband_RemainApplicant, GuildDB_Cannot_Disband_RemainMember, GuildDB_Cannot_Join_MemberMax, GuildDB_Cannot_Join_ApplicantMax, GuildDB_Cannot_Join_InvalidGuildSN, GuildDB_Cannot_Join_NotApplicant, GuildDB_Outside_Auth, GuildDB_Cannot_Change_RemainApplicant, GuildDB_Not_Guild_Member, GuildDB_Cannot_Change_NotMember, GuildDB_Cannot_Leave_Master, GuildDB_Cannot_Change_InvalidGrade, GuildDB_Cannot_Change_SameGrade, GuildDB_Cannot_Change_NotSubMaster, GuildDB_Cannot_Reward_Mission, GuildDB_NotEnough_SkillPoint, GuildDB_GuildWar_Area_Deploy_Change, MGTDB_Error
	}
	public enum InvalidRequestType
	{
		None, Auth_Invalid_NetmarblePlayerID, Auth_Invalid_NicknameLength, Auth_NotFound_User, Auth_Already_Login, Auth_Cannot_ChangeNickname, Common_Max_Level, Common_Max_Stamina, Common_Max_Inventory, Common_Max_Exp, Common_Invalid_Session, Common_Invalid_UserSerial, Common_Invalid_MaterialCount, Common_Invalid_Material, Common_Invalid_ItemID, Common_Invalid_ItemCount, Common_Invalid_ItemType, Common_Invalid_StringLength, Common_Invalid_Condition, Common_Invalid_HeroID, Common_Invalid_SkinID, Common_Invalid_WeaponSerial, Common_Invalid_WeaponSlot, Common_NotFound_TargetInfo, Common_Already_GiveReward, Common_NotEnough_UserLevel, Common_NotEnough_Material, Common_NotEnough_PriceItem, Common_Invalid_UserHero, Common_Use_BuyDia, Common_Invalid_NpcID, Common_Invalid_DailySeq, Common_Invalid_FrozenAssetSeq, Common_FrozenAsset_Content, common_ItemMusic_Already_Have, Cheat_Fail_Add, Stage_Not_ClearNeedStage, Stage_Not_ClearNeedQuest, Stage_Not_ProgressNeedQuest, Stage_Null_TopClearStageInfo, Stage_Invalid_StageInfo, Stage_Invalid_AlreadyClear, Stage_Invalid_AreaInfo, Stage_Already_Area_FirstReward, Stage_FreeStageDataError, Stage_Play_Dispatch, Stage_Repeat_Count, Stage_NotEnough_BasepointLevel, Stage_Invalid_InstantID, Stage_Weekly_Event_Reward_Notenough_Playcount, Stage_Cannot_UseMercenaryType, Stage_Cannot_Continue_LimitCount, Stage_Cannot_Continue_InvalidStageType, Stage_Event_Check_Condition, Stage_FinalBoss_InActive, Stage_Need_Hero, Team_Invalid_TeamIndex, Team_Invalid_TeamInfo, Team_NotEnough_UserRankSetFateSkin, Team_Invalid_Stage_Npc, Team_Invalid_HeroAttribute, Making_Max_EnableCount, Shop_NotEnough_BasepointLevel, Shop_Max_BuyCount, Shop_Max_SellCount, Shop_Invalid_ServerMode, Shop_NotEnough_Item, Shop_Max_Count_Over, Shop_Max_Stamina, Shop_Cannot_SellQuestItem, Shop_Invalid_AmountType, Shop_Not_Open_Gamble, Shop_Invalid_HeroCoinType, Shop_User_Rank_Over, Shop_Max_WeekKey, Shop_Invalid_FreeGamble_Time, Shop_Invalid_FreeGamble_Count, Shop_Invalid_Buy_Count, Shop_Coin_Count_Over, Shop_Invalid_GachaOneDiaCount, Shop_Cannot_GachaOneDia, Shop_Invalid_Free_Count, Shop_Invalid_Free_Time, Shop_Invalid_PriceType, Shop_Invalid_StepupTable, Shop_Invalid_StepupInfo, Shop_Invalid_StepupStepCount, Shop_No_StepupInfo, Shop_NotEnough_StepupMileage, Shop_Already_StepupMileageReward, Shop_Invalid_EventBingoGachaProgress, Shop_Already_EventBingoGachaReward, Shop_Invalid_Category, Fellowship_Max_DailyCount, Fellowship_Invalid_Level, Event_Invalid_Type, Event_Already_Finished, Event_Shop_Invalid_SlotIndex, Event_Shop_NotEnough_Buy_Count, Event_Shop_NotEnough_Item_Count, Event_NotEnough_Playcount, Event_NotEnough_DonationValue, Event_Invaild_User_Rank, Event_Invalid_MonthlyID, Event_Invalid_StoryID, Event_Invalid_StageID, Event_Invalid_RewardIndex, Event_NotEnough_MonthlyRewardPoint, Event_Payback_NotRewardData, Event_Payback_NotEnought_Progress, Event_Gague_Already_Free_Charge, Event_Gague_Already_MaxPoint, Event_Gague_Already_DailyMax, Event_Gague_Already_Reward, Event_Gague_NotEnough_Progress, Event_Gague_NotCharge, Event_NotEnough_Sns_Share_Count, Event_Already_Full_Sns_Share_Count, Cooking_Already_Cooking, Cooking_Max_CookingCount, Cooking_Invalid_CookingPoint, Cooking_Already_Finished, Cooking_Invalid_CookingID, Cooking_NotEnough_Material_Count, Cooking_No_Cooking, Cooking_Not_BuffFood, Cooking_Already_Food_Buff, Cooking_No_Auto_Use, Cooking_Make_Count_Over, Cooking_Already_Active, Boss_Not_Opened, Skin_Max_Capacity, Skin_NotEnough_Level, Skin_NotEnough_Pre_Research, Skin_Invalid_Research_Info, Skin_Invalid_RoleType, Skin_Invalid_Research_Rank, Skin_Invalid_Research_SkillType, Skin_Already_Research, Skin_Already_Awaken, Skin_Invalid_Awaken_Index, Skin_Not_Awaken_Max, Skin_Already_Research_Init, Skin_Already_Using, Skin_Invalid_Rating, Skin_Max_Awaken, Skin_Max_FellowshipExp, Skin_LookChange_Invalid_Rating, Skin_LookChange_Invalid_CostumeID, Skin_Already_SkillLevelUp_Max, Skin_Invalid_FellowshipRewardIndex, Skin_Invalid_PassiveSkillLevel, Skin_Invalid_LoveRewardSeq, Skin_OverEvolution_NeedMainStage, Skin_OverEvolution_NeedQuest, Weapon_Empty_Slot, Weapon_Invalid_Count, Weapon_NotSell_Equipped, Weapon_Max_Upgrade, Weapon_Already_Equipped, Weapon_NotEnough_SkinLevel, Weapon_Max_Evolution, Weapon_NotEnough_Upgrade, Weapon_NotEnough_Material, Weapon_Need_Evolution, Weapon_Invalid_Grind_ID, Weapon_Invalid_LookID, Weapon_Invalid_EvolutionCount, Weapon_Invalid_OptoinSlotIndex, Weapon_Invalid_Upgrade_Fail_Gauge, Weapon_NotEnough_Evolution, Weapon_Already_Carved, Weapon_Cannot_CarveNoSkin, Weapon_Not_Carved, Weapon_Cannot_CarveLockedGroup, Weapon_Cannot_UpgradeCarved, Weapon_Cannot_EvolutionCarved, Lobby_Invalid_GuestID, Lobby_Invalid_Object, Lobby_NotEnough_Item, Lobby_Cannot_Interact, Lobby_Diane_EyeContact_Max_DailyCount, Lobby_Invalid_SkinOwner, Lobby_Already_ElizabethCollect, Lobby_NotEnough_Count, Lobby_Already_GolemDispatch, Lobby_NotProcess, Lobby_Diane_NotEnough_Point, Lobby_Use_Team, Lobby_Diane_BasePoint_Close, Lobby_Error_RewardIndex, Lobby_Already_Reward, Lobby_Invalid_ID, Lobby_Talk_Already_Choice, Lobby_Invalid_Gift, Lobby_NotEnough_GiftItem, Lobby_Invalid_GuestSlot, Lobby_Invalid_EmptyGuest, Lobby_Invalid_UserNpc, Lobby_Invalid_GuestAnswerIndex, Lobby_Hero_NoVisit, Lobby_Count_Over, Lobby_Barrel_Not_Empty, Lobby_Duplicate_Item_ID, Lobby_Max_CleanTable, Lobby_Max_ServeBeer, Lobby_Max_PlayJukebox, Lobby_Max_ElizabethTouch, Lobby_Max_HawkAnger, Lobby_Invalid_GiftState, Lobby_Invalid_HeroRole, Lobby_Already_InteractObject, Lobby_NotEnough_GuestCondition, Lobby_Max_GuestChangeFree, Lobby_Already_GuestGiftReceived, Lobby_Cannot_InviteSpecialGuest, Lobby_UserMusic_Invalid_Index, Lobby_UserMusic_Invalid_Name, Lobby_UserMusic_Invalid_Name_Length, Lobby_UserMusic_Invalid_Beat, Lobby_UserMusic_Invalid_Tempo, Lobby_UserMusic_Invalid_Code, Lobby_UserMusic_Invalid_Code_Length, Lobby_UserMusic_Invalid_Save_Time_Not_Cool, Lobby_UserMusic_Invalid_Same_Data_Request, Mission_Invalid_ChainID, Mission_Invalid_ChainIndex, Mission_Invalid_AchieveRewardOrder, Mission_NotEnough_ClearCondition, Mission_NotEnough_AchievePoint, Mission_Invalid_MissionType, Mission_Invalid_AddValue, Mission_Not_EventContainsMission, Mission_Not_EventMissionAllClear, Mission_Already_GetCompleteReward, Mission_NotExist_CompleteReward, Mission_TimeAttack_End, Mission_TimeAttack_Already_Started, Quest_Already_ClearState, Quest_Already_Clear, Quest_Already_Progress, Quest_Already_Interacted, Quest_Not_Started, Quest_NotEnough_BasepointLevel, Quest_Not_ProgressingNeedQuest, Quest_Not_ClearNeedQuest, Quest_NotEnough_ClearCondition, Quest_Max_Count, Quest_Max_StoryQuest, Quest_Cannot_RemoveQuestClass, Quest_NotEnough_UserRank, Quest_Not_ClearPrevQuestGroup, Quest_Invalid_QuestType, Quest_Invalid_BasepointLevel, Quest_Invalid_LoopQuestID, Quest_Invalid_LoopRandomQuestID, Quest_Invalid_QuestID, Quest_Invalid_LobbyGroup, Quest_Already_GetChapterReward, Quest_Invalid_ChapterClearIndex, Quest_NotEnough_ChapterClearCondition, Quest_Invalid_QuestClass, Quest_Already_GuideListRewarded, Quest_Not_GuideListAllClear, BasePoint_Invalid_BasePointID, BasePoint_Not_Enter, BasePoint_Already_MaxFellowshipExp, BasePoint_Already_OpenedTrigger, BasePoint_Not_FiniteTrigger, BasePoint_Already_InteractiveBoxOpened, BasePoint_Already_Received_DailyReward, BasePoint_NotEnough_Fellow_Level, ArenaLeague_Invalid_OpponentUser, ArenaLeague_Already_JoinCurrentLeague, ArenaLeague_Already_BattleEnded, ArenaLeague_Cannot_RefreshPromotionMatch, ArenaLeague_Max_ShopBuyCount, ArenaLeague_Not_ClearedMission, ArenaLeague_Already_GetMissionReward, ArenaRealTimePvp_Invalid_TeamInfo, ArenaRealTimePvp_Shop_Invalid_Grade, ArenaRealTimePvp_Not_Join, ArenaRealTimePvp_NeedLowerClear, ArenaRealTimePvp_Not_Matching, Attendance_Already_Reward, Mail_Invalid_Confirm_All, Mail_Invalid_Serial, Mail_Already_Confirm, Tutorial_Already_Add_Step, Tutorial_Already_Set_Flag, Tutorial_Invalid_Type, Billing_Invalid_AgeLevel, Chat_NotExist_Stamp, Chat_Invalid_StampBookmarkCount, Chat_Invalid_BookmarkSlotNumber, Chat_Invalid_QuickMessageLength, Chat_Cannot_SendBothStampAndMessage, Chat_Invalid_StampSlot, RandomShop_Invalid_SlotIndex, RandomShop_Invalid_Slot, RandomShop_Max_Buy_Limit_Count_Over, RandomShop_Not_Open, RandomShop_No_Basepoint, RandomShop_Not_Enough_Basepoint_Fellowship, RandomShop_Already_Appear_Rewarded, Item_Max_Stack_Count_Over, Item_Cannot_Acquire_Anymore, Recipe_Not_Active, Recipe_Invalid_OrderSlot, WeekStageOpen_Already_Open, WeekStage_UnLock, WeekStage_CountOver, WeekStage_Mismatch_item, WeekStage_PlayCountFull, WeekStage_Not_ClearNeedQuest, WeekStage_NotEnough_Gauge, Costume_Invalid_CostumeID, Costume_Cannot_Found_User_Costume, Costume_User_Already_Have_Costume, Costume_Cannot_Buy_SkinNotExist, Costume_Invalid_Regist_Index, Costume_Invalid_Level, Package_User_Not_Buy, Package_Already_Reward, Package_NoneData, Package_Only_Cash, Package_NotEnough_Rank, CoinShopDaily_Invalid_SlotIndex, CoinShopDaily_Invalid_Slot, CoinShopDaily_Max_Buy_Limit_Count_Over, CoinShopDaily_Invalid_Buy_Date, FriendLobbyVisit_CookingEatLimitOver, FriendLobbyVisit_AlreadyFriendCookingEatToday, FriendLobbyVisit_NotFriendCookingRecipe, Guild_Donation_Count_Already_Initialized, Guild_Donation_DailyLimit_Check_Fail, Guild_Donation_Invalid_Donation_Count, Guild_Donation_Invalid_Donation_ConsumeItemList, Guild_Donation_Invalid_Donation_ConsumeItemCount, Guild_Shop_NotEnough_Guild_Level, Guild_Invalid_JoiningApprovalType, Guild_Invalid_emblemIconID, Guild_Invalid_emblemBgID, Guild_Invalid_emblemSubIconID, Guild_Invalid_UserRank, Guild_Invalid_Description_Length, Guild_Invalid_Notice_Length, Guild_Invalid_GuildSN, Guild_Invalid_AreaID, Guild_Invalid_USN, Guild_Not_Guild_ApplicantMember, Guild_Invalid_SkillSlot, Guild_Invalid_PersonalRewardOrder, Guild_Invalid_GuildBossSeasonGroup, Guild_NotEnough_PersonalRewardPoint, Guild_Invalid_BattlePointType, Friend_Max_Count, AD_NotEnough_RoulettePoint, Reverse_Invalid_SeasonID, Reverse_Invalid_UserGroupInfo, Reverse_Not_ClearAllStageGroup, Reverse_Already_GetReward, Reverse_Invalid_StarRewardIndex, Reverse_NotEnough_StageStar
	}
}