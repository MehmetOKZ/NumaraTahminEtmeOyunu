# 🎯 Numara Tahmin Etme Oyunu

Bu küçük C# konsol uygulaması, kullanıcıdan 1 ile 10 arasında rastgele seçilen bir sayıyı tahmin etmesini isteyen basit ve eğlenceli bir oyundur.

## 🕹️ Nasıl Çalışır?

Program başlatıldığında:

- 1 ile 10 arasında rastgele bir sayı oluşturulur.
- Kullanıcıdan bu sayıyı tahmin etmesi istenir.
- Kullanıcının her tahmini sonrasında, tahminin rastgele sayıya göre yüksek mi, düşük mü olduğu belirtilir.
- Doğru tahmin yapıldığında oyun sona erer ve kullanıcı tebrik edilir.

## 📷 Ekran Görüntüleri

Başlangıç ekranı:  
![Screenshot 1](https://github.com/MehmetOKZ/NumaraTahminEtmeOyunu/blob/master/asset/Screenshot-1.png?raw=true)

Tahmin etme süreci:  
![Screenshot 2](https://github.com/MehmetOKZ/NumaraTahminEtmeOyunu/blob/master/asset/Screenshot-2.png?raw=true)

Doğru tahmin sonrası ekran:  
![Screenshot 3](https://github.com/MehmetOKZ/NumaraTahminEtmeOyunu/blob/master/asset/Screenshot-3.png?raw=true)

## 💻 Kod Açıklaması

```csharp
bool tahmindogru = false;
Random rastgele = new Random();
int rastgelesayı = rastgele.Next(1, 11); // 1 ile 10 arasında rastgele bir sayı üret

Console.WriteLine("Numara tahmin etme oyununua hoşgeldiniz!");
Console.WriteLine("1 ile 10 arasında bir sayı oluşturulacak");
Console.WriteLine("Numarayı doğru tahmin edebilirseniz kazanırsınız");

while (!tahmindogru)
{
    Console.WriteLine("Lütfen tahmininizi giriniz.");
    int tahmin = Convert.ToInt32(Console.ReadLine());

    if (tahmin > rastgelesayı)
        Console.WriteLine("Tahmininiz çok yüksek");
    else if (tahmin < rastgelesayı)
        Console.WriteLine("Tahmininiz çok düşük");
    else
    {
        Console.WriteLine("Doğru!");
        tahmindogru = true;
    }
}

Console.WriteLine("Tebrikler, Oyunu kazandınız!");
