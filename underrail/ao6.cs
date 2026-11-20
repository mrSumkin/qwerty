using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using Ouroboros.Core.Logging;

// Token: 0x020018E7 RID: 6375
public static class ao6
{
	// Token: 0x0600870B RID: 34571 RVA: 0x0037E4D4 File Offset: 0x0037C6D4
	public static amf c(string A_0)
	{
		if (A_0 != null)
		{
			return ao6.b(A_0.ToLowerInvariant());
		}
		return null;
	}

	// Token: 0x0600870C RID: 34572 RVA: 0x0037E4EC File Offset: 0x0037C6EC
	public static List<string> b()
	{
		if (ao6.b == null)
		{
			ao6.b = ao6.a();
		}
		return new List<string>(ao6.b);
	}

	// Token: 0x0600870D RID: 34573 RVA: 0x0037E50C File Offset: 0x0037C70C
	private static amf b(string A_0)
	{
		if (ao6.a.ContainsKey(A_0))
		{
			return ao6.a[A_0];
		}
		amf amf = ao6.a(A_0);
		ao6.a[A_0] = amf;
		return amf;
	}

	// Token: 0x0600870E RID: 34574 RVA: 0x0037E54C File Offset: 0x0037C74C
	private static amf a(string A_0)
	{
		d67 serviceOrThrow = bpo.GetServiceOrThrow<d67>();
		amf result = null;
		try
		{
			result = amf.a(Path.Combine(serviceOrThrow.lf(), Path.Combine(d5x.aj, A_0 + "." + amf.a)));
		}
		catch (Exception ex)
		{
			dux.b(LogSeverity.Error, "Failed to load vehicle definition '{0}'. Exception: {1}", new object[]
			{
				A_0,
				ex.ToString()
			});
		}
		return result;
	}

	// Token: 0x0600870F RID: 34575 RVA: 0x0037E5C8 File Offset: 0x0037C7C8
	private static List<string> a()
	{
		List<string> list = new List<string>();
		d67 service = bpo.GetService<d67>();
		if (service != null)
		{
			string text = Path.Combine(service.lf(), d5x.ak);
			if (Directory.Exists(text))
			{
				foreach (string text2 in Directory.GetFiles(text, "*.v", 1))
				{
					if (text2.Length > text.Length)
					{
						string text3 = text2.Substring(text.Length);
						if (text3.StartsWith("\\") && text3.Length > 1)
						{
							text3 = text3.Substring(1);
						}
						if (text3.Length > 2)
						{
							string item = text3.Substring(0, text3.Length - 2);
							list.Add(item);
						}
					}
				}
			}
		}
		return Enumerable.ToList<string>(Enumerable.OrderBy<string, string>(list, new Func<string, string>(ao6.a.a.a)));
	}

	// Token: 0x04003495 RID: 13461
	private static Dictionary<string, amf> a = new Dictionary<string, amf>();

	// Token: 0x04003496 RID: 13462
	private static List<string> b;

	// Token: 0x020018E8 RID: 6376
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x06008713 RID: 34579 RVA: 0x0037E6F0 File Offset: 0x0037C8F0
		internal string a(string A_0)
		{
			return A_0;
		}

		// Token: 0x04003497 RID: 13463
		public static readonly ao6.a a = new ao6.a();

		// Token: 0x04003498 RID: 13464
		public static Func<string, string> b;
	}
}
