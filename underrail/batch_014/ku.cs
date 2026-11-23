using System;
using System.Collections.Generic;

// Token: 0x02001CAC RID: 7340
[d29("HeavyPunch", "Heavy Punch")]
public sealed class ku : ai8
{
	// Token: 0x0600A0DE RID: 41182 RVA: 0x003E68B0 File Offset: 0x003E4AB0
	public ku() : base("臀Тяжёлая рука")
	{
	}

	// Token: 0x0600A0DF RID: 41183 RVA: 0x003E68C0 File Offset: 0x003E4AC0
	public override void ar(efk A_0)
	{
		A_0.SpecialAttacks.b(dgk.Get<bs>());
	}

	// Token: 0x0600A0E0 RID: 41184 RVA: 0x003E68D4 File Offset: 0x003E4AD4
	public override void @as(efk A_0)
	{
		A_0.SpecialAttacks.a(dgk.Get<bs>());
	}

	// Token: 0x0600A0E1 RID: 41185 RVA: 0x003E68E8 File Offset: 0x003E4AE8
	public override object[] at()
	{
		return new object[]
		{
			Convert.ToInt32(bs.b * 100.0),
			Convert.ToInt32(bs.c * 100.0),
			l4.a(bs.d, false)
		};
	}

	// Token: 0x0600A0E2 RID: 41186 RVA: 0x003E6944 File Offset: 0x003E4B44
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new awr(typeof(d3m), 5),
			new bap(15, new Type[]
			{
				typeof(jk)
			})
		};
	}
}
