using System;
using System.Collections.Generic;

// Token: 0x020000E6 RID: 230
public sealed class der
{
	// Token: 0x0600050A RID: 1290 RVA: 0x00016B4C File Offset: 0x00014D4C
	public der()
	{
		der.a = new Dictionary<string, string>();
	}

	// Token: 0x0600050B RID: 1291 RVA: 0x00016B60 File Offset: 0x00014D60
	public der(dmf A_0)
	{
		czh.a(A_0, "book");
		this.a(A_0);
	}

	// Token: 0x0600050C RID: 1292 RVA: 0x00016B7C File Offset: 0x00014D7C
	public string a(string A_0)
	{
		string result;
		if (der.a.TryGetValue(A_0, out result))
		{
			return result;
		}
		return string.Empty;
	}

	// Token: 0x0600050D RID: 1293 RVA: 0x00016BA4 File Offset: 0x00014DA4
	private void a(dmf A_0)
	{
		der.a = new Dictionary<string, string>();
		foreach (ehq ehq in A_0.a())
		{
			if (!string.IsNullOrEmpty(ehq.d()))
			{
				der.a[ehq.d()] = (ehq.b() ?? "");
			}
		}
	}

	// Token: 0x04000479 RID: 1145
	private static Dictionary<string, string> a;
}
