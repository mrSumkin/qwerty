using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x020013B6 RID: 5046
[bs6("HFX:electroshock")]
[eiz("E37")]
[Serializable]
public sealed class az8 : cpl, ISerializable
{
	// Token: 0x060071C0 RID: 29120 RVA: 0x002FC33C File Offset: 0x002FA53C
	private az8(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060071C1 RID: 29121 RVA: 0x002FC348 File Offset: 0x002FA548
	public az8()
	{
	}

	// Token: 0x060071C2 RID: 29122 RVA: 0x002FC354 File Offset: 0x002FA554
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
		a1q a_ = nx.a(base.agu());
		amc amc = base.a();
		n4.a((amc != null) ? amc.aa() : null, ref a_);
		bool flag;
		if (base.agy().b != null)
		{
			flag = (Enumerable.Sum<csk>(base.agy().b, new Func<csk, int>(az8.a.a.a)) > 0);
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
		string a_4 = "Electricity";
		int maxValue = int.MaxValue;
		double a_5 = (double)dz6.b(300);
		bool a_6 = true;
		bool a_7 = true;
		float? a_8 = dz6.b();
		list.Add(new a7j(a_3, a_4, maxValue, a_5, a_6, a_7, null, null, null, a_8, false, null));
		dtb.ad().Add(new a4s(new bfq(Guid.NewGuid().ToString(), "Electroshock"), null, new ar7(base.b().a8()), null));
		eym.a(dtb, base.b().a8(), (double)aju.bf);
		dtb.ad().Add(new akg(base.a(), base.b(), this.a(base.agw(), a_, base.b(), a_2), new b7x(null), false));
		dtb.ad().Add(new a27(base.a(), base.b(), true, true, false, true));
		base.b().a8().Zone.ActionManager.g9(dtb, atp.a);
		dz6.a(dtb);
		return dc4.c;
	}

	// Token: 0x060071C3 RID: 29123 RVA: 0x002FC598 File Offset: 0x002FA798
	private cwt a(cwt A_0, a1q A_1, amc A_2, bool A_3)
	{
		cwt cwt = new cwt();
		cwt.b = true;
		cwt.f.Add(euf.a(A_1, 1.0));
		cwt.v = "электрошок";
		cwt.h = ImpactSpeed.VeryHigh;
		cwt.i = new ap9(base.a().aa());
		cwt.j = new ap9(A_2.aa());
		cwt.w = true;
		cwt.l = A_3;
		cpl.a(A_0, cwt);
		return cwt;
	}

	// Token: 0x020013B7 RID: 5047
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x060071C6 RID: 29126 RVA: 0x002FC630 File Offset: 0x002FA830
		internal int a(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x04002E6E RID: 11886
		public static readonly az8.a a = new az8.a();

		// Token: 0x04002E6F RID: 11887
		public static Func<csk, int> b;
	}
}
