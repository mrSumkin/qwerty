using System;
using System.Collections.Generic;

// Token: 0x02001C2E RID: 7214
[d29("ImprovedUnarmedCombat", "Improved Unarmed Combat")]
public sealed class alo : ai8
{
	// Token: 0x06009E77 RID: 40567 RVA: 0x003E201C File Offset: 0x003E021C
	public alo() : base("臅Улучшенный рукопашный бой")
	{
	}

	// Token: 0x06009E78 RID: 40568 RVA: 0x003E202C File Offset: 0x003E022C
	public override object[] at()
	{
		return new object[]
		{
			Convert.ToInt32(alo.a * 100.0),
			Convert.ToInt32(alo.b * 100.0),
			l4.a(alo.c, false)
		};
	}

	// Token: 0x06009E79 RID: 40569 RVA: 0x003E2088 File Offset: 0x003E0288
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new bap(35, new Type[]
			{
				typeof(jk)
			})
		};
	}

	// Token: 0x04003D6C RID: 15724
	public new static readonly double a = 0.2;

	// Token: 0x04003D6D RID: 15725
	public new static readonly double b = 0.05;

	// Token: 0x04003D6E RID: 15726
	public static readonly int c = 1;
}
