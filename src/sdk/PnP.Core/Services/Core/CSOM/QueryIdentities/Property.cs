﻿using PnP.Core.Services.Core.CSOM.QueryAction;

namespace PnP.Core.Services.Core.CSOM.QueryIdentities
{
    internal class Property : Identity
    {
        internal int ParentId { get; set; }

        public override string ToString()
        {
            return $"<Property Id=\"{Id}\" ParentId=\"{ParentId}\" Name=\"{Name}\" />";
        }
    }
    internal class StaticProperty : Identity
    {
        internal string TypeId { get; set; }

        public override string ToString()
        {
            return $"<StaticProperty  Id=\"{Id}\" TypeId=\"{TypeId}\" Name=\"{Name}\" />";
        }
    }
    internal class NamedProperty
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Value { get; set; }

        public override string ToString()
        {
            string stringValue = Value != null ? CsomHelper.XmlString(Parameter.TypeSpecificHandling(Value.ToString(), Type), false) : "";
            string type = Value != null ? Type : "Null"; if (Value == null)
            {
                return $"<Property Name=\"{Name}\" Type=\"Null\" />";
            }
            return $"<Property Name=\"{Name}\" Type=\"{Type}\">{stringValue}</Property>";
        }
    }
}
