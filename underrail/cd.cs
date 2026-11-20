using System;
using System.Collections.Generic;

// Token: 0x020005DB RID: 1499
public sealed class cd : ce8
{
	// Token: 0x06002789 RID: 10121 RVA: 0x000E5C68 File Offset: 0x000E3E68
	public override string[] c6()
	{
		return new string[]
		{
			"playerGiveSpecialAbility",
			"pgivesab"
		};
	}

	// Token: 0x0600278A RID: 10122 RVA: 0x000E5C84 File Offset: 0x000E3E84
	public cd()
	{
		base.Args.Add(new ayk(typeof(b0l), null, false));
	}

	// Token: 0x0600278B RID: 10123 RVA: 0x000E5CB4 File Offset: 0x000E3EB4
	public override lu c7(List<object> A_0)
	{
		if (A_0 != null && A_0.Count == 1)
		{
			c3n c3n = A_0[0] as c3n;
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && c3n != null)
			{
				serviceOrThrow.aqu().v().SpecialAbilities.b(c3n);
				bdg.a("Player gains [prop]{0}[/prop] special ability", new object[]
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
