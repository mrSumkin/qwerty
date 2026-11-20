using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020003F9 RID: 1017
[fe("jye_guard1")]
public sealed class dpt : b5g
{
	// Token: 0x06001B0D RID: 6925 RVA: 0x00093228 File Offset: 0x00091428
	public dpt(bm6 A_0) : base(A_0)
	{
		int a_ = base.g().Count - 2;
		List<c96> list = new List<c96>();
		list.Add(new byh("AttackOnSight", new Func<TimeSpan, double, bool>(this.b), new Func<TimeSpan, double, cst>(this.a), new Func<bool, float>(dpt.a.a.a), null)
		{
			e = true
		});
		base.a(a_, list);
	}

	// Token: 0x06001B0E RID: 6926 RVA: 0x000932A8 File Offset: 0x000914A8
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

	// Token: 0x06001B0F RID: 6927 RVA: 0x000933C0 File Offset: 0x000915C0
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

	// Token: 0x020003FA RID: 1018
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06001B12 RID: 6930 RVA: 0x00093464 File Offset: 0x00091664
		internal float a(bool A_0)
		{
			return 3f;
		}

		// Token: 0x04000F16 RID: 3862
		public static readonly dpt.a a = new dpt.a();

		// Token: 0x04000F17 RID: 3863
		public static Func<bool, float> b;
	}
}
