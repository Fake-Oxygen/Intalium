using Terraria.ID;
using Terraria.ModLoader;

namespace Intalium.Items.Materials
{
	public class Hard_Alloy : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Hard Alloy");
			Tooltip.SetDefault("This poorly-forged reject alloy still gets the job done");
		}
		public override void SetDefaults()
		{
            item.value = 8000;
            item.rare = 0;
            item.maxStack = 999;
            item.width = 34;
            item.height = 39;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddRecipeGroup("Intalium:Tier1Bar", 1);
            recipe.AddRecipeGroup("Intalium:Tier2Bar", 1);
            recipe.AddRecipeGroup("Intalium:Tier3Bar", 1);
            recipe.AddRecipeGroup("Intalium:Tier4Bar", 1);
            recipe.AddIngredient(null, "Shine", 1);
            recipe.AddTile(TileID.Furnaces);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
