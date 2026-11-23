using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

// Token: 0x0200181C RID: 6172
[eiz("XSPA")]
[Serializable]
public sealed class any : d64, ISerializable, enp
{
	// Token: 0x06008361 RID: 33633 RVA: 0x0036E3A4 File Offset: 0x0036C5A4
	private any(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008362 RID: 33634 RVA: 0x0036E3B0 File Offset: 0x0036C5B0
	public any()
	{
	}

	// Token: 0x06008363 RID: 33635 RVA: 0x0036E3BC File Offset: 0x0036C5BC
	protected override bool gq()
	{
		if (!base.gq())
		{
			return false;
		}
		cd1 cd = base.c().aa().Offense.u();
		if (cd.TypedDefinition != null && base.b().a8().j == cgy.b && base.b().a8().Area == base.c().a8().Area)
		{
			double a_ = aw1.b(base.c().a8(), base.b().a8());
			double a_2 = awq.a(base.vg().e(), base.b(), a_);
			cmn cmn = awq.a(base.c(), base.b(), null, null);
			cmn.b += base.c().aa().Offense.an();
			cmn.g = bz1.c;
			double num = (double)bz1.d - base.c().aa().Offense.u().TypedDefinition.k();
			if (num > 0.0)
			{
				base.c().aa().Offense.u().Battery = Math.Max(0.0, base.c().aa().Offense.u().Battery - num);
			}
			cwt cwt = euf.a(base.c().aa(), base.b().aa(), a_, cmn, 0.0, base.b().a8().l(), base.c().aa().Darkvision, cd.CurrentBullet, awq.f(base.c()), a_2, false, null, null, true, null);
			cwt.k = "Оглушающий импульс";
			awq.a(base.c(), base.b(), cwt, cd, this, true, null, "xphw_pulseDaze", null, false, false, true, null, null);
			return true;
		}
		return false;
	}

	// Token: 0x06008364 RID: 33636 RVA: 0x0036E5DC File Offset: 0x0036C7DC
	public void af(amc A_0, amc A_1, cwt A_2, cru A_3)
	{
		if (A_1 != null && A_1.a8() != null && A_2.b)
		{
			c5x a_ = A_1.a8();
			string a_2 = "xphw_pulseDazeHit";
			int a_3 = 1;
			double maxValue = double.MaxValue;
			bool a_4 = true;
			bool a_5 = false;
			float? a_6 = dz6.b();
			boj.a(a_, a_2, a_3, maxValue, a_4, a_5, null, null, null, a_6, false);
			A_1.a8().c().a("xphw_pulseDaze");
		}
		if (A_2.b && A_3.a != null && A_1 != null && !A_1.aa().Passive && !A_1.aa().b(d8o.e) && !A_1.aa().Dead)
		{
			if (Enumerable.Sum<csk>(A_3.a, new Func<csk, int>(any.a.a.a)) > 0)
			{
				awq.b(A_0, A_1, d0u.b, false);
			}
		}
	}

	// Token: 0x0200181D RID: 6173
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06008367 RID: 33639 RVA: 0x0036E700 File Offset: 0x0036C900
		internal int a(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x04003282 RID: 12930
		public static readonly any.a a = new any.a();

		// Token: 0x04003283 RID: 12931
		public static Func<csk, int> b;
	}
}
