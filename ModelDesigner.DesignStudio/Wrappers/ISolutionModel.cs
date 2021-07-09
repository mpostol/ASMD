//__________________________________________________________________________________________________
//
//  Copyright (C) 2021, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GitHub: https://github.com/mpostol/OPC-UA-OOI/discussions
//__________________________________________________________________________________________________

using CAS.CommServer.UA.ModelDesigner.Configuration.UserInterface;

namespace CAS.UA.Model.Designer.Wrappers
{
  internal interface ISolutionModel : IBaseModel
  {
    //TODO Removed dependency of the CAS.UA.Model.Designer.Wrappers on using System.Windows.Forms #38
    void GetPluginMenuItems(System.Windows.Forms.ToolStripItemCollection items);

    void AddProject(bool existing);

    void ImportNodeSet();

    void Save(bool prompt);

    void Open(IGraphicalUserInterface gui);

    void OnNew(IGraphicalUserInterface gui);
  }
}