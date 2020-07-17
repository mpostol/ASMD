# Object-Oriented Internet Address Space Model Designer - Release Notes

## Table of Contents

- [Object-Oriented Internet Address Space Model Designer - Release Notes](#object-oriented-internet-address-space-model-designer---release-notes)
	- [Table of Contents](#table-of-contents)
	- [Current release details](#current-release-details)
	- [Versions history](#versions-history)
		- [Version: 4.2.1](#version-421)
		- [Version: 4.2.0](#version-420)
		- [Version: 4.1.0](#version-410)
			- [Release Date: 17 Dec 2019](#release-date-17-dec-2019)
			- [Known issues](#known-issues)
		- [Version: 3.20.1](#version-3201)
			- [Release Date: 2016-05-17](#release-date-2016-05-17)
		- [Version 3.10](#version-310)
			- [Release Date: 2015-03-31](#release-date-2015-03-31)
		- [Version 3.00.10](#version-30010)
			- [Release Date: 2015-02-11](#release-date-2015-02-11)
		- [Version 3.00.03](#version-30003)
			- [Release Date: 2014.07.07](#release-date-20140707)
		- [Version 3.00.02](#version-30002)
			- [Release Date: 2011.05.19](#release-date-20110519)

## Current release details

 | Title        | Description                                                                                    |
 | ------------ | ---------------------------------------------------------------------------------------------- |
 | Product      | [Object-Oriented Internet Address Space Model Designer](https://github.com/mpostol/OPC-UA-OOI) |
 | Version      | 4.3.0                                                                                          |
 | Release Date | 17.06.2020                                                                                     |

The main changes and new functionality are listed below:

- Bug-fix release - see the issues list for details

## Versions history

### Version: 4.2.1

 | Title        | Description                                                                                    |
 | ------------ | ---------------------------------------------------------------------------------------------- |
 | Product      | [Object-Oriented Internet Address Space Model Designer](https://github.com/mpostol/OPC-UA-OOI) |
 | Version      | 4.2.1                                                                                          |
 | Release Date | 29.05.2020                                                                                     |

The main changes and new functionality are listed below:

- Hot-fix - see the issues list for details

### Version: 4.2.0

| Title        | Description                                                                                    |
| ------------ | ---------------------------------------------------------------------------------------------- |
| Product      | [Object-Oriented Internet Address Space Model Designer](https://github.com/mpostol/OPC-UA-OOI) |
| Version      | 4.2.0                                                                                          |
| Release Date | 17.05.2020                                                                                     |

The main changes and new functionality are listed below:

- it is a maintenance release
- fixed broken links to www.commsvr.com - the documentation has been published on GitHub in [a separate repository](https://github.com/commsvr-com/Documentation).
- fixed reported problems - check out the commits list to get details
- removed dependency on the Open XML SDK 2.5 for Microsoft Office - this functionality is provided by the appropriate NuGet package instead.
- updated dependencies

### Version: 4.1.0

#### Release Date: 17 Dec 2019

The main changes and new functionality are listed below:

- Refactoring application architecture to use dependency validation and separate libraries from dependency on `Windows.Forms` technology.
- Added a new version of the Model Compiler 1.01.335.1 as the application add-on.
- Updated ModelDesign schema and OPC UA Defined Types up to Model Compiler 1.11.335.1
- Improved tracking of the application activity
- Added the new version of the CAS OPC Viewer 3.11.17

#### Known issues

- The self-extracting zip file and the main application is not code-signed. Unsigned executables maybe not allowed by your company IT policy. The installer package containing signed stuff is on the project road map #89., The further development planning is based on the sponsors' priorities. Any comments and proposals add as the comments to #89.
- Property grid fonts scaling. Visit #86 to get more. Try the [workaround](https://github.com/mpostol/ASMD/issues/86#issuecomment-578040136)

### Version: 3.20.1

#### Release Date: 2016-05-17

The main changes and new functionality are listed below:

- The application supports the OPC UA Object Oriented Internet paradigm. Its detailed description is available on-line: [OPC-UA-OOI](https://github.com/mpostol/OPC-UA-OOI). To improve adaptability, the application uses open source components available in the mentioned project work space.
- Import of the XML documents compliant with the `UANodeSet` XML schema uses the deliverable developed and maintained in the public domain. See detailed description: [Address Space Prototyping Tool (asp.exe)](https://commsvr.gitbook.io/ooi/semantic-data-processing/addressspacecompliancetesttool)
- Embedded OPC UA application configuration editor supports any external plug-in prepared on the basis of the Nuget package: https://www.nuget.org/packages/UAOOI.DataBindings/. The package code is available as an open source at: [DataBindings](https://www.nuget.org/packages/UAOOI.DataBindings/).
- Updated code for target .NET Framework 4.6.1. and the recent development environment.
- Added unit tests and fixed reported errors.

### Version 3.10

#### Release Date: 2015-03-31

- Import support for XML documents compliant with the `UANodeSet` XML Schema.

Each OPC UA Server interchanges data with OPC UA Clients engaging the Address Space concept. Address 
Space instantiated by a server allows publication of the underlying process data in a standard way 
as a collection of nodes created according to the strictly observed rules. To instantiate the Address 
Space any reusable OPC UA Server needs a description of it. The OPC UA standard defines a formal 
definition of the syntax `UANodeSet` XML Schema. The semantics of a compliant with this schema XML 
document is explained in this manual : [Address Space Interchange XML](http://www.cas.internetdsl.pl/commserver/P_DowloadCenter/P_Publications/P-15010101-AddressSpaceInterchangeXML.pdf)

### Version 3.00.10

#### Release Date: 2015-02-11

The main changes and new functionality are listed below:

- Build-in model is compliant with Rel 1.02 Specification
- Build-in Model Compiler is compliant with the Model Compiler Rel. 1.02.26 included in the OPC Foundation SDK Rel. 1.02.334.6
- Embedded compiler validates the model during creation of the Browse view.
  - errors are logged to the Output window and log file
  - errors are added as nodes to the browse view to be easily recognizable
 Improved application instrumentation and by expanding events tracing to the log file.
- Added Analyzer Device Integration (ADI) model
- Synchronized example models with the White-paper: [OPC UA Information Model Deployment](http://www.commsvr.com/DownloadCenter/Publications/OPCUAInformationModelDeployment/tabid/563/language/en-US/Default.aspx)

### Version 3.00.03

#### Release Date: 2014.07.07

- Ported to the VS 2013 - refactoring

### Version 3.00.02

#### Release Date: 2011.05.19

This is only bug-fix release. The main changes and new functionality are listed below:

- Resolved issue with license installation ("wrong hardware key");
- Resolved issue with displaying information about license failure;
- Links to documentation are fixed.
