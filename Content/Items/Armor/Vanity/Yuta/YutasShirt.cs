using Terraria.ModLoader;

namespace NeviliscoVanity.Content.Items.Armor.Vanity.Yuta;

[AutoloadEquip(EquipType.Body)]
public class YutasShirt : NevilArmor
{
    public override void SetSize()
    {
        Item.width = 30;
        Item.height = 20;
    }
}
