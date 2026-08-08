using Terraria.ModLoader;

namespace NeviliscoVanity.Content.Items.Armor.Vanity.Sukuna;

[AutoloadEquip(EquipType.Body)]
public class SukunasShirt : NevilArmor
{
    public override void SetSize()
    {
        Item.width = 26;
        Item.height = 20;
    }
}
