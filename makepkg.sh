#!/bin/sh

rm -rf release
mkdir release&&mkdir release/rpncalc

cp rpncalc/bin/Release/rpncalc.exe rpncalc/bin/Release/complex.dll README README.ja License release/rpncalc
cd release
7z a -mx=9 rpncalc.zip rpncalc
