using System;
using System.Collections.Generic;

// Token: 0x02001C8E RID: 7310
[d29("PointShot", "Point Shot")]
public sealed class cld : ai8
{
	// Token: 0x0600A030 RID: 41008 RVA: 0x003E51FC File Offset: 0x003E33FC
	public override bool ap()
	{
		return false;
	}

	// Token: 0x0600A031 RID: 41009 RVA: 0x003E5200 File Offset: 0x003E3400
	public cld() : base("胧Выстрел навскидку")
	{
	}

	// Token: 0x0600A032 RID: 41010 RVA: 0x003E5210 File Offset: 0x003E3410
	public override void ar(efk A_0)
	{
		A_0.SpecialAttacks.b(dgk.Get<d5j>());
	}

	// Token: 0x0600A033 RID: 41011 RVA: 0x003E5224 File Offset: 0x003E3424
	public override void @as(efk A_0)
	{
		A_0.SpecialAttacks.a(dgk.Get<d5j>());
	}

	// Token: 0x0600A034 RID: 41012 RVA: 0x003E5238 File Offset: 0x003E3438
	public override object[] at()
	{
		return new object[]
		{
			(int)(d5j.c * 100.0),
			l4.a((double)d5j.b, false)
		};
	}

	// Token: 0x0600A035 RID: 41013 RVA: 0x003E5268 File Offset: 0x003E3468
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new awr(typeof(eav), 6),
			new awr(typeof(cwu), 6),
			new bap(25, new Type[]
			{
				typeof(ct7)
			})
		};
	}
}
