# _Leetspeak_

#### _C# Testting practice for Epicodus_, _Mar. 2, 2020_

#### By _**Michelle Morin, Zakkrey Short, Eric Settels**_

## Description

_This application translates a user input string into "Leetspeak", by:_
* _replacing every "e" with a "3"_
* _replacing every "t" with a "7"_
* _replacing every "o" with a "0"_
* _replacing every "I" (captial instances only) with a "1"_
* _replacing every "s" that is not the first character of a word with a "z"_

## Specifications:

| Specification | Example Input | Example Output |
| ------------- |:-------------:| -------------------:|
| The application replaces every "e" and "E" in a user input with a "3" | "hello" | "h3llo" |
| The application replaces every "t" and "T in a user input with a "7" | "hello" | "h3llo" |
| The application replaces every "e" in a user input with a "3" | "hello" | "h3llo" |
| The application replaces every "e" in a user input with a "3" | "hello" | "h3llo" |


| User enters a string into the console after being prompted and the program returns an array with each "o" replaced with a "0" | user enters hello | [h,3,l,l,0] is returned |
| User enters a string into the console after being prompted and the program returns an array with each "I" replaced with a "1" | user enters "I Do" | [1, ,D,0] is returned |
| User enters a string into the console after being prompted and the program returns an array with each "t" replaced with a "7" | user enters "Let's Do It" | [L,3,7,',s, ,D,0, ,1,7 ] is returned |
| User enters a string into the console after being prompted and the program returns an array with each "s" replaced with a "z" | user enters "Let's Do It" | [L,3,7,',z, ,D,0, ,1,7 ] is returned |
## Setup/Installation Requirements

### Install .NET Core

#### on macOS:
* _[Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer) to download a .NET Core SDK from Microsoft Corp._
* _Open the file (this will launch an installer which will walk you through installation steps. Use the default settings the installer suggests.)_

#### on Windows:
* _[Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.203-windows-x64-installer) to download the 64-bit .NET Core SDK from Microsoft Corp._
* _Open the .exe file and follow the steps provided by the installer for your OS._

#### Install dotnet script
_Enter the command ``dotnet tool install -g dotnet-script`` in Terminal (macOS) or PowerShell (Windows)._

### Clone this repository

_Enter the following commands in Terminal (macOS) or PowerShell (Windows):_
* ``cd desktop``
* ``git clone`` followed by the URL to this repository.
* ``cd`` followed by the repository name.

_Confirm that you have navigated to the correct directory (e.g., by entering the command_ ``pwd`` _in Terminal)._

_Run this console application by entering the following command in Terminal (macOS) or PowerShell (Windows):_
* ``dotnet run``

_To view/edit the source code of this application, open the contents of this directory in a text editor or IDE of your choice (e.g., to open all contents of the directory in Visual Studio Code on macOS, enter the command_ ``code .`` _in Terminal)._

## Technologies Used
* _Git_
* _C#_
* _.NET Core 2.2_
* _dotnet script_

### License

*This webpage is licensed under the MIT license.*

Copyright (c) 2020 **_Michelle Morin, Zakkrey Short, Eric Settels_**