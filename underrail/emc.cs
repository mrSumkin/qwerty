using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000417 RID: 1047
[fe("Lu_DeliveryInterceptionBandit")]
public sealed class emc : b5g
{
	// Token: 0x06001B8B RID: 7051 RVA: 0x00096720 File Offset: 0x00094920
	public emc(bm6 A_0) : base(A_0)
	{
		int a_ = base.g().Count - 2;
		List<c96> list = new List<c96>();
		list.Add(new byh("TalkToHero", new Func<TimeSpan, double, bool>(this.b), new Func<TimeSpan, double, cst>(this.a), new Func<bool, float>(emc.a.a.a), null)
		{
			e = false
		});
		base.a(a_, list);
	}

	// Token: 0x06001B8C RID: 7052 RVA: 0x000967A0 File Offset: 0x000949A0
	[CompilerGenerated]
	private bool b(TimeSpan A_0, double A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (this.Subject.a8().u.b != null && serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (!c5x.h.b.aa().IsInCombat && c5x.h.b.aa().IsInControl && aw1.b(c5x, this.Subject.a8()) <= 5.0 && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quest_jqsDelivery_talkedToBandits", new bool?(false)).Value)
			{
				blk blk = new bzv(this.Subject.y6()).c(serviceOrThrow.aqu().v().b().qe());
				return blk != null && blk.b() && blk.f() > global::h.a;
			}
		}
		return false;
	}

	// Token: 0x06001B8D RID: 7053 RVA: 0x000968D8 File Offset: 0x00094AD8
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

	// Token: 0x02000418 RID: 1048
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06001B90 RID: 7056 RVA: 0x00096990 File Offset: 0x00094B90
		internal float a(bool A_0)
		{
			return 3f;
		}

		// Token: 0x04000F46 RID: 3910
		public static readonly emc.a a = new emc.a();

		// Token: 0x04000F47 RID: 3911
		public static Func<bool, float> b;
	}
}
