using System;
using System.Collections.Generic;

// Token: 0x02001C6F RID: 7279
[d29("FightResponse", "Fight Response")]
public sealed class cuk : aw2
{
	// Token: 0x06009F9A RID: 40858 RVA: 0x003E3FD8 File Offset: 0x003E21D8
	public cuk() : base("胐Ответный бой")
	{
	}

	// Token: 0x06009F9B RID: 40859 RVA: 0x003E3FE8 File Offset: 0x003E21E8
	public override object[] at()
	{
		return new object[]
		{
			(int)(cuk.a * 100.0),
			cuk.b
		};
	}

	// Token: 0x06009F9C RID: 40860 RVA: 0x003E4018 File Offset: 0x003E2218
	public override List<brl> j0()
	{
		List<brl> list = base.j0();
		list.Add(new awr(typeof(axr), 7));
		list.Add(new c2y(new Type[]
		{
			typeof(cns)
		}));
		return list;
	}

	// Token: 0x04003DAA RID: 15786
	public new static readonly double a = 0.25;

	// Token: 0x04003DAB RID: 15787
	public new static readonly int b = 10;
}
