using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000411 RID: 1041
[fe("humanSoldierAttackOnSight")]
public sealed class crv : b5g
{
	// Token: 0x06001B79 RID: 7033 RVA: 0x000960C0 File Offset: 0x000942C0
	public crv(bm6 A_0) : base(A_0)
	{
		int a_ = base.g().Count - 2;
		List<c96> list = new List<c96>();
		list.Add(new byh("AttackOnSight", new Func<TimeSpan, double, bool>(this.b), new Func<TimeSpan, double, cst>(this.a), new Func<bool, float>(crv.a.a.a), null)
		{
			e = true
		});
		base.a(a_, list);
	}

	// Token: 0x06001B7A RID: 7034 RVA: 0x00096140 File Offset: 0x00094340
	[CompilerGenerated]
	private bool b(TimeSpan A_0, double A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null)
		{
			serviceOrThrow.aqu().v().b();
			if (!base.h().aa().SpecialStates.c && !base.h().aa().SpecialStates.h)
			{
				blk blk = new bzv(this.Subject.y6()).c(serviceOrThrow.aqu().v().b().qe());
				return blk != null && blk.b() && blk.f() > global::h.a;
			}
		}
		return false;
	}

	// Token: 0x06001B7B RID: 7035 RVA: 0x00096214 File Offset: 0x00094414
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

	// Token: 0x02000412 RID: 1042
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06001B7E RID: 7038 RVA: 0x000962B8 File Offset: 0x000944B8
		internal float a(bool A_0)
		{
			return 3f;
		}

		// Token: 0x04000F40 RID: 3904
		public static readonly crv.a a = new crv.a();

		// Token: 0x04000F41 RID: 3905
		public static Func<bool, float> b;
	}
}
