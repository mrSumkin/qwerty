using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Ouroboros.Core.Logging;

// Token: 0x020011CB RID: 4555
public static class c1h
{
	// Token: 0x060061B4 RID: 25012 RVA: 0x002A7044 File Offset: 0x002A5244
	static c1h()
	{
		c1h.a();
	}

	// Token: 0x060061B5 RID: 25013 RVA: 0x002A7050 File Offset: 0x002A5250
	public static List<ccn> a(IEnumerable<string> A_0)
	{
		HashSet<ccn> hashSet = new HashSet<ccn>();
		if (A_0 != null)
		{
			foreach (string text in A_0)
			{
				List<ccn> list;
				if (!string.IsNullOrEmpty(text) && c1h.a.TryGetValue(text, out list))
				{
					foreach (ccn ccn in list)
					{
						hashSet.Add(ccn);
					}
				}
			}
		}
		return Enumerable.ToList<ccn>(hashSet);
	}

	// Token: 0x060061B6 RID: 25014 RVA: 0x002A7110 File Offset: 0x002A5310
	public static ccn a(string A_0)
	{
		if (!string.IsNullOrEmpty(A_0))
		{
			ccn result;
			c1h.b.TryGetValue(A_0, out result);
			return result;
		}
		return null;
	}

	// Token: 0x060061B7 RID: 25015 RVA: 0x002A713C File Offset: 0x002A533C
	private static void a()
	{
		c1h.a = new Dictionary<string, List<ccn>>();
		c1h.b = new Dictionary<string, ccn>();
		foreach (Type type in bpo.GetServiceOrThrow<ei2>().av2(new Func<Type, bool>(c1h.a.a.a)))
		{
			try
			{
				if (type.IsClass && !type.IsAbstract && type.GetConstructor(Type.EmptyTypes) != null)
				{
					ccn ccn = (ccn)Activator.CreateInstance(type);
					if (string.IsNullOrEmpty(ccn.Id))
					{
						dux.b(LogSeverity.Error, "RandomEventLibrary: Random locale event of type {0} has invalid id.", new object[]
						{
							type.AssemblyQualifiedName
						});
					}
					else if (c1h.b.ContainsKey(ccn.Id))
					{
						dux.b(LogSeverity.Error, "RandomEventLibrary: Duplicate random event id: {0}.", new object[]
						{
							ccn.Id
						});
					}
					else
					{
						c1h.b[ccn.Id] = ccn;
						foreach (string key in ccn.Categories)
						{
							List<ccn> list;
							if (!c1h.a.TryGetValue(key, out list))
							{
								list = new List<ccn>();
								c1h.a[key] = list;
							}
							list.Add(ccn);
						}
					}
				}
			}
			catch (Exception a_)
			{
				dux.a(LogSeverity.Error, a_, "RandomEventLibrary: Failed to instantiate locale random event.", new object[0]);
			}
		}
	}

	// Token: 0x0400297C RID: 10620
	private static Dictionary<string, List<ccn>> a;

	// Token: 0x0400297D RID: 10621
	private static Dictionary<string, ccn> b;

	// Token: 0x020011CC RID: 4556
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x060061BA RID: 25018 RVA: 0x002A734C File Offset: 0x002A554C
		internal bool a(Type A_0)
		{
			return typeof(ccn).IsAssignableFrom(A_0);
		}

		// Token: 0x0400297E RID: 10622
		public static readonly c1h.a a = new c1h.a();

		// Token: 0x0400297F RID: 10623
		public static Func<Type, bool> b;
	}
}
