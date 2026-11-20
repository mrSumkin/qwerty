using System;
using System.Collections.Generic;

// Token: 0x02001E01 RID: 7681
[d29("KCS", "Kneecap Shot")]
public sealed class edd : ai8
{
	// Token: 0x0600AA0D RID: 43533 RVA: 0x003F30D0 File Offset: 0x003F12D0
	public override bool ap()
	{
		return false;
	}

	// Token: 0x0600AA0E RID: 43534 RVA: 0x003F30D4 File Offset: 0x003F12D4
	public edd() : base("胲Выстрел в колено")
	{
	}

	// Token: 0x0600AA0F RID: 43535 RVA: 0x003F30E4 File Offset: 0x003F12E4
	public override void ar(efk A_0)
	{
		A_0.SpecialAttacks.b(dgk.Get<d9w>());
	}

	// Token: 0x0600AA10 RID: 43536 RVA: 0x003F30F8 File Offset: 0x003F12F8
	public override void @as(efk A_0)
	{
		A_0.SpecialAttacks.a(dgk.Get<d9w>());
	}

	// Token: 0x0600AA11 RID: 43537 RVA: 0x003F310C File Offset: 0x003F130C
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new bap(25, new Type[]
			{
				typeof(ct7),
				typeof(e5n)
			}),
			new awr(typeof(eav), 7)
		};
	}

	// Token: 0x0600AA12 RID: 43538 RVA: 0x003F3164 File Offset: 0x003F1364
	public override object[] at()
	{
		return new object[]
		{
			(int)(edd.d * 100.0),
			l4.a((double)edd.b, false),
			l4.a((double)edd.c, false)
		};
	}

	// Token: 0x0600AA13 RID: 43539 RVA: 0x003F31A4 File Offset: 0x003F13A4
	protected override string nq()
	{
		if (dk2.f())
		{
			return "XPBL";
		}
		return null;
	}

	// Token: 0x04003FAE RID: 16302
	public new static readonly float a = 0.5f;

	// Token: 0x04003FAF RID: 16303
	public new static readonly int b = 15000;

	// Token: 0x04003FB0 RID: 16304
	public static readonly int c = 25000;

	// Token: 0x04003FB1 RID: 16305
	public new static readonly double d = 1.25;
}
