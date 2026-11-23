using System;
using System.Collections.Generic;

// Token: 0x02001CB6 RID: 7350
[d29("BodyHorror", "Body Horror")]
public sealed class aaw : ai8
{
	// Token: 0x0600A11C RID: 41244 RVA: 0x003E6F94 File Offset: 0x003E5194
	public override string au()
	{
		return "xpbl";
	}

	// Token: 0x0600A11D RID: 41245 RVA: 0x003E6F9C File Offset: 0x003E519C
	public override bool aq()
	{
		return false;
	}

	// Token: 0x0600A11E RID: 41246 RVA: 0x003E6FA0 File Offset: 0x003E51A0
	public aaw() : base("Ужасная плоть")
	{
	}

	// Token: 0x0600A11F RID: 41247 RVA: 0x003E6FB0 File Offset: 0x003E51B0
	public override object[] at()
	{
		return new object[]
		{
			Convert.ToInt32(aaw.a * 100.0),
			Convert.ToInt32(aaw.b * 100.0)
		};
	}

	// Token: 0x0600A120 RID: 41248 RVA: 0x003E6FF0 File Offset: 0x003E51F0
	public override List<d3e> cy(efk A_0)
	{
		return new List<d3e>
		{
			new cly(Convert.ToSingle(-aaw.b))
			{
				Priority = int.MaxValue
			}
		};
	}

	// Token: 0x0600A121 RID: 41249 RVA: 0x003E7018 File Offset: 0x003E5218
	public override List<brl> j0()
	{
		return new List<brl>();
	}

	// Token: 0x04003DFD RID: 15869
	public new static readonly double a = 0.03;

	// Token: 0x04003DFE RID: 15870
	public new static readonly double b = 0.3;
}
