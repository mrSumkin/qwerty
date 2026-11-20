using System;
using System.Collections.Generic;

// Token: 0x020005D9 RID: 1497
public sealed class e1h : ce8
{
	// Token: 0x06002783 RID: 10115 RVA: 0x000E5A88 File Offset: 0x000E3C88
	public override string[] c6()
	{
		return new string[]
		{
			"playerRemovePsiAbility",
			"prempsi"
		};
	}

	// Token: 0x06002784 RID: 10116 RVA: 0x000E5AA4 File Offset: 0x000E3CA4
	public e1h()
	{
		base.Args.Add(new ayk(typeof(b0l), null, false));
	}

	// Token: 0x06002785 RID: 10117 RVA: 0x000E5AD4 File Offset: 0x000E3CD4
	public override lu c7(List<object> A_0)
	{
		if (A_0 != null && A_0.Count == 1)
		{
			c3n c3n = A_0[0] as c3n;
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && c3n != null)
			{
				serviceOrThrow.aqu().v().PsiAbilities.a(c3n);
				bdg.a("Player loses [prop]{0}[/prop] psionic ability", new object[]
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
