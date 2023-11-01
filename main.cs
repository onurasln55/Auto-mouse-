using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;

namespace OtomatikTiklamaUygulamasi
{
    class Program
    {
        private static Rectangle clickArea = new Rectangle(850, 500, 50, 50); // Tıklama bölgesini belirleyin
        private static Random random = new Random();

        static void Main(string[] args)
        {
            Console.WriteLine("Otomatik Tıklama Uygulaması");
            Console.WriteLine("Programı sonlandırmak için Ctrl+C tuşlarına basın.");

            while (true)
            {
                // Belirlediğiniz alanda rastgele bir X ve Y koordinatı seçin
                int randomX = random.Next(clickArea.Left, clickArea.Right);
                int randomY = random.Next(clickArea.Top, clickArea.Bottom);

                // Koordinatları ekrana yazdır
                Console.WriteLine($"X: {randomX}, Y: {randomY}");

                // Seçilen koordinatlara tıklama işlemini gerçekleştirin
                SetCursorPos(randomX, randomY);
                mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);

                // Belirlediğiniz aralıklarla tıklamaları yapın (örneğin, her 10 saniyede bir)
                Thread.Sleep(60000);
            }
        }

        [DllImport("user32.dll")]
        private static extern bool SetCursorPos(int X, int Y);

        [DllImport("user32.dll")]
        private static extern void mouse_event(uint dwFlags, int dx, int dy, uint cButtons, uint dwExtraInfo);

        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
    }
}
