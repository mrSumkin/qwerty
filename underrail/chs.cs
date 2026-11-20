using System;
using System.Collections.Generic;

// Token: 0x02001C69 RID: 7273
[d29("Bodybuilding", "Bodybuilding")]
public sealed class chs : aw2
{
	// Token: 0x06009F7D RID: 40829 RVA: 0x003E3CC8 File Offset: 0x003E1EC8
	public chs() : base("肹Бодибилдинг")
	{
	}

	// Token: 0x06009F7E RID: 40830 RVA: 0x003E3CD8 File Offset: 0x003E1ED8
	public override object[] at()
	{
		return new object[]
		{
			chs.a
		};
	}

	// Token: 0x06009F7F RID: 40831 RVA: 0x003E3CF0 File Offset: 0x003E1EF0
	public override List<d3e> cy(efk A_0)
	{
		return new List<d3e>
		{
			new dxd(chs.a)
		};
	}

	// Token: 0x06009F80 RID: 40832 RVA: 0x003E3D08 File Offset: 0x003E1F08
	public override List<brl> j0()
	{
		List<brl> list = base.j0();
		list.Add(new awr(typeof(axa), 12));
		return list;
	}

	// Token: 0x04003DA3 RID: 15779
	public new static readonly int a = 80;
}
