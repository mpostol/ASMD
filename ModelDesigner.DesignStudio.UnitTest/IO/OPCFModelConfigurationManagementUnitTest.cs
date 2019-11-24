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
using System.IO;

namespace CAS.CommServer.UA.ModelDesigner.DesignStudio.UnitTest.IO
{

  [TestClass]
  public class OPCFModelConfigurationManagementUnitTest
  {

    [TestMethod]
    public void ConstructorTest()
    {
      string _defPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UAModelDesignerSolution");
      Mock<IFileDialog> _IFileDialogMock = new Mock<IFileDialog>();
      _IFileDialogMock.SetupProperty(x => x.FileName);
      _IFileDialogMock.Setup(x => x.InitialDirectory).Returns("RandomText");
      OPCFModelConfigurationManagement _newItem = new OPCFModelConfigurationManagement(new GraphicalUserInterface(_IFileDialogMock.Object), _defPath);
      _IFileDialogMock.VerifySet(x => x.FileName = It.IsAny<string>(), Times.Never);
      Assert.IsFalse(_newItem.ChangesArePresent);
      Assert.AreEqual<string>(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), _newItem.DefaultDirectory);
      Assert.AreEqual<string>(_defPath, _newItem.DefaultFileName);
      Assert.IsFalse(String.IsNullOrEmpty(Path.GetPathRoot(_newItem.DefaultDirectory)));
      _IFileDialogMock.Verify(x => x.InitialDirectory, Times.Never);
    }
    private class GraphicalUserInterface : IGraphicalUserInterface
    {
      private readonly IFileDialog m_Mock;
      public GraphicalUserInterface(IFileDialog @object)
      {
        this.m_Mock = @object;
      }
      public Action<string, string> MessageBoxShowWarning => throw new NotImplementedException();
      public Action<string, string> MessageBoxShowExclamation => throw new NotImplementedException();
      public Action<string, string> MessageBoxShowError => throw new NotImplementedException();
      public Func<IFileDialog> OpenFileDialogFunc => () => m_Mock;
      public Func<IFileDialog> SaveFileDialogFuc => () => m_Mock;
      public Func<IFolderBrowserDialog> OpenFolderBrowserDialogFunc => throw new NotImplementedException();
      public Func<string, string, bool> MessageBoxShowWarningAskYN => throw new NotImplementedException();
    }
  }
}
