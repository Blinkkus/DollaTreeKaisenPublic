using NeviliscoVanity.Content.Items.Accessories.Vanity;
using NeviliscoVanity.Content.Items.Armor.Vanity;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NeviliscoVanity.Core.Systems;

public class RecipeSystem : ModSystem
{
    public override void AddRecipes()
    {
        List<int> items = new List<int>();

        // Gojo
        items.Add(ModContent.ItemType<BlindfoldGojosHair>());
        items.Add(ModContent.ItemType<NoBlindfoldGojosHair>());
        items.Add(ModContent.ItemType<GojosHair>());
        items.Add(ModContent.ItemType<GojosShirt>());
        items.Add(ModContent.ItemType<GojosPants>());
        
        // Ino
        items.Add(ModContent.ItemType<InosBeanie>());
        items.Add(ModContent.ItemType<InosShiestyHelmet>());
        items.Add(ModContent.ItemType<InosShiestyAccessory>());
        items.Add(ModContent.ItemType<InosHair>());
        items.Add(ModContent.ItemType<InosShirt>());
        items.Add(ModContent.ItemType<InosPants>());

        // Past Geto
        items.Add(ModContent.ItemType<PastGetosHair>());
        items.Add(ModContent.ItemType<PastGetosShirt>());
        items.Add(ModContent.ItemType<PastGetosPants>());

        // Past Gojo
        items.Add(ModContent.ItemType<PastGojosHair>());
        items.Add(ModContent.ItemType<PastGojosShirt>());
        items.Add(ModContent.ItemType<PastGojosPants>());
        items.Add(ModContent.ItemType<PastGojosGlasses>());

        // Sukuna
        items.Add(ModContent.ItemType<SukunasHair>());
        items.Add(ModContent.ItemType<SukunasShirt>());
        items.Add(ModContent.ItemType<SukunasPants>());
        items.Add(ModContent.ItemType<EightHandledWheel>());

        // Toji
        items.Add(ModContent.ItemType<TojisHair>());
        items.Add(ModContent.ItemType<TojisShirt>());
        items.Add(ModContent.ItemType<TojisPants>());
        items.Add(ModContent.ItemType<TojiWorm>());

        // True Sukuna
        items.Add(ModContent.ItemType<TrueSukanaHair>());
        items.Add(ModContent.ItemType<TrueSukanaBody>());
        items.Add(ModContent.ItemType<TrueSukanaLegs>());

        // Yuta
        items.Add(ModContent.ItemType<YoungYutasHair>());
        items.Add(ModContent.ItemType<YutasHair>());
        items.Add(ModContent.ItemType<YutasShirt>());
        items.Add(ModContent.ItemType<YutasPants>());
        items.Add(ModContent.ItemType<YutasKatanaBag>());

        // Yuji
        items.Add(ModContent.ItemType<YujikunaHair>());
        items.Add(ModContent.ItemType<YujiSlickHair>());
        items.Add(ModContent.ItemType<YujisShirt>());
        items.Add(ModContent.ItemType<YujisPants>());


        // Add all recipes
        foreach (int item in items) 
        {
            Recipe.Create(item)
                .AddIngredient(ItemID.Silk)
                .AddTile(TileID.Loom)
                .Register();
        }
    }
}
