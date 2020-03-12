using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;

namespace OpSwordEpicDragon.Items
{

	public class BreakerSwordOk : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Ok Breaker Sword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("This is a Ok Breaking Sword.");
		}

		public override void SetDefaults() 
		{

			item.damage = 9999999;
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
			item.defense = 466666666;
			item.accessory = true;
			item.axe = 9999999;
			item.pick = 9999999;
			item.hammer = 9999999;
			item.tileBoost = 100;
			item.buffTime = 9999999;
			item.buffType = 9;

		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LunarBar, 1998);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}