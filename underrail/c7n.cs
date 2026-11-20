using System;
using System.Collections.Generic;

// Token: 0x02001CCB RID: 7371
[d29("SpearThrow", "Spear Throw")]
public sealed class c7n : ai8
{
	// Token: 0x0600A1BB RID: 41403 RVA: 0x003E7DEC File Offset: 0x003E5FEC
	public c7n() : base("膖Бросок копья")
	{
	}

	// Token: 0x0600A1BC RID: 41404 RVA: 0x003E7DFC File Offset: 0x003E5FFC
	public override string au()
	{
		return "xpbl";
	}

	// Token: 0x0600A1BD RID: 41405 RVA: 0x003E7E04 File Offset: 0x003E6004
	public override bool ap()
	{
		return false;
	}

	// Token: 0x0600A1BE RID: 41406 RVA: 0x003E7E08 File Offset: 0x003E6008
	public override void ar(efk A_0)
	{
		A_0.SpecialAttacks.b(dgk.Get<xd>());
		A_0.SpecialAbilities.b(dgk.Get<bmb>());
	}

	// Token: 0x0600A1BF RID: 41407 RVA: 0x003E7E38 File Offset: 0x003E6038
	public override void @as(efk A_0)
	{
		A_0.SpecialAttacks.a(dgk.Get<xd>());
		A_0.SpecialAbilities.a(dgk.Get<bmb>());
	}

	// Token: 0x0600A1C0 RID: 41408 RVA: 0x003E7E68 File Offset: 0x003E6068
	public override object[] at()
	{
		return new object[]
		{
			Convert.ToInt32(xd.b * 100.0),
			Convert.ToInt32(xd.c * 100.0),
			xd.d,
			l4.a(xd.f, false)
		};
	}

	// Token: 0x0600A1C1 RID: 41409 RVA: 0x003E7ED0 File Offset: 0x003E60D0
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new awr(typeof(cwu), 5),
			new bap(20, new Type[]
			{
				typeof(jk)
			}),
			new bap(20, new Type[]
			{
				typeof(dei)
			})
		};
	}
}
