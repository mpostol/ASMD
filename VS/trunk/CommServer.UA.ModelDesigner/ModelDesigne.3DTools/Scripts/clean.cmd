echo off
rem//  $LastChangedDate$
rem//  $Rev$
rem//  $LastChangedBy$
rem//  $URL$
rem//  $Id$


rem DEL [/P] [/F] [/S] [/Q] [/A[[:]attributes]] names
rem   names         Specifies a list of one or more files or directories.
rem                 Wildcards may be used to delete multiple files. If a
rem                 directory is specified, all files within the directory
rem                 will be deleted.
rem 
rem   /P            Prompts for confirmation before deleting each file.
rem   /F            Force deleting of read-only files.
rem   /S            Delete specified files from all subdirectories.
rem   /Q            Quiet mode, do not ask if ok to delete on global wildcard
rem   /A            Selects files to delete based on attributes
rem   attributes    R  Read-only files            S  System files
rem                 H  Hidden files               A  Files ready for archiving
rem                 -  Prefix meaning not
REM RMDIR [/S] [/Q] [drive:]path
REM RD [/S] [/Q] [drive:]path

REM     /S      Removes all directories and files in the specified directory
REM             in addition to the directory itself.  Used to remove a directory
REM             tree.

REM     /Q      Quiet mode, do not ask if ok to remove a directory tree with /S


echo "$URL$"
cd ..\..\

if "%1"=="local" goto LOCAL
del /Q  .\CommonBinaries\EX03-3DTools\*.*
:LOCAL

RD /S /Q ".\EX03-3DTools\3DTools\bin"
RD /S /Q ".\EX03-3DTools\3DTools\obj" 


rem deleting project user files
del /F /S /Q /A:H .\EX03-3DTools\*.suo
del /F /S /Q /A:H .\EX03-3DTools\*.user
rem deleting objects
del /F /S /Q  .\EX03-3DTools\*.obj
rem deleting intellisence
del /F /S /Q  .\EX03-3DTools\*.ncb
rem deleting debuger informations
del /F /S /Q  .\EX03-3DTools\*.pdb
rem deletind desktop.ini
del /F /S /Q /A:H .\EX03-3DTools\*.ini

rem returning to base directory
cd .\EX03-3DTools\Scripts