using System;
using System.Collections.Generic;

// Token: 0x02001C46 RID: 7238
[d29("TattooAnarchy", "Tattoo: Anarchy")]
public sealed class cml : e33
{
	// Token: 0x06009EDA RID: 40666 RVA: 0x003E2C6C File Offset: 0x003E0E6C
	public cml() : base("Татуировка: Анархия")
	{
	}

	// Token: 0x06009EDB RID: 40667 RVA: 0x003E2C7C File Offset: 0x003E0E7C
	public override List<d3e> cy(efk A_0)
	{
		return new List<d3e>
		{
			new dvq(cml.a, cs5.a)
		};
	}

	// Token: 0x06009EDC RID: 40668 RVA: 0x003E2C94 File Offset: 0x003E0E94
	public override object[] at()
	{
		return new object[]
		{
			Convert.ToInt32(cml.a * 100.0)
		};
	}

	// Token: 0x04003D88 RID: 15752
	public new static readonly double a = 0.01;
}
