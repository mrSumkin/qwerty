using System;
using System.Collections.Generic;

// Token: 0x02001C85 RID: 7301
[d29("SuperSlam", "Super Slam")]
public sealed class b9c : ai8
{
	// Token: 0x06009FF8 RID: 40952 RVA: 0x003E4AA8 File Offset: 0x003E2CA8
	public override bool ap()
	{
		return false;
	}

	// Token: 0x06009FF9 RID: 40953 RVA: 0x003E4AAC File Offset: 0x003E2CAC
	public b9c() : base("膳Вразнос")
	{
	}

	// Token: 0x06009FFA RID: 40954 RVA: 0x003E4ABC File Offset: 0x003E2CBC
	public override void ar(efk A_0)
	{
		A_0.SpecialAttacks.b(dgk.Get<cbi>());
	}

	// Token: 0x06009FFB RID: 40955 RVA: 0x003E4AD0 File Offset: 0x003E2CD0
	public override void @as(efk A_0)
	{
		A_0.SpecialAttacks.a(dgk.Get<cbi>());
	}

	// Token: 0x06009FFC RID: 40956 RVA: 0x003E4AE4 File Offset: 0x003E2CE4
	public override object[] at()
	{
		return new object[]
		{
			(int)(cbi.b * 100.0),
			l4.a(cbi.c, false)
		};
	}

	// Token: 0x06009FFD RID: 40957 RVA: 0x003E4B14 File Offset: 0x003E2D14
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new awr(typeof(d3m), 10),
			new bap(75, new Type[]
			{
				typeof(jk)
			})
		};
	}
}
