using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using Ouroboros.Common.Data;

// Token: 0x020000E8 RID: 232
[eiz("iPC")]
[DefaultMember("Item")]
public interface bq8
{
	// Token: 0x0600051D RID: 1309
	List<Property> get_Properties();

	// Token: 0x0600051E RID: 1310
	void set_Properties(List<Property> value);

	// Token: 0x0600051F RID: 1311
	[CompilerGenerated]
	void add_PropertyChanged(EventHandler<PropertyChangedEventArgs> value);

	// Token: 0x06000520 RID: 1312
	[CompilerGenerated]
	void remove_PropertyChanged(EventHandler<PropertyChangedEventArgs> value);

	// Token: 0x06000521 RID: 1313
	object get_Item(string name);

	// Token: 0x06000522 RID: 1314
	void set_Item(string name, object value);

	// Token: 0x06000523 RID: 1315
	IEnumerable<Property> CloneAllProperties();

	// Token: 0x06000524 RID: 1316
	T GetClassPropertyValue<T>(string name) where T : class;

	// Token: 0x06000525 RID: 1317
	T? GetPrimitivePropertyValue<T>(string name, T? defaultValue = null) where T : struct;

	// Token: 0x06000526 RID: 1318
	object GetPropertyValue(string name);

	// Token: 0x06000527 RID: 1319
	bool HasProperty(string name);

	// Token: 0x06000528 RID: 1320
	bool RemoveProperty(string name);

	// Token: 0x06000529 RID: 1321
	bool SetPropertyValue(string name, object value);
}
