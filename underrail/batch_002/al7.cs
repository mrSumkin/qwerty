using System;
using System.Linq;
using System.Runtime.CompilerServices;
using TimelapseVertigo.Rules.Combat;

// Token: 0x0200121A RID: 4634
public sealed class al7 : ang
{
	// Token: 0x060063C4 RID: 25540 RVA: 0x002AF80C File Offset: 0x002ADA0C
	public override string md()
	{
		return "bob";
	}

	// Token: 0x060063C5 RID: 25541 RVA: 0x002AF814 File Offset: 0x002ADA14
	public override string me()
	{
		return "BlackOilBarrel";
	}

	// Token: 0x060063C6 RID: 25542 RVA: 0x002AF820 File Offset: 0x002ADA20
	public override void qr(amc A_0, amc A_1, cwt A_2, cru A_3)
	{
		if (A_0 != null && A_2.b && A_0.a8() != null && A_0.a8().t.b != null)
		{
			double a_ = A_2.e ? 0.5 : 0.25;
			this.a(A_0, a_);
		}
	}

	// Token: 0x060063C7 RID: 25543 RVA: 0x002AF88C File Offset: 0x002ADA8C
	public override void qs(amc A_0, dj7 A_1)
	{
		if (A_1.a() != null)
		{
			int num = Enumerable.Sum<csk>(Enumerable.Where<csk>(A_1.a(), new Func<csk, bool>(al7.a.a.d)), new Func<csk, int>(al7.a.a.c));
			double a_ = Math.Min(0.5, (double)num * 0.01);
			this.a(A_0, a_);
		}
	}

	// Token: 0x060063C8 RID: 25544 RVA: 0x002AF91C File Offset: 0x002ADB1C
	public override void qt(amc A_0, dj7 A_1)
	{
		if (A_1.a() != null)
		{
			int num = Enumerable.Sum<csk>(Enumerable.Where<csk>(A_1.a(), new Func<csk, bool>(al7.a.a.b)), new Func<csk, int>(al7.a.a.a));
			double a_ = Math.Min(0.5, (double)num * 0.01);
			this.a(A_0, a_);
		}
	}

	// Token: 0x060063C9 RID: 25545 RVA: 0x002AF9AC File Offset: 0x002ADBAC
	protected override string qu()
	{
		return "BlackOilBarrel";
	}

	// Token: 0x060063CA RID: 25546 RVA: 0x002AF9B4 File Offset: 0x002ADBB4
	private void a(amc A_0, double A_1)
	{
		if (cuo.a.NextDouble() < A_1)
		{
			A_0.aa().CustomProperties[ddm.i] = "bobl";
			A_0.a2();
		}
	}

	// Token: 0x0200121C RID: 4636
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x060063D4 RID: 25556 RVA: 0x002AFD3C File Offset: 0x002ADF3C
		internal bool d(csk A_0)
		{
			return A_0.DamageType == DamageType.Mechanical;
		}

		// Token: 0x060063D5 RID: 25557 RVA: 0x002AFD48 File Offset: 0x002ADF48
		internal int c(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x060063D6 RID: 25558 RVA: 0x002AFD54 File Offset: 0x002ADF54
		internal bool b(csk A_0)
		{
			return A_0.DamageType == DamageType.Mechanical;
		}

		// Token: 0x060063D7 RID: 25559 RVA: 0x002AFD60 File Offset: 0x002ADF60
		internal int a(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x040029FA RID: 10746
		public static readonly al7.a a = new al7.a();

		// Token: 0x040029FB RID: 10747
		public static Func<csk, bool> b;

		// Token: 0x040029FC RID: 10748
		public static Func<csk, int> c;

		// Token: 0x040029FD RID: 10749
		public static Func<csk, bool> d;

		// Token: 0x040029FE RID: 10750
		public static Func<csk, int> e;
	}
}
