using System;
using System.Collections.Generic;
using System.Reflection;
using Ouroboros.Core.Logging;

// Token: 0x02000719 RID: 1817
public static class c7o
{
	// Token: 0x06002F2B RID: 12075 RVA: 0x0011E070 File Offset: 0x0011C270
	public static ICollection<bv3> b()
	{
		return c7o.b.Values;
	}

	// Token: 0x06002F2C RID: 12076 RVA: 0x0011E07C File Offset: 0x0011C27C
	static c7o()
	{
		c7o.a();
	}

	// Token: 0x06002F2D RID: 12077 RVA: 0x0011E090 File Offset: 0x0011C290
	public static aw4 a(string A_0)
	{
		if (string.IsNullOrEmpty(A_0))
		{
			return null;
		}
		bv3 bv;
		c7o.b.TryGetValue(A_0, out bv);
		if (bv != null)
		{
			aw4 aw = null;
			try
			{
				aw = (Activator.CreateInstance(bv.b()) as aw4);
			}
			catch (Exception a_)
			{
				dux.a(LogSeverity.Error, a_, "Failed to create an item generator with name '{0}'.", new object[]
				{
					A_0
				});
				return null;
			}
			if (aw == null)
			{
				dux.b(LogSeverity.Error, "Failed to create an item generator with name '{0}'. Resulting instance of type '{1}' does not implement IItemGenerator interface", new object[]
				{
					A_0,
					bv.b().FullName
				});
				return null;
			}
			return aw;
		}
		dux.b(LogSeverity.Error, "Failed to create an item generator with name '{0}'.", new object[]
		{
			A_0
		});
		return null;
	}

	// Token: 0x06002F2E RID: 12078 RVA: 0x0011E14C File Offset: 0x0011C34C
	private static void a()
	{
		Assembly assembly = Assembly.Load("TimelapseVertigo.Generators");
		if (assembly == null)
		{
			dux.a(LogSeverity.CriticalError, "Failed to locate {0} assembly", new object[]
			{
				"TimelapseVertigo.Generators"
			});
		}
		foreach (Type type in assembly.GetTypes())
		{
			if (type.IsClass && !type.IsAbstract && typeof(aw4).IsAssignableFrom(type) && type.GetConstructor(Type.EmptyTypes) != null)
			{
				bv3 value = new bv3(type);
				c7o.b[type.Name] = value;
			}
		}
	}

	// Token: 0x04001A1F RID: 6687
	private const string a = "TimelapseVertigo.Generators";

	// Token: 0x04001A20 RID: 6688
	private static Dictionary<string, bv3> b = new Dictionary<string, bv3>();
}
