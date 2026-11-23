using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Ouroboros.Playfield.References;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x020003E1 RID: 993
[fe("rc_jared")]
public sealed class d9g : b5g
{
	// Token: 0x06001A99 RID: 6809 RVA: 0x0008FB5C File Offset: 0x0008DD5C
	public d9g(bm6 A_0) : base(A_0)
	{
		List<c96> list = new List<c96>();
		list.Add(new b64("Start next raid timer", new Func<TimeSpan, double, bool>(this.p), new Func<TimeSpan, double, ej1>(this.o), new Func<bool, float>(d9g.a.a.h), null));
		list.Add(new b64("Start raiding", new Func<TimeSpan, double, bool>(this.n), new Func<TimeSpan, double, ej1>(this.m), new Func<bool, float>(d9g.a.a.f), null));
		list.Add(new b64("Stop raiding because destealthed or caught", new Func<TimeSpan, double, bool>(this.l), new Func<TimeSpan, double, ej1>(this.k), new Func<bool, float>(d9g.a.a.d), null));
		list.Add(new b64("Start rummaging", new Func<TimeSpan, double, bool>(this.j), new Func<TimeSpan, double, ej1>(this.i), new Func<bool, float>(d9g.a.a.a), null));
		list.Add(new b64("Stop rummaging", new Func<TimeSpan, double, bool>(this.h), new Func<TimeSpan, double, ej1>(this.g), new Func<bool, float>(d9g.a.a.c), null));
		list.Add(new b64("Start guarding completed phase", new Func<TimeSpan, double, bool>(this.f), new Func<TimeSpan, double, ej1>(this.e), new Func<bool, float>(d9g.a.a.e), null));
		list.Add(new b64("Try set next phase or end raid", new Func<TimeSpan, double, bool>(this.d), new Func<TimeSpan, double, ej1>(this.c), new Func<bool, float>(d9g.a.a.g), null));
		list.Add(new byh("Toggle Stealth", new Func<TimeSpan, double, bool>(this.b), new Func<TimeSpan, double, cst>(this.a), new Func<bool, float>(d9g.a.a.b), null)
		{
			e = false
		});
		base.a(list);
	}

	// Token: 0x06001A9B RID: 6811 RVA: 0x0008FE30 File Offset: 0x0008E030
	[CompilerGenerated]
	private bool p(TimeSpan A_0, double A_1)
	{
		return base.GetGlobalProperty<bool>(d9g.a, false) && !base.GetGlobalProperty<bool>(d9g.b, false) && this.Subject.y6().GetPropertyValue(d9g.e) == null && !base.GetCortexProperty<bool>(d9g.f, false);
	}

	// Token: 0x06001A9C RID: 6812 RVA: 0x0008FE90 File Offset: 0x0008E090
	[CompilerGenerated]
	private ej1 o(TimeSpan A_0, double A_1)
	{
		this.Subject.y6()[d9g.e] = A_0 + TimeSpan.FromMinutes(3.0);
		return ej1.b;
	}

	// Token: 0x06001A9D RID: 6813 RVA: 0x0008FECC File Offset: 0x0008E0CC
	[CompilerGenerated]
	private bool n(TimeSpan A_0, double A_1)
	{
		if (!base.GetCortexProperty<bool>(d9g.f, false))
		{
			TimeSpan? primitivePropertyValue = this.Subject.y6().GetPrimitivePropertyValue<TimeSpan>(d9g.e, null);
			return primitivePropertyValue != null && primitivePropertyValue.Value < A_0;
		}
		return false;
	}

	// Token: 0x06001A9E RID: 6814 RVA: 0x0008FF28 File Offset: 0x0008E128
	[CompilerGenerated]
	private ej1 m(TimeSpan A_0, double A_1)
	{
		this.Subject.y6()[d9g.f] = true;
		this.Subject.y6()[d9g.d] = 1;
		this.Subject.y6()[d9g.c] = false;
		this.Subject.y6().RemoveProperty(d9g.g);
		this.Subject.y6()[ddq.ay] = new bt4("jared1");
		return ej1.b;
	}

	// Token: 0x06001A9F RID: 6815 RVA: 0x0008FFBC File Offset: 0x0008E1BC
	[CompilerGenerated]
	private bool l(TimeSpan A_0, double A_1)
	{
		return (base.GetCortexProperty<bool>(d9g.f, false) && base.GetCortexProperty<int>(d9g.d, 0) >= 2 && !base.h().aa().SpecialStates.g) || base.GetCortexProperty<bool>(d9g.b, false);
	}

	// Token: 0x06001AA0 RID: 6816 RVA: 0x0009001C File Offset: 0x0008E21C
	[CompilerGenerated]
	private ej1 k(TimeSpan A_0, double A_1)
	{
		this.Subject.y6()[d9g.f] = false;
		this.Subject.y6().RemoveProperty(d9g.e);
		this.Subject.y6()[ddq.ay] = new bt4("jaredBar");
		return ej1.b;
	}

	// Token: 0x06001AA1 RID: 6817 RVA: 0x0009007C File Offset: 0x0008E27C
	[CompilerGenerated]
	private bool j(TimeSpan A_0, double A_1)
	{
		return base.GetCortexProperty<bool>(d9g.f, false) && base.GetCortexProperty<bool>(d9g.c, false) && base.GetCortexProperty<int>(d9g.d, 0) == 5 && base.h().ap == null;
	}

	// Token: 0x06001AA2 RID: 6818 RVA: 0x000900D4 File Offset: 0x0008E2D4
	[CompilerGenerated]
	private ej1 i(TimeSpan A_0, double A_1)
	{
		base.h().ap = new CharacterState?(CharacterState.Operating);
		return ej1.b;
	}

	// Token: 0x06001AA3 RID: 6819 RVA: 0x000900EC File Offset: 0x0008E2EC
	[CompilerGenerated]
	private bool h(TimeSpan A_0, double A_1)
	{
		return (!base.GetCortexProperty<bool>(d9g.f, false) || !base.GetCortexProperty<bool>(d9g.c, false) || base.GetCortexProperty<int>(d9g.d, 0) != 5) && base.h().ap != null;
	}

	// Token: 0x06001AA4 RID: 6820 RVA: 0x00090140 File Offset: 0x0008E340
	[CompilerGenerated]
	private ej1 g(TimeSpan A_0, double A_1)
	{
		base.h().ap = null;
		return ej1.b;
	}

	// Token: 0x06001AA5 RID: 6821 RVA: 0x00090158 File Offset: 0x0008E358
	[CompilerGenerated]
	private bool f(TimeSpan A_0, double A_1)
	{
		return base.GetCortexProperty<bool>(d9g.f, false) && !base.GetCortexProperty<bool>(d9g.c, false) && base.GetCortexProperty<int>(d9g.d, 0) > 0 && this.Subject.y6()[d9g.g] == null && aw1.a(this.Subject.a8(), base.GetCortexProperty<bt4>(ddq.ay, null), false);
	}

	// Token: 0x06001AA6 RID: 6822 RVA: 0x000901D4 File Offset: 0x0008E3D4
	[CompilerGenerated]
	private ej1 e(TimeSpan A_0, double A_1)
	{
		this.Subject.y6()[d9g.g] = A_0 + TimeSpan.FromSeconds(5.0);
		this.Subject.y6()[d9g.c] = true;
		return ej1.b;
	}

	// Token: 0x06001AA7 RID: 6823 RVA: 0x0009022C File Offset: 0x0008E42C
	[CompilerGenerated]
	private bool d(TimeSpan A_0, double A_1)
	{
		return base.GetCortexProperty<bool>(d9g.f, false) && base.GetCortexProperty<bool>(d9g.c, false) && this.Subject.y6()[d9g.g] != null && base.GetCortexProperty<TimeSpan>(d9g.g, default(TimeSpan)) <= A_0;
	}

	// Token: 0x06001AA8 RID: 6824 RVA: 0x00090298 File Offset: 0x0008E498
	[CompilerGenerated]
	private new ej1 c(TimeSpan A_0, double A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null)
		{
			serviceOrThrow.aqu().v().b();
			blk blk = new bzv(this.Subject.y6()).c(serviceOrThrow.aqu().v().b().qe());
			if (blk != null && blk.b())
			{
				this.Subject.y6()[d9g.g] = A_0 + TimeSpan.FromSeconds(5.0);
				return ej1.b;
			}
		}
		this.Subject.y6().RemoveProperty(d9g.g);
		this.Subject.y6()[d9g.c] = false;
		this.Subject.y6().RemoveProperty(d9g.g);
		int cortexProperty = base.GetCortexProperty<int>(d9g.d, 0);
		if (cortexProperty >= 6)
		{
			this.Subject.y6()[d9g.f] = false;
			this.Subject.y6()[ddq.ay] = new bt4("jaredBar");
			this.Subject.y6().RemoveProperty(d9g.e);
		}
		else
		{
			this.Subject.y6()[d9g.d] = cortexProperty + 1;
			this.Subject.y6()[d9g.c] = false;
			this.Subject.y6()[ddq.ay] = new bt4("jared" + (cortexProperty + 1).ToString());
		}
		return ej1.b;
	}

	// Token: 0x06001AA9 RID: 6825 RVA: 0x00090470 File Offset: 0x0008E670
	[CompilerGenerated]
	private bool b(TimeSpan A_0, double A_1)
	{
		amc amc = base.h();
		if (((!amc.aa().SpecialStates.g && base.GetCortexProperty<bool>(d9g.f, false) && base.GetCortexProperty<int>(d9g.d, 0) >= 2) || (amc.aa().SpecialStates.g && !base.GetCortexProperty<bool>(d9g.f, false))) && !amc.aa().IsInCombat && amc.aa().SpecialAbilities.a(typeof(e5b)))
		{
			bl6 bl = ecf.a(dgk.Get<e5b>(), new eru(new EntityAspectReference<amc, amc>(amc)), null) as bl6;
			if (bl != null && bl.yw())
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06001AAA RID: 6826 RVA: 0x00090544 File Offset: 0x0008E744
	[CompilerGenerated]
	private cst a(TimeSpan A_0, double A_1)
	{
		amc amc = base.h();
		bl6 bl = ecf.a(dgk.Get<e5b>(), new eru(new EntityAspectReference<amc, amc>(amc)), null) as bl6;
		if (bl != null && bl.yw())
		{
			return cp.a(bl, amc.a8(), false);
		}
		return null;
	}

	// Token: 0x04000EE5 RID: 3813
	private new static readonly string a = "npc_doc_queststarted";

	// Token: 0x04000EE6 RID: 3814
	private new static readonly string b = "loc_rc1_jaredCaught";

	// Token: 0x04000EE7 RID: 3815
	private new static readonly string c = "CompletedPhase";

	// Token: 0x04000EE8 RID: 3816
	private static readonly string d = "CurrentPhase";

	// Token: 0x04000EE9 RID: 3817
	private static readonly string e = "NextRaidTime";

	// Token: 0x04000EEA RID: 3818
	private static readonly string f = "IsRaiding";

	// Token: 0x04000EEB RID: 3819
	private static readonly string g = "NextPhaseTimer";

	// Token: 0x020003E2 RID: 994
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06001AAD RID: 6829 RVA: 0x000905A8 File Offset: 0x0008E7A8
		internal float h(bool A_0)
		{
			return 100f;
		}

		// Token: 0x06001AAE RID: 6830 RVA: 0x000905B0 File Offset: 0x0008E7B0
		internal float f(bool A_0)
		{
			return 100f;
		}

		// Token: 0x06001AAF RID: 6831 RVA: 0x000905B8 File Offset: 0x0008E7B8
		internal float d(bool A_0)
		{
			return 100f;
		}

		// Token: 0x06001AB0 RID: 6832 RVA: 0x000905C0 File Offset: 0x0008E7C0
		internal float a(bool A_0)
		{
			return 150f;
		}

		// Token: 0x06001AB1 RID: 6833 RVA: 0x000905C8 File Offset: 0x0008E7C8
		internal float c(bool A_0)
		{
			return 150f;
		}

		// Token: 0x06001AB2 RID: 6834 RVA: 0x000905D0 File Offset: 0x0008E7D0
		internal float e(bool A_0)
		{
			return 100f;
		}

		// Token: 0x06001AB3 RID: 6835 RVA: 0x000905D8 File Offset: 0x0008E7D8
		internal float g(bool A_0)
		{
			return 100f;
		}

		// Token: 0x06001AB4 RID: 6836 RVA: 0x000905E0 File Offset: 0x0008E7E0
		internal float b(bool A_0)
		{
			return 101f;
		}

		// Token: 0x04000EEC RID: 3820
		public static readonly d9g.a a = new d9g.a();

		// Token: 0x04000EED RID: 3821
		public static Func<bool, float> b;

		// Token: 0x04000EEE RID: 3822
		public static Func<bool, float> c;

		// Token: 0x04000EEF RID: 3823
		public static Func<bool, float> d;

		// Token: 0x04000EF0 RID: 3824
		public static Func<bool, float> e;

		// Token: 0x04000EF1 RID: 3825
		public static Func<bool, float> f;

		// Token: 0x04000EF2 RID: 3826
		public static Func<bool, float> g;

		// Token: 0x04000EF3 RID: 3827
		public static Func<bool, float> h;

		// Token: 0x04000EF4 RID: 3828
		public static Func<bool, float> i;
	}
}
