using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001805 RID: 6149
[eiz("CLXA")]
[Serializable]
public sealed class c2l : a6k, ISerializable
{
	// Token: 0x060082AC RID: 33452 RVA: 0x0036CCB8 File Offset: 0x0036AEB8
	private c2l(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060082AD RID: 33453 RVA: 0x0036CCC4 File Offset: 0x0036AEC4
	public c2l()
	{
	}

	// Token: 0x060082AE RID: 33454 RVA: 0x0036CCD0 File Offset: 0x0036AED0
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (base.vg().q() == null || base.vg().q().h == null || base.vg().q().h.b == null)
		{
			return dc4.e;
		}
		c5x c5x = base.vg().h() as c5x;
		if (c5x == null || c5x.h == null || c5x.h.b == null)
		{
			return dc4.e;
		}
		coh coh = base.vg().e().b9() as coh;
		if (coh == null || coh.Battery < (double)gn.a)
		{
			return dc4.e;
		}
		coh.Battery -= (double)gn.a;
		double a_ = aw1.b(base.vg().q(), c5x);
		cd1 cd = gn.a();
		cmn a_2 = awq.a(base.vg().q().h.b, c5x.h.b, cd, null);
		cwt cwt = euf.a(base.vg().e().b8(), c5x.h.b.aa(), a_, a_2, 0.0, c5x.l(), base.vg().e().b8().Darkvision, AmmoType.Energy, awq.f(base.vg().q().h.b), 1.0, false, cd, null, true, null);
		cwt.k = "Лазерная кошка";
		base.vg().q().c().a("CatMeow");
		awq.a(base.vg().q().h.b, c5x.h.b, cwt, cd, null, true, null, null, null, false, false, true, null, null);
		return dc4.c;
	}
}
