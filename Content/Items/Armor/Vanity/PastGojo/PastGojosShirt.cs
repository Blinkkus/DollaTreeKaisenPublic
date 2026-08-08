using Terraria.ModLoader;

namespace NeviliscoVanity.Content.Items.Armor.Vanity.PastGojo;

[AutoloadEquip(EquipType.Body)]
public class PastGojosShirt : NevilArmor
{
    public override void SetSize()
    {
        Item.width = 15;
        Item.height = 10;
    }
}
