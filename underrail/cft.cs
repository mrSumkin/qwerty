using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020003EF RID: 1007
[fe("lu_barricadeBanditOther")]
public sealed class cft : b5g
{
	// Token: 0x06001AE9 RID: 6889 RVA: 0x00092020 File Offset: 0x00090220
	public cft(bm6 A_0) : base(A_0)
	{
		int a_ = base.g().Count - 2;
		List<c96> list = new List<c96>();
		list.Add(new byh("TresspessingCheck", new Func<TimeSpan, double, bool>(this.a), new Func<TimeSpan, double, cst>(cft.a.a.a), new Func<bool, float>(cft.a.a.a), null)
		{
			e = true
		});
		base.a(a_, list);
	}

	// Token: 0x06001AEA RID: 6890 RVA: 0x000920B4 File Offset: 0x000902B4
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

	// Token: 0x020003F0 RID: 1008
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06001AED RID: 6893 RVA: 0x00092238 File Offset: 0x00090438
		internal cst a(TimeSpan A_0, double A_1)
		{
			eaq eaq = new eaq();
			eaq.b(asp.b6);
			eaq.a(asp.a);
			eaq.a(global::h.a);
			eaq.a(true);
			return new a4s(eaq, null, null, null);
		}

		// Token: 0x06001AEE RID: 6894 RVA: 0x00092278 File Offset: 0x00090478
		internal float a(bool A_0)
		{
			return 4f;
		}

		// Token: 0x04000F08 RID: 3848
		public static readonly cft.a a = new cft.a();

		// Token: 0x04000F09 RID: 3849
		public static Func<TimeSpan, double, cst> b;

		// Token: 0x04000F0A RID: 3850
		public static Func<bool, float> c;
	}
}
