# OPC UA Address Space Model Designer (ASMD)

OPC Unified Architecture (OPC UA) is the next generation of OPC. One of the most important improvements in OPC UA is a powerful Address Space and Information Model concepts. OPC UA allows for the presentation of a real-time process and underlying infrastructure as a consistent information model built up with nodes. The process model is represented by nodes, attributes, and their mutual relationships. Therefore, this powerful concept allows us to present in OPC UA not only raw process data but also complete information about the process state and process environment. The flexibility of UA ensures that no existing or future system is too complex to be exposed via OPC UA. Of course, such flexibility leads to difficulties during configuration, that’s why the Address Space Model Designer (ASMD) design environment has been born.

The ASMD provides graphical design of the process model using OPC UA Information and Address Space concepts. The embedded model compiler may be used to generate all required file formats necessary to deploy custom model using any existing Software Development Kit. It is compliant with the OPC UA Specyfications listed in the `See Also` section.

> **NOTE**: The design, development and deployment of the OPC UA Information Model detailed description is covered by the document [Information Models Development][IMD].

## Releases

The ASMD was written by CAS Lodz Poland. I am the founder and Executive Director of CAS. Now CAS is just an individual business activity conducted by me, so I decided to move this software to Open Source.

We use [Semantic Versioning][SV] for versioning. For the versions available, see the [releases on this repository][REL]. For your convenience, the versions of the repository, tools and NuGet packages has been listed in the next subsections.

| Version | Milestone                                                          | DOI |Date|
|:-------:|--------------------------------------------------------------------|:---:|:--:|
| 4.0.0-Alpha | Initial pre-release | NA | Nov 12, 2019|
| 3.20.1| [ASMD last available Windows installation released by CAS][CAS.ASMD]|`NA`|May 17, 2016|

## Key Features

- graphical modeling of the OPC UA Information Model according to [OPC UA Part 5 specification][OPC.UA.Part5]
  - easy addition and deletion of nodes from the model structure
  - definition of nodes relationship (references) and types
  - modes filtering
  - search and find utility
  - type declaration, definition and inheritance analysis
  - state machine custom editor 
  - and more...
- graphical modeling of the OPC UA Address Space according to [OPC UA Part 3 specification][OPC.UA.Part3]
- 3D modeling of the Information Model
- the layered structure of the Information Model
- contextual OPC UA Standard help documentation - synchronization of the model with OPC UA ebook
- interoperability without programming
  - supports custom OPC UA Server/Client/PubSub configuration editor
  - supports definition and edition of the data bindings (leveraging machine to sensor connectivity) coupling the Address Space variables with the process (sensors, actuators, etc.) making an in-memory process replica
  - simple configuration of a custom OPC UA Server in context of the model design
  - no programming skills are required
- import and validation of any custom UANodeSet files to a new project
- import the address space from an **OPC DA server** (embedded OPC DA Viewer) and create a new OPC UA Information Model - an easier way to converge your old OPC Classic server and the Unified Architecture world
- documentation generation in MS Word and MAML formats
- generates OPC UA compliant UANodeSet XML File according to the [OPC UA Part 6 specification][OPC.UA.Part6]
- provides embedded [OPCFoundation/UA-ModelCompiler][OPC.UA.ModelCompiler] maintained by the OPC Foundation as the default model build tool
- output window provides detailed diagnostic information about the build model process
- works with any existing code generator
- full adherence to OPC Specifications
- considerably improves robustness of the OPC UA Information Model deployment in any custom environment
- any OPC UA SDK integration-ready (OPC UA SDK independent)

Check out the [WIKI - Help Documentation][WIKI] to get a more detailed description

## Getting Started

This section describes prerequisites to compile the software and run tests.

### Open XML SDK

The following package must be installed on the development computer to build the solution

- [Open XML SDK 2.5 for Microsoft Office][OPENXML]

Open XML is an open ECMA 376 standard and is also approved as the ISO/IEC 29500 standard that defines a set of XML schemas for representing spreadsheets, charts, presentations, and word processing documents. Microsoft Office Word 2007, Excel 2007, PowerPoint 2007, and the later versions all use Open XML as the default file format.

### NuGet packages

The list of packages used is listed on the page [Dependency graph][DEPGraph] of this repository. All packages are included in this GitHub repository in the local folder `_nugets` or published on NuGet. The local folder is configured in the `NuGet.Config`. The NuGet Gallery is the public package repository used by all package authors and consumers. All required packages are loaded before the build.
To get more visit the Microsoft documentation [How to reinstall and update packages][NUGETInstall].

### Visual Studio

Projects can be opened in Visual Studio 2017. Support for some projects depends on the Visual Studio edition and installed components.

## Ho to Guide

### How to build and run the unit tests in Visual Studio on Windows

1. Open the `CommServer.UA.ModelDesigner.sln` solution file using Visual Studio 2017.
1. Hit `F6` to build all projects in the solution.
1. Set the `ModelDesigner.DesignStudio` as the Start-up Project
2. Press `F5` to run the tool using Debug configuration
5. Hit `Ctrl+r,Ctrl+a` to run all unit tests

### How to open an example

This section contains information about the Address Space Model Designer sample solutions that illustrate the structure and techniques used for designing models and defining bindings between model nodes and real-time process data.

The section [Information Models Development][IMD] of the online ebook covers details on how to get started using the attached examples. The solution `BoilerExampleSolution` contains a boiler model. This model is described in the [ReferenceApplication Producer - Boilers Set Simulator][boiler]. Check out the section [Companion Specification - Information Model for Analyzers][ADI] to get more about `ADIExempleSolution` example.

Selected examples are also published on the [ASMD releases page][REL]. The following step by step, instruction will guide you on how to open the examples.

- From the [ASMD releases page][REL] download and unzip the file `ASMD.EmbeddedExample.zip` to the selected folder
- The folder `EmbeddedExample` contains two examples
  - `BoilerExampleSolution` - a set of unmanned boilers spread geographically, which have to be monitored and remotely controlled
  - `ADIExempleSolution` - a set of models to be used as an example of adopting companion standard models, i.e. [analyzer devices integration][ADI]
- Now you may run the ASMD application and open the selected solution

You can open the solution into ASMD in the following way:

1. Click on the main menu Open item
1. Select the directory containing the sample solution
1. Open the `BoilerExampleSolution.uamdsl` file
1. Click on the confirmation (Open) button

![How to open a Sample Solution](https://github.com/mpostol/ASMD/wiki/_Media/ToOpenSampleSolution.jpg)

The files of the sample solution are listed in the following table.

File | Content
|----|---------|
`*.uamdsl` |Address Space Model Designer solution. This file contains the configuration of the sample solution and references to other files that are used in this solution (e.g. projects, plug-ins, etc.)
`CAS.UA.Server.ServerConfiguration.dll` | A sample Plug-in file for CommServer UA that can be used to edit the configuration file and define process data bindings
`*.csv` | A CSV file that contains Node Identifiers
`*.xml` | An XML file that contains the model
`*/CAS.UAServer.DemoConfiguration.uasconfig` | A sample configuration file of CommServer UA. This file is created and edited by `CAS.UA.Server.ServerConfiguration.dll` - configuration editor.
`*/DefaultConfig.xml` |A sample CommServer configuration file. It can be edited by the Network Configuration application (part of CommServer package).
`*/DemoConfiguration.oses` |A sample OPC DA client configuration (compatible with `OPC Viewer` and `DataPorter` products)

## See Also

- [WIKI - Help Documentation][WIKI]
- [Mariusz Postol. Address Space and Address Space Model](https://commsvr.gitbook.io/ooi/semantic-data-processing/addressspaceaddressspacemodel)
- [ASMD Re. 3.30.1 installation released by CAS][CAS.ASMD]
- [OPC UA Address Space Model Designer, 2019][CAS.ASMD]
- Wolfgang Mahnke, Stefan Helmut Leitner, Matthias Damm. OPC Unified Architecture. Berlin: Springer, 2009.
- [OPC Unified Architecture Specification Part 3: Address Space Model, OPC Foundation, Rel. 1.04, 2017-11-22][Opc.UA.Part3]
- [OPC Unified Architecture Specification Part 5: Information Model, OPC Foundation, Rel. 1.04, 2017-11-22][OPC.UA.Part5]
- [OPC Unified Architecture Specification Part 6: Mappings, OPC Foundation, Rel. 1.04, 2017-11-22][OPC.UA.Part6]
- [ReferenceApplication Producer - Boilers Set Simulator][boiler]
- [Companion Specification - Information Model for Analyzers][ADI]
- [Information Models Development][IMD]
- [ASMD releases page][REL]
- [OPC 10020 - UA for Analyzer Devices (ADI), OPC Foundation Rel 1.1a, 2015][ADI]
- [Semantic Versioning][SV]
- [Open XML SDK 2.5 for Microsoft Office][OPENXML]
- [How to reinstall and update packages][NUGETInstall].
- [Dependency graph][DEPGraph]
- [OPCFoundation/UA-ModelCompiler][OPC.UA.ModelCompiler]
- [OPC UA Information Model - How to Create Instances using ASMD; Video][CAS.VideoInstances]
- [Introduction to OPC UA Address Space modeling using CAS Address Space Model Designer; Video][CAS.MZASMDIntro]

[CAS.MZASMDIntro]:https://www.youtube.com/watch?v=pYOQA4atlRI&feature=youtu.be
[OPC.UA.ModelCompiler]:https://github.com/OPCFoundation/UA-ModelCompiler
[WIKI]:https://github.com/mpostol/ASMD/wiki
[NUGETInstall]:https://docs.microsoft.com/en-us/nuget/consume-packages/reinstalling-and-updating-packages
[SV]:http://semver.org/
[OPC.UA.Part5]:https://opcfoundation.org/developer-tools/specifications-unified-architecture/part-5-information-model/
[Opc.UA.Part3]:https://opcfoundation.org/developer-tools/specifications-unified-architecture/part-3-address-space-model/
[Opc.UA.Part6]:https://opcfoundation.org/developer-tools/specifications-unified-architecture/part-6-mappings/
[CAS.ASMD]: http://www.commsvr.com/Products/OPCUA/UAModelDesigner.aspx
[REL]: https://github.com/mpostol/ASMD/releases
[boiler]: https://commsvr.gitbook.io/ooi/reactive-communication/referenceapplication/simulator.boiler#informal-model-of-boiler
[ADI]: https://commsvr.gitbook.io/ooi/semantic-data-processing/informationmodelsdevelopment/companionspecificationinformationmodelfforanalyzers
[IMD]: https://commsvr.gitbook.io/ooi/semantic-data-processing/informationmodelsdevelopment
[ADI]:https://opcfoundation.org/developer-tools/specifications-opc-ua-information-models/opc-unified-architecture-for-analyzer-devices-adi/
[CAS.ASMD]:http://www.commsvr.com/COInstal/UAModelDesignerPro/setup.exe
[OPENXML]:https://www.microsoft.com/en-us/download/details.aspx?id=30425
[DEPGraph]:https://github.com/mpostol/ASMD/network/dependencies
[CAS.VideoInstances]:https://youtu.be/LvGHl-hRwZw
