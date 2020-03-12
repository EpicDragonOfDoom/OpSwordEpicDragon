using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ModLoader;

namespace OpSwordEpicDragon.Projectiles //We need this to basically indicate the folder where it is to be read from, so you the texture will load correctly
{	
	public class OpProjectile : ModProjectile 
	{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Op Projectile");
        }
		public override void SetDefaults()
		{
			projectile.width = 256; //Set the hitbox width
			projectile.height = 256; //Set the hitbox height
			projectile.timeLeft = 60; //The amount of time the projectile is alive for
			projectile.penetrate = 999999999; //Tells the game how many enemies it can hit before being destroyed
			projectile.friendly = true; //Tells the game whether it is friendly to players/friendly npcs or not
			projectile.hostile = false; //Tells the game whether it is hostile to players or not
			projectile.tileCollide = false; //Tells the game whether or not it can collide with a tile
			projectile.ignoreWater = true; //Tells the game whether or not projectile will be affected by water
			projectile.ranged = true; //Tells the game whether it is a ranged projectile or not
			projectile.aiStyle = 0; //How the projectile works, 0 makes the projectile just go straight towards your cursor
		}
		
		//How the projectile works
		public override void AI()
        {
            Player owner = Main.player[projectile.owner]; //Makes a player variable of owner set as the player using the projectile
            projectile.light = 0.9f; //Lights up the whole room
            projectile.alpha = 128; //Semi Transparent
            projectile.rotation += (float)projectile.direction * 0.8f; //Spins in a good speed
            int DustID = Dust.NewDust(new Vector2(projectile.position.X, projectile.position.Y + 2f), projectile.width + 4, projectile.height + 4, 36, projectile.velocity.X * 0.2f, projectile.velocity.Y * 0.2f, 120, default(Color), 0.75f); //Spawns dust
            Main.dust[DustID].noGravity = true; //Makes dust not fall
            if(projectile.timeLeft % 15 == 0) //If the remainder of the timeLeft divided 15 is 0, then make the projectile; Every 15 seconds, projectile spawns another projectile
            {
                Projectile.NewProjectile(projectile.position.X, projectile.position.Y, MathHelper.Lerp(-1f, 1f, (float)Main.rand.NextDouble()), MathHelper.Lerp(-1f, 1f, (float)Main.rand.NextDouble()), mod.ProjectileType("ExampleBulletB"), 5 * (int)owner.rangedDamage, projectile.knockBack, Main.myPlayer); //owner.rangedDamage is basically the damage multiplier for ranged weapons
            }
        }


        //When you hit an NPC
        public override void OnHitNPC(NPC n, int damage, float knockback, bool crit)
        {
            Player owner = Main.player[projectile.owner];
            int rand = Main.rand.Next(2); //Generates an integer from 0 to 1
            if(rand == 0)
            {
                n.AddBuff(24, 180); //On Fire! debuff for 3 seconds
            }
            else if (rand == 1)
            {
                owner.statLife += 5; //Gives 5 Health
				owner.HealEffect(5, true); //Shows you have healed by 5 health
            }
        }
		
		//When the projectile hits a tile
        public override bool OnTileCollide(Vector2 velocityChange)  
        {
            if (projectile.velocity.X != velocityChange.X)
            {
                projectile.velocity.X = -velocityChange.X/2; //Goes in the opposite direction with half of its x velocity
            }
            if (projectile.velocity.Y != velocityChange.Y)
            {
                projectile.velocity.Y = -velocityChange.Y/2; //Goes in the opposite direction with half of its y velocity
            }
            return false;
        }
		
        //After the projectile is dead
        public override void Kill(int timeLeft)
        {
            int rand = Main.rand.Next(5); //Generates integers from 0 to 4
            Projectile.NewProjectile(projectile.position.X, projectile.position.Y, 0, 0, 0, (int) (projectile.damage * 1.5), projectile.knockBack, Main.myPlayer); // 296 is the explosion from the Inferno Fork
            if(rand == 0)
            {
                Item.NewItem((int)projectile.position.X, (int)projectile.position.Y, projectile.width, projectile.height, mod.ItemType("OpProjectile"), 1, false, 0, false); //Spawns a bullet
            }
        }
	}
}
