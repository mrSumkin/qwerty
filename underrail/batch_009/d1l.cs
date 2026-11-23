using System;
using System.Collections.Generic;

// Token: 0x02001C54 RID: 7252
[d29("Strider", "Strider")]
public sealed class d1l : aw2
{
	// Token: 0x06009F15 RID: 40725 RVA: 0x003E32FC File Offset: 0x003E14FC
	public d1l() : base("胋Первопроходец")
	{
	}

	// Token: 0x06009F16 RID: 40726 RVA: 0x003E330C File Offset: 0x003E150C
	public override object[] at()
	{
		return new object[]
		{
			d1l.a,
			Convert.ToInt32(d1l.b * 100f)
		};
	}

	// Token: 0x06009F17 RID: 40727 RVA: 0x003E333C File Offset: 0x003E153C
	public override List<d3e> cy(efk A_0)
	{
		return new List<d3e>
		{
			new ba(d1l.a, true, false, false),
			new i0(d1l.b, true, false, false)
		};
	}

	// Token: 0x06009F18 RID: 40728 RVA: 0x003E3374 File Offset: 0x003E1574
	public override List<brl> j0()
	{
		List<brl> list = base.j0();
		list.Add(new awr(typeof(dqg), 10));
		return list;
	}

	// Token: 0x04003D93 RID: 15763
	public new static readonly int a = 15;

	// Token: 0x04003D94 RID: 15764
	public new static readonly float b = 0.15f;
}
