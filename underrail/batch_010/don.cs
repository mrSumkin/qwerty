using System;
using System.Collections.Generic;

// Token: 0x02001CB8 RID: 7352
[d29("IronGrip", "Iron Grip")]
public sealed class don : ai8
{
	// Token: 0x0600A12C RID: 41260 RVA: 0x003E7158 File Offset: 0x003E5358
	public override string au()
	{
		return "xpbl";
	}

	// Token: 0x0600A12D RID: 41261 RVA: 0x003E7160 File Offset: 0x003E5360
	public override bool ap()
	{
		return false;
	}

	// Token: 0x0600A12E RID: 41262 RVA: 0x003E7164 File Offset: 0x003E5364
	public don() : base("膗Железный хват")
	{
	}

	// Token: 0x0600A12F RID: 41263 RVA: 0x003E7174 File Offset: 0x003E5374
	public override object[] at()
	{
		return new object[]
		{
			Convert.ToInt32(don.a * 100.0)
		};
	}

	// Token: 0x0600A130 RID: 41264 RVA: 0x003E7198 File Offset: 0x003E5398
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new awr(typeof(d3m), 11)
		};
	}

	// Token: 0x04003E01 RID: 15873
	public new static readonly double a = 0.15;
}
