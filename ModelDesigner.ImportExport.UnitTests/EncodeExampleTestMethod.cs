using Microsoft.VisualStudio.TestTools.UnitTesting;
using Opc.Ua;
using System;

namespace CAS.UA.Model.Designer.ImportExport.UT
{
  [TestClass]
  public class EncodeExampleUnitTest
  {
    [TestMethod]
    public void EncodeExampleTestMethod()
    {
      //define an instance of our class object, defined above.
      simpleClass mySimpleClassInstance1 = new simpleClass("String", int.MaxValue, DateTime.Now);
      //define an object that will encapsulate/extend our simple instance above
      ExtensionObject extendedSimpleClassInstance = new ExtensionObject(mySimpleClassInstance1);
      //
      //encode our class object into the stream
      Assert.Inconclusive("XmlEncoder must be initialized see UANodeSet.CreateDecoder");
      using (XmlEncoder uaEncoderInstance = new XmlEncoder(null))
        uaEncoderInstance.WriteExtensionObject("Extended1", extendedSimpleClassInstance);
    }
  }

  internal class simpleClass : IEncodeable
  {

    //fields
    public string PublicFieldNotVisible = "I should not be encoded";

    //properties
    private string stringField;
    public string StringProperty
    {
      get
      {
        return (stringField);
      }
      set
      {
        stringField = value;
      }
    }

    private int intField;
    public int IntProperty
    {
      get
      {
        return (intField);
      }
      set
      {
        intField = value;
      }
    }

    private DateTime datetimeField;
    public DateTime DatetimeProperty
    {
      get
      {
        return (datetimeField);
      }
      set
      {
        datetimeField = value;
      }
    }

    //class constructor
    public simpleClass(string StringValue, int IntValue, DateTime DateTimeValue)
    {
      StringProperty = StringValue;
      IntProperty = IntValue;
      DatetimeProperty = DateTimeValue;
    }
    public simpleClass(simpleClass SimpleClassInstance)
    {
      StringProperty = SimpleClassInstance.StringProperty;
      IntProperty = SimpleClassInstance.IntProperty;
      DatetimeProperty = SimpleClassInstance.DatetimeProperty;
    }
    #region IEncodeable Members

    public ExpandedNodeId TypeId
    {
      get
      {
        return (new ExpandedNodeId(Guid.NewGuid()));
      }
    }
    public void Encode(IEncoder encoder)
    {
      if (encoder != null)
      {
        //our simple object has 3 properies: string, int and datetime
        encoder.WriteString("StringProperty", this.StringProperty);
        encoder.WriteInt32("IntProperty", this.IntProperty);
        encoder.WriteDateTime("DateTimeProperty", this.DatetimeProperty);
      }
    }
    public void Decode(IDecoder decoder)
    {
      if (decoder != null)
      {
        this.StringProperty = decoder.ReadString("StringProperty");
        this.IntProperty = decoder.ReadInt16("IntProperty");
        this.DatetimeProperty = decoder.ReadDateTime("DateTimeProperty");
      }
    }
    public bool IsEqual(IEncodeable encodeable)
    {
      return (encodeable.Equals(this));
    }
    public ExpandedNodeId BinaryEncodingId
    {
      get { throw new NotImplementedException(); }
    }
    public ExpandedNodeId XmlEncodingId
    {
      get { throw new NotImplementedException(); }
    }
    #endregion

    #region ICloneable Members
    public object Clone()
    {
      return (new simpleClass(this));
    }
    #endregion

  }

}
