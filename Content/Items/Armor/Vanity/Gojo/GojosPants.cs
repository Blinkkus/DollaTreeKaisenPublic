using Terraria.ModLoader;

namespace NeviliscoVanity.Content.Items.Armor.Vanity.Gojo;

[AutoloadEquip(EquipType.Legs)]
public class GojosPants : NevilArmor
{
    public override void SetSize()
    {
        Item.width = 22;
        Item.height = 18;
    }
}