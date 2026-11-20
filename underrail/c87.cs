using System;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001228 RID: 4648
public class c87 : dip
{
	// Token: 0x0600642B RID: 25643 RVA: 0x002B0EB8 File Offset: 0x002AF0B8
	public override string md()
	{
		return "eb";
	}

	// Token: 0x0600642C RID: 25644 RVA: 0x002B0EC0 File Offset: 0x002AF0C0
	public override string me()
	{
		return "ExplosiveBarrel";
	}

	// Token: 0x0600642D RID: 25645 RVA: 0x002B0ECC File Offset: 0x002AF0CC
	public override void q5(ak1 A_0, c5x A_1)
	{
		if (A_0 != null && A_0.Area != null && A_0.c.Count > 0)
		{
			c5x c5x = Enumerable.FirstOrDefault<b0b>(A_0.c.Values) as c5x;
			if (!aw1.a(A_0, false, null, l9.b))
			{
				eym.a(c5x, (double)aju.bz);
				c5x.c().a("RockSplash");
				boj.d(A_0);
				return;
			}
			aud a_ = A_0.Area;
			Vector3 a_2 = A_0.Location.a();
			HorizontalDirection? a_3 = (A_1 != null) ? new HorizontalDirection?(A_1.VisualDirection) : null;
			string a_4 = "ExplosiveBarrelImpact";
			int a_5 = 1;
			double maxValue = double.MaxValue;
			float? a_6 = dz6.b();
			boj.a(a_, a_2, a_3, a_4, a_5, maxValue, null, null, a_6, null);
			eym.a(c5x, (double)aju.b0);
			c5x.c().a("BarrelCrash");
			dm5 dm = new dm5();
			dm.ym(null, c5x, null);
			dm.d("Explosive Barrel");
			dm.a(0.2);
			dm.s().Add(new a1q(DamageType.Mechanical, 50, 75));
			dm.s().Add(new a1q(DamageType.Heat, 50, 75));
			dm.b(100);
			dm.c("ScorchGround");
			dm.d(true);
			dm.a(3);
			dm.b("HeGrenadeExplode");
			dm.c(true);
			dm.a(new AmmoType?(AmmoType.HighExplosives));
		}
	}

	// Token: 0x0600642E RID: 25646 RVA: 0x002B1060 File Offset: 0x002AF260
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

	// Token: 0x0600642F RID: 25647 RVA: 0x002B10D4 File Offset: 0x002AF2D4
	protected override cd1 mf(efk A_0)
	{
		return euf.a();
	}

	// Token: 0x06006430 RID: 25648 RVA: 0x002B10E0 File Offset: 0x002AF2E0
	public override void qr(amc A_0, amc A_1, cwt A_2, cru A_3)
	{
		if (A_0 != null && A_2.b && A_0.a8() != null && A_0.a8().t.b != null)
		{
			double a_ = A_2.e ? 0.2 : 0.05;
			this.a(A_0, a_);
		}
	}

	// Token: 0x06006431 RID: 25649 RVA: 0x002B114C File Offset: 0x002AF34C
	public override void qs(amc A_0, dj7 A_1)
	{
		if (A_1.a() != null)
		{
			int num = Enumerable.Sum<csk>(Enumerable.Where<csk>(A_1.a(), new Func<csk, bool>(c87.a.a.a)), new Func<csk, int>(c87.a.a.d));
			double a_ = Math.Min(0.25, (double)num * 0.005);
			this.a(A_0, a_);
		}
	}

	// Token: 0x06006432 RID: 25650 RVA: 0x002B11DC File Offset: 0x002AF3DC
	public override void qt(amc A_0, dj7 A_1)
	{
		if (A_1.a() != null)
		{
			int num = Enumerable.Sum<csk>(Enumerable.Where<csk>(A_1.a(), new Func<csk, bool>(c87.a.a.b)), new Func<csk, int>(c87.a.a.c));
			double a_ = Math.Min(0.25, (double)num * 0.005);
			this.a(A_0, a_);
		}
	}

	// Token: 0x06006433 RID: 25651 RVA: 0x002B126C File Offset: 0x002AF46C
	private void a(amc A_0, double A_1)
	{
		if (cuo.a.NextDouble() < A_1)
		{
			A_0.aa().CustomProperties[ddm.i] = null;
			this.q6(A_0);
		}
	}

	// Token: 0x02001229 RID: 4649
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x06006437 RID: 25655 RVA: 0x002B12C4 File Offset: 0x002AF4C4
		internal bool a(csk A_0)
		{
			return A_0.DamageType == DamageType.Mechanical;
		}

		// Token: 0x06006438 RID: 25656 RVA: 0x002B12D0 File Offset: 0x002AF4D0
		internal int d(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x06006439 RID: 25657 RVA: 0x002B12DC File Offset: 0x002AF4DC
		internal bool b(csk A_0)
		{
			return A_0.DamageType == DamageType.Mechanical;
		}

		// Token: 0x0600643A RID: 25658 RVA: 0x002B12E8 File Offset: 0x002AF4E8
		internal int c(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x04002A0A RID: 10762
		public static readonly c87.a a = new c87.a();

		// Token: 0x04002A0B RID: 10763
		public static Func<csk, bool> b;

		// Token: 0x04002A0C RID: 10764
		public static Func<csk, int> c;

		// Token: 0x04002A0D RID: 10765
		public static Func<csk, bool> d;

		// Token: 0x04002A0E RID: 10766
		public static Func<csk, int> e;
	}
}
