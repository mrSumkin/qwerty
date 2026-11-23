using System;
using System.Collections.Generic;

// Token: 0x02001C6E RID: 7278
[d29("FlightResponse", "Flight Response")]
public sealed class cns : aw2
{
	// Token: 0x06009F96 RID: 40854 RVA: 0x003E3F34 File Offset: 0x003E2134
	public cns() : base("胑Ответный полёт")
	{
	}

	// Token: 0x06009F97 RID: 40855 RVA: 0x003E3F44 File Offset: 0x003E2144
	public override object[] at()
	{
		return new object[]
		{
			(int)(cns.a * 100.0),
			cns.b
		};
	}

	// Token: 0x06009F98 RID: 40856 RVA: 0x003E3F74 File Offset: 0x003E2174
	public override List<brl> j0()
	{
		List<brl> list = base.j0();
		list.Add(new awr(typeof(dqg), 7));
		list.Add(new c2y(new Type[]
		{
			typeof(cuk)
		}));
		return list;
	}

	// Token: 0x04003DA8 RID: 15784
	public new static readonly double a = 0.35;

	// Token: 0x04003DA9 RID: 15785
	public new static readonly int b = 25;
}
