rem//  $LastChangedDate$
rem//  $Rev$
rem//  $LastChangedBy$
rem//  $URL$
rem//  $Id$

if "%1"=="" goto ERROR
set branchtype=%2
if "%branchtype%"=="" goto setbranch

:dothejob
svn mkdir svn://svnserver.hq.cas.com.pl/VS/%branchtype%/UAModelDesigner/%1  -m "created new %branchtype%  %1 (%branchtype% folder)"
svn copy svn://svnserver.hq.cas.com.pl/VS/trunk/PR24-Biblioteka svn://svnserver.hq.cas.com.pl/VS/%branchtype%/UAModelDesigner/%1/PR24-Biblioteka -m "created new ASMD %branchtype% %1 (project PR24-Biblioteka)"
svn copy svn://svnserver.hq.cas.com.pl/VS/trunk/PR30-OPCViever svn://svnserver.hq.cas.com.pl/VS/%branchtype%/UAModelDesigner/%1/PR30-OPCViever -m "created new ASMD %branchtype% %1 (project PR30-OPCViever)"
svn copy svn://svnserver.hq.cas.com.pl/VS/trunk/PR32-ModelDesigner svn://svnserver.hq.cas.com.pl/VS/%branchtype%/UAModelDesigner/%1/PR32-ModelDesigner -m "created new ASMD %branchtype% %1 (project PR32-ModelDesigner)"
svn copy svn://svnserver.hq.cas.com.pl/VS/trunk/PR35-ASMD_Plugins svn://svnserver.hq.cas.com.pl/VS/%branchtype%/UAModelDesigner/%1/PR35-ASMD_Plugins -m "created new ASMD %branchtype% %1 (project PR35-ASMD_Plugins)"
svn copy svn://svnserver.hq.cas.com.pl/VS/trunk/ImageLibrary svn://svnserver.hq.cas.com.pl/VS/%branchtype%/UAModelDesigner/%1/ImageLibrary -m "created new ASMD %branchtype% %1 (project ImageLibrary)"
svn copy svn://svnserver.hq.cas.com.pl/VS/trunk/CommonBinaries svn://svnserver.hq.cas.com.pl/VS/%branchtype%/UAModelDesigner/%1/CommonBinaries -m "created new ASMD %branchtype% %1 (project CommonBinaries)"
svn copy svn://svnserver.hq.cas.com.pl/VS/trunk/EX01-OPCFoundation_NETApi svn://svnserver.hq.cas.com.pl/VS/%branchtype%/UAModelDesigner/%1/EX01-OPCFoundation_NETApi -m "created new ASMD %branchtype% %1 (project EX01-OPCFoundation_NETApi)"
svn copy svn://svnserver.hq.cas.com.pl/VS/trunk/EX02-MAML svn://svnserver.hq.cas.com.pl/VS/%branchtype%/UAModelDesigner/%1/EX02-MAML -m "created new ASMD %branchtype% %1 (project EX02-MAML)"
svn copy svn://svnserver.hq.cas.com.pl/VS/trunk/EX03-3DTools svn://svnserver.hq.cas.com.pl/VS/%branchtype%/UAModelDesigner/%1/EX03-3DTools -m "created new ASMD %branchtype% %1 (project EX03-3DTools)"
svn copy svn://svnserver.hq.cas.com.pl/VS/trunk/EX05-MeshDiagram3D svn://svnserver.hq.cas.com.pl/VS/%branchtype%/UAModelDesigner/%1/EX05-MeshDiagram3D -m "created new ASMD %branchtype% %1 (project EX05-MeshDiagram3D)"
svn copy svn://svnserver.hq.cas.com.pl/VS/trunk/PR39-CommonResources svn://svnserver.hq.cas.com.pl/VS/%branchtype%/UAModelDesigner/%1/PR39-CommonResources -m "created new ASMD %branchtype% %1 (project PR39-CommonResources)"

goto EXIT

:setbranch
set branchtype=branches
goto dothejob
:ERROR
echo Parametr must be set
:EXIT
