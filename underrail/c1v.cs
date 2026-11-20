using System;
using System.Collections.Generic;

// Token: 0x020005D8 RID: 1496
public sealed class c1v : ce8
{
	// Token: 0x06002780 RID: 10112 RVA: 0x000E5998 File Offset: 0x000E3B98
	public override string[] c6()
	{
		return new string[]
		{
			"playerRemoveSpecialAbility",
			"premsab"
		};
	}

	// Token: 0x06002781 RID: 10113 RVA: 0x000E59B4 File Offset: 0x000E3BB4
	public c1v()
	{
		base.Args.Add(new ayk(typeof(b0l), null, false));
	}

	// Token: 0x06002782 RID: 10114 RVA: 0x000E59E4 File Offset: 0x000E3BE4
	public override lu c7(List<object> A_0)
	{
		if (A_0 != null && A_0.Count == 1)
		{
			c3n c3n = A_0[0] as c3n;
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && c3n != null)
			{
				serviceOrThrow.aqu().v().SpecialAbilities.a(c3n);
				bdg.a("Player loses [prop]{0}[/prop] special ability", new object[]
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
