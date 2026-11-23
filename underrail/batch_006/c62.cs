using System;
using System.Collections.Generic;

// Token: 0x02001CA7 RID: 7335
[d29("TrapExpert", "Trap Expert")]
public sealed class c62 : ai8
{
	// Token: 0x0600A0C4 RID: 41156 RVA: 0x003E64B8 File Offset: 0x003E46B8
	public override bool ap()
	{
		return false;
	}

	// Token: 0x0600A0C5 RID: 41157 RVA: 0x003E64BC File Offset: 0x003E46BC
	public c62() : base("膋Траппер")
	{
	}

	// Token: 0x0600A0C6 RID: 41158 RVA: 0x003E64CC File Offset: 0x003E46CC
	public override object[] at()
	{
		return new object[]
		{
			(int)(c62.a * 100.0),
			(int)(c62.b * 100.0)
		};
	}

	// Token: 0x0600A0C7 RID: 41159 RVA: 0x003E6508 File Offset: 0x003E4708
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new awr(typeof(cwu), 6),
			new bap(30, new Type[]
			{
				typeof(c0b)
			})
		};
	}

	// Token: 0x04003DEB RID: 15851
	public new static readonly double a = 0.6;

	// Token: 0x04003DEC RID: 15852
	public new static readonly double b = 0.25;
}
