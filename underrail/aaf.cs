using System;
using System.Collections.Generic;

// Token: 0x02001C7C RID: 7292
[d29("ExpertSprint", "Expert Sprint")]
public sealed class aaf : aw2
{
	// Token: 0x06009FCA RID: 40906 RVA: 0x003E45D8 File Offset: 0x003E27D8
	public aaf() : base("胊Эксперт спринта")
	{
	}

	// Token: 0x06009FCB RID: 40907 RVA: 0x003E45E8 File Offset: 0x003E27E8
	public override object[] at()
	{
		return new object[]
		{
			aaf.a
		};
	}

	// Token: 0x06009FCC RID: 40908 RVA: 0x003E4600 File Offset: 0x003E2800
	public override List<brl> j0()
	{
		List<brl> list = base.j0();
		list.Add(new awr(typeof(dqg), 13));
		list.Add(new b4k(new Type[]
		{
			typeof(alw)
		}));
		return list;
	}

	// Token: 0x04003DB5 RID: 15797
	public new static readonly int a = 10;
}
