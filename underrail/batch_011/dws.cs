using System;
using System.Collections.Generic;

// Token: 0x02001CA6 RID: 7334
[d29("ThreePointer", "Three-Pointer")]
public sealed class dws : ai8
{
	// Token: 0x0600A0BF RID: 41151 RVA: 0x003E63D8 File Offset: 0x003E45D8
	public override bool ap()
	{
		return false;
	}

	// Token: 0x0600A0C0 RID: 41152 RVA: 0x003E63DC File Offset: 0x003E45DC
	public dws() : base("膍Трёхочковый")
	{
	}

	// Token: 0x0600A0C1 RID: 41153 RVA: 0x003E63EC File Offset: 0x003E45EC
	public override object[] at()
	{
		return new object[]
		{
			(int)(dws.a * 100.0),
			Math.Round(dws.c * 100.0, 1),
			dws.b
		};
	}

	// Token: 0x0600A0C2 RID: 41154 RVA: 0x003E6444 File Offset: 0x003E4644
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new awr(typeof(cwu), 7),
			new bap(50, new Type[]
			{
				typeof(dei)
			})
		};
	}

	// Token: 0x04003DE8 RID: 15848
	public new static readonly double a = 0.1;

	// Token: 0x04003DE9 RID: 15849
	public new static readonly int b = 50;

	// Token: 0x04003DEA RID: 15850
	public static readonly double c = 0.015;
}
