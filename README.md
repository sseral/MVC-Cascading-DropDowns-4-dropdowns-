MVC-Cascading-DropDowns (4-dropdowns) - MVC Bağımlı DropDownlar (4 DropDown - birbirine bağımlı) - (İL, İLÇE, SEMT, MAHALLE seçimi için)

MVC geliştiricileri ASP.NET ‘te alıştığımız bol dökümantasyon ve örnek programlar bulmada hala sıkıntılı. Gerçek hayat örneği olmayan  örnekleme yapan arkadaşlar işi kolaylaştırmıyor. 

İnternette bulduğum hiçbir örnek doğru çalışmadı veya amacıma uymadı. Burada verdiklerim bu konudaki aramalarınıza 
kesin cevap olup, tüm testleri yapıldı. Yani ben sizin ile çalışan bir programımdan direk aldığım kodlarımı paylaşıyorum. 

Burada özellikle Türkiye 'deki tüm İL, İLÇE, SEMT ve MAHALLE 'ler için birbirine bağımlı çalışan Dropdownların MVC 'de 
nasıl olacağını anlatıyorum. Gerçek senaryoda veriler veritabanından çekilmeli ki bu da veritabanında bu tabloları 
oluşturmaktan geçiyor. Bu neden ile ben size bu konuda da yardımcı oluyorum veritabanı tabloları içeriklerini vererek. 
Tablolar MSSQL için ve Türkiye 'nin tüm   İL, İLÇE, SEMT ve MAHALLELERİ 'ni kapsıyor. 

Öncelikle bu DropDown 'ların herhangi bir Modele ihtiyaç duymuyor olması nedenini açıklayayım. Çünkü gerçek hayat
senaryosu için oluşturacağınız View 'lerde bu dropdownların dışında da başka  field lerin de doldurulmasını 
isteyebilirsiniz. O zaman kullanacağınız her view Model 'ine bu dropdownları sorunsuzca entegre edebilirsiniz. 
Her ne kadar ben İL, İLÇE, SEMT ve MAHALLE dropdownlarını örnekliyor da olsam bu mantığı başka bir senaryoya 
kolayca uygulayabilirsiniz. Sadece buradaki mantığı iyi anlayın.

Burada püf noktası şu. Her şey Index.cshtml  ve HomeController.cs 'te bitiyor. Sadece Index.cshtml 'deki scripler sayesinde herhangi bir dropdown değiştiğinde diğer dropdownların bu değişen dropdowndaki değişikliğe göre durum alması sağlanıyor. Bu da HomeController.cs 'te tanımlanmış olan JSon fonksiyonları ile ve sayfa yenilenmeden gerçekleşiyor.
Yani dikkatinizi sadece 2 şeye verin. HomeController.cs ve Index.cshtml. Diğerleri ise veritabanında il, ilçe, semt ve mahalleleri oluşturabilmeniz için sql scriptleri. Çünkü Json fonksiyonları bu tablolardan veriyi çekiyor.

Şimdi bu iki öğeyi inceleyin.


