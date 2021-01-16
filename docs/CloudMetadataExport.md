# Cloud Metadata Export

## Keywords

`OPC UA`, `Information Model`, `Address Space`, `ModelDesign`, `NodeSet`, `JSON`, `JSON-LD`, `SQL`, `Azure Device Template`, `Azure Device Capability Model`, `Smart Manufacturing Profiles`, `SMP`.

## [Back to mpostol/ASMD][ASMD]

## Subject

The **Cloud Metadata** (CM) defines how a device interacts with IoT cloud services. Usually, a solution developer can import a file that defines the CM, or use the web UI to create or edit it. The CM is a semantic-context used to expose the process data by the cloud frond-end. This context is necessary to make the exposed real-time process data meaningful.

The **Cloud Metadata Export** project is to be conducted as part of the open-source **[Object Oriented Internet][OOI]** initiatives. Let's work on it with you and for you. To join our effort and create an organizational context I have launched the [Object-Oriented Internet Partnership Program](https://github.commsvr.com/AboutPartnershipProgram.md.html).

> Consider joining as a sponsor, contributor, or end-user. Details are covered by the section [How to be involved](https://github.commsvr.com/AboutPartnershipProgram.md.html#how-to-be-involved)
>
> Your experience, knowledge, and direct participation is needed to make sure the work will continue as expected.

## Goal

We are going to provide export functionality that can be used to convert standard _OPC UA Information Model_ representation to other ones that can be used by the cloud services to define metadata of an IoT solution.

## Scope

### Azure

In **IoT Central** a Cyber-Physical Systems (CPS) is represented as a set of devices. The characteristics and behavior of each device kind are described by the device template. This Device Template (DT) contains also metadata describing the data exchanged over the wire with the CPS called Device Capability Model (DCM). Additionally, the DT contains properties, customization, and views definitions used by the service locally. As an option, DCM expressed as a JSON-LD can be imported into a Device Template. **IoT Central** also allows to create and edit a DCM using the dedicated web UI. A JSON file containing DCM can be derived from an _OPC UA Information Model_ used as a foundation to establish the semantic-context applied to achieve interoperability of the devices interconnected as the CPS. DCM development against any external information model is a design-time task and should be supported by dedicated development tools. In any case, the data interchanged between the cloud and the gateway must be compliant with the DCM, hence, the middleware software must be aware of conversions that must be applied to achieve this interoperability.

### Smart Manufacturing Profiles™

The **SM Profiles™** have been proposed and are maintained by the [CESMII][cesmii]. **SM Profiles™** is a way of representing data in information models that provide the ability to transfer “data-in-context” from source to consumption, and between components that consume the data to provide a solution. Developers and end-users will adapt or customize the information model with constructs that are specific to a particular domain, platform, or application. In other words, a profile is a digital extension mechanism to seamlessly connect, collect, analyze, and act at the edge, the cloud and in the apps in the SM Innovation Platform.

[CESMII][cesmii] has chosen a JSON serialization of an OPC UA Information Model Type definition as a starting point. As an open specification, SM Profiles™ can be implemented by any platform. However, CESMII and its members are developing an implementation that can be used for reference, rapid innovation, and production use of the SM Profile capabilities.

Check out the [CESMII - The Smart Manufacturing Institute home page][cesmii] to get a more detailed description of the technology and learn how to be involved.

### SQL database Schema

A database schema is a metadata of the database. It represents the description of a database structure, data types, and the constraints on the database. Designing database schemas is one of the very first and important steps to start developing any software/website. In general, it defines how an IoT cloud service or _OPC UA Application_ can store/retrieve process data. Usually, a solution developer can execute a script (list of queries) that defines the database schema or use the UI to create or edit it. The database schema is a semantic-context used to expose the process data. This context is necessary to make the exposed real-time process data meaningful.

## Related work

**[Object Oriented Internet][OOI]** is an umbrella project aimed at providing C\# deliverables supporting a new Machine To Machine \(M2M\) communication approach based on the **Data-Oriented Architecture** (DOA) paradigm. The goal is to provide a generic solution for publishing and updating information in a context that can be used to describe and discover it by software applications. It is implemented based on the

- [OPC Unified Architecture](https://commsvr.gitbook.io/ooi/introduction/opcunifiedarchitecture) - an industrial integration standard that fulfills the proposed architecture requirements.
- Object-Oriented Programming - well know and widely accepted programming language model in which data processing is organized around 4 major principles, namely encapsulation, abstraction, polymorphism, and inheritance.

The GitHub **[Object Oriented Internet][OOI]** repository is aimed at the maintenance of this project. The [OPC UA Address Space Model Designer][ASMD] contributes to this project and is compliant with the OOI concept.

## Contact

[![View my profile on LinkedIn](https://www.linkedin.com/img/webpromo/btn_viewmy_160x33.png "View my profile on LinkedIn")](https://pl.linkedin.com/in/mpostol)

- [my blog on wordpress](https://mpostol.wordpress.com/about/)
- [mpostol (at) cas.eu](https://cas.eu/index.php/contact)
- [GitHub profile](https://github.com/mpostol)
- [http://www.commsvr.com/](http://www.commsvr.com/)
- [twitter](https://twitter.com/mpostol)

## See also

- [CASMPostol/SharePoint SQLGenerator](https://github.com/CASMPostol/SharePoint/tree/main/Tools/SPExplorer/SQLGenerator)
- [cesmii/SMProfiles nodeset2json](https://github.com/cesmii/SMProfiles/tree/main/nodeset2json)
- [JSON for Linking Data](https://json-ld.org/)
- [JSON-LD 1.1 W3C Specyfication](https://www.w3.org/TR/json-ld/)
- [Object Oriented Internet][OOI]
- [OPC UA Address Space Model Designer][ASMD]

[OOI]: https://github.com/mpostol/OPC-UA-OOI
[ASMD]: https://github.com/mpostol/ASMD
[cesmii]:https://www.cesmii.org/