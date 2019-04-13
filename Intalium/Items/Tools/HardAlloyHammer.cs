using Terraria.ModLoader;
using Terraria.ID;

namespace Intalium.Items.Tools
{
    public class HardAlloyHammer : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Hard Alloy Hammer");
        }

        public override void SetDefaults()
        {
            item.value = 10000;
            item.useStyle = 1;
            item.useAnimation = 20;
            item.useTime = 16;
            item.useTurn = true;
            item.autoReuse = true;
            item.rare = 1;
            item.width = 32;
            item.height = 32;
            item.UseSound = SoundID.Item1;
            item.damage = 12;
            item.knockBack = 4;
            item.melee = true;
            item.scale = 1.1f;
            item.hammer = 60;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "Hard_Alloy", 8);
            recipe.AddIngredient(null, "Shine", 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
