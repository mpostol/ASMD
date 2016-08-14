rem//  $LastChangedDate$
rem//  $Rev$
rem//  $LastChangedBy$
rem//  $URL$
rem//  $Id$

if "%1"=="" goto ERROR

./create_branch %1 tags

goto EXIT
:ERROR
echo Parametr must be set
:EXIT
