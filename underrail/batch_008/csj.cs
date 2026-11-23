using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020003F1 RID: 1009
[fe("lu_barricadeBandit")]
public sealed class csj : b5g
{
	// Token: 0x06001AEF RID: 6895 RVA: 0x00092284 File Offset: 0x00090484
	public csj(bm6 A_0) : base(A_0)
	{
		int a_ = base.g().Count - 2;
		List<c96> list = new List<c96>();
		list.Add(new byh("TalkToHero", new Func<TimeSpan, double, bool>(this.c), new Func<TimeSpan, double, cst>(this.b), new Func<bool, float>(csj.a.a.b), null)
		{
			e = false
		});
		list.Add(new byh("TresspessingCheck", new Func<TimeSpan, double, bool>(this.a), new Func<TimeSpan, double, cst>(csj.a.a.a), new Func<bool, float>(csj.a.a.a), null)
		{
			e = true
		});
		base.a(a_, list);
	}

	// Token: 0x06001AF0 RID: 6896 RVA: 0x0009236C File Offset: 0x0009056C
	[CompilerGenerated]
	private new bool c(TimeSpan A_0, double A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (this.Subject.a8().u.b != null && serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (!c5x.h.b.aa().IsInCombat && c5x.h.b.aa().IsInControl && aw1.b(c5x, this.Subject.a8()) <= 8.0 && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_lu_bandit1_met", new bool?(false)).Value)
			{
				blk blk = new bzv(this.Subject.y6()).c(serviceOrThrow.aqu().v().b().qe());
				return blk != null && blk.b() && blk.f() > global::h.a;
			}
		}
		return false;
	}

	// Token: 0x06001AF1 RID: 6897 RVA: 0x000924A4 File Offset: 0x000906A4
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

	// Token: 0x06001AF2 RID: 6898 RVA: 0x00092548 File Offset: 0x00090748
	[CompilerGenerated]
	private bool a(TimeSpan A_0, double A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (this.Subject.a8().u.b != null && serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null)
		{
			bool value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_lu_bandit1_paidToll", new bool?(false)).Value;
			bool value2 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_lu_bandit1_charmed", new bool?(false)).Value;
			bool value3 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_lu_bandit1_intpassed", new bool?(false)).Value;
			if (!value2 && !value3 && !value)
			{
				c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
				if (c5x != null && c5x.Location.X >= 14f && c5x.Location.X <= 19f)
				{
					blk blk = new bzv(this.Subject.y6()).c(serviceOrThrow.aqu().v().b().qe());
					return blk != null && blk.b() && blk.f() > global::h.a;
				}
			}
		}
		return false;
	}

	// Token: 0x020003F2 RID: 1010
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06001AF5 RID: 6901 RVA: 0x000926CC File Offset: 0x000908CC
		internal float b(bool A_0)
		{
			return 3f;
		}

		// Token: 0x06001AF6 RID: 6902 RVA: 0x000926D4 File Offset: 0x000908D4
		internal cst a(TimeSpan A_0, double A_1)
		{
			eaq eaq = new eaq();
			eaq.b(asp.b6);
			eaq.a(asp.a);
			eaq.a(global::h.a);
			eaq.a(true);
			return new a4s(eaq, null, null, null);
		}

		// Token: 0x06001AF7 RID: 6903 RVA: 0x00092714 File Offset: 0x00090914
		internal float a(bool A_0)
		{
			return 4f;
		}

		// Token: 0x04000F0B RID: 3851
		public static readonly csj.a a = new csj.a();

		// Token: 0x04000F0C RID: 3852
		public static Func<bool, float> b;

		// Token: 0x04000F0D RID: 3853
		public static Func<TimeSpan, double, cst> c;

		// Token: 0x04000F0E RID: 3854
		public static Func<bool, float> d;
	}
}
