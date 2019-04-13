using Terraria.ModLoader;
using Terraria.ID;

namespace Intalium.Items.Tools
{
    public class HardAlloyPickaxe : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Hard Alloy Pickaxe");
        }

        public override void SetDefaults()
        {
            item.value = 17500;
            item.useStyle = 1;
            item.useAnimation = 20;
            item.useTime = 16;
            item.useTurn = true;
            item.autoReuse = true;
            item.rare = 1;
            item.width = 32;
            item.height = 32;
            item.UseSound = SoundID.Item1;
            item.damage = 9;
            item.knockBack = 3;
            item.melee = true;
            item.scale = 1.15f;
            item.pick = 90;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "Hard_Alloy", 10);
            recipe.AddIngredient(null, "Shine", 2);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
