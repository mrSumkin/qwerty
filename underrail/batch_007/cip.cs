using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001379 RID: 4985
[bs6("HFX:shockwave")]
[eiz("SWHEA")]
[Serializable]
public sealed class cip : cpl, ISerializable, enp
{
	// Token: 0x060070EE RID: 28910 RVA: 0x002F6B68 File Offset: 0x002F4D68
	private cip(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060070EF RID: 28911 RVA: 0x002F6B74 File Offset: 0x002F4D74
	public cip()
	{
	}

	// Token: 0x060070F0 RID: 28912 RVA: 0x002F6B80 File Offset: 0x002F4D80
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (base.a() == null || base.a().a8() == null || base.b() == null || base.b().a8() == null || base.b().a8().Zone == null || base.agu() == null || base.b() == null || base.b().aa() == null)
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
		int num = e7w.b(base.agu());
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
			a1q a_ = e7w.a(base.agu());
			dtb dtb = new dtb();
			dtb.b(false);
			dtb.c(false);
			List<auv> list3 = dtb.ad();
			c5x a_2 = base.b().a8();
			string a_3 = "Shockwave_Quake";
			int a_4 = 1;
			double maxValue = double.MaxValue;
			bool a_5 = false;
			bool a_6 = false;
			float? num2 = dz6.b();
			int? num3 = new int?(cuo.a.Next(3));
			list3.Add(new a7j(a_2, a_3, a_4, maxValue, a_5, a_6, null, null, null, num2, false, num3));
			List<auv> list4 = dtb.ad();
			c5x a_7 = base.b().a8();
			string a_8 = "xpbl_SoundGunWaveHit";
			int a_9 = 1;
			double maxValue2 = double.MaxValue;
			bool a_10 = true;
			bool a_11 = true;
			num2 = dz6.b();
			Vector3? a_12 = null;
			float? a_13 = null;
			num3 = null;
			int? a_14 = num3;
			float? a_15 = num2;
			bool a_16 = false;
			num3 = null;
			list4.Add(new a7j(a_7, a_8, a_9, maxValue2, a_10, a_11, a_12, a_13, a_14, a_15, a_16, num3));
			List<auv> list5 = dtb.ad();
			cav cav = new cav();
			cav.a(500);
			list5.Add(new a4s(cav, null, null, null));
			dtb.ad().Add(new a4s(new bfq(Guid.NewGuid().ToString(), "Shockwave"), null, new ar7(base.a().a8()), null));
			eym.a(dtb, base.b().a8(), (double)aju.b1);
			dtb.ad().Add(new akg(base.a(), base.b(), this.a(base.agw(), a_, base.b(), euf.d(cd.TypedDefinition), true, true), new b7x(this), false));
			dtb.ad().Add(new a27(base.a(), base.b(), true, true, false, true));
			if (list2.Count > 0)
			{
				dtb.ad().Add(new bm3(dz6.b(150)));
				foreach (amc amc2 in list2)
				{
					if (dk2.f())
					{
						List<auv> list6 = dtb.ad();
						c5x a_17 = amc2.a8();
						string a_18 = "xpbl_SoundGunWaveHit";
						int a_19 = 1;
						double maxValue3 = double.MaxValue;
						bool a_20 = true;
						bool a_21 = true;
						num2 = dz6.b();
						Vector3? a_22 = null;
						float? a_23 = null;
						num3 = null;
						int? a_24 = num3;
						float? a_25 = num2;
						bool a_26 = false;
						num3 = null;
						list6.Add(new a7j(a_17, a_18, a_19, maxValue3, a_20, a_21, a_22, a_23, a_24, a_25, a_26, num3));
					}
					dtb.ad().Add(new akg(base.a(), amc2, this.a(base.agw(), a_, amc2, euf.d(cd.TypedDefinition), false, false), new b7x(this), false));
					dtb.ad().Add(new a27(base.a(), amc2, true, true, false, true));
					dtb.ad().Add(new bm3(dz6.b(10)));
				}
			}
			base.b().a8().Zone.ActionManager.g9(dtb, atp.a);
			dz6.a(dtb);
		}
		return dc4.c;
	}

	// Token: 0x060070F1 RID: 28913 RVA: 0x002F6FF8 File Offset: 0x002F51F8
	private cwt a(cwt A_0, a1q A_1, amc A_2, WeaponSubtype? A_3, bool A_4, bool A_5)
	{
		cwt cwt = new cwt();
		cwt.x = AmmoType.SonicWave;
		cwt.b = true;
		cwt.f.Add(euf.a(A_1, 1.0));
		cwt.v = "ударная волна";
		cwt.h = ImpactSpeed.VeryHigh;
		cwt.i = new ap9(base.a().aa());
		cwt.j = new ap9(A_2.aa());
		cwt.w = A_4;
		cwt.l = A_5;
		cwt.ae = A_3;
		cpl.a(A_0, cwt);
		return cwt;
	}

	// Token: 0x060070F2 RID: 28914 RVA: 0x002F7090 File Offset: 0x002F5290
	public void af(amc A_0, amc A_1, cwt A_2, cru A_3)
	{
		if (A_3 != null && !A_3.c && A_3.a != null)
		{
			if (Enumerable.Sum<csk>(Enumerable.Where<csk>(A_3.a, new Func<csk, bool>(cip.a.a.a)), new Func<csk, int>(cip.a.a.b)) > 0)
			{
				awq.a(A_0, A_1, 1, false, true);
			}
		}
	}

	// Token: 0x0200137A RID: 4986
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x060070F5 RID: 28917 RVA: 0x002F7138 File Offset: 0x002F5338
		internal bool a(csk A_0)
		{
			return A_0.DamageType == DamageType.Mechanical;
		}

		// Token: 0x060070F6 RID: 28918 RVA: 0x002F7144 File Offset: 0x002F5344
		internal int b(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x04002E2D RID: 11821
		public static readonly cip.a a = new cip.a();

		// Token: 0x04002E2E RID: 11822
		public static Func<csk, bool> b;

		// Token: 0x04002E2F RID: 11823
		public static Func<csk, int> c;
	}
}
