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
- [ ] Update version information
- [ ] Update ReleaseNotes.md and print it to .html using VC
- [ ] Build the Release Configuration of the solution and perform functional tests
- [ ] Create the installation package and publish in on the Release page
- [ ] Update the Release page
- [ ] Publish the release
- [ ] Close this issue and the parent milestone

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
> - rename the folder name Release to UA.ModelDesigner
> - configure Logo: _media\ASMDLogo_SFX_93_302.png
> - configure Icon: _media\ASMDLogo-48.ico
> - rename the CAS.UA.ModelDesigner.exe to OOI.UA.ModelDesigner.exe and the config file - it is necessary as long as the license container and editor will be fixed
