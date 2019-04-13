using Terraria.ModLoader;
using Terraria.ID;

namespace Intalium.Items.Tools
{
    public class UltimateAlloyHamaxe : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ultimate Alloy Hamaxe");
        }

        public override void SetDefaults()
        {
            item.value = 125000;
            item.useStyle = 1;
            item.useAnimation = 12;
            item.useTime = 6;
            item.useTurn = true;
            item.autoReuse = true;
            item.rare = 7;
            item.width = 60;
            item.height = 62;
            item.UseSound = SoundID.Item1;
            item.damage = 180;
            item.knockBack = 7;
            item.melee = true;
            item.scale = 1.3f;
            item.axe = 60;
            item.hammer = 200;
            item.tileBoost = 4;
            item.crit = 6;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "HardAlloyHamaxe", 1);
            recipe.AddIngredient(null, "HotAlloyHamaxe", 1);
            recipe.AddIngredient(null, "AwesomeAlloyHamaxe", 1);
            recipe.AddIngredient(null, "GreatAlloyHamaxe", 1);
            recipe.AddIngredient(null, "MagicAlloyHamaxe", 1);
            recipe.AddIngredient(null, "Shine", 6);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
