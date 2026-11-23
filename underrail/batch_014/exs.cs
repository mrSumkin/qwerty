using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001374 RID: 4980
[eiz("PC11A")]
[bs6("HFX:plasmaCut")]
[Serializable]
public sealed class exs : cpl, ISerializable, enp
{
	// Token: 0x060070DC RID: 28892 RVA: 0x002F637C File Offset: 0x002F457C
	private exs(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060070DD RID: 28893 RVA: 0x002F6388 File Offset: 0x002F4588
	public exs()
	{
	}

	// Token: 0x060070DE RID: 28894 RVA: 0x002F6394 File Offset: 0x002F4594
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
		int num = d58.b(base.agu());
		if (cd.MaxBattery == 0 || (double)num <= cd.Battery)
		{
			cd.Battery -= (double)num;
			a1q[] array = d58.a(base.agu());
			amc amc = base.a();
			n4.a((amc != null) ? amc.aa() : null, ref array[0]);
			amc amc2 = base.a();
			n4.a((amc2 != null) ? amc2.aa() : null, ref array[1]);
			bool flag;
			if (base.agy().b != null)
			{
				flag = (Enumerable.Sum<csk>(base.agy().b, new Func<csk, int>(exs.a.a.b)) > 0);
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
			string a_3 = "PlasmaHit";
			int a_4 = 1;
			double a_5 = 2147483647.0;
			bool a_6 = true;
			bool a_7 = true;
			float? a_8 = dz6.b();
			list.Add(new a7j(a_2, a_3, a_4, a_5, a_6, a_7, null, null, null, a_8, false, null));
			eym.a(dtb, base.b().a8(), (double)aju.bg);
			dtb.ad().Add(new akg(base.a(), base.b(), this.a(base.agw(), array, base.b(), euf.d(cd.TypedDefinition), a_), new b7x(this), false));
			dtb.ad().Add(new a27(base.a(), base.b(), true, true, false, true));
			base.b().a8().Zone.ActionManager.g9(dtb, atp.a);
			dz6.a(dtb);
		}
		return dc4.c;
	}

	// Token: 0x060070DF RID: 28895 RVA: 0x002F6610 File Offset: 0x002F4810
	private cwt a(cwt A_0, a1q[] A_1, amc A_2, WeaponSubtype? A_3, bool A_4)
	{
		cwt cwt = new cwt();
		cwt.b = true;
		cwt.f.Add(euf.a(A_1[0], 1.0));
		cwt.f.Add(euf.a(A_1[1], 1.0));
		cwt.v = "плазменный разрез";
		cwt.h = ImpactSpeed.VeryHigh;
		cwt.i = new ap9(base.a().aa());
		cwt.j = new ap9(A_2.aa());
		cwt.l = A_4;
		cwt.ae = A_3;
		cwt.w = true;
		cpl.a(A_0, cwt);
		return cwt;
	}

	// Token: 0x060070E0 RID: 28896 RVA: 0x002F66C4 File Offset: 0x002F48C4
	public void af(amc A_0, amc A_1, cwt A_2, cru A_3)
	{
		if (A_1 != null && A_1.a8() != null && A_3 != null && A_3.a != null)
		{
			if (Enumerable.Sum<csk>(A_3.a, new Func<csk, int>(exs.a.a.a)) > 0)
			{
				A_1.a8().c().a("PlasmaHit");
				return;
			}
		}
		A_1.a8().c().a("PlasmaResist");
	}

	// Token: 0x02001375 RID: 4981
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x060070E3 RID: 28899 RVA: 0x002F676C File Offset: 0x002F496C
		internal int b(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x060070E4 RID: 28900 RVA: 0x002F6778 File Offset: 0x002F4978
		internal int a(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x04002E28 RID: 11816
		public static readonly exs.a a = new exs.a();

		// Token: 0x04002E29 RID: 11817
		public static Func<csk, int> b;

		// Token: 0x04002E2A RID: 11818
		public static Func<csk, int> c;
	}
}
