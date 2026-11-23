using System;
using System.Collections.Generic;

// Token: 0x020005E7 RID: 1511
public sealed class c4 : ce8
{
	// Token: 0x060027B1 RID: 10161 RVA: 0x000E6944 File Offset: 0x000E4B44
	public override string[] c6()
	{
		return new string[]
		{
			"go",
			"goto"
		};
	}

	// Token: 0x060027B2 RID: 10162 RVA: 0x000E6960 File Offset: 0x000E4B60
	public c4()
	{
		base.Args.Add(new ayk(typeof(cqd), null, false));
	}

	// Token: 0x060027B3 RID: 10163 RVA: 0x000E6990 File Offset: 0x000E4B90
	public override lu c7(List<object> A_0)
	{
		if (A_0 != null && A_0.Count > 0)
		{
			c2w c2w = A_0[0] as c2w;
			if (c2w != null)
			{
				cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
				bool flag = false;
				using (List<bfc>.Enumerator enumerator = serviceOrThrow.aq0().a().GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (string.Equals(enumerator.Current.Id, c2w.b(), StringComparison.OrdinalIgnoreCase))
						{
							flag = true;
						}
					}
				}
				if (flag)
				{
					bdg.a("Teleporting to locale [val]'{0}'[/val]", new object[]
					{
						c2w.b()
					});
					ps service = bpo.GetService<ps>();
					if (service != null)
					{
						service.ang(true);
					}
					a0l.a(c2w);
					return null;
				}
				bdg.a("[error]Locale [val]'{0}'[/val] not found[/error]", new object[]
				{
					c2w.b()
				});
				return null;
			}
		}
		base.b();
		return null;
	}
}
