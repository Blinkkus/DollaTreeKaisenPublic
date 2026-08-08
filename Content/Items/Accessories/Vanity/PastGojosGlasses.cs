using Terraria.ModLoader;

namespace NeviliscoVanity.Content.Items.Accessories.Vanity;

[AutoloadEquip(EquipType.Front)]
public class PastGojosGlasses : NevilAccessory
{
    public override void SetSize() =>
        Item.width = Item.height = 24;
}