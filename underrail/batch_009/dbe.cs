using System;
using System.Collections.Generic;

// Token: 0x02001DE9 RID: 7657
[d29("Ambush", "Ambush")]
public sealed class dbe : ai8
{
	// Token: 0x0600A970 RID: 43376 RVA: 0x003F1B98 File Offset: 0x003EFD98
	public dbe() : base("胖Засада")
	{
	}

	// Token: 0x0600A971 RID: 43377 RVA: 0x003F1BA8 File Offset: 0x003EFDA8
	public override void ar(efk A_0)
	{
	}

	// Token: 0x0600A972 RID: 43378 RVA: 0x003F1BAC File Offset: 0x003EFDAC
	public override void @as(efk A_0)
	{
	}

	// Token: 0x0600A973 RID: 43379 RVA: 0x003F1BB4 File Offset: 0x003EFDB4
	public override object[] at()
	{
		return new object[]
		{
			(int)(dbe.a * 100.0),
			(dbe.b * 100.0).ToString("0.0")
		};
	}

	// Token: 0x0600A974 RID: 43380 RVA: 0x003F1C00 File Offset: 0x003EFE00
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new awr(typeof(eav), 6),
			new bap(40, new Type[]
			{
				typeof(a2n)
			})
		};
	}

	// Token: 0x04003F83 RID: 16259
	public new static readonly double a = 0.2;

	// Token: 0x04003F84 RID: 16260
	public new static readonly double b = 0.003;
}
