using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using Ouroboros.Common.Data;

// Token: 0x020000E7 RID: 231
[DefaultMember("Item")]
public sealed class dpn : bq8
{
	// Token: 0x0600050E RID: 1294 RVA: 0x00016C34 File Offset: 0x00014E34
	public List<bq8> a()
	{
		return this.b;
	}

	// Token: 0x0600050F RID: 1295 RVA: 0x00016C3C File Offset: 0x00014E3C
	public dpn(bq8 A_0, params bq8[] A_1)
	{
		czh.a(A_0, "primarySource");
		this.a = A_0;
		if (A_1 != null)
		{
			this.b = new List<bq8>(A_1);
			return;
		}
		this.b = new List<bq8>();
	}

	// Token: 0x06000510 RID: 1296 RVA: 0x00016C74 File Offset: 0x00014E74
	public List<Property> get_Properties()
	{
		return new List<Property>();
	}

	// Token: 0x06000511 RID: 1297 RVA: 0x00016C7C File Offset: 0x00014E7C
	public void set_Properties(List<Property> value)
	{
	}

	// Token: 0x06000512 RID: 1298 RVA: 0x00016C84 File Offset: 0x00014E84
	public object get_Item(string name)
	{
		object obj = this.a.get_Item(name);
		if (obj == null)
		{
			foreach (bq8 bq in this.b)
			{
				obj = bq.get_Item(name);
				if (obj != null)
				{
					break;
				}
			}
		}
		return obj;
	}

	// Token: 0x06000513 RID: 1299 RVA: 0x00016CFC File Offset: 0x00014EFC
	public void set_Item(string name, object value)
	{
		this.a.set_Item(name, value);
	}

	// Token: 0x06000514 RID: 1300 RVA: 0x00016D0C File Offset: 0x00014F0C
	public IEnumerable<Property> CloneAllProperties()
	{
		List<Property> list = new List<Property>();
		list.AddRange(this.a.CloneAllProperties());
		foreach (bq8 bq in this.b)
		{
			list.AddRange(bq.CloneAllProperties());
		}
		return list;
	}

	// Token: 0x06000515 RID: 1301 RVA: 0x00016D84 File Offset: 0x00014F84
	public T GetClassPropertyValue<T>(string name) where T : class
	{
		T classPropertyValue = this.a.GetClassPropertyValue<T>(name);
		if (classPropertyValue == null)
		{
			foreach (bq8 bq in this.b)
			{
				classPropertyValue = bq.GetClassPropertyValue<T>(name);
				if (classPropertyValue != null)
				{
					return classPropertyValue;
				}
			}
			return classPropertyValue;
		}
		return classPropertyValue;
	}

	// Token: 0x06000516 RID: 1302 RVA: 0x00016E0C File Offset: 0x0001500C
	public T? GetPrimitivePropertyValue<T>(string name, T? defaultValue = null) where T : struct
	{
		T? primitivePropertyValue = this.a.GetPrimitivePropertyValue<T>(name, defaultValue);
		if (primitivePropertyValue == null)
		{
			foreach (bq8 bq in this.b)
			{
				primitivePropertyValue = bq.GetPrimitivePropertyValue<T>(name, defaultValue);
				if (primitivePropertyValue != null)
				{
					return primitivePropertyValue;
				}
			}
			return primitivePropertyValue;
		}
		return primitivePropertyValue;
	}

	// Token: 0x06000517 RID: 1303 RVA: 0x00016E98 File Offset: 0x00015098
	public object GetPropertyValue(string name)
	{
		object propertyValue = this.a.GetPropertyValue(name);
		if (propertyValue == null)
		{
			foreach (bq8 bq in this.b)
			{
				propertyValue = bq.GetPropertyValue(name);
				if (propertyValue != null)
				{
					return propertyValue;
				}
			}
			return propertyValue;
		}
		return propertyValue;
	}

	// Token: 0x06000518 RID: 1304 RVA: 0x00016F14 File Offset: 0x00015114
	public bool HasProperty(string name)
	{
		bool flag = this.a.HasProperty(name);
		if (!flag)
		{
			foreach (bq8 bq in this.b)
			{
				flag = bq.HasProperty(name);
				if (flag)
				{
					break;
				}
			}
		}
		return flag;
	}

	// Token: 0x06000519 RID: 1305 RVA: 0x00016F8C File Offset: 0x0001518C
	[CompilerGenerated]
	public void add_PropertyChanged(EventHandler<PropertyChangedEventArgs> value)
	{
		EventHandler<PropertyChangedEventArgs> eventHandler = this.c;
		EventHandler<PropertyChangedEventArgs> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<PropertyChangedEventArgs> value2 = (EventHandler<PropertyChangedEventArgs>)Delegate.Combine(eventHandler2, value);
			eventHandler = Interlocked.CompareExchange<EventHandler<PropertyChangedEventArgs>>(ref this.c, value2, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x0600051A RID: 1306 RVA: 0x00016FC4 File Offset: 0x000151C4
	[CompilerGenerated]
	public void remove_PropertyChanged(EventHandler<PropertyChangedEventArgs> value)
	{
		EventHandler<PropertyChangedEventArgs> eventHandler = this.c;
		EventHandler<PropertyChangedEventArgs> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<PropertyChangedEventArgs> value2 = (EventHandler<PropertyChangedEventArgs>)Delegate.Remove(eventHandler2, value);
			eventHandler = Interlocked.CompareExchange<EventHandler<PropertyChangedEventArgs>>(ref this.c, value2, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x0600051B RID: 1307 RVA: 0x00016FFC File Offset: 0x000151FC
	public bool RemoveProperty(string name)
	{
		return this.a.RemoveProperty(name);
	}

	// Token: 0x0600051C RID: 1308 RVA: 0x0001700C File Offset: 0x0001520C
	public bool SetPropertyValue(string name, object value)
	{
		bool result = this.a.SetPropertyValue(name, value);
		if (this.c != null)
		{
			this.c(this, new PropertyChangedEventArgs(name));
		}
		return result;
	}

	// Token: 0x0400047A RID: 1146
	private bq8 a;

	// Token: 0x0400047B RID: 1147
	private List<bq8> b;

	// Token: 0x0400047C RID: 1148
	[CompilerGenerated]
	private EventHandler<PropertyChangedEventArgs> c;
}
