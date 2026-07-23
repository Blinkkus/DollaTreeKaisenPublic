using NeviliscoVanity.Content.Rarities;
using Terraria;
using Terraria.ModLoader;

namespace NeviliscoVanity.Content.Items.Accessories.Vanity;

[AutoloadEquip(EquipType.Front)]
public class InosShiestyAccessory : ModItem
{
    public override string Texture => GetAssetPath("Accessories", Name);

    public override void SetDefaults()
    {
        Item.value = 0;
        Item.rare = ModContent.RarityType<NevilsicoRarity>();

        Item.width = 30;
        Item.height = 26;
        Item.vanity = true;
        Item.accessory = true;
    }
}
