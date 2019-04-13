using Terraria.ModLoader;
using Terraria.ID;

namespace Intalium.Items.Tools
{
    public class AwesomeAlloyHamaxe : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Awesome Alloy Hamaxe");
        }

        public override void SetDefaults()
        {
            item.value = 60000;
            item.useStyle = 1;
            item.useAnimation = 16;
            item.useTime = 16;
            item.useTurn = true;
            item.autoReuse = true;
            item.rare = 4;
            item.width = 36;
            item.height = 36;
            item.UseSound = SoundID.Item1;
            item.damage = 35;
            item.knockBack = 5;
            item.melee = true;
            item.scale = 1.2f;
            item.axe = 37;
            item.hammer = 90;
            item.tileBoost = 2;
            item.crit = 2;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "AwesomeAlloy", 10);
            recipe.AddIngredient(null, "Shine", 2);
            recipe.AddTile(TileID.AdamantiteForge);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
