using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Ouroboros.Common.Data
{
	// Token: 0x0200221B RID: 8731
	[eiz("P")]
	[XmlRoot("Property")]
	[Serializable]
	public sealed class Property : ICloneable, ISerializable
	{
		// Token: 0x0600CAB4 RID: 51892 RVA: 0x0047CC00 File Offset: 0x0047AE00
		private Property(SerializationInfo info, StreamingContext ctx)
		{
			if (ell.b() != 0)
			{
				this._Name = info.GetString("P:N");
				this._Value = info.GetValue("P:V", typeof(object));
				return;
			}
			if (base.GetType() == typeof(Property))
			{
				this._Name = info.GetString("_Name");
				this._Value = info.GetValue("_Value", typeof(object));
				return;
			}
			this._Name = info.GetString("Property+_Name");
			this._Value = info.GetValue("Property+_Value", typeof(object));
		}

		// Token: 0x0600CAB5 RID: 51893 RVA: 0x0047CCC0 File Offset: 0x0047AEC0
		public void GetObjectData(SerializationInfo info, StreamingContext ctx)
		{
			info.AddValue("P:N", this._Name);
			info.AddValue("P:V", this._Value);
		}

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x0600CAB6 RID: 51894 RVA: 0x0047CCE4 File Offset: 0x0047AEE4
		// (set) Token: 0x0600CAB7 RID: 51895 RVA: 0x0047CCEC File Offset: 0x0047AEEC
		[XmlAttribute("Name")]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				this._Name = value;
			}
		}

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x0600CAB8 RID: 51896 RVA: 0x0047CCF8 File Offset: 0x0047AEF8
		// (set) Token: 0x0600CAB9 RID: 51897 RVA: 0x0047CD00 File Offset: 0x0047AF00
		[XmlElement("Value")]
		public object Value
		{
			get
			{
				return this._Value;
			}
			set
			{
				this._Value = value;
			}
		}

		// Token: 0x0600CABA RID: 51898 RVA: 0x0047CD0C File Offset: 0x0047AF0C
		public Property()
		{
		}

		// Token: 0x0600CABB RID: 51899 RVA: 0x0047CD14 File Offset: 0x0047AF14
		public Property(string name, object value)
		{
			this._Name = name;
			this._Value = value;
		}

		// Token: 0x0600CABC RID: 51900 RVA: 0x0047CD30 File Offset: 0x0047AF30
		public object Clone()
		{
			Property property = new Property();
			property.Name = this.Name;
			ICloneable cloneable = this.Value as ICloneable;
			if (cloneable != null)
			{
				property.Value = cloneable.Clone();
			}
			else
			{
				property.Value = this.Value;
			}
			return property;
		}

		// Token: 0x0600CABD RID: 51901 RVA: 0x0047CD80 File Offset: 0x0047AF80
		public override bool Equals(object obj)
		{
			bool result = false;
			Property property = obj as Property;
			if (property != null)
			{
				result = this.Equals(property);
			}
			return result;
		}

		// Token: 0x0600CABE RID: 51902 RVA: 0x0047CDA8 File Offset: 0x0047AFA8
		public bool Equals(Property other)
		{
			return this.Name == other.Name;
		}

		// Token: 0x0600CABF RID: 51903 RVA: 0x0047CDBC File Offset: 0x0047AFBC
		public override int GetHashCode()
		{
			if (this.Name == null)
			{
				return 0;
			}
			return this.Name.GetHashCode();
		}

		// Token: 0x0600CAC0 RID: 51904 RVA: 0x0047CDD8 File Offset: 0x0047AFD8
		public override string ToString()
		{
			return string.Format("{0} = {1}", this.Name, this.Value);
		}

		// Token: 0x04004A25 RID: 18981
		private string _Name;

		// Token: 0x04004A26 RID: 18982
		private object _Value;
	}
}
