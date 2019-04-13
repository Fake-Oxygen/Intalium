using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using System;

namespace Intalium.NPC.Enemy
{
    public class ShinyCrystal : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Shiny Crystal");
        }

        public override void SetDefaults()
        {
            npc.lifeMax = 50;
            npc.damage = 10;
            npc.defense = 3;
            npc.knockBackResist = 0.1f;
            npc.aiStyle = 44;
            npc.width = 24;
            npc.npcSlots = 1f;
            npc.HitSound = SoundID.NPCHit5;
            npc.DeathSound = SoundID.NPCDeath7;
            npc.height = 24;
            npc.noGravity = true;
        }

        public override void AI()
        {
            Player player = Main.player[npc.target];
            if (npc.target < 0 || npc.target == 255 || Main.player[npc.target].dead || !Main.player[npc.target].active)
            {
                npc.TargetClosest(true);
            }
            int dust = Dust.NewDust(npc.position, npc.width, npc.height, 223);
            Main.dust[dust].velocity += npc.velocity * 0.25f;
            Vector2 vector8 = new Vector2(npc.position.X + (npc.width / 2), npc.position.Y + (npc.height / 2));
            float rotation = (float)Math.Atan2(vector8.Y - (player.position.Y + (player.height * 0.5f)), vector8.X - (player.position.X + (player.width * 0.5f)));
            npc.ai[1]++;
            if (Main.netMode != 1 && npc.ai[1] >= 120)
            {
                Main.PlaySound(43, (int)npc.position.X, (int)npc.position.Y, 17);
                int proj = Projectile.NewProjectile(npc.Center.X, npc.Center.Y, (float)((Math.Cos(rotation) * 5f) * -1), (float)((Math.Sin(rotation) * 5f) * -1), mod.ProjectileType<Projectiles.Hostile.AmethystBoltHostile>(), npc.damage / 2, 0.3f, Main.myPlayer);
                npc.ai[1] = 0;
            }
            npc.netUpdate = true;
        }

        public override void NPCLoot()
        {
            Item.NewItem(npc.getRect(), mod.ItemType<Items.Materials.Shine>(), Main.rand.Next(1,4));
        }

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            if (spawnInfo.playerSafe) return 0f;

            return SpawnCondition.OverworldDayRain.Chance * 0.5f;
        }
    }
}
