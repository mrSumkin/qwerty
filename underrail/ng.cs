using System;
using System.Collections.Generic;

// Token: 0x02001CB0 RID: 7344
[d29("Bowyer", "Bowyer")]
public sealed class ng : ai8
{
	// Token: 0x0600A0F2 RID: 41202 RVA: 0x003E6BBC File Offset: 0x003E4DBC
	public override bool ap()
	{
		return false;
	}

	// Token: 0x0600A0F3 RID: 41203 RVA: 0x003E6BC0 File Offset: 0x003E4DC0
	public ng() : base("膄Арбалетчик")
	{
	}

	// Token: 0x0600A0F4 RID: 41204 RVA: 0x003E6BD0 File Offset: 0x003E4DD0
	public override void ar(efk A_0)
	{
	}

	// Token: 0x0600A0F5 RID: 41205 RVA: 0x003E6BD4 File Offset: 0x003E4DD4
	public override void @as(efk A_0)
	{
	}

	// Token: 0x0600A0F6 RID: 41206 RVA: 0x003E6BD8 File Offset: 0x003E4DD8
	public override object[] at()
	{
		return new object[]
		{
			(int)(ng.a * 100.0)
		};
	}

	// Token: 0x0600A0F7 RID: 41207 RVA: 0x003E6BFC File Offset: 0x003E4DFC
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new awr(typeof(av8), 7),
			new bap(30, new Type[]
			{
				typeof(eq1)
			})
		};
	}

	// Token: 0x04003DF7 RID: 15863
	public new static readonly double a = 0.35;
}
