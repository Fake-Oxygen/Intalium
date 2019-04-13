using Terraria.ID;
using Terraria.ModLoader;

namespace Intalium.Items.Materials
{
    public class MagicAlloy : ModItem //Żółty
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Magic Alloy");
            Tooltip.SetDefault("A magic alloy forged by Patapon ancestors during the tribe's peak");
        }
        public override void SetDefaults()
        {
            item.value = 45000;
            item.rare = 5;
            item.maxStack = 999;
            item.width = 34;
            item.height = 39;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.LunarBar, 1);
            recipe.AddIngredient(ItemID.FragmentNebula, 1);
            recipe.AddIngredient(ItemID.FragmentSolar, 1);
            recipe.AddIngredient(ItemID.FragmentStardust, 1);
            recipe.AddIngredient(ItemID.FragmentVortex, 1);
            recipe.AddIngredient(null, "Shine", 1);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
