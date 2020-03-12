using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;

namespace OpSwordEpicDragon.Items
{

	public class InfiniteCoin : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Money"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("This is Money. Don't sell too much at the same time or you only will get 1 copper");
		}

		public override void SetDefaults() 
		{


			item.value = 2147483647;
			item.maxStack = 2147483647;


		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LunarBar, 1);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this, 2147483647);
			recipe.AddRecipe();
		}
	}
}