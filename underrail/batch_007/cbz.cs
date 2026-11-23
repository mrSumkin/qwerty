using System;
using System.Collections.Generic;

// Token: 0x02001CD8 RID: 7384
[d29("Strafe", "Strafe")]
public sealed class cbz : ai8
{
	// Token: 0x0600A211 RID: 41489 RVA: 0x003E87C4 File Offset: 0x003E69C4
	public override string au()
	{
		return "xpbl";
	}

	// Token: 0x0600A212 RID: 41490 RVA: 0x003E87CC File Offset: 0x003E69CC
	public override bool ap()
	{
		return false;
	}

	// Token: 0x0600A213 RID: 41491 RVA: 0x003E87D0 File Offset: 0x003E69D0
	public cbz() : base("胈Обстрел")
	{
	}

	// Token: 0x0600A214 RID: 41492 RVA: 0x003E87E0 File Offset: 0x003E69E0
	public override void ar(efk A_0)
	{
	}

	// Token: 0x0600A215 RID: 41493 RVA: 0x003E87E4 File Offset: 0x003E69E4
	public override void @as(efk A_0)
	{
	}

	// Token: 0x0600A216 RID: 41494 RVA: 0x003E87E8 File Offset: 0x003E69E8
	public override object[] at()
	{
		return new object[]
		{
			(int)(cbz.a * 100.0)
		};
	}

	// Token: 0x0600A217 RID: 41495 RVA: 0x003E8808 File Offset: 0x003E6A08
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new awr(typeof(cwu), 5),
			new awr(typeof(dqg), 5)
		};
	}

	// Token: 0x04003E24 RID: 15908
	public new static readonly double a = 0.15;
}
