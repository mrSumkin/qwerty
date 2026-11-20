using System;
using System.Collections.Generic;

// Token: 0x02001C4C RID: 7244
[d29("TattooSkulljacked", "Tattoo: Skulljacked")]
public sealed class e1f : e33
{
	// Token: 0x06009EF7 RID: 40695 RVA: 0x003E2F38 File Offset: 0x003E1138
	public e1f() : base("Татуировка: Вскрытый череп")
	{
	}

	// Token: 0x06009EF8 RID: 40696 RVA: 0x003E2F48 File Offset: 0x003E1148
	public override object[] at()
	{
		return new object[]
		{
			e1f.a.ToString("P0"),
			e1f.b.ToString("P0")
		};
	}

	// Token: 0x06009EF9 RID: 40697 RVA: 0x003E2F88 File Offset: 0x003E1188
	public override List<d3e> cy(efk A_0)
	{
		if (A_0 != null && A_0.Gear.l().Item != null && A_0.Gear.l().Item.fu().h() >= (double)e1f.b)
		{
			return new List<d3e>
			{
				new bi0(null, e1f.a)
				{
					Priority = int.MaxValue
				}
			};
		}
		return null;
	}

	// Token: 0x04003D8D RID: 15757
	public new static readonly float a = 0.02f;

	// Token: 0x04003D8E RID: 15758
	public new static readonly float b = 0.5f;
}
