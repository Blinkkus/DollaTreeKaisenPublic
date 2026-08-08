using Terraria.ModLoader;

namespace NeviliscoVanity.Content.Items.Armor.Vanity.Toji;

[AutoloadEquip(EquipType.Legs)]
public class TojisPants : NevilArmor
{
    public override void SetSize() 
    {
        Item.width = 22;
        Item.height = 18;
    }
}
