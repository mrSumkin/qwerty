using System;
using System.Collections.Generic;

// Token: 0x02001DF2 RID: 7666
[d29("LocusOfControl", "Locus of Control")]
public sealed class cbv : ai8
{
	// Token: 0x0600A9AE RID: 43438 RVA: 0x003F2390 File Offset: 0x003F0590
	public override bool ap()
	{
		return false;
	}

	// Token: 0x0600A9AF RID: 43439 RVA: 0x003F2394 File Offset: 0x003F0594
	public cbv() : base("臢Локус контроля")
	{
	}

	// Token: 0x0600A9B0 RID: 43440 RVA: 0x003F23A4 File Offset: 0x003F05A4
	public override void ar(efk A_0)
	{
		A_0.SpecialAbilities.b(dgk.Get<djj>());
	}

	// Token: 0x0600A9B1 RID: 43441 RVA: 0x003F23B8 File Offset: 0x003F05B8
	public override void @as(efk A_0)
	{
		A_0.SpecialAbilities.a(dgk.Get<djj>());
	}

	// Token: 0x0600A9B2 RID: 43442 RVA: 0x003F23CC File Offset: 0x003F05CC
	public override object[] at()
	{
		return new object[]
		{
			l4.a((double)cbv.a, false),
			l4.a((double)cbv.b, false)
		};
	}

	// Token: 0x0600A9B3 RID: 43443 RVA: 0x003F23F4 File Offset: 0x003F05F4
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new awr(typeof(axr), 10),
			new bap(75, new Type[]
			{
				typeof(dql)
			}),
			new b4k(new Type[]
			{
				typeof(c3v)
			})
		};
	}

	// Token: 0x04003F95 RID: 16277
	public new static readonly int a = 3 * d0u.b;

	// Token: 0x04003F96 RID: 16278
	public new static readonly int b = 15 * d0u.b;
}
