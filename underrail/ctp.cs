using System;
using System.Collections.Generic;

// Token: 0x02001C3E RID: 7230
[d29("TattooTchort", "Tattoo: Tchort")]
public sealed class ctp : e33
{
	// Token: 0x06009EBB RID: 40635 RVA: 0x003E28BC File Offset: 0x003E0ABC
	public ctp() : base("Татуировка: Чорт")
	{
	}

	// Token: 0x06009EBC RID: 40636 RVA: 0x003E28CC File Offset: 0x003E0ACC
	public override List<d3e> cy(efk A_0)
	{
		return new List<d3e>
		{
			new cly(ctp.a)
			{
				Priority = 2147483646
			},
			new d0d(-ctp.b)
			{
				Priority = int.MaxValue
			}
		};
	}

	// Token: 0x06009EBD RID: 40637 RVA: 0x003E2918 File Offset: 0x003E0B18
	public override object[] at()
	{
		return new object[]
		{
			Convert.ToInt32(ctp.a * 100f),
			Convert.ToInt32(ctp.b * 100f)
		};
	}

	// Token: 0x04003D7F RID: 15743
	public new static readonly float a = 0.1f;

	// Token: 0x04003D80 RID: 15744
	public new static readonly float b = 0.05f;
}
