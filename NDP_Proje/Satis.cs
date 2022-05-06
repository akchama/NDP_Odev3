namespace NDP_Proje
{
    // Satış müşteriden kalıtım almaktadır.
    public class Satis : Musteri
    {
        public Urun SatilanUrun { get; set; }

        public Satis UrunSat(Urun urun)
        {
            return new Satis();
        }
    }
}