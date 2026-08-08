using Terraria.ModLoader;

namespace NeviliscoVanity.Content.Items.Armor.Vanity.Ino;

[AutoloadEquip(EquipType.Body)]
public class InosShirt : NevilArmor
{
    public override void SetSize()
    {
        Item.width = 30;
        Item.height = 20;
    }
}
