using System;
using System.Collections.Generic;

// Token: 0x02001DEE RID: 7662
[d29("Cutthroat", "Cut-throat")]
public sealed class exo : ai8
{
	// Token: 0x0600A991 RID: 43409 RVA: 0x003F1F7C File Offset: 0x003F017C
	public override bool ap()
	{
		return false;
	}

	// Token: 0x0600A992 RID: 43410 RVA: 0x003F1F80 File Offset: 0x003F0180
	public exo() : base("膪Горлорез")
	{
	}

	// Token: 0x0600A993 RID: 43411 RVA: 0x003F1F90 File Offset: 0x003F0190
	public override void ar(efk A_0)
	{
		A_0.SpecialAttacks.b(dgk.Get<bsk>());
	}

	// Token: 0x0600A994 RID: 43412 RVA: 0x003F1FA4 File Offset: 0x003F01A4
	public override void @as(efk A_0)
	{
		A_0.SpecialAttacks.a(dgk.Get<bsk>());
	}

	// Token: 0x0600A995 RID: 43413 RVA: 0x003F1FBC File Offset: 0x003F01BC
	public override object[] at()
	{
		return new object[]
		{
			(int)(exo.a * 100.0),
			l4.a(exo.b, false),
			bsk.b,
			l4.a((double)exo.c, false)
		};
	}

	// Token: 0x0600A996 RID: 43414 RVA: 0x003F2014 File Offset: 0x003F0214
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new awr(typeof(cwu), 10),
			new bap(55, new Type[]
			{
				typeof(jk)
			}),
			new bap(45, new Type[]
			{
				typeof(a2n)
			})
		};
	}

	// Token: 0x04003F8A RID: 16266
	public new static readonly double a = 8.0;

	// Token: 0x04003F8B RID: 16267
	public new static readonly int b = 3;

	// Token: 0x04003F8C RID: 16268
	public static readonly int c = 6 * d0u.b;
}
