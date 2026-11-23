using System;
using System.Collections.Generic;

// Token: 0x02001CE5 RID: 7397
[d29("Shroomhead", "Shroomhead")]
public sealed class cbm : ai8
{
	// Token: 0x0600A276 RID: 41590 RVA: 0x003E94B8 File Offset: 0x003E76B8
	public override bool ae6()
	{
		return false;
	}

	// Token: 0x0600A277 RID: 41591 RVA: 0x003E94BC File Offset: 0x003E76BC
	public cbm() : base("Грибная шляпа")
	{
	}

	// Token: 0x0600A278 RID: 41592 RVA: 0x003E94CC File Offset: 0x003E76CC
	public override void ar(efk A_0)
	{
	}

	// Token: 0x0600A279 RID: 41593 RVA: 0x003E94D0 File Offset: 0x003E76D0
	public override void @as(efk A_0)
	{
	}

	// Token: 0x0600A27A RID: 41594 RVA: 0x003E94D4 File Offset: 0x003E76D4
	public override object[] at()
	{
		return new object[]
		{
			cbm.a
		};
	}

	// Token: 0x0600A27B RID: 41595 RVA: 0x003E94EC File Offset: 0x003E76EC
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new b4k(new Type[]
			{
				typeof(c3v)
			})
		};
	}

	// Token: 0x04003E3C RID: 15932
	public new static int a = 15;
}
