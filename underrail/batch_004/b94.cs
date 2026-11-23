using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;

// Token: 0x02000504 RID: 1284
public static class b94
{
	// Token: 0x06002133 RID: 8499 RVA: 0x000B1C14 File Offset: 0x000AFE14
	public static List<bph> a(coh A_0)
	{
		List<bph> list = new List<bph>
		{
			new bph(new d22(b94.a(), adi.ag[A_0.Definition.bc()]), A_0.Definition.az(), null)
		};
		if (A_0.Stacks > 1)
		{
			list.Add(new bph(new d22(b94.a(), Color.White), (A_0.Stacks > 1) ? (" (" + A_0.Stacks.ToString() + ")") : string.Empty, null));
		}
		return list;
	}

	// Token: 0x06002134 RID: 8500 RVA: 0x000B1CB8 File Offset: 0x000AFEB8
	public static string a()
	{
		if (egg.v)
		{
			return egg.n;
		}
		return egg.ak;
	}
}
