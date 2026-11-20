using System;
using System.Collections.Generic;

// Token: 0x02001C88 RID: 7304
[d29("RapidFire", "Rapid Fire")]
public sealed class elo : ai8
{
	// Token: 0x0600A008 RID: 40968 RVA: 0x003E4C48 File Offset: 0x003E2E48
	public override bool ap()
	{
		return false;
	}

	// Token: 0x0600A009 RID: 40969 RVA: 0x003E4C4C File Offset: 0x003E2E4C
	public elo() : base("胦Беглый огонь")
	{
	}

	// Token: 0x0600A00A RID: 40970 RVA: 0x003E4C5C File Offset: 0x003E2E5C
	public override void ar(efk A_0)
	{
		A_0.SpecialAttacks.b(dgk.Get<uw>());
	}

	// Token: 0x0600A00B RID: 40971 RVA: 0x003E4C70 File Offset: 0x003E2E70
	public override void @as(efk A_0)
	{
		A_0.SpecialAttacks.a(dgk.Get<uw>());
	}

	// Token: 0x0600A00C RID: 40972 RVA: 0x003E4C84 File Offset: 0x003E2E84
	public override object[] at()
	{
		return new object[]
		{
			uw.d,
			(int)(uw.c * 100.0),
			l4.a(uw.b, false)
		};
	}

	// Token: 0x0600A00D RID: 40973 RVA: 0x003E4CC0 File Offset: 0x003E2EC0
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new bap(50, new Type[]
			{
				typeof(ct7)
			})
		};
	}
}
