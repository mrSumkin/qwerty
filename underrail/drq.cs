using System;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001F99 RID: 8089
[ayj("FocusStimConsumation")]
public sealed class drq : awn
{
	// Token: 0x0600BE02 RID: 48642 RVA: 0x00418538 File Offset: 0x00416738
	public override string y8()
	{
		return "Стимулятор внимания";
	}

	// Token: 0x0600BE03 RID: 48643 RVA: 0x00418540 File Offset: 0x00416740
	public override string os()
	{
		return "FocusStimConsumation";
	}

	// Token: 0x0600BE04 RID: 48644 RVA: 0x00418548 File Offset: 0x00416748
	public override ci8 bg()
	{
		return ci8.b;
	}

	// Token: 0x0600BE06 RID: 48646 RVA: 0x00418554 File Offset: 0x00416754
	public override string bm(cnm A_0)
	{
		return null;
	}

	// Token: 0x0600BE07 RID: 48647 RVA: 0x00418558 File Offset: 0x00416758
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.Self;
	}

	// Token: 0x0600BE08 RID: 48648 RVA: 0x0041855C File Offset: 0x0041675C
	public override string bo(cnm A_0)
	{
		return qv.a("Items\\Consumables/FocusStim", new object[]
		{
			(int)(j3.a * 100.0),
			l4.a(drq.a, false)
		});
	}

	// Token: 0x04004448 RID: 17480
	public new static readonly int a = 10;
}
