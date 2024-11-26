
import ctypes
import time

def stay_active_in_teams():
    print("Ekran açık. Teams üzerinde aktif olarak görünüyorsunuz...")
    while True:
        ctypes.windll.user32.SetCursorPos(0, 0)  # Fareyi sol üst köşeye getir
        ctypes.windll.user32.SetCursorPos(1, 1)  # Fareyi hafifçe oynat
        time.sleep(150)  # Her 50 saniyede bir tetiklenir

if __name__ == "__main__":
    try:
        stay_active_in_teams()
    except KeyboardInterrupt:
        print("\nProgram durduruldu.")
