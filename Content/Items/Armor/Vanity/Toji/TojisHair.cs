using Terraria.ModLoader;

namespace NeviliscoVanity.Content.Items.Armor.Vanity.Toji;

[AutoloadEquip(EquipType.Head)]
public class TojisHair : NevilArmor
{
    public override void SetSize()
    {
        Item.width = 22;
        Item.height = 20;
    }
}
