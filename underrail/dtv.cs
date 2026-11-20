using System;
using System.Collections.Generic;

// Token: 0x02001C7E RID: 7294
[d29("SeaDog", "Sea Dog")]
public sealed class dtv : aw2
{
	// Token: 0x06009FD0 RID: 40912 RVA: 0x003E466C File Offset: 0x003E286C
	public dtv() : base("肛Морской пёс")
	{
	}

	// Token: 0x06009FD1 RID: 40913 RVA: 0x003E467C File Offset: 0x003E287C
	public override string au()
	{
		return "xpbl";
	}

	// Token: 0x06009FD2 RID: 40914 RVA: 0x003E4684 File Offset: 0x003E2884
	public override bool ap()
	{
		return false;
	}

	// Token: 0x06009FD3 RID: 40915 RVA: 0x003E4688 File Offset: 0x003E2888
	public override object[] at()
	{
		return new object[]
		{
			Convert.ToInt32(dtv.a * 100.0),
			Convert.ToInt32(dtv.b * 100.0)
		};
	}

	// Token: 0x06009FD4 RID: 40916 RVA: 0x003E46CC File Offset: 0x003E28CC
	public override List<brl> j0()
	{
		List<brl> list = base.j0();
		list.Add(new awr(typeof(dqg), 10));
		list.Add(new b4k(new Type[]
		{
			typeof(duv)
		}));
		return list;
	}

	// Token: 0x04003DB6 RID: 15798
	public new static readonly double a = 0.3;

	// Token: 0x04003DB7 RID: 15799
	public new static readonly double b = 0.1;
}
