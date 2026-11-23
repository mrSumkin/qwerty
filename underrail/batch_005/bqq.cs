using System;
using System.Collections.Generic;

// Token: 0x020005D3 RID: 1491
public sealed class bqq : ce8
{
	// Token: 0x06002770 RID: 10096 RVA: 0x000E5464 File Offset: 0x000E3664
	public override string[] c6()
	{
		return new string[]
		{
			"playerTeachBlueprint",
			"pteachblueprint",
			"pgiveblueprint"
		};
	}

	// Token: 0x06002771 RID: 10097 RVA: 0x000E5488 File Offset: 0x000E3688
	public bqq()
	{
		base.Args.Add(new ayk(typeof(cw4), null, false));
	}

	// Token: 0x06002772 RID: 10098 RVA: 0x000E54B8 File Offset: 0x000E36B8
	public override lu c7(List<object> A_0)
	{
		if (A_0 != null && A_0.Count >= 1)
		{
			cwp cwp = A_0[0] as cwp;
			if (cwp != null)
			{
				cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
				if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null)
				{
					df6.a(cwp.TechnicalName, serviceOrThrow.aqu().v());
					bdg.a("Player learns [val]{0}[/val]", new object[]
					{
						cwp.Name
					});
					return null;
				}
				return null;
			}
		}
		base.b();
		return null;
	}
}
