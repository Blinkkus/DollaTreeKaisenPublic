using Terraria.ModLoader;

namespace NeviliscoVanity.Content.Items.Armor.Vanity.PastGeto;

[AutoloadEquip(EquipType.Legs)]
public class PastGetosPants : NevilArmor
{
    public override void SetSize()
    {
        Item.width = 22;
        Item.height = 18;
    }
}
