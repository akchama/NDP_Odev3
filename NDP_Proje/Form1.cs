/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2014-2015 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........: 3 - Proje Ödevi
**				ÖĞRENCİ ADI............: Abdullah Akçam
**				ÖĞRENCİ NUMARASI.......: g140910076
**                         DERSİN ALINDIĞI GRUP...: 2. Öğretim A
****************************************************************************/

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using NDP_Proje.UrunTurleri;

namespace NDP_Proje
{
    public partial class Form1 : Form
    {
        // Ürünelerin tutulduğu property
        private List<Urun> urunler;

        public Form1()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            about.Text = "Nesneye Dayalı Programlama" +
                         "\nProje Ödevi" +
                         "\nAbdullah Akçam - g140910076";

            urunler = VeriOlustur.UrunleriOlustur();
        }

        #region Butonlar

        /* Bu bölümde buton atamaları yapılmaktadır. Butonlara tıklandığında Veriler.cs den
         * alınıp oluşturularn veriler ile DataGridView bileşenleri doldurulmaktadır.
         */

        private void satilanUrunlerButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            foreach (var urun in urunler)
                switch (urun)
                {
                    case Bayan o:
                        dataGridView1.Rows.Add(urun.SatisTarihi.ToString("dd-MM-yyyy"), o.TurIsmi,
                            urun.Musteri.AdSoyad);
                        break;
                    case Erkek y:
                        dataGridView1.Rows.Add(urun.SatisTarihi.ToString("dd-MM-yyyy"), y.TurIsmi,
                            urun.Musteri.AdSoyad);
                        break;
                    case Cocuk i:
                        dataGridView1.Rows.Add(urun.SatisTarihi.ToString("dd-MM-yyyy"), i.TurIsmi,
                            urun.Musteri.AdSoyad);
                        break;
                }

            dataGridView1.CurrentCell = null;
        }

        private void buttonSiparisEdilen_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();

            // Her ürün için tedarikçi ataması yapar
            foreach (var urun in urunler)
                switch (urun)
                {
                    case Bayan bayan:
                        dataGridView2.Rows.Add(urun.AlisTarihi.ToString("dd-MM-yyyy"), bayan.TurIsmi,
                            urun.Tedarikci.AdSoyad);
                        break;
                    case Erkek erkek:
                        dataGridView2.Rows.Add(urun.AlisTarihi.ToString("dd-MM-yyyy"), erkek.TurIsmi,
                            urun.Tedarikci.AdSoyad);
                        break;
                    case Cocuk cocuk:
                        dataGridView2.Rows.Add(urun.AlisTarihi.ToString("dd-MM-yyyy"), cocuk.TurIsmi,
                            urun.Tedarikci.AdSoyad);
                        break;
                }

            dataGridView2.CurrentCell = null;
        }

        private void buttonGelirGider_Click(object sender, EventArgs e)
        {
            dataGridView3.Rows.Clear();
            // Her ürün için tedarikçi ataması yapar
            var bilanco = new Bilanco(urunler);
            foreach (var gun in bilanco.Gunler)
                dataGridView3.Rows.Add(gun.GununTarihi.ToString("dd-MM-yyyy"), gun.SatisToplamlar, gun.AlisToplamlar);
            dataGridView3.CurrentCell = null;
        }

        /* Buradaki ürün türleri genel türler olduğu için (Örneğin erkek giyimde pantolon olabilir)
         * Ürün türlerini tek tek stoklarına göre listelemek ile hepsini toplayıp listelemek arasında
         * kararsız kaldım. O yüzden ikinci yoldan yaptım
         */

        private void buttonDepodakiUrunleriListele_Click(object sender, EventArgs e)
        {
            dataGridView4.Rows.Clear();
            var bayanToplam = 0;
            var erkekToplam = 0;
            var cocukToplam = 0;
            foreach (var urun in urunler)
                switch (urun)
                {
                    case Bayan bayan:
                        bayanToplam += urun.Stok.DepodakiUrunler;
                        break;
                    case Erkek erkek:
                        erkekToplam += urun.Stok.DepodakiUrunler;
                        break;
                    case Cocuk cocuk:
                        cocukToplam += urun.Stok.DepodakiUrunler;
                        break;
                }

            dataGridView4.Rows.Add(new Bayan().TurIsmi, bayanToplam);
            dataGridView4.Rows.Add(new Erkek().TurIsmi, erkekToplam);
            dataGridView4.Rows.Add(new Cocuk().TurIsmi, cocukToplam);
            dataGridView4.CurrentCell = null;
        }

        private void buttonRaftakiUrunleriListele_Click(object sender, EventArgs e)
        {
            dataGridView5.Rows.Clear();
            var bayanToplam = 0;
            var erkekToplam = 0;
            var cocukToplam = 0;
            foreach (var urun in urunler)
                switch (urun)
                {
                    case Bayan bayan:
                        bayanToplam += urun.Stok.RaftakiUrunler;
                        break;
                    case Erkek erkek:
                        erkekToplam += urun.Stok.RaftakiUrunler;
                        break;
                    case Cocuk cocuk:
                        cocukToplam += urun.Stok.RaftakiUrunler;
                        break;
                }

            dataGridView5.Rows.Add(new Bayan().TurIsmi, bayanToplam);
            dataGridView5.Rows.Add(new Erkek().TurIsmi, erkekToplam);
            dataGridView5.Rows.Add(new Cocuk().TurIsmi, cocukToplam);
            dataGridView5.CurrentCell = null;
        }

        #endregion
    }
}