using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace HallowedCape.Items
{
	[AutoloadEquip(EquipType.Back)]
    public class HallowedCape : ModItem
    {
        public override LocalizedText DisplayName => Language.GetOrRegister("Hallowed Cape");

        public override LocalizedText Tooltip => Language.GetOrRegister("'The cloak of a hero'");

        public override void SetDefaults()
        {
            Item.value = 0;
            Item.rare = ItemRarityID.Pink;
			Item.accessory = true;
			Item.vanity = true;
        }

        public override void AddRecipes()
        {
            Recipe.Create(Type, 1)
				.AddIngredient(ItemID.HallowedBar, 2)
				.AddIngredient(ItemID.Silk, 5)
				.AddTile(TileID.Loom)
				.Register();
        }
    }
}