using Terraria.ModLoader;
using Terraria.ID;

namespace Intalium.Items.Tools
{
    public class UltimateAlloyPickaxe : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ultimate Alloy Pickaxe");
        }

        public override void SetDefaults()
        {
            item.value = 150000;
            item.useStyle = 1;
            item.useAnimation = 12;
            item.useTime = 5;
            item.useTurn = true;
            item.autoReuse = true;
            item.rare = 7;
            item.width = 60;
            item.height = 60;
            item.UseSound = SoundID.Item1;
            item.damage = 150;
            item.knockBack = 6.25f;
            item.melee = true;
            item.scale = 1.3f;
            item.pick = 300;
            item.tileBoost = 4;
            item.crit = 6;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "HardAlloyPickaxe", 1);
            recipe.AddIngredient(null, "HotAlloyPickaxe", 1);
            recipe.AddIngredient(null, "AwesomeAlloyPickaxe", 1);
            recipe.AddIngredient(null, "GreatAlloyPickaxe", 1);
            recipe.AddIngredient(null, "MagicAlloyPickaxe", 1);
            recipe.AddIngredient(null, "Shine", 8);
            recipe.AddIngredient(ItemID.PixieDust, 8);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
