using System;
using System.Collections.Generic;

// Token: 0x02001CA9 RID: 7337
[d29("EvasiveManeuvers", "Evasive Maneuvers")]
public sealed class a08 : ai8
{
	// Token: 0x0600A0CE RID: 41166 RVA: 0x003E6608 File Offset: 0x003E4808
	public a08() : base("胎Манёвр уворота")
	{
	}

	// Token: 0x0600A0CF RID: 41167 RVA: 0x003E6618 File Offset: 0x003E4818
	public override object[] at()
	{
		return new object[]
		{
			l4.a(enw.c, false),
			l4.a(enw.b, false)
		};
	}

	// Token: 0x0600A0D0 RID: 41168 RVA: 0x003E663C File Offset: 0x003E483C
	public override void ar(efk A_0)
	{
		A_0.SpecialAbilities.b(dgk.Get<enw>());
	}

	// Token: 0x0600A0D1 RID: 41169 RVA: 0x003E6650 File Offset: 0x003E4850
	public override void @as(efk A_0)
	{
		A_0.SpecialAbilities.a(dgk.Get<enw>());
	}

	// Token: 0x0600A0D2 RID: 41170 RVA: 0x003E6664 File Offset: 0x003E4864
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new awr(typeof(dqg), 6),
			new bap(50, new Type[]
			{
				typeof(erc)
			})
		};
	}
}
