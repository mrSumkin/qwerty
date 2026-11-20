using System;
using System.Linq;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Items;

// Token: 0x0200121E RID: 4638
public abstract class e5m : dip
{
	// Token: 0x060063E7 RID: 25575 RVA: 0x002AFDF0 File Offset: 0x002ADFF0
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
			aud a_2 = A_0.Area;
			Vector3 a_3 = A_0.Location.a();
			HorizontalDirection? a_4 = (A_1 != null) ? new HorizontalDirection?(A_1.VisualDirection) : null;
			string a_5 = this.adj();
			int a_6 = 1;
			double maxValue = double.MaxValue;
			float? a_7 = dz6.b();
			boj.a(a_2, a_3, a_4, a_5, a_6, maxValue, null, null, a_7, null);
			eym.a(a_, (double)aju.b0);
			a_.c().a("BarrelCrash");
			dm5 dm = new dm5();
			dm.d("Propane Tank");
			dm.a(3);
			dm.d(true);
			dm.s().Add(new a1q(DamageType.Heat, 100, 150));
			dm.s().Add(new a1q(DamageType.Mechanical, 75, 125));
			dm.a(new AmmoType?(AmmoType.HighExplosives));
			dm.c(true);
			dm.a(0.1);
			dm.ym(null, Enumerable.FirstOrDefault<b0b>(A_0.c.Values), null);
		}
	}

	// Token: 0x060063E8 RID: 25576 RVA: 0x002AFF78 File Offset: 0x002AE178
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

	// Token: 0x060063E9 RID: 25577
	protected abstract string adj();
}
