namespace KelimeEzberleme;

public class Kelime
{
    public string Ingilizce { get; set; }
    public string Turkce { get; set; }

    public Kelime(string ingilizce, string turkce)
    {
        Ingilizce = ingilizce;
        Turkce = turkce;
    }
}
