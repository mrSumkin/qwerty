using System;
using System.Collections.Generic;

// Token: 0x02001CD3 RID: 7379
[d29("FutureOrientation", "Future Orientation")]
public sealed class ank : ai8
{
	// Token: 0x0600A1F0 RID: 41456 RVA: 0x003E8468 File Offset: 0x003E6668
	public override string au()
	{
		return "xpbl";
	}

	// Token: 0x0600A1F1 RID: 41457 RVA: 0x003E8470 File Offset: 0x003E6670
	public override bool ap()
	{
		return false;
	}

	// Token: 0x0600A1F2 RID: 41458 RVA: 0x003E8474 File Offset: 0x003E6674
	public ank() : base("臸Прыжок в будущее")
	{
	}

	// Token: 0x0600A1F3 RID: 41459 RVA: 0x003E8484 File Offset: 0x003E6684
	public override object[] at()
	{
		return new object[]
		{
			l4.a(ank.b, false),
			ank.a
		};
	}

	// Token: 0x0600A1F4 RID: 41460 RVA: 0x003E84A8 File Offset: 0x003E66A8
	public static int a(cnm A_0)
	{
		return Math.Max(0, ank.a - A_0.b8().GetSpecializationValue<jt>(true) * jt.a);
	}

	// Token: 0x0600A1F5 RID: 41461 RVA: 0x003E84C8 File Offset: 0x003E66C8
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new b4k(new Type[]
			{
				typeof(c3v)
			}),
			new bap(60, new Type[]
			{
				typeof(p5)
			})
		};
	}

	// Token: 0x04003E1C RID: 15900
	public new static readonly int a = 5;

	// Token: 0x04003E1D RID: 15901
	public new static readonly int b = 1;
}
