using Terraria.ModLoader;

namespace NeviliscoVanity.Content.Items.Armor.Vanity.Ino;

[AutoloadEquip(EquipType.Head)]
public class InosBeanie : NevilArmor
{
    public override void SetSize()
    {
        Item.width = 30;
        Item.height = 32;
    }
}