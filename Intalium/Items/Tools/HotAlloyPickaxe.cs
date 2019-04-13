using Terraria.ModLoader;
using Terraria.ID;

namespace Intalium.Items.Tools
{
    public class HotAlloyPickaxe : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Hot Alloy Pickaxe");
        }

        public override void SetDefaults()
        {
            item.value = 30000;
            item.useStyle = 1;
            item.useAnimation = 15;
            item.useTime = 15;
            item.useTurn = true;
            item.autoReuse = true;
            item.rare = 3;
            item.width = 36;
            item.height = 36;
            item.UseSound = SoundID.Item1;
            item.damage = 14;
            item.knockBack = 4;
            item.melee = true;
            item.scale = 1.1f;
            item.pick = 110;
            item.tileBoost = 1;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "HotAlloy", 10);
            recipe.AddIngredient(null, "Shine", 2);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
