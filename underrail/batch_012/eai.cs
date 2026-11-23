using System;
using System.Collections.Generic;

// Token: 0x02001C53 RID: 7251
[d29("IronWill", "Iron Will")]
public sealed class eai : aw2
{
	// Token: 0x06009F10 RID: 40720 RVA: 0x003E3288 File Offset: 0x003E1488
	public eai() : base("肸Железная воля")
	{
	}

	// Token: 0x06009F11 RID: 40721 RVA: 0x003E3298 File Offset: 0x003E1498
	public override object[] at()
	{
		return new object[]
		{
			Convert.ToInt32(eai.a * 100f)
		};
	}

	// Token: 0x06009F12 RID: 40722 RVA: 0x003E32B8 File Offset: 0x003E14B8
	public override List<d3e> cy(efk A_0)
	{
		return new List<d3e>
		{
			new cly(eai.a)
		};
	}

	// Token: 0x06009F13 RID: 40723 RVA: 0x003E32D0 File Offset: 0x003E14D0
	public override List<brl> j0()
	{
		List<brl> list = base.j0();
		list.Add(new awr(typeof(axr), 7));
		return list;
	}

	// Token: 0x04003D92 RID: 15762
	public new static readonly float a = 0.5f;
}
