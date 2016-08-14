//<summary>
//  Title   : Implementation of the <see cref="INodeComponent"/> for the instance declaration.
//  System  : Microsoft Visual C# .NET 2008
//  $LastChangedDate$
//  $Rev$
//  $LastChangedBy$
//  $URL$
//  $Id$
//
//  Copyright (C)2010, CAS LODZ POLAND.
//  TEL: +48 (42) 686 25 47
//  mailto://techsupp@cas.eu
//  http://www.cas.eu
//</summary>

using CAS.UA.Model.Designer.Wrappers4ProperyGrid;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml;

namespace CAS.UA.Model.Designer.Wrappers.AddressSpaceDictionary
{

  /// <summary>
  /// Class ReferencesCollection - contains collection of references defined by the inheritance chain of instance declarations.
  /// </summary>
  internal class InstanceReferencesCollection : IInstanceReferencesCollection, IEnumerable<IReference>
  {

    #region creator
    /// <summary>
    /// Initializes a new instance of the <see cref="InstanceReferencesCollection"/> class. It is empty collection of <see cref="IReference"/>.
    /// </summary>
    /// <param name="parent">The parent.</param>
    public InstanceReferencesCollection(InstanceNodeContext parent)
    {
      m_Parent = parent;
    }
    #endregion

    #region IInstanceReferencesCollection
    /// <summary>
    /// Adds the reference of an instance declaration.
    /// </summary>
    /// <param name="reference">The reference to be added.</param>
    /// <param name="referenceParent">The reference parent.</param>
    /// <param name="typeParentID">The parent identifier of the type provisioning instance declarations - prefix to the relative reference path.</param>
    public void AddReference(Reference reference, INodeDesign referenceParent, XmlQualifiedName typeParentID)
    {
      string _relativeName = referenceParent.CalculateReferenceRelativeName(reference.Wrapper.TargetId.Name);
      XmlQualifiedName id = null;
      if (string.IsNullOrEmpty(_relativeName))
        id = new XmlQualifiedName(InstanceIdentifier.AddSuffix(typeParentID.Name, reference.Wrapper.TargetId.Name), m_Parent.NodeID.Namespace);
      else
        id = new XmlQualifiedName(InstanceIdentifier.AddSuffix(typeParentID.Name, _relativeName), m_Parent.NodeID.Namespace);
      ReferenceStub rs = new ReferenceStub()
      {
        Inverse = reference.Wrapper.IsInverse,
        ReferenceType = reference.Wrapper.ReferenceType.XmlQualifiedName,
        TargetName = id
      };
      m_References.Add(rs);
    }
    #endregion

    #region private
    private InstanceNodeContext m_Parent;
    private List<IReference> m_References = new List<IReference>();
    private class ReferenceStub : IReference
    {

      #region creator
      /// <summary>
      /// Initializes a new instance of the <see cref="ReferenceStub"/> class.
      /// </summary>
      internal ReferenceStub() { }
      #endregion

      #region IReference Members
      /// <summary>
      /// Gets the type of the reference.
      /// </summary>
      /// <value>
      /// An instance of <see cref="XmlQualifiedName"/> that represents the type name of the reference.
      /// </value>
      public XmlQualifiedName ReferenceType { get; set; }
      /// <summary>
      /// Gets a value indicating whether this <see cref="IReference"/> is inverse.
      /// </summary>
      /// <value><c>true</c> if inverse; otherwise, <c>false</c>.</value>
      public bool Inverse { get; set; }
      /// <summary>
      /// Gets the name of the target.
      /// </summary>
      /// <value>
      /// An instance of <see cref="XmlQualifiedName"/> that represents the name of the target.
      /// </value>
      public XmlQualifiedName TargetName { get; set; }
      #endregion

    }
    #endregion

    #region IEnumerable
    /// <summary>
    /// Returns an enumerator that iterates through the collection.
    /// </summary>
    /// <returns>A <see cref="T:System.Collections.Generic.IEnumerator`1" /> that can be used to iterate through the collection.</returns>
    public IEnumerator<IReference> GetEnumerator()
    {
      return m_References.GetEnumerator();
    }
    /// <summary>
    /// Returns an enumerator that iterates through a collection.
    /// </summary>
    /// <returns>An <see cref="T:System.Collections.IEnumerator" /> object that can be used to iterate through the collection.</returns>
    IEnumerator IEnumerable.GetEnumerator()
    {
      return m_References.GetEnumerator();
    }
    #endregion

  }

}

