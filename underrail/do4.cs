using System;
using System.Linq;
using System.Runtime.CompilerServices;
using TimelapseVertigo.AI.Model.TurnBased;
using TimelapseVertigo.Playfield.Locale;
using TimelapseVertigo.Rules.Characters;

// Token: 0x0200031C RID: 796
[apc("psiBeetle")]
public sealed class do4 : or
{
	// Token: 0x060016B6 RID: 5814 RVA: 0x0007069C File Offset: 0x0006E89C
	public override string jw()
	{
		return "PsiBeetleChitter";
	}

	// Token: 0x060016B7 RID: 5815 RVA: 0x000706A4 File Offset: 0x0006E8A4
	public do4()
	{
		this.m = new ej0();
		this.a = new fh(new arr[0]);
		this.b = new ej0();
		this.c = new ej0();
		this.d = new ge();
		this.j = new fh(new arr[0]);
		this.k = new fh(new arr[0]);
		this.e = new TryInvokePsiAbilityNode<dzs>();
		this.f = new TryInvokePsiAbilityNode<h7>();
		this.g = new TryInvokePsiAbilityNode<dxh>();
		this.h = new TryInvokePsiAbilityNode<eq6>();
		this.i = new TryInvokePsiAbilityNode<c67>();
		this.l = new ej0();
		this.n = new ej0();
		this.i.a = new Func<e1k, object>(do4.a.a.a);
		this.m.a = new Action<ej0>(do4.a.a.a);
		this.m.a = this.c.a;
		this.c.a = this.m;
		fh fh = this.a;
		arr[] array = new arr[2];
		array[0] = new arr(this.b, new Func<e1k, bool>(do4.a.a.b));
		array[1] = new arr(this.c, null);
		fh.a(array);
		this.b.a = new Action<ej0>(do4.a.a.c);
		this.b.a = this.d;
		this.c.a = new Action<ej0>(do4.a.a.b);
		this.c.a = this.d;
		this.d.a = this.j;
		fh fh2 = this.j;
		arr[] array2 = new arr[4];
		array2[0] = new arr(this.k, new Func<e1k, bool>(do4.a.a.c));
		array2[1] = new arr(this.l, new Func<e1k, bool>(do4.a.a.d));
		array2[2] = new arr(this.p.a, new Func<e1k, bool>(do4.a.a.e));
		array2[3] = new arr(this.c, null);
		fh2.a(array2);
		this.k.a(new arr[]
		{
			new arr(this.h, new Func<e1k, bool>(this.e)),
			new arr(this.i, new Func<e1k, bool>(this.d)),
			new arr(this.g, new Func<e1k, bool>(this.c)),
			new arr(this.f, new Func<e1k, bool>(this.b)),
			new arr(this.e, new Func<e1k, bool>(this.a)),
			new arr(this.c, null)
		});
		this.e.a = this.d.a;
		this.f.a = this.d.a;
		this.g.a = this.d.a;
		this.h.a = this.d.a;
		this.i.a = this.d.a;
		this.e.b = this.n;
		this.f.b = this.n;
		this.g.b = this.n;
		this.h.b = this.n;
		this.i.b = this.n;
		this.n.a = new Action<ej0>(do4.a.a.d);
		this.n.a = this.a;
		this.l.a = new Action<ej0>(do4.a.a.e);
		this.l.a = this.d.a;
		this.p.a = this.a;
	}

	// Token: 0x060016B8 RID: 5816 RVA: 0x00070B70 File Offset: 0x0006ED70
	public new static bool f(e1k A_0)
	{
		amc amc = new bzv(A_0.c().y6()).g();
		return amc != null && (amc.aa().b(d8o.e) || amc.aa().d(CharacterImmunities.MindAffecting));
	}

	// Token: 0x060016B9 RID: 5817 RVA: 0x00070BC0 File Offset: 0x0006EDC0
	public new static void a(efk A_0, string A_1)
	{
		c8d c8d = Enumerable.FirstOrDefault<coh>(A_0.Bag.b(A_1)) as c8d;
		if (c8d != null)
		{
			if (A_0.Gear.l().Item != null)
			{
				A_0.Bag.z3(A_0.Gear.l().Item, true);
			}
			A_0.Gear.l().a(c8d, true);
		}
	}

	// Token: 0x060016BA RID: 5818 RVA: 0x00070C30 File Offset: 0x0006EE30
	[CompilerGenerated]
	private new bool e(e1k A_0)
	{
		if (A_0.d().GetPrimitivePropertyValue<int>("psiSynergy", new int?(0)).Value >= 5)
		{
			amc amc = new bzv(A_0.c().y6()).g();
			if (amc != null)
			{
				if (amc.aa().b(d8o.e) || amc.aa().d(CharacterImmunities.MindAffecting) || amc.aa().Vehicle != null || !amc.aa().b(d8o.b | d8o.c))
				{
					return false;
				}
				if (this.h.a(A_0) && cuo.a.NextDouble() < 0.85)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x060016BB RID: 5819 RVA: 0x00070CF4 File Offset: 0x0006EEF4
	[CompilerGenerated]
	private new bool d(e1k A_0)
	{
		if (A_0.d().GetPrimitivePropertyValue<int>("psiSynergy", new int?(0)).Value >= 3)
		{
			amc amc = new bzv(A_0.c().y6()).g();
			if (amc != null && this.i.a(A_0) && cuo.a.NextDouble() < 0.85)
			{
				cmb cmb = new bzv(A_0.c().y6()).d();
				if (cmb == null)
				{
					return false;
				}
				c67 c = dgk.Get<c67>();
				eoj a_ = new eoj(A_0.g().aa(), null, null);
				return eb4.IsSafeToThrow<rs>(A_0.g(), amc, (int)c.afi(a_), c.g(a_), cmb, false, false, false, false);
			}
		}
		return false;
	}

	// Token: 0x060016BC RID: 5820 RVA: 0x00070DC8 File Offset: 0x0006EFC8
	[CompilerGenerated]
	private new bool c(e1k A_0)
	{
		if (A_0.d().GetPrimitivePropertyValue<int>("psiSynergy", new int?(0)).Value >= 2)
		{
			amc amc = new bzv(A_0.c().y6()).g();
			if (amc != null)
			{
				if (amc.aa().SpecialStates.a || amc.aa().b(d8o.e) || amc.aa().d(CharacterImmunities.Stun))
				{
					return false;
				}
				if (this.g.a(A_0) && cuo.a.NextDouble() < 0.85)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x060016BD RID: 5821 RVA: 0x00070E7C File Offset: 0x0006F07C
	[CompilerGenerated]
	private new bool b(e1k A_0)
	{
		return A_0.d().GetPrimitivePropertyValue<int>("psiSynergy", new int?(0)).Value >= 1 && (do4.f(A_0) || cuo.a.NextDouble() < 0.6) && this.f.a(A_0);
	}

	// Token: 0x060016BE RID: 5822 RVA: 0x00070EE0 File Offset: 0x0006F0E0
	[CompilerGenerated]
	private new bool a(e1k A_0)
	{
		return !do4.f(A_0) && this.e.a(A_0);
	}

	// Token: 0x04000D52 RID: 3410
	private new fh a;

	// Token: 0x04000D53 RID: 3411
	private new ej0 b;

	// Token: 0x04000D54 RID: 3412
	private new ej0 c;

	// Token: 0x04000D55 RID: 3413
	private new ge d;

	// Token: 0x04000D56 RID: 3414
	private new TryInvokePsiAbilityNode<dzs> e;

	// Token: 0x04000D57 RID: 3415
	private new TryInvokePsiAbilityNode<h7> f;

	// Token: 0x04000D58 RID: 3416
	private new TryInvokePsiAbilityNode<dxh> g;

	// Token: 0x04000D59 RID: 3417
	private new TryInvokePsiAbilityNode<eq6> h;

	// Token: 0x04000D5A RID: 3418
	private new TryInvokePsiAbilityNode<c67> i;

	// Token: 0x04000D5B RID: 3419
	private new fh j;

	// Token: 0x04000D5C RID: 3420
	private new fh k;

	// Token: 0x04000D5D RID: 3421
	private new ej0 l;

	// Token: 0x04000D5E RID: 3422
	private new ej0 m;

	// Token: 0x04000D5F RID: 3423
	private new ej0 n;

	// Token: 0x0200031D RID: 797
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x060016C1 RID: 5825 RVA: 0x00070F14 File Offset: 0x0006F114
		internal object a(e1k A_0)
		{
			amc amc = new bzv(A_0.c().y6()).g();
			if (amc != null && amc.a8() != null && amc.a8().Area != null)
			{
				return amc.a8().Area.a(amc.a8().aj().a());
			}
			return null;
		}

		// Token: 0x060016C2 RID: 5826 RVA: 0x00070F7C File Offset: 0x0006F17C
		internal void a(ej0 A_0)
		{
			A_0.b().d().RemoveProperty("kited");
			A_0.b().d().RemoveProperty("psiInhibited");
		}

		// Token: 0x060016C3 RID: 5827 RVA: 0x00070FB8 File Offset: 0x0006F1B8
		internal bool b(e1k A_0)
		{
			if (awq.f(A_0.g()))
			{
				return false;
			}
			if (A_0.g().aa().SpecialStates.d)
			{
				return false;
			}
			dzs dzs = dgk.Get<dzs>();
			return A_0.g().aa().Offense.aa().zo() >= dzs.e(new eoj(A_0.g().aa(), null, null)) && (A_0.d().GetPrimitivePropertyValue<int>("psiSynergy", new int?(0)).Value != 0 || !do4.f(A_0));
		}

		// Token: 0x060016C4 RID: 5828 RVA: 0x00071064 File Offset: 0x0006F264
		internal void c(ej0 A_0)
		{
			A_0.b().d()["CombatMode"] = "o";
			efk efk = A_0.b().g().aa();
			if (efk.Gear.l().Item.fu().a5() != "openShell")
			{
				efk.Offense.a(WeaponKey.Secondary);
				do4.a(efk, "openShell");
				awx awx = new awx();
				awx.ad().Add(new e4t(A_0.b().g(), CharacterState.Custom1, dz6.b(cux.a), 0, null, 1));
				A_0.b().i().b(awx, atp.a);
			}
		}

		// Token: 0x060016C5 RID: 5829 RVA: 0x00071128 File Offset: 0x0006F328
		internal void b(ej0 A_0)
		{
			A_0.b().d()["CombatMode"] = "c";
			efk efk = A_0.b().g().aa();
			if (efk.Gear.l().Item.fu().a5() != "closedShell")
			{
				efk.Offense.a(WeaponKey.Primary);
				do4.a(efk, "closedShell");
				awx awx = new awx();
				awx.ad().Add(new e4t(A_0.b().g(), CharacterState.Custom2, dz6.b(cux.a), 0, null, 1));
				A_0.b().i().b(awx, atp.a);
			}
		}

		// Token: 0x060016C6 RID: 5830 RVA: 0x000711EC File Offset: 0x0006F3EC
		internal bool c(e1k A_0)
		{
			if (A_0.d().GetClassPropertyValue<string>("CombatMode") == "o" && !A_0.d().GetPrimitivePropertyValue<bool>("psiInhibited", new bool?(false)).Value)
			{
				dzs dzs = dgk.Get<dzs>();
				return !A_0.g().aa().SpecialStates.d && A_0.g().aa().Offense.aa().zo() >= dzs.e(new eoj(A_0.g().aa(), null, null));
			}
			return false;
		}

		// Token: 0x060016C7 RID: 5831 RVA: 0x00071298 File Offset: 0x0006F498
		internal bool d(e1k A_0)
		{
			if (!A_0.d().GetPrimitivePropertyValue<bool>("kited", null).GetValueOrDefault() && A_0.d().GetClassPropertyValue<string>("CombatMode") == "c")
			{
				dzs dzs = dgk.Get<dzs>();
				if (!A_0.g().aa().SpecialStates.d && A_0.g().aa().Offense.aa().zo() >= dzs.e(new eoj(A_0.g().aa(), null, null)))
				{
					return A_0.d().GetPrimitivePropertyValue<int>("psiSynergy", new int?(0)).Value != 0 || !do4.f(A_0);
				}
			}
			return false;
		}

		// Token: 0x060016C8 RID: 5832 RVA: 0x00071374 File Offset: 0x0006F574
		internal bool e(e1k A_0)
		{
			return A_0.d().GetClassPropertyValue<string>("CombatMode") == "c";
		}

		// Token: 0x060016C9 RID: 5833 RVA: 0x00071390 File Offset: 0x0006F590
		internal void d(ej0 A_0)
		{
			A_0.b().d()["psiInhibited"] = true;
		}

		// Token: 0x060016CA RID: 5834 RVA: 0x000713B0 File Offset: 0x0006F5B0
		internal void e(ej0 A_0)
		{
			amc amc = new bzv(A_0.b().c().y6()).g();
			if (amc != null)
			{
				ak1 ak = g8.a(A_0.b().c(), amc.a8().t.b, 2, 1.8f, int.MaxValue);
				if (ak != null)
				{
					A_0.b().g().a8().k.b.a(ak, 0.0, 1, 0, true);
				}
			}
			A_0.b().d()["kited"] = true;
		}

		// Token: 0x04000D60 RID: 3424
		public static readonly do4.a a = new do4.a();

		// Token: 0x04000D61 RID: 3425
		public static Func<e1k, object> b;

		// Token: 0x04000D62 RID: 3426
		public static Action<ej0> c;

		// Token: 0x04000D63 RID: 3427
		public static Func<e1k, bool> d;

		// Token: 0x04000D64 RID: 3428
		public static Action<ej0> e;

		// Token: 0x04000D65 RID: 3429
		public static Action<ej0> f;

		// Token: 0x04000D66 RID: 3430
		public static Func<e1k, bool> g;

		// Token: 0x04000D67 RID: 3431
		public static Func<e1k, bool> h;

		// Token: 0x04000D68 RID: 3432
		public static Func<e1k, bool> i;

		// Token: 0x04000D69 RID: 3433
		public static Action<ej0> j;

		// Token: 0x04000D6A RID: 3434
		public static Action<ej0> k;
	}
}
