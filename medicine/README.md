# medicine
İlaç prospektüsüne ulaşamayan veya görme kısıtı olan insanlar için prospektüse web sayfasından ulaşabilmek 

Sisteminizde Visual Studio 2017, Microsoft Sql Server, Microsoft Sql Server
Management Studio yazılımlarının kurulu olması gerekmektedir.
Projeye ait ilgili database script dosyası (script isimli dosya) çalıştırılır ve açılan
Sql Server Management Studio arayüzündeki "Execute" kısmına tıklanarak
database oluşturulur.
 Proje dosyalarının bulunduğu İlacim isimli klasördeki İlacim.sln dosyası
çalıştırılır, proje Visual Studio’da açılacaktır.
Web.config dosyası altında <connectionStrings> </ connectionStrings>
arasındaki “<add name="İlaçProspektüsü" connectionString="Data
Source=LAPTOP-MCK52B87; Initial Catalog=” şeklinde devam eden satırdaki
“LAPTOP-MCK52B87” silinir ve o kısma kendi SQL Server adınızı yazmanız
gerekir.
