using Terraria.ModLoader;
using Terraria.ID;

namespace Intalium.Items.Tools
{
    public class AwesomeAlloyPickaxe : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Awesome Alloy Pickaxe");
        }

        public override void SetDefaults()
        {
            item.value = 67000;
            item.useStyle = 1;
            item.useAnimation = 15;
            item.useTime = 15;
            item.useTurn = true;
            item.autoReuse = true;
            item.rare = 4;
            item.width = 38;
            item.height = 38;
            item.UseSound = SoundID.Item1;
            item.damage = 30;
            item.knockBack = 5;
            item.melee = true;
            item.scale = 1.25f;
            item.pick = 195;
            item.tileBoost = 2;
            item.crit = 2;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "AwesomeAlloy", 12);
            recipe.AddIngredient(null, "Shine", 2);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
