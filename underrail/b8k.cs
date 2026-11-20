using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000424 RID: 1060
[fe("gms_raiderLeader")]
public sealed class b8k : b5g
{
	// Token: 0x06001BBE RID: 7102 RVA: 0x00097B58 File Offset: 0x00095D58
	public b8k(bm6 A_0) : base(A_0)
	{
		int a_ = base.g().Count - 2;
		List<c96> list = new List<c96>();
		list.Add(new byh("TalkToHero", new Func<TimeSpan, double, bool>(this.b), new Func<TimeSpan, double, cst>(this.a), new Func<bool, float>(b8k.a.a.a), null)
		{
			e = false
		});
		base.a(a_, list);
	}

	// Token: 0x06001BBF RID: 7103 RVA: 0x00097BD8 File Offset: 0x00095DD8
	[CompilerGenerated]
	private bool b(TimeSpan A_0, double A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (this.Subject.a8().u.b != null && serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (!c5x.h.b.aa().IsInCombat && c5x.h.b.aa().IsInControl && aw1.b(c5x, this.Subject.a8()) <= 5.0 && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("gms_l3_raiderLeaderTalkToHero", new bool?(false)).Value)
			{
				blk blk = new bzv(this.Subject.y6()).c(serviceOrThrow.aqu().v().b().qe());
				return blk != null && blk.b() && blk.f() > global::h.a;
			}
		}
		return false;
	}

	// Token: 0x06001BC0 RID: 7104 RVA: 0x00097D10 File Offset: 0x00095F10
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

	// Token: 0x02000425 RID: 1061
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06001BC3 RID: 7107 RVA: 0x00097DC8 File Offset: 0x00095FC8
		internal float a(bool A_0)
		{
			return 3f;
		}

		// Token: 0x04000F58 RID: 3928
		public static readonly b8k.a a = new b8k.a();

		// Token: 0x04000F59 RID: 3929
		public static Func<bool, float> b;
	}
}
