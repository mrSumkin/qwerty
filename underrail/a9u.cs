using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x020013AF RID: 5039
[bs6("HFX:acid")]
[eiz("ACCY")]
[Serializable]
public sealed class a9u : cpl, ISerializable
{
	// Token: 0x060071A8 RID: 29096 RVA: 0x002FB6BC File Offset: 0x002F98BC
	private a9u(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060071A9 RID: 29097 RVA: 0x002FB6C8 File Offset: 0x002F98C8
	public a9u()
	{
	}

	// Token: 0x060071AA RID: 29098 RVA: 0x002FB6D4 File Offset: 0x002F98D4
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
		bool flag;
		if (base.agy().b != null)
		{
			flag = (Enumerable.Sum<csk>(base.agy().b, new Func<csk, int>(a9u.a.a.a)) > 0);
		}
		else
		{
			flag = false;
		}
		bool a_ = flag;
		a1q a_2 = efz.a(base.agu());
		dtb dtb = new dtb();
		dtb.b(false);
		dtb.c(false);
		List<auv> list = dtb.ad();
		c5x a_3 = base.b().a8();
		string a_4 = "AcidSplash";
		int a_5 = 1;
		double maxValue = double.MaxValue;
		bool a_6 = true;
		bool a_7 = true;
		float? a_8 = dz6.b();
		list.Add(new a7j(a_3, a_4, a_5, maxValue, a_6, a_7, null, null, null, a_8, false, null));
		dtb.ad().Add(new a4s(new bfq(Guid.NewGuid().ToString(), "AcidFizz"), null, new ar7(base.b().a8()), null));
		dtb.ad().Add(new akg(base.a(), base.b(), this.a(base.agw(), a_2, base.b(), a_), new b7x(null), false));
		dtb.ad().Add(new a27(base.a(), base.b(), true, true, false, true));
		base.b().a8().Zone.ActionManager.g9(dtb, atp.a);
		dz6.a(dtb);
		return dc4.c;
	}

	// Token: 0x060071AB RID: 29099 RVA: 0x002FB8DC File Offset: 0x002F9ADC
	private cwt a(cwt A_0, a1q A_1, amc A_2, bool A_3)
	{
		cwt cwt = new cwt();
		cwt.b = true;
		cwt.c = A_0.c;
		cwt.f.Add(euf.a(A_1, 1.0));
		cwt.v = "кислотный заряд";
		cwt.h = ImpactSpeed.Medium;
		cwt.i = new ap9(base.a().aa());
		cwt.j = new ap9(A_2.aa());
		cwt.w = false;
		cwt.l = A_3;
		cpl.a(A_0, cwt);
		return cwt;
	}

	// Token: 0x020013B0 RID: 5040
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x060071AE RID: 29102 RVA: 0x002FB980 File Offset: 0x002F9B80
		internal int a(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x04002E6A RID: 11882
		public static readonly a9u.a a = new a9u.a();

		// Token: 0x04002E6B RID: 11883
		public static Func<csk, int> b;
	}
}
