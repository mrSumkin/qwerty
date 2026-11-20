using System;
using System.Collections.Generic;

// Token: 0x02001CE4 RID: 7396
[d29("Yell", "Yell")]
public sealed class er5 : ai8
{
	// Token: 0x0600A271 RID: 41585 RVA: 0x003E940C File Offset: 0x003E760C
	public er5() : base("肎Крик")
	{
	}

	// Token: 0x0600A272 RID: 41586 RVA: 0x003E941C File Offset: 0x003E761C
	public override void ar(efk A_0)
	{
		A_0.SpecialAbilities.b(dgk.Get<cv5>());
	}

	// Token: 0x0600A273 RID: 41587 RVA: 0x003E9430 File Offset: 0x003E7630
	public override void @as(efk A_0)
	{
		A_0.SpecialAbilities.a(dgk.Get<cv5>());
	}

	// Token: 0x0600A274 RID: 41588 RVA: 0x003E9444 File Offset: 0x003E7644
	public override object[] at()
	{
		return new object[]
		{
			(int)(cv5.e * 100.0),
			l4.a((double)cv5.d, false),
			l4.a((double)cv5.c, false)
		};
	}

	// Token: 0x0600A275 RID: 41589 RVA: 0x003E9484 File Offset: 0x003E7684
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new bap(20, new Type[]
			{
				typeof(bec)
			})
		};
	}
}
