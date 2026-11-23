using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;
using TimelapseVertigo.Rules.Capabilities.Psi;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001F2D RID: 7981
[ayj("PyrokineticStream")]
public sealed class c5y : ce5
{
	// Token: 0x0600B8E6 RID: 47334 RVA: 0x004109E8 File Offset: 0x0040EBE8
	public override string y8()
	{
		return "Пирокинетический поток";
	}

	// Token: 0x0600B8E7 RID: 47335 RVA: 0x004109F0 File Offset: 0x0040EBF0
	public override string os()
	{
		return "PyrokineticStream";
	}

	// Token: 0x0600B8E8 RID: 47336 RVA: 0x004109F8 File Offset: 0x0040EBF8
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600B8E9 RID: 47337 RVA: 0x004109FC File Offset: 0x0040EBFC
	public override PsiSchool ch()
	{
		return PsiSchool.Metathermics;
	}

	// Token: 0x0600B8EA RID: 47338 RVA: 0x00410A00 File Offset: 0x0040EC00
	public override int ci()
	{
		return 5;
	}

	// Token: 0x0600B8EB RID: 47339 RVA: 0x00410A04 File Offset: 0x0040EC04
	public c5y()
	{
		this.h = new List<string>
		{
			d7f.b
		};
	}

	// Token: 0x0600B8EC RID: 47340 RVA: 0x00410A24 File Offset: 0x0040EC24
	public override a3b bl(cnm A_0, efk A_1)
	{
		if (A_0 != null && A_0.b8() != null && A_0.b8().CustomProperties.GetPrimitivePropertyValue<bool>("up_psiFireBreathing", new bool?(false)).Value)
		{
			return new a3b
			{
				a = c0e.a,
				b = new int?(1),
				c = c0e.a,
				d = new int?(1),
				e = c0e.q
			};
		}
		return null;
	}

	// Token: 0x0600B8ED RID: 47341 RVA: 0x00410AAC File Offset: 0x0040ECAC
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.DiscoveredPenetrableSpot;
	}

	// Token: 0x0600B8EE RID: 47342 RVA: 0x00410AB0 File Offset: 0x0040ECB0
	public override IList<string> bi()
	{
		return this.h;
	}

	// Token: 0x0600B8EF RID: 47343 RVA: 0x00410ABC File Offset: 0x0040ECBC
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		List<cfd> list = new List<cfd>();
		if (A_1 == v5.b)
		{
			list.Add(new cfd(d7f.b, d7f.g, true, false));
		}
		return list;
	}

	// Token: 0x0600B8F0 RID: 47344 RVA: 0x00410AF0 File Offset: 0x0040ECF0
	public override string bo(cnm A_0)
	{
		a1q a1q = c5y.a(A_0);
		int num = c5y.e;
		if (A_0 != null && A_0.b8() != null && (A_0.b8().bb & eom.b) != eom.a)
		{
			num = (int)((double)num * (1.0 - dyi.a(A_0.b8())));
		}
		string text = qv.a("Psi/PyrokineticStream", new object[]
		{
			a1q.LowerBoundary,
			a1q.UpperBoundary,
			c5y.d,
			num,
			c5y.f
		});
		if (A_0 != null && A_0.b8() != null && A_0.b8().Feats.Contains<xk>())
		{
			text = text + " " + qv.a("Psi/PyrokineticStreamPyromaniac", new object[]
			{
				(int)(c5y.g * 100.0),
				(int)(xk.a(A_0) * 100.0),
				l4.a(3, false)
			});
		}
		return text;
	}

	// Token: 0x0600B8F1 RID: 47345 RVA: 0x00410C18 File Offset: 0x0040EE18
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
		double num2 = c3n.a("PyrokineticStream", A_0);
		return new a1q
		{
			DamageType = DamageType.Heat,
			LowerBoundary = Convert.ToInt32((5.0 + 0.1 * (double)num) * num2),
			UpperBoundary = Convert.ToInt32((6.0 + 0.2 * (double)num) * num2)
		};
	}

	// Token: 0x0600B8F2 RID: 47346 RVA: 0x00410CC4 File Offset: 0x0040EEC4
	public override List<brl> ck()
	{
		return new List<brl>
		{
			new b4k(new Type[]
			{
				typeof(c3v)
			}),
			new bap(35, new Type[]
			{
				typeof(rs)
			})
		};
	}

	// Token: 0x0600B8F3 RID: 47347 RVA: 0x00410D18 File Offset: 0x0040EF18
	protected override float f0(cnm A_0)
	{
		return 6f;
	}

	// Token: 0x0600B8F4 RID: 47348 RVA: 0x00410D20 File Offset: 0x0040EF20
	protected override float cj(cnm A_0)
	{
		return 25f;
	}

	// Token: 0x0600B8F5 RID: 47349 RVA: 0x00410D28 File Offset: 0x0040EF28
	protected override float cl(cnm A_0)
	{
		float num = base.cl(A_0);
		if ((A_0.b8().bb & eom.b) != eom.a)
		{
			num *= (float)(1.0 - dyi.a(A_0.b8()));
		}
		return num;
	}

	// Token: 0x0600B8F6 RID: 47350 RVA: 0x00410D6C File Offset: 0x0040EF6C
	protected override int hi(cnm A_0)
	{
		return 20;
	}

	// Token: 0x0600B8F7 RID: 47351 RVA: 0x00410D70 File Offset: 0x0040EF70
	protected override int mb(cnm A_0)
	{
		return 70;
	}

	// Token: 0x0600B8F8 RID: 47352 RVA: 0x00410D74 File Offset: 0x0040EF74
	protected override int ma(cnm A_0)
	{
		return 5000;
	}

	// Token: 0x0600B8F9 RID: 47353 RVA: 0x00410D7C File Offset: 0x0040EF7C
	protected override float afj(cnm A_0)
	{
		return 0f;
	}

	// Token: 0x0600B8FA RID: 47354 RVA: 0x00410D84 File Offset: 0x0040EF84
	protected override PsiAbilityCategories cm(cnm A_0)
	{
		return PsiAbilityCategories.Damaging;
	}

	// Token: 0x04004351 RID: 17233
	private new const double a = 5.0;

	// Token: 0x04004352 RID: 17234
	private const double b = 0.1;

	// Token: 0x04004353 RID: 17235
	private const double c = 0.2;

	// Token: 0x04004354 RID: 17236
	private static readonly int d = 3;

	// Token: 0x04004355 RID: 17237
	public new static readonly int e = 10;

	// Token: 0x04004356 RID: 17238
	public new static readonly int f = 5;

	// Token: 0x04004357 RID: 17239
	public new static double g = 0.2;

	// Token: 0x04004358 RID: 17240
	private new List<string> h;
}
