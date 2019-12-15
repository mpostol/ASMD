# OPC UA Address Space Model Designer (ASMD)

OPC Unified Architecture (OPC UA) is the next generation of OPC. One of the most important improvements in OPC UA is a powerful Address Space and Information Model concepts. OPC UA allows for the presentation of a real-time process and underlying infrastructure as a consistent information model built up with nodes. The process model is represented by nodes, attributes, and their mutual relationships. Therefore, this powerful concept allows us to present in OPC UA not only raw process data but also complete information about the process state and process environment. The flexibility of UA ensures that no existing or future system is too complex to be exposed via OPC UA. Of course, such flexibility leads to difficulties during configuration, that’s why the Address Space Model Designer (ASMD) design environment has been born.

> **NOTE**: The design, development and deployment of the OPC UA Information Model detailed description is covered by the document [Information Models Development](https://commsvr.gitbook.io/ooi/semantic-data-processing/informationmodelsdevelopment).

## Releases

The ASMD was written by CAS Lodz Poland. I am the founder and Executive Director of CAS. Now CAS is just an individual business activity conducted by me, so I decided to move this software to Open Source.

We use [Semantic Versioning](http://semver.org/) for versioning. For the versions available, see the [releases on this repository](https://github.com/mpostol/ASMD/releases). For your convenience, the versions of the repository, tools and NuGet packages has been listed in the next subsections.

| Version | Milestone                                                          | DOI |Date|
|:-------:|--------------------------------------------------------------------|:---:|:--:|
| 4.0.0-Alpha | Initial pre-release | NA | Nov 12, 2019|
| 3.20.1| [ASMD last available Windows installation released by CAS](http://www.commsvr.com/COInstal/UAModelDesignerPro/setup.exe)|`NA`|May 17, 2016|

## Getting Started

This section describes prerequisites you need to compile the software and run tests.

### Open XML SDK

The following package must be installed on the development computer to build the solution

- [Open XML SDK 2.5 for Microsoft Office](https://www.microsoft.com/en-us/download/details.aspx?id=30425)

Open XML is an open ECMA 376 standard and is also approved as the ISO/IEC 29500 standard that defines a set of XML schemas for representing spreadsheets, charts, presentations, and word processing documents. Microsoft Office Word 2007, Excel 2007, PowerPoint 2007, and the later versions all use Open XML as the default file format.

### NuGet packages

The list of packages used is listed on the page [Dependency graph](https://github.com/mpostol/ASMD/network/dependencies) of this repository. All packages are included in this GitHub repository in the local folder `_nugets` or published on NuGet. The local folder is configured in the `NuGet.Config`. The NuGet Gallery is the public package repository used by all package authors and consumers. All required packages are loaded before the build.
To get more visit the Microsoft documentation [How to reinstall and update packages](https://docs.microsoft.com/en-us/nuget/consume-packages/reinstalling-and-updating-packages)

### Visual Studio

Projects can be opened in Visual Studio 2017. Support for some project depends on the Visual Studio edition and installed components.

## How to build and run the unit tests in Visual Studio on Windows

1. Open the `CommServer.UA.ModelDesigner.sln` solution file using Visual Studio 2017.
1. Hit `F6` to build all projects in the solution.
1. Set the `ModelDesigner.DesignStudio` as the Start-up Project
2. Press `F5` to run the tool using Debug configuration
5. Hit `Ctrl+r,Ctrl+a` to run all unit tests

## How to open an example



## See also
- [WIKI - Help Documentation](https://github.com/mpostol/ASMD/wiki)
- [Mariusz Postol. Address Space and Address Space Model](https://commsvr.gitbook.io/ooi/semantic-data-processing/addressspaceaddressspacemodel)
- [ASMD Re. 3.30.1 installation released by CAS](http://www.commsvr.com/COInstal/UAModelDesignerPro/setup.exe)
- [OPC UA Address Space Model Designer, 2019][CAS.ASMD]
- Wolfgang Mahnke, Stefan Helmut Leitner, Matthias Damm. OPC Unified Architecture. Berlin: Springer, 2009.
- [OPC Unified Architecture Specification Part 3: Address Space Model, OPC Foundation, Rel. 1.04, 2017-11-22][Opc.UA.Part3]
- [OPC Unified Architecture Specification Part 5: Information Model, OPC Foundation, Rel. 1.04, 2017-11-22][OPC.UA.Part5]

[OPC.UA.Part5]:https://opcfoundation.org/developer-tools/specifications-unified-architecture/part-5-information-model/
[Opc.UA.Part3]:https://opcfoundation.org/developer-tools/specifications-unified-architecture/part-3-address-space-model/
[CAS.ASMD]: http://www.commsvr.com/Products/OPCUA/UAModelDesigner.aspx
