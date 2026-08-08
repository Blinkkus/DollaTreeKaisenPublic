using Terraria.ModLoader;

namespace NeviliscoVanity.Content.Items.Armor.Vanity.Yuta;

[AutoloadEquip(EquipType.Legs)]
public class YutasPants : NevilArmor
{
    public override void SetSize()
    {
        Item.width = 22;
        Item.height = 18;
    }
}
