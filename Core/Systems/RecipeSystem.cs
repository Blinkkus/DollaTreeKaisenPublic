using NeviliscoVanity.Content.Items.Accessories.Vanity;
using NeviliscoVanity.Content.Items.Armor.Vanity.Gojo;
using NeviliscoVanity.Content.Items.Armor.Vanity.Ino;
using NeviliscoVanity.Content.Items.Armor.Vanity.PastGeto;
using NeviliscoVanity.Content.Items.Armor.Vanity.PastGojo;
using NeviliscoVanity.Content.Items.Armor.Vanity.Sukuna;
using NeviliscoVanity.Content.Items.Armor.Vanity.Toji;
using NeviliscoVanity.Content.Items.Armor.Vanity.TrueSukuna;
using NeviliscoVanity.Content.Items.Armor.Vanity.Yuji;
using NeviliscoVanity.Content.Items.Armor.Vanity.Yuta;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NeviliscoVanity.Core.Systems;

public class RecipeSystem : ModSystem
{
    public override void AddRecipes()
    {
        // Shorthand
        static int ItemType<T>() where T : ModItem => ModContent.ItemType<T>();

        List<int> items = new List<int>()
        {
            // Gojo
            ItemType<BlindfoldGojosHair>(),
            ItemType<NoBlindfoldGojosHair>(),
            ItemType<GojosHair>(),
            ItemType<GojosShirt>(),
            ItemType<GojosPants>(),

            // Ino
            ItemType<InosBeanie>(),
            ItemType<InosShiestyHelmet>(),
            ItemType<InosShiestyAccessory>(),
            ItemType<InosHair>(),
            ItemType<InosShirt>(),
            ItemType<InosPants>(),

            // Past Geto
            ItemType<PastGetosHair>(),
            ItemType<PastGetosShirt>(),
            ItemType<PastGetosPants>(),

            // Past Gojo
            ItemType<PastGojosHair>(),
            ItemType<PastGojosShirt>(),
            ItemType<PastGojosPants>(),
            ItemType<PastGojosGlasses>(),

            // Sukuna
            ItemType<SukunasHair>(),
            ItemType<SukunasShirt>(),
            ItemType<SukunasPants>(),
            ItemType<EightHandledWheel>(),

            // Toji
            ItemType<TojisHair>(),
            ItemType<TojisShirt>(),
            ItemType<TojisPants>(),
            ItemType<TojiWorm>(),

            // True Sukuna
            ItemType<TrueSukunaHair>(),
            ItemType<TrueSukunaBody>(),
            ItemType<TrueSukunaLegs>(),

            // Yuta
            ItemType<YoungYutasHair>(),
            ItemType<YutasHair>(),
            ItemType<YutasShirt>(),
            ItemType<YutasPants>(),
            ItemType<YutasKatanaBag>(),

            // Yuji
            ItemType<YujikunaHair>(),
            ItemType<YujiSlickHair>(),
            ItemType<YujisShirt>(),
            ItemType<YujisPants>()
        };


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
