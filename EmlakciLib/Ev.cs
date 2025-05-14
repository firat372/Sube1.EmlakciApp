using System;

public abstract class Ev
{
    public static int Sayac { get; private set; }

    public Ev()
    {
        Sayac++;
    }

    public Ev(int odasayisi, int katno, double alan, string semt = "Kızılay")
    {
        this.Odasayisi = odasayisi;
        this.Katno = katno;
        this.Semt = semt;
        this.Alan = alan;
        Sayac++;
    }

    private string semt;
    public string Buyukluk { get; private set; }
    public int Katno { get; set; }
    public string Semt { get => semt; set => semt = value.ToUpper(); }
    private int odasayisi;
    public int Odasayisi { get => odasayisi; set => odasayisi = Math.Abs(value); }

    private double alan;
    public double Alan
    {
        get { return alan; }
        set
        {
            if (value < 50)
                throw new Exception("Min alan değeri 50 olmalıdır");

            alan = value;
            if (alan > 50 && alan < 75)
                Buyukluk = "Küçük Ev";
            else if (alan >= 75 && alan < 120)
                Buyukluk = "Orta büyüklükte ev";
            else
                Buyukluk = "Büyük ev";
        }
    }

    // 🔴 Artık bu metot soyut, yani her çocuk class'ta override edilmesi zorunlu
    public abstract string EvBilgileri();
}
