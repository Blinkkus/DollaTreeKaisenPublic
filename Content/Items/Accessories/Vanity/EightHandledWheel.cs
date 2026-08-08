using Terraria.ModLoader;

namespace NeviliscoVanity.Content.Items.Accessories.Vanity;

[AutoloadEquip(EquipType.Balloon)]
public class EightHandledWheel : NevilAccessory
{
    public override void SetSize()
    {
        Item.width = 28;
        Item.height = 24;
    }
}