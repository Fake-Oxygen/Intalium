using Terraria.ModLoader;
using Terraria.ID;

namespace Intalium.Projectiles.Hostile
{
    public class AmethystBoltHostile : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Amethyst Bolt");
        }
        public override void SetDefaults()
        {
            projectile.width = 10;
            projectile.height = 10;
            projectile.aiStyle = 29;
            projectile.friendly = false;
            projectile.hostile = true;
            aiType = ProjectileID.AmethystBolt;
        }
    }
}
