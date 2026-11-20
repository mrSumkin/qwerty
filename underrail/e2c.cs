using System;
using System.Collections.Generic;

// Token: 0x02001CD7 RID: 7383
[d29("ShieldArm", "Shield Arm")]
public sealed class e2c : ai8
{
	// Token: 0x0600A20B RID: 41483 RVA: 0x003E8730 File Offset: 0x003E6930
	public override string au()
	{
		return "xpbl";
	}

	// Token: 0x0600A20C RID: 41484 RVA: 0x003E8738 File Offset: 0x003E6938
	public override bool ap()
	{
		return false;
	}

	// Token: 0x0600A20D RID: 41485 RVA: 0x003E873C File Offset: 0x003E693C
	public e2c() : base("膺Ручной щит")
	{
	}

	// Token: 0x0600A20E RID: 41486 RVA: 0x003E874C File Offset: 0x003E694C
	public override object[] at()
	{
		return new object[]
		{
			(int)(e2c.a * 100.0),
			(int)(e2c.b * 100.0)
		};
	}

	// Token: 0x0600A20F RID: 41487 RVA: 0x003E8784 File Offset: 0x003E6984
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new awr(typeof(d3m), 8)
		};
	}

	// Token: 0x04003E22 RID: 15906
	public new static readonly double a = 0.15;

	// Token: 0x04003E23 RID: 15907
	public new static readonly double b = 0.3;
}
