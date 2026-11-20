using System;
using System.Collections.Generic;

// Token: 0x02001C6D RID: 7277
[d29("Stuntman", "Stuntman")]
public sealed class cek : aw2
{
	// Token: 0x06009F92 RID: 40850 RVA: 0x003E3ED4 File Offset: 0x003E20D4
	public cek() : base("胁Каскадёр")
	{
	}

	// Token: 0x06009F93 RID: 40851 RVA: 0x003E3EE4 File Offset: 0x003E20E4
	public override object[] at()
	{
		return new object[]
		{
			(int)(cek.a * 100.0)
		};
	}

	// Token: 0x06009F94 RID: 40852 RVA: 0x003E3F04 File Offset: 0x003E2104
	public override List<brl> j0()
	{
		List<brl> list = base.j0();
		list.Add(new awr(typeof(dqg), 12));
		return list;
	}

	// Token: 0x04003DA7 RID: 15783
	public new static readonly double a = 0.2;
}
