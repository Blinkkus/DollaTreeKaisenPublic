using Terraria.ModLoader;

namespace NeviliscoVanity.Content.Items.Armor.Vanity.PastGojo;

[AutoloadEquip(EquipType.Head)]
public class PastGojosHair : NevilArmor
{
    public override void SetSize() =>
        Item.width = Item.height = 20;
}
