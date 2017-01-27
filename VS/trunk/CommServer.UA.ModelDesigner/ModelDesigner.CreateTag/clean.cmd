echo off
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
rem all cleanup should be performed in the following directories:
rem EX01-OPCFoundation_NETApi
rem PR21-CommServer
rem PR24-Biblioteka

rem//  $LastChangedDate: 2009-10-26 18:28:58 +0100 (Pn, 26 paź 2009) $
rem//  $Rev: 4069 $
rem//  $LastChangedBy: mzbrzezny $
rem//  $URL: svn://svnserver.hq.cas.com.pl/VS/trunk/PR38-OPCUAViewer/Scripts/clean.cmd $
rem//  $Id: clean.cmd 4069 2009-10-26 17:28:58Z mzbrzezny $

echo "$URL: svn://svnserver.hq.cas.com.pl/VS/trunk/PR38-OPCUAViewer/Scripts/clean.cmd $"

cd ..\..\
RD /S /Q .\PR38-OPCUAViewer\Common\Controls\obj
RD /S /Q .\PR38-OPCUAViewer\Common\Controls\bin
RD /S /Q .\PR38-OPCUAViewer\OPCUAViewer\Client\bin
RD /S /Q .\PR38-OPCUAViewer\OPCUAViewer\Client\obj
RD /S /Q .\PR38-OPCUAViewer\OPCUAViewer\Controls\bin
RD /S /Q .\PR38-OPCUAViewer\OPCUAViewer\Controls\obj
RD /S /Q .\PR38-OPCUAViewer\OpcUaViewerSetup\Debug
RD /S /Q .\PR38-OPCUAViewer\OpcUaViewerSetup\Release

rem deleting project user files
del /F /S /Q /A:H .\PR38-OPCUAViewer\*.suo
del /F /S /Q /A:H .\PR38-OPCUAViewer\*.user
rem deleting objects
del /F /S /Q  .\PR38-OPCUAViewer\*.obj
rem deleting intellisence
del /F /S /Q  .\PR38-OPCUAViewer\*.ncb
rem deleting debuger informations
del /F /S /Q  .\PR38-OPCUAViewer\*.pdb
rem deletind desktop.ini
del /F /S /Q /A:H .\PR38-OPCUAViewer\*.ini

if /I "%1" NEQ "local" (
echo cleanup
echo $URL: svn://svnserver.hq.cas.com.pl/VS/trunk/PR38-OPCUAViewer/Scripts/clean.cmd $
cd .\PR24-Biblioteka\Scripts
call clean.cmd 
cd ..\..
)