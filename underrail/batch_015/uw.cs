using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001EB3 RID: 7859
[ayj("RapidFire")]
public sealed class uw : bon
{
	// Token: 0x0600B0EE RID: 45294 RVA: 0x00400D10 File Offset: 0x003FEF10
	public override string y8()
	{
		return "Беглый огонь";
	}

	// Token: 0x0600B0EF RID: 45295 RVA: 0x00400D18 File Offset: 0x003FEF18
	public override string os()
	{
		return "RapidFire";
	}

	// Token: 0x0600B0F0 RID: 45296 RVA: 0x00400D20 File Offset: 0x003FEF20
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600B0F1 RID: 45297 RVA: 0x00400D24 File Offset: 0x003FEF24
	public override bool cs()
	{
		return false;
	}

	// Token: 0x0600B0F2 RID: 45298 RVA: 0x00400D28 File Offset: 0x003FEF28
	public override int ct()
	{
		return 2;
	}

	// Token: 0x0600B0F3 RID: 45299 RVA: 0x00400D2C File Offset: 0x003FEF2C
	public override IList<string> bi()
	{
		return this.e;
	}

	// Token: 0x0600B0F4 RID: 45300 RVA: 0x00400D34 File Offset: 0x003FEF34
	public override bool j7()
	{
		return true;
	}

	// Token: 0x0600B0F5 RID: 45301 RVA: 0x00400D38 File Offset: 0x003FEF38
	public override bool l8()
	{
		return false;
	}

	// Token: 0x0600B0F6 RID: 45302 RVA: 0x00400D3C File Offset: 0x003FEF3C
	public uw()
	{
		this.e = new List<string>();
		this.e.Add(d7f.a);
		this.e.Add("SAt.RapidFire");
	}

	// Token: 0x0600B0F7 RID: 45303 RVA: 0x00400D70 File Offset: 0x003FEF70
	public override string bm(cnm A_0)
	{
		return "RapidFire";
	}

	// Token: 0x0600B0F8 RID: 45304 RVA: 0x00400D7C File Offset: 0x003FEF7C
	public override bool hm(cnm A_0)
	{
		return base.hm(A_0) && A_0 != null && A_0.b8() != null && A_0.b8().Offense.u() != null && A_0.b8().Offense.u().TypedDefinition != null && euf.m(A_0.b8().Offense.u()) && A_0.b8().Offense.u().TypedDefinition.e() != btz.d && A_0.b8().Offense.u().TypedDefinition.e() != btz.e && A_0.b8().Offense.u().TypedDefinition.e() != btz.h && A_0.b8().Offense.u().TypedDefinition.e() != btz.l && (eub.b(A_0.b8(), A_0.b8().Offense.u()) || A_0.b8().Offense.u().TypedDefinition.g());
	}

	// Token: 0x0600B0F9 RID: 45305 RVA: 0x00400EB0 File Offset: 0x003FF0B0
	public override bool cu(cnm A_0)
	{
		return base.cu(A_0) && A_0 != null && A_0.b8() != null && A_0.b8().Offense.u() != null && A_0.b8().Offense.u().TypedDefinition != null && euf.m(A_0.b8().Offense.u()) && A_0.b8().Offense.u().TypedDefinition.e() != btz.d && A_0.b8().Offense.u().TypedDefinition.e() != btz.e && A_0.b8().Offense.u().TypedDefinition.e() != btz.h && A_0.b8().Offense.u().TypedDefinition.e() != btz.l;
	}

	// Token: 0x0600B0FA RID: 45306 RVA: 0x00400FA8 File Offset: 0x003FF1A8
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.CreatureNotSelf;
	}

	// Token: 0x0600B0FB RID: 45307 RVA: 0x00400FAC File Offset: 0x003FF1AC
	public override string bo(cnm A_0)
	{
		return qv.a("SpecialAttacks/RapidFire", new object[]
		{
			uw.d
		});
	}

	// Token: 0x0600B0FC RID: 45308 RVA: 0x00400FD0 File Offset: 0x003FF1D0
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		List<cfd> list = new List<cfd>();
		if (A_1 == v5.b)
		{
			list.Add(new cfd(d7f.a, d7f.g, true, false));
		}
		list.Add(new cfd("SAt.RapidFire", uw.b * d0u.b, false, false));
		return list;
	}

	// Token: 0x0600B0FD RID: 45309 RVA: 0x00401020 File Offset: 0x003FF220
	public override double l9(cnm A_0, double A_1)
	{
		if (A_1 > 2.0)
		{
			double num = d05.b(0.1, (A_1 - 2.0) / (double)Math.Max(1f, A_0.b8().Offense.u().TypedDefinition.ad()) * 0.66, 0.75);
			return 1.0 - num;
		}
		return 1.0;
	}

	// Token: 0x0600B0FE RID: 45310 RVA: 0x004010A4 File Offset: 0x003FF2A4
	protected override float cl(cnm A_0)
	{
		double num = uw.c;
		if (A_0 != null && A_0.b8() != null)
		{
			num -= (double)A_0.b8().GetSpecializationValue<bvk>(true) * bvk.a;
		}
		return (float)num;
	}

	// Token: 0x0600B0FF RID: 45311 RVA: 0x004010E0 File Offset: 0x003FF2E0
	protected override int ma(cnm A_0)
	{
		return uw.d * 210;
	}

	// Token: 0x0600B100 RID: 45312 RVA: 0x004010F0 File Offset: 0x003FF2F0
	protected override int mb(cnm A_0)
	{
		return 210;
	}

	// Token: 0x040040F7 RID: 16631
	private new const string a = "SAt.RapidFire";

	// Token: 0x040040F8 RID: 16632
	public static readonly int b = 2;

	// Token: 0x040040F9 RID: 16633
	public static readonly double c = 1.5;

	// Token: 0x040040FA RID: 16634
	public static readonly int d = 3;

	// Token: 0x040040FB RID: 16635
	private new List<string> e;
}
