
{
    Sword s1 = new Sword(Material.iron, Gemstone.none , 10, 2);
    Sword s2 = new Sword(Material.steel, Gemstone.diamond, 11, 2);
    Sword s3 = new Sword(Material.binarium, Gemstone.bitstone, 18, 3);

    Console.WriteLine($"{s1}\n{s2}\n{s3}");


}

public record Sword (Material SwordMaterial, Gemstone SwordStone, float Length, float Width);
public enum Material
{wood,broxnze,iron,steel,binarium,}
public enum Gemstone {emerald,amber,sapphire,diamond,bitstone, none,}

