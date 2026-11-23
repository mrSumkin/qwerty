using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using TimelapseVertigo.Playfield.Locale;
using TimelapseVertigo.Rules.Characters;

// Token: 0x020003BB RID: 955
[fe("lemurianHandmaiden")]
public sealed class b3c : am2
{
	// Token: 0x06001A00 RID: 6656 RVA: 0x0008BCF8 File Offset: 0x00089EF8
	public b3c(bm6 A_0) : base(A_0)
	{
		c96[] array = new c96[1];
		array[0] = new byh("Retract blade", new Func<TimeSpan, double, bool>(this.b), new Func<TimeSpan, double, cst>(this.a), new Func<bool, float>(b3c.a.a.a), null)
		{
			e = true
		};
		base.a(array);
		e1y e1y = Enumerable.Last<c96>(base.g(), new Func<c96, bool>(b3c.a.a.a)) as e1y;
		if (e1y != null)
		{
			e1y.b = false;
			e7y e7y = Enumerable.First<c96>(e1y.g(), new Func<c96, bool>(b3c.a.a.b)) as e7y;
			if (e7y != null)
			{
				e7y.c = 5;
				e7y.b = 8;
			}
		}
	}

	// Token: 0x06001A01 RID: 6657 RVA: 0x0008BDF0 File Offset: 0x00089FF0
	[CompilerGenerated]
	private bool b(TimeSpan A_0, double A_1)
	{
		amc amc = base.h();
		if (amc.aa().IsInControl && amc.aa().Offense.au() != WeaponKey.Primary)
		{
			amc amc2 = new bzv(this.Subject.y6()).g();
			if (amc2 == null || amc2.a8() == null || amc2.aa().Dead)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06001A02 RID: 6658 RVA: 0x0008BE64 File Offset: 0x0008A064
	[CompilerGenerated]
	private cst a(TimeSpan A_0, double A_1)
	{
		amc amc = base.h();
		if (amc != null && amc.a8().i.b != null)
		{
			awx awx = new awx();
			awx.a(awx.kh() | m7.b);
			List<auv> list = awx.ad();
			a4s a4s = new a4s(new bfq("xpbl_LemurianHandmaidenBladesSheath"), null, null, null);
			a4s.b(new ar7(amc.a8()));
			list.Add(a4s);
			awx.ad().Add(new e4t(amc, CharacterState.Custom4, cux.a, 0, null, 1));
			List<auv> list2 = awx.ad();
			ar ar = new ar();
			ar.a(WeaponKey.Primary);
			a4s a4s2 = new a4s(ar, null, null, null);
			a4s2.b(new ar7(amc.a8()));
			list2.Add(a4s2);
			return awx;
		}
		return null;
	}

	// Token: 0x020003BC RID: 956
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06001A05 RID: 6661 RVA: 0x0008BF40 File Offset: 0x0008A140
		internal float a(bool A_0)
		{
			return 0.99f;
		}

		// Token: 0x06001A06 RID: 6662 RVA: 0x0008BF48 File Offset: 0x0008A148
		internal bool a(c96 A_0)
		{
			return A_0 is e1y;
		}

		// Token: 0x06001A07 RID: 6663 RVA: 0x0008BF54 File Offset: 0x0008A154
		internal bool b(c96 A_0)
		{
			return A_0 is e7y;
		}

		// Token: 0x04000EA6 RID: 3750
		public static readonly b3c.a a = new b3c.a();

		// Token: 0x04000EA7 RID: 3751
		public static Func<bool, float> b;

		// Token: 0x04000EA8 RID: 3752
		public static Func<c96, bool> c;

		// Token: 0x04000EA9 RID: 3753
		public static Func<c96, bool> d;
	}
}
