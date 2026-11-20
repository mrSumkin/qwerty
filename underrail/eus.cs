using System;
using System.Collections.Generic;

// Token: 0x02000FB4 RID: 4020
[ayj("MetallineEnergization")]
public sealed class eus : cx6
{
	// Token: 0x0600525C RID: 21084 RVA: 0x0024DA2C File Offset: 0x0024BC2C
	public override string y8()
	{
		return "Электроактивная гибкость";
	}

	// Token: 0x0600525D RID: 21085 RVA: 0x0024DA34 File Offset: 0x0024BC34
	public override string os()
	{
		return "MetallineEnergization";
	}

	// Token: 0x0600525E RID: 21086 RVA: 0x0024DA3C File Offset: 0x0024BC3C
	public override ci8 bg()
	{
		return ci8.b;
	}

	// Token: 0x0600525F RID: 21087 RVA: 0x0024DA40 File Offset: 0x0024BC40
	public override IList<string> bi()
	{
		return new List<string>
		{
			eus.e
		};
	}

	// Token: 0x06005260 RID: 21088 RVA: 0x0024DA54 File Offset: 0x0024BC54
	public override int bh()
	{
		return -2147483647;
	}

	// Token: 0x06005261 RID: 21089 RVA: 0x0024DA5C File Offset: 0x0024BC5C
	public override v5 c2()
	{
		return v5.a;
	}

	// Token: 0x06005262 RID: 21090 RVA: 0x0024DA60 File Offset: 0x0024BC60
	public override bool hl()
	{
		return true;
	}

	// Token: 0x06005263 RID: 21091 RVA: 0x0024DA64 File Offset: 0x0024BC64
	public override bool bk()
	{
		return true;
	}

	// Token: 0x06005264 RID: 21092 RVA: 0x0024DA68 File Offset: 0x0024BC68
	public override string bm(cnm A_0)
	{
		return "Xpbl_Abilities.31";
	}

	// Token: 0x06005265 RID: 21093 RVA: 0x0024DA70 File Offset: 0x0024BC70
	public override string bo(cnm A_0)
	{
		return qv.a("SpecialAbilities/MetallineEnergization", new object[]
		{
			Convert.ToInt32(eus.a * 100.0),
			eus.f
		});
	}

	// Token: 0x06005266 RID: 21094 RVA: 0x0024DAAC File Offset: 0x0024BCAC
	public override string bp(cnm A_0)
	{
		return this.bo(A_0);
	}

	// Token: 0x06005267 RID: 21095 RVA: 0x0024DAB8 File Offset: 0x0024BCB8
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>
		{
			new cfd(eus.e, 10000, false, false)
		};
	}

	// Token: 0x06005268 RID: 21096 RVA: 0x0024DAD8 File Offset: 0x0024BCD8
	public override List<els> j8(cnm A_0)
	{
		return new List<els>
		{
			new dnb()
		};
	}

	// Token: 0x06005269 RID: 21097 RVA: 0x0024DAF0 File Offset: 0x0024BCF0
	public override bool hm(cnm A_0)
	{
		return base.hm(A_0) && (A_0 != null && A_0.b8() != null && A_0.b8().Gear.l().Item != null) && A_0.b8().Gear.l().Item.Battery >= eus.f;
	}

	// Token: 0x0600526A RID: 21098 RVA: 0x0024DB5C File Offset: 0x0024BD5C
	public override bool cu(cnm A_0)
	{
		return base.cu(A_0) && (A_0 != null && A_0.b8() != null && A_0.b8().Gear.l().Item != null) && A_0.b8().Gear.l().Item.Battery > 0.0;
	}

	// Token: 0x0600526B RID: 21099 RVA: 0x0024DBCC File Offset: 0x0024BDCC
	protected override int hi(cnm A_0)
	{
		return 5;
	}

	// Token: 0x040021C2 RID: 8642
	public new static readonly double a = 0.35;

	// Token: 0x040021C3 RID: 8643
	private const string b = "Electroactive Flexibility";

	// Token: 0x040021C4 RID: 8644
	private const string c = "MetallineEnergization";

	// Token: 0x040021C5 RID: 8645
	private const int d = 10000;

	// Token: 0x040021C6 RID: 8646
	public new static readonly string e = "SA.MetallineEnergization";

	// Token: 0x040021C7 RID: 8647
	public new static readonly double f = 5.0;
}
