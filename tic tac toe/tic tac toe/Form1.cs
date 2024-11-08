using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tic_tac_toe
{
    public partial class Form1 : Form
    {   
        public enum Player
        {
            X , O
        }
        Player currentPlayer; //oyuncu sınıfını çağırıyor
         Random random = new Random();// rastgele sayı üreteci sınıfını içe aktarıyoruz 
        int playerWins = 0;// oyuncunun galibiyet tamsayısını 0 olarak ayarla
        int computerWins = 0;// bilgisayarın galibiyet tamsayısını 0 olarak ayarla
        List <Button> buttons;//bir LİSTE veya buton dizisi oluşturma
        public Form1()
        {
            InitializeComponent();
            RestartGame();
        }

        private void PcMove(object sender, EventArgs e)
        {
            if (buttons.Count>0)
            {
                int index = random.Next(buttons.Count);
                buttons[index].Enabled = false;
                currentPlayer = Player.O;
                buttons[index].Text = currentPlayer.ToString();
                buttons[index].BackColor = Color.Red;
                buttons.RemoveAt(index);
                Checkgame();
                pcGameTimer.Stop();
            }
        }

        private void PlayerClickButton(object sender, EventArgs e)
        {
            var button = (Button)sender;// hangi butona tıklandığını bul
            currentPlayer = Player.X;// oynatıcıyı X olarak ayarla
            button.Text = currentPlayer.ToString();// düğme metnini oynatıcı X olarak değiştir
            button.Enabled = false;// düğmeyi devre dışı bırak
            button.BackColor = Color.Cyan;// oynatıcının rengini Cyan'a değiştir
            buttons.Remove(button);// düğmeyi düğmeler listesinden kaldır böylece AI da tıklayamaz
            Checkgame();// oyuncunun kazanıp kazanmadığını kontrol et
            pcGameTimer.Start();// AI zamanlayıcısını başlat
        }

        private void RestartGame(object sender, EventArgs e)
        {
            RestartGame();
        }
        private void Checkgame()
        {   //Bu fonksiyonda oyuncunun veya yapay zekanın kazanıp kazanmadığını kontrol edeceğiz
            // kazanma olasılıkları olan iki çok büyük if ifademiz var
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X"
              || button4.Text == "X" && button5.Text == "X" && button6.Text == "X"
              || button7.Text == "X" && button9.Text == "X" && button8.Text == "X"
              || button1.Text == "X" && button4.Text == "X" && button7.Text == "X"
              || button2.Text == "X" && button5.Text == "X" && button8.Text == "X"
              || button3.Text == "X" && button6.Text == "X" && button9.Text == "X"
              || button1.Text == "X" && button5.Text == "X" && button9.Text == "X"
              || button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {   // yukarıdaki koşullardan herhangi biri karşılanırsa
                pcGameTimer.Stop(); //zamanlayıcıyı durdur
                MessageBox.Show("Oyuncu kazandı");// oyuncunnun kazandığını söyleyen bir mesaj kutusu göster
                playerWins++;// oyuncunun galibiyetlerini arttır
                label1.Text = "Oyuncu: " + playerWins;// oyuncu etiketini güncelle
                RestartGame(); // oyunu sıfırlama fonksiyonunu çalıştır

            }
            else if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O"
                    || button4.Text == "O" && button5.Text == "O" && button6.Text == "O"
                    || button7.Text == "O" && button9.Text == "O" && button8.Text == "O"
                    || button1.Text == "O" && button4.Text == "O" && button7.Text == "O"
                    || button2.Text == "O" && button5.Text == "O" && button8.Text == "O"
                    || button3.Text == "O" && button6.Text == "O" && button9.Text == "O"
                    || button1.Text == "O" && button5.Text == "O" && button9.Text == "O"
                    || button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
                 {  // yukarıdaki koşullardan herhangi biri karşılanırsa
                    pcGameTimer.Stop(); // zamanlayıcıyı durdur
                    MessageBox.Show("Bilgisayar Kazandı"); // bilgisayarın kazandığını söyleyen bir mesaj kutusu göster
                    computerWins++;// bilgisayarın galibiyetlerini arttır
                    label2.Text = "Bilgisayar: " + computerWins;// bilgisayar etiketini güncelle
                    RestartGame();// oyunu sıfırlama fonksiyonunu çalıştır
                 }
        }
        private void RestartGame()
        {
            buttons = new List<Button> { button1, button2, button3, button4, button5, button6, button7, button9, button8 };
            foreach  (Button x in buttons)
            {
                x.Enabled = true;
                x.Text = " ";
                x.BackColor = DefaultBackColor;
            }
        }
    } 
}

