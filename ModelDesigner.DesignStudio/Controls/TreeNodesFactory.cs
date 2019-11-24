//___________________________________________________________________________________
//
//  Copyright (C) 2019, Mariusz Postol LODZ POLAND.
//
//___________________________________________________________________________________

using CAS.UA.Model.Designer.Wrappers;

namespace CAS.UA.Model.Designer.Controls
{
  internal interface ITreeNodesFactory
  {
    DictionaryTreeNode GetTreeNode(IBaseModel wrapper);
  }
  internal class TreeNodesFactory
  {
    internal static ITreeNodesFactory Factory { get; set; } = new InternalTreeNodesFactory();
    private class InternalTreeNodesFactory : ITreeNodesFactory
    {
      public DictionaryTreeNode GetTreeNode(IBaseModel wrapper)
      {
        DictionaryTreeNode _ret = null;
        if (wrapper is ViewDesign)
          _ret = new ViewDesignTreeNodeControl((ViewDesign)wrapper);
        else if (wrapper is VariableTypeDesign)
          _ret = new VariableTypeDesignTreeNodeControl((VariableTypeDesign)wrapper);
        else if (wrapper is VariableDesign)
          _ret = new VariableDesignTreeNodeControl((VariableDesign)wrapper);
        else if (wrapper is SolutionTreeNode)
          _ret = new SolutionTreeNodeControl((SolutionTreeNode)wrapper);
        else if (wrapper is ReferenceTypeDesign)
          _ret = new ReferenceTypeDesignTreeNodeControl((ReferenceTypeDesign)wrapper);
        else if (wrapper is ReferencesFolder)
          _ret = new ReferencesFolderTreeNodeControl((ReferencesFolder)wrapper);
        else if (wrapper is Reference)
          _ret = new ReferenceTreeNodeControl((Reference)wrapper);
        else if (wrapper is PropertyDesign)
          _ret = new PropertyDesignTreeNodeControl((PropertyDesign)wrapper);
        else if (wrapper is ProjectTreeNode)
          _ret = new ProjectTreeNodeControl((ProjectTreeNode)wrapper);
        else if (wrapper is ParametersFolder)
          _ret = new ParametersFolderTreeNodeControl((ParametersFolder)wrapper);
        else if (wrapper is Parameter)
          _ret = new ParameterTreeNodeControl((Parameter)wrapper);
        else if (wrapper is ObjectTypeDesign)
          _ret = new ObjectTypeDesignTreeNodeControl((ObjectTypeDesign)wrapper);
        else if (wrapper is ObjectDesign)
          _ret = new ObjectDesignTreeNodeControl((ObjectDesign)wrapper);
        else if (wrapper is NamespacesFolder)
          _ret = new NamespacesFolderTreeNodeControl((NamespacesFolder)wrapper);
        else if (wrapper is Namespace)
          _ret = new NamespaceTreeNodeControl((Namespace)wrapper);
        else if (wrapper is ModelDesign)
          _ret = new ModelDesignTreeNodeControl((ModelDesign)wrapper);
        else if (wrapper is MethodDesign)
          _ret = new MethodDesignTreeNodeControl((MethodDesign)wrapper);
        else if (wrapper is EncodingsFolder)
          _ret = new EncodingsFolderTreeNodeControl((EncodingsFolder)wrapper);
        else if (wrapper is DictionaryDesign)
          _ret = new DictionaryDesignTreeNodeControl((DictionaryDesign)wrapper);
        else if (wrapper is DataTypeDesign)
          _ret = new DataTypeDesignTreeNodeControl((DataTypeDesign)wrapper);
        else if (wrapper is EncodingDesign)
          _ret = new EncodingDesignTreeNodeControl((EncodingDesign)wrapper);
        else if (wrapper is ChildrenFolder)
          _ret = new ChildrenFolderTreeNodeControl((ChildrenFolder)wrapper);
        else if (wrapper is NamespacesFolder)
          _ret = new NamespacesFolderTreeNodeControl((NamespacesFolder)wrapper);
        else if (wrapper is ModelDesign)
          _ret = new ModelDesignTreeNodeControl((ModelDesign)wrapper);
        else
          throw new System.ArgumentOutOfRangeException($"{nameof(GetTreeNode)} cannot factory object for {wrapper.GetType().FullName}");
        return _ret;
      }
    }

    #region Debug Instrumentation
    [System.Diagnostics.Conditional("DEBUG")]
    internal static void ResetSingleton()
    {
      Factory = new InternalTreeNodesFactory();
    }
    #endregion
  }
}
