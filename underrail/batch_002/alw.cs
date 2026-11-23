using System;
using System.Collections.Generic;

// Token: 0x02001E09 RID: 7689
[d29("S2", "Sprint")]
public sealed class alw : ai8
{
	// Token: 0x0600AA44 RID: 43588 RVA: 0x003F38B4 File Offset: 0x003F1AB4
	public alw() : base("胉Спринт")
	{
	}

	// Token: 0x0600AA45 RID: 43589 RVA: 0x003F38C4 File Offset: 0x003F1AC4
	public override void ar(efk A_0)
	{
		A_0.SpecialAbilities.b(dgk.Get<bbc>());
	}

	// Token: 0x0600AA46 RID: 43590 RVA: 0x003F38D8 File Offset: 0x003F1AD8
	public override void @as(efk A_0)
	{
		A_0.SpecialAbilities.a(dgk.Get<bbc>());
	}

	// Token: 0x0600AA47 RID: 43591 RVA: 0x003F38EC File Offset: 0x003F1AEC
	public override object[] at()
	{
		return new object[]
		{
			bbc.e,
			l4.a((double)bbc.f, false),
			l4.a((double)bbc.d, false)
		};
	}

	// Token: 0x0600AA48 RID: 43592 RVA: 0x003F3920 File Offset: 0x003F1B20
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new awr(typeof(dqg), 6)
		};
	}
}
