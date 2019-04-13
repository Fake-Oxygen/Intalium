using Terraria.ModLoader;
using Terraria.ID;

namespace Intalium.Items.Tools
{
    public class GreatAlloyHamaxe : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Great Alloy Hamaxe");
        }

        public override void SetDefaults()
        {
            item.value = 75000;
            item.useStyle = 1;
            item.useAnimation = 14;
            item.useTime = 14;
            item.useTurn = true;
            item.autoReuse = true;
            item.rare = 5;
            item.width = 40;
            item.height = 40;
            item.UseSound = SoundID.Item1;
            item.damage = 45;
            item.knockBack = 5.5f;
            item.melee = true;
            item.scale = 1.2f;
            item.axe = 42;
            item.hammer = 120;
            item.tileBoost = 2;
            item.crit = 3;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "GreatAlloy", 10);
            recipe.AddIngredient(null, "Shine", 2);
            recipe.AddTile(TileID.AdamantiteForge);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
