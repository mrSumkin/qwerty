using System;
using System.Collections.Generic;

// Token: 0x02001C52 RID: 7250
[d29("ExpertUnarmedCombat", "Expert Unarmed Combat")]
public sealed class bfn : aw2
{
	// Token: 0x06009F0C RID: 40716 RVA: 0x003E31A4 File Offset: 0x003E13A4
	public bfn() : base("臈Эксперт рукопашного боя")
	{
	}

	// Token: 0x06009F0D RID: 40717 RVA: 0x003E31B4 File Offset: 0x003E13B4
	public override object[] at()
	{
		return new object[]
		{
			Convert.ToInt32(bfn.a * 100.0),
			Convert.ToInt32(bfn.b * 100.0),
			l4.a(bfn.c, false)
		};
	}

	// Token: 0x06009F0E RID: 40718 RVA: 0x003E3210 File Offset: 0x003E1410
	public override List<brl> j0()
	{
		List<brl> list = base.j0();
		list.Add(new bap(100, new Type[]
		{
			typeof(jk)
		}));
		list.Add(new b4k(new Type[]
		{
			typeof(alo)
		}));
		return list;
	}

	// Token: 0x04003D8F RID: 15759
	public new static readonly double a = 0.2;

	// Token: 0x04003D90 RID: 15760
	public new static readonly double b = 0.05;

	// Token: 0x04003D91 RID: 15761
	public static readonly int c = 1;
}
