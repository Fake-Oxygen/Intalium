using Terraria.ID;
using Terraria.ModLoader;

namespace Intalium.Items.Materials
{
    public class GreatAlloy : ModItem //Zielony
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Great Alloy");
            Tooltip.SetDefault("Magical steel, sealed by the ancestors of the Patapon race that flourished in ancient times.");
        }
        public override void SetDefaults()
        {
            item.value = 30000;
            item.rare = 4;
            item.maxStack = 999;
            item.width = 34;
            item.height = 39;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.HallowedBar, 1);
            recipe.AddIngredient(ItemID.ChlorophyteBar, 1);
            recipe.AddIngredient(ItemID.SpectreBar, 1);
            recipe.AddIngredient(ItemID.ShroomiteBar, 1);
            recipe.AddIngredient(null, "Shine", 1);
            recipe.AddTile(TileID.AdamantiteForge);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
