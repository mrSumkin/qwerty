using System;
using System.Collections.Generic;

// Token: 0x02001C89 RID: 7305
[d29("EscapeArtist", "Escape Artist")]
public sealed class a4n : ai8
{
	// Token: 0x0600A00E RID: 40974 RVA: 0x003E4CF4 File Offset: 0x003E2EF4
	public a4n() : base("胍Разорвать путы")
	{
	}

	// Token: 0x0600A00F RID: 40975 RVA: 0x003E4D04 File Offset: 0x003E2F04
	public override void ar(efk A_0)
	{
		A_0.SpecialAbilities.b(dgk.Get<d35>());
	}

	// Token: 0x0600A010 RID: 40976 RVA: 0x003E4D18 File Offset: 0x003E2F18
	public override void @as(efk A_0)
	{
		A_0.SpecialAbilities.a(dgk.Get<d35>());
	}

	// Token: 0x0600A011 RID: 40977 RVA: 0x003E4D2C File Offset: 0x003E2F2C
	public override object[] at()
	{
		return new object[]
		{
			l4.a(d35.b, false)
		};
	}

	// Token: 0x0600A012 RID: 40978 RVA: 0x003E4D48 File Offset: 0x003E2F48
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new awr(typeof(cwu), 7),
			new bap(30, new Type[]
			{
				typeof(e74)
			})
		};
	}
}
