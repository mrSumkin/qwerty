using System;
using System.Collections.Generic;

// Token: 0x020005D2 RID: 1490
public sealed class c0w : ce8
{
	// Token: 0x0600276D RID: 10093 RVA: 0x000E5334 File Offset: 0x000E3534
	public override string[] c6()
	{
		return new string[]
		{
			"playerRemoveCooldown",
			"prmcd"
		};
	}

	// Token: 0x0600276E RID: 10094 RVA: 0x000E5350 File Offset: 0x000E3550
	public c0w()
	{
		base.Args.Add(new ayk(typeof(czq), null, false));
	}

	// Token: 0x0600276F RID: 10095 RVA: 0x000E5380 File Offset: 0x000E3580
	public override lu c7(List<object> A_0)
	{
		if (A_0 != null && A_0.Count == 1)
		{
			string text = A_0[0] as string;
			if (text != null)
			{
				cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
				if (serviceOrThrow.aqu() == null || serviceOrThrow.aqu().v() == null)
				{
					base.a("[error]Could not find player character", new object[0]);
					goto IL_D4;
				}
				ip ip = serviceOrThrow.aqu().v().Cooldowns.b(text);
				if (ip != null)
				{
					serviceOrThrow.aqu().v().Cooldowns.a(text);
					base.a("Cooldown '[val]{0}[/val]' removed at [val]{1}[/val]", new object[]
					{
						text,
						ip.a
					});
					goto IL_D4;
				}
				base.a("[warning]Cooldown not found.", new object[0]);
				goto IL_D4;
			}
		}
		base.b();
		IL_D4:
		return null;
	}
}
