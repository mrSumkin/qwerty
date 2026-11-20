using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000407 RID: 1031
[fe("jy_vilmer")]
public sealed class a5f : b5g
{
	// Token: 0x06001B58 RID: 7000 RVA: 0x000952E0 File Offset: 0x000934E0
	public a5f(bm6 A_0) : base(A_0)
	{
		int a_ = base.g().Count - 2;
		List<c96> list = new List<c96>();
		list.Add(new byh("TalkToHero", new Func<TimeSpan, double, bool>(this.b), new Func<TimeSpan, double, cst>(this.a), new Func<bool, float>(a5f.a.a.a), null)
		{
			e = false
		});
		base.a(a_, list);
	}

	// Token: 0x06001B59 RID: 7001 RVA: 0x00095360 File Offset: 0x00093560
	[CompilerGenerated]
	private bool b(TimeSpan A_0, double A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (this.Subject.a8().u.b != null && serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (!c5x.h.b.aa().IsInCombat && c5x.h.b.aa().IsInControl && aw1.b(c5x, this.Subject.a8()) <= 5.0 && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_jyvilmer_met", new bool?(false)).Value)
			{
				blk blk = new bzv(this.Subject.y6()).c(serviceOrThrow.aqu().v().b().qe());
				return blk != null && blk.b() && blk.f() > global::h.a;
			}
		}
		return false;
	}

	// Token: 0x06001B5A RID: 7002 RVA: 0x00095498 File Offset: 0x00093698
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

	// Token: 0x02000408 RID: 1032
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06001B5D RID: 7005 RVA: 0x00095550 File Offset: 0x00093750
		internal float a(bool A_0)
		{
			return 3f;
		}

		// Token: 0x04000F31 RID: 3889
		public static readonly a5f.a a = new a5f.a();

		// Token: 0x04000F32 RID: 3890
		public static Func<bool, float> b;
	}
}
