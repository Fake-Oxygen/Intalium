using Terraria.ID;
using Terraria.ModLoader;

namespace Intalium.Items.Materials
{
    public class HotAlloy : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Hot Alloy");
            Tooltip.SetDefault("This expertly-forged alloy is a valuable resource");
        }
        public override void SetDefaults()
        {
            item.value = 15000;
            item.rare = 2;
            item.maxStack = 999;
            item.width = 34;
            item.height = 39;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddRecipeGroup("Intalium:Tier5Bar", 1);
            recipe.AddIngredient(ItemID.MeteoriteBar, 1);
            recipe.AddIngredient(ItemID.HellstoneBar, 1);
            recipe.AddIngredient(null, "Shine", 1);
            recipe.AddTile(TileID.Hellforge);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
