using System;
using System.Collections.Generic;

// Token: 0x02001C2C RID: 7212
[d29("ConcussiveShots", "Concussive Shots")]
public sealed class bo8 : ai8
{
	// Token: 0x06009E6B RID: 40555 RVA: 0x003E1E78 File Offset: 0x003E0078
	public override bool ap()
	{
		return false;
	}

	// Token: 0x06009E6C RID: 40556 RVA: 0x003E1E7C File Offset: 0x003E007C
	public bo8() : base("膆Контузящие стрелы")
	{
	}

	// Token: 0x06009E6D RID: 40557 RVA: 0x003E1E8C File Offset: 0x003E008C
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new bap(30, new Type[]
			{
				typeof(e5n)
			})
		};
	}

	// Token: 0x06009E6E RID: 40558 RVA: 0x003E1EC0 File Offset: 0x003E00C0
	public override object[] at()
	{
		return new object[]
		{
			(int)(bo8.a * 100.0),
			eok.a,
			eok.b,
			l4.a(bo8.b, false)
		};
	}

	// Token: 0x04003D68 RID: 15720
	public new static readonly double a = 0.4;

	// Token: 0x04003D69 RID: 15721
	public new static readonly int b = 1;
}
