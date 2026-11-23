using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020003D7 RID: 983
[fe("jye_guard2")]
public sealed class dpr : b5g
{
	// Token: 0x06001A62 RID: 6754 RVA: 0x0008E534 File Offset: 0x0008C734
	public dpr(bm6 A_0) : base(A_0)
	{
		int a_ = base.g().Count - 2;
		List<c96> list = new List<c96>();
		list.Add(new byh("AttackOnSight", new Func<TimeSpan, double, bool>(this.b), new Func<TimeSpan, double, cst>(this.a), new Func<bool, float>(dpr.a.a.a), null)
		{
			e = true
		});
		base.a(a_, list);
	}

	// Token: 0x06001A63 RID: 6755 RVA: 0x0008E5B4 File Offset: 0x0008C7B4
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
				if (d3k.a(c5x.h.b.aa()))
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x06001A64 RID: 6756 RVA: 0x0008E6A4 File Offset: 0x0008C8A4
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

	// Token: 0x020003D8 RID: 984
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06001A67 RID: 6759 RVA: 0x0008E748 File Offset: 0x0008C948
		internal float a(bool A_0)
		{
			return 3f;
		}

		// Token: 0x04000ECD RID: 3789
		public static readonly dpr.a a = new dpr.a();

		// Token: 0x04000ECE RID: 3790
		public static Func<bool, float> b;
	}
}
