# OOI Address Space Model Designer (OOI ASMD) ![Logo](https://mpostol.github.io/ASMD/_media/ASMDLogo-48.png) <!-- omit in toc -->

## Table of Content  <!-- omit in toc -->

- [Preface](#preface)
- [Releases](#releases)
- [Key Features](#key-features)
- [Getting Started](#getting-started)
  - [Ho to Install](#ho-to-install)
  - [How to open an example](#how-to-open-an-example)
  - [How to build and run the unit tests in Visual Studio on Windows](#how-to-build-and-run-the-unit-tests-in-visual-studio-on-windows)
- [Related work](#related-work)
  - [Object Oriented Internet](#object-oriented-internet)
  - [CommServer](#commserver)
  - [Object Oriented Internet Reactive Networking Configuration Editor](#object-oriented-internet-reactive-networking-configuration-editor)
- [Future Work](#future-work)
- [Contact](#contact)
- [See Also](#see-also)
  - [Documentation](#documentation)
  - [Video](#video)

## Preface

OPC Unified Architecture (OPC UA) is the next generation solution compared to OPC Classic. One of the most important improvements in OPC UA is the powerful Address Space and Information Model concepts. OPC UA allows exposing real-time process data and underlying infrastructure as a consistent information model built up with nodes. The process model is represented by nodes, attributes, and their mutual relationships. Therefore, using OPC UA this powerful concept allows us to expose not only raw process data but also entire consistent information about the process state and behavior. The flexibility of the OPC UA ensures that no existing or future systems are too complex to be exposed via OPC UA. Of course, such flexibility leads to difficulties during design, development, and deployment, that’s why the Object Oriented-Internet Address Space Model Designer (ASMD) was born.

The  OOI ASMD supports the graphical design of the process model using OPC UA Information and Address Space concepts. The embedded model compiler may be used to generate all required file formats necessary to deploy custom models on the client, server, publisher and subscriber side using any existing Software Development Kit. It is compliant with the OPC UA Specifications [OPC UA Part 3][Opc.UA.Part3], [OPC UA Part 5][Opc.UA.Part5], and [OPC UA Part 6][Opc.UA.Part6]. By design, it is also a consistent part of the broader concept [Object-Oriented Internet](https://commsvr.gitbook.io/ooi/).

> **NOTE**:
>
>- The design, development and deployment of the OPC UA Information Model detailed description is covered by the document [Information Models Development][IMD].
>- The help documentation is now available at [OPC UA Address Space Model Designer On-line Help][github.MD]

I am a researcher who is passionate about applying knowledge and experience in building a machine-centric global village. Let's build it with you and for you. To join our effort and create an organization context I have launched the [**Object-Oriented Internet Partnership Program**](https://github.commsvr.com/AboutPartnershipProgram.md.html).

> Consider joining as a sponsor, contributor or end-user. Details are covered by the section [**How to be involved**](https://github.commsvr.com/AboutPartnershipProgram.md.html#how-to-be-involved)
>
> Your participation is needed to make sure the work will continue as expected.

## Releases

The ASMD was written by CAS Lodz Poland. I am the founder and Executive Director of CAS. Now CAS is just an individual business activity conducted by me, so I decided to move this software to Open Source.

We use [Semantic Versioning][SV] for versioning. For the versions available, see the [releases on this repository][REL].

## Key Features

- graphical modeling of the OPC UA Information Model according to [OPC UA Part 5 specification][OPC.UA.Part5]
  - easy addition and deletion of nodes from the model structure
  - definition of nodes relationship (references) and types
  - nodes filtering
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

Check out the [On-line Help][github.MD] to get a more detailed description.

## Getting Started

This section describes prerequisites to use the tool, compile the code and run unit tests.

### Ho to Install

Download and run the file `UA.ModelDesigner.exe` to unzip the content to the selected folder and create an icon on the desktop. The application will run after unpacking. To restart the application you may use the icon on the desktop or double click the application file `<target>\CAS.UA.ModelDesigner.exe`, where `<target>` is the already selected folder during the installation. To uninstall the software and embedded example delete the `<target>` folder and the icon.

> Note: The self-extracting zip file and the main application are not code-signed. The unsigned executable may not be allowed by your company IT policy. The installer package containing signed stuff is on the project road map #89. Further development planning is based on the sponsors' priorities.

### How to open an example

This section contains information about the Address Space Model Designer sample solutions that illustrate the structure and techniques used for designing models and defining bindings between model nodes and real-time process data.

The section [Information Models Development][IMD] of the online ebook covers details on how to get started using the attached examples. The solution `BoilerExampleSolution` contains a boiler model. This model is described in the [ReferenceApplication Producer - Boilers Set Simulator][boiler]. Check out the section [Companion Specification - Information Model for Analyzers][ADI] to get more about `ADIExempleSolution` example.

Selected examples is added to the folder `<target>\EmbeddedExample`. The following step by step instruction will guide you on how to open the examples.

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

| File                                         | Content                                                                                                                                                                                                                                       |
| -------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `*.uamdsl`                                   | Address Space Model Designer solution. This file contains the configuration of the sample solution and references to other files that are used in this solution (e.g. projects, plug-ins, etc.)                                               |
| `*.csv`                                      | A CSV file that contains Node Identifiers                                                                                                                                                                                                     |
| `*.xml`                                      | An XML file that contains the model                                                                                                                                                                                                           |
| `*/CAS.UAServer.DemoConfiguration.uasconfig` | A sample configuration file of OPC UA Server. This file is created and edited by the plug-in providing the configuration editor. It is compatible with  [mpostol/OPCUA.Server](https://github.com/mpostol/OPCUA.Server) Open Source Software. |
| `*/DefaultConfig.xml`                        | A sample OPC DA Server configuration file (compatible with [mpostol/OPCDA.Server](https://github.com/mpostol/OPCDA.Server) Open Source Software).                                                                                             |
| `*/DemoConfiguration.oses`                   | A sample OPC DA Client configuration (compatible with  [mpostol/OPCDA.Viewer](https://github.com/mpostol/OPCDA.Viewer) and [mpostol/OPCDA.DataPorter](https://github.com/mpostol/OPCDA.DataPorter) Open Source Software)                      |

### How to build and run the unit tests in Visual Studio on Windows

Projects can be opened in Visual Studio.

1. Open the `CommServer.UA.ModelDesigner.sln` solution file using Visual Studio.
1. Hit `F6` to build all projects in the solution.
1. Set the `ModelDesigner.DesignStudio` as the Start-up Project
1. Press `F5` to run the tool using Debug configuration
1. Hit `Ctrl+r,Ctrl+a` to run all unit tests

The list of packages used is listed on the page [Dependency graph][DEPGraph] of this repository. All packages are included in this GitHub repository in the local folder `_nugets` or published on NuGet. The local folder is configured in the `NuGet.Config`. The NuGet Gallery is the public package repository used by all package authors and consumers. All required packages are loaded before the build.

To get more visit the Microsoft documentation [How to reinstall and update packages][NUGETInstall].

## Related work

### Object Oriented Internet

In this umbrella project, `C#` deliverables supporting a new `Machine To Machine (M2M)` communication approach based on the `Data-Oriented Architecture (DOA)` paradigm is to be researched. The goal is to provide a generic solution for publishing and updating information in a context that can be used to describe and discover it by software applications. It is implemented based on the

- [OPC Unified Architecture](https://commsvr.gitbook.io/ooi/introduction/opcunifiedarchitecture) - an industrial integration standard that fulfills the proposed architecture requirements.
- `Object-Oriented Programming` - well know and widely accepted programming language model in which data processing is organized around 4 major principles, namely encapsulation, abstraction, polymorphism and inheritance.

The GitHub [Object Oriented Internet][OOI] repository is aimed at the maintenance of this project. The ASMD contributes to this project and is compliant with the OOI concept.

### CommServer

[CommServer][commserver] is a package of software to manage data transfer using OPC standards. Built-in technologies and algorithms support Machine to Machine (M2M) meaningful interoperability. The [CommServer][commserver] was written by CAS Lodz Poland.

The GitHub repository [commsvr-com/migration2os][migration2os] is aimed at the `CommServer` software migration from on-premise subversion repository to GitHub and publishing it as the Open-Source Software (OSS). The members of the `CommServer` family are to be converged with the Object-Oriented Internet paradigms and integrated with the solutions maintained in this repository.

The project [CommServer Migration to Open-source][migration2osProj] will be used to coordinate the migration process of transferring multi-parts software from an on-premise subversion repository to a set of GitHub repositories.

### Object Oriented Internet Reactive Networking Configuration Editor

OPC-UA-OOI.ConfigEditor is a package of software to manage the configuration of the [Reactive Communication][OOIBookToC].  The `OPC-UA-OOI.ConfigEditor` was written by CAS Lodz Poland. The [mpostol/OPC-UA-OOI.ConfigEditor][ConfigEditor] repository is aimed at the software migration from on-premise subversion repository to GitHub and publishing it as the Open-Source Software (OSS).  After migration, this repository will be used to manage all activities addressing the software maintenance process as a plug-in of the ASMD.

### OPCUA.Common

Intentionally the [OPCUA.Common](https://github.com/mpostol/OPCUA.Common) repository should provide NuGet definitions for all main components defined in the OPC UA specification and used elsewhere outside the OPC UA application (client/server), namely:

- common definitions
- data serialization
- address space management
- configuration
- TBD

## Future Work

The following list of projects is to be conducted as part of the open-source inititives **[Object Oriented Internet][OOI]**:

1. [Cloud Metadata Export](https://mpostol.github.io/ASMD/CloudMetadataExport)
1. [OPC UA Information Models Compliance Testing](https://mpostol.github.io/ASMD/ASMD50-ModelsTesting)

## Partnership program

I am a researcher and University associate who is passionate about applying knowledge and experience in building a Machine to Machine (M2M) meaningful interoperability based on OPC UA. Let's build it with you and for you. To join our effort and create an organizational context I have launched an open-access **Object-Oriented Internet Partnership Program**. Hence, maintenance of this repository and further development of the OPC UA Information Model Domain-Specific Language will be carried out under a broader concept described in the following article

[Object-Oriented Internet Partnership Program][Sponsorship]

**Consider joining**. Visit the section [How to be involved][SponsorshipToBeInvolved] to get more. I hope that thanks to this partnership program we will establish long-term mutually beneficial cooperation. Your participation is needed to make sure that the work will continue as expected. As a rule of thumb, the work priority is derived from community feedback.

I strongly encourage community participation and contribution to this project. First, please fork the repository and commit your changes there. Once happy with your changes you can generate a 'pull request'.

When contributing to this repository, please first discuss the change you wish to make via issue, email, or any other method with the owners of this repository before making a change.

Please note we have a code of conduct, please follow it in all your interactions with the project.

- [Object-Oriented Internet Partnership Program][Sponsorship]
- [How to be involved][SponsorshipToBeInvolved]

## Contact

- [![View my profile on LinkedIn](https://www.linkedin.com/img/webpromo/btn_viewmy_160x33.png "View my profile on LinkedIn")](https://pl.linkedin.com/in/mpostol)
- [my blog on wordpress](https://mpostol.wordpress.com/about/)
- [mpostol (at) cas.eu](https://cas.eu/index.php/contact)
- [GitHub profile](https://github.com/mpostol)
- [http://www.commsvr.com/](http://www.commsvr.com/)
- [twitter](https://twitter.com/mpostol)
- [![ORCID Mariusz Postół](https://orcid.org/sites/default/files/images/orcid_16x16.png) ORCID Mariusz Postół](https://orcid.org/0000-0002-9669-0565)

## See Also

### Documentation

- [OPC UA Address Space Model Designer Help][github.MD]
- [WIKI - Help Documentation][WIKI]
- [Mariusz Postol. Address Space and Address Space Model](https://commsvr.gitbook.io/ooi/semantic-data-processing/addressspaceaddressspacemodel)
- [OPC UA Address Space Model Designer][CAS.ASMD]
- [Object Oriented Internet][OOI]
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

### Video

- [OPC UA Information Model How to Create Instances][CAS.VideoInstances] - The main aim of this movie is to demonstrate how to use a tool - the Address Space Model Designer to design OPC UA Information Model and instantiate OPC UA Address Space for selected well-known Boiler example.
- [ASMD - How to Build Solution][CAS.VideBuild] - How to get started using an embedded example.
- [Introduction to OPC UA Address Space modeling using CAS Address Space Model Designer][CAS.MZASMDIntro]

[Sponsorship]: https://github.commsvr.com/AboutPartnershipProgram.md.html
[SponsorshipToBeInvolved]: https://github.commsvr.com/AboutPartnershipProgram.md.html#how-to-be-involved
[CAS.MZASMDIntro]:https://www.youtube.com/watch?v=pYOQA4atlRI&feature=youtu.be
[OPC.UA.ModelCompiler]:https://github.com/OPCFoundation/UA-ModelCompiler
[WIKI]:https://github.com/mpostol/ASMD/wiki
[NUGETInstall]:https://docs.microsoft.com/nuget/consume-packages/reinstalling-and-updating-packages
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
[github.MD]:https://commsvr-com.github.io/Documentation/ModelDesigner
