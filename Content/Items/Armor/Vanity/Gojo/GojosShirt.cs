using Terraria.ModLoader;

namespace NeviliscoVanity.Content.Items.Armor.Vanity.Gojo;

[AutoloadEquip(EquipType.Body)]
public class GojosShirt : NevilArmor
{
    public override void SetSize()
    {
        Item.width = 30;
        Item.height = 20;
    }
}