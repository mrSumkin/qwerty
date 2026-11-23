using System;
using System.Collections.Generic;

// Token: 0x02001C19 RID: 7193
[d29("Sap", "Sap")]
public sealed class e0f : ai8
{
	// Token: 0x06009DF4 RID: 40436 RVA: 0x003E1078 File Offset: 0x003DF278
	public override bool ap()
	{
		return false;
	}

	// Token: 0x06009DF5 RID: 40437 RVA: 0x003E107C File Offset: 0x003DF27C
	public e0f() : base("膯Ломом по башке")
	{
	}

	// Token: 0x06009DF6 RID: 40438 RVA: 0x003E108C File Offset: 0x003DF28C
	public override void ar(efk A_0)
	{
		A_0.SpecialAttacks.b(dgk.Get<dvf>());
	}

	// Token: 0x06009DF7 RID: 40439 RVA: 0x003E10A0 File Offset: 0x003DF2A0
	public override void @as(efk A_0)
	{
		A_0.SpecialAttacks.a(dgk.Get<dvf>());
	}

	// Token: 0x06009DF8 RID: 40440 RVA: 0x003E10B8 File Offset: 0x003DF2B8
	public override object[] at()
	{
		return new object[]
		{
			l4.a(e0f.b, false),
			l4.a((double)e0f.a, false),
			Convert.ToInt32(e0f.c * 100.0)
		};
	}

	// Token: 0x06009DF9 RID: 40441 RVA: 0x003E1104 File Offset: 0x003DF304
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new bap(50, new Type[]
			{
				typeof(jk)
			}),
			new bap(50, new Type[]
			{
				typeof(a2n)
			})
		};
	}

	// Token: 0x06009DFA RID: 40442 RVA: 0x003E1158 File Offset: 0x003DF358
	public static double c(efk A_0)
	{
		double num = e0f.c;
		if (A_0 != null)
		{
			num += (double)A_0.GetSpecializationValue<ew4>(true) * ew4.a;
		}
		return num;
	}

	// Token: 0x06009DFB RID: 40443 RVA: 0x003E1184 File Offset: 0x003DF384
	public static int b(efk A_0)
	{
		int num = e0f.b;
		if (A_0 != null)
		{
			num += A_0.GetSpecializationValue<at0>(true) * at0.a;
		}
		return num;
	}

	// Token: 0x06009DFC RID: 40444 RVA: 0x003E11B0 File Offset: 0x003DF3B0
	public static int a(efk A_0)
	{
		int num = e0f.a;
		if (A_0 != null)
		{
			num -= A_0.GetSpecializationValue<bcc>(true) * bcc.a;
		}
		return num;
	}

	// Token: 0x04003D47 RID: 15687
	public new static readonly int a = 6 * d0u.b;

	// Token: 0x04003D48 RID: 15688
	public new static readonly int b = 5;

	// Token: 0x04003D49 RID: 15689
	public static readonly double c = 0.20000000298023224;
}
