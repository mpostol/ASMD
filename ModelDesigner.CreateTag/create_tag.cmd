rem//  $LastChangedDate: 2009-10-28 16:42:05 +0100 (Śr, 28 paź 2009) $
rem//  $Rev: 4145 $
rem//  $LastChangedBy: mzbrzezny $
rem//  $URL: svn://svnserver.hq.cas.com.pl/VS/trunk/PR26-DataPorter/Scripts/create_tag.cmd $
rem//  $Id: create_tag.cmd 4145 2009-10-28 15:42:05Z mzbrzezny $
if "%1%"=="" goto ERROR

svn mkdir svn://svnserver.hq.cas.com.pl/VS/tags/OPCUAViewer/%1  -m "created new tag  %1 (release folder)"
svn copy svn://svnserver.hq.cas.com.pl/VS/trunk/PR24-Biblioteka svn://svnserver.hq.cas.com.pl/VS/tags/OPCUAViewer/%1/PR24-Biblioteka -m "created new tag %1 (project PR24-Biblioteka)"
svn copy svn://svnserver.hq.cas.com.pl/VS/trunk/CommonBinaries svn://svnserver.hq.cas.com.pl/VS/tags/OPCUAViewer/%1/CommonBinaries -m "created new tag %1 (project CommonBinaries)"
svn copy svn://svnserver.hq.cas.com.pl/VS/trunk/ImageLibrary svn://svnserver.hq.cas.com.pl/VS/tags/OPCUAViewer/%1/ImageLibrary -m "created new tag %1 (project ImageLibrary)"
svn copy svn://svnserver.hq.cas.com.pl/VS/trunk/PR38-OPCUAViewer svn://svnserver.hq.cas.com.pl/VS/tags/OPCUAViewer/%1/PR38-OPCUAViewer -m "created new tag %1 (project PR38-OPCUAViewer)"

goto EXIT
:ERROR
echo Parametr must be set
:EXIT
