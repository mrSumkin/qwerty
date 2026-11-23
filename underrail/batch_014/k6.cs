using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x0200136D RID: 4973
[bs6("HFX:burn")]
[eiz("BHE")]
[Serializable]
public sealed class k6 : cpl, ISerializable
{
	// Token: 0x060070C2 RID: 28866 RVA: 0x002F5694 File Offset: 0x002F3894
	private k6(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060070C3 RID: 28867 RVA: 0x002F56A0 File Offset: 0x002F38A0
	public k6()
	{
	}

	// Token: 0x060070C4 RID: 28868 RVA: 0x002F56AC File Offset: 0x002F38AC
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
		a1q a_ = cmw.a(base.agu());
		bool flag;
		if (base.agy().b != null)
		{
			flag = (Enumerable.Sum<csk>(base.agy().b, new Func<csk, int>(k6.a.a.a)) > 0);
		}
		else
		{
			flag = false;
		}
		bool a_2 = flag;
		dtb dtb = new dtb();
		dtb.b(false);
		dtb.c(false);
		List<auv> list = dtb.ad();
		c5x a_3 = base.b().a8();
		string a_4 = "ExplosionSmall";
		int maxValue = int.MaxValue;
		double a_5 = (double)dz6.b(300);
		bool a_6 = true;
		bool a_7 = true;
		float? a_8 = dz6.b();
		list.Add(new a7j(a_3, a_4, maxValue, a_5, a_6, a_7, null, null, null, a_8, false, null));
		dtb.ad().Add(new a4s(new bfq(Guid.NewGuid().ToString(), "Flare"), null, new ar7(base.b().a8()), null));
		dtb.ad().Add(new akg(base.a(), base.b(), this.a(base.agw(), a_, base.b(), a_2), new b7x(null), false));
		dtb.ad().Add(new a27(base.a(), base.b(), true, true, false, true));
		base.b().a8().Zone.ActionManager.g9(dtb, atp.a);
		dz6.a(dtb);
		return dc4.c;
	}

	// Token: 0x060070C5 RID: 28869 RVA: 0x002F58B8 File Offset: 0x002F3AB8
	private cwt a(cwt A_0, a1q A_1, amc A_2, bool A_3)
	{
		cwt cwt = new cwt();
		cwt.b = true;
		cwt.f.Add(euf.a(A_1, 1.0));
		cwt.h = ImpactSpeed.VeryHigh;
		cwt.i = new ap9(base.a().aa());
		cwt.j = new ap9(A_2.aa());
		cwt.w = true;
		cwt.l = A_3;
		cpl.a(A_0, cwt);
		return cwt;
	}

	// Token: 0x0200136E RID: 4974
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x060070C8 RID: 28872 RVA: 0x002F5948 File Offset: 0x002F3B48
		internal int a(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x04002E20 RID: 11808
		public static readonly k6.a a = new k6.a();

		// Token: 0x04002E21 RID: 11809
		public static Func<csk, int> b;
	}
}
