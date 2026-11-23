using System;
using System.Linq;
using System.Runtime.CompilerServices;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001225 RID: 4645
public class b52 : e5m
{
	// Token: 0x06006412 RID: 25618 RVA: 0x002B09F8 File Offset: 0x002AEBF8
	public override string md()
	{
		return "pb";
	}

	// Token: 0x06006413 RID: 25619 RVA: 0x002B0A00 File Offset: 0x002AEC00
	public override string me()
	{
		return "Xpbl_PropaneTank";
	}

	// Token: 0x06006414 RID: 25620 RVA: 0x002B0A08 File Offset: 0x002AEC08
	protected override cd1 mf(efk A_0)
	{
		return euf.a();
	}

	// Token: 0x06006415 RID: 25621 RVA: 0x002B0A10 File Offset: 0x002AEC10
	public override void qr(amc A_0, amc A_1, cwt A_2, cru A_3)
	{
		if (A_0 != null && A_2.b && A_0.a8() != null && A_0.a8().t.b != null)
		{
			double a_ = A_2.e ? 0.5 : 0.25;
			this.a(A_0, a_);
		}
	}

	// Token: 0x06006416 RID: 25622 RVA: 0x002B0A7C File Offset: 0x002AEC7C
	public override void qs(amc A_0, dj7 A_1)
	{
		if (A_1.a() != null)
		{
			int num = Enumerable.Sum<csk>(Enumerable.Where<csk>(A_1.a(), new Func<csk, bool>(b52.a.a.c)), new Func<csk, int>(b52.a.a.a));
			double a_ = Math.Min(0.5, (double)num * 0.01);
			this.a(A_0, a_);
		}
	}

	// Token: 0x06006417 RID: 25623 RVA: 0x002B0B0C File Offset: 0x002AED0C
	public override void qt(amc A_0, dj7 A_1)
	{
		if (A_1.a() != null)
		{
			int num = Enumerable.Sum<csk>(Enumerable.Where<csk>(A_1.a(), new Func<csk, bool>(b52.a.a.d)), new Func<csk, int>(b52.a.a.b));
			double a_ = Math.Min(0.5, (double)num * 0.01);
			this.a(A_0, a_);
		}
	}

	// Token: 0x06006418 RID: 25624 RVA: 0x002B0B9C File Offset: 0x002AED9C
	protected override string adj()
	{
		return "Xpbl_PropaneTank";
	}

	// Token: 0x06006419 RID: 25625 RVA: 0x002B0BA4 File Offset: 0x002AEDA4
	private void a(amc A_0, double A_1)
	{
		if (cuo.a.NextDouble() < A_1)
		{
			A_0.aa().CustomProperties[ddm.i] = "pbl";
			new dtg().q7(A_0, null);
			A_0.a2();
		}
	}

	// Token: 0x02001226 RID: 4646
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x0600641D RID: 25629 RVA: 0x002B0C0C File Offset: 0x002AEE0C
		internal bool c(csk A_0)
		{
			return A_0.DamageType == DamageType.Mechanical;
		}

		// Token: 0x0600641E RID: 25630 RVA: 0x002B0C18 File Offset: 0x002AEE18
		internal int a(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x0600641F RID: 25631 RVA: 0x002B0C24 File Offset: 0x002AEE24
		internal bool d(csk A_0)
		{
			return A_0.DamageType == DamageType.Mechanical;
		}

		// Token: 0x06006420 RID: 25632 RVA: 0x002B0C30 File Offset: 0x002AEE30
		internal int b(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x04002A05 RID: 10757
		public static readonly b52.a a = new b52.a();

		// Token: 0x04002A06 RID: 10758
		public static Func<csk, bool> b;

		// Token: 0x04002A07 RID: 10759
		public static Func<csk, int> c;

		// Token: 0x04002A08 RID: 10760
		public static Func<csk, bool> d;

		// Token: 0x04002A09 RID: 10761
		public static Func<csk, int> e;
	}
}
