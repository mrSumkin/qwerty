using System;
using System.Collections.Generic;

// Token: 0x020005DA RID: 1498
public sealed class ec : ce8
{
	// Token: 0x06002786 RID: 10118 RVA: 0x000E5B78 File Offset: 0x000E3D78
	public override string[] c6()
	{
		return new string[]
		{
			"playerGivePsiAbility",
			"pgivepsi"
		};
	}

	// Token: 0x06002787 RID: 10119 RVA: 0x000E5B94 File Offset: 0x000E3D94
	public ec()
	{
		base.Args.Add(new ayk(typeof(b0l), null, false));
	}

	// Token: 0x06002788 RID: 10120 RVA: 0x000E5BC4 File Offset: 0x000E3DC4
	public override lu c7(List<object> A_0)
	{
		if (A_0 != null && A_0.Count == 1)
		{
			c3n c3n = A_0[0] as c3n;
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && c3n != null)
			{
				serviceOrThrow.aqu().v().PsiAbilities.b(c3n);
				bdg.a("Player gains [prop]{0}[/prop] psionic ability", new object[]
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
