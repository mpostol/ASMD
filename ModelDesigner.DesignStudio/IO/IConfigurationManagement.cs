//___________________________________________________________________________________
//
//  Copyright (C) 2020, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GITTER: https://gitter.im/mpostol/OPC-UA-OOI
//___________________________________________________________________________________

using System;

namespace CAS.UA.Model.Designer.IO
{
  /// <summary>
  /// Interface IConfigurationManagement - definitions related to the configuration management
  /// </summary>
  internal interface IConfigurationManagement
  {
    /// <summary>
    /// Gets or sets a value indicating whether [changes are present].
    /// </summary>
    /// <value><c>true</c> if [changes are present]; otherwise, <c>false</c>.</value>
    bool ChangesArePresent { get; }

    /// <summary>
    /// Occurs when changes are present.
    /// </summary>
    event EventHandler ChangesArePresentHasChanged;

    /// <summary>
    /// Tests if changes are present, next display window and return true if they may be lost.
    /// </summary>
    /// <returns><c>true</c> if changes may be neglected and next operation may be executed, <c>false</c> otherwise.</returns>
    bool TestIfChangesArePresentDisplayWindowAndReturnTrueIfShouldBeContinued();

    /// <summary>
    /// Sets that the changes are present.
    /// </summary>
    void SetChangesArePresent();
  }
}