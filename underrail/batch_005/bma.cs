using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x020013B3 RID: 5043
[eiz("XPM")]
[bs6("HFX:explosiveHit")]
[Serializable]
public sealed class bma : cpl, ISerializable
{
	// Token: 0x060071B6 RID: 29110 RVA: 0x002FBCC0 File Offset: 0x002F9EC0
	private bma(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060071B7 RID: 29111 RVA: 0x002FBCCC File Offset: 0x002F9ECC
	public bma()
	{
	}

	// Token: 0x060071B8 RID: 29112 RVA: 0x002FBCD4 File Offset: 0x002F9ED4
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
			flag = (Enumerable.Sum<csk>(base.agy().b, new Func<csk, int>(bma.a.a.a)) > 0);
		}
		else
		{
			flag = false;
		}
		bool a_ = flag;
		dtb dtb = new dtb();
		dtb.b(false);
		dtb.c(false);
		List<auv> list = dtb.ad();
		c5x a_2 = base.b().a8();
		string a_3 = "ExplosionSmall";
		int a_4 = 1;
		double maxValue = double.MaxValue;
		bool a_5 = true;
		bool a_6 = true;
		float? a_7 = dz6.b();
		list.Add(new a7j(a_2, a_3, a_4, maxValue, a_5, a_6, null, null, null, a_7, false, null));
		dtb.ad().Add(new a4s(new bfq(Guid.NewGuid().ToString(), "FireballSpread"), null, new ar7(base.b().a8()), null));
		eym.a(dtb, base.b().a8(), (double)aju.bp);
		dtb.ad().Add(new akg(base.a(), base.b(), this.a(base.agw(), base.b(), a_), null, false));
		dtb.ad().Add(new a27(base.a(), base.b(), true, true, false, true));
		foreach (amc amc in aw1.a(base.b().a8(), 1))
		{
			List<auv> list2 = dtb.ad();
			c5x a_8 = amc.a8();
			string a_9 = "ExplosionSmall";
			int a_10 = 1;
			double maxValue2 = double.MaxValue;
			bool a_11 = true;
			bool a_12 = true;
			a_7 = dz6.b();
			list2.Add(new a7j(a_8, a_9, a_10, maxValue2, a_11, a_12, null, null, null, a_7, false, null));
			dtb.ad().Add(new akg(base.a(), amc, this.a(base.agw(), base.b(), false), new b7x(null), false));
		}
		base.b().a8().Zone.ActionManager.g9(dtb, atp.a);
		dz6.a(dtb);
		return dc4.c;
	}

	// Token: 0x060071B9 RID: 29113 RVA: 0x002FBFBC File Offset: 0x002FA1BC
	private cwt a(cwt A_0, amc A_1, bool A_2)
	{
		cwt cwt = new cwt();
		cwt.b = true;
		cwt.c = A_0.c;
		cwt.f.Add(euf.a(kn.b(base.agu()), 1.0));
		cwt.f.Add(euf.a(kn.c(base.agu()), 1.0));
		cwt.v = "взрыв";
		cwt.h = ImpactSpeed.VeryHigh;
		cwt.i = new ap9(base.a().aa());
		cwt.j = new ap9(A_1.aa());
		cwt.w = false;
		cwt.l = A_2;
		cpl.a(A_0, cwt);
		cwt.ad["IsExplosion"] = true;
		return cwt;
	}

	// Token: 0x020013B4 RID: 5044
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x060071BC RID: 29116 RVA: 0x002FC0A4 File Offset: 0x002FA2A4
		internal int a(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x04002E6C RID: 11884
		public static readonly bma.a a = new bma.a();

		// Token: 0x04002E6D RID: 11885
		public static Func<csk, int> b;
	}
}
