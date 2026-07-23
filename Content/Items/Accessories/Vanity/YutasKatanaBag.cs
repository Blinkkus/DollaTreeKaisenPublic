using NeviliscoVanity.Content.Rarities;
using Terraria;
using Terraria.ModLoader;

namespace NeviliscoVanity.Content.Items.Accessories.Vanity;

[AutoloadEquip(EquipType.Back, EquipType.Front)]
public class YutasKatanaBag : ModItem
{
    public override string Texture => GetAssetPath("Accessories", Name);

    public override void SetDefaults()
    {
        Item.value = 0;
        Item.rare = ModContent.RarityType<NevilsicoRarity>();

        Item.width = Item.height = 34;
        Item.vanity = true;
        Item.accessory = true;
    }
}
