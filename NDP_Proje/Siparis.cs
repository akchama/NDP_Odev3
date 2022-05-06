namespace NDP_Proje
{
    public class Siparis
    {
        public Urun SiparisEdilenUrun { get; set; }

        public Siparis SiparisVer(Urun urun)
        {
            return new Siparis();
        }
    }
}