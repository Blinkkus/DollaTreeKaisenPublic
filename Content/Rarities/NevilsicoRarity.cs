using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace NeviliscoVanity.Content.Rarities;

public class NevilsicoRarity : ModRarity
{
    public override Color RarityColor => Color.Lerp(Color.Black, Color.DarkRed, Main.masterColor);
}
