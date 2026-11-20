using System;
using System.Collections.Generic;

// Token: 0x02001CE6 RID: 7398
[d29("Pummel", "Pummel")]
public sealed class aq1 : ai8
{
	// Token: 0x0600A27D RID: 41597 RVA: 0x003E952C File Offset: 0x003E772C
	public override bool ap()
	{
		return false;
	}

	// Token: 0x0600A27E RID: 41598 RVA: 0x003E9530 File Offset: 0x003E7730
	public aq1() : base("膱Избиение")
	{
	}

	// Token: 0x0600A27F RID: 41599 RVA: 0x003E9540 File Offset: 0x003E7740
	public override void ar(efk A_0)
	{
		A_0.SpecialAttacks.b(dgk.Get<bho>());
	}

	// Token: 0x0600A280 RID: 41600 RVA: 0x003E9554 File Offset: 0x003E7754
	public override void @as(efk A_0)
	{
		A_0.SpecialAttacks.a(dgk.Get<bho>());
	}

	// Token: 0x0600A281 RID: 41601 RVA: 0x003E956C File Offset: 0x003E776C
	public override object[] at()
	{
		return new object[]
		{
			(int)(bho.b * 100.0),
			l4.a((double)bho.c, false),
			bho.e,
			l4.a((double)bho.d, false)
		};
	}

	// Token: 0x0600A282 RID: 41602 RVA: 0x003E95C4 File Offset: 0x003E77C4
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new bap(20, new Type[]
			{
				typeof(jk)
			})
		};
	}
}
