FanFlow
=======

> **Head Up!** This application stopped working for me and may not be necessary anymore. But make sure to install the latest AppCenter and SIV (System Information Viewer) application that you can **[download here](https://www.gigabyte.com/Support/Utility)** for Gigabyte haven't updated motherboard's website in a long time now. 

FanFlow fixes Gigabyte's latest version of System Information Viewer (B14.0905.2) application that suddenly does not start Thermal Daemon (thermald.exe) automatically after Windows startup. Thermal Daemon is however responsible for monitoring temperatures and managing fans speed and therefore I have decided to fix it myself by providing an open source Windows Service that does nothing else than starts thermald.exe at the Windows startup.

You can download the latest installer [here](https://github.com/mareksuscak/FanFlow/releases). Please note that the installer is headless which means it won't show any dialog. Just run it and it will be installed automatically. You can always uninstall the FanFlow from the Programs and Features Windows screen.

Assumptions
===========

FanFlow makes a few assumptions. First it expects the file `thermald.exe` to be present at `C:\Program Files (x86)\Gigabyte\SIV\thermald.exe` on 64bit Windows and at `C:\Program Files\Gigabyte\SIV\thermald.exe` on 32bit Windows so if you've installed SIV elsewhere create an issue and I will see what can I do about it. Another assumption is that you have at least the .NET framework 4 installed on your machine (comes with Windows 7, 8, 8.1...) but if not, you can download current latest version [here](http://www.microsoft.com/en-us/download/details.aspx?id=42642). And last but not least Intel Management Engine driver for your particular motherboard is necessary to allow for communication between Gigabyte's software and fan speed control module.

FAQ
===

**Q:** Does the FanFlow contain any viruses?

**A:** No, no at all, it's open source so you can grab a copy of the source code yourself, review the code and also build it yourself. You need [Visual Studio 2013](http://www.visualstudio.com/products/visual-studio-community-vs) with NuGet Package Manager installed (should be by default) and [WiX toolset](http://wixtoolset.org/).

**Q:** Will you charge me for using the FanFlow?

**A:** No it is free of charge, forever.

**Q:** If anything goes wrong how can I report a bug?

**A:** Fill out [the new issue form](https://github.com/mareksuscak/FanFlow/issues/new) with as much details as you can provide and always provide a log file that can be found at `C:\Program Files (x86)\FanFlow\logs\logfile.txt` or `C:\Program Files\FanFlow\logs\logfile.txt` on 32bit and 64bit Windows respectively.

License
=======

The MIT License (MIT)

Copyright (c) 2015 Marek Suscak

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.

