VSorMonoDevelop
===============


Decides whether a .sln file should be opened with Xamarin Studio or Visual Studio based on its contents, then opens with the chosen ide.

I was too lazy to chose either xamarin studio or visual studio each time I opened a solution file, so I wrote and app for that.


Instructions
-------
1. Download and extract build from [here](http://matthewoneill.com/uploads/VSorMonoDevelop.zip "download link"), or clone this repo and build yourself
2. Modify the .config file to point to the path to your installations of vs and monoDevelop using provided values as a guide
3. Right click on a .sln file and tell windows to 'open with...' the path to VSorMonoDevelop.exe
4. Double click .sln and it will open with the correct ide