using System;
using System.Collections.Generic;

// Token: 0x020005CC RID: 1484
public sealed class cqt : ce8
{
	// Token: 0x0600275B RID: 10075 RVA: 0x000E4B6C File Offset: 0x000E2D6C
	public override string[] c6()
	{
		return new string[]
		{
			"playerGiveAllPsiAbilities",
			"pgiveallpsi"
		};
	}

	// Token: 0x0600275D RID: 10077 RVA: 0x000E4B90 File Offset: 0x000E2D90
	public override lu c7(List<object> A_0)
	{
		if (A_0 == null || A_0.Count == 0)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null)
			{
				using (IEnumerator<c3n> enumerator = dgk.b().GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						c3n c3n = enumerator.Current;
						if (!serviceOrThrow.aqu().v().PsiAbilities.c(c3n) && (c3n is ce5 || c3n is aoc))
						{
							serviceOrThrow.aqu().v().PsiAbilities.b(c3n);
							bdg.a("Player gains [prop]{0}[/prop] psionic ability", new object[]
							{
								c3n.Name
							});
						}
					}
					goto IL_D4;
				}
			}
			bdg.a("[error]Could not find player character", new object[0]);
			IL_D4:
			return null;
		}
		base.b();
		return null;
	}
}
