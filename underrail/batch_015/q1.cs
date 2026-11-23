using System;
using System.Collections.Generic;

// Token: 0x02001C1B RID: 7195
[d29("BulletTime", "Bullet Time")]
public sealed class q1 : ai8
{
	// Token: 0x06009E04 RID: 40452 RVA: 0x003E1268 File Offset: 0x003DF468
	public q1() : base("胴Время пули")
	{
	}

	// Token: 0x06009E05 RID: 40453 RVA: 0x003E1278 File Offset: 0x003DF478
	public override void ar(efk A_0)
	{
		A_0.SpecialAbilities.b(dgk.Get<cyc>());
	}

	// Token: 0x06009E06 RID: 40454 RVA: 0x003E128C File Offset: 0x003DF48C
	public override void @as(efk A_0)
	{
		A_0.SpecialAbilities.a(dgk.Get<cyc>());
	}

	// Token: 0x06009E07 RID: 40455 RVA: 0x003E12A0 File Offset: 0x003DF4A0
	public override object[] at()
	{
		return new object[]
		{
			Convert.ToInt32(cyc.c * 100.0),
			l4.a(cyc.b, false)
		};
	}

	// Token: 0x06009E08 RID: 40456 RVA: 0x003E12D4 File Offset: 0x003DF4D4
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new awr(typeof(cwu), 9),
			new bap(70, new Type[]
			{
				typeof(ct7)
			}),
			new b4k(new Type[]
			{
				typeof(dtc)
			})
		};
	}
}
