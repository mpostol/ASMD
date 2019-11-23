//___________________________________________________________________________________
//
//  Copyright (C) 2019, Mariusz Postol LODZ POLAND.
//
//___________________________________________________________________________________

using CAS.CommServer.UA.ModelDesigner.Configuration.UserInterface;
using CAS.UA.Model.Designer.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;

namespace CAS.CommServer.UA.ModelDesigner.DesignStudio.UnitTest.IO
{

  [TestClass]
  public class OPCFModelConfigurationManagementUnitTest
  {
    [TestMethod]
    public void CreatorTestMethod()
    {
      Mock<IFileDialog> _IFileDialogMock = new Mock<IFileDialog>();
      _IFileDialogMock.SetupProperty(x => x.FileName);
      _IFileDialogMock.Setup(x => x.InitialDirectory).Returns("RandomText");
      using (OPCFModelConfigurationManagement _newItem = new OPCFModelConfigurationManagement(new GraphicalUserInterface(_IFileDialogMock.Object)))
      {
        Assert.IsFalse(_newItem.ChangesArePresent);
        Assert.AreEqual<string>("RandomText", _newItem.DefaultDirectory);
        Assert.AreEqual<string>("UAModelDesignerProject.xml", _newItem.DefaultFileName);
      }
    }
    private class GraphicalUserInterface : IGraphicalUserInterface
    {
      private IFileDialog m_Mock;
      public GraphicalUserInterface(IFileDialog @object)
      {
        this.m_Mock = @object;
      }
      public Action<string, string> MessageBoxShowWarning => throw new NotImplementedException();
      public Action<string, string> MessageBoxShowExclamation => throw new NotImplementedException();
      public Action<string, string> MessageBoxShowError => throw new NotImplementedException();
      public Func<IFileDialog> OpenFileDialogFunc => () => m_Mock;
      public Func<IFileDialog> SaveFileDialogFuc => () =>  m_Mock;
      public Func<IFolderBrowserDialog> OpenFolderBrowserDialogFunc => throw new NotImplementedException();
    }
  }
}
