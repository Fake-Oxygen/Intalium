using Terraria.ModLoader;
using Terraria.ID;

namespace Intalium.Items.Tools
{
    public class PickaxeOfTerraria : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Pickaxe of Terraria");
        }

        public override void SetDefaults()
        {
            item.value = 250000;
            item.useStyle = 1;
            item.useAnimation = 12;
            item.useTime = 3;
            item.useTurn = true;
            item.autoReuse = true;
            item.rare = 8;
            item.width = 80;
            item.height = 80;
            item.UseSound = SoundID.Item1;
            item.damage = 240;
            item.knockBack = 8;
            item.melee = true;
            item.scale = 1.4f;
            item.pick = 375;
            item.tileBoost = 8;
            item.crit = 12;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "PreUltimatePickaxe", 1);
            recipe.AddIngredient(null, "UltimatePickaxe", 1);
            recipe.AddIngredient(null, "UltimateAlloyPickaxe", 1);
            recipe.AddIngredient(null, "Shine", 15);
            recipe.AddIngredient(ItemID.PixieDust, 25);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
