using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x0200136B RID: 4971
[eiz("CASHHIEFA")]
[bs6("HFX:energyHit")]
[Serializable]
public sealed class deb : cpl, ISerializable, enp
{
	// Token: 0x060070B9 RID: 28857 RVA: 0x002F5324 File Offset: 0x002F3524
	private deb(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060070BA RID: 28858 RVA: 0x002F5330 File Offset: 0x002F3530
	public deb()
	{
	}

	// Token: 0x060070BB RID: 28859 RVA: 0x002F533C File Offset: 0x002F353C
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
		cd1 cd = base.c();
		if (cd == null)
		{
			return dc4.c;
		}
		a1q a_ = ly.a(base.agu());
		bool flag;
		if (base.agy().b != null)
		{
			flag = (Enumerable.Sum<csk>(base.agy().b, new Func<csk, int>(deb.a.a.b)) > 0);
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
		string a_4 = "LaserHit";
		int maxValue = int.MaxValue;
		double a_5 = (double)dz6.b(300);
		bool a_6 = true;
		bool a_7 = true;
		float? a_8 = dz6.b();
		list.Add(new a7j(a_3, a_4, maxValue, a_5, a_6, a_7, null, null, null, a_8, false, null));
		eym.a(dtb, base.b().a8(), (double)aju.bg);
		dtb.ad().Add(new akg(base.a(), base.b(), this.a(base.agw(), a_, base.b(), euf.d(cd.TypedDefinition), a_2), new b7x(this), false));
		dtb.ad().Add(new a27(base.a(), base.b(), true, true, false, true));
		base.b().a8().Zone.ActionManager.g9(dtb, atp.a);
		dz6.a(dtb);
		return dc4.c;
	}

	// Token: 0x060070BC RID: 28860 RVA: 0x002F553C File Offset: 0x002F373C
	private cwt a(cwt A_0, a1q A_1, amc A_2, WeaponSubtype? A_3, bool A_4)
	{
		cwt cwt = new cwt();
		cwt.b = true;
		cwt.f.Add(euf.a(A_1, 1.0));
		cwt.v = "ёмкостной разряд";
		cwt.h = ImpactSpeed.VeryHigh;
		cwt.i = new ap9(base.a().aa());
		cwt.j = new ap9(A_2.aa());
		cwt.l = A_4;
		cwt.ae = A_3;
		cwt.w = true;
		cpl.a(A_0, cwt);
		return cwt;
	}

	// Token: 0x060070BD RID: 28861 RVA: 0x002F55C8 File Offset: 0x002F37C8
	public void af(amc A_0, amc A_1, cwt A_2, cru A_3)
	{
		if (A_1 != null && A_1.a8() != null && A_3 != null && A_3.a != null)
		{
			if (Enumerable.Sum<csk>(A_3.a, new Func<csk, int>(deb.a.a.a)) > 0 || A_3.c)
			{
				A_1.a8().c().a("LaserHit");
				return;
			}
			A_1.a8().c().a("LaserResist");
		}
	}

	// Token: 0x0200136C RID: 4972
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x060070C0 RID: 28864 RVA: 0x002F567C File Offset: 0x002F387C
		internal int b(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x060070C1 RID: 28865 RVA: 0x002F5688 File Offset: 0x002F3888
		internal int a(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x04002E1D RID: 11805
		public static readonly deb.a a = new deb.a();

		// Token: 0x04002E1E RID: 11806
		public static Func<csk, int> b;

		// Token: 0x04002E1F RID: 11807
		public static Func<csk, int> c;
	}
}
