using Terraria.ModLoader;

namespace NeviliscoVanity.Content.Items.Armor.Vanity.TrueSukuna;

[AutoloadEquip(EquipType.Head)]
public class TrueSukunaHair : NevilArmor
{
    public override void SetSize() 
    {
        Item.width = 24;
        Item.height = 16;
    }
}
