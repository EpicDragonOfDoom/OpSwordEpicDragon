using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;

namespace OpSwordEpicDragon.Items
{

	public class GodSword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("God Sword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("This is a God Sword that you actually can get.");
		}

		public override void SetDefaults() 
		{

			item.damage = 9999;
			item.melee = true;
			item.width = 1000;
			item.height = 1000;
			item.useTime = 0;
			item.useAnimation = 0;
			item.useStyle = 1;
			item.knockBack = 99;
			item.value = 10000;
			item.rare = 10;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.useTurn = true;
			item.crit = 9999;
			item.shoot = mod.ProjectileType("GodProjectile");
			item.shootSpeed = 20;

		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LunarBar, 50);
			recipe.AddIngredient(ItemID.ChlorophyteBar, 50);
			recipe.AddIngredient(ItemID.CobaltBar, 50);
			recipe.AddIngredient(ItemID.HallowedBar, 50);
			recipe.AddIngredient(ItemID.MythrilBar, 50);
			recipe.AddIngredient(ItemID.OrichalcumBar, 50);
			recipe.AddIngredient(ItemID.PalladiumBar, 50);
			recipe.AddIngredient(ItemID.ShroomiteBar, 50);
			recipe.AddIngredient(ItemID.AdamantiteBar, 50);
			recipe.AddIngredient(ItemID.SpectreBar, 50);
			recipe.AddIngredient(ItemID.TitaniumBar, 50);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}