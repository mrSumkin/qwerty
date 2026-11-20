using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001F8D RID: 8077
[ayj("SpiritPotionConsumption")]
public sealed class bai : awn
{
	// Token: 0x0600BD97 RID: 48535 RVA: 0x00417D68 File Offset: 0x00415F68
	public override string y8()
	{
		return "Зелье духа";
	}

	// Token: 0x0600BD98 RID: 48536 RVA: 0x00417D70 File Offset: 0x00415F70
	public override string os()
	{
		return "SpiritPotionConsumption";
	}

	// Token: 0x0600BD99 RID: 48537 RVA: 0x00417D78 File Offset: 0x00415F78
	public override ci8 bg()
	{
		return ci8.b;
	}

	// Token: 0x0600BD9A RID: 48538 RVA: 0x00417D7C File Offset: 0x00415F7C
	public bai()
	{
		this.d = new List<string>();
		this.d.Add(d7f.i);
	}

	// Token: 0x0600BD9B RID: 48539 RVA: 0x00417DA0 File Offset: 0x00415FA0
	public override string bm(cnm A_0)
	{
		return null;
	}

	// Token: 0x0600BD9C RID: 48540 RVA: 0x00417DA4 File Offset: 0x00415FA4
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.Self;
	}

	// Token: 0x0600BD9D RID: 48541 RVA: 0x00417DAC File Offset: 0x00415FAC
	public override string bo(cnm A_0)
	{
		return qv.a("Items\\Consumables/SpiritPotion", new object[]
		{
			bai.a,
			bai.b,
			l4.a(bai.c, false),
			a87.a,
			Convert.ToInt32(a87.b * 100.0),
			l4.a(a87.c, false)
		});
	}

	// Token: 0x0600BD9E RID: 48542 RVA: 0x00417E28 File Offset: 0x00416028
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>
		{
			d7f.k
		};
	}

	// Token: 0x0600BD9F RID: 48543 RVA: 0x00417E3C File Offset: 0x0041603C
	public override IList<cfd> p5(cnm A_0, v5 A_1)
	{
		return new List<cfd>
		{
			new cfd(alm.a, d7f.k.b, false, false)
		};
	}

	// Token: 0x0600BDA0 RID: 48544 RVA: 0x00417E60 File Offset: 0x00416060
	public override IList<string> bi()
	{
		return this.d;
	}

	// Token: 0x0400442B RID: 17451
	public new static readonly int a = 80;

	// Token: 0x0400442C RID: 17452
	public static readonly int b = 20;

	// Token: 0x0400442D RID: 17453
	public static readonly int c = 3;

	// Token: 0x0400442E RID: 17454
	private List<string> d;
}
