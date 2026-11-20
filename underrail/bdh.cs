using System;
using System.Collections.Generic;

// Token: 0x02001C6B RID: 7275
[d29("Mantra", "Mantra")]
public sealed class bdh : aw2
{
	// Token: 0x06009F87 RID: 40839 RVA: 0x003E3DAC File Offset: 0x003E1FAC
	public override bool ap()
	{
		return false;
	}

	// Token: 0x06009F88 RID: 40840 RVA: 0x003E3DB0 File Offset: 0x003E1FB0
	public bdh() : base("臛Мантра")
	{
	}

	// Token: 0x06009F89 RID: 40841 RVA: 0x003E3DC0 File Offset: 0x003E1FC0
	public override object[] at()
	{
		return new object[]
		{
			bdh.a
		};
	}

	// Token: 0x06009F8A RID: 40842 RVA: 0x003E3DD8 File Offset: 0x003E1FD8
	public override List<d3e> cy(efk A_0)
	{
		return new List<d3e>
		{
			new emn(bdh.a)
		};
	}

	// Token: 0x06009F8B RID: 40843 RVA: 0x003E3DF0 File Offset: 0x003E1FF0
	public override List<brl> j0()
	{
		List<brl> list = base.j0();
		list.Add(new awr(typeof(axr), 8));
		list.Add(new db7(100));
		list.Add(new b4k(new Type[]
		{
			typeof(c3v)
		}));
		return list;
	}

	// Token: 0x04003DA5 RID: 15781
	public new static readonly int a = 10;
}
