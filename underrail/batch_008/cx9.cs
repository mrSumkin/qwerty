using System;
using System.Collections.Generic;

// Token: 0x02001C74 RID: 7284
[d29("ImprovedEvasion", "Expert Evasion")]
public sealed class cx9 : aw2
{
	// Token: 0x06009FAF RID: 40879 RVA: 0x003E42AC File Offset: 0x003E24AC
	public cx9() : base("胂Эксперт уворачивания")
	{
	}

	// Token: 0x06009FB0 RID: 40880 RVA: 0x003E42BC File Offset: 0x003E24BC
	public override object[] at()
	{
		return new object[]
		{
			(int)(cx9.a * 100.0)
		};
	}

	// Token: 0x06009FB1 RID: 40881 RVA: 0x003E42E0 File Offset: 0x003E24E0
	public override List<brl> j0()
	{
		List<brl> list = base.j0();
		list.Add(new awr(typeof(dqg), 12));
		list.Add(new bap(120, new Type[]
		{
			typeof(erc)
		}));
		return list;
	}

	// Token: 0x04003DB0 RID: 15792
	public new static readonly double a = 0.05;
}
