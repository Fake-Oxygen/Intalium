using Terraria.ModLoader;
using Terraria.ID;

namespace Intalium.Items.Tools
{
    public class MagicAlloyHamaxe : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Magic Alloy Hamaxe");
        }

        public override void SetDefaults()
        {
            item.value = 95000;
            item.useStyle = 1;
            item.useAnimation = 14;
            item.useTime = 12;
            item.useTurn = true;
            item.autoReuse = true;
            item.rare = 6;
            item.width = 40;
            item.height = 40;
            item.UseSound = SoundID.Item1;
            item.damage = 100;
            item.knockBack = 6.25f;
            item.melee = true;
            item.scale = 1.2f;
            item.axe = 50;
            item.hammer = 150;
            item.tileBoost = 3;
            item.crit = 5;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "MagicAlloy", 12);
            recipe.AddIngredient(null, "Shine", 2);
            recipe.AddTile(TileID.AdamantiteForge);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
