using System;

namespace Edelstein.Provider.Templates
{
    [Flags]
    public enum TemplateCollectionType
    {
        All = int.MaxValue,

        Item = 0x1,
        Field = 0x2,
        NPC = 0x4,
        MakeCharInfo = 0x8,
        Commodity = 0x10,
        CashPackage = 0x20,
        ModifiedCommodity = 0x40,
        Best = 0x80,
        CategoryDiscount = 0x100,
        NotSale = 0x200,
        SetItemInfo = 0x400,
        ItemOption = 0x800,

        Login = Item | MakeCharInfo,
        Game = Item | Field | NPC | SetItemInfo | ItemOption,
        Shop = Item | Commodity | CashPackage | ModifiedCommodity | Best | CategoryDiscount | NotSale
    }
}