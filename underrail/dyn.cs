using System;
using System.Collections.Generic;

// Token: 0x02001C84 RID: 7300
[d29("Guard", "Guard")]
public sealed class dyn : ai8
{
	// Token: 0x06009FF4 RID: 40948 RVA: 0x003E4A1C File Offset: 0x003E2C1C
	public dyn() : base("肷Стойка")
	{
	}

	// Token: 0x06009FF5 RID: 40949 RVA: 0x003E4A2C File Offset: 0x003E2C2C
	public override object[] at()
	{
		return new object[]
		{
			(int)(dyn.a * 100.0)
		};
	}

	// Token: 0x06009FF6 RID: 40950 RVA: 0x003E4A4C File Offset: 0x003E2C4C
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new awr(typeof(d3m), 7),
			new bap(50, new Type[]
			{
				typeof(jk)
			})
		};
	}

	// Token: 0x04003DBB RID: 15803
	public new static readonly double a = 0.35;
}
