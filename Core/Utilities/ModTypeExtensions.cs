namespace NeviliscoVanity.Core.Utilities;

public partial class Utilities
{
    public static string GetAssetPath(string prefix, string name) =>
        $"NeviliscoVanity/Assets/Textures/{prefix}/{name}";
}
