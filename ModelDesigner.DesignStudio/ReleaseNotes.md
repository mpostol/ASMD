
# Release Notes: CAS OPC UA Address Space Model Designer

## Current release details:

* Description:   OPC UA Information Model Design Studio.
* Company:       CAS
* Product:       CAS CommServer Family
* Trademark:     CommServer
* Version:       3.20.2
* Release Date:  2017-02-06

The main changes and new functionality are listed below:

- Added new version of the Model Compiler 1.01.335.1 as the application add-on.
- Updated ModelDesign schema and OPC UA Defined Types up to Model Compiler 1.01.335.1
- Improved tracing of the application activity
- Added new version of the CAS OPC Viewer 3.11.17

____________________________________________________________________________________________
> For assistance, contact:

> Mariusz Postol

> CAS

> mailto://mpostol@cas.eu

Copyright (C) 2017, commsvr.com LODZ POLAND

mailto://commserver@cas.eu

http://www.commsvr.com/


# Versions history:

## Version: 3.20.0 
### Release Date:  2016-01-13

The main changes and new functionality are listed below:

* The application supports the OPC UA Object Oriented Internet paradigm. Its detailed description is available on-line: [OPC-UA-OOI](https://github.com/mpostol/OPC-UA-OOI). To improve adaptability, the application uses open source components available in the mentioned project work space.
* Import of the XML documents compliant with the `UANodeSet` XML schema uses the deliverable developed and maintained in the public domain. See detailed description at: https://github.com/mpostol/OPC-UA-OOI/tree/master/SemanticDataSolution.
* Embedded OPC UA application configuration editor supports any external plug-in prepared on the basis of the Nuget package: https://www.nuget.org/packages/UAOOI.DataBindings/. 
    The package code is available as an open source at: [DataBindings](https://www.nuget.org/packages/UAOOI.DataBindings/).
* Updated code for target .NET Framework 4.6.1. and the recent development environment.
* Added unit tests and fixed reported errors.

## Version 3.10
### Release Date: 2015-03-31

* Import support for XML documents compliant with the `UANodeSet` XML Schema.

Each OPC UA Server interchanges data with OPC UA Clients engaging the Address Space concept. Address 
Space instantiated by a server allows publication of the underlying process data in a standard way 
as a collection of nodes created according to the strictly observed rules. To instantiate the Address 
Space any reusable OPC UA Server needs a description of it. The OPC UA standard defines a formal 
definition of the syntax `UANodeSet` XML Schema. The semantics of a compliant with this schema XML 
document is explained in this manual : [Address Space Interchange XML](http://www.cas.internetdsl.pl/commserver/P_DowloadCenter/P_Publications/P-15010101-AddressSpaceInterchangeXML.pdf)

## Version 3.00.10
### Release Date: 2015-02-11

The main changes and new functionality are listed below:

 - Build-in model is compliant with Rel 1.02 Specification
 - Build-in Model Compiler is compliant with the Model Compiler Rel. 1.02.26 included in the OPC Foundation SDK Rel. 1.02.334.6
 - Embedded compiler validates the model during creation of the Browse view.
	* errors are logged to the Output window and log file
	* errors are added as nodes to the browse view to be easily recognizable
 - Improved application instrumentation and by expanding events tracing to the log file.
 - Added Analyzer Device Integration (ADI) model
 - Synchronized example models with the White-paper: [OPC UA Information Model Deployment](http://www.commsvr.com/DownloadCenter/Publications/OPCUAInformationModelDeployment/tabid/563/language/en-US/Default.aspx)
 
## Version 3.00.03 
### Release Date: 2014.07.07

- Ported to the VS 2013 - refactoring 

## Version 3.00.02
### Release 2011.05.19

This is only bug-fix release. The main changes and new functionality are listed below:

- Resolved issue with license installation ("wrong hardware key");
- Resolved issue with displaying information about license failure;
- Links to documentation are fixed.

# Archival Information

For archival information visit the document [Version History](http://www.commsvr.com/OPC-Help/Index.aspx?topic=html/ada1af70-e1ba-49df-8d0a-8ddc87a0f287.htm)

