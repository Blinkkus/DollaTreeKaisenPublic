using NeviliscoVanity.Content.Rarities;
using Terraria;
using Terraria.ModLoader;

namespace NeviliscoVanity.Content.Items.Armor.Vanity;

[AutoloadEquip(EquipType.Head)]
public class InosShiestyHelmet : ModItem
{
    public override string Texture => GetAssetPath("Armor", Name);

    public override void SetDefaults()
    {
        Item.value = 0;
        Item.rare = ModContent.RarityType<NevilsicoRarity>();

        Item.width = Item.height = 22;
        Item.vanity = true;
    }
}
