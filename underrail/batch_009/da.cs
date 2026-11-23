using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x020013CA RID: 5066
[eiz("E30")]
[bs6("HFX:electroshockAoe")]
[Serializable]
public sealed class da : cpl, ISerializable
{
	// Token: 0x0600720E RID: 29198 RVA: 0x002FEB74 File Offset: 0x002FCD74
	private da(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600720F RID: 29199 RVA: 0x002FEB80 File Offset: 0x002FCD80
	public da()
	{
	}

	// Token: 0x06007210 RID: 29200 RVA: 0x002FEB88 File Offset: 0x002FCD88
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
		int num = cyb.c(base.agu());
		if (cd.MaxBattery == 0 || (double)num <= cd.Battery)
		{
			cd.Battery -= (double)num;
			List<amc> list = aw1.a(base.b().a8(), 1);
			List<amc> list2 = new List<amc>();
			foreach (amc amc in list)
			{
				if (base.a().a(amc) == h.a)
				{
					list2.Add(amc);
				}
			}
			a1q a_ = cyb.b(base.agu());
			a1q a_2 = cyb.a(base.agu());
			amc amc2 = base.a();
			n4.a((amc2 != null) ? amc2.aa() : null, ref a_);
			amc amc3 = base.a();
			n4.a((amc3 != null) ? amc3.aa() : null, ref a_2);
			bool flag;
			if (base.agy().b != null)
			{
				flag = (Enumerable.Sum<csk>(base.agy().b, new Func<csk, int>(da.a.a.a)) > 0);
			}
			else
			{
				flag = false;
			}
			bool a_3 = flag;
			dtb dtb = new dtb();
			dtb.b(false);
			dtb.c(false);
			List<auv> list3 = dtb.ad();
			c5x a_4 = base.b().a8();
			string a_5 = "Electricity";
			int maxValue = int.MaxValue;
			double a_6 = (double)dz6.b(300);
			bool a_7 = true;
			bool a_8 = true;
			float? a_9 = dz6.b();
			list3.Add(new a7j(a_4, a_5, maxValue, a_6, a_7, a_8, null, null, null, a_9, false, null));
			dtb.ad().Add(new a4s(new bfq(Guid.NewGuid().ToString(), "Electroshock"), null, new ar7(base.b().a8()), null));
			eym.a(dtb, base.b().a8(), (double)aju.bf);
			dtb.ad().Add(new akg(base.a(), base.b(), this.a(base.agw(), a_, base.b(), euf.d(cd.TypedDefinition), true, a_3), new b7x(null), false));
			dtb.ad().Add(new a27(base.a(), base.b(), true, true, false, true));
			if (list2.Count > 0)
			{
				dtb.ad().Add(new bm3(dz6.b(150)));
				foreach (amc amc4 in list2)
				{
					List<auv> list4 = dtb.ad();
					c5x a_10 = amc4.a8();
					string a_11 = "Electricity";
					int maxValue2 = int.MaxValue;
					double a_12 = (double)dz6.b(300);
					bool a_13 = true;
					bool a_14 = true;
					a_9 = dz6.b();
					list4.Add(new a7j(a_10, a_11, maxValue2, a_12, a_13, a_14, null, null, null, a_9, false, null));
					dtb.ad().Add(new a4s(new bfq(Guid.NewGuid().ToString(), "Electroshock"), null, new ar7(amc4.a8()), null));
					eym.a(dtb, amc4.a8(), (double)aju.bf);
					dtb.ad().Add(new akg(base.a(), amc4, this.a(base.agw(), a_2, amc4, euf.d(cd.TypedDefinition), false, false), new b7x(null), false));
					dtb.ad().Add(new a27(base.a(), amc4, true, true, false, true));
					dtb.ad().Add(new bm3(dz6.b(50)));
				}
			}
			base.b().a8().Zone.ActionManager.g9(dtb, atp.a);
			dz6.a(dtb);
		}
		return dc4.c;
	}

	// Token: 0x06007211 RID: 29201 RVA: 0x002FF068 File Offset: 0x002FD268
	private cwt a(cwt A_0, a1q A_1, amc A_2, WeaponSubtype? A_3, bool A_4, bool A_5)
	{
		cwt cwt = new cwt();
		cwt.b = true;
		cwt.f.Add(euf.a(A_1, 1.0));
		cwt.v = "электрошок";
		cwt.h = ImpactSpeed.VeryHigh;
		cwt.i = new ap9(base.a().aa());
		cwt.j = new ap9(A_2.aa());
		cwt.w = A_4;
		cwt.l = A_5;
		cwt.ae = A_3;
		cpl.a(A_0, cwt);
		return cwt;
	}

	// Token: 0x020013CB RID: 5067
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06007214 RID: 29204 RVA: 0x002FF10C File Offset: 0x002FD30C
		internal int a(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x04002E89 RID: 11913
		public static readonly da.a a = new da.a();

		// Token: 0x04002E8A RID: 11914
		public static Func<csk, int> b;
	}
}
