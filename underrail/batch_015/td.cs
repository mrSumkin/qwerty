using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020003E3 RID: 995
[fe("rc_mindreader")]
public sealed class td : b5g
{
	// Token: 0x06001AB5 RID: 6837 RVA: 0x000905E8 File Offset: 0x0008E7E8
	public td(bm6 A_0) : base(A_0)
	{
		int a_ = base.g().Count - 2;
		List<c96> list = new List<c96>();
		list.Add(new byh("TalkToHero", new Func<TimeSpan, double, bool>(this.b), new Func<TimeSpan, double, cst>(this.a), new Func<bool, float>(td.a.a.a), null)
		{
			e = false
		});
		base.a(a_, list);
	}

	// Token: 0x06001AB6 RID: 6838 RVA: 0x00090668 File Offset: 0x0008E868
	[CompilerGenerated]
	private bool b(TimeSpan A_0, double A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (this.Subject.a8().u.b != null && serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (!c5x.h.b.aa().IsInCombat && c5x.h.b.aa().IsInControl && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_rcmindreader_met", new bool?(false)).Value)
			{
				blk blk = new bzv(this.Subject.y6()).c(serviceOrThrow.aqu().v().b().qe());
				return blk != null && blk.b() && blk.f() > global::h.a;
			}
		}
		return false;
	}

	// Token: 0x06001AB7 RID: 6839 RVA: 0x00090780 File Offset: 0x0008E980
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

	// Token: 0x020003E4 RID: 996
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06001ABA RID: 6842 RVA: 0x00090838 File Offset: 0x0008EA38
		internal float a(bool A_0)
		{
			return 3f;
		}

		// Token: 0x04000EF5 RID: 3829
		public static readonly td.a a = new td.a();

		// Token: 0x04000EF6 RID: 3830
		public static Func<bool, float> b;
	}
}
