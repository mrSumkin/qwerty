using System;
using System.Collections.Generic;

// Token: 0x02001DF8 RID: 7672
[d29("MS", "Mental Subversion")]
public sealed class cgu : ai8
{
	// Token: 0x0600A9D9 RID: 43481 RVA: 0x003F2918 File Offset: 0x003F0B18
	public override bool ap()
	{
		return false;
	}

	// Token: 0x0600A9DA RID: 43482 RVA: 0x003F291C File Offset: 0x003F0B1C
	public cgu() : base("臠Ментальная диверсия")
	{
	}

	// Token: 0x0600A9DB RID: 43483 RVA: 0x003F292C File Offset: 0x003F0B2C
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new awr(typeof(axr), 6),
			new bap(30, new Type[]
			{
				typeof(dql)
			}),
			new b6h(new Type[]
			{
				typeof(dzs),
				typeof(dx2)
			})
		};
	}

	// Token: 0x0600A9DC RID: 43484 RVA: 0x003F29A4 File Offset: 0x003F0BA4
	public override object[] at()
	{
		return new object[]
		{
			(int)(cgu.a * 100.0)
		};
	}

	// Token: 0x04003FA1 RID: 16289
	public new static readonly double a = 0.75;

	// Token: 0x04003FA2 RID: 16290
	public new static readonly int b = 50;

	// Token: 0x04003FA3 RID: 16291
	public static readonly int c = 120000;
}
