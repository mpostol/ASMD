rem//  $LastChangedDate: 2009-10-20 09:51:31 +0200 (Wt, 20 paź 2009) $
rem//  $Rev: 4007 $
rem//  $LastChangedBy: mzbrzezny $
rem//  $URL: svn://svnserver.hq.cas.com.pl/VS/trunk/PR26-DataPorter/Scripts/build.cmd $
rem//  $Id: build.cmd 4007 2009-10-20 07:51:31Z mzbrzezny $

set buildtype=%1
if "%buildtype%"=="" goto setbuildtype

:dothejob
cd ..
"%Windir%\Microsoft.NET\Framework\v3.5\msbuild"  .\OPCUAViewer.sln /t:build /p:Configuration=%buildtype%
cd .\Scripts
goto exit

:setbuildtype
set buildtype=Release
goto dothejob

:exit
rem call SignInstall.cmd
