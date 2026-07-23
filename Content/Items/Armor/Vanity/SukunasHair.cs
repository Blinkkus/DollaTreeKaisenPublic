using NeviliscoVanity.Content.Rarities;
using Terraria;
using Terraria.ModLoader;

namespace NeviliscoVanity.Content.Items.Armor.Vanity;

[AutoloadEquip(EquipType.Head)]
public class SukunasHair : ModItem
{
    public override string Texture => GetAssetPath("Armor", Name);

    public override void SetDefaults()
    {
        Item.value = 0;
        Item.rare = ModContent.RarityType<NevilsicoRarity>();

        Item.width = 26;
        Item.height = 22;
        Item.vanity = true;
    }
}
