using Terraria.ModLoader;
using Terraria.ID;

namespace Intalium.Items.Tools
{
    public class PreUltimatePickaxe : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Pre-Ultimate Pickaxe");
        }

        public override void SetDefaults()
        {
            item.value = 100000;
            item.useStyle = 1;
            item.useAnimation = 18;
            item.useTime = 18;
            item.useTurn = true;
            item.autoReuse = true;
            item.rare = 4;
            item.width = 80;
            item.height = 80;
            item.UseSound = SoundID.Item1;
            item.damage = 25;
            item.knockBack = 4f;
            item.melee = true;
            item.scale = 1.3f;
            item.pick = 115;
            item.tileBoost = 1;
            item.crit = 2;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddRecipeGroup("Intalium:Tier1Pickaxe", 1);
            recipe.AddIngredient(ItemID.CactusPickaxe, 1);
            recipe.AddRecipeGroup("Intalium:Tier2Pickaxe", 1);
            recipe.AddRecipeGroup("Intalium:Tier3Pickaxe", 1);
            recipe.AddIngredient(ItemID.BonePickaxe, 1);
            recipe.AddRecipeGroup("Intalium:Tier4Pickaxe", 1);
            recipe.AddIngredient(ItemID.CnadyCanePickaxe, 1);
            recipe.AddRecipeGroup("Intalium:Tier5Pickaxe", 1);
            recipe.AddIngredient(ItemID.ReaverShark, 1);
            recipe.AddIngredient(ItemID.MoltenPickaxe, 1);
            recipe.AddIngredient(null, "Shine", 8);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
