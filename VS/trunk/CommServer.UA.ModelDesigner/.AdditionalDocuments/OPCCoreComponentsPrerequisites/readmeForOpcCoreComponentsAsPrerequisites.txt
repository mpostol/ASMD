Adding OPC Core Components to the ASMD setup:
- Copy folder OPCCoreComponents to C:\Program Files\Microsoft SDKs\Windows\v6.0A\Bootstrapper\Packages
- Start Visual Studio or restart it, if it was working during first step.
- Open properties of the Model project.
- Open Publish bookmark and open Prerequisites.
- Select OpcCoreComponentsSetup from the drop-down list.
- Push OK.

The Manifest (OPCCoreComponents.VSBootstrapperManifest) has been created in "Bootstrap Manifest Generator"(it is recommended by Microsoft). Unfortunately this program causes many problems and sometimes it is impossible to open correct file due to errors (which are in fact not in the manifest file, but in BMG itself).

In BMG during creating of the Manifest it is important to select proper exe and msi files.