using System;
using System.Collections.Generic;

// Token: 0x020005CB RID: 1483
public sealed class ct6 : ce8
{
	// Token: 0x06002758 RID: 10072 RVA: 0x000E4A68 File Offset: 0x000E2C68
	public override string[] c6()
	{
		return new string[]
		{
			"playerSetHealth",
			"psethp"
		};
	}

	// Token: 0x06002759 RID: 10073 RVA: 0x000E4A80 File Offset: 0x000E2C80
	public ct6()
	{
		base.Args.Add(new ayk(typeof(dq4), null, false));
	}

	// Token: 0x0600275A RID: 10074 RVA: 0x000E4AB0 File Offset: 0x000E2CB0
	public override lu c7(List<object> A_0)
	{
		if (A_0 != null && A_0.Count == 1)
		{
			int num = (int)A_0[0];
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null)
			{
				serviceOrThrow.aqu().v().Defense.q().zp((float)num);
				bdg.a("Player health set to {0}", new object[]
				{
					serviceOrThrow.aqu().v().Defense.q().zo()
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
