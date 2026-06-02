# 🎬 Cinemada - Sinema Bilet Otomasyonu

Bu proje, C# Windows Forms ve MS SQL Server kullanılarak geliştirilmiş, modern arayüze sahip bir sinema yönetim ve bilet satış otomasyonudur. Admin paneli üzerinden film, salon ve seans yönetimi yapılabilirken; kullanıcı arayüzü üzerinden dinamik koltuk seçimi ve büfe ürünleri satışı gerçekleştirilebilmektedir.

Admin Kullanıcı Adı: admin
Admin Şifre: admin123

---

## 👥 Proje Yürütücüleri (Geliştiriciler)

Hocamızın isteği doğrultusunda projeyi geliştiren ekip üyeleri ve öğrenci numaraları aşağıda belirtilmiştir:

- **Nisa Şener** - `243004004`
- **Umutcan Aksoy** - `243004011`
- **Aslı Nur Öztürk** - `243004027`

---

## 💾 Veritabanı Kurulumu (Restore)

Projeyi bilgisayarınızda veritabanı hatası almadan çalıştırmak için lütfen aşağıdaki adımları sırasıyla uygulayınız:

1.  **SQL Server Management Studio (SSMS)** programını açın ve yerel sunucunuza bağlanın.
2.  Sol taraftaki **Databases** klasörüne sağ tıklayıp **Restore Database...** seçeneğine basın.
3.  Açılan pencerede **Device** seçeneğini işaretleyin ve sağındaki **`...`** (üç nokta) butonuna tıklayın.
4.  **Add** butonuna basarak, bu projenin içindeki `/Database/SinemaOtomasyonu.bak` dosyasını seçip **OK** deyin.
5.  Pencereyi onaylayarak veritabanının sisteminize yüklenmesini (Restore) sağlayın.

> ⚠️ **Bağlantı Notu:** Proje içindeki veritabanı bağlantı dizesi yerel sunucu (`Server=.`) olarak ayarlanmıştır. Yukarıdaki adımları tamamladıktan sonra Visual Studio üzerinden projeyi direkt olarak başlatabilirsiniz.
