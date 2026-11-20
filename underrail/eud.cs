using System;
using System.Collections.Generic;

// Token: 0x020005D1 RID: 1489
public sealed class eud : ce8
{
	// Token: 0x0600276A RID: 10090 RVA: 0x000E517C File Offset: 0x000E337C
	public override string[] c6()
	{
		return new string[]
		{
			"playerSetStatusEffect",
			"psetse"
		};
	}

	// Token: 0x0600276B RID: 10091 RVA: 0x000E5198 File Offset: 0x000E3398
	public eud()
	{
		base.Args.Add(new ayk(typeof(a33), null, false));
		base.Args.Add(new ayk(typeof(dq4), "duration", true));
		base.Args.Add(new ayk(typeof(dq4), "stacks", true));
	}

	// Token: 0x0600276C RID: 10092 RVA: 0x000E5208 File Offset: 0x000E3408
	public override lu c7(List<object> A_0)
	{
		if (A_0 != null && A_0.Count >= 1)
		{
			els els = A_0[0] as els;
			if (els != null)
			{
				if (A_0.Count > 1)
				{
					object obj = A_0[1];
					if (obj is int)
					{
						int a_ = (int)obj;
						els.Duration = a_;
					}
				}
				if (A_0.Count > 2)
				{
					object obj = A_0[2];
					if (obj is int)
					{
						int a_2 = (int)obj;
						els.Stacks = a_2;
					}
				}
				cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
				if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null)
				{
					serviceOrThrow.aqu().v().StatusEffects.a(els, false, false, false);
					bdg.a("Player gains [prop]{0}[/prop] status effect for {1}", new object[]
					{
						els.Name,
						(els.Duration > 0) ? els.Duration.ToString() : "ever"
					});
				}
				else
				{
					bdg.a("[error]Could not find player character", new object[0]);
				}
			}
			return null;
		}
		base.b();
		return null;
	}
}
