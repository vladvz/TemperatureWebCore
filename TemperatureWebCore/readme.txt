Install .NET Core 2 at Raspberry Pi
===================================

# Update the Raspbian Jessie install
sudo apt-get -y update

# Install the packages necessary for .NET Core
sudo apt-get -y install libunwind8 gettext

# Download the nightly binaries for .NET Core 2
wget https://dotnetcli.blob.core.windows.net/dotnet/Runtime/release/2.0.0/dotnet-runtime-latest-linux-arm.tar.gz

# Create a folder to hold the .NET Core 2 installation
sudo mkdir /opt/dotnet

# Unzip the dotnet zip into the dotnet installation folder
sudo tar -xvf dotnet-runtime-latest-linux-arm.tar.gz -C /opt/dotnet

# set up a symbolic link to a directory on the path so we can call dotnet
sudo ln -s /opt/dotnet/dotnet /usr/local/bin

# test dotnet
dotnet –info

Prepare web site (Windows VS)
=============================
1. Go to the root of project in cmd and run: dotnet publish -c Release -r ubuntu.16.04-arm
2. With WinSCP to copy all the files created from the folder ...\bin\Release\netcoreapp2.0\ubuntu.16.04-arm32\publish\ to the Raspberry Pi folder /home/pi/wwwroot/TemperatureWebCore

Run web site on Raspberry Pi
============================
cd ~/wwwroot/TemperatureWebCore
sudo dotnet TemperatureWebCore.dll &

Hosting environment: Production
Content root path: /home/pi/wwwroot/TemperatureWebCore
Now listening on: http://[::]:9999
Application started. Press Ctrl+C to shut down.

Check running process
=====================
ps -aef|grep TemperatureWebCore.dll
sudo kill -9 process_id