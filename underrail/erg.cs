using System;
using System.Collections.Generic;

// Token: 0x02001C75 RID: 7285
[d29("ImprovedDodging", "Expert Dodging")]
public sealed class erg : aw2
{
	// Token: 0x06009FB3 RID: 40883 RVA: 0x003E433C File Offset: 0x003E253C
	public erg() : base("胃Эксперт уклонения")
	{
	}

	// Token: 0x06009FB4 RID: 40884 RVA: 0x003E434C File Offset: 0x003E254C
	public override object[] at()
	{
		return new object[]
		{
			(int)(erg.a * 100.0)
		};
	}

	// Token: 0x06009FB5 RID: 40885 RVA: 0x003E4370 File Offset: 0x003E2570
	public override List<brl> j0()
	{
		List<brl> list = base.j0();
		list.Add(new awr(typeof(dqg), 12));
		list.Add(new bap(120, new Type[]
		{
			typeof(e74)
		}));
		return list;
	}

	// Token: 0x04003DB1 RID: 15793
	public new static readonly double a = 0.05;
}
