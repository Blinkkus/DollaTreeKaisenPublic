using Terraria.ModLoader;

namespace NeviliscoVanity.Content.Items.Accessories.Vanity;

[AutoloadEquip(EquipType.Neck)]
public class TojiWorm : NevilAccessory
{
    public override void SetSize() =>
        Item.width = Item.height = 28;
}