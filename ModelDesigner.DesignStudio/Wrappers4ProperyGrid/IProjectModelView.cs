//__________________________________________________________________________________________________
//
//  Copyright (C) 2021, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GitHub: https://github.com/mpostol/OPC-UA-OOI/discussions
//__________________________________________________________________________________________________

namespace CAS.UA.Model.Designer.Wrappers4ProperyGrid
{
  internal interface IProjectModelView : IBaseViewModel
  {
    string Name { get; }

    void Remove();
  }
}