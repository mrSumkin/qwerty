using System;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001F97 RID: 8087
[ayj("HerculesConsumation")]
public sealed class avr : awn
{
	// Token: 0x0600BDF2 RID: 48626 RVA: 0x00418458 File Offset: 0x00416658
	public override string y8()
	{
		return "Геракл";
	}

	// Token: 0x0600BDF3 RID: 48627 RVA: 0x00418460 File Offset: 0x00416660
	public override string os()
	{
		return "HerculesConsumation";
	}

	// Token: 0x0600BDF4 RID: 48628 RVA: 0x00418468 File Offset: 0x00416668
	public override ci8 bg()
	{
		return ci8.b;
	}

	// Token: 0x0600BDF6 RID: 48630 RVA: 0x00418474 File Offset: 0x00416674
	public override string bm(cnm A_0)
	{
		return null;
	}

	// Token: 0x0600BDF7 RID: 48631 RVA: 0x00418478 File Offset: 0x00416678
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.Self;
	}

	// Token: 0x0600BDF8 RID: 48632 RVA: 0x0041847C File Offset: 0x0041667C
	public override string bo(cnm A_0)
	{
		return qv.a("Items\\Consumables/Hercules", new object[]
		{
			cqr.a,
			l4.a(avr.a, false)
		});
	}

	// Token: 0x04004446 RID: 17478
	public new static readonly int a = 10;
}
