using System;
using System.Linq;
using System.Runtime.CompilerServices;
using TimelapseVertigo.AI.Model.TurnBased;
using TimelapseVertigo.Playfield.Locale;
using TimelapseVertigo.Rules.Characters;

// Token: 0x020002D0 RID: 720
[apc("greaterPsiBeetle")]
public class b2n : or
{
	// Token: 0x06001558 RID: 5464 RVA: 0x0006347C File Offset: 0x0006167C
	public override string jw()
	{
		return "PsiBeetleChitter";
	}

	// Token: 0x06001559 RID: 5465 RVA: 0x00063484 File Offset: 0x00061684
	public b2n()
	{
		this.q = new ej0();
		this.a = new fh(new arr[0]);
		this.b = new ej0();
		this.c = new ej0();
		this.d = new ge
		{
			a = 3.0
		};
		this.n = new fh(new arr[0]);
		this.o = new fh(new arr[0]);
		this.e = new TryInvokePsiAbilityNode<dzs>();
		this.f = new TryInvokePsiAbilityNode<h7>();
		this.g = new TryInvokePsiAbilityNode<dxh>();
		this.h = new TryInvokePsiAbilityNode<eq6>();
		this.i = new TryInvokePsiAbilityNode<c67>();
		this.j = new TryInvokePsiAbilityNode<ezt>();
		this.k = new TryInvokePsiAbilityNode<byu>();
		this.l = new TryInvokePsiAbilityNode<px>();
		this.m = new TryInvokePsiAbilityNode<d97>();
		this.m.a = new Func<e1k, object>(b2n.a.a.b);
		this.p = new ej0();
		this.r = new ej0();
		this.i.a = new Func<e1k, object>(b2n.a.a.e);
		this.q.a = new Action<ej0>(b2n.a.a.a);
		this.q.a = this.c.a;
		this.c.a = this.q;
		fh fh = this.a;
		arr[] array = new arr[2];
		array[0] = new arr(this.b, new Func<e1k, bool>(b2n.a.a.a));
		array[1] = new arr(this.c, null);
		fh.a(array);
		this.b.a = new Action<ej0>(b2n.a.a.e);
		this.b.a = this.d;
		this.c.a = new Action<ej0>(b2n.a.a.c);
		this.c.a = this.d;
		this.d.a = this.n;
		fh fh2 = this.n;
		arr[] array2 = new arr[4];
		array2[0] = new arr(this.o, new Func<e1k, bool>(b2n.a.a.f));
		array2[1] = new arr(this.p, new Func<e1k, bool>(b2n.a.a.d));
		array2[2] = new arr(this.p.a, new Func<e1k, bool>(b2n.a.a.c));
		array2[3] = new arr(this.c, null);
		fh2.a(array2);
		this.o.a(new arr[]
		{
			new arr(this.m, new Func<e1k, bool>(this.i)),
			new arr(this.k, new Func<e1k, bool>(this.h)),
			new arr(this.l, new Func<e1k, bool>(this.g)),
			new arr(this.h, new Func<e1k, bool>(this.f)),
			new arr(this.i, new Func<e1k, bool>(this.e)),
			new arr(this.g, new Func<e1k, bool>(this.d)),
			new arr(this.j, new Func<e1k, bool>(this.c)),
			new arr(this.f, new Func<e1k, bool>(this.b)),
			new arr(this.e, new Func<e1k, bool>(this.a)),
			new arr(this.c, null)
		});
		this.e.a = this.d.a;
		this.f.a = this.d.a;
		this.g.a = this.d.a;
		this.h.a = this.d.a;
		this.i.a = this.d.a;
		this.j.a = this.d.a;
		this.k.a = this.d.a;
		this.m.a = this.d.a;
		this.l.a = this.d.a;
		this.e.b = this.r;
		this.f.b = this.r;
		this.g.b = this.r;
		this.h.b = this.r;
		this.i.b = this.r;
		this.j.b = this.r;
		this.k.b = this.r;
		this.m.b = this.r;
		this.l.b = this.r;
		this.r.a = new Action<ej0>(b2n.a.a.b);
		this.r.a = this.a;
		this.p.a = new Action<ej0>(b2n.a.a.d);
		this.p.a = this.d.a;
		this.p.a = this.a;
	}

	// Token: 0x0600155A RID: 5466 RVA: 0x00063ABC File Offset: 0x00061CBC
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

	// Token: 0x0600155B RID: 5467 RVA: 0x00063B2C File Offset: 0x00061D2C
	[CompilerGenerated]
	private new bool i(e1k A_0)
	{
		if (A_0.d().GetPrimitivePropertyValue<int>("psiSynergy", new int?(0)).Value >= 0 && this.m.a(A_0) && !A_0.g().aa().SpecialStates.g)
		{
			amc amc = new bzv(A_0.c().y6()).g();
			if (amc != null && amc.aa().IsInControl)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600155C RID: 5468 RVA: 0x00063BB8 File Offset: 0x00061DB8
	[CompilerGenerated]
	private new bool h(e1k A_0)
	{
		if (A_0.d().GetPrimitivePropertyValue<int>("psiSynergy", new int?(0)).Value >= 9 && this.k.a(A_0))
		{
			amc amc = new bzv(A_0.c().y6()).g();
			if (amc != null && euf.f(amc.aa()) >= 0.5f && cuo.a.NextDouble() < 0.5)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600155D RID: 5469 RVA: 0x00063C48 File Offset: 0x00061E48
	[CompilerGenerated]
	private new bool g(e1k A_0)
	{
		if (this.l.a(A_0))
		{
			amc amc = new bzv(A_0.c().y6()).g();
			if (amc != null && amc.aa().Feats.Contains<c3v>() && amc.aa().Offense.aa().zo() >= 20f && !amc.aa().SpecialStates.d && amc.aa().IsInControl)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600155E RID: 5470 RVA: 0x00063CE0 File Offset: 0x00061EE0
	[CompilerGenerated]
	private new bool f(e1k A_0)
	{
		if (A_0.d().GetPrimitivePropertyValue<int>("psiSynergy", new int?(0)).Value >= 6)
		{
			amc amc = new bzv(A_0.c().y6()).g();
			if (amc != null)
			{
				if (amc.aa().b(d8o.e) || amc.aa().d(CharacterImmunities.MindAffecting) || amc.aa().Vehicle != null || !amc.aa().b(d8o.b | d8o.c))
				{
					return false;
				}
				if (this.h.a(A_0) && cuo.a.NextDouble() < 0.5)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x0600155F RID: 5471 RVA: 0x00063DA4 File Offset: 0x00061FA4
	[CompilerGenerated]
	private new bool e(e1k A_0)
	{
		if (A_0.d().GetPrimitivePropertyValue<int>("psiSynergy", new int?(0)).Value >= 0)
		{
			amc amc = new bzv(A_0.c().y6()).g();
			if (amc != null && this.i.a(A_0) && cuo.a.NextDouble() < 0.5)
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

	// Token: 0x06001560 RID: 5472 RVA: 0x00063E78 File Offset: 0x00062078
	[CompilerGenerated]
	private new bool d(e1k A_0)
	{
		if (A_0.d().GetPrimitivePropertyValue<int>("psiSynergy", new int?(0)).Value >= 1)
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

	// Token: 0x06001561 RID: 5473 RVA: 0x00063F2C File Offset: 0x0006212C
	[CompilerGenerated]
	private new bool c(e1k A_0)
	{
		if (this.j.a(A_0))
		{
			amc amc = new bzv(A_0.c().y6()).g();
			if (amc != null && amc.aa().IsInControl && !amc.aa().StatusEffects.a(cpy.a) && (!euf.b(amc.aa().Offense.u().TypedDefinition) || A_0.g().aa().PsiAbilities.a() == 1))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06001562 RID: 5474 RVA: 0x00063FD0 File Offset: 0x000621D0
	[CompilerGenerated]
	private new bool b(e1k A_0)
	{
		return A_0.d().GetPrimitivePropertyValue<int>("psiSynergy", new int?(0)).Value >= 0 && (do4.f(A_0) || cuo.a.NextDouble() < 0.6) && this.f.a(A_0);
	}

	// Token: 0x06001563 RID: 5475 RVA: 0x00064034 File Offset: 0x00062234
	[CompilerGenerated]
	private new bool a(e1k A_0)
	{
		return !do4.f(A_0) && this.e.a(A_0);
	}

	// Token: 0x04000C0B RID: 3083
	private new fh a;

	// Token: 0x04000C0C RID: 3084
	private new ej0 b;

	// Token: 0x04000C0D RID: 3085
	private new ej0 c;

	// Token: 0x04000C0E RID: 3086
	private new ge d;

	// Token: 0x04000C0F RID: 3087
	private new TryInvokePsiAbilityNode<dzs> e;

	// Token: 0x04000C10 RID: 3088
	private new TryInvokePsiAbilityNode<h7> f;

	// Token: 0x04000C11 RID: 3089
	private new TryInvokePsiAbilityNode<dxh> g;

	// Token: 0x04000C12 RID: 3090
	private new TryInvokePsiAbilityNode<eq6> h;

	// Token: 0x04000C13 RID: 3091
	protected new TryInvokePsiAbilityNode<c67> i;

	// Token: 0x04000C14 RID: 3092
	private new TryInvokePsiAbilityNode<ezt> j;

	// Token: 0x04000C15 RID: 3093
	private new TryInvokePsiAbilityNode<byu> k;

	// Token: 0x04000C16 RID: 3094
	private new TryInvokePsiAbilityNode<px> l;

	// Token: 0x04000C17 RID: 3095
	private new TryInvokePsiAbilityNode<d97> m;

	// Token: 0x04000C18 RID: 3096
	protected new fh n;

	// Token: 0x04000C19 RID: 3097
	protected new fh o;

	// Token: 0x04000C1A RID: 3098
	private new ej0 p;

	// Token: 0x04000C1B RID: 3099
	private new ej0 q;

	// Token: 0x04000C1C RID: 3100
	protected new ej0 r;

	// Token: 0x020002D1 RID: 721
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06001566 RID: 5478 RVA: 0x00064064 File Offset: 0x00062264
		internal object b(e1k A_0)
		{
			if (A_0.g() != null)
			{
				return A_0.g().a8();
			}
			return null;
		}

		// Token: 0x06001567 RID: 5479 RVA: 0x00064080 File Offset: 0x00062280
		internal object e(e1k A_0)
		{
			amc amc = new bzv(A_0.c().y6()).g();
			if (amc != null && amc.a8() != null && amc.a8().Area != null)
			{
				return amc.a8().Area.a(amc.a8().aj().a());
			}
			return null;
		}

		// Token: 0x06001568 RID: 5480 RVA: 0x000640E8 File Offset: 0x000622E8
		internal void a(ej0 A_0)
		{
			A_0.b().d().RemoveProperty("kited");
			A_0.b().d().RemoveProperty("psiInhibited");
		}

		// Token: 0x06001569 RID: 5481 RVA: 0x00064124 File Offset: 0x00062324
		internal bool a(e1k A_0)
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

		// Token: 0x0600156A RID: 5482 RVA: 0x000641D0 File Offset: 0x000623D0
		internal void e(ej0 A_0)
		{
			A_0.b().d()["CombatMode"] = "o";
			efk efk = A_0.b().g().aa();
			if (efk.Gear.l().Item.fu().a5() != "openShell")
			{
				efk.Offense.a(WeaponKey.Secondary);
				b2n.a(efk, "openShell");
				awx awx = new awx();
				awx.ad().Add(new e4t(A_0.b().g(), CharacterState.Custom1, dz6.b(cux.a), 0, null, 1));
				A_0.b().i().b(awx, atp.a);
			}
		}

		// Token: 0x0600156B RID: 5483 RVA: 0x00064294 File Offset: 0x00062494
		internal void c(ej0 A_0)
		{
			A_0.b().d()["CombatMode"] = "c";
			efk efk = A_0.b().g().aa();
			if (efk.Gear.l().Item.fu().a5() != "closedShell")
			{
				efk.Offense.a(WeaponKey.Primary);
				b2n.a(efk, "closedShell");
				awx awx = new awx();
				awx.ad().Add(new e4t(A_0.b().g(), CharacterState.Custom2, dz6.b(cux.a), 0, null, 1));
				A_0.b().i().b(awx, atp.a);
			}
		}

		// Token: 0x0600156C RID: 5484 RVA: 0x00064358 File Offset: 0x00062558
		internal bool f(e1k A_0)
		{
			if (A_0.d().GetClassPropertyValue<string>("CombatMode") == "o" && !A_0.d().GetPrimitivePropertyValue<bool>("psiInhibited", new bool?(false)).Value)
			{
				dzs dzs = dgk.Get<dzs>();
				return !A_0.g().aa().SpecialStates.d && A_0.g().aa().Offense.aa().zo() >= dzs.e(new eoj(A_0.g().aa(), null, null));
			}
			return false;
		}

		// Token: 0x0600156D RID: 5485 RVA: 0x00064404 File Offset: 0x00062604
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

		// Token: 0x0600156E RID: 5486 RVA: 0x000644E0 File Offset: 0x000626E0
		internal bool c(e1k A_0)
		{
			return A_0.d().GetClassPropertyValue<string>("CombatMode") == "c";
		}

		// Token: 0x0600156F RID: 5487 RVA: 0x000644FC File Offset: 0x000626FC
		internal void b(ej0 A_0)
		{
			A_0.b().d()["psiInhibited"] = true;
		}

		// Token: 0x06001570 RID: 5488 RVA: 0x0006451C File Offset: 0x0006271C
		internal void d(ej0 A_0)
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

		// Token: 0x04000C1D RID: 3101
		public static readonly b2n.a a = new b2n.a();

		// Token: 0x04000C1E RID: 3102
		public static Func<e1k, object> b;

		// Token: 0x04000C1F RID: 3103
		public static Func<e1k, object> c;

		// Token: 0x04000C20 RID: 3104
		public static Action<ej0> d;

		// Token: 0x04000C21 RID: 3105
		public static Func<e1k, bool> e;

		// Token: 0x04000C22 RID: 3106
		public static Action<ej0> f;

		// Token: 0x04000C23 RID: 3107
		public static Action<ej0> g;

		// Token: 0x04000C24 RID: 3108
		public static Func<e1k, bool> h;

		// Token: 0x04000C25 RID: 3109
		public static Func<e1k, bool> i;

		// Token: 0x04000C26 RID: 3110
		public static Func<e1k, bool> j;

		// Token: 0x04000C27 RID: 3111
		public static Action<ej0> k;

		// Token: 0x04000C28 RID: 3112
		public static Action<ej0> l;
	}
}
