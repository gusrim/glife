:: if you dont want to copy the glife.qsp anywhere just comment out (::) the cp glife.qsp ..\GL_ECV

python -3 txtmerge.py locations glife.txt
txt2gam.exe glife.txt glife.qsp
cp glife.qsp ..\GL_ECV
..\QSP\qspgui.exe ..\GL_ECV\glife.qsp