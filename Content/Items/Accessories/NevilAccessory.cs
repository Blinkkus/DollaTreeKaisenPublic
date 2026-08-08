using NeviliscoVanity.Content.Rarities;
using Terraria.ModLoader;

namespace NeviliscoVanity.Content.Items.Accessories
{
    public abstract class NevilAccessory : ModItem
    {
        public override string Texture => GetAssetPath("Accessories", Name);

        public override void SetDefaults()
        {
            Item.value = 0;
            Item.rare = ModContent.RarityType<NevilsicoRarity>();

            SetSize();
            Item.vanity = true;
            Item.accessory = true;
        }

        public virtual void SetSize() {
        }
    }
}