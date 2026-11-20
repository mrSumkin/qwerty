using System;
using System.Collections.Generic;

// Token: 0x020005DC RID: 1500
public sealed class cqs : ce8
{
	// Token: 0x0600278C RID: 10124 RVA: 0x000E5D58 File Offset: 0x000E3F58
	public override string[] c6()
	{
		return new string[]
		{
			"playerGiveSpecialAttack",
			"pgivesatt"
		};
	}

	// Token: 0x0600278D RID: 10125 RVA: 0x000E5D74 File Offset: 0x000E3F74
	public cqs()
	{
		base.Args.Add(new ayk(typeof(b0l), null, false));
	}

	// Token: 0x0600278E RID: 10126 RVA: 0x000E5DA4 File Offset: 0x000E3FA4
	public override lu c7(List<object> A_0)
	{
		if (A_0 != null && A_0.Count == 1)
		{
			c3n c3n = A_0[0] as c3n;
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && c3n != null)
			{
				serviceOrThrow.aqu().v().SpecialAttacks.b(c3n);
				bdg.a("Player gains [prop]{0}[/prop] special attack", new object[]
				{
					c3n.Name
				});
			}
			else
			{
				bdg.a("[error]Could not find player character", new object[0]);
			}
			return null;
		}
		base.b();
		return null;
	}
}
