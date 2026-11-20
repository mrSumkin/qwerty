using System;
using System.Collections.Generic;

// Token: 0x02001DEF RID: 7663
[d29("Premeditation", "Premeditation")]
public sealed class pv : ai8
{
	// Token: 0x0600A998 RID: 43416 RVA: 0x003F20A4 File Offset: 0x003F02A4
	public override bool ap()
	{
		return false;
	}

	// Token: 0x0600A999 RID: 43417 RVA: 0x003F20A8 File Offset: 0x003F02A8
	public pv() : base("臕Премедитация")
	{
	}

	// Token: 0x0600A99A RID: 43418 RVA: 0x003F20B8 File Offset: 0x003F02B8
	public override void ar(efk A_0)
	{
		A_0.SpecialAbilities.b(dgk.Get<e9>());
	}

	// Token: 0x0600A99B RID: 43419 RVA: 0x003F20CC File Offset: 0x003F02CC
	public override void @as(efk A_0)
	{
		A_0.SpecialAbilities.a(dgk.Get<e9>());
	}

	// Token: 0x0600A99C RID: 43420 RVA: 0x003F20E0 File Offset: 0x003F02E0
	public override object[] at()
	{
		return new object[]
		{
			(int)(pv.d * 100.0),
			(int)(pv.e * 100.0),
			pv.a,
			l4.a((double)pv.b, false)
		};
	}

	// Token: 0x0600A99D RID: 43421 RVA: 0x003F2140 File Offset: 0x003F0340
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new awr(typeof(av8), 6),
			new db7(40),
			new b4k(new Type[]
			{
				typeof(c3v)
			})
		};
	}

	// Token: 0x04003F8D RID: 16269
	public new static readonly float a = 3f;

	// Token: 0x04003F8E RID: 16270
	public new static readonly int b = 5 * d0u.b;

	// Token: 0x04003F8F RID: 16271
	public static readonly int c = 3 * d0u.b;

	// Token: 0x04003F90 RID: 16272
	public new static readonly double d = 0.5;

	// Token: 0x04003F91 RID: 16273
	public new static readonly double e = 1.0;
}
