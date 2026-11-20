using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000415 RID: 1045
[fe("jy_vince")]
public sealed class at1 : b5g
{
	// Token: 0x06001B85 RID: 7045 RVA: 0x000964A8 File Offset: 0x000946A8
	public at1(bm6 A_0) : base(A_0)
	{
		int a_ = base.g().Count - 2;
		List<c96> list = new List<c96>();
		list.Add(new byh("TalkToHero", new Func<TimeSpan, double, bool>(this.b), new Func<TimeSpan, double, cst>(this.a), new Func<bool, float>(at1.a.a.a), null)
		{
			e = false
		});
		base.a(a_, list);
	}

	// Token: 0x06001B86 RID: 7046 RVA: 0x00096528 File Offset: 0x00094728
	[CompilerGenerated]
	private bool b(TimeSpan A_0, double A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (this.Subject.a8().u.b != null && serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (!c5x.h.b.aa().IsInCombat && c5x.h.b.aa().IsInControl && aw1.b(c5x, this.Subject.a8()) <= 5.0 && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_jyvince_met", new bool?(false)).Value)
			{
				blk blk = new bzv(this.Subject.y6()).c(serviceOrThrow.aqu().v().b().qe());
				return blk != null && blk.b() && blk.f() > global::h.a;
			}
		}
		return false;
	}

	// Token: 0x06001B87 RID: 7047 RVA: 0x00096660 File Offset: 0x00094860
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

	// Token: 0x02000416 RID: 1046
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06001B8A RID: 7050 RVA: 0x00096718 File Offset: 0x00094918
		internal float a(bool A_0)
		{
			return 3f;
		}

		// Token: 0x04000F44 RID: 3908
		public static readonly at1.a a = new at1.a();

		// Token: 0x04000F45 RID: 3909
		public static Func<bool, float> b;
	}
}
