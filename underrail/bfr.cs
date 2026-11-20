using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001F82 RID: 8066
[ayj("NervosomniferConsumation")]
public sealed class bfr : awn
{
	// Token: 0x0600BD1C RID: 48412 RVA: 0x00417460 File Offset: 0x00415660
	public override string y8()
	{
		return "Нервосомнифер";
	}

	// Token: 0x0600BD1D RID: 48413 RVA: 0x00417468 File Offset: 0x00415668
	public override string os()
	{
		return "NervosomniferConsumation";
	}

	// Token: 0x0600BD1E RID: 48414 RVA: 0x00417470 File Offset: 0x00415670
	public override ci8 bg()
	{
		return ci8.b;
	}

	// Token: 0x0600BD1F RID: 48415 RVA: 0x00417474 File Offset: 0x00415674
	public override IList<string> bi()
	{
		return this.f;
	}

	// Token: 0x0600BD20 RID: 48416 RVA: 0x0041747C File Offset: 0x0041567C
	public bfr()
	{
		this.f = new List<string>
		{
			"Meds.MorphineHypo"
		};
	}

	// Token: 0x0600BD21 RID: 48417 RVA: 0x0041749C File Offset: 0x0041569C
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.Self;
	}

	// Token: 0x0600BD22 RID: 48418 RVA: 0x004174A0 File Offset: 0x004156A0
	public override string bo(cnm A_0)
	{
		return qv.a("Items\\Consumables/Nervosomnifer", new object[]
		{
			Convert.ToInt32(bfr.b * 100.0),
			l4.a(bfr.a, false),
			Convert.ToInt32(bfr.c * 100.0)
		});
	}

	// Token: 0x0600BD23 RID: 48419 RVA: 0x00417504 File Offset: 0x00415704
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>
		{
			new cfd("Meds.MorphineHypo", bfr.e, false, false)
		};
	}

	// Token: 0x0400440F RID: 17423
	public new static readonly int a = 4;

	// Token: 0x04004410 RID: 17424
	public static readonly double b = 0.6;

	// Token: 0x04004411 RID: 17425
	public static readonly double c = 0.35;

	// Token: 0x04004412 RID: 17426
	private const string d = "Meds.MorphineHypo";

	// Token: 0x04004413 RID: 17427
	private new static readonly int e = 10 * d0u.b;

	// Token: 0x04004414 RID: 17428
	private readonly List<string> f;
}
