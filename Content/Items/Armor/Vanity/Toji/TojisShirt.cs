using Terraria.ModLoader;

namespace NeviliscoVanity.Content.Items.Armor.Vanity.Toji;

[AutoloadEquip(EquipType.Body)]
public class TojisShirt : NevilArmor
{
    public override void SetSize()
    {
        Item.width = 30;
        Item.height = 20;
    }
}
