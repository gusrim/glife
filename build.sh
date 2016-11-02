#!/usr/bin/env bash

# Set those lines to fit your setup.
# This is where glife.qsp will be copied. If you don't want to move it just comment (#) the line below.
#DESTDIR=../GL_ECV

# The file that will be generated or open
QSPFILE=glife.qsp

#######################################################################

./txtmerge.py locations glife.txt
if [[ "$OSTYPE" == "linux-gnu" ]]; then
	./txt2gam.linux glife.txt "${QSPFILE}" 1> /dev/null
elif [[ "$OSTYPE" == "darwin"* ]]; then
	./txt2gam.mac glife.txt "${QSPFILE}" 1> /dev/null
elif [[ "$OSTYPE" == "msys" ]]; then
	./txt2gam.exe glife.txt "${QSPFILE}" 1> /dev/null
fi
if [ -d "${DESTDIR}" ]; then
	cp --reflink=auto "${QSPFILE}" "${DESTDIR}"
fi

