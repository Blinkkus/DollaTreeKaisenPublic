using Terraria.ModLoader;

namespace NeviliscoVanity.Content.Items.Accessories.Vanity;

[AutoloadEquip(EquipType.Back, EquipType.Front)]
public class YutasKatanaBag : NevilAccessory
{
    public override void SetSize() =>
        Item.width = Item.height = 34;
}