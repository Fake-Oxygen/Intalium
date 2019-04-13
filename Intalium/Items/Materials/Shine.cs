using Terraria.ModLoader;

namespace Intalium.Items.Materials
{
    public class Shine : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Shine");
            Tooltip.SetDefault("Sparkly dust");
        }
        public override void SetDefaults()
        {
            item.value = 500;
            item.rare = 0;
            item.maxStack = 999;
            item.width = 26;
            item.height = 14;
        }
    }
}
