using System;
using System.Collections.Generic;

// Token: 0x02001C3C RID: 7228
[d29("TattooBalorsEye", "Tattoo: Balor's Eye")]
public sealed class b27 : e33
{
	// Token: 0x06009EB3 RID: 40627 RVA: 0x003E27D8 File Offset: 0x003E09D8
	public b27() : base("Татуировка: Глаз Балора")
	{
	}

	// Token: 0x06009EB4 RID: 40628 RVA: 0x003E27E8 File Offset: 0x003E09E8
	public override List<d3e> cy(efk A_0)
	{
		return new List<d3e>
		{
			new d0d(b27.a)
			{
				Priority = int.MaxValue
			}
		};
	}

	// Token: 0x06009EB5 RID: 40629 RVA: 0x003E280C File Offset: 0x003E0A0C
	public override object[] at()
	{
		return new object[]
		{
			Convert.ToInt32(b27.a * 100f)
		};
	}

	// Token: 0x04003D7D RID: 15741
	public new static readonly float a = 0.1f;
}
