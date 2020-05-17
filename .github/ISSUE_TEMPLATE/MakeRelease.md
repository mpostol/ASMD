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

Path=.\ASMD
Setup=Release\CAS.UA.ModelDesigner.exe installic
Title=Address Space Model Designer
Shortcut=D, Release\CAS.UA.ModelDesigner.exe,  , "OPC UA Address Space Model Designer", asmd, Release\OPC_UA_ASMD_48.ico

```
