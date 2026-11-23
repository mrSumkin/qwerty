using System;
using System.Collections.Generic;

// Token: 0x020005E2 RID: 1506
public sealed class e4a : ce8
{
	// Token: 0x0600279F RID: 10143 RVA: 0x000E639C File Offset: 0x000E459C
	public override string[] c6()
	{
		return new string[]
		{
			"playerSetBaseAbility",
			"psetstat"
		};
	}

	// Token: 0x060027A0 RID: 10144 RVA: 0x000E63B8 File Offset: 0x000E45B8
	public e4a()
	{
		base.Args.Add(new ayk(typeof(csg), null, false));
		base.Args.Add(new ayk(typeof(dq4), null, false));
	}

	// Token: 0x060027A1 RID: 10145 RVA: 0x000E6404 File Offset: 0x000E4604
	public override lu c7(List<object> A_0)
	{
		if (A_0 != null && A_0.Count >= 2)
		{
			string text = A_0[0] as string;
			int num = (int)A_0[1];
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null)
			{
				to to = serviceOrThrow.aqu().v().BaseAbilities.a(text);
				if (to != null)
				{
					to.a(num);
					serviceOrThrow.aqu().v().bl();
					bdg.a("Player [prop]{0}[/prop] base ability set to [val]{1}[/val]", new object[]
					{
						to.Name,
						num
					});
					return null;
				}
				bdg.a("[error]Cannot find base ability [prop]'{0}'[/prop][/error]", new object[]
				{
					text
				});
				return null;
			}
		}
		else
		{
			base.b();
		}
		return null;
	}
}
