using Terraria.ModLoader;

namespace NeviliscoVanity.Content.Items.Armor.Vanity.Yuji;

[AutoloadEquip(EquipType.Head)]
public class YujikunaHair : NevilArmor
{
    public override void SetSize() =>
        Item.width = Item.height = 32;
}
