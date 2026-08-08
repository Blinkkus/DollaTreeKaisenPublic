using Terraria.ModLoader;

namespace NeviliscoVanity.Content.Items.Armor.Vanity.Ino;

[AutoloadEquip(EquipType.Legs)]
public class InosPants : NevilArmor
{
    public override void SetSize()
    {
        Item.width = 22;
        Item.height = 18;
    }
}