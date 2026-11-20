using System;
using System.Runtime.Serialization;

// Token: 0x020017BD RID: 6077
[eiz("B07")]
[Serializable]
public sealed class dw0 : a6k, ISerializable
{
	// Token: 0x060081C3 RID: 33219 RVA: 0x0036A018 File Offset: 0x00368218
	private dw0(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060081C4 RID: 33220 RVA: 0x0036A024 File Offset: 0x00368224
	public dw0()
	{
	}

	// Token: 0x060081C5 RID: 33221 RVA: 0x0036A030 File Offset: 0x00368230
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		c5x c5x = base.vg().h() as c5x;
		if (c5x == null || c5x.h.b == null || c5x.h.b.aa().Dead || c5x.Zone == null)
		{
			return dc4.e;
		}
		if (c5x.h.b.aa().Passive || c5x.h.b.aa().b(d8o.e | d8o.s))
		{
			etm a_ = new etm(new ap9(c5x.h.b.aa()), "лечению");
			bey.a(a_, base.vg().e().b8(), c5x.h.b.aa(), c5x.h.b);
			a7v.a(a_);
			bmj.a(c5x, new ba0());
			return dc4.e;
		}
		if (Math.Ceiling((double)(c5x.h.b.aa().Defense.q().zo() / Math.Max(1f, c5x.h.b.aa().Defense.q().zm()) * 100f)) / 100.0 <= ec3.b(base.vg().e()))
		{
			return dc4.e;
		}
		c5x.c().a(Guid.NewGuid().ToString(), "BandageApply", 1f, c9z.a, false, false);
		c5x a_2 = c5x;
		string a_3 = "Heal";
		int a_4 = 1;
		double maxValue = double.MaxValue;
		bool a_5 = true;
		bool a_6 = true;
		float? a_7 = dz6.b();
		a7j a_8 = new a7j(a_2, a_3, a_4, maxValue, a_5, a_6, null, null, null, a_7, false, null);
		c5x.Zone.ActionManager.g9(a_8, atp.a);
		int val = (int)(c5x.h.b.aa().Defense.q().zm() - c5x.h.b.aa().Defense.q().zo());
		int a_9 = Math.Min(ec3.a(base.vg().e()), val);
		amc amc;
		if (base.vg().q() != null)
		{
			amc = base.vg().q().h.b;
		}
		else
		{
			amc = null;
		}
		c5x.h.b.aa().Defense.a(a_9, (amc != null) ? amc.aa() : null, base.vg().e().b9(), true, false, false, null);
		return dc4.c;
	}
}
