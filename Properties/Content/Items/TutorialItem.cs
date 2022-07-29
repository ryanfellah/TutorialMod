using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;

namespace TutorialMod.Properties.Content.Items;

internal class TutorialItem : ModItem
{
    public override void SetStaticDefaults()
    {
        DisplayName.SetDefault("Tutorial Item");
        Tooltip.SetDefault("This is a Tutorial Material\nThis is line 2");
        // This accesses the crative catalog 
        // Setting the research number to 100 before it can fully accessed 
        CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 100;
    }

    public override void SetDefaults()
    {

        Item.width = 16;     // Hitbox Width from Bottom Center
        Item.height = 16;    // Hitbox Height from Bottom Center

        Item.value = Item.buyPrice(copper: 5); // Value of the Item 120 = Silver: 1, Cooper: 20
        Item.maxStack = 999;

    }
}
