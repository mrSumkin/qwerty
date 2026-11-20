using System;
using System.Collections.Generic;

// Token: 0x02001DF9 RID: 7673
[d29("S", "Snipe")]
public sealed class bbn : ai8
{
	// Token: 0x0600A9DE RID: 43486 RVA: 0x003F29E8 File Offset: 0x003F0BE8
	public override bool ap()
	{
		return false;
	}

	// Token: 0x0600A9DF RID: 43487 RVA: 0x003F29EC File Offset: 0x003F0BEC
	public bbn() : base("膃Снайперский выстрел")
	{
	}

	// Token: 0x0600A9E0 RID: 43488 RVA: 0x003F29FC File Offset: 0x003F0BFC
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new awr(typeof(eav), 10),
			new bap(35, new Type[]
			{
				typeof(ct7),
				typeof(e5n)
			}),
			new bap(30, new Type[]
			{
				typeof(a2n)
			}),
			new b4k(new Type[]
			{
				typeof(avk)
			})
		};
	}

	// Token: 0x0600A9E1 RID: 43489 RVA: 0x003F2A94 File Offset: 0x003F0C94
	public override void ar(efk A_0)
	{
		A_0.SpecialAttacks.b(dgk.Get<cit>());
	}

	// Token: 0x0600A9E2 RID: 43490 RVA: 0x003F2AA8 File Offset: 0x003F0CA8
	public override void @as(efk A_0)
	{
		A_0.SpecialAttacks.a(dgk.Get<cit>());
	}

	// Token: 0x0600A9E3 RID: 43491 RVA: 0x003F2ABC File Offset: 0x003F0CBC
	public override object[] at()
	{
		return new object[]
		{
			(int)((1.0 + cit.c) * 100.0),
			Math.Round(cit.d * 100.0, 1),
			l4.a((double)cit.b, false)
		};
	}
}
