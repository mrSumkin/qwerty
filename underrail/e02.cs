using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001394 RID: 5012
[bs6("HFX:energyCut")]
[eiz("EC30")]
[Serializable]
public sealed class e02 : cpl, ISerializable, enp
{
	// Token: 0x0600714A RID: 29002 RVA: 0x002F8EB0 File Offset: 0x002F70B0
	private e02(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600714B RID: 29003 RVA: 0x002F8EBC File Offset: 0x002F70BC
	public e02()
	{
	}

	// Token: 0x0600714C RID: 29004 RVA: 0x002F8EC4 File Offset: 0x002F70C4
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
		int num = brd.b(base.agu());
		if (cd.MaxBattery == 0 || (double)num <= cd.Battery)
		{
			cd.Battery -= (double)num;
			a1q a_ = brd.a(base.agu());
			amc amc = base.a();
			n4.a((amc != null) ? amc.aa() : null, ref a_);
			bool flag;
			if (base.agy().b != null)
			{
				flag = (Enumerable.Sum<csk>(base.agy().b, new Func<csk, int>(e02.a.a.b)) > 0);
			}
			else
			{
				flag = false;
			}
			bool a_2 = flag;
			dtb dtb = new dtb();
			dtb.b(false);
			dtb.c(false);
			dtb.ad().Add(new a4s(new bfq("EnergyCut"), null, new ar7(base.b().a8()), null));
			List<auv> list = dtb.ad();
			c5x a_3 = base.b().a8();
			string a_4 = "EnergySlash" + cuo.a.Next(1, 3).ToString();
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
		}
		return dc4.c;
	}

	// Token: 0x0600714D RID: 29005 RVA: 0x002F9164 File Offset: 0x002F7364
	private cwt a(cwt A_0, a1q A_1, amc A_2, WeaponSubtype? A_3, bool A_4)
	{
		cwt cwt = new cwt();
		cwt.b = true;
		cwt.f.Add(euf.a(A_1, 1.0));
		cwt.v = "энергетический разрез";
		cwt.h = ImpactSpeed.VeryHigh;
		cwt.i = new ap9(base.a().aa());
		cwt.j = new ap9(A_2.aa());
		cwt.l = A_4;
		cwt.ae = A_3;
		cwt.w = true;
		cpl.a(A_0, cwt);
		return cwt;
	}

	// Token: 0x0600714E RID: 29006 RVA: 0x002F91F0 File Offset: 0x002F73F0
	public void af(amc A_0, amc A_1, cwt A_2, cru A_3)
	{
		if (A_1 != null && A_1.a8() != null && A_3 != null && A_3.a != null)
		{
			if (Enumerable.Sum<csk>(A_3.a, new Func<csk, int>(e02.a.a.a)) > 0)
			{
				A_1.a8().c().a("LaserHit");
				return;
			}
		}
		A_1.a8().c().a("LaserResist");
	}

	// Token: 0x02001395 RID: 5013
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06007151 RID: 29009 RVA: 0x002F9298 File Offset: 0x002F7498
		internal int b(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x06007152 RID: 29010 RVA: 0x002F92A4 File Offset: 0x002F74A4
		internal int a(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x04002E4A RID: 11850
		public static readonly e02.a a = new e02.a();

		// Token: 0x04002E4B RID: 11851
		public static Func<csk, int> b;

		// Token: 0x04002E4C RID: 11852
		public static Func<csk, int> c;
	}
}
