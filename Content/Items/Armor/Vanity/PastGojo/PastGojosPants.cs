using Terraria.ModLoader;

namespace NeviliscoVanity.Content.Items.Armor.Vanity.PastGojo;

[AutoloadEquip(EquipType.Legs)]
public class PastGojosPants : NevilArmor
{
    public override void SetSize() =>
        Item.width = Item.height = 20;
}
