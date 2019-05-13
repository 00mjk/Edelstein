namespace Edelstein.Service.Game.Fields.User.Effects
{
    public enum EffectType
    {
        LevelUp = 0x0,
        SkillUse = 0x1,
        SkillAffected = 0x2,
        SkillAffected_Select = 0x3,
        SkillSpecialAffected = 0x4,
        Quest = 0x5,
        Pet = 0x6,
        SkillSpecial = 0x7,
        ProtectOnDieItemUse = 0x8,
        PlayPortalSE = 0x9,
        JobChanged = 0xA,
        QuestComplete = 0xB,
        IncDecHPEffect = 0xC,
        BuffItemEffect = 0xD,
        SquibEffect = 0xE,
        MonsterBookCardGet = 0xF,
        LotteryUse = 0x10,
        ItemLevelUp = 0x11,
        ItemMaker = 0x12,
        ExpItemConsumed = 0x13,
        ReservedEffect = 0x14,
        Buff = 0x15,
        ConsumeEffect = 0x16,
        UpgradeTombItemUse = 0x17,
        BattlefieldItemUse = 0x18,
        AvatarOriented = 0x19,
        IncubatorUse = 0x1A,
        PlaySoundWithMuteBGM = 0x1B,
        SoulStoneUse = 0x1C,
        IncDecHPEffect_EX = 0x1D,
        DeliveryQuestItemUse = 0x1E,
        RepeatEffectRemove = 0x1F,
        EvolRing = 0x20
    }
}