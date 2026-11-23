using System;
using System.Collections.Generic;

// Token: 0x020005E0 RID: 1504
public sealed class cpq : ce8
{
	// Token: 0x06002799 RID: 10137 RVA: 0x000E6280 File Offset: 0x000E4480
	public override string[] c6()
	{
		return new string[]
		{
			"playerGiveXp",
			"pgivexp",
			"givexp"
		};
	}

	// Token: 0x0600279A RID: 10138 RVA: 0x000E62A0 File Offset: 0x000E44A0
	public cpq()
	{
		base.Args.Add(new ayk(typeof(dq4), null, false));
	}

	// Token: 0x0600279B RID: 10139 RVA: 0x000E62D0 File Offset: 0x000E44D0
	public override lu c7(List<object> A_0)
	{
		if (A_0 != null && A_0.Count == 1)
		{
			int num = (int)A_0[0];
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null)
			{
				num = awq.a(num, null);
				bdg.a("Player gains [prop]{0}[/prop] experience points", new object[]
				{
					num
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
