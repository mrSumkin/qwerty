using System;
using System.Collections.Generic;

// Token: 0x02001C71 RID: 7281
[d29("MonsterSlayer", "Monster Slayer")]
public sealed class cce : aw2
{
	// Token: 0x06009FA2 RID: 40866 RVA: 0x003E4100 File Offset: 0x003E2300
	public cce() : base("肘Убийца чудовищ")
	{
	}

	// Token: 0x06009FA3 RID: 40867 RVA: 0x003E4110 File Offset: 0x003E2310
	public override object[] at()
	{
		return new object[]
		{
			(int)(cce.a * 100.0)
		};
	}

	// Token: 0x06009FA4 RID: 40868 RVA: 0x003E4134 File Offset: 0x003E2334
	public override List<brl> j0()
	{
		List<brl> list = base.j0();
		list.Add(new c2y(new Type[]
		{
			typeof(b46),
			typeof(bg6)
		}));
		return list;
	}

	// Token: 0x04003DAD RID: 15789
	public new static readonly double a = 0.15;
}
