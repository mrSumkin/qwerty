using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020003DF RID: 991
[fe("lostVault_Traders_Bodygard")]
public sealed class eda : b5g
{
	// Token: 0x06001A90 RID: 6800 RVA: 0x0008F72C File Offset: 0x0008D92C
	public eda(bm6 A_0) : base(A_0)
	{
		int a_ = base.g().Count - 2;
		List<c96> list = new List<c96>();
		list.Add(new byh("TalkToHero", new Func<TimeSpan, double, bool>(this.c), new Func<TimeSpan, double, cst>(this.b), new Func<bool, float>(eda.a.a.b), null)
		{
			e = false
		});
		list.Add(new byh("TresspessingCheck", new Func<TimeSpan, double, bool>(this.a), new Func<TimeSpan, double, cst>(eda.a.a.a), new Func<bool, float>(eda.a.a.a), null)
		{
			e = true
		});
		base.a(a_, list);
	}

	// Token: 0x06001A91 RID: 6801 RVA: 0x0008F814 File Offset: 0x0008DA14
	[CompilerGenerated]
	private new bool c(TimeSpan A_0, double A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (this.Subject.a8().u.b != null && serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (!c5x.h.b.aa().IsInCombat && c5x.h.b.aa().IsInControl && aw1.b(c5x, this.Subject.a8()) <= 8.0 && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_lux_LostVault_Bodygard_met", new bool?(false)).Value)
			{
				blk blk = new bzv(this.Subject.y6()).c(serviceOrThrow.aqu().v().b().qe());
				return blk != null && blk.b() && blk.f() > global::h.a;
			}
		}
		return false;
	}

	// Token: 0x06001A92 RID: 6802 RVA: 0x0008F94C File Offset: 0x0008DB4C
	[CompilerGenerated]
	private cst b(TimeSpan A_0, double A_1)
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

	// Token: 0x06001A93 RID: 6803 RVA: 0x0008F9F0 File Offset: 0x0008DBF0
	[CompilerGenerated]
	private bool a(TimeSpan A_0, double A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (this.Subject.a8().u.b != null && serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_lux_Lostvault_Bodygard_allowTrading", new bool?(false)).Value)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (c5x != null && c5x.Location.Y <= 27f)
			{
				blk blk = new bzv(this.Subject.y6()).c(serviceOrThrow.aqu().v().b().qe());
				return blk != null && blk.b() && blk.f() > global::h.a;
			}
		}
		return false;
	}

	// Token: 0x020003E0 RID: 992
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06001A96 RID: 6806 RVA: 0x0008FB04 File Offset: 0x0008DD04
		internal float b(bool A_0)
		{
			return 3f;
		}

		// Token: 0x06001A97 RID: 6807 RVA: 0x0008FB10 File Offset: 0x0008DD10
		internal cst a(TimeSpan A_0, double A_1)
		{
			eaq eaq = new eaq();
			eaq.b(asp.cp);
			eaq.a(asp.a);
			eaq.a(global::h.a);
			eaq.a(true);
			return new a4s(eaq, null, null, null);
		}

		// Token: 0x06001A98 RID: 6808 RVA: 0x0008FB50 File Offset: 0x0008DD50
		internal float a(bool A_0)
		{
			return 4f;
		}

		// Token: 0x04000EE1 RID: 3809
		public static readonly eda.a a = new eda.a();

		// Token: 0x04000EE2 RID: 3810
		public static Func<bool, float> b;

		// Token: 0x04000EE3 RID: 3811
		public static Func<TimeSpan, double, cst> c;

		// Token: 0x04000EE4 RID: 3812
		public static Func<bool, float> d;
	}
}
