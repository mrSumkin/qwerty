using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Microsoft.Xna.Framework;
using Ouroboros.Common.Aspects;
using TimelapseVertigo.Rules;

// Token: 0x020005CA RID: 1482
public sealed class dja : ce8
{
	// Token: 0x06002755 RID: 10069 RVA: 0x000E47B4 File Offset: 0x000E29B4
	public override string[] c6()
	{
		return new string[]
		{
			"setDiffParam",
			"setCustomDifficultyParam"
		};
	}

	// Token: 0x06002756 RID: 10070 RVA: 0x000E47D0 File Offset: 0x000E29D0
	public dja()
	{
		base.Args.Add(new ayk(typeof(hb), null, false));
		base.Args.Add(new ayk(typeof(cpd), null, false));
	}

	// Token: 0x06002757 RID: 10071 RVA: 0x000E481C File Offset: 0x000E2A1C
	public override lu c7(List<object> A_0)
	{
		if (A_0 != null && A_0.Count == 2)
		{
			FieldInfo fieldInfo = (FieldInfo)A_0[0];
			float num = (float)A_0[1];
			do2 @do = Enumerable.FirstOrDefault<object>(fieldInfo.GetCustomAttributes(typeof(do2), false)) as do2;
			if (@do != null)
			{
				cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
				if (serviceOrThrow.aqu() == null)
				{
					return null;
				}
				bool flag = false;
				GameDifficultySettings gameDifficultySettings;
				if (serviceOrThrow.aqu().i() != GameDifficulty.Custom)
				{
					flag = true;
					gameDifficultySettings = eoq.Clone<GameDifficultySettings>(aiy.cp[(int)serviceOrThrow.aqu().i()]);
				}
				else
				{
					gameDifficultySettings = serviceOrThrow.aqu().r;
				}
				num = MathHelper.Clamp(num, @do.b, @do.c);
				if (@do.a)
				{
					int num2 = (int)num;
					fieldInfo.SetValue(gameDifficultySettings, num2);
					bdg.a("Game difficulty parameter [prop]{0}[/prop] set to [val]{1}[/val]", new object[]
					{
						fieldInfo.Name,
						num2
					});
				}
				else
				{
					fieldInfo.SetValue(gameDifficultySettings, num);
					bdg.a("Game difficulty parameter [prop]{0}[/prop] set to [val]{1}[/val]", new object[]
					{
						fieldInfo.Name,
						num
					});
				}
				if (flag)
				{
					serviceOrThrow.aqu().a(GameDifficulty.Custom);
					serviceOrThrow.aqu().r = gameDifficultySettings;
					bdg.a("Game difficulty converted to [val]{0}[/val]", new object[]
					{
						GameDifficulty.Custom
					});
				}
				if (serviceOrThrow.aqw() != null)
				{
					foreach (aud aud in serviceOrThrow.aqw().Areas)
					{
						foreach (b0b b0b in Enumerable.ToList<b0b>(aud.Entities))
						{
							QuickAspectAccessor<amc> h = ((c5x)b0b).h;
							if (h != null)
							{
								amc b = h.b;
								if (b != null)
								{
									b.aa().bl();
								}
							}
						}
					}
				}
				return null;
			}
		}
		base.b();
		return null;
	}
}
