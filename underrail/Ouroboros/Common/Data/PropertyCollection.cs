using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading;
using System.Xml.Serialization;

namespace Ouroboros.Common.Data
{
	// Token: 0x0200221C RID: 8732
	[eiz("PC")]
	[XmlRoot("PropertyCollection")]
	[Serializable]
	public sealed class PropertyCollection : bq8, ISerializable
	{
		// Token: 0x0600CAC1 RID: 51905 RVA: 0x0047CDF4 File Offset: 0x0047AFF4
		private PropertyCollection(SerializationInfo info, StreamingContext ctx)
		{
			if (ell.b() != 0)
			{
				di7.ReadList<Property>("PC:P", ref this._Properties, info);
				return;
			}
			if (base.GetType() == typeof(PropertyCollection))
			{
				this._Properties = (List<Property>)info.GetValue("_Properties", typeof(List<Property>));
				return;
			}
			this._Properties = (List<Property>)info.GetValue("PropertyCollection+_Properties", typeof(List<Property>));
		}

		// Token: 0x0600CAC2 RID: 51906 RVA: 0x0047CE94 File Offset: 0x0047B094
		public void GetObjectData(SerializationInfo info, StreamingContext ctx)
		{
			di7.WriteList<Property>("PC:P", this._Properties, info);
		}

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x0600CAC3 RID: 51907 RVA: 0x0047CEA8 File Offset: 0x0047B0A8
		// (set) Token: 0x0600CAC4 RID: 51908 RVA: 0x0047CEB0 File Offset: 0x0047B0B0
		[XmlElement("Property")]
		public List<Property> Properties
		{
			get
			{
				return this._Properties;
			}
			set
			{
				this._Properties = value;
			}
		}

		// Token: 0x0600CAC5 RID: 51909 RVA: 0x0047CEBC File Offset: 0x0047B0BC
		public PropertyCollection()
		{
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x0600CAC6 RID: 51910 RVA: 0x0047CEDC File Offset: 0x0047B0DC
		// (remove) Token: 0x0600CAC7 RID: 51911 RVA: 0x0047CF14 File Offset: 0x0047B114
		[NonSerialized]
		public event EventHandler<PropertyChangedEventArgs> PropertyChanged;

		// Token: 0x170002E8 RID: 744
		public object this[string name]
		{
			get
			{
				return this.GetPropertyValue(name);
			}
			set
			{
				this.SetPropertyValue(name, value);
			}
		}

		// Token: 0x0600CACA RID: 51914 RVA: 0x0047CF68 File Offset: 0x0047B168
		public object GetPropertyValue(string name)
		{
			czh.a(name, "name");
			this._PropertiesLock.AcquireReaderLock(-1);
			object result;
			try
			{
				Property property = Enumerable.FirstOrDefault<Property>(Enumerable.Where<Property>(this._Properties, (Property p) => p.Name == name));
				if (property != null)
				{
					result = property.Value;
				}
				else
				{
					result = null;
				}
			}
			finally
			{
				this._PropertiesLock.ReleaseReaderLock();
			}
			return result;
		}

		// Token: 0x0600CACB RID: 51915 RVA: 0x0047CFF4 File Offset: 0x0047B1F4
		public T GetClassPropertyValue<T>(string name) where T : class
		{
			return this.GetPropertyValue(name) as T;
		}

		// Token: 0x0600CACC RID: 51916 RVA: 0x0047D008 File Offset: 0x0047B208
		public T? GetPrimitivePropertyValue<T>(string name, T? defaultValue = null) where T : struct
		{
			object propertyValue = this.GetPropertyValue(name);
			if (propertyValue is T)
			{
				return new T?((T)((object)propertyValue));
			}
			return defaultValue;
		}

		// Token: 0x0600CACD RID: 51917 RVA: 0x0047D038 File Offset: 0x0047B238
		public IEnumerable<Property> CloneAllProperties()
		{
			this._PropertiesLock.AcquireReaderLock(-1);
			IEnumerable<Property> result;
			try
			{
				List<Property> list = new List<Property>();
				foreach (Property property in this._Properties)
				{
					list.Add(property.Clone() as Property);
				}
				result = list;
			}
			finally
			{
				this._PropertiesLock.ReleaseReaderLock();
			}
			return result;
		}

		// Token: 0x0600CACE RID: 51918 RVA: 0x0047D0D0 File Offset: 0x0047B2D0
		public PropertyCollection Clone()
		{
			PropertyCollection propertyCollection = new PropertyCollection();
			propertyCollection._Properties.AddRange(this.CloneAllProperties());
			return propertyCollection;
		}

		// Token: 0x0600CACF RID: 51919 RVA: 0x0047D0E8 File Offset: 0x0047B2E8
		public bool SetPropertyValue(string name, object value)
		{
			czh.a(name, "name");
			this._PropertiesLock.AcquireWriterLock(-1);
			bool result;
			try
			{
				Property property = Enumerable.FirstOrDefault<Property>(Enumerable.Where<Property>(this._Properties, (Property p) => p.Name == name));
				if (property != null)
				{
					bool flag = !object.Equals(property.Value, value);
					property.Value = value;
					if (flag && this.PropertyChanged != null)
					{
						this.PropertyChanged(this, new PropertyChangedEventArgs(name));
					}
					result = true;
				}
				else
				{
					property = new Property(name, value);
					this._Properties.Add(property);
					if (this.PropertyChanged != null)
					{
						this.PropertyChanged(this, new PropertyChangedEventArgs(name));
					}
					result = false;
				}
			}
			finally
			{
				this._PropertiesLock.ReleaseWriterLock();
			}
			return result;
		}

		// Token: 0x0600CAD0 RID: 51920 RVA: 0x0047D1E4 File Offset: 0x0047B3E4
		public bool HasProperty(string name)
		{
			this._PropertiesLock.AcquireReaderLock(-1);
			bool result;
			try
			{
				result = Enumerable.Any<Property>(this._Properties, (Property p) => p.Name == name);
			}
			finally
			{
				this._PropertiesLock.ReleaseReaderLock();
			}
			return result;
		}

		// Token: 0x0600CAD1 RID: 51921 RVA: 0x0047D244 File Offset: 0x0047B444
		public bool RemoveProperty(string name)
		{
			czh.a(name, "name");
			this._PropertiesLock.AcquireWriterLock(-1);
			bool result;
			try
			{
				Property property = Enumerable.FirstOrDefault<Property>(Enumerable.Where<Property>(this._Properties, (Property p) => p.Name == name));
				if (property != null)
				{
					this._Properties.Remove(property);
					result = true;
				}
				else
				{
					result = false;
				}
			}
			finally
			{
				this._PropertiesLock.ReleaseWriterLock();
			}
			return result;
		}

		// Token: 0x0600CAD2 RID: 51922 RVA: 0x0047D2D8 File Offset: 0x0047B4D8
		public void Clear()
		{
			this._PropertiesLock.AcquireWriterLock(-1);
			try
			{
				this._Properties.Clear();
			}
			finally
			{
				this._PropertiesLock.ReleaseWriterLock();
			}
		}

		// Token: 0x0600CAD3 RID: 51923 RVA: 0x0047D320 File Offset: 0x0047B520
		public void WriteToObject(object target, bool throwOnError = true)
		{
			czh.a(target, "target");
			foreach (Property property in this._Properties)
			{
				if (!string.IsNullOrEmpty(property.Name))
				{
					try
					{
						boo.a(target, property.Name, property.Value);
					}
					catch
					{
						if (throwOnError)
						{
							throw;
						}
					}
				}
			}
		}

		// Token: 0x0600CAD4 RID: 51924 RVA: 0x0047D3C0 File Offset: 0x0047B5C0
		[OnDeserialized]
		private void OnDeserialized(StreamingContext context)
		{
			this._PropertiesLock = new ReaderWriterLock();
		}

		// Token: 0x0600CAD5 RID: 51925 RVA: 0x0047D3D0 File Offset: 0x0047B5D0
		public override string ToString()
		{
			return "Count: " + ((this._Properties != null) ? this._Properties.Count.ToString() : "0");
		}

		// Token: 0x04004A27 RID: 18983
		[NonSerialized]
		private ReaderWriterLock _PropertiesLock = new ReaderWriterLock();

		// Token: 0x04004A28 RID: 18984
		private List<Property> _Properties = new List<Property>();
	}
}
