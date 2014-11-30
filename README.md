VSorMonoDevelop
===============


Decides whether a .sln file should be opened with Xamarin Studio or Visual Studio based on its contents, then opens with the chosen ide.

I was too lazy to choose either xamarin studio or visual studio each time I opened a solution file, so I wrote an app for that.


Instructions
-------
1. Download and extract build from [here](http://matthewoneill.com/uploads/VSorMonoDevelop.zip "download link"), or clone this repo and build yourself
2. Modify the .config file to point to the path to your installations of Visual Studio and Mono Develop using the provided values as a guide
3. Right click on a .sln file and tell windows to 'open with...' the path to VSorMonoDevelop.exe and tick 'remember' or similar
4. In future just double click .sln and it will open with the correct ide
