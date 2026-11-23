using System;
using System.Collections.Generic;

// Token: 0x02001DF3 RID: 7667
[d29("ForceUser", "Force User")]
public sealed class a9z : ai8
{
	// Token: 0x0600A9B5 RID: 43445 RVA: 0x003F247C File Offset: 0x003F067C
	public override bool ap()
	{
		return false;
	}

	// Token: 0x0600A9B6 RID: 43446 RVA: 0x003F2480 File Offset: 0x003F0680
	public a9z() : base("臧Сила с тобой")
	{
	}

	// Token: 0x0600A9B7 RID: 43447 RVA: 0x003F2490 File Offset: 0x003F0690
	public override void ar(efk A_0)
	{
	}

	// Token: 0x0600A9B8 RID: 43448 RVA: 0x003F2494 File Offset: 0x003F0694
	public override void @as(efk A_0)
	{
	}

	// Token: 0x0600A9B9 RID: 43449 RVA: 0x003F2498 File Offset: 0x003F0698
	public override object[] at()
	{
		return new object[]
		{
			(int)(a9z.a * 100.0),
			Convert.ToInt32(a9z.c * 100.0),
			a9z.b,
			a9z.d
		};
	}

	// Token: 0x0600A9BA RID: 43450 RVA: 0x003F24FC File Offset: 0x003F06FC
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new awr(typeof(axr), 7),
			new bap(25, new Type[]
			{
				typeof(fd)
			}),
			new b6h(new Type[]
			{
				typeof(dxh),
				typeof(cp5)
			})
		};
	}

	// Token: 0x04003F97 RID: 16279
	public new static readonly double a = 1.0;

	// Token: 0x04003F98 RID: 16280
	public new static readonly int b = 2;

	// Token: 0x04003F99 RID: 16281
	public static readonly double c = 0.5;

	// Token: 0x04003F9A RID: 16282
	public new static readonly int d = 1;
}
