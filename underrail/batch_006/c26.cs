using System;
using System.Collections.Generic;

// Token: 0x020005C8 RID: 1480
public sealed class c26 : ce8
{
	// Token: 0x06002749 RID: 10057 RVA: 0x000E4500 File Offset: 0x000E2700
	public override string[] c6()
	{
		return new string[]
		{
			"godmode",
			"godmanmode"
		};
	}

	// Token: 0x0600274A RID: 10058 RVA: 0x000E4518 File Offset: 0x000E2718
	public c26()
	{
		base.Args.Add(new ayk(typeof(c2v), null, false));
	}

	// Token: 0x0600274B RID: 10059 RVA: 0x000E4548 File Offset: 0x000E2748
	public override lu c7(List<object> A_0)
	{
		if (A_0 != null && A_0.Count == 1)
		{
			bool flag = (bool)A_0[0];
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null)
			{
				if (flag)
				{
					serviceOrThrow.aqu().v().AttributesBase |= d8o.v;
				}
				else
				{
					serviceOrThrow.aqu().v().AttributesBase ^= d8o.v;
				}
				serviceOrThrow.aqu().v().bl();
				bdg.a("Godmode set to [val]{0}[/val]", new object[]
				{
					flag
				});
			}
		}
		else
		{
			base.b();
		}
		return null;
	}
}
