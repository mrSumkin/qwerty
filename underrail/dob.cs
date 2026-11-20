using System;
using System.Collections.Generic;

// Token: 0x02001C48 RID: 7240
[d29("TattooProtectorate", "Tattoo: Protectorate")]
public sealed class dob : e33
{
	// Token: 0x06009EE2 RID: 40674 RVA: 0x003E2D30 File Offset: 0x003E0F30
	public dob() : base("Татуировка: Протекторат")
	{
	}

	// Token: 0x06009EE3 RID: 40675 RVA: 0x003E2D40 File Offset: 0x003E0F40
	public override List<d3e> cy(efk A_0)
	{
		return new List<d3e>
		{
			new bh1(dob.a)
			{
				Priority = 2147483646
			}
		};
	}

	// Token: 0x06009EE4 RID: 40676 RVA: 0x003E2D64 File Offset: 0x003E0F64
	public override object[] at()
	{
		return new object[]
		{
			Convert.ToInt32(dob.a * 100.0)
		};
	}

	// Token: 0x04003D8A RID: 15754
	public new static readonly double a = 0.08;
}
