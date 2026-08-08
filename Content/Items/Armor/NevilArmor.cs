using NeviliscoVanity.Content.Rarities;
using Terraria.ModLoader;

namespace NeviliscoVanity.Content.Items.Armor
{
    public abstract class NevilArmor : ModItem
    {
        public override string Texture => GetAssetPath("Armor", Name);

        public override void SetDefaults()
        {
            Item.value = 0;
            Item.rare = ModContent.RarityType<NevilsicoRarity>();

            SetSize();
            Item.vanity = true;
        }

        public virtual void SetSize() {
        }
    }
}