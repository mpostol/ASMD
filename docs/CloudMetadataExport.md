# Cloud Metadata Schema Generation

## Keywords

`JSON`, `SQL`, `JSON-LD`, `Azure DeviceTemplate`, `Azure Device Capability Model`.

## Subject

A basic matter of thought, discussion, investigation, development, etc.:
Describe the problem and the motivation for undertaking the effort to solve the problem.

## Goal

What we are going to achieve - the result or achievement toward which effort is directed.

## Scope

### Azure

In **IoT Central** a Cyber-Physical Systems (CPS) is represented as a set of devices. The characteristics and behavior of each device kind are described by the device template. This Device Template (DT) contains also metadata describing the data exchanged over the wire with the CPS called Device Capability Model (DCM). Additionally, the DT contains properties, customization, and views definitions used by the service locally. As an option, DCM expressed as a JSON-LD can be imported into a Device Template. **IoT Central** also allows to create and edit a DCM using the dedicated web UI. A JSON file containing DCM can be derived from an information model used as a foundation to establish the semantic-context applied to achieve interoperability of the devices interconnected as the CPS. DCM development against any external information model is a design-time task and should be supported by dedicated development tools. In any case, the data interchanged between the cloud and the gateway must be compliant with the DCM, hence, the middleware software must be aware of conversions that must be applied to achieve this interoperability.

### SQL database Schema

### SMProfiles

## Related work

Any information about available reusable deliverables related to this work.

## See also

- [CASMPostol/SharePoint SQLGenerator](https://github.com/CASMPostol/SharePoint/tree/main/Tools/SPExplorer/SQLGenerator)
- [cesmii/SMProfiles nodeset2json](https://github.com/cesmii/SMProfiles/tree/main/nodeset2json)
- [JSON for Linking Data](https://json-ld.org/)
- [JSON-LD 1.1 W3C Specyfication](https://www.w3.org/TR/json-ld/)
