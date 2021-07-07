//__________________________________________________________________________________________________
//
//  Copyright (C) 2021, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GitHub: https://github.com/mpostol/OPC-UA-OOI/discussions
//__________________________________________________________________________________________________

using System;
using System.Collections.Generic;

namespace CAS.UA.Model.Designer.Wrappers
{
  internal interface IBaseModel : IEnumerable<IBaseModel>
  {
    event EventHandler<BaseModel.TextEventArgs> TextChanged;

    event EventHandler<BaseModel.ProjectEventArgs> SubtreeChanged;

    string ToolTipText { get; set; }
    string Text { get; set; }
    string[] AvailiableNamespaces { get; }

    /// <summary>
    /// Gets or sets the parent node in the model.
    /// </summary>
    /// <value>The parent node.</value>
    IBaseModel Parent { get; set; }

    /// <summary>
    /// Raises the handler to notify changes.
    /// </summary>
    void RaiseOnChangeHandler();

    bool IsReadOnly();

    /// <summary>
    /// Gets the target namespace.
    /// </summary>
    /// <returns>The target namespace.</returns>
    string GetTargetNamespace();

    /// <summary>
    /// Request to create the instance configurations.
    /// </summary>
    /// <param name="node">The node.</param>
    /// <param name="SkipOpeningConfigurationFile">if set to <c>true</c> skip opening configuration file was requested.</param>
    /// <param name="CancelWasPressed">if set to <c>true</c> cancel was pressed during execution.</param>
    void CreateInstanceConfigurations(IBaseModel node, bool SkipOpeningConfigurationFile, out bool CancelWasPressed);

    /// <summary>
    /// Removes the first occurrence of a specific object from the collection.
    /// </summary>
    /// <param name="item">The object to remove from the collection.</param>
    /// <returns>
    /// <c>true</c> if <paramref name="item"/> was successfully removed from the embedded collection>;
    /// otherwise, <c>false</c>. This method also returns false if <paramref name="item"/> is not found in the collection.
    /// </returns>
    bool Remove(IBaseModel item);
  }
}