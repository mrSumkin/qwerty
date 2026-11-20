using System;
using System.Collections.Generic;

// Token: 0x02001DEC RID: 7660
[d29("PowerManagement", "Power Management")]
public sealed class e7f : ai8
{
	// Token: 0x0600A984 RID: 43396 RVA: 0x003F1E64 File Offset: 0x003F0064
	public override bool ap()
	{
		return false;
	}

	// Token: 0x0600A985 RID: 43397 RVA: 0x003F1E68 File Offset: 0x003F0068
	public e7f() : base("肊Управление питанием")
	{
	}

	// Token: 0x0600A986 RID: 43398 RVA: 0x003F1E78 File Offset: 0x003F0078
	public override void ar(efk A_0)
	{
	}

	// Token: 0x0600A987 RID: 43399 RVA: 0x003F1E7C File Offset: 0x003F007C
	public override void @as(efk A_0)
	{
	}

	// Token: 0x0600A988 RID: 43400 RVA: 0x003F1E80 File Offset: 0x003F0080
	public override object[] at()
	{
		return new object[]
		{
			(int)(e7f.a * 100.0)
		};
	}

	// Token: 0x0600A989 RID: 43401 RVA: 0x003F1EA0 File Offset: 0x003F00A0
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new awr(typeof(av8), 7),
			new bap(15, new Type[]
			{
				typeof(ij)
			})
		};
	}

	// Token: 0x04003F88 RID: 16264
	public new static readonly double a = 0.35;
}
