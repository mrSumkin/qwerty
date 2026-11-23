using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TimelapseVertigo.Rules.Characters;

// Token: 0x0200043C RID: 1084
[fe("rnd_femmeFatale")]
public sealed class d3v : b5g
{
	// Token: 0x06001C59 RID: 7257 RVA: 0x0009A4D8 File Offset: 0x000986D8
	public d3v(bm6 A_0) : base(A_0)
	{
		int a_ = base.g().Count - 2;
		List<c96> list = new List<c96>();
		list.Add(new byh("AttackOnSight", new Func<TimeSpan, double, bool>(this.b), new Func<TimeSpan, double, cst>(this.a), new Func<bool, float>(d3v.a.a.a), null)
		{
			e = true
		});
		base.a(a_, list);
	}

	// Token: 0x06001C5A RID: 7258 RVA: 0x0009A558 File Offset: 0x00098758
	[CompilerGenerated]
	private bool b(TimeSpan A_0, double A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null && serviceOrThrow.aqu().v().Gender == Gender.Male)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (!base.h().aa().SpecialStates.c && !base.h().aa().SpecialStates.h)
			{
				blk blk = new bzv(this.Subject.y6()).c(c5x.qe());
				return blk != null && blk.b() && blk.f() > global::h.a;
			}
		}
		return false;
	}

	// Token: 0x06001C5B RID: 7259 RVA: 0x0009A634 File Offset: 0x00098834
	[CompilerGenerated]
	private cst a(TimeSpan A_0, double A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			return new a27(base.h(), c5x.h.b, false, false, false, false);
		}
		return null;
	}

	// Token: 0x0200043D RID: 1085
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06001C5E RID: 7262 RVA: 0x0009A6C0 File Offset: 0x000988C0
		internal float a(bool A_0)
		{
			return 3f;
		}

		// Token: 0x04000FBC RID: 4028
		public static readonly d3v.a a = new d3v.a();

		// Token: 0x04000FBD RID: 4029
		public static Func<bool, float> b;
	}
}
