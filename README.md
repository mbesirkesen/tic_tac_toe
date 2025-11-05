# Tic Tac Toe (XOX) Oyunu

Windows Forms ile geliştirilmiş klasik Tic Tac Toe (XOX) oyunu. Oyuncu bilgisayara karşı oynar.

## 🎮 Özellikler

- **İki Oyuncu Modu**: Oyuncu (X) vs Bilgisayar (O)
- **Skor Takibi**: Oyuncu ve bilgisayarın kazanma sayılarını takip eder
- **Otomatik Hamle**: Bilgisayar rastgele hamleler yapar
- **Yeniden Başlatma**: "RESTART" butonu ile oyunu sıfırlayabilirsiniz
- **Görsel Geri Bildirim**: 
  - Oyuncu hamleleri **Cyan** renkte
  - Bilgisayar hamleleri **Kırmızı** renkte

## 🛠️ Teknolojiler

- **C#** (.NET Framework 4.6.1)
- **Windows Forms**
- **Visual Studio**

## 📋 Gereksinimler

- Windows işletim sistemi
- .NET Framework 4.6.1 veya üzeri
- Visual Studio 2017 veya üzeri (geliştirme için)

## 🚀 Kurulum

1. Projeyi klonlayın:
```bash
git clone https://github.com/kullanici-adi/tic-tac-toe.git
```

2. Projeyi Visual Studio'da açın:
   - `tic tac toe.sln` dosyasını açın

3. Projeyi derleyin:
   - `F5` tuşuna basın veya "Build > Build Solution" seçeneğini kullanın

4. Uygulamayı çalıştırın:
   - Visual Studio'da `F5` tuşuna basın veya `bin/Debug/tic tac toe.exe` dosyasını çalıştırın

## 🎯 Nasıl Oynanır?

1. Oyun başladığında 3x3'lük bir grid görürsünüz
2. Boş bir kareye tıklayarak hamle yapın (X işareti)
3. Bilgisayar otomatik olarak hamle yapacaktır (O işareti)
4. Üç işareti yatay, dikey veya çapraz olarak sıralayan ilk oyuncu kazanır
5. Oyun bittiğinde skorlar güncellenir ve yeni bir oyun başlar
6. İstediğiniz zaman "RESTART" butonuna basarak oyunu sıfırlayabilirsiniz

## 📁 Proje Yapısı

```
tic tac toe/
├── tic tac toe/
│   ├── Form1.cs              # Ana oyun mantığı
│   ├── Form1.Designer.cs     # Form tasarımı
│   ├── Form1.resx            # Form kaynakları
│   ├── Program.cs             # Uygulama giriş noktası
│   └── Properties/           # Proje özellikleri
├── tic tac toe.sln           # Visual Studio solution dosyası
└── README.md                 # Bu dosya
```

## 🎨 Oyun Görünümü

- **Oyuncu (X)**: Cyan renkte, sol üstte skor gösterilir
- **Bilgisayar (O)**: Kırmızı renkte, sağ üstte skor gösterilir
- **9 Adet Buton**: 3x3 grid oluşturur
- **RESTART Butonu**: Alt kısımda oyunu sıfırlar

## 🔧 Geliştirme Notları

- Oyun mantığı `Form1.cs` dosyasında bulunur
- Bilgisayar hamleleri rastgele seçilir (`Random` sınıfı kullanılır)
- Kazanma durumları tüm olası kombinasyonlar kontrol edilerek belirlenir
- Timer kullanılarak bilgisayar hamlesi 1 saniye gecikmeyle yapılır

## 📝 Lisans

Bu proje eğitim amaçlı geliştirilmiştir.

## 👤 Yazar

**Muhammed Beşir Kesen** tarafından geliştirilmiştir.

## 🤝 Katkıda Bulunma

Katkılarınızı bekliyoruz! Pull request göndermekten çekinmeyin.

---

**Not**: Bu oyun basit bir AI kullanır. Bilgisayar hamleleri rastgele seçilir, bu yüzden strateji gerektirmez.

