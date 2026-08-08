using Terraria.ModLoader;

namespace NeviliscoVanity.Content.Items.Armor.Vanity.Ino;

[AutoloadEquip(EquipType.Head)]
public class InosHair : NevilArmor
{
    public override void SetSize() =>
        Item.width = Item.height = 30;
}