using System;
using System.Collections.Generic;
using System.IO;

// Token: 0x02000106 RID: 262
public static class dk2
{
	// Token: 0x06000634 RID: 1588 RVA: 0x0001AE28 File Offset: 0x00019028
	public static bool f()
	{
		if (dk2.a == null)
		{
			dk2.a = new bool?(dk2.b("xpbl"));
		}
		return dk2.a.Value;
	}

	// Token: 0x06000635 RID: 1589 RVA: 0x0001AE58 File Offset: 0x00019058
	public static bool e()
	{
		if (dk2.b == null)
		{
			dk2.b = new bool?(dk2.b("xphw"));
		}
		return dk2.b.Value;
	}

	// Token: 0x06000636 RID: 1590 RVA: 0x0001AE88 File Offset: 0x00019088
	public static int d()
	{
		dk2.a();
		return dk2.g.Count;
	}

	// Token: 0x06000637 RID: 1591 RVA: 0x0001AE9C File Offset: 0x0001909C
	public static int c()
	{
		dk2.a();
		return dk2.h.Count;
	}

	// Token: 0x06000638 RID: 1592 RVA: 0x0001AEB0 File Offset: 0x000190B0
	static dk2()
	{
		dk2.d = new List<string>();
		dk2.c.Add("xpbl");
		dk2.d.Add("xpbl");
		dk2.e["xpbl"] = "Expedition";
		dk2.f["xpbl"] = "Expedition";
		dk2.c.Add("xphw");
		dk2.e["xphw"] = "Heavy Duty";
		dk2.f["xphw"] = "Heavy Duty";
	}

	// Token: 0x06000639 RID: 1593 RVA: 0x0001AF64 File Offset: 0x00019164
	public static HashSet<string> b()
	{
		dk2.a();
		return dk2.g;
	}

	// Token: 0x0600063A RID: 1594 RVA: 0x0001AF74 File Offset: 0x00019174
	public static string d(string A_0)
	{
		string result;
		if (dk2.e.TryGetValue(A_0, out result))
		{
			return result;
		}
		return "";
	}

	// Token: 0x0600063B RID: 1595 RVA: 0x0001AF9C File Offset: 0x0001919C
	public static string c(string A_0)
	{
		string result;
		if (dk2.f.TryGetValue(A_0, out result))
		{
			return result;
		}
		return "";
	}

	// Token: 0x0600063C RID: 1596 RVA: 0x0001AFC4 File Offset: 0x000191C4
	public static bool b(string A_0)
	{
		if (A_0 != null)
		{
			dk2.a();
			return dk2.g.Contains(A_0.ToLowerInvariant());
		}
		return false;
	}

	// Token: 0x0600063D RID: 1597 RVA: 0x0001AFE8 File Offset: 0x000191E8
	private static void a()
	{
		if (dk2.g == null)
		{
			dk2.g = new HashSet<string>();
			foreach (string text in dk2.c)
			{
				if (dk2.a(text))
				{
					dk2.g.Add(text);
				}
			}
		}
		if (dk2.h == null)
		{
			dk2.h = new HashSet<string>();
			foreach (string text2 in dk2.d)
			{
				if (dk2.a(text2))
				{
					dk2.h.Add(text2);
				}
			}
		}
	}

	// Token: 0x0600063E RID: 1598 RVA: 0x0001B0D0 File Offset: 0x000192D0
	private static bool a(string A_0)
	{
		return File.Exists(Path.Combine(bpo.GetServiceOrThrow<d67>().lf(), d7i.aj, A_0));
	}

	// Token: 0x04000502 RID: 1282
	private static bool? a;

	// Token: 0x04000503 RID: 1283
	private static bool? b;

	// Token: 0x04000504 RID: 1284
	private static List<string> c = new List<string>();

	// Token: 0x04000505 RID: 1285
	private static List<string> d;

	// Token: 0x04000506 RID: 1286
	private static Dictionary<string, string> e = new Dictionary<string, string>();

	// Token: 0x04000507 RID: 1287
	private static Dictionary<string, string> f = new Dictionary<string, string>();

	// Token: 0x04000508 RID: 1288
	private static HashSet<string> g;

	// Token: 0x04000509 RID: 1289
	private static HashSet<string> h;

	// Token: 0x0400050A RID: 1290
	public const string i = "xpbl";

	// Token: 0x0400050B RID: 1291
	public const string j = "xphw";
}
