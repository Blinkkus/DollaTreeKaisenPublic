using Terraria.ModLoader;

namespace NeviliscoVanity.Content.Items.Armor.Vanity.Yuta;

[AutoloadEquip(EquipType.Head)]
public class YutasHair : NevilArmor
{
    public override void SetSize()
    {
        Item.width = 28;
        Item.height = 16;
    }
}
