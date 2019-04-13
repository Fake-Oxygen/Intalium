using Terraria.ModLoader;
using Terraria.ID;

namespace Intalium.Items.Tools
{
    public class GreatAlloyPickaxe : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Great Alloy Pickaxe");
        }

        public override void SetDefaults()
        {
            item.value = 80000;
            item.useStyle = 1;
            item.useAnimation = 12;
            item.useTime = 12;
            item.useTurn = true;
            item.autoReuse = true;
            item.rare = 5;
            item.width = 38;
            item.height = 38;
            item.UseSound = SoundID.Item1;
            item.damage = 40;
            item.knockBack = 5.25f;
            item.melee = true;
            item.scale = 1.2f;
            item.pick = 220;
            item.tileBoost = 2;
            item.crit = 3;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "GreatAlloy", 14);
            recipe.AddIngredient(null, "Shine", 3);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
