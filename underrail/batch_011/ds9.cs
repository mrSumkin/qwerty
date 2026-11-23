using System;
using System.Collections.Generic;

// Token: 0x02001C64 RID: 7268
[d29("NeuralOverclocking", "Neural Overclocking")]
public sealed class ds9 : ai8
{
	// Token: 0x06009F5D RID: 40797 RVA: 0x003E3978 File Offset: 0x003E1B78
	public override bool ap()
	{
		return false;
	}

	// Token: 0x06009F5E RID: 40798 RVA: 0x003E397C File Offset: 0x003E1B7C
	public ds9() : base("臖Невральный разгон")
	{
	}

	// Token: 0x06009F5F RID: 40799 RVA: 0x003E398C File Offset: 0x003E1B8C
	public override List<d3e> cy(efk A_0)
	{
		return new List<d3e>
		{
			new db(null, (float)((double)ds9.a + (double)A_0.GetSpecializationValue<g2>(true) * g2.a))
		};
	}

	// Token: 0x06009F60 RID: 40800 RVA: 0x003E39C8 File Offset: 0x003E1BC8
	public override object[] at()
	{
		return new object[]
		{
			(int)(ds9.a * 100f)
		};
	}

	// Token: 0x06009F61 RID: 40801 RVA: 0x003E39E4 File Offset: 0x003E1BE4
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new awr(typeof(axr), 10),
			new db7(65),
			new b4k(new Type[]
			{
				typeof(c3v)
			})
		};
	}

	// Token: 0x04003D9E RID: 15774
	public new static readonly float a = 0.3f;
}
