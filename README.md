# Dankov

## How to prepare environment for C\# development

- Generate Visual Studio files (By right click on root/Dankov/Dankov.uproject -> Generate Visual Studio project files)
- Navigate to [UnrealCLR](https://github.com/nxrighthere/UnrealCLR/) submodule folder and install using [UnrealCLR install instructions](https://github.com/nxrighthere/UnrealCLR#auto)
- Open Unreal and recompile
- Open Dankov.sln and add Dankov.Core as a project to it
- Recompile Dankov.Core

## How to debug C\# 

- Attach Visual studio to UE4Editor.exe (Managed .NET core, .NET5+)
- Place breakpoint in C\# code
- Start the scene in Unreal engine

## Useful links

https://github.com/nxrighthere/UnrealCLR/blob/master/MANUAL.md
