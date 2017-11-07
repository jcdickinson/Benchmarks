@echo off
SET Methods=System.HashCode::Test_8
SET AppDir=%CD%\bin\Release\netcoreapp2.0\win10-x64\
SET CoreClrDir=C:\dev\coreclr\bin\Product\Windows_NT.x64.Debug
SET OCD=%CD%

dotnet publish -c Release
robocopy /e %CoreClrDir% %AppDir%\publish > NUL

SET CORE_ROOT=%CoreClrDir%
SET CORE_LIBRARIES=%AppDir%publish\
SET SAVESTAMP=%DATE:/=-%@%TIME::=-%
SET SAVESTAMP=%SAVESTAMP: =%

SET SAVEDisasm=%OCD%\%SAVESTAMP:,=.%.asm
SET SAVEDump=%OCD%\%SAVESTAMP:,=.%.jitdump

cd %AppDir%

SET COMPlus_JitDiffableDasm=1

SET COMPlus_JitDisasm=%Methods%
%CoreClrDir%\corerun TestJit.dll > %SAVEDisasm%
SET COMPlus_JitDisasm=

SET COMPLUS_JitDump=%Methods%
%CoreClrDir%\corerun TestJit.dll > %SAVEDump%
