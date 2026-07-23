using NeviliscoVanity.Content.Rarities;
using Terraria;
using Terraria.ModLoader;

namespace NeviliscoVanity.Content.Items.Armor.Vanity;

[AutoloadEquip(EquipType.Legs)]
public class SukunasPants : ModItem
{
    public override string Texture => GetAssetPath("Armor", Name);

    public override void SetDefaults()
    {
        Item.value = 0;
        Item.rare = ModContent.RarityType<NevilsicoRarity>();

        Item.width = 22;
        Item.height = 18;
        Item.vanity = true;
    }
}
