using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

// Token: 0x020003FB RID: 1019
[fe("jy_jenny")]
public sealed class c7e : b5g
{
	// Token: 0x06001B13 RID: 6931 RVA: 0x00093470 File Offset: 0x00091670
	public c7e(bm6 A_0) : base(A_0)
	{
		int a_ = base.g().Count - 2;
		List<c96> list = new List<c96>();
		list.Add(new byh("TalkToHero", new Func<TimeSpan, double, bool>(this.b), new Func<TimeSpan, double, cst>(this.a), new Func<bool, float>(c7e.a.a.a), null)
		{
			e = false
		});
		base.a(a_, list);
	}

	// Token: 0x06001B14 RID: 6932 RVA: 0x000934F0 File Offset: 0x000916F0
	[CompilerGenerated]
	private bool b(TimeSpan A_0, double A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (this.Subject.a8().u.b != null && serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			bool value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_jytjenny_met", new bool?(false)).Value;
			bool value2 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_jytjenny_cured", new bool?(false)).Value;
			if (!c5x.h.b.aa().IsInCombat && c5x.h.b.aa().IsInControl && aw1.b(c5x, this.Subject.a8()) <= 2.0 && !value)
			{
				blk blk = new bzv(this.Subject.y6()).c(serviceOrThrow.aqu().v().b().qe());
				return blk != null && blk.b() && blk.f() > global::h.a;
			}
			if (value && !value2 && this.Subject.a8().Area.y8() == "jytd1")
			{
				amc amc = base.h();
				float num = amc.aa().Defense.q().zo() / Math.Max(1f, amc.aa().Defense.q().zm());
				if (amc != null && num < 0.4f)
				{
					if (Enumerable.FirstOrDefault<c2b>(Enumerable.Where<c2b>(amc.aa().StatusEffects.Get<c2b>(), new Func<c2b, bool>(c7e.a.a.a))) == null)
					{
						c2b a_ = new c2b(null, "mortalBurrowerPoison", "Яд могильщика", d0u.b * 30, 5, 5);
						amc.aa().StatusEffects.a(a_, false, false, false);
					}
				}
			}
		}
		return false;
	}

	// Token: 0x06001B15 RID: 6933 RVA: 0x00093750 File Offset: 0x00091950
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

	// Token: 0x020003FC RID: 1020
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06001B18 RID: 6936 RVA: 0x00093808 File Offset: 0x00091A08
		internal bool a(c2b A_0)
		{
			return A_0.Code == "poison:mortalBurrowerPoison";
		}

		// Token: 0x06001B19 RID: 6937 RVA: 0x0009381C File Offset: 0x00091A1C
		internal float a(bool A_0)
		{
			return 3f;
		}

		// Token: 0x04000F18 RID: 3864
		public static readonly c7e.a a = new c7e.a();

		// Token: 0x04000F19 RID: 3865
		public static Func<c2b, bool> b;

		// Token: 0x04000F1A RID: 3866
		public static Func<bool, float> c;
	}
}
