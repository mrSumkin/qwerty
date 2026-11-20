using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000420 RID: 1056
[fe("fls_ratking")]
public sealed class wk : b5g
{
	// Token: 0x06001BA6 RID: 7078 RVA: 0x0009742C File Offset: 0x0009562C
	public wk(bm6 A_0) : base(A_0)
	{
		int a_ = base.g().Count - 2;
		List<c96> list = new List<c96>();
		list.Add(new byh("TalkToHero", new Func<TimeSpan, double, bool>(this.b), new Func<TimeSpan, double, cst>(this.a), new Func<bool, float>(wk.a.a.a), null)
		{
			e = false
		});
		base.a(a_, list);
	}

	// Token: 0x06001BA7 RID: 7079 RVA: 0x000974AC File Offset: 0x000956AC
	[CompilerGenerated]
	private bool b(TimeSpan A_0, double A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (this.Subject.a8().u.b != null && serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (!c5x.h.b.aa().IsInCombat && c5x.h.b.aa().IsInControl && aw1.b(c5x, this.Subject.a8()) <= 5.0 && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_flsratking_met", new bool?(false)).Value)
			{
				blk blk = new bzv(this.Subject.y6()).c(serviceOrThrow.aqu().v().b().qe());
				return blk != null && blk.b() && blk.f() > global::h.a;
			}
		}
		return false;
	}

	// Token: 0x06001BA8 RID: 7080 RVA: 0x000975E4 File Offset: 0x000957E4
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

	// Token: 0x02000421 RID: 1057
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06001BAB RID: 7083 RVA: 0x0009769C File Offset: 0x0009589C
		internal float a(bool A_0)
		{
			return 3f;
		}

		// Token: 0x04000F50 RID: 3920
		public static readonly wk.a a = new wk.a();

		// Token: 0x04000F51 RID: 3921
		public static Func<bool, float> b;
	}
}
