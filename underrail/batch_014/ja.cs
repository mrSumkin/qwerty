using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001F9C RID: 8092
[ayj("MorphineHypoConsumation")]
public sealed class ja : awn
{
	// Token: 0x0600BE1A RID: 48666 RVA: 0x0041868C File Offset: 0x0041688C
	public override string y8()
	{
		return "Morphine Hypo";
	}

	// Token: 0x0600BE1B RID: 48667 RVA: 0x00418694 File Offset: 0x00416894
	public override string os()
	{
		return "MorphineHypoConsumation";
	}

	// Token: 0x0600BE1C RID: 48668 RVA: 0x0041869C File Offset: 0x0041689C
	public override ci8 bg()
	{
		return ci8.b;
	}

	// Token: 0x0600BE1D RID: 48669 RVA: 0x004186A0 File Offset: 0x004168A0
	public ja()
	{
		this.f = new List<string>();
		this.f.Add("Meds.MorphineHypo");
	}

	// Token: 0x0600BE1E RID: 48670 RVA: 0x004186C4 File Offset: 0x004168C4
	public override string bm(cnm A_0)
	{
		return null;
	}

	// Token: 0x0600BE1F RID: 48671 RVA: 0x004186C8 File Offset: 0x004168C8
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.Self;
	}

	// Token: 0x0600BE20 RID: 48672 RVA: 0x004186CC File Offset: 0x004168CC
	public override string bo(cnm A_0)
	{
		return qv.a("Items\\Consumables/MorphineHypo", new object[]
		{
			(int)(ja.b * 100.0),
			l4.a(ja.a, false),
			(int)(ja.c * 100.0)
		});
	}

	// Token: 0x0600BE21 RID: 48673 RVA: 0x00418728 File Offset: 0x00416928
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>
		{
			new cfd("Meds.MorphineHypo", ja.e, false, false)
		};
	}

	// Token: 0x0600BE22 RID: 48674 RVA: 0x00418748 File Offset: 0x00416948
	public override IList<string> bi()
	{
		return this.f;
	}

	// Token: 0x0400444B RID: 17483
	public new static readonly int a = 3;

	// Token: 0x0400444C RID: 17484
	public static readonly double b = 0.5;

	// Token: 0x0400444D RID: 17485
	public static readonly double c = 0.5;

	// Token: 0x0400444E RID: 17486
	private const string d = "Meds.MorphineHypo";

	// Token: 0x0400444F RID: 17487
	private new static readonly int e = 10 * d0u.b;

	// Token: 0x04004450 RID: 17488
	private List<string> f;
}
