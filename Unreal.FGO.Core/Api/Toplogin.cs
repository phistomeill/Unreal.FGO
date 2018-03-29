using System.Threading.Tasks;
using Unreal.FGO.Core.Api;
using System.Collections.Generic;

namespace Unreal.FGO.Core.Api
{
    public class ToploginResponse
    {
        public string resCode { get; set; }
        public success success { get; set; }
        public fail fail { get; set; }
        public string nid { get; set; }
        public string usk { get; set; }
    }
    public class ToploginEquiptarget1
    {
        public string scalar { get; set; }
    }
    public class ToploginUsersvtleader
    {
        public string userId { get; set; }
        public string userSvtId { get; set; }
        public string svtId { get; set; }
        public string limitCount { get; set; }
        public string lv { get; set; }
        public string exp { get; set; }
        public int hp { get; set; }
        public int atk { get; set; }
        public string adjustHp { get; set; }
        public string adjustAtk { get; set; }
        public int skillId1 { get; set; }
        public string skillId2 { get; set; }
        public string skillId3 { get; set; }
        public string skillLv1 { get; set; }
        public string skillLv2 { get; set; }
        public string skillLv3 { get; set; }
        public int treasureDeviceId { get; set; }
        public string treasureDeviceLv { get; set; }
        public string classId { get; set; }
        public ToploginEquiptarget1 equipTarget1 { get; set; }
        public int updatedAt { get; set; }
        public int createdAt { get; set; }
    }
    public class ToploginUserlogin
    {
        public string userId { get; set; }
        public string seqLoginCount { get; set; }
        public string totalLoginCount { get; set; }
        public int lastLoginAt { get; set; }
        public string createdAt { get; set; }
    }
    public class ToploginTblfriend
    {
        public string userId { get; set; }
        public string friendId { get; set; }
        public string status { get; set; }
        public string updatedAt { get; set; }
        public string createdAt { get; set; }
    }
    public class ToploginUsersvtleaderhash
    {
        public string userId { get; set; }
        public string classId { get; set; }
        public string userSvtId { get; set; }
        public string svtId { get; set; }
        public string limitCount { get; set; }
        public string lv { get; set; }
        public string exp { get; set; }
        public string hp { get; set; }
        public string atk { get; set; }
        public string adjustHp { get; set; }
        public string adjustAtk { get; set; }
        public string skillId1 { get; set; }
        public string skillId2 { get; set; }
        public string skillId3 { get; set; }
        public string skillLv1 { get; set; }
        public string skillLv2 { get; set; }
        public string skillLv3 { get; set; }
        public string treasureDeviceId { get; set; }
        public string treasureDeviceLv { get; set; }
        public ToploginEquiptarget1 equipTarget1 { get; set; }
        public string updatedAt { get; set; }
        public string createdAt { get; set; }
    }
    public class ToploginOtherusergame
    {
        public string id { get; set; }
        public string userId { get; set; }
        public string appuid { get; set; }
        public string appname { get; set; }
        public string rksdkid { get; set; }
        public string rkchannel { get; set; }
        public string name { get; set; }
        public string birthDay { get; set; }
        public string actMax { get; set; }
        public string actRecoverAt { get; set; }
        public string carryOverActPoint { get; set; }
        public string genderType { get; set; }
        public string lv { get; set; }
        public string exp { get; set; }
        public string qp { get; set; }
        public string costMax { get; set; }
        public string friendCode { get; set; }
        public string favoriteUserSvtId { get; set; }
        public string friendKeepBase { get; set; }
        public string friendKeepAdjust { get; set; }
        public string commandSpellRecoverAt { get; set; }
        public string svtKeepBase { get; set; }
        public string svtKeepAdjust { get; set; }
        public string svtEquipKeepBase { get; set; }
        public string svtEquipKeepAdjust { get; set; }
        public string userEquipId { get; set; }
        public string freeStone { get; set; }
        public string chargeStone { get; set; }
        public string getPay { get; set; }
        public string mana { get; set; }
        public string mainDeckId { get; set; }
        public string activeDeckId { get; set; }
        public string tutorial1 { get; set; }
        public string tutorial2 { get; set; }
        public string tutorialProgress { get; set; }
        public string darkGachaNum { get; set; }
        public string mregtime { get; set; }
        public string zerotime { get; set; }
        public string sweepNum { get; set; }
        public string uflag { get; set; }
        public string md5str { get; set; }
        public string md5key { get; set; }
        public string regtime { get; set; }
        public string lasttime { get; set; }
        public string thawAt { get; set; }
        public string updatedAt { get; set; }
        public string createdAt { get; set; }
        public string rewardGetIds { get; set; }
        public string weekFriendPoint { get; set; }
        public string chargeRewardRecord { get; set; }
        public string firstgoldtime { get; set; }
        public string loginresettime { get; set; }
        public string last_ac { get; set; }
        public string last_ac_time { get; set; }
        public string appVer { get; set; }
        public List<ToploginUsersvtleaderhash> userSvtLeaderHash { get; set; }
        public string userName { get; set; }
        public string userLv { get; set; }
    }
    public class ToploginUsershop
    {
        public string userId { get; set; }
        public string shopId { get; set; }
        public string num { get; set; }
        public string updatedAt { get; set; }
        public string createdAt { get; set; }
    }
    public class ToploginUserevent
    {
        public string userId { get; set; }
        public string eventId { get; set; }
        public string value { get; set; }
        public string rank { get; set; }
    }
    public class ToploginUpdated
    {
        public List<HomeUserboxgacha> userBoxGacha { get; set; }
        public List<ToploginUserdeck> userDeck { get; set; }
        public List<ToploginUsersvtleader> userSvtLeader { get; set; }
        public List<ToploginUserlogin> userLogin { get; set; }
        public List<HomeTblfriend> tblFriend { get; set; }
        public List<ToploginOtherusergame> otherUserGame { get; set; }
        public List<ToploginUsershop> userShop { get; set; }
        public List<ToploginUserevent> userEvent { get; set; }
    }
    public class ToploginUsergame
    {
        public string id { get; set; }
        public string userId { get; set; }
        public string usk { get; set; }
        public string appuid { get; set; }
        public string appname { get; set; }
        public string rksdkid { get; set; }
        public string rkchannel { get; set; }
        public string name { get; set; }
        public string birthDay { get; set; }
        public string actMax { get; set; }
        public string actRecoverAt { get; set; }
        public string carryOverActPoint { get; set; }
        public string genderType { get; set; }
        public string lv { get; set; }
        public string exp { get; set; }
        public string qp { get; set; }
        public string costMax { get; set; }
        public string friendCode { get; set; }
        public string favoriteUserSvtId { get; set; }
        public string friendKeepBase { get; set; }
        public string friendKeepAdjust { get; set; }
        public string commandSpellRecoverAt { get; set; }
        public string svtKeepBase { get; set; }
        public string svtKeepAdjust { get; set; }
        public string svtEquipKeepBase { get; set; }
        public string svtEquipKeepAdjust { get; set; }
        public string userEquipId { get; set; }
        public string freeStone { get; set; }
        public string chargeStone { get; set; }
        public string getPay { get; set; }
        public string mana { get; set; }
        public string mainDeckId { get; set; }
        public string activeDeckId { get; set; }
        public string tutorial1 { get; set; }
        public string tutorial2 { get; set; }
        public string tutorialProgress { get; set; }
        public string darkGachaNum { get; set; }
        public string mregtime { get; set; }
        public string zerotime { get; set; }
        public string sweepNum { get; set; }
        public string uflag { get; set; }
        public string deviceinfo { get; set; }
        public string md5str { get; set; }
        public string md5key { get; set; }
        public string regtime { get; set; }
        public string lasttime { get; set; }
        public string thawAt { get; set; }
        public string updatedAt { get; set; }
        public string createdAt { get; set; }
        public string rewardGetIds { get; set; }
        public int weekFriendPoint { get; set; }
        public string chargeRewardRecord { get; set; }
        public string firstgoldtime { get; set; }
        public string loginresettime { get; set; }
        public string last_ac { get; set; }
        public string last_ac_time { get; set; }
        public string appVer { get; set; }
        public int stone { get; set; }
        public int friendKeep { get; set; }
        public int svtKeep { get; set; }
        public int svtEquipKeep { get; set; }
    }
    public class ToploginTblusergame
    {
        public string userId { get; set; }
        public int friendPoint { get; set; }
        public string updatedAt { get; set; }
        public string createdAt { get; set; }
    }
    public class ToploginUseritem
    {
        public string userId { get; set; }
        public string itemId { get; set; }
        public string num { get; set; }
        public string updatedAt { get; set; }
        public string createdAt { get; set; }
    }
    public class ToploginUsersvtcollection
    {
        public string userId { get; set; }
        public string svtId { get; set; }
        public string status { get; set; }
        public string maxLv { get; set; }
        public string maxHp { get; set; }
        public string maxAtk { get; set; }
        public string maxLimitCount { get; set; }
        public string skillLv1 { get; set; }
        public string skillLv2 { get; set; }
        public string skillLv3 { get; set; }
        public string treasureDeviceLv1 { get; set; }
        public string treasureDeviceLv2 { get; set; }
        public string treasureDeviceLv3 { get; set; }
        public string friendship { get; set; }
        public string friendshipRank { get; set; }
        public string voicePlayed { get; set; }
        public string updatedAt { get; set; }
        public string createdAt { get; set; }
    }
    public class ToploginUsersvt
    {
        public string id { get; set; }
        public string userId { get; set; }
        public string svtId { get; set; }
        public string limitCount { get; set; }
        public string dispLimitCount { get; set; }
        public string lv { get; set; }
        public string exp { get; set; }
        public string adjustHp { get; set; }
        public string adjustAtk { get; set; }
        public string status { get; set; }
        public string skillLv1 { get; set; }
        public string skillLv2 { get; set; }
        public string skillLv3 { get; set; }
        public string treasureDeviceLv1 { get; set; }
        public string treasureDeviceLv2 { get; set; }
        public string treasureDeviceLv3 { get; set; }
        public string selectTreasureDeviceIdx { get; set; }
        public string equipTargetId1 { get; set; }
        public string createdAt { get; set; }
        public string updatedAt { get; set; }
        public string isLock { get; set; }
        public int hp { get; set; }
        public int atk { get; set; }
    }
    public class ToploginSvts
    {
        public int? id { get; set; }
        public long? userSvtId { get; set; }
        public long? userId { get; set; }
        public List<int> userSvtEquipIds { get; set; }
        public bool? isFollowerSvt { get; set; }
    }
    public class ToploginDeckinfo
    {
        public List<ToploginSvts> svts { get; set; }
    }
    public class ToploginUserdeck
    {
        public int? id { get; set; }
        public long? userId { get; set; }
        public int? deckNo { get; set; }
        public string name { get; set; }
        public int? cost { get; set; }
        public ToploginDeckinfo deckInfo { get; set; }
    }
    public class ToploginUserequip
    {
        public string id { get; set; }
        public string userId { get; set; }
        public string equipId { get; set; }
        public string lv { get; set; }
        public string exp { get; set; }
        public string updatedAt { get; set; }
        public string createdAt { get; set; }
    }
    public class ToploginUserquest
    {
        public string userId { get; set; }
        public string questId { get; set; }
        public string questPhase { get; set; }
        public string clearNum { get; set; }
        public string isEternalOpen { get; set; }
        public string keyExpireAt { get; set; }
        public string keyCountRemain { get; set; }
        public string isNew { get; set; }
        public string lastStartedAt { get; set; }
        public string updatedAt { get; set; }
        public string createdAt { get; set; }
    }
    public class ToploginUsergacha
    {
        public string userId { get; set; }
        public string gachaId { get; set; }
        public string num { get; set; }
        public string tenNum { get; set; }
        public string freeDrawAt { get; set; }
        public string updatedAt { get; set; }
        public string createdAt { get; set; }
    }
    public class ToploginReplaced
    {
        public List<HomeUsergame> userGame { get; set; }
        public List<ToploginTblusergame> tblUserGame { get; set; }
        public List<HomeUseritem> userItem { get; set; }
        public List<ToploginUsersvtcollection> userSvtCollection { get; set; }
        public List<ToploginUsersvt> userSvt { get; set; }
        public List<ToploginUsersvtleader> userSvtLeader { get; set; }
        public List<ToploginUserdeck> userDeck { get; set; }
        public List<ToploginUserequip> userEquip { get; set; }
        public List<HomeUserquest> userQuest { get; set; }
        public List<ToploginUsergacha> userGacha { get; set; }
    }
    public class ToploginCache
    {
        public ToploginUpdated updated { get; set; }
        public ToploginReplaced replaced { get; set; }
        public int serverTime { get; set; }
    }
    public class ToploginRes : BaseResponse
    {

        public override int code
        {
            get
            {
                return response != null && response.Count > 0 ? int.Parse(response[0].resCode) : 99;
            }

            set
            {
                base.code = value;
            }
        }
        public override string message
        {
            get
            {
                return response != null && response.Count > 0 && response[0].fail != null ? response[0].fail.title + " " + response[0].fail.detail : base.message;
            }

            set
            {
                base.message = value;
            }
        }
        public List<ToploginResponse> response { get; set; }
        public ToploginCache cache { get; set; }
    }

    public class ToploginReq : BaseRequest<ToploginRes>
    {
        public ToploginReq(ServerApi api) : base(api)
        {
        }

        public override async Task<ToploginRes> Send(params string[] args)
        {
            PlatfromInfos["ac"] = "action";
            PlatfromInfos["key"] = args[0];
            var url = "/rongame_beta//rgfate/60_1001/ac.php";
            string getParam = null;
            getParam = getPlatfromInfo(new string[] { "_userId" });
            if (!string.IsNullOrEmpty(getParam))
                url += "?" + getParam;
            Dictionary<string, string> postParam = null;
            postParam = getPlatfromInfoDic(new string[] { "ac", "key", "deviceid", "os", "ptype", "usk", "umk", "rgsid", "rkchannel", "nickname", "sgtype", "sgtag", "userId", "appVer", "dateVer", "lastAccessTime", "try", "developmentAuthCode", "userAgent", "dataVer" });
            var response = await Post(url, postParam);
            if (response.code == 0)
            {
                PlatfromInfos["usk"] = response.response[0].usk;
                if (response.cache != null && response.cache.replaced != null)
                {
                    if (response.cache.replaced.userGame != null && response.cache.replaced.userGame.Count > 0)
                        serverApi.userGame = response.cache.replaced.userGame[0];

                    if (response.cache.replaced.userQuest != null && response.cache.replaced.userQuest.Count > 0)
                        serverApi.userQuest = response.cache.replaced.userQuest;

                    if (response.cache.replaced.userDeck != null && response.cache.replaced.userDeck.Count > 0)
                        serverApi.userDeck = response.cache.replaced.userDeck;

                    if (response.cache.replaced.userItem != null && response.cache.replaced.userItem.Count > 0)
                        serverApi.userItem = response.cache.replaced.userItem;

                    if (response.cache.replaced.userSvt != null)
                        serverApi.userSvt = response.cache.replaced.userSvt;
                }
                if (response.cache.updated != null && response.cache.updated.tblFriend != null && response.cache.updated.tblFriend.Count > 0)
                {
                    serverApi.UpdateFriend(response.cache.updated.tblFriend);
                }
                if (response.cache.updated != null && response.cache.updated.userDeck != null && response.cache.updated.userDeck.Count > 0)
                {
                    serverApi.userDeck = response.cache.updated.userDeck;
                }
                if (response.cache.updated != null && response.cache.updated.userBoxGacha != null)
                {
                    serverApi.userBoxGacha = response.cache.updated.userBoxGacha;
                }
            }
            return response;
        }
    }


}

namespace Unreal.FGO.Core
{
    public partial class ServerApi
    {
        public List<HomeTblfriend> blFriend { get; set; }
        public List<HomeUserboxgacha> userBoxGacha { get; internal set; }

        public void UpdateFriend(List<HomeTblfriend> friend)
        {
            if (blFriend == null)
                blFriend = friend;
            else if (friend != null && friend.Count > 0)
            {
                var count = blFriend.Count;
                var count2 = friend.Count;
                for (int i = 0; i < count2; i++)
                {
                    var find = false;
                    for (var j = 0; j < count; j++)
                    {
                        if (blFriend[j].userId == friend[i].userId)
                        {
                            blFriend[j] = friend[i];
                            find = true;
                            break;
                        }
                    }
                    if (!find)
                        blFriend.Add(friend[i]);
                }
            }
        }

        public void UpdateQuest(List<HomeUserquest> quest)
        {
            if (userQuest == null)
                userQuest = quest;
            else if (quest != null && quest.Count > 0)
            {
                var count = userQuest.Count;
                var count2 = quest.Count;
                for (int i = 0; i < count2; i++)
                {
                    var find = false;
                    for (var j = 0; j < count; j++)
                    {
                        if (userQuest[j].questId == quest[i].questId)
                        {
                            userQuest[j] = quest[i];
                            find = true;
                            break;
                        }
                    }
                    if (!find)
                        userQuest.Add(quest[i]);
                }
            }
        }
        public async Task<ToploginRes> Toplogin(string type = "toplogin")
        {
            return await new ToploginReq(this).Send(type);
        }
    }
}