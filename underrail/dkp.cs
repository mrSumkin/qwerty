using System;
using System.Collections.Generic;

// Token: 0x020005CE RID: 1486
public sealed class dkp : ce8
{
	// Token: 0x06002761 RID: 10081 RVA: 0x000E4E40 File Offset: 0x000E3040
	public override string[] c6()
	{
		return new string[]
		{
			"playerSetModel",
			"psetmodel"
		};
	}

	// Token: 0x06002762 RID: 10082 RVA: 0x000E4E58 File Offset: 0x000E3058
	public dkp()
	{
		base.Args.Add(new ayk(typeof(cj8), null, false));
	}

	// Token: 0x06002763 RID: 10083 RVA: 0x000E4E88 File Offset: 0x000E3088
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
						c5x.h.b.a(text);
						bdg.a("Player model set to [val]{0}[/val]", new object[]
						{
							text
						});
						return null;
					}
					bdg.a("[error]Could not change player model[/error]", new object[0]);
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
