using Terraria.ModLoader;

namespace NeviliscoVanity.Content.Items.Armor.Vanity.Gojo;

[AutoloadEquip(EquipType.Head)]
public class BlindfoldGojosHair : NevilArmor
{
    public override void SetSize()
    {
        Item.width = 22;
        Item.height = 20;
    }
}