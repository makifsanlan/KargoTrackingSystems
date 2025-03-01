using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KargoTrackingSystems
{
    public partial class Default : System.Web.UI.Page
    {
        CargoTracking_DBEntities baglanti = new CargoTracking_DBEntities();
       

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnUrunEkle_Click(object sender, EventArgs e)
        {
            Kargolar UrunEkle = new Kargolar();
            UrunEkle.KargoAdi = tbxKargoAdi.Text;
            UrunEkle.KargoAciklamasi = tbxKargoAciklamasi.Text;
            UrunEkle.KargoTakipNumarasi = tbxKargoNumarasi.Text;
           
            
            try
            {
                baglanti.Kargolar.Add(UrunEkle);
                baglanti.SaveChanges();
                lblSonuc.Text = "Ürün ekleme işlemi başarılı...";


            }
            catch (Exception)
            {
                lblSonuc.Text = "Ürün ekleme işlemi başarısız...";
                throw;
            }

        }

        protected void btnUrunListele_Click(object sender, EventArgs e)
        {
            baglanti.Kargolar.Load();
            GridView1.DataSource = baglanti.Kargolar.Local;
            GridView1.DataBind();

        }

        protected void btnSil_Click(object sender, EventArgs e)
        {
            string urunKodu = tbxKargoNumarasi.Text;
            var sorgu = (from kayit in baglanti.Kargolar
                         where kayit.KargoTakipNumarasi == urunKodu
                         select kayit).ToList();

            if (sorgu.Count == 1)
            {
                baglanti.Kargolar.Remove(sorgu[0]);
                baglanti.SaveChanges();
                lblSonuc.Text = "Silme işleri başarıyla gerçekleşti...";

            }
            else
            {
                lblSonuc.Text = "Silinecek ürün bulunamadı...";

            }
        }

        protected void btnUrunGuncelle_Click(object sender, EventArgs e)
        {
            string urunKodu = tbxKargoNumarasi.Text;
            var sorgu = (from kayit in baglanti.Kargolar
                         where kayit.KargoTakipNumarasi == urunKodu
                         select kayit).ToList();

            if (sorgu.Count == 1)
            {
                sorgu[0].KargoAdi = tbxKargoAdi.Text;
                sorgu[0].KargoAciklamasi = tbxKargoAciklamasi.Text;
                sorgu[0].KargoTakipNumarasi = tbxKargoNumarasi.Text;
                baglanti.SaveChanges();
                lblSonuc.Text = "Güncelleme başarıyla gerçekleşti...";
            }
            else
            {
                lblSonuc.Text = "Güncellenecek ürün bulunamadı...";
            }

        }
    }
}