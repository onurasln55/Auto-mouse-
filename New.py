import pyautogui
import time
import random

# Tıklama yapacağı koordinat aralığı (örnek olarak 400-800 x 300-600 seçildi)
X_MIN, X_MAX = 400, 800
Y_MIN, Y_MAX = 300, 600

# Tıklama aralığı (saniye cinsinden)
CLICK_INTERVAL = 30  # Her 10 saniyede bir tıklama yapacak

try:
    while True:
        x = random.randint(X_MIN, X_MAX)
        y = random.randint(Y_MIN, Y_MAX)

        pyautogui.moveTo(x, y, duration=0.5)  # Fareyi yumuşak bir şekilde hareket ettir
        pyautogui.click()  # Tıklama yap

        print(f"Tıklama yapıldı: ({x}, {y})")

        time.sleep(CLICK_INTERVAL)  # Belirlenen süre kadar bekle
except KeyboardInterrupt:
    print("\nİşlem kullanıcı tarafından durduruldu.")
