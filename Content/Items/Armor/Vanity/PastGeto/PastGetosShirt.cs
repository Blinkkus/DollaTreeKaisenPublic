using Terraria.ModLoader;

namespace NeviliscoVanity.Content.Items.Armor.Vanity.PastGeto;

[AutoloadEquip(EquipType.Body)] 
public class PastGetosShirt : NevilArmor
{
    public override void SetSize() 
    {
        Item.width = 30;
        Item.height = 20;
    }
}
