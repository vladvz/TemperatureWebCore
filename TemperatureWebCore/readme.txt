Prepare web site (Windows VS)
=============================
1. Go to the root of project in cmd and run: dotnet publish -r ubuntu.16.04-arm
2. With WinSCP to copy all the files created from the folder ...\bin\Debug\netcoreapp2.0\ubuntu.16.04-arm32\publish\ to the Raspberry Pi folder /home/pi/wwwroot/TemperatureWebCore

Run web site on Raspberry Pi
============================
cd ~/wwwroot/TemperatureWebCore
sudo dotnet TemperatureWebCore.dll &

Hosting environment: Production
Content root path: /home/pi/wwwroot/TemperatureWebCore
Now listening on: http://[::]:9999
Application started. Press Ctrl+C to shut down.