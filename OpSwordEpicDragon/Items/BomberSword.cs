using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;

namespace OpSwordEpicDragon.Items
{

	public class BomberSword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Bomber Sword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("This is a Bombing Sword.");
		}

		public override void SetDefaults() 
		{

			item.damage = 999999999;
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
			item.defense = 699999999;
			item.accessory = true;
			item.axe = 999999999;
			item.pick = 999999999;
			item.hammer = 999999999;
			item.tileBoost = 100;
			item.shoot = ProjectileID.StickyDynamite;
			item.shootSpeed = 20;

		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LunarBar, 2997);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}