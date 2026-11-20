using System;
using System.Collections.Generic;

// Token: 0x020005E3 RID: 1507
public sealed class me : ce8
{
	// Token: 0x060027A2 RID: 10146 RVA: 0x000E64D4 File Offset: 0x000E46D4
	public override string[] c6()
	{
		return new string[]
		{
			"playerSetSkill",
			"psetskill"
		};
	}

	// Token: 0x060027A3 RID: 10147 RVA: 0x000E64F0 File Offset: 0x000E46F0
	public me()
	{
		base.Args.Add(new ayk(typeof(aii), null, false));
		base.Args.Add(new ayk(typeof(dq4), null, false));
	}

	// Token: 0x060027A4 RID: 10148 RVA: 0x000E653C File Offset: 0x000E473C
	public override lu c7(List<object> A_0)
	{
		if (A_0 != null && A_0.Count >= 2)
		{
			string text = A_0[0] as string;
			int num = (int)A_0[1];
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null)
			{
				csn csn = serviceOrThrow.aqu().v().Skills.a(text);
				if (csn != null)
				{
					csn.a(num);
					serviceOrThrow.aqu().v().bl();
					bdg.a("Player [prop]{0}[/prop] skill set to [val]{1}[/val]", new object[]
					{
						csn.Name,
						num
					});
					return null;
				}
				bdg.a("[error]Cannot find skill [prop]'{0}'[/prop][/error]", new object[]
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
