@ECHO off

set CP_TO=..\GL_ECV
set QSPGUI=..\QSP\qspgui.exe

:menu
cls
echo.
echo -- QSP Compiler and Launcher --
echo.
echo (b)uild  (r)un  (f)ull  (q)uit
echo.
set /p action=Choose an action:

if %action% == b goto build
if %action% == r goto run
if %action% == f goto build
if %action% == q goto exit

:build
echo.
echo Building ...

@ECHO ON
python -3 txtmerge.py locations glife.txt
txt2gam.exe glife.txt glife.qsp
cp glife.qsp %CP_TO%
@ECHO OFF

echo.
echo Done.
if %action% == f goto run 
pause
goto menu

:run
echo.
echo Running ...

@ECHO ON
start %QSPGUI% %CP_TO%\glife.qsp
@ECHO OFF

:exit
pause