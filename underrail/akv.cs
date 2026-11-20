using System;
using System.Collections.Generic;

// Token: 0x02001DF7 RID: 7671
[d29("IM", "Execute")]
public sealed class akv : ai8
{
	// Token: 0x0600A9D2 RID: 43474 RVA: 0x003F283C File Offset: 0x003F0A3C
	public override bool ap()
	{
		return false;
	}

	// Token: 0x0600A9D3 RID: 43475 RVA: 0x003F2840 File Offset: 0x003F0A40
	public akv() : base("胷Казнь")
	{
	}

	// Token: 0x0600A9D4 RID: 43476 RVA: 0x003F2850 File Offset: 0x003F0A50
	public override void ar(efk A_0)
	{
		A_0.SpecialAttacks.b(dgk.Get<b13>());
	}

	// Token: 0x0600A9D5 RID: 43477 RVA: 0x003F2864 File Offset: 0x003F0A64
	public override void @as(efk A_0)
	{
		A_0.SpecialAttacks.a(dgk.Get<b13>());
	}

	// Token: 0x0600A9D6 RID: 43478 RVA: 0x003F2878 File Offset: 0x003F0A78
	public override object[] at()
	{
		return new object[]
		{
			(int)(akv.a * 100.0),
			l4.a(akv.b, false)
		};
	}

	// Token: 0x0600A9D7 RID: 43479 RVA: 0x003F28AC File Offset: 0x003F0AAC
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new bap(70, new Type[]
			{
				typeof(ct7)
			}),
			new b4k(new Type[]
			{
				typeof(zf)
			})
		};
	}

	// Token: 0x04003F9F RID: 16287
	public new static readonly double a = 2.5;

	// Token: 0x04003FA0 RID: 16288
	public new static readonly int b = 5;
}
