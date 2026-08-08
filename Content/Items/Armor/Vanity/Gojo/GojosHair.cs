using Terraria.ModLoader;

namespace NeviliscoVanity.Content.Items.Armor.Vanity.Gojo;

[AutoloadEquip(EquipType.Head)]
public class GojosHair : NevilArmor
{
    public override void SetSize()
    {
        Item.width = 24;
        Item.height = 20;
    }
}