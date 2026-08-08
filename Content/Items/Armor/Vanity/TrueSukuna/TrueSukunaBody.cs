using Terraria.ModLoader;

namespace NeviliscoVanity.Content.Items.Armor.Vanity.TrueSukuna;

[AutoloadEquip(EquipType.Body)]
public class TrueSukunaBody : NevilArmor
{
    public override void SetSize()
    {
        Item.width = 30;
        Item.height = 20;
    }
}
