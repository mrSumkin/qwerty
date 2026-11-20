using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001E9D RID: 7837
[ayj("CookedShot")]
public sealed class cks : bon, a5q
{
	// Token: 0x0600AFB2 RID: 44978 RVA: 0x003FE714 File Offset: 0x003FC914
	public override string y8()
	{
		return "Подготовленный выстрел";
	}

	// Token: 0x0600AFB3 RID: 44979 RVA: 0x003FE71C File Offset: 0x003FC91C
	public override string os()
	{
		return "CookedShot";
	}

	// Token: 0x0600AFB4 RID: 44980 RVA: 0x003FE724 File Offset: 0x003FC924
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600AFB5 RID: 44981 RVA: 0x003FE728 File Offset: 0x003FC928
	public override int ct()
	{
		return 2;
	}

	// Token: 0x0600AFB6 RID: 44982 RVA: 0x003FE72C File Offset: 0x003FC92C
	public override bool cs()
	{
		return false;
	}

	// Token: 0x0600AFB7 RID: 44983 RVA: 0x003FE730 File Offset: 0x003FC930
	public cks()
	{
		this.b = new List<string>();
		this.b.Add(d7f.a);
		this.b.Add("CookedShot");
	}

	// Token: 0x0600AFB8 RID: 44984 RVA: 0x003FE764 File Offset: 0x003FC964
	public override string bm(cnm A_0)
	{
		return "Attacks.9";
	}

	// Token: 0x0600AFB9 RID: 44985 RVA: 0x003FE770 File Offset: 0x003FC970
	public override bool hm(cnm A_0)
	{
		return base.hm(A_0) && A_0 != null && A_0.b8() != null && A_0.b8().Offense.u() != null && A_0.b8().Offense.u().TypedDefinition != null && euf.r(A_0.b8().Offense.u()) && eub.b(A_0.b8(), A_0.b8().Offense.u());
	}

	// Token: 0x0600AFBA RID: 44986 RVA: 0x003FE800 File Offset: 0x003FCA00
	public override bool cu(cnm A_0)
	{
		return A_0 != null && A_0.b8() != null && A_0.b8().Offense.u() != null && A_0.b8().Offense.u().TypedDefinition != null && euf.r(A_0.b8().Offense.u());
	}

	// Token: 0x0600AFBB RID: 44987 RVA: 0x003FE864 File Offset: 0x003FCA64
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.DiscoveredPenetrableSpot;
	}

	// Token: 0x0600AFBC RID: 44988 RVA: 0x003FE868 File Offset: 0x003FCA68
	public override string bo(cnm A_0)
	{
		double num;
		if (A_0 != null && A_0.b8() != null)
		{
			num = cks.a(A_0.b8());
		}
		else
		{
			num = 0.0;
		}
		if (num > 0.0)
		{
			return qv.a("SpecialAttacks/CookedShotBonusDamage", new object[]
			{
				(int)((1.0 + num) * 100.0)
			});
		}
		return qv.b("SpecialAttacks/CookedShot");
	}

	// Token: 0x0600AFBD RID: 44989 RVA: 0x003FE8EC File Offset: 0x003FCAEC
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		List<cfd> list = new List<cfd>();
		if (A_1 == v5.b)
		{
			list.Add(new cfd(d7f.a, d7f.g, true, false));
		}
		list.Add(new cfd("CookedShot", bkv.a * d0u.b, false, false));
		return list;
	}

	// Token: 0x0600AFBE RID: 44990 RVA: 0x003FE93C File Offset: 0x003FCB3C
	public override IList<string> bi()
	{
		return this.b;
	}

	// Token: 0x0600AFBF RID: 44991 RVA: 0x003FE948 File Offset: 0x003FCB48
	public static double a(efk A_0)
	{
		return 0.0 + (double)A_0.GetSpecializationValue<e3z>(true) * e3z.a + (A_0.SpecialCategoryModifiers[SpecialCategory.CookedShot].a - 1.0);
	}

	// Token: 0x0600AFC0 RID: 44992 RVA: 0x003FE98C File Offset: 0x003FCB8C
	protected override int br(cnm A_0)
	{
		return 750;
	}

	// Token: 0x0600AFC1 RID: 44993 RVA: 0x003FE994 File Offset: 0x003FCB94
	protected override int hi(cnm A_0)
	{
		double num = (double)base.hi(A_0);
		double num2 = 0.0;
		if (A_0 != null && A_0.b8() != null)
		{
			num2 = (double)A_0.b8().GetSpecializationValue<el6>(true) * el6.a;
		}
		return (int)(num * (bkv.b - num2));
	}

	// Token: 0x0600AFC2 RID: 44994 RVA: 0x003FE9E4 File Offset: 0x003FCBE4
	protected override int d2(cnm A_0)
	{
		return 1;
	}

	// Token: 0x0600AFC3 RID: 44995 RVA: 0x003FE9E8 File Offset: 0x003FCBE8
	public double[] f2(cnm A_0, double A_1, bool A_2, cmn A_3)
	{
		return euf.a(A_0.b8(), A_0.b8().Skills.Get<ct7>().g(), A_1, 0.0);
	}

	// Token: 0x040040B9 RID: 16569
	private new const string a = "CookedShot";

	// Token: 0x040040BA RID: 16570
	private List<string> b;
}
