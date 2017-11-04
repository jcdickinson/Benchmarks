@echo off
SET AppDir=%CD%\bin\Release\netcoreapp2.0\win10-x64\
SET CoreClrDir=C:\dev\coreclr\bin\Product\Windows_NT.x64.Debug
SET OCD=%CD%

dotnet publish -c Release > NUL
robocopy /e %CoreClrDir% %AppDir%\publish > NUL

SET CORE_ROOT=%CoreClrDir%
SET CORE_LIBRARIES=%AppDir%publish\
SET SAVESTAMP=%DATE:/=-%@%TIME::=-%
SET SAVESTAMP=%SAVESTAMP: =%
SET SAVESTAMP=%OCD%\%SAVESTAMP:,=.%.il

cd %AppDir%
rem set COMPLUS_JitDump=System.HashCode:Test
set COMPlus_JitDisasm=System.HashCode:*
%CoreClrDir%\corerun TestJit.dll > %SAVESTAMP%
code %SAVESTAMP%
