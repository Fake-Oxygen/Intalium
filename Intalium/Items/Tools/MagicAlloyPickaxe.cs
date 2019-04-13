using Terraria.ModLoader;
using Terraria.ID;

namespace Intalium.Items.Tools
{
    public class MagicAlloyPickaxe : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Magic Alloy Pickaxe");
        }

        public override void SetDefaults()
        {
            item.value = 100000;
            item.useStyle = 1;
            item.useAnimation = 12;
            item.useTime = 9;
            item.useTurn = true;
            item.autoReuse = true;
            item.rare = 6;
            item.width = 46;
            item.height = 46;
            item.UseSound = SoundID.Item1;
            item.damage = 90;
            item.knockBack = 5.5f;
            item.melee = true;
            item.scale = 1.2f;
            item.pick = 250;
            item.tileBoost = 3;
            item.crit = 4;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "MagicAlloy", 16);
            recipe.AddIngredient(null, "Shine", 4);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
