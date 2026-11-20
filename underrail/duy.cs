using System;
using System.Collections.Generic;

// Token: 0x020005D7 RID: 1495
public sealed class duy : ce8
{
	// Token: 0x0600277D RID: 10109 RVA: 0x000E58AC File Offset: 0x000E3AAC
	public override string[] c6()
	{
		return new string[]
		{
			"playerRemoveSpecialAttack",
			"premsatt"
		};
	}

	// Token: 0x0600277E RID: 10110 RVA: 0x000E58C4 File Offset: 0x000E3AC4
	public duy()
	{
		base.Args.Add(new ayk(typeof(b0l), null, false));
	}

	// Token: 0x0600277F RID: 10111 RVA: 0x000E58F4 File Offset: 0x000E3AF4
	public override lu c7(List<object> A_0)
	{
		if (A_0 != null && A_0.Count == 1)
		{
			c3n c3n = A_0[0] as c3n;
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && c3n != null)
			{
				serviceOrThrow.aqu().v().SpecialAttacks.a(c3n);
				bdg.a("Player loses [prop]{0}[/prop] special attack", new object[]
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
