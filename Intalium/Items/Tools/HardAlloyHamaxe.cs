using Terraria.ModLoader;
using Terraria.ID;

namespace Intalium.Items.Tools
{
    public class HardAlloyHamaxe : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Hard Alloy Hamaxe");
        }

        public override void SetDefaults()
        {
            item.value = 19500;
            item.useStyle = 1;
            item.useAnimation = 20;
            item.useTime = 16;
            item.useTurn = true;
            item.autoReuse = true;
            item.rare = 1;
            item.width = 32;
            item.height = 32;
            item.UseSound = SoundID.Item1;
            item.damage = 15;
            item.knockBack = 6;
            item.melee = true;
            item.scale = 1.1f;
            item.axe = 16;
            item.hammer = 60;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "HardAlloyHammer", 1);
            recipe.AddIngredient(null, "HardAlloyAxe", 1);
            recipe.AddIngredient(null, "Shine", 2);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
