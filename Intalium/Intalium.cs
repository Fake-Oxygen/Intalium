using Terraria.ModLoader;
using Terraria.Localization;
using Terraria.ID;
using Terraria;

namespace Intalium
{
	class Intalium : Mod
	{
		public Intalium()
		{

		}

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.Bone, 15);
            recipe.AddTile(TileID.BoneWelder);
            recipe.SetResult(ItemID.BonePickaxe, 1);
            recipe.AddRecipe();
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.CandyCaneBlock, 12);
            recipe.AddIngredient(ItemID.GreenCandyCaneBlock, 12);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(ItemID.CnadyCanePickaxe, 1);
            recipe.AddRecipe();
        }

        public override void AddRecipeGroups()
        {
            RecipeGroup group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Tier 1 Bar", new int[]
            {
                    ItemID.TinBar,
                    ItemID.CopperBar
            });
            RecipeGroup.RegisterGroup("Intalium:Tier1Bar", group);

            group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Tier 2 Bar", new int[]
            {
                    ItemID.IronBar,
                    ItemID.LeadBar
            });
            RecipeGroup.RegisterGroup("Intalium:Tier2Bar", group);

            group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Tier 3 Bar", new int[]
            {
                    ItemID.SilverBar,
                    ItemID.TungstenBar
            });
            RecipeGroup.RegisterGroup("Intalium:Tier3Bar", group);

            group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Tier 4 Bar", new int[]
            {
                    ItemID.PlatinumBar,
                    ItemID.GoldBar
            });
            RecipeGroup.RegisterGroup("Intalium:Tier4Bar", group);

            group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Tier 5 Bar", new int[]
            {
                    ItemID.DemoniteBar,
                    ItemID.CrimtaneBar
            });
            RecipeGroup.RegisterGroup("Intalium:Tier5Bar", group);

            group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Tier 8 Bar", new int[]
            {
                    ItemID.PalladiumBar,
                    ItemID.CobaltBar
            });
            RecipeGroup.RegisterGroup("Intalium:Tier8Bar", group);

            group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Tier 9 Bar", new int[]
            {
                    ItemID.OrichalcumBar,
                    ItemID.MythrilBar
            });
            RecipeGroup.RegisterGroup("Intalium:Tier9Bar", group);

            group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Tier 10 Bar", new int[]
            {
                    ItemID.TitaniumBar,
                    ItemID.AdamantiteBar
            });
            RecipeGroup.RegisterGroup("Intalium:Tier10Bar", group);

            group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Tier 1 Pickaxe", new int[]
            {
                    ItemID.TinPickaxe,
                    ItemID.CopperPickaxe
            });
            RecipeGroup.RegisterGroup("Intalium:Tier1Pickaxe", group);

            group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Tier 2 Pickaxe", new int[]
            {
                    ItemID.IronPickaxe,
                    ItemID.LeadPickaxe
            });
            RecipeGroup.RegisterGroup("Intalium:Tier2Pickaxe", group);

            group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Tier 3 Pickaxe", new int[]
            {
                    ItemID.SilverPickaxe,
                    ItemID.TungstenPickaxe
            });
            RecipeGroup.RegisterGroup("Intalium:Tier3Pickaxe", group);

            group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Tier 4 Pickaxe", new int[]
            {
                    ItemID.GoldPickaxe,
                    ItemID.PlatinumPickaxe
            });
            RecipeGroup.RegisterGroup("Intalium:Tier4Pickaxe", group);

            group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Tier 5 Pickaxe", new int[]
            {
                    ItemID.DeathbringerPickaxe,
                    ItemID.NightmarePickaxe
            });
            RecipeGroup.RegisterGroup("Intalium:Tier5Pickaxe", group);

            group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Tier 8 Pickaxe", new int[]
            {
                    ItemID.CobaltPickaxe,
                    ItemID.CobaltDrill,
                    ItemID.PalladiumDrill,
                    ItemID.PalladiumPickaxe
            });
            RecipeGroup.RegisterGroup("Intalium:Tier8Pickaxe", group);

            group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Tier 9 Pickaxe", new int[]
            {
                    ItemID.OrichalcumDrill,
                    ItemID.OrichalcumPickaxe,
                    ItemID.MythrilDrill,
                    ItemID.MythrilPickaxe
            });
            RecipeGroup.RegisterGroup("Intalium:Tier9Pickaxe", group);

            group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Tier 10 Pickaxe", new int[]
            {
                    ItemID.TitaniumDrill,
                    ItemID.TitaniumPickaxe,
                    ItemID.AdamantiteDrill,
                    ItemID.AdamantitePickaxe
            });
            RecipeGroup.RegisterGroup("Intalium:Tier10Pickaxe", group);

            group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Tier 11 Pickaxe", new int[]
            {
                    ItemID.PickaxeAxe,
                    ItemID.Drax
            });
            RecipeGroup.RegisterGroup("Intalium:Tier11Pickaxe", group);

            group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Tier 12 Pickaxe", new int[]
            {
                    ItemID.ChlorophyteDrill,
                    ItemID.ChlorophytePickaxe
            });
            RecipeGroup.RegisterGroup("Intalium:Tier12Pickaxe", group);

            group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Tier 16 Pickaxe", new int[]
            {
                    ItemID.SolarFlarePickaxe,
                    ItemID.VortexPickaxe,
                    ItemID.StardustPickaxe,
                    ItemID.NebulaPickaxe
            });
            RecipeGroup.RegisterGroup("Intalium:Tier16Pickaxe", group);
        }
    }
}
