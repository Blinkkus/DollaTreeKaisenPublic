using Terraria.ModLoader;

namespace NeviliscoVanity.Content.Items.Armor.Vanity.Sukuna;

[AutoloadEquip(EquipType.Legs)]
public class SukunasPants : NevilArmor
{
    public override void SetSize()
    {
        Item.width = 22;
        Item.height = 18;
    }
}
