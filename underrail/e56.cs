using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Characters;

// Token: 0x020005CD RID: 1485
public sealed class e56 : ce8
{
	// Token: 0x0600275E RID: 10078 RVA: 0x000E4C8C File Offset: 0x000E2E8C
	public override string[] c6()
	{
		return new string[]
		{
			"playerSetGender",
			"psetgender"
		};
	}

	// Token: 0x0600275F RID: 10079 RVA: 0x000E4CA4 File Offset: 0x000E2EA4
	public e56()
	{
		base.Args.Add(new ayk(typeof(cj8), null, false));
	}

	// Token: 0x06002760 RID: 10080 RVA: 0x000E4CD4 File Offset: 0x000E2ED4
	public override lu c7(List<object> A_0)
	{
		if (A_0 != null && A_0.Count >= 1)
		{
			string text = A_0[0] as string;
			if (!string.IsNullOrWhiteSpace(text))
			{
				cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
				if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null)
				{
					c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
					if (c5x != null && c5x.h.b != null)
					{
						if (string.Equals(text, "male"))
						{
							c5x.h.b.a("player");
							c5x.h.b.aa().Gender = Gender.Male;
							c5x.h.b.aa().bl();
							bdg.a("Player model set to [val]{0}[/val]", new object[]
							{
								text
							});
						}
						else if (string.Equals(text, "female"))
						{
							c5x.h.b.a("player_female");
							c5x.h.b.aa().Gender = Gender.Female;
							c5x.h.b.aa().bl();
							bdg.a("Player model set to [val]{0}[/val]", new object[]
							{
								text
							});
						}
						return null;
					}
					bdg.a("[error]Could not change player gender[/error]", new object[0]);
					return null;
				}
			}
		}
		else
		{
			base.b();
		}
		return null;
	}
}
