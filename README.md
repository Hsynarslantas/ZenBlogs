# ReporterDay - Çok Katmanlı ASP.NET Core Blog Uygulaması

Bu proje, ASP.NET Core 7.0 teknolojisi kullanılarak geliştirilen çok katmanlı bir blog uygulamasıdır. Kullanıcıların makale yazabildiği, bu makaleleri kategorilere göre sınıflandırabildiği ve içerik detaylarını dinamik olarak görüntüleyebildiği bir içerik yönetim sistemidir.

## 🔧 Kullanılan Teknolojiler
- ASP.NET Core 7.0
- Entity Framework Core
- ASP.NET Identity
- SQL Server
- Layered Architecture (N Katmanlı Mimari)
- Slug tabanlı routing
- X.PagedList
- ApexCharts (istatistik görselleri için)
- Bootstrap 5 (Spike teması ile uyumlu)

## 🔐 Özellikler
- Yetkilendirme ve kimlik doğrulama (giriş yapılmadan dashboard ve içeriklere erişim engellenmiştir)
- Yazar paneli (dashboard) ile son makaleler, toplam içerik sayısı gibi bilgilerin listelenmesi
- Slug yapısıyla SEO dostu makale detay sayfaları (örnek: `/benim-makalem-slug`)
- Dinamik olarak içerik listesi ve kategoriye göre filtreleme
- Writer (Yazar) profil sayfası
- Makale detaylarında yorumlar ve tarih bilgisi

## 🧩 Katmanlar
- **EntityLayer**: Tüm veri modelleri
- **DataAccessLayer**: EF Core ile veritabanı işlemleri
- **BusinessLayer**: İş kuralları ve validasyonlar
- **PresentationLayer**: MVC yapısında kullanıcıya sunulan arayüz

## 📌 Başlangıç
1. Veritabanını `Update-Database` ile oluşturun
2. Projeyi çalıştırarak giriş yapın veya yeni kullanıcı oluşturun
3. Yazar paneline giriş yaparak makale paylaşabilirsiniz
<img width="1559" height="939" alt="Image" src="https://github.com/user-attachments/assets/8cd2c3d2-ef78-4546-b778-28e6269e8aff" />
<img width="1561" height="935" alt="Image" src="https://github.com/user-attachments/assets/faefe99e-d5e8-4a3d-b2f0-240d12ee8c35" />
<img width="1586" height="916" alt="Image" src="https://github.com/user-attachments/assets/20627677-3065-4800-97b0-28cd60437d77" />
<img width="1573" height="929" alt="Image" src="https://github.com/user-attachments/assets/5e267b5b-7f00-4d47-96c0-8e42a0b02bf3" />
<img width="1601" height="815" alt="Image" src="https://github.com/user-attachments/assets/f5078dda-26ca-4cd6-ae47-e7ae53ea5bb0" />
<img width="1555" height="934" alt="Image" src="https://github.com/user-attachments/assets/9f0fe6c3-25a8-4aeb-9d61-1c33d0fddbdb" />
