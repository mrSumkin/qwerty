using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

// Token: 0x02000428 RID: 1064
[fe("turret")]
public class c8f : bwv
{
	// Token: 0x06001BCA RID: 7114 RVA: 0x00098090 File Offset: 0x00096290
	public override int or()
	{
		return 1000;
	}

	// Token: 0x06001BCB RID: 7115 RVA: 0x00098098 File Offset: 0x00096298
	public c8f(bm6 A_0) : base(A_0)
	{
		List<c96> list = new List<c96>();
		list.Add(new b64("NotFunctional", new Func<TimeSpan, double, bool>(this.c), new Func<TimeSpan, double, ej1>(c8f.a.a.b), new Func<bool, float>(c8f.a.a.c), null));
		list.Add(new b64("ChangingState", new Func<TimeSpan, double, bool>(this.b), new Func<TimeSpan, double, ej1>(c8f.a.a.a), new Func<bool, float>(c8f.a.a.a), null));
		list.Add(new b64("Overwatch", new Func<TimeSpan, double, bool>(c8f.a.a.c), new Func<TimeSpan, double, ej1>(this.a), new Func<bool, float>(c8f.a.a.b), null));
		base.a(list);
	}

	// Token: 0x06001BCC RID: 7116 RVA: 0x000981DC File Offset: 0x000963DC
	[CompilerGenerated]
	private new bool c(TimeSpan A_0, double A_1)
	{
		return !this.Subject.a8().a();
	}

	// Token: 0x06001BCD RID: 7117 RVA: 0x000981F4 File Offset: 0x000963F4
	[CompilerGenerated]
	private bool b(TimeSpan A_0, double A_1)
	{
		ny b = this.Subject.a8().i.b;
		return b != null && b.a() != null && b.a().Name == "turretStateChange";
	}

	// Token: 0x06001BCE RID: 7118 RVA: 0x00098240 File Offset: 0x00096440
	[CompilerGenerated]
	private ej1 a(TimeSpan A_0, double A_1)
	{
		if (this.Subject.a8().a())
		{
			b2w b2w = Enumerable.FirstOrDefault<b2w>(base.h().aa().StatusEffects.Get<b2w>());
			if (b2w == null || b2w.Power < base.h().aa().Offense.n())
			{
				b2w = new b2w(base.h().aa().Offense.n(), 0);
				base.h().aa().StatusEffects.a(b2w, false, false, false);
			}
			return ej1.b;
		}
		return ej1.c;
	}

	// Token: 0x02000429 RID: 1065
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06001BD1 RID: 7121 RVA: 0x000982F0 File Offset: 0x000964F0
		internal ej1 b(TimeSpan A_0, double A_1)
		{
			return ej1.b;
		}

		// Token: 0x06001BD2 RID: 7122 RVA: 0x000982F4 File Offset: 0x000964F4
		internal float c(bool A_0)
		{
			return 2f;
		}

		// Token: 0x06001BD3 RID: 7123 RVA: 0x000982FC File Offset: 0x000964FC
		internal ej1 a(TimeSpan A_0, double A_1)
		{
			return ej1.b;
		}

		// Token: 0x06001BD4 RID: 7124 RVA: 0x00098300 File Offset: 0x00096500
		internal float a(bool A_0)
		{
			return 3f;
		}

		// Token: 0x06001BD5 RID: 7125 RVA: 0x00098308 File Offset: 0x00096508
		internal bool c(TimeSpan A_0, double A_1)
		{
			return false;
		}

		// Token: 0x06001BD6 RID: 7126 RVA: 0x0009830C File Offset: 0x0009650C
		internal float b(bool A_0)
		{
			return 5.01f;
		}

		// Token: 0x04000F5C RID: 3932
		public static readonly c8f.a a = new c8f.a();

		// Token: 0x04000F5D RID: 3933
		public static Func<TimeSpan, double, ej1> b;

		// Token: 0x04000F5E RID: 3934
		public static Func<bool, float> c;

		// Token: 0x04000F5F RID: 3935
		public static Func<TimeSpan, double, ej1> d;

		// Token: 0x04000F60 RID: 3936
		public static Func<bool, float> e;

		// Token: 0x04000F61 RID: 3937
		public static Func<TimeSpan, double, bool> f;

		// Token: 0x04000F62 RID: 3938
		public static Func<bool, float> g;
	}
}
