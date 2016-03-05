@echo off
cls
del temp.exe
del temp.obj
masm temp.asm;
link temp.obj;
temp.exe
