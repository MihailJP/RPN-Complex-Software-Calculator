#!/bin/sh

rm -rf release
mkdir release&&mkdir release/rpncalc

cp rpncalc/bin/Release/rpncalc.exe rpncalc/bin/Release/complex.dll README README.ja License release/rpncalc
cd release
chmod 755 rpncalc/rpncalc.exe
chmod 644 rpncalc/complex.dll
7z a -mx=9 rpncalc.zip rpncalc
