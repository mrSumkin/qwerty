using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200041D RID: 1053
[fe("mmc_guard")]
public sealed class pf : b5g
{
	// Token: 0x06001B9D RID: 7069 RVA: 0x00097198 File Offset: 0x00095398
	public pf(bm6 A_0) : base(A_0)
	{
		int a_ = base.g().Count - 2;
		List<c96> list = new List<c96>();
		list.Add(new byh("TalkToHero", new Func<TimeSpan, double, bool>(this.b), new Func<TimeSpan, double, cst>(this.a), new Func<bool, float>(pf.a.a.a), null)
		{
			e = false
		});
		base.a(a_, list);
	}

	// Token: 0x06001B9E RID: 7070 RVA: 0x00097218 File Offset: 0x00095418
	[CompilerGenerated]
	private bool b(TimeSpan A_0, double A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (this.Subject.a8().u.b != null && serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (!c5x.h.b.aa().IsInCombat && c5x.h.b.aa().IsInControl && aw1.b(c5x, this.Subject.a8()) <= 6.0 && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_mushroomCoveGuard_met", new bool?(false)).Value)
			{
				blk blk = new bzv(this.Subject.y6()).c(serviceOrThrow.aqu().v().b().qe());
				return blk != null && blk.b() && blk.f() > global::h.a;
			}
		}
		return false;
	}

	// Token: 0x06001B9F RID: 7071 RVA: 0x00097350 File Offset: 0x00095550
	[CompilerGenerated]
	private cst a(TimeSpan A_0, double A_1)
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

	// Token: 0x0200041E RID: 1054
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06001BA2 RID: 7074 RVA: 0x00097408 File Offset: 0x00095608
		internal float a(bool A_0)
		{
			return 3f;
		}

		// Token: 0x04000F4C RID: 3916
		public static readonly pf.a a = new pf.a();

		// Token: 0x04000F4D RID: 3917
		public static Func<bool, float> b;
	}
}
