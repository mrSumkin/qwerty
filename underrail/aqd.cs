using System;
using System.Collections.Generic;

// Token: 0x02000FAD RID: 4013
[ayj("EnergyShieldEmpowerment")]
public sealed class aqd : cx6
{
	// Token: 0x06005204 RID: 20996 RVA: 0x0024CA2C File Offset: 0x0024AC2C
	public override string y8()
	{
		return "Усиление энергетического щита";
	}

	// Token: 0x06005205 RID: 20997 RVA: 0x0024CA34 File Offset: 0x0024AC34
	public override string os()
	{
		return "EnergyShieldEmpowerment";
	}

	// Token: 0x06005206 RID: 20998 RVA: 0x0024CA3C File Offset: 0x0024AC3C
	public override ci8 bg()
	{
		return ci8.b;
	}

	// Token: 0x06005207 RID: 20999 RVA: 0x0024CA40 File Offset: 0x0024AC40
	public override IList<string> bi()
	{
		return new List<string>
		{
			aqd.e
		};
	}

	// Token: 0x06005208 RID: 21000 RVA: 0x0024CA54 File Offset: 0x0024AC54
	public override int bh()
	{
		return -2147483647;
	}

	// Token: 0x06005209 RID: 21001 RVA: 0x0024CA5C File Offset: 0x0024AC5C
	public override v5 c2()
	{
		return v5.a;
	}

	// Token: 0x0600520A RID: 21002 RVA: 0x0024CA60 File Offset: 0x0024AC60
	public override bool hl()
	{
		return true;
	}

	// Token: 0x0600520B RID: 21003 RVA: 0x0024CA64 File Offset: 0x0024AC64
	public override bool bk()
	{
		return true;
	}

	// Token: 0x0600520C RID: 21004 RVA: 0x0024CA68 File Offset: 0x0024AC68
	public override string bm(cnm A_0)
	{
		return "Xpbl_Abilities.30";
	}

	// Token: 0x0600520D RID: 21005 RVA: 0x0024CA70 File Offset: 0x0024AC70
	public override string bo(cnm A_0)
	{
		return qv.a("SpecialAbilities/EnergyShieldEmpowerment", new object[]
		{
			Convert.ToInt32(aqd.a * 100.0),
			aqd.f
		});
	}

	// Token: 0x0600520E RID: 21006 RVA: 0x0024CAAC File Offset: 0x0024ACAC
	public override string bp(cnm A_0)
	{
		return this.bo(A_0);
	}

	// Token: 0x0600520F RID: 21007 RVA: 0x0024CAB8 File Offset: 0x0024ACB8
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>
		{
			new cfd(aqd.e, 10000, false, false)
		};
	}

	// Token: 0x06005210 RID: 21008 RVA: 0x0024CAD8 File Offset: 0x0024ACD8
	public override List<els> j8(cnm A_0)
	{
		return new List<els>
		{
			new bwp()
		};
	}

	// Token: 0x06005211 RID: 21009 RVA: 0x0024CAF0 File Offset: 0x0024ACF0
	public override bool hm(cnm A_0)
	{
		return base.hm(A_0) && (A_0 != null && A_0.b8() != null && A_0.b8().Gear.l().Item != null) && A_0.b8().Gear.l().Item.Battery >= aqd.f;
	}

	// Token: 0x06005212 RID: 21010 RVA: 0x0024CB5C File Offset: 0x0024AD5C
	public override bool cu(cnm A_0)
	{
		return base.cu(A_0) && (A_0 != null && A_0.b8() != null && A_0.b8().Gear.l().Item != null) && A_0.b8().Gear.l().Item.Battery > 0.0;
	}

	// Token: 0x06005213 RID: 21011 RVA: 0x0024CBCC File Offset: 0x0024ADCC
	protected override int hi(cnm A_0)
	{
		return 5;
	}

	// Token: 0x04002192 RID: 8594
	public new static readonly double a = 0.3;

	// Token: 0x04002193 RID: 8595
	private const string b = "Energy Shield Empowerment";

	// Token: 0x04002194 RID: 8596
	private const string c = "EnergyShieldEmpowerment";

	// Token: 0x04002195 RID: 8597
	private const int d = 10000;

	// Token: 0x04002196 RID: 8598
	public new static readonly string e = "SA.EnergyShieldEmpowerment";

	// Token: 0x04002197 RID: 8599
	public new static readonly double f = 5.0;
}
