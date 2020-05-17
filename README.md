
# Address Space Model Designer (ASMD)

![Logo](_media/ASMDLogo-48.png)

- [Address Space Model Designer (ASMD)](#address-space-model-designer-asmd)
  - [Preface](#preface)
  - [Releases](#releases)
  - [Key Features](#key-features)
  - [Getting Started](#getting-started)
    - [NuGet packages](#nuget-packages)
    - [Ho to Install](#ho-to-install)
    - [How to build and run the unit tests in Visual Studio on Windows](#how-to-build-and-run-the-unit-tests-in-visual-studio-on-windows)
    - [How to open an example](#how-to-open-an-example)
  - [Related work](#related-work)
    - [Object Oriented Internet](#object-oriented-internet)
    - [CommServer](#commserver)
    - [Object Oriented Internet Reactive Networking Configuration Editor](#object-oriented-internet-reactive-networking-configuration-editor)
  - [See Also](#see-also)

## Preface

OPC Unified Architecture (OPC UA) is the next generation of OPC. One of the most important improvements in OPC UA is a powerful Address Space and Information Model concepts. OPC UA allows for the presentation of a real-time process and underlying infrastructure as a consistent information model built up with nodes. The process model is represented by nodes, attributes, and their mutual relationships. Therefore, this powerful concept allows us to present in OPC UA not only raw process data but also complete information about the process state and process environment. The flexibility of UA ensures that no existing or future system is too complex to be exposed via OPC UA. Of course, such flexibility leads to difficulties during configuration, that’s why the Address Space Model Designer (ASMD) design environment has been born.

The  OOI - OPC UA Address Space Model Designer supports the graphical design of the process model using **OPC UA Information and Address Space** concepts. The embedded model compiler may be used to generate all required file formats necessary to deploy custom models using any existing Software Development Kit. It is compliant with the OPC UA Specifications [OPC UA Part 3][Opc.UA.Part3] and [OPC UA Part 5][Opc.UA.Part5] and is a consistent part of the broader concept [Object-Oriented Internet](https://commsvr.gitbook.io/ooi/).

> **NOTE**:
>
>- The design, development and deployment of the OPC UA Information Model detailed description is covered by the document [Information Models Development][IMD].
>- The help documentation is now available at [OPC UA Address Space Model Designer Online Help][github.MD]

## Releases

The ASMD was written by CAS Lodz Poland. I am the founder and Executive Director of CAS. Now CAS is just an individual business activity conducted by me, so I decided to move this software to Open Source.

We use [Semantic Versioning][SV] for versioning. For the versions available, see the [releases on this repository][REL]. For your convenience, the versions of the repository, tools and NuGet packages has been listed in the next subsections.

| Version | Milestone                                                          | Date|Notes|
|:-------:|--------------------------------------------------------------------|:--:|-|
| 4.1 | [Public release of the ASMD][ASMD410] |  Dec 17, 2019 ||
| 3.20.1| [ASMD last available Windows installation released by CAS]| May 17, 2016|deprecated|

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

### NuGet packages

The list of packages used is listed on the page [Dependency graph][DEPGraph] of this repository. All packages are included in this GitHub repository in the local folder `_nugets` or published on NuGet. The local folder is configured in the `NuGet.Config`. The NuGet Gallery is the public package repository used by all package authors and consumers. All required packages are loaded before the build.

To get more visit the Microsoft documentation [How to reinstall and update packages][NUGETInstall].

### Ho to Install

Download and run the file `UA.ModelDesigner.exe` to unzip the content to the selected folder and create an icon on the desktop. The application will run after unpacking. To restart the application you may use the icon on the desktop or double click the application file `OOI.UA.ModelDesigner.exe` in the already selected target folder.

### How to build and run the unit tests in Visual Studio on Windows

Projects can be opened in Visual Studio 2017. Support for some projects depends on the Visual Studio edition and installed components.

1. Open the `CommServer.UA.ModelDesigner.sln` solution file using Visual Studio 2017.
1. Hit `F6` to build all projects in the solution.
1. Set the `ModelDesigner.DesignStudio` as the Start-up Project
1. Press `F5` to run the tool using Debug configuration
1. Hit `Ctrl+r,Ctrl+a` to run all unit tests

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

## Related work

### Object Oriented Internet

In this umbrella project, C\# deliverables supporting a new Machine To Machine \(M2M\) communication approach based on the **Data-Oriented Architecture** (DOA) paradigm is to be researched. The goal is to provide a generic solution for publishing and updating information in a context that can be used to describe and discover it by software applications. It is implemented based on the

- [OPC Unified Architecture](http://goo.gl/y4EHUn) - an industrial integration standard that fulfills the proposed architecture requirements.
- Object-Oriented Programming - well know and widely accepted programming language model in which data processing is organized around 4 major principles, namely encapsulation, abstraction, polymorphism and inheritance.

The GitHub [Object Oriented Internet][OOI] repository is aimed at the maintenance of this project. The ASMD contributes to this project and is compliant with the OOI concept.

### CommServer

[CommServer][commserver] is a package of software to manage data transfer using OPC standards. Built-in technologies and algorithms support Machine to Machine (M2M) meaningful interoperability. The [CommServer][commserver] was written by CAS Lodz Poland.

The GitHub repository [commsvr-com/migration2os][migration2os] is aimed at the `CommServer` software migration from on-premise subversion repository to GitHub and publishing it as the Open-Source Software (OSS). The members of the `CommServer` family are to be converged with the Object-Oriented Internet paradigms and integrated with the solutions maintained in this repository.

The project [CommServer Migration to Open-source][migration2osProj] will be used to coordinate the migration process of transferring multi-parts software from an on-premise subversion repository to a set of GitHub repositories.

### Object Oriented Internet Reactive Networking Configuration Editor

OPC-UA-OOI.ConfigEditor is a package of software to manage the configuration of the [Reactive Communication][OOIBookToC].  The `OPC-UA-OOI.ConfigEditor` was written by CAS Lodz Poland. The [mpostol/OPC-UA-OOI.ConfigEditor][ConfigEditor] repository is aimed at the software migration from on-premise subversion repository to GitHub and publishing it as the Open-Source Software (OSS).  After migration, this repository will be used to manage all activities addressing the software maintenance process as a plug-in of the ASMD.

[Mariusz Postol](https://mpostol.wordpress.com/about/)

[![View my profile on LinkedIn](https://www.linkedin.com/img/webpromo/btn_viewmy_160x33.png "View my profile on LinkedIn")](https://pl.linkedin.com/in/mpostol)

- [mpostol (at) cas.eu](https://cas.eu/index.php/contact)
- [GitHub profile](https://github.com/mpostol)
- [http://www.commsvr.com/](http://www.commsvr.com/)
- [LinkedIn](https://linkedin.com/in/mpostol)
- [twitter](https://twitter.com/mpostol)

## See Also

- [OPC UA Address Space Model Designer Help][github.MD]
- [WIKI - Help Documentation][WIKI]
- [Mariusz Postol. Address Space and Address Space Model](https://commsvr.gitbook.io/ooi/semantic-data-processing/addressspaceaddressspacemodel)
- [OPC UA Address Space Model Designer][CAS.ASMD]
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
- [Open XML SDK 2.5 for Microsoft Office; GitHub repository OfficeDev/Open-XML-SDK][OPENXML]
- [How to reinstall and update packages][NUGETInstall].
- [Dependency graph][DEPGraph]
- [OPCFoundation/UA-ModelCompiler][OPC.UA.ModelCompiler]
- [OPC UA Information Model - How to Create Instances using ASMD; Video][CAS.VideoInstances]
- [OPC UA Information Model - How to build the model; Video][CAS.VideBuild]
- [Introduction to OPC UA Address Space modeling using CAS Address Space Model Designer; Video][CAS.MZASMDIntro]
- [OOI - OPC UA Address Space Model Designer V 4.1][ASMD410]

[CAS.MZASMDIntro]:https://www.youtube.com/watch?v=pYOQA4atlRI&feature=youtu.be
[OPC.UA.ModelCompiler]:https://github.com/OPCFoundation/UA-ModelCompiler
[WIKI]:https://github.com/mpostol/ASMD/wiki
[NUGETInstall]:https://docs.microsoft.com/en-us/nuget/consume-packages/reinstalling-and-updating-packages
[SV]:http://semver.org/
[OPC.UA.Part5]:https://opcfoundation.org/developer-tools/specifications-unified-architecture/part-5-information-model/
[Opc.UA.Part3]:https://opcfoundation.org/developer-tools/specifications-unified-architecture/part-3-address-space-model/
[Opc.UA.Part6]:https://opcfoundation.org/developer-tools/specifications-unified-architecture/part-6-mappings/
[REL]: https://github.com/mpostol/ASMD/releases
[boiler]: https://commsvr.gitbook.io/ooi/reactive-communication/referenceapplication/simulator.boiler#informal-model-of-boiler
[ADI]: https://commsvr.gitbook.io/ooi/semantic-data-processing/informationmodelsdevelopment/companionspecificationinformationmodelfforanalyzers
[IMD]: https://commsvr.gitbook.io/ooi/semantic-data-processing/informationmodelsdevelopment
[ADI]:https://opcfoundation.org/developer-tools/specifications-opc-ua-information-models/opc-unified-architecture-for-analyzer-devices-adi/
[CAS.ASMD]:https://commsvr-com.github.io/Documentation/ModelDesigner
[OPENXML]:https://github.com/OfficeDev/Open-XML-SDK
[DEPGraph]:https://github.com/mpostol/ASMD/network/dependencies
[CAS.VideoInstances]:https://youtu.be/LvGHl-hRwZw
[CAS.VideBuild]:https://youtu.be/y3tndTA7YYo
[commserver]: http://www.commsvr.com/
[migration2os]: https://github.com/commsvr-com/migration2os
[migration2osProj]: https://github.com/orgs/commsvr-com/projects
[OOIBookToC]: https://commsvr.gitbook.io/ooi/TableOfContent.md#reactive-communication
[ConfigEditor]: https://github.com/mpostol/OPC-UA-OOI.ConfigEditor
[OOI]: https://github.com/mpostol/OPC-UA-OOI
[ASMD410]:https://github.com/mpostol/ASMD/releases/tag/4.1.0
[github.MD]:https://commsvr-com.github.io/Documentation/ModelDesigner
