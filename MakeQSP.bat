@ECHO off

:: Set those lines to fit your setup. 
:: This is where glife.qsp will be copied. If you don't want to move it just comment (::) the line below.
set CP_TO=..\GL_ECV

:: This is the program used to open glife.qsp. If you comment this line windows will launch the default app to open glife.qsp
set QSPGUI=..\QSP\qspgui.exe

:menu
cls
echo.
echo -- QSP Compiler and Launcher --
echo.
echo (B)uild  (R)un  (F)ull  (Q)uit
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
txt2gam.exe glife.txt glife.qsp > nul
@ECHO OFF

echo.
if defined CP_TO (echo Copying glife.qsp to "%CP_TO%" ... & cp glife.qsp %CP_TO% )

echo.
echo Done.
if %action% == f goto run 
pause
goto menu

:run
echo.
echo Running ...

if defined CP_TO (start %QSPGUI% %CP_TO%\glife.qsp ) else (start %QSPGUI% glife.qsp )

:exit