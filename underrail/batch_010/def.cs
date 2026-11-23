using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000409 RID: 1033
[fe("jy_gamblingHouseRoamingGuard")]
public sealed class def : b5g
{
	// Token: 0x06001B5E RID: 7006 RVA: 0x00095558 File Offset: 0x00093758
	public def(bm6 A_0) : base(A_0)
	{
		int a_ = base.g().Count - 2;
		List<c96> list = new List<c96>();
		list.Add(new b64("Roam", new Func<TimeSpan, double, bool>(def.a.a.a), new Func<TimeSpan, double, ej1>(this.c), new Func<bool, float>(def.a.a.b), null));
		list.Add(new b64("AttackTresspasser", new Func<TimeSpan, double, bool>(this.b), new Func<TimeSpan, double, ej1>(this.a), new Func<bool, float>(def.a.a.a), null));
		base.a(a_, list);
	}

	// Token: 0x06001B5F RID: 7007 RVA: 0x00095630 File Offset: 0x00093830
	[CompilerGenerated]
	private new ej1 c(TimeSpan A_0, double A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			if (serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("powSrc_jy8_main", new bool?(false)).Value)
			{
				this.Subject.y6()[ddq.ay] = new bt4("guardIdle");
			}
			else
			{
				this.Subject.y6()[ddq.ay] = new bt4("powerbox");
			}
			serviceOrThrow.aqu().r()["npc_jy8roamingGuard_nextWaypointCheck"] = A_0 + TimeSpan.FromSeconds(3.0);
			csd csd = this.Subject.a8().Zone.g("powerbox");
			if (csd != null && csd.Location == this.Subject.a8().Location && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("powSrc_jy8_main", new bool?(false)).Value)
			{
				c5x c5x = new ar7(new Guid("eca10791-7b05-4071-8eef-cec5799c6385"), this.Subject.a8().Area).ao() as c5x;
				if (c5x != null)
				{
					axh aspect = c5x.GetAspect<axh>();
					b0e b0e = c5x.s.b as b0e;
					if (b0e != null && b0e.q())
					{
						b0e.a(this.Subject.a8(), null, false, false);
					}
					if (aspect != null && !aspect.i())
					{
						aspect.a(this.Subject.a8());
					}
				}
			}
		}
		return ej1.b;
	}

	// Token: 0x06001B60 RID: 7008 RVA: 0x000957EC File Offset: 0x000939EC
	[CompilerGenerated]
	private bool b(TimeSpan A_0, double A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (this.Subject.a8().u.b != null && serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (c5x.Location.Y >= 18f && c5x.Location.X <= 8f && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("powSrc_jy8_main", new bool?(false)).Value)
			{
				blk blk = new bzv(this.Subject.y6()).c(serviceOrThrow.aqu().v().b().qe());
				return blk != null && blk.b() && blk.f() > global::h.a;
			}
		}
		return false;
	}

	// Token: 0x06001B61 RID: 7009 RVA: 0x000958FC File Offset: 0x00093AFC
	[CompilerGenerated]
	private ej1 a(TimeSpan A_0, double A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (this.Subject.a8().u.b != null && serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null)
		{
			c5x a_ = serviceOrThrow.aqu().v().b() as c5x;
			awq.a(this.Subject.a8(), a_, false, false, true, true, false, false);
		}
		return ej1.b;
	}

	// Token: 0x0200040A RID: 1034
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06001B64 RID: 7012 RVA: 0x000959A0 File Offset: 0x00093BA0
		internal bool a(TimeSpan A_0, double A_1)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null)
			{
				TimeSpan? primitivePropertyValue = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<TimeSpan>("npc_jy8roamingGuard_nextWaypointCheck", null);
				return primitivePropertyValue == null || primitivePropertyValue.Value <= A_0;
			}
			return false;
		}

		// Token: 0x06001B65 RID: 7013 RVA: 0x000959FC File Offset: 0x00093BFC
		internal float b(bool A_0)
		{
			return 3f;
		}

		// Token: 0x06001B66 RID: 7014 RVA: 0x00095A04 File Offset: 0x00093C04
		internal float a(bool A_0)
		{
			return 4f;
		}

		// Token: 0x04000F33 RID: 3891
		public static readonly def.a a = new def.a();

		// Token: 0x04000F34 RID: 3892
		public static Func<TimeSpan, double, bool> b;

		// Token: 0x04000F35 RID: 3893
		public static Func<bool, float> c;

		// Token: 0x04000F36 RID: 3894
		public static Func<bool, float> d;
	}
}
