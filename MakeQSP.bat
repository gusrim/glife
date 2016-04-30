@ECHO off

:: Set those lines to fit your setup. 
:: This is where glife.qsp will be copied. If you don't want to move it just comment (::) the line below.
set CP_TO=..\GL_ECV

:: The file that will be generated or open
set QSPFILE=glife.qsp

:: This is the program used to open glife.qsp. If you comment this line windows will launch the default app to open glife.qsp
set QSPGUI=..\QSP\qspgui.exe
set QGEN=..\QSP\QGen5\QGen.exe
::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::


:menu
cls
echo.

if defined NOT_FOUND ( echo ERROR: Option '%action%' wasn't recognized. Is it lowercase\? ) ELSE ( echo. )
set NOT_FOUND=

echo.
echo -- QSP Compiler and Launcher --
echo.
echo (B)uild  (R)un  (F)ull  (Q)Gen  (E)xit
echo.
set /p action=Choose an action:

if %action% == b goto build
if %action% == r goto run
if %action% == f goto build
if %action% == q goto qgen
if %action% == e goto exit
set NOT_FOUND=1
goto menu

:build
echo.
echo Building ...

@ECHO ON
python -3 txtmerge.py locations glife.txt
txt2gam.exe glife.txt %QSPFILE% > nul
@ECHO OFF

echo.
if defined CP_TO (echo Copying %QSPFILE% to "%CP_TO%" ... & copy %QSPFILE% %CP_TO% )

echo.
echo Done.
if %action% == f goto run 
pause
goto menu

:qgen
echo.
echo Running ...
if defined CP_TO (start %QGEN% %CP_TO%\%QSPFILE% ) else (start %QGEN% %QSPFILE% )
goto exit

:run
echo.
echo Running ...

if defined CP_TO (start %QSPGUI% %CP_TO%\%QSPFILE% ) else (start %QSPGUI% %QSPFILE% )

:exit