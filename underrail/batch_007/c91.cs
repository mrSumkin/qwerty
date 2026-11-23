using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001EC5 RID: 7877
[ayj("burst")]
public sealed class c91 : bon
{
	// Token: 0x0600B1F0 RID: 45552 RVA: 0x004034F8 File Offset: 0x004016F8
	public override string y8()
	{
		return "Очередь";
	}

	// Token: 0x0600B1F1 RID: 45553 RVA: 0x00403500 File Offset: 0x00401700
	public override string os()
	{
		return "Burst";
	}

	// Token: 0x0600B1F2 RID: 45554 RVA: 0x00403508 File Offset: 0x00401708
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600B1F3 RID: 45555 RVA: 0x0040350C File Offset: 0x0040170C
	public override bool cs()
	{
		return false;
	}

	// Token: 0x0600B1F4 RID: 45556 RVA: 0x00403510 File Offset: 0x00401710
	public override int ct()
	{
		return 1;
	}

	// Token: 0x0600B1F5 RID: 45557 RVA: 0x00403514 File Offset: 0x00401714
	public override IList<string> bi()
	{
		return this.a;
	}

	// Token: 0x0600B1F6 RID: 45558 RVA: 0x0040351C File Offset: 0x0040171C
	public override bool j7()
	{
		return true;
	}

	// Token: 0x0600B1F7 RID: 45559 RVA: 0x00403520 File Offset: 0x00401720
	public override bool l8()
	{
		return false;
	}

	// Token: 0x0600B1F8 RID: 45560 RVA: 0x00403524 File Offset: 0x00401724
	public c91()
	{
		this.a = new List<string>();
		this.a.Add(d7f.a);
	}

	// Token: 0x0600B1F9 RID: 45561 RVA: 0x00403548 File Offset: 0x00401748
	public override string bm(cnm A_0)
	{
		return "Burst";
	}

	// Token: 0x0600B1FA RID: 45562 RVA: 0x00403554 File Offset: 0x00401754
	public override bool hm(cnm A_0)
	{
		return base.hm(A_0) && A_0 != null && A_0.b8() != null && A_0.b8().Offense.u() != null && A_0.b8().Offense.u().TypedDefinition != null && (A_0.b8().Offense.u().TypedDefinition.e() == btz.b || A_0.b8().Offense.u().TypedDefinition.e() == btz.c || A_0.b8().Offense.u().TypedDefinition.e() == btz.j || A_0.b8().Offense.u().TypedDefinition.e() == btz.k) && (eub.b(A_0.b8(), A_0.b8().Offense.u()) || A_0.b8().Offense.u().TypedDefinition.g());
	}

	// Token: 0x0600B1FB RID: 45563 RVA: 0x00403670 File Offset: 0x00401870
	public override bool cu(cnm A_0)
	{
		return A_0 != null && A_0.b8() != null && A_0.b8().Offense.u() != null && A_0.b8().Offense.u().TypedDefinition != null && (A_0.b8().Offense.u().TypedDefinition.e() == btz.b || A_0.b8().Offense.u().TypedDefinition.e() == btz.c || A_0.b8().Offense.u().TypedDefinition.e() == btz.j || A_0.b8().Offense.u().TypedDefinition.e() == btz.k);
	}

	// Token: 0x0600B1FC RID: 45564 RVA: 0x00403740 File Offset: 0x00401940
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.CreatureNotSelf;
	}

	// Token: 0x0600B1FD RID: 45565 RVA: 0x00403744 File Offset: 0x00401944
	public override string bo(cnm A_0)
	{
		return qv.a("SpecialAttacks/Burst", new object[]
		{
			c91.c(A_0)
		});
	}

	// Token: 0x0600B1FE RID: 45566 RVA: 0x00403764 File Offset: 0x00401964
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		List<cfd> list = new List<cfd>();
		if (A_1 == v5.b)
		{
			list.Add(new cfd(d7f.a, d7f.g, true, false));
		}
		return list;
	}

	// Token: 0x0600B1FF RID: 45567 RVA: 0x00403798 File Offset: 0x00401998
	public override double ajx(cnm A_0, double A_1, efk A_2, double A_3)
	{
		if (A_0 != null)
		{
			cd1 cd = A_0.b9() as cd1;
			if (cd != null && cd.TypedDefinition != null)
			{
				double num = c91.a(A_3, cd.TypedDefinition);
				return A_1 * (1.0 - num);
			}
		}
		return A_1;
	}

	// Token: 0x0600B200 RID: 45568 RVA: 0x004037E8 File Offset: 0x004019E8
	public static double a(double A_0, bke A_1)
	{
		double num = d05.b(0.15, A_0 / (double)Math.Max(1f, A_1.ad()), 0.75);
		return d05.b(0.05, num - A_1.s(), 0.95);
	}

	// Token: 0x0600B201 RID: 45569 RVA: 0x00403844 File Offset: 0x00401A44
	public static int c(cnm A_0)
	{
		int num = 5;
		if (A_0 != null && A_0.b8() != null)
		{
			if (A_0.b8().Feats.Contains<crq>())
			{
				num += 2;
			}
			if (A_0.b8().Feats.Contains<e6b>() && A_0.b8().Offense.u().TypedDefinition.e() == btz.j)
			{
				num += e6b.a + (int)((double)A_0.b8().GetSpecializationValue<cu5>(true) * cu5.a);
			}
			if (A_0.b8().Offense.u().TypedDefinition.d() != 0)
			{
				num += A_0.b8().Offense.u().TypedDefinition.d();
			}
			ajy ajy = c91.b(A_0);
			if (ajy != null)
			{
				num += ajy.b();
			}
			List<bgx> list = A_0.b8().StatusEffects.Get<bgx>();
			if (list != null && list.Count > 0)
			{
				foreach (bgx bgx in list)
				{
					if (bgx.a() == A_0.b8().Offense.u().Id)
					{
						num += bgx.b();
					}
				}
			}
		}
		if (num < 1)
		{
			num = 1;
		}
		return num;
	}

	// Token: 0x0600B202 RID: 45570 RVA: 0x004039C0 File Offset: 0x00401BC0
	private static ajy b(cnm A_0)
	{
		if (A_0 != null && A_0.b8() != null)
		{
			List<ajy> list = A_0.b8().StatusEffects.Get<ajy>();
			Guid b = A_0.b8().Offense.u().Id;
			foreach (ajy ajy in list)
			{
				if (ajy.c == b)
				{
					return ajy;
				}
			}
		}
		return null;
	}

	// Token: 0x0600B203 RID: 45571 RVA: 0x00403A60 File Offset: 0x00401C60
	protected override int hi(cnm A_0)
	{
		if (A_0 == null || A_0.b8() == null)
		{
			return 50;
		}
		cd1 cd = A_0.b8().Offense.u();
		if (cd == null)
		{
			return 50;
		}
		double num;
		if (cd.TypedDefinition.e() == btz.j || cd.TypedDefinition.e() == btz.k)
		{
			num = 1.0;
		}
		else
		{
			num = as3.bo;
		}
		if (A_0 != null && A_0.b8() != null)
		{
			if (A_0.b8().StatusEffects.a(di.a) && (cd.TypedDefinition.e() == btz.c || cd.TypedDefinition.e() == btz.b))
			{
				return 0;
			}
			if (A_0.b8().Offense.u().TypedDefinition.e() == btz.b && A_0.b8().Feats.Contains<m6>())
			{
				num -= m6.a;
			}
		}
		return (int)Math.Min((double)base.hi(A_0) * num, 50.0);
	}

	// Token: 0x0600B204 RID: 45572 RVA: 0x00403B7C File Offset: 0x00401D7C
	protected override int ma(cnm A_0)
	{
		return c91.c(A_0) * this.a(A_0);
	}

	// Token: 0x0600B205 RID: 45573 RVA: 0x00403B90 File Offset: 0x00401D90
	private int a(cnm A_0)
	{
		double num = 1.0;
		if (A_0 != null && A_0.b8() != null)
		{
			if (A_0.b8().Offense.u().TypedDefinition.e() == btz.j)
			{
				num *= 0.75;
			}
			else if (A_0.b8().Offense.u().TypedDefinition.e() == btz.k)
			{
				num *= 0.65;
			}
			ajy ajy = c91.b(A_0);
			if (ajy != null)
			{
				double num2 = (double)ajy.b() / (double)c91.c(A_0);
				if (num2 > 0.0)
				{
					num *= 1.0 - num2;
				}
			}
		}
		return Math.Max(30, (int)(150.0 * num));
	}

	// Token: 0x0600B206 RID: 45574 RVA: 0x00403C64 File Offset: 0x00401E64
	protected override int mb(cnm A_0)
	{
		return this.a(A_0);
	}

	// Token: 0x04004142 RID: 16706
	private new List<string> a;
}
