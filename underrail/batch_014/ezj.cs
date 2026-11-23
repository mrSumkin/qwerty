using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Ouroboros.Playfield.References;

// Token: 0x0200037F RID: 895
[fe("camera")]
public sealed class ezj : ua
{
	// Token: 0x060018C5 RID: 6341 RVA: 0x00080520 File Offset: 0x0007E720
	public ezj(bm6 A_0) : base("CameraBehavior", A_0)
	{
		List<c96> list = new List<c96>();
		string a_ = "Scan";
		Func<bool> a_2 = new Func<bool>(this.a);
		Func<bool, float> a_3 = new Func<bool, float>(ezj.a.a.e);
		List<c96> list2 = new List<c96>();
		list2.Add(new b64("TransitionFromTurnBased", new Func<TimeSpan, double, bool>(this.o), new Func<TimeSpan, double, ej1>(this.n), new Func<bool, float>(ezj.a.a.b), null));
		list2.Add(new b64("Rotate", new Func<TimeSpan, double, bool>(this.m), new Func<TimeSpan, double, ej1>(this.l), new Func<bool, float>(ezj.a.a.d), null));
		list2.Add(new b64("ReportFocus", new Func<TimeSpan, double, bool>(this.k), new Func<TimeSpan, double, ej1>(this.j), new Func<bool, float>(ezj.a.a.g), null));
		list2.Add(new b64("FollowFocus", new Func<TimeSpan, double, bool>(this.i), new Func<TimeSpan, double, ej1>(this.h), new Func<bool, float>(ezj.a.a.c), null));
		list2.Add(new b64("Unfocus", new Func<TimeSpan, double, bool>(this.g), new Func<TimeSpan, double, ej1>(this.f), new Func<bool, float>(ezj.a.a.f), null));
		list2.Add(new b64("ProcessScanned", new Func<TimeSpan, double, bool>(this.e), new Func<TimeSpan, double, ej1>(this.d), new Func<bool, float>(ezj.a.a.h), null));
		list2.Add(new b64("Idling", new Func<TimeSpan, double, bool>(ezj.a.a.a), new Func<TimeSpan, double, ej1>(this.c), new Func<bool, float>(ezj.a.a.a), null));
		list.Add(new cm7(a_, a_2, a_3, list2));
		list.Add(new b64("NotFunctional", new Func<TimeSpan, double, bool>(this.b), new Func<TimeSpan, double, ej1>(this.a), new Func<bool, float>(ezj.a.a.i), null));
		base.a(list);
	}

	// Token: 0x060018C6 RID: 6342 RVA: 0x000807F8 File Offset: 0x0007E9F8
	private void a(ref double A_0)
	{
		if (this.Subject != null && this.Subject.a8() != null && this.Subject.a8().h.b != null)
		{
			co5 co = Enumerable.FirstOrDefault<co5>(this.Subject.a8().h.b.aa().StatusEffects.Get<co5>());
			if (co != null)
			{
				A_0 *= 1.0 + co.b;
			}
		}
	}

	// Token: 0x060018C7 RID: 6343 RVA: 0x00080880 File Offset: 0x0007EA80
	private TimeSpan b()
	{
		double value = 2.0;
		this.a(ref value);
		return TimeSpan.FromSeconds(value);
	}

	// Token: 0x060018C8 RID: 6344 RVA: 0x000808A8 File Offset: 0x0007EAA8
	public TimeSpan d()
	{
		return TimeSpan.FromSeconds(10.0);
	}

	// Token: 0x060018C9 RID: 6345 RVA: 0x000808BC File Offset: 0x0007EABC
	public new TimeSpan c()
	{
		double value = 2.5;
		this.a(ref value);
		return TimeSpan.FromSeconds(value);
	}

	// Token: 0x060018CA RID: 6346 RVA: 0x000808E4 File Offset: 0x0007EAE4
	public TimeSpan e()
	{
		return TimeSpan.FromSeconds(0.5);
	}

	// Token: 0x060018CB RID: 6347 RVA: 0x000808F8 File Offset: 0x0007EAF8
	public override void lv(b0b A_0)
	{
		if (e5v.a(this.Subject, A_0 as c5x) && this.Subject.b(A_0.GetAspect<amc>(), true))
		{
			awq.a(this.Subject.a8(), A_0 as c5x, false, false, false, false, false, true);
			e5v.b(this.Subject);
		}
	}

	// Token: 0x060018CC RID: 6348 RVA: 0x0008095C File Offset: 0x0007EB5C
	[CompilerGenerated]
	private bool a()
	{
		dt5 aspect = this.Subject.a8().GetAspect<dt5>();
		return aspect == null || aspect.e() == null || aspect.e().Value;
	}

	// Token: 0x060018CD RID: 6349 RVA: 0x000809A4 File Offset: 0x0007EBA4
	[CompilerGenerated]
	private bool o(TimeSpan A_0, double A_1)
	{
		return this.Subject.y6().GetPrimitivePropertyValue<emu>(ddq.i, null) != null;
	}

	// Token: 0x060018CE RID: 6350 RVA: 0x000809D8 File Offset: 0x0007EBD8
	[CompilerGenerated]
	private ej1 n(TimeSpan A_0, double A_1)
	{
		emu? primitivePropertyValue = this.Subject.y6().GetPrimitivePropertyValue<emu>(ddq.i, null);
		if (primitivePropertyValue != null)
		{
			switch (primitivePropertyValue.Value)
			{
			case emu.a:
				this.Subject.y6()[ddq.b] = A_0 + TimeSpan.FromSeconds(2.0);
				this.Subject.y6()[ddq.g] = null;
				this.Subject.y6()[ddq.h] = null;
				break;
			case emu.b:
				this.Subject.y6()[ddq.g] = A_0 + this.d();
				this.Subject.y6()[ddq.h] = A_0 + this.c();
				break;
			case emu.c:
				this.Subject.y6()[ddq.g] = A_0 + this.d();
				this.Subject.y6()[ddq.h] = A_0 - TimeSpan.FromSeconds(1.0);
				break;
			}
			this.Subject.y6().RemoveProperty(ddq.i);
		}
		return ej1.b;
	}

	// Token: 0x060018CF RID: 6351 RVA: 0x00080B4C File Offset: 0x0007ED4C
	[CompilerGenerated]
	private bool m(TimeSpan A_0, double A_1)
	{
		TimeSpan? primitivePropertyValue = this.Subject.y6().GetPrimitivePropertyValue<TimeSpan>(ddq.b, null);
		return primitivePropertyValue == null || primitivePropertyValue.Value < A_0;
	}

	// Token: 0x060018D0 RID: 6352 RVA: 0x00080B94 File Offset: 0x0007ED94
	[CompilerGenerated]
	private ej1 l(TimeSpan A_0, double A_1)
	{
		e5v.c(this.Subject);
		this.Subject.y6()[ddq.b] = A_0 + this.b();
		return ej1.b;
	}

	// Token: 0x060018D1 RID: 6353 RVA: 0x00080BD4 File Offset: 0x0007EDD4
	[CompilerGenerated]
	private bool k(TimeSpan A_0, double A_1)
	{
		TimeSpan? primitivePropertyValue = this.Subject.y6().GetPrimitivePropertyValue<TimeSpan>(ddq.h, null);
		return primitivePropertyValue != null && primitivePropertyValue.Value <= A_0 && e5v.h(this.Subject);
	}

	// Token: 0x060018D2 RID: 6354 RVA: 0x00080C2C File Offset: 0x0007EE2C
	[CompilerGenerated]
	private ej1 j(TimeSpan A_0, double A_1)
	{
		if (e5v.g(this.Subject))
		{
			this.Subject.y6()[ddq.h] = A_0 + this.e();
			return ej1.b;
		}
		return ej1.c;
	}

	// Token: 0x060018D3 RID: 6355 RVA: 0x00080C74 File Offset: 0x0007EE74
	[CompilerGenerated]
	private bool i(TimeSpan A_0, double A_1)
	{
		EntityAspectReference<amc, amc> classPropertyValue = this.Subject.y6().GetClassPropertyValue<EntityAspectReference<amc, amc>>(ddq.f);
		return classPropertyValue != null && classPropertyValue.ao() != null;
	}

	// Token: 0x060018D4 RID: 6356 RVA: 0x00080CA8 File Offset: 0x0007EEA8
	[CompilerGenerated]
	private ej1 h(TimeSpan A_0, double A_1)
	{
		bool? flag = e5v.d(this.Subject);
		if (flag.GetValueOrDefault())
		{
			this.Subject.y6()[ddq.g] = A_0 + this.d();
		}
		else
		{
			bool? flag2 = flag;
			bool flag3 = false;
			if (flag2.GetValueOrDefault() == flag3 & flag2 != null)
			{
				this.Subject.y6().GetPrimitivePropertyValue<TimeSpan>(ddq.h, null);
			}
		}
		return ej1.b;
	}

	// Token: 0x060018D5 RID: 6357 RVA: 0x00080D34 File Offset: 0x0007EF34
	[CompilerGenerated]
	private bool g(TimeSpan A_0, double A_1)
	{
		bool classPropertyValue = this.Subject.y6().GetClassPropertyValue<EntityAspectReference<amc, amc>>(ddq.f) != null;
		TimeSpan? primitivePropertyValue = this.Subject.y6().GetPrimitivePropertyValue<TimeSpan>(ddq.g, null);
		return classPropertyValue && (primitivePropertyValue == null || primitivePropertyValue.Value < A_0);
	}

	// Token: 0x060018D6 RID: 6358 RVA: 0x00080D98 File Offset: 0x0007EF98
	[CompilerGenerated]
	private ej1 f(TimeSpan A_0, double A_1)
	{
		e5v.a(this.Subject);
		this.Subject.y6().RemoveProperty(ddq.g);
		this.Subject.y6()[ddq.b] = A_0 + TimeSpan.FromSeconds(2.0);
		e5v.d(this.Subject.a8());
		return ej1.b;
	}

	// Token: 0x060018D7 RID: 6359 RVA: 0x00080E08 File Offset: 0x0007F008
	[CompilerGenerated]
	private bool e(TimeSpan A_0, double A_1)
	{
		TimeSpan? primitivePropertyValue = this.Subject.y6().GetPrimitivePropertyValue<TimeSpan>(ddq.e, null);
		return primitivePropertyValue == null || primitivePropertyValue.Value < A_0;
	}

	// Token: 0x060018D8 RID: 6360 RVA: 0x00080E50 File Offset: 0x0007F050
	[CompilerGenerated]
	private ej1 d(TimeSpan A_0, double A_1)
	{
		if (e5v.b(this.Subject))
		{
			this.Subject.y6()[ddq.g] = A_0 + this.d();
			this.Subject.y6()[ddq.h] = A_0 + this.c();
		}
		this.Subject.y6()[ddq.e] = A_0 + TimeSpan.FromMilliseconds(100.0);
		return ej1.b;
	}

	// Token: 0x060018D9 RID: 6361 RVA: 0x00080EE8 File Offset: 0x0007F0E8
	[CompilerGenerated]
	private new ej1 c(TimeSpan A_0, double A_1)
	{
		e5v.d(this.Subject.a8());
		return ej1.b;
	}

	// Token: 0x060018DA RID: 6362 RVA: 0x00080EFC File Offset: 0x0007F0FC
	[CompilerGenerated]
	private bool b(TimeSpan A_0, double A_1)
	{
		return !this.Subject.a8().a();
	}

	// Token: 0x060018DB RID: 6363 RVA: 0x00080F14 File Offset: 0x0007F114
	[CompilerGenerated]
	private ej1 a(TimeSpan A_0, double A_1)
	{
		this.Subject.y6().RemoveProperty(ddq.f);
		this.Subject.y6().RemoveProperty(ddq.g);
		this.Subject.y6().RemoveProperty(ddq.h);
		return ej1.b;
	}

	// Token: 0x02000380 RID: 896
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x060018DE RID: 6366 RVA: 0x00080F78 File Offset: 0x0007F178
		internal float e(bool A_0)
		{
			return 1f;
		}

		// Token: 0x060018DF RID: 6367 RVA: 0x00080F80 File Offset: 0x0007F180
		internal float b(bool A_0)
		{
			return 2f;
		}

		// Token: 0x060018E0 RID: 6368 RVA: 0x00080F88 File Offset: 0x0007F188
		internal float d(bool A_0)
		{
			return 1f;
		}

		// Token: 0x060018E1 RID: 6369 RVA: 0x00080F90 File Offset: 0x0007F190
		internal float g(bool A_0)
		{
			return 1.15f;
		}

		// Token: 0x060018E2 RID: 6370 RVA: 0x00080F98 File Offset: 0x0007F198
		internal float c(bool A_0)
		{
			return 1.1f;
		}

		// Token: 0x060018E3 RID: 6371 RVA: 0x00080FA0 File Offset: 0x0007F1A0
		internal float f(bool A_0)
		{
			return 1.2f;
		}

		// Token: 0x060018E4 RID: 6372 RVA: 0x00080FA8 File Offset: 0x0007F1A8
		internal float h(bool A_0)
		{
			return 0.8f;
		}

		// Token: 0x060018E5 RID: 6373 RVA: 0x00080FB0 File Offset: 0x0007F1B0
		internal bool a(TimeSpan A_0, double A_1)
		{
			return true;
		}

		// Token: 0x060018E6 RID: 6374 RVA: 0x00080FB4 File Offset: 0x0007F1B4
		internal float a(bool A_0)
		{
			return 0.75f;
		}

		// Token: 0x060018E7 RID: 6375 RVA: 0x00080FBC File Offset: 0x0007F1BC
		internal float i(bool A_0)
		{
			return 2f;
		}

		// Token: 0x04000E5F RID: 3679
		public static readonly ezj.a a = new ezj.a();

		// Token: 0x04000E60 RID: 3680
		public static Func<bool, float> b;

		// Token: 0x04000E61 RID: 3681
		public static Func<bool, float> c;

		// Token: 0x04000E62 RID: 3682
		public static Func<bool, float> d;

		// Token: 0x04000E63 RID: 3683
		public static Func<bool, float> e;

		// Token: 0x04000E64 RID: 3684
		public static Func<bool, float> f;

		// Token: 0x04000E65 RID: 3685
		public static Func<bool, float> g;

		// Token: 0x04000E66 RID: 3686
		public static Func<bool, float> h;

		// Token: 0x04000E67 RID: 3687
		public static Func<TimeSpan, double, bool> i;

		// Token: 0x04000E68 RID: 3688
		public static Func<bool, float> j;

		// Token: 0x04000E69 RID: 3689
		public static Func<bool, float> k;
	}
}
