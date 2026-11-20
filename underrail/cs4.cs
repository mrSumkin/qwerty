using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001ED3 RID: 7891
[ayj("ElectroshockAura")]
public sealed class cs4 : cx6
{
	// Token: 0x0600B2E2 RID: 45794 RVA: 0x00405C28 File Offset: 0x00403E28
	public override string y8()
	{
		return "Электрошоковая аура";
	}

	// Token: 0x0600B2E3 RID: 45795 RVA: 0x00405C30 File Offset: 0x00403E30
	public override string os()
	{
		return "ElectroshockAura";
	}

	// Token: 0x0600B2E4 RID: 45796 RVA: 0x00405C38 File Offset: 0x00403E38
	public override ci8 bg()
	{
		return ci8.b;
	}

	// Token: 0x0600B2E5 RID: 45797 RVA: 0x00405C3C File Offset: 0x00403E3C
	public override IList<string> bi()
	{
		return new List<string>
		{
			cs4.d
		};
	}

	// Token: 0x0600B2E6 RID: 45798 RVA: 0x00405C50 File Offset: 0x00403E50
	public override int bh()
	{
		return int.MinValue;
	}

	// Token: 0x0600B2E7 RID: 45799 RVA: 0x00405C58 File Offset: 0x00403E58
	public override v5 c2()
	{
		return v5.a;
	}

	// Token: 0x0600B2E8 RID: 45800 RVA: 0x00405C5C File Offset: 0x00403E5C
	public override bool hl()
	{
		return true;
	}

	// Token: 0x0600B2E9 RID: 45801 RVA: 0x00405C60 File Offset: 0x00403E60
	public override bool bk()
	{
		return true;
	}

	// Token: 0x0600B2EA RID: 45802 RVA: 0x00405C64 File Offset: 0x00403E64
	public override string bm(cnm A_0)
	{
		return "xpbl_Abilities.10";
	}

	// Token: 0x0600B2EB RID: 45803 RVA: 0x00405C6C File Offset: 0x00403E6C
	public override string bo(cnm A_0)
	{
		return qv.a("SpecialAbilities/ElectroshockAura", new object[]
		{
			cs4.e,
			cs4.a().a(true),
			cs4.f,
			Convert.ToInt32(cs4.i * 100.0),
			l4.a(cs4.j, false)
		});
	}

	// Token: 0x0600B2EC RID: 45804 RVA: 0x00405CE0 File Offset: 0x00403EE0
	public override string bp(cnm A_0)
	{
		return this.bo(A_0);
	}

	// Token: 0x0600B2ED RID: 45805 RVA: 0x00405CEC File Offset: 0x00403EEC
	public static a1q a()
	{
		return new a1q(DamageType.Electricity, cs4.g, cs4.h);
	}

	// Token: 0x0600B2EE RID: 45806 RVA: 0x00405D00 File Offset: 0x00403F00
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>
		{
			new cfd(cs4.d, 10000, false, false)
		};
	}

	// Token: 0x0600B2EF RID: 45807 RVA: 0x00405D20 File Offset: 0x00403F20
	public override List<els> j8(cnm A_0)
	{
		return new List<els>
		{
			new e2p()
		};
	}

	// Token: 0x0600B2F0 RID: 45808 RVA: 0x00405D38 File Offset: 0x00403F38
	public override bool hm(cnm A_0)
	{
		return base.hm(A_0) && (A_0 != null && A_0.b8() != null && A_0.b8().Gear.l().Item != null) && A_0.b8().Gear.l().Item.Battery >= cs4.e;
	}

	// Token: 0x0600B2F1 RID: 45809 RVA: 0x00405DA4 File Offset: 0x00403FA4
	public override bool cu(cnm A_0)
	{
		return base.cu(A_0) && (A_0 != null && A_0.b8() != null && A_0.b8().Gear.l().Item != null) && A_0.b8().Gear.l().Item.Battery >= 0.0;
	}

	// Token: 0x0600B2F2 RID: 45810 RVA: 0x00405E14 File Offset: 0x00404014
	protected override int hi(cnm A_0)
	{
		return 5;
	}

	// Token: 0x04004174 RID: 16756
	private new const string a = "Electroshock Aura";

	// Token: 0x04004175 RID: 16757
	private const string b = "ElectroshockAura";

	// Token: 0x04004176 RID: 16758
	private const int c = 10000;

	// Token: 0x04004177 RID: 16759
	public static readonly string d = "SA.ElectroshockAura";

	// Token: 0x04004178 RID: 16760
	public new static readonly double e = 5.0;

	// Token: 0x04004179 RID: 16761
	public new static readonly double f = 3.0;

	// Token: 0x0400417A RID: 16762
	private static readonly int g = 25;

	// Token: 0x0400417B RID: 16763
	private static readonly int h = 50;

	// Token: 0x0400417C RID: 16764
	public static readonly double i = 0.25;

	// Token: 0x0400417D RID: 16765
	public static readonly int j = 1;
}
