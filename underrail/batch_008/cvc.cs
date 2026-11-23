using System;
using System.Collections.Generic;

// Token: 0x02001DF1 RID: 7665
[d29("Tranquility", "Tranquility")]
public sealed class cvc : ai8
{
	// Token: 0x0600A9A7 RID: 43431 RVA: 0x003F2304 File Offset: 0x003F0504
	public override bool ap()
	{
		return false;
	}

	// Token: 0x0600A9A8 RID: 43432 RVA: 0x003F2308 File Offset: 0x003F0508
	public cvc() : base("臓Уравновешенность")
	{
	}

	// Token: 0x0600A9A9 RID: 43433 RVA: 0x003F2318 File Offset: 0x003F0518
	public override void ar(efk A_0)
	{
	}

	// Token: 0x0600A9AA RID: 43434 RVA: 0x003F231C File Offset: 0x003F051C
	public override void @as(efk A_0)
	{
	}

	// Token: 0x0600A9AB RID: 43435 RVA: 0x003F2320 File Offset: 0x003F0520
	public override object[] at()
	{
		return new object[]
		{
			cvc.a
		};
	}

	// Token: 0x0600A9AC RID: 43436 RVA: 0x003F2338 File Offset: 0x003F0538
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new b4k(new Type[]
			{
				typeof(c3v)
			}),
			new c2y(new Type[]
			{
				typeof(c80)
			})
		};
	}

	// Token: 0x04003F94 RID: 16276
	public new static readonly int a = 5;
}
