using System;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001221 RID: 4641
public class anf : dip
{
	// Token: 0x060063F5 RID: 25589 RVA: 0x002B025C File Offset: 0x002AE45C
	public override string md()
	{
		return "nb";
	}

	// Token: 0x060063F6 RID: 25590 RVA: 0x002B0264 File Offset: 0x002AE464
	public override string me()
	{
		return "GreaterExplosiveBarrel";
	}

	// Token: 0x060063F7 RID: 25591 RVA: 0x002B026C File Offset: 0x002AE46C
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
			string a_4 = "GreaterExplosiveBarrelImpact";
			int a_5 = 1;
			double maxValue = double.MaxValue;
			float? a_6 = dz6.b();
			boj.a(a_, a_2, a_3, a_4, a_5, maxValue, null, null, a_6, null);
			eym.a(c5x, (double)aju.b0);
			c5x.c().a("BarrelCrash");
			dm5 dm = new dm5();
			dm.ym(null, c5x, null);
			dm.d("Napalm Barrel");
			dm.a(0.2);
			dm.s().Add(new a1q(DamageType.Mechanical, 70, 100));
			dm.s().Add(new a1q(DamageType.Heat, 80, 120));
			dm.b(100);
			dm.d(true);
			dm.a(3);
			dm.b("HeGrenadeExplode");
			dm.c(true);
			dm.e(true);
			dm.c(1);
			dm.d(4);
			dm.a(1f);
			dm.b(1f);
			dm.a(new AmmoType?(AmmoType.HighExplosives));
		}
	}

	// Token: 0x060063F8 RID: 25592 RVA: 0x002B0420 File Offset: 0x002AE620
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

	// Token: 0x060063F9 RID: 25593 RVA: 0x002B0494 File Offset: 0x002AE694
	protected override cd1 mf(efk A_0)
	{
		return euf.a();
	}

	// Token: 0x060063FA RID: 25594 RVA: 0x002B04A0 File Offset: 0x002AE6A0
	public override void qr(amc A_0, amc A_1, cwt A_2, cru A_3)
	{
		if (A_0 != null && A_2.b && A_0.a8() != null && A_0.a8().t.b != null)
		{
			double a_ = A_2.e ? 1.0 : 0.3;
			this.a(A_0, a_);
		}
	}

	// Token: 0x060063FB RID: 25595 RVA: 0x002B050C File Offset: 0x002AE70C
	public override void qs(amc A_0, dj7 A_1)
	{
		if (A_1.a() != null)
		{
			int num = Enumerable.Sum<csk>(Enumerable.Where<csk>(A_1.a(), new Func<csk, bool>(anf.a.a.a)), new Func<csk, int>(anf.a.a.d));
			double a_ = Math.Min(0.25, (double)num * 0.005);
			this.a(A_0, a_);
		}
	}

	// Token: 0x060063FC RID: 25596 RVA: 0x002B059C File Offset: 0x002AE79C
	public override void qt(amc A_0, dj7 A_1)
	{
		if (A_1.a() != null)
		{
			int num = Enumerable.Sum<csk>(Enumerable.Where<csk>(A_1.a(), new Func<csk, bool>(anf.a.a.b)), new Func<csk, int>(anf.a.a.c));
			double a_ = Math.Min(0.25, (double)num * 0.005);
			this.a(A_0, a_);
		}
	}

	// Token: 0x060063FD RID: 25597 RVA: 0x002B062C File Offset: 0x002AE82C
	private void a(amc A_0, double A_1)
	{
		if (cuo.a.NextDouble() < A_1)
		{
			A_0.aa().CustomProperties[ddm.i] = null;
			this.q6(A_0);
		}
	}

	// Token: 0x02001222 RID: 4642
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x06006401 RID: 25601 RVA: 0x002B0684 File Offset: 0x002AE884
		internal bool a(csk A_0)
		{
			return A_0.DamageType == DamageType.Mechanical;
		}

		// Token: 0x06006402 RID: 25602 RVA: 0x002B0690 File Offset: 0x002AE890
		internal int d(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x06006403 RID: 25603 RVA: 0x002B069C File Offset: 0x002AE89C
		internal bool b(csk A_0)
		{
			return A_0.DamageType == DamageType.Mechanical;
		}

		// Token: 0x06006404 RID: 25604 RVA: 0x002B06A8 File Offset: 0x002AE8A8
		internal int c(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x040029FF RID: 10751
		public static readonly anf.a a = new anf.a();

		// Token: 0x04002A00 RID: 10752
		public static Func<csk, bool> b;

		// Token: 0x04002A01 RID: 10753
		public static Func<csk, int> c;

		// Token: 0x04002A02 RID: 10754
		public static Func<csk, bool> d;

		// Token: 0x04002A03 RID: 10755
		public static Func<csk, int> e;
	}
}
