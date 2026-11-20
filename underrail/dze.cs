using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x0200138C RID: 5004
[bs6("HFX:rustingAcidSplash")]
[eiz("RACZX2")]
[Serializable]
public sealed class dze : cpl, ISerializable
{
	// Token: 0x06007130 RID: 28976 RVA: 0x002F8478 File Offset: 0x002F6678
	private dze(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007131 RID: 28977 RVA: 0x002F8484 File Offset: 0x002F6684
	public dze()
	{
	}

	// Token: 0x06007132 RID: 28978 RVA: 0x002F8490 File Offset: 0x002F6690
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (base.a() == null || base.b() == null || base.b().a8() == null || base.b().a8().Zone == null || base.agu() == null || base.b() == null || base.b().aa() == null)
		{
			return dc4.e;
		}
		if (!base.agw().b)
		{
			return dc4.c;
		}
		dtb dtb = new dtb();
		dtb.b(false);
		dtb.c(false);
		List<auv> list = dtb.ad();
		c5x a_ = base.b().a8();
		string a_2 = "RustingAcidSplash";
		int a_3 = 1;
		double maxValue = double.MaxValue;
		bool a_4 = true;
		bool a_5 = true;
		float? a_6 = dz6.b();
		list.Add(new a7j(a_, a_2, a_3, maxValue, a_4, a_5, null, null, null, a_6, false, null));
		dtb.ad().Add(new a4s(new bfq(Guid.NewGuid().ToString(), "AcidFizz"), null, new ar7(base.b().a8()), null));
		dtb.ad().Add(new amd(base.b(), new els[]
		{
			new ce(ce.b * d0u.b)
		}));
		dtb.ad().Add(new a27(base.a(), base.b(), true, true, false, true));
		base.b().a8().Zone.ActionManager.g9(dtb, atp.a);
		dz6.a(dtb);
		return dc4.c;
	}
}
