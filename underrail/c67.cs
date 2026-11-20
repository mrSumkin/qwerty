using System;
using System.Collections.Generic;
using TimelapseVertigo.Common;
using TimelapseVertigo.Rules.Capabilities;
using TimelapseVertigo.Rules.Capabilities.Psi;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001F36 RID: 7990
[ayj("Pyrokinesis")]
public sealed class c67 : ce5, a5q
{
	// Token: 0x0600B987 RID: 47495 RVA: 0x00412110 File Offset: 0x00410310
	public override string y8()
	{
		return "Пирокинез";
	}

	// Token: 0x0600B988 RID: 47496 RVA: 0x00412118 File Offset: 0x00410318
	public override string os()
	{
		return "Pyrokinesis";
	}

	// Token: 0x0600B989 RID: 47497 RVA: 0x00412120 File Offset: 0x00410320
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600B98A RID: 47498 RVA: 0x00412124 File Offset: 0x00410324
	public override PsiSchool ch()
	{
		return PsiSchool.Metathermics;
	}

	// Token: 0x0600B98B RID: 47499 RVA: 0x00412128 File Offset: 0x00410328
	public override int ci()
	{
		return 6;
	}

	// Token: 0x0600B98C RID: 47500 RVA: 0x0041212C File Offset: 0x0041032C
	public override TimelapseCursor? bj()
	{
		return new TimelapseCursor?(TimelapseCursor.GroundAttack);
	}

	// Token: 0x0600B98D RID: 47501 RVA: 0x00412138 File Offset: 0x00410338
	public c67()
	{
		this.g = new List<string>
		{
			d7f.b,
			c67.a
		};
	}

	// Token: 0x0600B98E RID: 47502 RVA: 0x0041216C File Offset: 0x0041036C
	public override a3b bl(cnm A_0, efk A_1)
	{
		if (A_0 != null && A_0.b8() != null && A_0.b8().CustomProperties.GetPrimitivePropertyValue<bool>("up_psiFireBreathing", new bool?(false)).Value)
		{
			return new a3b
			{
				a = c0e.a,
				b = new int?(1),
				c = c0e.p
			};
		}
		return null;
	}

	// Token: 0x0600B98F RID: 47503 RVA: 0x004121DC File Offset: 0x004103DC
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.DiscoveredPenetrableSpot;
	}

	// Token: 0x0600B990 RID: 47504 RVA: 0x004121E0 File Offset: 0x004103E0
	public override IList<string> bi()
	{
		return this.g;
	}

	// Token: 0x0600B991 RID: 47505 RVA: 0x004121EC File Offset: 0x004103EC
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		List<cfd> list = new List<cfd>();
		list.Add(new cfd(c67.a, c67.b, false, false));
		if (A_1 == v5.b)
		{
			list.Add(new cfd(d7f.b, d7f.g, true, false));
		}
		return list;
	}

	// Token: 0x0600B992 RID: 47506 RVA: 0x00412238 File Offset: 0x00410438
	public override string bo(cnm A_0)
	{
		a1q a1q = c67.a(A_0);
		string text = qv.b("Psi/Pyrokinesis");
		string text2 = string.Empty;
		if (!string.IsNullOrEmpty(text))
		{
			try
			{
				text2 = string.Format(text, a1q.LowerBoundary, a1q.UpperBoundary);
			}
			catch
			{
			}
		}
		if (A_0 != null && A_0.b8() != null && A_0.b8().Feats.Contains<xk>())
		{
			text2 = text2 + " " + qv.a("Psi/PyrokinesisPyromaniac", new object[]
			{
				(int)(c67.f * 100.0),
				(int)(xk.a(A_0) * 100.0),
				l4.a(3, false)
			});
		}
		return text2;
	}

	// Token: 0x0600B993 RID: 47507 RVA: 0x00412320 File Offset: 0x00410520
	public new static a1q a(cnm A_0)
	{
		if (A_0 == null || A_0.b8() == null)
		{
			return new a1q(DamageType.Heat, 0, 0);
		}
		int num = 0;
		rs rs = A_0.b8().Skills.Get<rs>();
		if (rs != null)
		{
			num = rs.g();
		}
		double num2 = c3n.a("Pyrokinesis", A_0);
		return new a1q
		{
			DamageType = DamageType.Heat,
			LowerBoundary = Convert.ToInt32((20.0 + 0.4 * (double)num) * num2),
			UpperBoundary = Convert.ToInt32((21.0 + 0.85 * (double)num) * num2)
		};
	}

	// Token: 0x0600B994 RID: 47508 RVA: 0x004123CC File Offset: 0x004105CC
	public double[] f2(cnm A_0, double A_1, bool A_2, cmn A_3)
	{
		return euf.a(A_0.b8(), A_0.b8().Skills.Get<rs>().g(), A_1, 0.0);
	}

	// Token: 0x0600B995 RID: 47509 RVA: 0x00412404 File Offset: 0x00410604
	protected override int br(cnm A_0)
	{
		if (A_0 != null && A_0.b8() != null)
		{
			return 0;
		}
		return 3000;
	}

	// Token: 0x0600B996 RID: 47510 RVA: 0x00412424 File Offset: 0x00410624
	public override List<brl> ck()
	{
		return new List<brl>
		{
			new b4k(new Type[]
			{
				typeof(c3v)
			}),
			new bap(25, new Type[]
			{
				typeof(rs)
			})
		};
	}

	// Token: 0x0600B997 RID: 47511 RVA: 0x00412478 File Offset: 0x00410678
	protected override float f0(cnm A_0)
	{
		return 10f;
	}

	// Token: 0x0600B998 RID: 47512 RVA: 0x00412480 File Offset: 0x00410680
	protected override float cj(cnm A_0)
	{
		return 40f;
	}

	// Token: 0x0600B999 RID: 47513 RVA: 0x00412488 File Offset: 0x00410688
	protected override int d2(cnm A_0)
	{
		return 2;
	}

	// Token: 0x0600B99A RID: 47514 RVA: 0x0041248C File Offset: 0x0041068C
	protected override float cl(cnm A_0)
	{
		float num = base.cl(A_0);
		if ((A_0.b8().bb & eom.b) != eom.a)
		{
			num *= (float)(1.0 - dyi.a(A_0.b8()));
		}
		return num;
	}

	// Token: 0x0600B99B RID: 47515 RVA: 0x004124D0 File Offset: 0x004106D0
	protected override int hi(cnm A_0)
	{
		return 35;
	}

	// Token: 0x0600B99C RID: 47516 RVA: 0x004124D4 File Offset: 0x004106D4
	protected override PsiAbilityCategories cm(cnm A_0)
	{
		return PsiAbilityCategories.Damaging;
	}

	// Token: 0x0400438A RID: 17290
	public new static readonly string a = "Psi.Pyrokinesis";

	// Token: 0x0400438B RID: 17291
	private static readonly int b = 3 * d0u.b;

	// Token: 0x0400438C RID: 17292
	private const double c = 20.0;

	// Token: 0x0400438D RID: 17293
	private const double d = 0.4;

	// Token: 0x0400438E RID: 17294
	private new const double e = 0.85;

	// Token: 0x0400438F RID: 17295
	public new static double f = 0.5;

	// Token: 0x04004390 RID: 17296
	private new List<string> g;
}
