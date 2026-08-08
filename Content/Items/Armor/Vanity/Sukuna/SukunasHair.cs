using Terraria.ModLoader;

namespace NeviliscoVanity.Content.Items.Armor.Vanity.Sukuna;

[AutoloadEquip(EquipType.Head)]
public class SukunasHair : NevilArmor
{
    public override void SetSize()
    {
        Item.width = 26;
        Item.height = 22;
    }
}
