using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001EB4 RID: 7860
[ayj("PointShot")]
public sealed class d5j : bon
{
	// Token: 0x0600B102 RID: 45314 RVA: 0x00401114 File Offset: 0x003FF314
	public override string y8()
	{
		return "Выстрел навскидку";
	}

	// Token: 0x0600B103 RID: 45315 RVA: 0x0040111C File Offset: 0x003FF31C
	public override string os()
	{
		return "PointShot";
	}

	// Token: 0x0600B104 RID: 45316 RVA: 0x00401124 File Offset: 0x003FF324
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600B105 RID: 45317 RVA: 0x00401128 File Offset: 0x003FF328
	public override bool cs()
	{
		return false;
	}

	// Token: 0x0600B106 RID: 45318 RVA: 0x0040112C File Offset: 0x003FF32C
	public override int ct()
	{
		return 2;
	}

	// Token: 0x0600B107 RID: 45319 RVA: 0x00401130 File Offset: 0x003FF330
	public override bool j7()
	{
		return true;
	}

	// Token: 0x0600B108 RID: 45320 RVA: 0x00401134 File Offset: 0x003FF334
	public d5j()
	{
		this.d = new List<string>();
		this.d.Add(d7f.a);
		this.d.Add("SAt.PointShot");
	}

	// Token: 0x0600B109 RID: 45321 RVA: 0x00401168 File Offset: 0x003FF368
	public override string bm(cnm A_0)
	{
		return "PointShot";
	}

	// Token: 0x0600B10A RID: 45322 RVA: 0x00401170 File Offset: 0x003FF370
	public override bool hm(cnm A_0)
	{
		return base.hm(A_0) && A_0 != null && A_0.b8() != null && A_0.b8().Offense.u() != null && A_0.b8().Offense.u().TypedDefinition != null && A_0.b8().Offense.u().TypedDefinition.e() != btz.g && A_0.b8().Offense.u().TypedDefinition.e() != btz.f && euf.d(A_0.b8().Offense.u().TypedDefinition).GetValueOrDefault() != WeaponSubtype.Sniper_762 && euf.d(A_0.b8().Offense.u().TypedDefinition).GetValueOrDefault() != WeaponSubtype.Sniper_86 && euf.d(A_0.b8().Offense.u().TypedDefinition).GetValueOrDefault() != WeaponSubtype.Sniper_127 && euf.d(A_0.b8().Offense.u().TypedDefinition).GetValueOrDefault() != WeaponSubtype.Pistol_Sonic && !euf.k(A_0.b8().Offense.u()) && !euf.i(A_0.b8().Offense.u()) && A_0.b8().Offense.u().TypedDefinition.e() != btz.j && A_0.b8().Offense.u().TypedDefinition.e() != btz.k && A_0.b8().Offense.u().TypedDefinition.e() != btz.i && A_0.b8().Offense.u().TypedDefinition.e() != btz.l;
	}

	// Token: 0x0600B10B RID: 45323 RVA: 0x00401368 File Offset: 0x003FF568
	public override bool cu(cnm A_0)
	{
		return base.cu(A_0) && A_0 != null && A_0.b8() != null && A_0.b8().Offense.u() != null && A_0.b8().Offense.u().TypedDefinition != null && A_0.b8().Offense.u().TypedDefinition.e() != btz.g && A_0.b8().Offense.u().TypedDefinition.e() != btz.f && euf.d(A_0.b8().Offense.u().TypedDefinition).GetValueOrDefault() != WeaponSubtype.Sniper_762 && euf.d(A_0.b8().Offense.u().TypedDefinition).GetValueOrDefault() != WeaponSubtype.Sniper_86 && euf.d(A_0.b8().Offense.u().TypedDefinition).GetValueOrDefault() != WeaponSubtype.Sniper_127 && euf.d(A_0.b8().Offense.u().TypedDefinition).GetValueOrDefault() != WeaponSubtype.Pistol_Sonic && !euf.k(A_0.b8().Offense.u()) && !euf.i(A_0.b8().Offense.u()) && A_0.b8().Offense.u().TypedDefinition.e() != btz.j && A_0.b8().Offense.u().TypedDefinition.e() != btz.k && A_0.b8().Offense.u().TypedDefinition.e() != btz.i && A_0.b8().Offense.u().TypedDefinition.e() != btz.l;
	}

	// Token: 0x0600B10C RID: 45324 RVA: 0x00401560 File Offset: 0x003FF760
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.CreatureNotSelf;
	}

	// Token: 0x0600B10D RID: 45325 RVA: 0x00401564 File Offset: 0x003FF764
	public override string bo(cnm A_0)
	{
		return qv.a("SpecialAttacks/PointShot", new object[]
		{
			(int)(d5j.a(A_0) * 100.0)
		});
	}

	// Token: 0x0600B10E RID: 45326 RVA: 0x00401590 File Offset: 0x003FF790
	private new static double a(cnm A_0)
	{
		double num = d5j.c;
		if (A_0 != null && A_0.b8() != null)
		{
			num -= (double)A_0.b8().GetSpecializationValue<d84>(true) * d84.a;
			dvm microfeat = A_0.b8().GetMicrofeat<dvm>();
			if (microfeat != null)
			{
				num += microfeat.a();
			}
		}
		return Math.Max(0.0, num);
	}

	// Token: 0x0600B10F RID: 45327 RVA: 0x004015F8 File Offset: 0x003FF7F8
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		List<cfd> list = new List<cfd>();
		if (A_1 == v5.b)
		{
			list.Add(new cfd(d7f.a, d7f.g, true, false));
		}
		list.Add(new cfd("SAt.PointShot", d5j.b, false, false));
		return list;
	}

	// Token: 0x0600B110 RID: 45328 RVA: 0x00401644 File Offset: 0x003FF844
	public override IList<string> bi()
	{
		return this.d;
	}

	// Token: 0x0600B111 RID: 45329 RVA: 0x00401650 File Offset: 0x003FF850
	public override double l9(cnm A_0, double A_1)
	{
		if (A_0 != null && A_0.b8() != null && A_1 > 2.0)
		{
			double num = d05.b(0.1, (A_1 - 2.0) / (double)Math.Max(1f, A_0.b8().Offense.u().TypedDefinition.ad()) * 0.66, 0.75);
			if (A_0.b8().GetMicrofeat<ba7>() != null)
			{
				num /= 2.0;
			}
			return 1.0 - num;
		}
		return 1.0;
	}

	// Token: 0x0600B112 RID: 45330 RVA: 0x00401704 File Offset: 0x003FF904
	protected override int br(cnm A_0)
	{
		return 500;
	}

	// Token: 0x0600B113 RID: 45331 RVA: 0x0040170C File Offset: 0x003FF90C
	protected override int hi(cnm A_0)
	{
		return (int)((double)base.hi(A_0) * d5j.a(A_0));
	}

	// Token: 0x040040FC RID: 16636
	private new const string a = "SAt.PointShot";

	// Token: 0x040040FD RID: 16637
	public static readonly int b = d0u.b;

	// Token: 0x040040FE RID: 16638
	public static readonly double c = 0.5;

	// Token: 0x040040FF RID: 16639
	private List<string> d;
}
