using Terraria.ModLoader;

namespace NeviliscoVanity.Content.Items.Armor.Vanity.Yuji
{
    [AutoloadEquip(EquipType.Legs)]
    public class YujisPants : NevilArmor
    {
        public override void SetSize()
        {
            Item.width = 22;
            Item.height = 18;
        }
    }
}
