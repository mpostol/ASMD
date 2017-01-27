rem//  $LastChangedDate: 2009-08-10 10:45:53 +0200 (Pn, 10 sie 2009) $
rem//  $Rev: 3492 $
rem//  $LastChangedBy: mzbrzezny $
rem//  $URL: svn://svnserver.hq.cas.com.pl/VS/trunk/PR33-CommServerUA/Scripts/create_branch.cmd $
rem//  $Id: create_branch.cmd 3492 2009-08-10 08:45:53Z mzbrzezny $

if "%1"=="" goto ERROR
set branchtype=%2
if "%branchtype%"=="" goto setbranch

:dothejob
svn mkdir svn://svnserver.hq.cas.com.pl/VS/%branchtype%/OPCUAViewer/%1  -m "created new %branchtype% %1 (%branchtype% folder)"
svn copy svn://svnserver.hq.cas.com.pl/VS/trunk/PR24-Biblioteka svn://svnserver.hq.cas.com.pl/VS/%branchtype%/OPCUAViewer/%1/PR24-Biblioteka -m "created new %branchtype% %1 (project PR24-Biblioteka)"
svn copy svn://svnserver.hq.cas.com.pl/VS/trunk/PR38-OPCUAViever svn://svnserver.hq.cas.com.pl/VS/%branchtype%/OPCUAViewer/%1/PR38-OPCUAViever -m "created new %branchtype% %1 (project PR38-OPCUAViever)"
svn copy svn://svnserver.hq.cas.com.pl/VS/trunk/ImageLibrary svn://svnserver.hq.cas.com.pl/VS/%branchtype%/OPCUAViewer/%1/ImageLibrary -m "created new %branchtype% %1 (project ImageLibrary)"
svn copy svn://svnserver.hq.cas.com.pl/VS/trunk/CommonBinaries svn://svnserver.hq.cas.com.pl/VS/%branchtype%/OPCUAViewer/%1/CommonBinaries -m "created new %branchtype% %1 (project CommonBinaries)"

goto EXIT

:setbranch
set branchtype=branches
goto dothejob
:ERROR
echo Parametr must be set
:EXIT
