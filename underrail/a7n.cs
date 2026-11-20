using System;
using System.Linq;
using System.Runtime.CompilerServices;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001217 RID: 4631
public sealed class a7n : a1d
{
	// Token: 0x060063B0 RID: 25520 RVA: 0x002AF290 File Offset: 0x002AD490
	public override string md()
	{
		return "ac";
	}

	// Token: 0x060063B1 RID: 25521 RVA: 0x002AF298 File Offset: 0x002AD498
	public override string me()
	{
		return "Xpbl_AcidBarrel";
	}

	// Token: 0x060063B2 RID: 25522 RVA: 0x002AF2A0 File Offset: 0x002AD4A0
	protected override cd1 mf(efk A_0)
	{
		return euf.a();
	}

	// Token: 0x060063B3 RID: 25523 RVA: 0x002AF2A8 File Offset: 0x002AD4A8
	public override void qr(amc A_0, amc A_1, cwt A_2, cru A_3)
	{
		if (A_0 != null && A_2.b && A_0.a8() != null && A_0.a8().t.b != null)
		{
			double a_ = A_2.e ? 0.5 : 0.25;
			this.a(A_0, a_);
		}
	}

	// Token: 0x060063B4 RID: 25524 RVA: 0x002AF314 File Offset: 0x002AD514
	public override void qs(amc A_0, dj7 A_1)
	{
		if (A_1.a() != null)
		{
			int num = Enumerable.Sum<csk>(Enumerable.Where<csk>(A_1.a(), new Func<csk, bool>(a7n.a.a.c)), new Func<csk, int>(a7n.a.a.a));
			double a_ = Math.Min(0.5, (double)num * 0.01);
			this.a(A_0, a_);
		}
	}

	// Token: 0x060063B5 RID: 25525 RVA: 0x002AF3A4 File Offset: 0x002AD5A4
	public override void qt(amc A_0, dj7 A_1)
	{
		if (A_1.a() != null)
		{
			int num = Enumerable.Sum<csk>(Enumerable.Where<csk>(A_1.a(), new Func<csk, bool>(a7n.a.a.d)), new Func<csk, int>(a7n.a.a.b));
			double a_ = Math.Min(0.5, (double)num * 0.01);
			this.a(A_0, a_);
		}
	}

	// Token: 0x060063B6 RID: 25526 RVA: 0x002AF434 File Offset: 0x002AD634
	protected override string mj()
	{
		return "Xpbl_AcidBarrel";
	}

	// Token: 0x060063B7 RID: 25527 RVA: 0x002AF43C File Offset: 0x002AD63C
	private void a(amc A_0, double A_1)
	{
		if (cuo.a.NextDouble() < A_1)
		{
			A_0.aa().CustomProperties[ddm.i] = "acl";
			A_0.a2();
		}
	}

	// Token: 0x02001219 RID: 4633
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x060063C0 RID: 25536 RVA: 0x002AF7DC File Offset: 0x002AD9DC
		internal bool c(csk A_0)
		{
			return A_0.DamageType == DamageType.Mechanical;
		}

		// Token: 0x060063C1 RID: 25537 RVA: 0x002AF7E8 File Offset: 0x002AD9E8
		internal int a(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x060063C2 RID: 25538 RVA: 0x002AF7F4 File Offset: 0x002AD9F4
		internal bool d(csk A_0)
		{
			return A_0.DamageType == DamageType.Mechanical;
		}

		// Token: 0x060063C3 RID: 25539 RVA: 0x002AF800 File Offset: 0x002ADA00
		internal int b(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x040029F5 RID: 10741
		public static readonly a7n.a a = new a7n.a();

		// Token: 0x040029F6 RID: 10742
		public static Func<csk, bool> b;

		// Token: 0x040029F7 RID: 10743
		public static Func<csk, int> c;

		// Token: 0x040029F8 RID: 10744
		public static Func<csk, bool> d;

		// Token: 0x040029F9 RID: 10745
		public static Func<csk, int> e;
	}
}
