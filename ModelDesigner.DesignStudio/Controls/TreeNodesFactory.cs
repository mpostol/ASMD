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
        if (wrapper is VariableTypeDesign)
          _ret = new VariableTypeDesignTreeNodeControl((VariableTypeDesign)wrapper);
        if (wrapper is VariableDesign)
          _ret = new VariableDesignTreeNodeControl((VariableDesign)wrapper);
        if (wrapper is SolutionTreeNode)
          _ret = new SolutionTreeNodeControl((SolutionTreeNode)wrapper);
        if (wrapper is ReferenceTypeDesign)
          _ret = new ReferenceTypeDesignTreeNodeControl((ReferenceTypeDesign)wrapper);
        if (wrapper is ReferencesFolder)
          _ret = new ReferencesFolderTreeNodeControl((ReferencesFolder)wrapper);
        if (wrapper is Reference)
          _ret = new ReferenceTreeNodeControl((Reference)wrapper);
        if (wrapper is PropertyDesign)
          _ret = new PropertyDesignTreeNodeControl((PropertyDesign)wrapper);
        if (wrapper is ProjectTreeNode)
          _ret = new ProjectTreeNodeControl((ProjectTreeNode)wrapper);
        if (wrapper is ParametersFolder)
          _ret = new ParametersFolderTreeNodeControl((ParametersFolder)wrapper);
        if (wrapper is Parameter)
          _ret = new ParameterTreeNodeControl((Parameter)wrapper);
        if (wrapper is ObjectTypeDesign)
          _ret = new ObjectTypeDesignTreeNodeControl((ObjectTypeDesign)wrapper);
        if (wrapper is ObjectDesign)
          _ret = new ObjectDesignTreeNodeControl((ObjectDesign)wrapper);
        if (wrapper is NamespacesFolder)
          _ret = new NamespacesFolderTreeNodeControl((NamespacesFolder)wrapper);
        if (wrapper is Namespace)
          _ret = new NamespaceTreeNodeControl((Namespace)wrapper);
        if (wrapper is ModelDesign)
          _ret = new ModelDesignTreeNodeControl((ModelDesign)wrapper);
        if (wrapper is MethodDesign)
          _ret = new MethodDesignTreeNodeControl((MethodDesign)wrapper);
        if (wrapper is EncodingsFolder)
          _ret = new EncodingsFolderTreeNodeControl((EncodingsFolder)wrapper);
        if (wrapper is DictionaryDesign)
          _ret = new DictionaryDesignTreeNodeControl((DictionaryDesign)wrapper);
        if (wrapper is DataTypeDesign)
          _ret = new DataTypeDesignTreeNodeControl((DataTypeDesign)wrapper);
        if (wrapper is EncodingDesign)
          _ret = new EncodingDesignTreeNodeControl((EncodingDesign)wrapper);
        if (wrapper is ChildrenFolder)
          _ret = new ChildrenFolderTreeNodeControl((ChildrenFolder)wrapper);
        else
          throw new System.ArgumentOutOfRangeException($"{nameof(GetTreeNode)} cannot factory object for {wrapper.GetType().FullName}");
        return _ret;
      }
    }
  }
}
