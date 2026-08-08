using Terraria.ModLoader;

namespace NeviliscoVanity.Content.Items.Armor.Vanity.TrueSukuna;

[AutoloadEquip(EquipType.Legs)]
public class TrueSukunaLegs : NevilArmor
{
    public override void SetSize()
    {
        Item.width = 22;
        Item.height = 18;
    }
}
