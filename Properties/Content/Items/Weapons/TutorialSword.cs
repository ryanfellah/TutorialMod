using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;
using TutorialMod.Properties.Content.Items.Weapons;

namespace TutorialMod.Properties.Content.Items.Weapons
{
    internal class TutorialSword : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Tutorial Sword");
            Tooltip.SetDefault("this is a modded Broadsword");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }


        public override void SetDefaults()
        {
            // Hitbox
            Item.width = 64;
            Item.height = 64;

            // Use and Animation Style
            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTime = 20;
            Item.useAnimation = 20;
            Item.autoReuse = true;

            // Damage Values
            Item.DamageType = DamageClass.Melee;
            Item.damage = 1000;
            Item.knockBack = 3.5f;
            Item.crit = 100;

            // Misc
            Item.value = Item.buyPrice(silver: 80, copper: 50);
            Item.rare = ItemRarityID.Blue;

            // Sound
            Item.UseSound = SoundID.Item1;
        }
            
        


        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ModContent.ItemType<TutorialItem>(), 8)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}
