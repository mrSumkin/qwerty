using System;
using System.Collections.Generic;

// Token: 0x02001E04 RID: 7684
[d29("G", "Gunslinger")]
public sealed class dtc : ai8
{
	// Token: 0x0600AA24 RID: 43556 RVA: 0x003F34E0 File Offset: 0x003F16E0
	public override bool ap()
	{
		return false;
	}

	// Token: 0x0600AA25 RID: 43557 RVA: 0x003F34E4 File Offset: 0x003F16E4
	public dtc() : base("胳Ковбой")
	{
	}

	// Token: 0x0600AA26 RID: 43558 RVA: 0x003F34F4 File Offset: 0x003F16F4
	public override void ar(efk A_0)
	{
	}

	// Token: 0x0600AA27 RID: 43559 RVA: 0x003F34F8 File Offset: 0x003F16F8
	public override void @as(efk A_0)
	{
	}

	// Token: 0x0600AA28 RID: 43560 RVA: 0x003F34FC File Offset: 0x003F16FC
	public override List<d3e> cy(efk A_0)
	{
		List<d3e> list = new List<d3e>();
		if (A_0.Offense.u().TypedDefinition.e() == btz.a && euf.m(A_0.Offense.u()))
		{
			list.Add(new b5x(dtc.b + A_0.GetSpecializationValue<a05>(true) * a05.a));
			list.Add(new bjo((float)(-(float)dtc.a) * d0u.c, -dtc.a, new List<btz>
			{
				btz.a
			})
			{
				Priority = 2147483646
			});
		}
		return list;
	}

	// Token: 0x0600AA29 RID: 43561 RVA: 0x003F3594 File Offset: 0x003F1794
	public override object[] at()
	{
		return new object[]
		{
			dtc.a,
			dtc.b
		};
	}

	// Token: 0x0600AA2A RID: 43562 RVA: 0x003F35B8 File Offset: 0x003F17B8
	public override List<brl> j0()
	{
		List<brl> list = base.j0();
		if (list == null)
		{
			list = new List<brl>();
		}
		list.Add(new awr(typeof(cwu), 7));
		list.Add(new bap(15, new Type[]
		{
			typeof(ct7)
		}));
		return list;
	}

	// Token: 0x04003FB5 RID: 16309
	public new static readonly int a = 3;

	// Token: 0x04003FB6 RID: 16310
	public new static readonly int b = 7;
}
