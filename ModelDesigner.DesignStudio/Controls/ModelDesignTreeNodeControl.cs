//___________________________________________________________________________________
//
//  Copyright (C) 2021, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GITTER: https://gitter.im/mpostol/OPC-UA-OOI
//___________________________________________________________________________________

using CAS.UA.Model.Designer.ImportExport;
using CAS.UA.Model.Designer.Wrappers;
using CAS.UA.Model.Designer.Wrappers4ProperyGrid;
using System.Collections.Generic;
using System.Windows.Forms;
using OpcUaModelCompiler = UAOOI.SemanticData.UAModelDesignExport.XML;

namespace CAS.UA.Model.Designer.Controls
{
  internal class ModelDesignTreeNodeControl : WrapperBaseTreeNodeControl<ModelDesign, Wrappers4ProperyGrid.ModelDesignViewModel, OpcUaModelCompiler.ModelDesign>
  {
    #region creator

    public ModelDesignTreeNodeControl(ModelDesign parent) : base(parent)
    {
      this.Expand();
    }

    #endregion creator

    #region public

    public override void SetTypeFilter(bool allTypes, IEnumerable<NodeClassesEnum> types)
    {
      RecreateSubtree();
      ApplyTypeFiltersToChildren(allTypes, types);
    }

    /// <summary>
    /// Gets the unique identifier.
    /// </summary>
    /// <param name="ui">The instance of <see cref="UniqueIdentifier"/> that represents an unique identifier.</param>
    /// <returns>
    /// 	<c>true</c> if it is not top level element; <c>false</c> otherwise if it is top level element
    /// </returns>
    internal override bool GetUniqueIdentifier(UniqueIdentifier ui)
    {
      return false;
    }

    public override DictionaryTreeNode CreateCopy()
    {
      return new ModelDesignTreeNodeControl(ModelEntity);
    }

    #endregion public

    #region private

    protected override void BeforeMenuStripOpening()
    {
      AddMenuItemAdd(ModelEntity.ListOfNodes);
      ToolStripMenuItem import = ImportMenuFactory.CreateImportMenuItem.CreateToolStripMenuItem();
      this.ContextMenuStrip.Items.Add(import);
      ModelEntity.GetImportMenu(import.DropDownItems);
      base.BeforeMenuStripOpening();
    }

    protected override void AddMenuItemDelete()
    {
      //this node should not have menu delete
    }

    protected internal override void GetImportMenu(ToolStripItemCollection items)
    {
      ModelEntity.GetImportMenu(items);
    }

    #endregion private
  }
}