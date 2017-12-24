# FolderLocker
This is a simple Visual Basic app that password protects a folder using only the internal workings of Windows. No sophisticated third-party software is required.

DEPENDENCIES -- RUNNING
In order to run this program "out of the box," you must be running Windows 10, but it will run on earlier versions of Windows with a little tweaking of the source code (see below for more information on developing). You must also have the .NET Framework 4.6.1 runtime (or any later version; the latest version at the time of this posting is 4.7.1), which is downloadable at https://www.microsoft.com/net/download/windows.

DEPENDENCIES -- DEVELOPING
Even if you don't have Windows 10, you may be able to adapt this app to work with your version of Windows, if you're running at least Windows 7 SP1. Simply download and install Visual Studio 2017 (at https://www.visualstudio.com); this will also install the .NET Framework development libraries as well as the appropriate Windows SDK for your operating system version. Then, download this repository and open the solution file, add support for your SDK to the solution. Finally, build and run your program.

HOW IT WORKS
The program will do one of three things upon execution:
1. It will create a folder named "Locker" in the current working directory (i.e. the directory where the executable is located; feel free to move the executable anywhere you wish). To override this, you can simply create the folder yourself and name it "Locker."
2. It will set the Hidden and System attributes on the folder, hiding them from view in the Windows (File) Explorer, in such a way that it will remain hidden from view even if you have Windows (File) Explorer set to "Show hidden files, folders, and drives."
3. It will ask for a password to unlock the folder and, if correct, will clear the Hidden and System attributes from the folder, so that it will be visible in Windows (File) Explorer.

ABOUT
The inspiration for this app came from Britec09 on YouTube -- specifically, this video (https://youtu.be/L3M435ZyUSw). The program (there's a link to the source code in the description) was originally written as an MS-DOS batch file (cool!), so I decided to adapt it as best I could into what was originally going to be a JavaScript program, until I found out that JavaScript doesn't manipulate Windows file systems.
I next decided to try VBScript. Using extensive Web searches, I was able to complete the source code as best I could, and was ready to put it through a validator. Unfortunately, there isn't really a freeware VBScript validator out there.
I then thought of Visual Studio 2017, since VBScript and Visual Studio are both Microsoft products. I downloaded and installed this, and opened my VBScript program in this, but without a Visual Studio solution associated with the VBScript, it didn't even bother trying to validate the script. It doesn't work with standalone script files.
Finally, I decided to turn it into a full-fledged Visual Basic app. Initially, I wasn't going to have the app use a form at all -- the whole program would be controlled by several MessageBoxes and one InputBox. Unfortunately, that's when I ran into a problem with the InputBox: You cannot mask input in an InputBox with any sort of password character.
So I finally decided to use a small form. My next problem was: How do I get the form window to show no icon? When I discovered this was not possible, I settled for setting the form's icon to the "Question" icon found in Windows dialog boxes. This, in turn, inspired me to add icons to all my MessageBoxes (which had the bonus effect of adding appropriate sounds!).
So it's true, developing computer programs in this day and age is no easy task. Yes, there are days when I, as a computer programmer, would do anything (short of selling my soul to the Devil) to have my old Apple //e again. But if I can get one thing to lead to another, the way I did when creating this app, I'm pretty sure anyone with half a brain can do the same, and create an app all his (or her!) own.

...AND THE FUTURE?
As of right now, this is a fairly complete app. But even minutes after finishing it, I realize there's still more I can do with the thing. Perhaps the number one thing on my priority list is to have the program ask the user to choose his or her own password with which to lock the folder, and store the chosen password in the app's properties.
I'm also thinking about possibly porting this app to macOS and Linux. For this, I would need the .NET Core, and would also have to make some modifications to the subroutines. In my experience with Linux as well as Windows, I can say with certainty that each OS takes a different approach to hiding files and folders. Plus, can you even set the System attribute on a file or folder in Linux? I have never tried to do so. Some research will be required on that front...

CONCLUSION
Well, that about wraps up the README.md file for this short project. Thanks to Britec09 for giving me the inspiration for this app. As for the rest of you, I hope you enjoy my app. Don't hesitate to let me know what you think -- if you have a problem with installing or running the app, please don't hesitate to file an Issue. Remember, this app is probably not in its final stage, so if you have some ideas as to how to improve the app, again, don't hesitate to let me know -- file an Issue!

That's about it. Thanks for reading -- have fun!
