using System;
using System.Collections.Generic;

// Token: 0x02001DEA RID: 7658
[d29("Deflection", "Deflection")]
public sealed class bw8 : ai8
{
	// Token: 0x0600A976 RID: 43382 RVA: 0x003F1C6C File Offset: 0x003EFE6C
	public bw8() : base("臄Ката")
	{
	}

	// Token: 0x0600A977 RID: 43383 RVA: 0x003F1C7C File Offset: 0x003EFE7C
	public override void ar(efk A_0)
	{
	}

	// Token: 0x0600A978 RID: 43384 RVA: 0x003F1C80 File Offset: 0x003EFE80
	public override void @as(efk A_0)
	{
	}

	// Token: 0x0600A979 RID: 43385 RVA: 0x003F1C84 File Offset: 0x003EFE84
	public override List<d3e> cy(efk A_0)
	{
		return new List<d3e>
		{
			new eyz()
		};
	}

	// Token: 0x0600A97A RID: 43386 RVA: 0x003F1C98 File Offset: 0x003EFE98
	public override object[] at()
	{
		return new object[]
		{
			(int)(bw8.a * 100.0)
		};
	}

	// Token: 0x0600A97B RID: 43387 RVA: 0x003F1CBC File Offset: 0x003EFEBC
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new awr(typeof(cwu), 6),
			new bap(35, new Type[]
			{
				typeof(jk)
			})
		};
	}

	// Token: 0x04003F85 RID: 16261
	public new static readonly double a = 0.3;
}
