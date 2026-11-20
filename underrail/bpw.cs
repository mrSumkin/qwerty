using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x020013B1 RID: 5041
[eiz("BHY")]
[bs6("HFX:bioHit")]
[Serializable]
public sealed class bpw : cpl, ISerializable
{
	// Token: 0x060071AF RID: 29103 RVA: 0x002FB98C File Offset: 0x002F9B8C
	private bpw(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060071B0 RID: 29104 RVA: 0x002FB998 File Offset: 0x002F9B98
	public bpw()
	{
	}

	// Token: 0x060071B1 RID: 29105 RVA: 0x002FB9A4 File Offset: 0x002F9BA4
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
		a1q a_ = e66.a(base.agu());
		dtb dtb = new dtb();
		dtb.b(false);
		dtb.c(false);
		List<auv> list = dtb.ad();
		c5x a_2 = base.b().a8();
		string a_3 = "ToxicSmoke";
		int a_4 = 1;
		double maxValue = double.MaxValue;
		bool a_5 = true;
		bool a_6 = true;
		float? a_7 = dz6.b();
		list.Add(new a7j(a_2, a_3, a_4, maxValue, a_5, a_6, null, null, null, a_7, false, null));
		dtb.ad().Add(new akg(base.a(), base.b(), this.a(base.agw(), a_, base.b()), new b7x(null), false));
		dtb.ad().Add(new a27(base.a(), base.b(), true, true, false, true));
		base.b().a8().Zone.ActionManager.g9(dtb, atp.a);
		dz6.a(dtb);
		return dc4.c;
	}

	// Token: 0x060071B2 RID: 29106 RVA: 0x002FBB1C File Offset: 0x002F9D1C
	private cwt a(cwt A_0, a1q A_1, amc A_2)
	{
		cwt cwt = new cwt();
		cwt.b = true;
		cwt.c = A_0.c;
		cwt.f.Add(euf.a(A_1, 1.0));
		cwt.v = "загрязнение";
		cwt.h = ImpactSpeed.Low;
		cwt.i = new ap9(base.a().aa());
		cwt.j = new ap9(A_2.aa());
		cwt.w = true;
		cwt.l = true;
		cpl.a(A_0, cwt);
		return cwt;
	}
}
