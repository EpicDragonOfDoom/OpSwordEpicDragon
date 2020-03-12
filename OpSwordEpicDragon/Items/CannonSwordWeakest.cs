using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;

namespace OpSwordEpicDragon.Items
{

	public class CannonSwordWeakest : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Weak Rocket Sword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("This is a Weak Rocket Sword.");
		}

		public override void SetDefaults() 
		{

			item.damage = 99999;
			item.melee = true;
			item.width = 1000;
			item.height = 1000;
			item.useTime = 0;
			item.useAnimation = 0;
			item.useStyle = 1;
			item.knockBack = 999999999;
			item.value = 10000;
			item.rare = 10;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.useTurn = true;
			item.crit = 999999999;
			item.defense = 233333333;
			item.accessory = true;
			item.axe = 99999;
			item.pick = 99999;
			item.hammer = 99999;
			item.tileBoost = 100;
			item.shoot = ProjectileID.RocketIII;
			item.shootSpeed = 20;

		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LunarBar, 999);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}