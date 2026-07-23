using NeviliscoVanity.Content.Rarities;
using Terraria;
using Terraria.ModLoader;

namespace NeviliscoVanity.Content.Items.Armor.Vanity;

[AutoloadEquip(EquipType.Body)]
public class PastGojosShirt : ModItem
{
    public override string Texture => GetAssetPath("Armor", Name);

    public override void SetDefaults()
    {
        Item.value = 0;
        Item.rare = ModContent.RarityType<NevilsicoRarity>();

        Item.width = 15;
        Item.height = 10;
        Item.vanity = true;
    }
}
