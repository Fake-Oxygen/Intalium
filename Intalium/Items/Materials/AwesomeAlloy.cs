using Terraria.ID;
using Terraria.ModLoader;

namespace Intalium.Items.Materials
{
    public class AwesomeAlloy : ModItem //Niebieski
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Awesome Alloy");
            Tooltip.SetDefault("This exceedingly rare high-quality steel is as precious as gold");
        }
        public override void SetDefaults()
        {
            item.value = 25000;
            item.rare = 3;
            item.maxStack = 999;
            item.width = 34;
            item.height = 39;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddRecipeGroup("Intalium:Tier8Bar", 1);
            recipe.AddRecipeGroup("Intalium:Tier9Bar", 1);
            recipe.AddRecipeGroup("Intalium:Tier10Bar", 1);
            recipe.AddIngredient(null, "Shine", 1);
            recipe.AddTile(TileID.AdamantiteForge);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
