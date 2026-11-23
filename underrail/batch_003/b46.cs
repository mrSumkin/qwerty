using System;
using System.Collections.Generic;

// Token: 0x02001C72 RID: 7282
[d29("SerialKiller", "Serial Killer")]
public sealed class b46 : aw2
{
	// Token: 0x06009FA6 RID: 40870 RVA: 0x003E4184 File Offset: 0x003E2384
	public b46() : base("肗Серийный убийца")
	{
	}

	// Token: 0x06009FA7 RID: 40871 RVA: 0x003E4194 File Offset: 0x003E2394
	public override object[] at()
	{
		return new object[]
		{
			(int)(b46.a * 100.0)
		};
	}

	// Token: 0x06009FA8 RID: 40872 RVA: 0x003E41B8 File Offset: 0x003E23B8
	public override List<brl> j0()
	{
		List<brl> list = base.j0();
		list.Add(new c2y(new Type[]
		{
			typeof(cce),
			typeof(bg6)
		}));
		return list;
	}

	// Token: 0x04003DAE RID: 15790
	public new static readonly double a = 0.1;
}
