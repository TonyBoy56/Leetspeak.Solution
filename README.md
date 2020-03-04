# _Leetspeak_

#### _C# Testing practice for Epicodus_, _Mar. 2, 2020_

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
| The application replaces every "t" and "T in a user input with a "7" | "let go" | "l37 go" |
| The application replaces every "I" in a user input with a "1" | "I do" | "1 do" |
| The application replaces every "o" and "O" in a user input with a "0" | "Lets go" | "L37s g0" |
| The application replaces every "s" that is not the first character in a word of the user input with a "z" | "Lets do it" | "L37z d0 i7" |

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
