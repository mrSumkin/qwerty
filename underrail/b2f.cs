using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

// Token: 0x020003FD RID: 1021
[fe("jy_cliff")]
public sealed class b2f : b5g
{
	// Token: 0x06001B1A RID: 6938 RVA: 0x00093828 File Offset: 0x00091A28
	public b2f(bm6 A_0) : base(A_0)
	{
		int a_ = base.g().Count - 2;
		List<c96> list = new List<c96>();
		list.Add(new byh("TalkToHero", new Func<TimeSpan, double, bool>(this.b), new Func<TimeSpan, double, cst>(this.a), new Func<bool, float>(b2f.a.a.a), null)
		{
			e = false
		});
		base.a(a_, list);
	}

	// Token: 0x06001B1B RID: 6939 RVA: 0x000938A8 File Offset: 0x00091AA8
	[CompilerGenerated]
	private bool b(TimeSpan A_0, double A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (this.Subject.a8().u.b != null && serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			bool value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_jytcliff_met", new bool?(false)).Value;
			bool value2 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_jytjenny_cured", new bool?(false)).Value;
			if (!c5x.h.b.aa().IsInCombat && c5x.h.b.aa().IsInControl && aw1.b(c5x, this.Subject.a8()) <= 3.0 && !value)
			{
				blk blk = new bzv(this.Subject.y6()).c(serviceOrThrow.aqu().v().b().qe());
				return blk != null && blk.b() && blk.f() > global::h.a;
			}
			if (value)
			{
				amc amc = base.h();
				float num = amc.aa().Defense.q().zo() / Math.Max(1f, amc.aa().Defense.q().zm());
				if (amc != null && num < 0.4f && !value2)
				{
					if (Enumerable.FirstOrDefault<a5e>(Enumerable.Where<a5e>(amc.aa().StatusEffects.Get<a5e>(), new Func<a5e, bool>(b2f.a.a.a))) == null)
					{
						a5e a_ = new a5e(null, d0u.b * 30, 1, "mortalWound", null);
						amc.aa().StatusEffects.a(a_, false, false, false);
					}
				}
			}
		}
		return false;
	}

	// Token: 0x06001B1C RID: 6940 RVA: 0x00093AE0 File Offset: 0x00091CE0
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

	// Token: 0x020003FE RID: 1022
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06001B1F RID: 6943 RVA: 0x00093B98 File Offset: 0x00091D98
		internal bool a(a5e A_0)
		{
			return A_0.Code == "mortalWound";
		}

		// Token: 0x06001B20 RID: 6944 RVA: 0x00093BAC File Offset: 0x00091DAC
		internal float a(bool A_0)
		{
			return 3f;
		}

		// Token: 0x04000F1B RID: 3867
		public static readonly b2f.a a = new b2f.a();

		// Token: 0x04000F1C RID: 3868
		public static Func<a5e, bool> b;

		// Token: 0x04000F1D RID: 3869
		public static Func<bool, float> c;
	}
}
