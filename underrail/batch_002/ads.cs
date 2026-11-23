using System;
using System.Collections.Generic;

// Token: 0x02001C6A RID: 7274
[d29("BodyWeightTraining", "Body Weight Training")]
public sealed class ads : aw2
{
	// Token: 0x06009F82 RID: 40834 RVA: 0x003E3D34 File Offset: 0x003E1F34
	public ads() : base("肣Тренировка поднятия веса")
	{
	}

	// Token: 0x06009F83 RID: 40835 RVA: 0x003E3D44 File Offset: 0x003E1F44
	public override object[] at()
	{
		return new object[]
		{
			(int)(ads.a * 100.0)
		};
	}

	// Token: 0x06009F84 RID: 40836 RVA: 0x003E3D64 File Offset: 0x003E1F64
	public override List<d3e> cy(efk A_0)
	{
		return new List<d3e>
		{
			new caz(-ads.a)
		};
	}

	// Token: 0x06009F85 RID: 40837 RVA: 0x003E3D7C File Offset: 0x003E1F7C
	public override List<brl> j0()
	{
		List<brl> list = base.j0();
		list.Add(new awr(typeof(d3m), 10));
		return list;
	}

	// Token: 0x04003DA4 RID: 15780
	public new static readonly double a = 0.1;
}
