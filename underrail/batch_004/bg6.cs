using System;
using System.Collections.Generic;

// Token: 0x02001C70 RID: 7280
[d29("Decommissioner", "Decommissioner")]
public sealed class bg6 : aw2
{
	// Token: 0x06009F9E RID: 40862 RVA: 0x003E407C File Offset: 0x003E227C
	public bg6() : base("肙Разборщик")
	{
	}

	// Token: 0x06009F9F RID: 40863 RVA: 0x003E408C File Offset: 0x003E228C
	public override object[] at()
	{
		return new object[]
		{
			(int)(bg6.a * 100.0)
		};
	}

	// Token: 0x06009FA0 RID: 40864 RVA: 0x003E40B0 File Offset: 0x003E22B0
	public override List<brl> j0()
	{
		List<brl> list = base.j0();
		list.Add(new c2y(new Type[]
		{
			typeof(b46),
			typeof(cce)
		}));
		return list;
	}

	// Token: 0x04003DAC RID: 15788
	public new static readonly double a = 0.15;
}
