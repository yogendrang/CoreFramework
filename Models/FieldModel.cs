using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Runtime.Serialization;

using CoreFramework.Utils;

namespace CoreFramework.Models
{
    [Serializable()]
    public class FieldModel : ISerializable
    {

        private string fieldName;
        private string fieldAliasName;
        private Type fieldType;
        private bool isFieldComplex;

        protected FieldModel(SerializationInfo info, StreamingContext ctx){
            this.fieldName = (string)info.GetValue("fieldName", typeof(string));
            this.fieldType = (Type) info.GetValue("fieldType", typeof(Type));
        }

        public FieldModel(string fieldName, Type fieldType)
        {
            this.fieldName = fieldName;
            this.fieldType = fieldType;
            this.isFieldComplex = TypeUtil.isComplexType(fieldType);
        }

        public string getFieldName()
        {
            return this.fieldName;
        }

        public Type getFieldType()
        {
            return this.fieldType;
        }

        public bool isComplexField()
        {
            return this.isFieldComplex;
        }

        public XmlReader generateXml()
        {
            return null;
        }

        public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
        {
            info.AddValue("fieldName", this.fieldName);
            info.AddValue("fieldType", this.fieldType);
        }
    }
}
