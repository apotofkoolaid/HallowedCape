using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace HallowedCape.Items
{
	[AutoloadEquip(EquipType.Back)]
    public class HallowedCape : ModItem
    {
		public override void SetStaticDefaults()
        {
			Tooltip.SetDefault("'The cloak of a hero'");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }
        public override void SetDefaults()
        {
            Item.value = 0;
            Item.rare = ItemRarityID.Pink;
			Item.accessory = true;
			Item.vanity = true;
        }
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.HallowedBar, 2);
            recipe.AddIngredient(ItemID.Silk, 5);
            recipe.AddTile(TileID.Loom);
            recipe.Register();
        }
    }
}