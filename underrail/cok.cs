using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020003F7 RID: 1015
[fe("jye_mainGuard")]
public sealed class cok : b5g
{
	// Token: 0x06001B04 RID: 6916 RVA: 0x00092DAC File Offset: 0x00090FAC
	public cok(bm6 A_0) : base(A_0)
	{
		int a_ = base.g().Count - 2;
		List<c96> list = new List<c96>();
		list.Add(new byh("TalkToHero", new Func<TimeSpan, double, bool>(this.d), new Func<TimeSpan, double, cst>(this.c), new Func<bool, float>(cok.a.a.b), null)
		{
			e = false
		});
		list.Add(new byh("AttackOnSight", new Func<TimeSpan, double, bool>(this.b), new Func<TimeSpan, double, cst>(this.a), new Func<bool, float>(cok.a.a.a), null)
		{
			e = true
		});
		base.a(a_, list);
	}

	// Token: 0x06001B05 RID: 6917 RVA: 0x00092E7C File Offset: 0x0009107C
	[CompilerGenerated]
	private bool d(TimeSpan A_0, double A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (this.Subject.a8().u.b != null && serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (!c5x.h.b.aa().IsInCombat && c5x.h.b.aa().IsInControl && aw1.b(c5x, this.Subject.a8()) <= 4.0 && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_jyemainguard_met", new bool?(false)).Value)
			{
				blk blk = new bzv(this.Subject.y6()).c(serviceOrThrow.aqu().v().b().qe());
				return blk != null && blk.b() && blk.f() > global::h.a;
			}
		}
		return false;
	}

	// Token: 0x06001B06 RID: 6918 RVA: 0x00092FB4 File Offset: 0x000911B4
	[CompilerGenerated]
	private new cst c(TimeSpan A_0, double A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (this.Subject.a8().u.b != null && serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null)
		{
			j7 aspect = (serviceOrThrow.aqu().v().b() as c5x).GetAspect<j7>();
			j7 aspect2 = this.Subject.a8().GetAspect<j7>();
			if (aspect2 != null && aspect != null)
			{
				return aspect2.a(aspect, true, null, false);
			}
		}
		return null;
	}

	// Token: 0x06001B07 RID: 6919 RVA: 0x00093058 File Offset: 0x00091258
	[CompilerGenerated]
	private bool b(TimeSpan A_0, double A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		bool value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("lo_jye_allowAccess", new bool?(false)).Value;
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			blk blk = new bzv(this.Subject.y6()).c(serviceOrThrow.aqu().v().b().qe());
			if (blk != null && blk.b() && blk.f() != global::h.a)
			{
				if (!value)
				{
					return true;
				}
				if ((c5x.Location.X <= 20f || c5x.Location.Y <= 12f) && d3k.a(c5x.h.b.aa()))
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x06001B08 RID: 6920 RVA: 0x00093170 File Offset: 0x00091370
	[CompilerGenerated]
	private cst a(TimeSpan A_0, double A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (this.Subject.a8().u.b != null && serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			return new a27(base.h(), c5x.h.b, false, false, false, true);
		}
		return null;
	}

	// Token: 0x020003F8 RID: 1016
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06001B0B RID: 6923 RVA: 0x00093214 File Offset: 0x00091414
		internal float b(bool A_0)
		{
			return 2.5f;
		}

		// Token: 0x06001B0C RID: 6924 RVA: 0x0009321C File Offset: 0x0009141C
		internal float a(bool A_0)
		{
			return 3f;
		}

		// Token: 0x04000F13 RID: 3859
		public static readonly cok.a a = new cok.a();

		// Token: 0x04000F14 RID: 3860
		public static Func<bool, float> b;

		// Token: 0x04000F15 RID: 3861
		public static Func<bool, float> c;
	}
}
