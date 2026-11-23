using System;
using System.Collections.Generic;

// Token: 0x02001C25 RID: 7205
[d29("ConcentratedFire", "Concentrated Fire")]
public sealed class c12 : ai8
{
	// Token: 0x06009E3D RID: 40509 RVA: 0x003E1ABC File Offset: 0x003DFCBC
	public c12() : base("胡Плотный огонь")
	{
	}

	// Token: 0x06009E3E RID: 40510 RVA: 0x003E1ACC File Offset: 0x003DFCCC
	public override bool ap()
	{
		return false;
	}

	// Token: 0x06009E3F RID: 40511 RVA: 0x003E1AD0 File Offset: 0x003DFCD0
	public override void ar(efk A_0)
	{
	}

	// Token: 0x06009E40 RID: 40512 RVA: 0x003E1AD4 File Offset: 0x003DFCD4
	public override void @as(efk A_0)
	{
	}

	// Token: 0x06009E41 RID: 40513 RVA: 0x003E1AD8 File Offset: 0x003DFCD8
	public override object[] at()
	{
		return new object[]
		{
			(int)(c12.b * 100.0),
			c12.a
		};
	}

	// Token: 0x06009E42 RID: 40514 RVA: 0x003E1B08 File Offset: 0x003DFD08
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new awr(typeof(eav), 8),
			new bap(60, new Type[]
			{
				typeof(ct7),
				typeof(e8k)
			})
		};
	}

	// Token: 0x06009E43 RID: 40515 RVA: 0x003E1B60 File Offset: 0x003DFD60
	protected override string nq()
	{
		if (dk2.e())
		{
			return "XPHW";
		}
		return null;
	}

	// Token: 0x04003D62 RID: 15714
	public new static readonly int a = 10;

	// Token: 0x04003D63 RID: 15715
	public new static readonly double b = 0.1;
}
