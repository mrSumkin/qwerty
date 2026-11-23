using System;
using System.Diagnostics;
using System.IO;

// Token: 0x020004B8 RID: 1208
public static class b82
{
	// Token: 0x06001EE7 RID: 7911 RVA: 0x000AB3E4 File Offset: 0x000A95E4
	public static string a()
	{
		return b82.a;
	}

	// Token: 0x06001EE8 RID: 7912 RVA: 0x000AB3EC File Offset: 0x000A95EC
	public static void e(string A_0)
	{
		b82.b(A_0);
	}

	// Token: 0x06001EE9 RID: 7913 RVA: 0x000AB3F8 File Offset: 0x000A95F8
	public static string d(string A_0)
	{
		if (!string.IsNullOrEmpty(A_0))
		{
			string text = b82.c.a(A_0);
			if (!string.IsNullOrEmpty(text))
			{
				return text;
			}
		}
		return A_0;
	}

	// Token: 0x06001EEA RID: 7914 RVA: 0x000AB42C File Offset: 0x000A962C
	public static string c(string A_0)
	{
		if (!string.IsNullOrEmpty(A_0))
		{
			string text = b82.b.a(A_0);
			if (!string.IsNullOrEmpty(text))
			{
				return text;
			}
		}
		return string.Empty;
	}

	// Token: 0x06001EEB RID: 7915 RVA: 0x000AB464 File Offset: 0x000A9664
	private static void b(string A_0)
	{
		if (b82.a != A_0)
		{
			b82.b = null;
			b82.c = null;
			b82.a = A_0;
			if (!string.IsNullOrEmpty(b82.a))
			{
				string text = Path.Combine(bpo.GetServiceOrThrow<d67>().lf(), d5x.ap, b82.a);
				if (Directory.Exists(text))
				{
					string a_ = Path.Combine(text, ei.i);
					Path.Combine(text, ei.j);
					b82.b = b82.a(a_);
				}
			}
			if (b82.b == null)
			{
				b82.b = new der();
			}
			if (b82.c == null)
			{
				b82.c = new der();
			}
		}
	}

	// Token: 0x06001EEC RID: 7916 RVA: 0x000AB510 File Offset: 0x000A9710
	private static der a(string A_0)
	{
		if (File.Exists(A_0))
		{
			try
			{
				dmf dmf = eoq.DeserializeFromXmlFile<dmf>(A_0, null);
				if (dmf != null)
				{
					return new der(dmf);
				}
			}
			catch (Exception ex)
			{
				Trace.WriteLine(string.Format("Failed to load phrase tome from path: {0}. Error: {1}.", A_0, ex.ToString()));
			}
		}
		return null;
	}

	// Token: 0x0400139E RID: 5022
	private static string a;

	// Token: 0x0400139F RID: 5023
	private static der b;

	// Token: 0x040013A0 RID: 5024
	private static der c;
}
