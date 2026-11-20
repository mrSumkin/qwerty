using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Ouroboros.Common.Data;

// Token: 0x020004AD RID: 1197
public static class eti
{
	// Token: 0x06001E67 RID: 7783 RVA: 0x000A9780 File Offset: 0x000A7980
	public static T? Get<T>(string name, T? defaultValue = null) where T : struct
	{
		czh.a(name, "name");
		if (!eti.a)
		{
			eti.a();
		}
		object obj;
		if (eti.c.TryGetValue(name, out obj))
		{
			return obj as T?;
		}
		T? primitivePropertyValue = eti.b.GetPrimitivePropertyValue<T>(name, defaultValue);
		eti.c[name] = primitivePropertyValue;
		return primitivePropertyValue;
	}

	// Token: 0x06001E68 RID: 7784 RVA: 0x000A97E4 File Offset: 0x000A79E4
	private static void a()
	{
		try
		{
			string text = Path.Combine(d5x.e(), ei.h);
			if (File.Exists(text))
			{
				eti.b = eoq.DeserializeFromXmlFile<PropertyCollection>(text, null);
			}
			if (eti.b == null)
			{
				eti.b = new PropertyCollection();
			}
		}
		catch (Exception ex)
		{
			Trace.WriteLine(string.Format("Failed to load {0}. Error: {1}", ei.h, ex.ToString()));
			eti.b = new PropertyCollection();
		}
		finally
		{
			eti.a = true;
		}
	}

	// Token: 0x04001363 RID: 4963
	private static bool a;

	// Token: 0x04001364 RID: 4964
	private static PropertyCollection b;

	// Token: 0x04001365 RID: 4965
	private static Dictionary<string, object> c = new Dictionary<string, object>();
}
