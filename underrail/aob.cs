using System;
using System.Collections.Generic;

// Token: 0x020005DF RID: 1503
public sealed class aob : ce8
{
	// Token: 0x06002796 RID: 10134 RVA: 0x000E60AC File Offset: 0x000E42AC
	public override string[] c6()
	{
		return new string[]
		{
			"playerGiveItem",
			"pgiveitem"
		};
	}

	// Token: 0x06002797 RID: 10135 RVA: 0x000E60C8 File Offset: 0x000E42C8
	public aob()
	{
		base.Args.Add(new ayk(typeof(eeq), null, false));
		base.Args.Add(new ayk(typeof(dq4), "stacks", true));
		base.Args.Add(new ayk(typeof(dq4), "quality", true));
	}

	// Token: 0x06002798 RID: 10136 RVA: 0x000E6138 File Offset: 0x000E4338
	public override lu c7(List<object> A_0)
	{
		if (A_0 != null && A_0.Count >= 1)
		{
			string text = A_0[0] as string;
			if (text != null)
			{
				coh coh = ez2.a(text);
				if (coh == null)
				{
					bdg.a("[error]Failed to load item from path [val]{0}", new object[]
					{
						text
					});
					return null;
				}
				if (A_0.Count >= 2)
				{
					int a_ = (int)A_0[1];
					coh.Stacks = a_;
				}
				if (A_0.Count >= 3)
				{
					int a_2 = (int)A_0[2];
					fv fv = coh as fv;
					if (fv == null)
					{
						bdg.a("[error]Cannot set quality on non-component item", new object[0]);
						return null;
					}
					fv.QualityLevel = a_2;
				}
				cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
				if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null)
				{
					serviceOrThrow.aqu().v().Bag.z3(coh, true);
					string text2 = "Player is given [val]{0}[/val]";
					if (coh.Stacks > 1)
					{
						text2 += " x [val]{1}[/val]";
					}
					bdg.a(text2, new object[]
					{
						coh.Definition.az(),
						coh.Stacks
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
