using Terraria.ModLoader;

namespace NeviliscoVanity.Content.Items.Accessories.Vanity;

[AutoloadEquip(EquipType.Front)]
public class InosShiestyAccessory : NevilAccessory
{
    public override void SetSize()
    {
        Item.width = 30;
        Item.height = 26;
    }
}