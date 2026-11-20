using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;

// Token: 0x020001C1 RID: 449
public static class b6l
{
	// Token: 0x06000D54 RID: 3412 RVA: 0x00038CF8 File Offset: 0x00036EF8
	static b6l()
	{
		b6l.a();
	}

	// Token: 0x06000D55 RID: 3413 RVA: 0x00038D00 File Offset: 0x00036F00
	public static cmk a(string A_0)
	{
		if (!string.IsNullOrEmpty(A_0))
		{
			cmk result;
			b6l.a.TryGetValue(A_0, out result);
			return result;
		}
		return null;
	}

	// Token: 0x06000D56 RID: 3414 RVA: 0x00038D2C File Offset: 0x00036F2C
	private static void a()
	{
		b6l.a = new Dictionary<string, cmk>();
		foreach (Type type in bpo.GetServiceOrThrow<ei2>().av2(new Func<Type, bool>(b6l.a.a.a)))
		{
			try
			{
				if (type.IsClass && !type.IsAbstract && type.GetConstructor(Type.EmptyTypes) != null)
				{
					cmk value = (cmk)Activator.CreateInstance(type);
					aut aut = Enumerable.FirstOrDefault<object>(type.GetCustomAttributes(typeof(aut), false)) as aut;
					if (aut != null && !string.IsNullOrEmpty(aut.a()))
					{
						b6l.a[aut.a()] = value;
					}
				}
			}
			catch (Exception ex)
			{
				Trace.WriteLine(string.Format("Error occurred while initiating delayed effect of type: {0}. Exception: {1}", type.FullName, ex.ToString()));
			}
		}
	}

	// Token: 0x040007E1 RID: 2017
	private static Dictionary<string, cmk> a;

	// Token: 0x020001C2 RID: 450
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x06000D59 RID: 3417 RVA: 0x00038E74 File Offset: 0x00037074
		internal bool a(Type A_0)
		{
			return typeof(cmk).IsAssignableFrom(A_0);
		}

		// Token: 0x040007E2 RID: 2018
		public static readonly b6l.a a = new b6l.a();

		// Token: 0x040007E3 RID: 2019
		public static Func<Type, bool> b;
	}
}
