using Terraria.ModLoader;

namespace NeviliscoVanity.Content.Items.Armor.Vanity.Yuji;

[AutoloadEquip(EquipType.Head)]
public class YujiSlickHair : NevilArmor
{
    public override void SetSize()
    {
        Item.width = 22;
        Item.height = 26;
    }
}
