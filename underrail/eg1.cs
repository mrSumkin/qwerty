using System;
using System.Collections.Generic;

// Token: 0x02001CAD RID: 7341
[d29("CripplingStrike", "Crippling Strike")]
public sealed class eg1 : ai8
{
	// Token: 0x0600A0E3 RID: 41187 RVA: 0x003E6990 File Offset: 0x003E4B90
	public eg1() : base("臃Калечащий удар")
	{
	}

	// Token: 0x0600A0E4 RID: 41188 RVA: 0x003E69A0 File Offset: 0x003E4BA0
	public override void ar(efk A_0)
	{
		A_0.SpecialAttacks.b(dgk.Get<fz>());
	}

	// Token: 0x0600A0E5 RID: 41189 RVA: 0x003E69B4 File Offset: 0x003E4BB4
	public override void @as(efk A_0)
	{
		A_0.SpecialAttacks.a(dgk.Get<fz>());
	}

	// Token: 0x0600A0E6 RID: 41190 RVA: 0x003E69CC File Offset: 0x003E4BCC
	public override object[] at()
	{
		return new object[]
		{
			(int)(fz.b * 100.0),
			fz.e,
			l4.a((double)fz.c, false),
			fz.d,
			l4.a(fz.f, false)
		};
	}

	// Token: 0x0600A0E7 RID: 41191 RVA: 0x003E6A30 File Offset: 0x003E4C30
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new bap(30, new Type[]
			{
				typeof(jk)
			})
		};
	}
}
