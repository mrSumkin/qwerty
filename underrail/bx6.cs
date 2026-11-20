using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000426 RID: 1062
[fe("gms_hostage1")]
public sealed class bx6 : b5g
{
	// Token: 0x06001BC4 RID: 7108 RVA: 0x00097DD0 File Offset: 0x00095FD0
	public bx6(bm6 A_0) : base(A_0)
	{
		int a_ = base.g().Count - 2;
		List<c96> list = new List<c96>();
		list.Add(new byh("TalkToHero", new Func<TimeSpan, double, bool>(this.b), new Func<TimeSpan, double, cst>(this.a), new Func<bool, float>(bx6.a.a.a), null)
		{
			e = false
		});
		base.a(a_, list);
	}

	// Token: 0x06001BC5 RID: 7109 RVA: 0x00097E50 File Offset: 0x00096050
	[CompilerGenerated]
	private bool b(TimeSpan A_0, double A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (this.Subject.a8().u.b != null && serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (!c5x.h.b.aa().IsInCombat && c5x.h.b.aa().IsInControl)
			{
				bool value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("gms_l3_fightIntruders", new bool?(false)).Value;
				bool value2 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("gms_l3_hostage1TalkToHero", new bool?(false)).Value;
				bool value3 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("gms_l3_takeMeToYourLeader", new bool?(false)).Value;
				if (value && !value2 && !value3)
				{
					bzv bzv = new bzv(this.Subject.y6());
					blk blk = bzv.c(serviceOrThrow.aqu().v().b().qe());
					return bzv.c() == 0 && blk != null && blk.b() && blk.f() > global::h.a;
				}
			}
		}
		return false;
	}

	// Token: 0x06001BC6 RID: 7110 RVA: 0x00097FD0 File Offset: 0x000961D0
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

	// Token: 0x02000427 RID: 1063
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06001BC9 RID: 7113 RVA: 0x00098088 File Offset: 0x00096288
		internal float a(bool A_0)
		{
			return 3f;
		}

		// Token: 0x04000F5A RID: 3930
		public static readonly bx6.a a = new bx6.a();

		// Token: 0x04000F5B RID: 3931
		public static Func<bool, float> b;
	}
}
