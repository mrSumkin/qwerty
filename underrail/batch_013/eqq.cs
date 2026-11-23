using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001F83 RID: 8067
[ayj("PsionicInhalantConsumation")]
public sealed class eqq : awn
{
	// Token: 0x0600BD25 RID: 48421 RVA: 0x00417558 File Offset: 0x00415758
	public override string y8()
	{
		return "Псионический ингалянт";
	}

	// Token: 0x0600BD26 RID: 48422 RVA: 0x00417560 File Offset: 0x00415760
	public override string os()
	{
		return "PsionicInhalantConsumation";
	}

	// Token: 0x0600BD27 RID: 48423 RVA: 0x00417568 File Offset: 0x00415768
	public override ci8 bg()
	{
		return ci8.b;
	}

	// Token: 0x0600BD28 RID: 48424 RVA: 0x0041756C File Offset: 0x0041576C
	public override v5 c2()
	{
		return v5.b;
	}

	// Token: 0x0600BD29 RID: 48425 RVA: 0x00417570 File Offset: 0x00415770
	public eqq()
	{
		this.d = new List<string>();
	}

	// Token: 0x0600BD2A RID: 48426 RVA: 0x00417584 File Offset: 0x00415784
	public override string bm(cnm A_0)
	{
		return null;
	}

	// Token: 0x0600BD2B RID: 48427 RVA: 0x00417588 File Offset: 0x00415788
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.Self;
	}

	// Token: 0x0600BD2C RID: 48428 RVA: 0x0041758C File Offset: 0x0041578C
	public override string bo(cnm A_0)
	{
		return qv.a("Items\\Consumables/PsionicInhalant", new object[]
		{
			eqq.a,
			eqq.b,
			eqq.c / 1000
		});
	}

	// Token: 0x0600BD2D RID: 48429 RVA: 0x004175CC File Offset: 0x004157CC
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>();
	}

	// Token: 0x0600BD2E RID: 48430 RVA: 0x004175D4 File Offset: 0x004157D4
	public override IList<string> bi()
	{
		return this.d;
	}

	// Token: 0x0600BD2F RID: 48431 RVA: 0x004175DC File Offset: 0x004157DC
	public static int a()
	{
		return eqq.c;
	}

	// Token: 0x0600BD30 RID: 48432 RVA: 0x004175E4 File Offset: 0x004157E4
	public int a(cnm A_0)
	{
		return eqq.a / (eqq.c / base.h(A_0));
	}

	// Token: 0x0600BD31 RID: 48433 RVA: 0x004175FC File Offset: 0x004157FC
	public int b(cnm A_0)
	{
		return eqq.b / (eqq.c / base.h(A_0));
	}

	// Token: 0x0600BD32 RID: 48434 RVA: 0x00417614 File Offset: 0x00415814
	protected override int ma(cnm A_0)
	{
		return eqq.a();
	}

	// Token: 0x0600BD33 RID: 48435 RVA: 0x0041761C File Offset: 0x0041581C
	protected override int mb(cnm A_0)
	{
		return 700;
	}

	// Token: 0x04004415 RID: 17429
	public new static readonly int a = 1500;

	// Token: 0x04004416 RID: 17430
	public static readonly int b = 200;

	// Token: 0x04004417 RID: 17431
	public static readonly int c = 10000;

	// Token: 0x04004418 RID: 17432
	private List<string> d;
}
