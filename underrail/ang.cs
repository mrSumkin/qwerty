using System;
using System.Linq;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;
using TimelapseVertigo.Rules.Combat;

// Token: 0x0200121B RID: 4635
public abstract class ang : dip
{
	// Token: 0x060063CC RID: 25548 RVA: 0x002AFA00 File Offset: 0x002ADC00
	public override void q5(ak1 A_0, c5x A_1)
	{
		if (A_0 != null && A_0.Area != null && A_0.c.Count > 0)
		{
			c5x a_ = Enumerable.FirstOrDefault<b0b>(A_0.c.Values) as c5x;
			if (!aw1.a(A_0, false, null, l9.b))
			{
				eym.a(a_, (double)aju.bz);
				a_.c().a("RockSplash");
				boj.d(A_0);
				return;
			}
			eym.a(a_, (double)aju.b0);
			a_.c().a("BarrelCrash");
			a_.c().a("BlackOilBurst");
			aud a_2 = A_0.Area;
			Vector3 a_3 = A_0.Location.a();
			HorizontalDirection? a_4 = (A_1 != null) ? new HorizontalDirection?(A_1.VisualDirection) : null;
			string a_5 = this.qu();
			int a_6 = 1;
			double maxValue = double.MaxValue;
			float? a_7 = dz6.b();
			boj.a(a_2, a_3, a_4, a_5, a_6, maxValue, null, null, a_7, null);
			aud a_8 = A_0.Area;
			Vector3 a_9 = A_0.Location.a();
			HorizontalDirection? a_10 = null;
			string a_11 = "BlackOilBurst";
			int a_12 = 1;
			double maxValue2 = double.MaxValue;
			a_7 = dz6.b();
			boj.a(a_8, a_9, a_10, a_11, a_12, maxValue2, null, null, a_7, null);
			foreach (b0b b0b in Enumerable.ToList<b0b>(A_0.c.Values))
			{
				c5x c5x = (c5x)b0b;
				if (c5x.j == cgy.b && c5x.h.b != null)
				{
					cwt cwt = new cwt();
					cwt.f.Add(euf.a(new a1q(DamageType.Mechanical, 75, 150), 1.0));
					cwt.b = true;
					cwt.q = true;
					cwt.h = ImpactSpeed.Low;
					cwt.v = "oil barrel";
					cwt.l = true;
					c5x.h.b.aa().Defense.a(cwt);
				}
			}
			new e3d(new edx(A_0), null, true, true).ym(null, null, null);
			new e3d(new edx(A_0), null, true, true).ym(null, null, null);
		}
	}

	// Token: 0x060063CD RID: 25549 RVA: 0x002AFC7C File Offset: 0x002ADE7C
	public override void q6(amc A_0)
	{
		if (A_0 != null && A_0.a8() != null && A_0.a8().Area != null && A_0.a8().Zone != null)
		{
			ak1 ak = A_0.a8().Area.a(A_0.a8().aj().a());
			if (ak != null)
			{
				this.q5(ak, A_0.a8());
			}
		}
	}

	// Token: 0x060063CE RID: 25550 RVA: 0x002AFCF0 File Offset: 0x002ADEF0
	protected override cd1 mf(efk A_0)
	{
		return euf.a();
	}

	// Token: 0x060063CF RID: 25551 RVA: 0x002AFCF8 File Offset: 0x002ADEF8
	public override void q7(amc A_0, c5i A_1)
	{
		base.q7(A_0, A_1);
		if (A_0 != null)
		{
			A_0.aa().CustomProperties.RemoveProperty(ddm.k);
		}
	}

	// Token: 0x060063D0 RID: 25552
	protected abstract string qu();
}
