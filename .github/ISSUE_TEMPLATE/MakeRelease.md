---
name: Make release
about: Make release tasks list
title: 'Close the milestone and make release'
labels: 'Release'
assignees: 'mpostol'

---

## Release ToDo List

- [ ] Remove all not crucial tasks from the current milestone to a new one or backlog
- [ ] Draft a new release
- [ ] Update version information for all published assemblies (Model.t4), 
- [ ] Update ReleaseNotes.md and print it to .html using VC
- [ ] Build the Release Configuration of the solution
- [ ] rename the folder name Release to UA.ModelDesigner
- [ ] Create the installation package and publish in on the Release page
- [ ] Perform functional tests
- [ ] Update Readme files
- [ ] Prepare and publish NuGet packages if applicable. 
- [ ] Create release front page
  - [ ] Getting Started
  - [ ] Version information
- [ ] Build solution to create deliverable and publish the installation package
- [ ] Close this issue and the parent milestone

- [ ] Publish the release
- [ ] Update the repository front page
- [ ] Update the GitHub pages documentation

> Note: after publication prepare and publish news to advertise the results

## Creating self extracting file

The comment below contains SFX script commands for RAR

```txt

Path=OOI
Setup=UA.ModelDesigner\OOI.UA.ModelDesigner.exe installic
Title=Address Space Model Designer
Shortcut=D, UA.ModelDesigner\OOI.UA.ModelDesigner.exe,  , "OPC UA Address Space Model Designer", asmd, UA.ModelDesigner\OPC_UA_ASMD_48.ico

```

> Note
>
> - configure Logo: _media\ASMDLogo_SFX_93_302.png
> - configure Icon: _media\ASMDLogo-48.ico
