using System;
using System.Collections.Generic;

// Token: 0x02001CA2 RID: 7330
[d29("SpecOps", "Spec Ops")]
public sealed class m6 : ai8
{
	// Token: 0x0600A0AB RID: 41131 RVA: 0x003E5FD0 File Offset: 0x003E41D0
	public override bool ap()
	{
		return false;
	}

	// Token: 0x0600A0AC RID: 41132 RVA: 0x003E5FD4 File Offset: 0x003E41D4
	public m6() : base("胯Спецназ")
	{
	}

	// Token: 0x0600A0AD RID: 41133 RVA: 0x003E5FE4 File Offset: 0x003E41E4
	public override object[] at()
	{
		return new object[]
		{
			(int)(as3.bo * 100.0),
			(int)((as3.bo - m6.a) * 100.0),
			l4.a(m6.b, false)
		};
	}

	// Token: 0x0600A0AE RID: 41134 RVA: 0x003E603C File Offset: 0x003E423C
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new awr(typeof(dqg), 6),
			new bap(50, new Type[]
			{
				typeof(ct7)
			})
		};
	}

	// Token: 0x04003DE1 RID: 15841
	public new static readonly double a = 1.0;

	// Token: 0x04003DE2 RID: 15842
	public new static readonly int b = 1;
}
