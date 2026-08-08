using Terraria.ModLoader;

namespace NeviliscoVanity.Content.Items.Armor.Vanity.Yuji
{
    [AutoloadEquip(EquipType.Body)]
    public class YujisShirt : NevilArmor
    {
        public override void SetSize()
        {
            Item.width = 30;
            Item.height = 20;
        }
    }
}
