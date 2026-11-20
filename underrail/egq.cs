using System;
using System.Collections.Generic;

// Token: 0x02001C24 RID: 7204
[d29("Combo", "Combo")]
public sealed class egq : ai8
{
	// Token: 0x06009E39 RID: 40505 RVA: 0x003E19E0 File Offset: 0x003DFBE0
	public egq() : base("臇Комбо")
	{
	}

	// Token: 0x06009E3A RID: 40506 RVA: 0x003E19F0 File Offset: 0x003DFBF0
	public override object[] at()
	{
		return new object[]
		{
			(int)(egq.a * 100.0),
			(int)(egq.c * 100.0),
			l4.a(egq.d, false)
		};
	}

	// Token: 0x06009E3B RID: 40507 RVA: 0x003E1A44 File Offset: 0x003DFC44
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new bap(65, new Type[]
			{
				typeof(jk)
			}),
			new awr(typeof(cwu), 8)
		};
	}

	// Token: 0x04003D5E RID: 15710
	public new static readonly double a = 1.0;

	// Token: 0x04003D5F RID: 15711
	public new static readonly int b = 2;

	// Token: 0x04003D60 RID: 15712
	public static readonly double c = 0.2;

	// Token: 0x04003D61 RID: 15713
	public new static readonly int d = 1;
}
