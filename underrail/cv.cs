using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;

// Token: 0x020015DD RID: 5597
[euj]
public sealed class cv
{
	// Token: 0x06007B69 RID: 31593 RVA: 0x003393BC File Offset: 0x003375BC
	[ayh("TelekineticGrounding_Tick")]
	public void a(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		if (A_1 != null && A_1.h != null && A_1.h.b != null && A_1.Zone != null && A_1.h.b.aa() != null && A_2 != null)
		{
			efk efk = A_1.h.b.aa();
			if (efk.SpecialStates.a || efk.SpecialStates.c || efk.SpecialStates.h || efk.SpecialStates.k)
			{
				return;
			}
			ro ro;
			if (A_2.QuickGet("StatusEffect", out ro))
			{
				double d;
				if (ro.Duration > 0)
				{
					d = ro.TimeLeft / (double)ro.Duration;
				}
				else
				{
					d = 1.0;
				}
				int a_ = Math.Max(efk.Level, (efk.Level + aiy.bk) / 2);
				double a_2 = (double)ro.b;
				double a_3 = (double)c2h.a(efk.BaseAbilities.Strength, a_, (double)aiy.ag);
				double num = qw.a(a_2, a_3);
				num *= 1.2 - Math.Sqrt(d);
				if (cuo.a.NextDouble() < num)
				{
					dtb dtb = new dtb();
					dtb.b(false);
					dtb.c(false);
					dtb.ad().Add(new bm3(250));
					dtb.ad().Add(new e43(A_1.h.b, new Guid[]
					{
						ro.Id
					}));
					A_1.Zone.ActionManager.g9(dtb, atp.a);
					dz6.a(dtb);
					Vector3 a_4 = A_1.aj() - new Vector3(0.5f, 0.5f, 0f);
					a_4.Z = A_1.Location.Z;
					dv1.a(new List<string>
					{
						"Projectiles\\PsiFlake"
					}, A_1.Area, a_4, 0.1f, 20, 175, 2f, 7.5f, true, true, false, new Action<c5x>(cv.a), true);
				}
			}
		}
	}

	// Token: 0x06007B6A RID: 31594 RVA: 0x003395F8 File Offset: 0x003377F8
	[ayh("TelekineticGrounding_SoundOn")]
	public void b(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		if (A_1 != null)
		{
			A_1.c().a("telekineticGrounding", false);
			A_1.c().a("telekineticGrounding", "TelekineticGroundingLoop", 1f, c9z.a, true, false);
		}
	}

	// Token: 0x06007B6B RID: 31595 RVA: 0x0033963C File Offset: 0x0033783C
	[ayh("TelekineticGrounding_SoundOff")]
	public void c(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		if (A_1 != null)
		{
			A_1.c().a("telekineticGrounding", false);
		}
	}

	// Token: 0x06007B6C RID: 31596 RVA: 0x0033965C File Offset: 0x0033785C
	public static void a(c5x A_0)
	{
		if (A_0.o.b != null)
		{
			A_0.o.b.g = new float?(0.95f);
		}
		else if (A_0.p.b != null && A_0.p.b.a != null)
		{
			foreach (cd0 cd in A_0.p.b.a)
			{
				cd.g = new float?(0.95f);
			}
		}
		A_0.Size = new Vector3(0.3f, 0.3f, 0.1f);
	}
}
