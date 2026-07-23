using NeviliscoVanity.Content.Rarities;
using Terraria;
using Terraria.ModLoader;

namespace NeviliscoVanity.Content.Items.Armor.Vanity;

[AutoloadEquip(EquipType.Head)]
public class PastGojosHair : ModItem
{
    public override string Texture => GetAssetPath("Armor", Name);

    public override void SetDefaults()
    {
        Item.value = 0;
        Item.rare = ModContent.RarityType<NevilsicoRarity>();

        Item.width = Item.height = 20;
        Item.vanity = true;
    }
}
