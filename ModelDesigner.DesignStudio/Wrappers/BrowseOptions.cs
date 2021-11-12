//__________________________________________________________________________________________________
//
//  Copyright (C) 2021, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GitHub: https://github.com/mpostol/OPC-UA-OOI/discussions
//__________________________________________________________________________________________________

using System.Collections.Generic;
using UAOOI.OPCUA.Common.Types;

namespace CAS.UA.Model.Designer.Wrappers
{
    public class BrowseOptions
    {
        /// <summary>
        /// Gets or sets the browse direction.
        /// </summary>
        /// <value>The browse direction.</value>
        private BrowseDirection BrowseDirection { get; set; }

        /// <summary>
        /// Gets or sets the reference type design.
        /// </summary>
        /// <value>The reference type.</value>
        private ReferenceTypeDesign ReferenceTypeDesign { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the subtypes are included.
        /// </summary>
        /// <value><c>true</c> if subtypes are included; otherwise, <c>false</c>.</value>
        private bool IncludeSubtypes { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether node class mask is set.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if the node class mask is set; otherwise, <c>false</c>.
        /// </value>
        private bool NodeClassMask { get; set; }

        /// <summary>
        /// Gets or sets the selected node class list.
        /// </summary>
        /// <value>The selected node class list.</value>
        private List<string> SelectedNodeClassList { get; set; }
    }
}