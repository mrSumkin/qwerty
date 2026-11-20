using System;
using System.Collections.Generic;

// Token: 0x02001E00 RID: 7680
[d29("H", "Hypothermia")]
public sealed class qz : ai8
{
	// Token: 0x0600AA06 RID: 43526 RVA: 0x003F2FFC File Offset: 0x003F11FC
	public override bool ap()
	{
		return false;
	}

	// Token: 0x0600AA07 RID: 43527 RVA: 0x003F3000 File Offset: 0x003F1200
	public qz() : base("臲Гипотермия")
	{
	}

	// Token: 0x0600AA08 RID: 43528 RVA: 0x003F3010 File Offset: 0x003F1210
	public override void ar(efk A_0)
	{
	}

	// Token: 0x0600AA09 RID: 43529 RVA: 0x003F3014 File Offset: 0x003F1214
	public override void @as(efk A_0)
	{
	}

	// Token: 0x0600AA0A RID: 43530 RVA: 0x003F3018 File Offset: 0x003F1218
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new bap(40, new Type[]
			{
				typeof(rs)
			}),
			new b6h(new Type[]
			{
				typeof(h7),
				typeof(cmp),
				typeof(d7l)
			})
		};
	}

	// Token: 0x0600AA0B RID: 43531 RVA: 0x003F3084 File Offset: 0x003F1284
	public override object[] at()
	{
		return new object[]
		{
			qz.a,
			qz.b,
			l4.a((double)qz.c, false)
		};
	}

	// Token: 0x04003FAB RID: 16299
	public new static readonly int a = 1;

	// Token: 0x04003FAC RID: 16300
	public new static readonly int b = 5;

	// Token: 0x04003FAD RID: 16301
	public static readonly int c = 120000;
}
