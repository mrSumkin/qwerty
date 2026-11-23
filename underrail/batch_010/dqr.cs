using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020003FF RID: 1023
[fe("jy_wyatt")]
public sealed class dqr : b5g
{
	// Token: 0x06001B21 RID: 6945 RVA: 0x00093BB8 File Offset: 0x00091DB8
	public dqr(bm6 A_0) : base(A_0)
	{
		int a_ = base.g().Count - 2;
		List<c96> list = new List<c96>();
		list.Add(new byh("TalkToHero", new Func<TimeSpan, double, bool>(this.b), new Func<TimeSpan, double, cst>(this.a), new Func<bool, float>(dqr.a.a.a), null)
		{
			e = false
		});
		base.a(a_, list);
	}

	// Token: 0x06001B22 RID: 6946 RVA: 0x00093C38 File Offset: 0x00091E38
	[CompilerGenerated]
	private bool b(TimeSpan A_0, double A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (this.Subject.a8().u.b != null && serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (!c5x.h.b.aa().IsInCombat && c5x.h.b.aa().IsInControl && aw1.b(c5x, this.Subject.a8()) <= 5.0 && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_jywyatt_met", new bool?(false)).Value)
			{
				blk blk = new bzv(this.Subject.y6()).c(serviceOrThrow.aqu().v().b().qe());
				return blk != null && blk.b() && blk.f() > global::h.a;
			}
		}
		return false;
	}

	// Token: 0x06001B23 RID: 6947 RVA: 0x00093D70 File Offset: 0x00091F70
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

	// Token: 0x02000400 RID: 1024
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06001B26 RID: 6950 RVA: 0x00093E28 File Offset: 0x00092028
		internal float a(bool A_0)
		{
			return 3f;
		}

		// Token: 0x04000F1E RID: 3870
		public static readonly dqr.a a = new dqr.a();

		// Token: 0x04000F1F RID: 3871
		public static Func<bool, float> b;
	}
}
