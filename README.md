C# Erişim Belirleyicilerinin Açıklamaları
1. Public Erişim Belirleyici
    Tanım: Public erişim belirleyicisi, en geniş erişim seviyesidir. Public olarak işaretlenen bir sınıf üyesine (metot, özellik, alan, vb.) projenin her yerinden  erişilebilir. Aynı proje, farklı projeler, farklı assembly'ler (dll dosyaları) ve hatta referans alan diğer uygulamalardan bile erişim sağlanabilir.
Kullanım Durumları:

Gerçek Hayat Örneği: Bir alışveriş merkezinin giriş kapısı gibidir. Herkes tarafından kullanılabilir, hiçbir kısıtlama yoktur.

API'nin bir parçası olarak dış dünyaya sunulması gereken sınıflar ve metotlar
Diğer sınıfların da kullanması gereken yardımcı metotlar
Başka projelerden erişilmesi gereken veri modelleri

Avantajları: Maksimum erişilebilirlik sağlar.
Dezavantajları: Gereğinden fazla kullanıldığında kapsüllemeyi zayıflatır ve bağımlılıkları artırır.

2. Private Erişim Belirleyici
 Tanım: Private üyeler sadece tanımlandıkları sınıf içerisinden erişilebilir. Aynı assembly içinde olsa bile, türetilen sınıflar dahil olmak üzere sınıf dışından hiçbir şekilde erişilemez. Bu, kapsüllemenin en güçlü formudur.
Kullanım Durumları:

Gerçek Hayat Örneği: Bir alışveriş merkezinin giriş kapısı gibidir. Herkes tarafından kullanılabilir, hiçbir kısıtlama yoktur.

Sınıfın iç işleyişi için gereken değişkenler ve metotlar
Doğrudan dış erişime açılmaması gereken hassas veri alanları
Sınıfın mantığını oluşturan yardımcı algoritmaları içeren metotlar

Avantajları: Maksimum koruma sağlar, sınıfın iç yapısını değiştirme özgürlüğü verir.
Dezavantajları: Bazen aşırı kısıtlayıcı olabilir ve kod tekrarına neden olabilir.

3. Protected Erişim Belirleyici
    Tanım: Protected üyeler, tanımlandıkları sınıf ve bu sınıftan türetilen tüm alt sınıflar (aynı veya farklı assembly'lerde olsa bile) tarafından erişilebilir. Bu, kalıtım (inheritance) için tasarlanmış sınıflarda önemlidir.
Kullanım Durumları:

Alt sınıfların özelleştirmesi veya yeniden uygulaması (override) gereken metotlar
Alt sınıfların erişmesi gereken, ancak tamamen public olmaması gereken veriler
İç mantık için kullanılan ama alt sınıfların da bilmesi gereken değişkenler

Gerçek Hayat Örneği: Aile üyeleri arasında paylaşılan bilgiler gibidir. Aile içinde konuşulabilir ama yabancılara açıklanmaz.

Avantajları: Kalıtım hiyerarşisinde veri ve davranış paylaşımını destekler.
Dezavantajları: Hiyerarşideki değişiklikler bu üyelere beklenmedik erişimlere neden olabilir.

4. Internal Erişim Belirleyici
 Tanım: Internal üyeler, aynı assembly (derleme) içindeki tüm sınıflar tarafından erişilebilir. Farklı bir projeden veya dll'den referans alınsa bile, internal üyelere erişilemez. Bu, modül seviyesinde kapsülleme sağlar.
Kullanım Durumları:

Bir projenin farklı bölümleri arasında paylaşılması gereken, ancak dış dünyaya açılmaması gereken bileşenler
Aynı kütüphane içinde çalışan yardımcı sınıflar
Modül içi uygulama detayları

Gerçek Hayat Örneği: Bir şirketin departman içi bilgileri gibidir. Şirket içinde paylaşılabilir ama dışarıya çıkmaz.

Avantajları: Modül sınırlarını belirginleştirir, dış erişimi kısıtlar.
Dezavantajları: Projenin büyümesiyle birlikte, iç içe geçmiş bağımlılıklara neden olabilir.

5. Protected Internal Erişim Belirleyici
 Tanım: Protected internal üyeler, aynı assembly içindeki tüm sınıflar VEYA bu sınıftan türetilen sınıflar (farklı assembly'lerde olsa bile) tarafından erişilebilir. Yani protected VE internal erişim belirleyicilerinin birleşimidir.
Kullanım Durumları:

Aynı assembly içinde paylaşılması gereken, ancak farklı assembly'lerde sadece kalıtım yoluyla erişilmesi gereken özellikler
Framework tasarımında, belirli özellikler için genişletilebilirlik sağlama

Gerçek Hayat Örneği: Franchise iş modeli gibidir. Ana şirket (aynı derleme) ve franchise alan şubeler (türetilen sınıflar) bilgiye erişebilir.

Avantajları: Internal ve protected belirleyicilerinin avantajlarını birleştirir.
Dezavantajları: Karmaşık erişim mantığı bazen kafa karıştırıcı olabilir.

6. Private Protected Erişim Belirleyici
 Tanım: Private protected üyeler, aynı assembly içindeki türetilmiş sınıflar tarafından erişilebilir. Farklı assembly'lerdeki türetilmiş sınıflar erişemez. Yani protected VE internal erişim belirleyicilerinin kesişimidir.
Kullanım Durumları:

Aynı assembly içinde kalıtım yoluyla sınırlandırılmış erişim gerektiren üyeler
Kütüphane geliştiricilerinin, kendi kütüphanesi içindeki kalıtım için ayrılan özellikler

Gerçek Hayat Örneği: Bir şirketin sadece yönetici pozisyonundaki çalışanlarına verdiği özel bilgiler gibidir.

Avantajları: En hassas erişim kontrolünü sağlar, kalıtımı assembly içinde sınırlar.
Dezavantajları: C# 7.2'den önce kullanılamaz, kullanımı nispeten daha az yaygındır.
Bu erişim belirleyiciler, yazılım tasarımında güçlü sınırlar ve kontrollü erişim noktaları oluşturmanızı sağlar. Her biri belirli bir senaryo için en uygun çözümü sunar ve doğru kullanıldıklarında, kodunuzun kalitesini, güvenliğini ve bakım yapılabilirliğini önemli ölçüde artırırlar.



Erişim Belirleyicilerin OOP'deki Rolü

Kapsülleme (Encapsulation): Erişim belirleyiciler, veri ve davranış kapsüllemesinin temelidir. Verileri private yapıp, kontrollü erişim için public metotlar sağlamak en temel OOP prensiplerinden biridir.

Güvenlik: Hassas veri ve operasyonları koruyarak istenmeyen erişimleri engellerler. Örneğin banka bakiyesinin doğrudan değiştirilememesi.

Arayüz Tasarımı: Sınıfın hangi özellik ve davranışlarının dışarıya açık olacağını tanımlarlar, böylece temiz ve anlaşılır API'ler oluşturulur.

Sürüm Kontrolü: Gelecekte değişebilecek iç detayları gizleyerek, public arayüzün sabit kalmasını ve geriye dönük uyumluluğu desteklerler.

Kalıtım Kontrolü: Protected gibi belirleyiciler, miras hiyerarşisinde hangi özelliklerin alt sınıflara aktarılacağını kontrol eder.

Modüler Tasarım: Internal gibi belirleyiciler, büyük projelerin modüler olarak yapılandırılmasını ve derleme sınırlarının belirlenmesini sağlar.

Erişim belirleyiciler, kodun nasıl kullanılacağı konusunda hem rehberlik eder hem de sınırlamalar getirir. Bu da daha güvenli, bakımı kolay ve ölçeklenebilir yazılım sistemleri geliştirmeye yardımcı olur.
