# Fiddler Logger

FiddlerLogger can be used to log the network calls from Fiddler using log4net.

![apm](https://img.shields.io/apm/l/vim-mode.svg)
[![Twitter URL](https://img.shields.io/twitter/url/http/shields.io.svg?style=social)](https://twitter.com/iAvinashVarma) [![Twitter Follow](https://img.shields.io/twitter/follow/iAvinashVarma.svg?style=social&label=Follow)](https://twitter.com/iAvinashVarma)
![GitHub followers](https://img.shields.io/github/followers/iAvinashVarma.svg?style=flat-square&label=Follow)

## How to build and deploy

* Copy %LocalAppData%\Programs\Fiddler\Fiddler.exe to ~\ExternalLibs folder.
* Go to Visual Studio > Tools > Options > NuGet Package Manager.
  * Package Restore > Check 'Allow NuGet to download missing packages' and 'Automatically check for missing packages during build in Visual Studio'.
  * Package Management > Set Packages.config as Default package management format and check 'Allow format selection on first package install'.
* Ensure that the Fiddler is not running. 
* Build the project to auto copy the relevant DLLs to %LocalAppData%\Programs\Fiddler\Scripts\

## Supported Fiddler Version

> Greater than Fiddler4 (.NET Framework 4.6.1)

## IDE

> Visual Studio 2017

## .NET Framework Version

> v4.6.1