using Terraria.ModLoader;

namespace NeviliscoVanity.Content.Items.Accessories.Vanity;

[AutoloadEquip(EquipType.HandsOn)]
public class ClawsOfCalamity : NevilAccessory
{
    public override void SetSize()
    {
        Item.width = 20;
        Item.height = 40;
    }
}