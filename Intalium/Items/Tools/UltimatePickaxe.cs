using Terraria.ModLoader;
using Terraria.ID;

namespace Intalium.Items.Tools
{
    public class UltimatePickaxe : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ultimate Pickaxe");
        }

        public override void SetDefaults()
        {
            item.value = 150000;
            item.useStyle = 1;
            item.useAnimation = 12;
            item.useTime = 5;
            item.useTurn = true;
            item.autoReuse = true;
            item.rare = 7;
            item.width = 80;
            item.height = 80;
            item.UseSound = SoundID.Item1;
            item.damage = 135;
            item.knockBack = 6.5f;
            item.melee = true;
            item.scale = 1.3f;
            item.pick = 280;
            item.tileBoost = 3;
            item.crit = 6;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddRecipeGroup("Intalium:Tier8Pickaxe", 1);
            recipe.AddRecipeGroup("Intalium:Tier9Pickaxe", 1);
            recipe.AddRecipeGroup("Intalium:Tier10Pickaxe", 1);
            recipe.AddRecipeGroup("Intalium:Tier11Pickaxe", 1);
            recipe.AddRecipeGroup("Intalium:Tier12Pickaxe", 1);
            recipe.AddIngredient(ItemID.SpectrePickaxe, 1);
            recipe.AddIngredient(ItemID.ShroomiteDiggingClaw, 1);
            recipe.AddIngredient(ItemID.Picksaw, 1);
            recipe.AddRecipeGroup("Intalium:Tier16Pickaxe", 1);
            recipe.AddIngredient(ItemID.LaserDrill, 1);
            recipe.AddIngredient(null, "Shine", 8);
            recipe.AddIngredient(ItemID.PixieDust, 8);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
