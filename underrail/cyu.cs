using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Ouroboros.Playfield.Space;
using TimelapseVertigo.AI.Model.TurnBased;
using TimelapseVertigo.Playfield.Locale;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02000301 RID: 769
[apc("superPsiBeetle")]
public sealed class cyu : or
{
	// Token: 0x06001625 RID: 5669 RVA: 0x0006A880 File Offset: 0x00068A80
	public cyu()
	{
		this.l = new ej0();
		this.a = new fh(new arr[0]);
		this.b = new ej0();
		this.c = new ej0();
		this.i = new fh(new arr[0]);
		this.j = new fh(new arr[0]);
		this.d = new TryInvokePsiAbilityNode<dzs>();
		this.e = new TryInvokePsiAbilityNode<h7>();
		this.f = new TryInvokePsiAbilityNode<dxh>();
		this.g = new TryInvokePsiAbilityNode<eq6>();
		this.h = new TryInvokePsiAbilityNode<c67>();
		this.k = new ej0();
		this.m = new ej0();
		this.o = new ej0();
		this.o.a = new Action<ej0>(cyu.a.a.d);
		this.o.a = this.j;
		this.n = new ej0(new Action<ej0>(cyu.a.a.c));
		this.n.a = this.c;
		this.j.a.Insert(0, new arr(this.n, new Func<e1k, bool>(cyu.a.a.a)));
		this.h.a = new Func<e1k, object>(cyu.a.a.b);
		this.l.a = new Action<ej0>(cyu.a.a.g);
		this.l.a = this.c.a;
		this.c.a = this.l;
		fh fh = this.a;
		arr[] array = new arr[2];
		array[0] = new arr(this.b, new Func<e1k, bool>(cyu.a.a.e));
		array[1] = new arr(this.c, null);
		fh.a(array);
		this.b.a = new Action<ej0>(cyu.a.a.e);
		this.b.a = this.i;
		this.c.a = new Action<ej0>(cyu.a.a.f);
		this.c.a = this.i;
		fh fh2 = this.i;
		arr[] array2 = new arr[4];
		array2[0] = new arr(this.j, new Func<e1k, bool>(cyu.a.a.d));
		array2[1] = new arr(this.k, new Func<e1k, bool>(cyu.a.a.c));
		array2[2] = new arr(this.p.a, new Func<e1k, bool>(cyu.a.a.f));
		array2[3] = new arr(this.c, null);
		fh2.a(array2);
		this.j.a(new arr[]
		{
			new arr(this.g, new Func<e1k, bool>(this.e)),
			new arr(this.h, new Func<e1k, bool>(this.d)),
			new arr(this.f, new Func<e1k, bool>(this.c)),
			new arr(this.e, new Func<e1k, bool>(this.b)),
			new arr(this.d, new Func<e1k, bool>(this.a)),
			new arr(this.c, null)
		});
		this.d.a = this.o;
		this.e.a = this.o;
		this.f.a = this.o;
		this.g.a = this.o;
		this.h.a = this.o;
		this.d.b = this.m;
		this.e.b = this.m;
		this.f.b = this.m;
		this.g.b = this.m;
		this.h.b = this.m;
		this.m.a = new Action<ej0>(cyu.a.a.b);
		this.m.a = this.a;
		this.k.a = new Action<ej0>(cyu.a.a.a);
		this.k.a = this.d.a;
		this.p.a = this.a;
	}

	// Token: 0x06001626 RID: 5670 RVA: 0x0006ADDC File Offset: 0x00068FDC
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

	// Token: 0x06001627 RID: 5671 RVA: 0x0006AE4C File Offset: 0x0006904C
	[CompilerGenerated]
	private new bool e(e1k A_0)
	{
		amc amc = new bzv(A_0.c().y6()).g();
		if (amc != null)
		{
			if (amc.aa().b(d8o.e) || amc.aa().d(CharacterImmunities.MindAffecting) || amc.aa().Vehicle != null || !amc.aa().b(d8o.b | d8o.c))
			{
				return false;
			}
			if (this.g.a(A_0) && cuo.a.NextDouble() < 0.85)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06001628 RID: 5672 RVA: 0x0006AEEC File Offset: 0x000690EC
	[CompilerGenerated]
	private new bool d(e1k A_0)
	{
		amc amc = new bzv(A_0.c().y6()).g();
		if (amc == null || !this.h.a(A_0) || cuo.a.NextDouble() >= 0.85)
		{
			return false;
		}
		cmb cmb = new bzv(A_0.c().y6()).d();
		if (cmb == null)
		{
			return false;
		}
		c67 c = dgk.Get<c67>();
		eoj a_ = new eoj(A_0.g().aa(), null, null);
		return eb4.IsSafeToThrow<rs>(A_0.g(), amc, (int)c.afi(a_), c.g(a_), cmb, false, false, false, false);
	}

	// Token: 0x06001629 RID: 5673 RVA: 0x0006AF98 File Offset: 0x00069198
	[CompilerGenerated]
	private new bool c(e1k A_0)
	{
		amc amc = new bzv(A_0.c().y6()).g();
		if (amc != null)
		{
			if (amc.aa().SpecialStates.a || amc.aa().b(d8o.e) || amc.aa().d(CharacterImmunities.Stun))
			{
				return false;
			}
			if (this.f.a(A_0) && cuo.a.NextDouble() < 0.85)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600162A RID: 5674 RVA: 0x0006B028 File Offset: 0x00069228
	[CompilerGenerated]
	private new bool b(e1k A_0)
	{
		bool flag = false;
		amc amc = new bzv(A_0.c().y6()).g();
		if (amc != null && amc.aa().b(d8o.e))
		{
			flag = true;
		}
		return (flag || cuo.a.NextDouble() < 0.6) && this.e.a(A_0);
	}

	// Token: 0x0600162B RID: 5675 RVA: 0x0006B094 File Offset: 0x00069294
	[CompilerGenerated]
	private new bool a(e1k A_0)
	{
		return this.d.a(A_0);
	}

	// Token: 0x04000CB6 RID: 3254
	private new fh a;

	// Token: 0x04000CB7 RID: 3255
	private new ej0 b;

	// Token: 0x04000CB8 RID: 3256
	private new ej0 c;

	// Token: 0x04000CB9 RID: 3257
	private new TryInvokePsiAbilityNode<dzs> d;

	// Token: 0x04000CBA RID: 3258
	private new TryInvokePsiAbilityNode<h7> e;

	// Token: 0x04000CBB RID: 3259
	private new TryInvokePsiAbilityNode<dxh> f;

	// Token: 0x04000CBC RID: 3260
	private new TryInvokePsiAbilityNode<eq6> g;

	// Token: 0x04000CBD RID: 3261
	private new TryInvokePsiAbilityNode<c67> h;

	// Token: 0x04000CBE RID: 3262
	private new fh i;

	// Token: 0x04000CBF RID: 3263
	private new fh j;

	// Token: 0x04000CC0 RID: 3264
	private new ej0 k;

	// Token: 0x04000CC1 RID: 3265
	private new ej0 l;

	// Token: 0x04000CC2 RID: 3266
	private new ej0 m;

	// Token: 0x04000CC3 RID: 3267
	private new ej0 n;

	// Token: 0x04000CC4 RID: 3268
	private new ej0 o;

	// Token: 0x02000302 RID: 770
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x0600162E RID: 5678 RVA: 0x0006B0BC File Offset: 0x000692BC
		internal void d(ej0 A_0)
		{
			ip ip = A_0.b().g().aa().Cooldowns.b("ventEscape");
			if (ip == null || ip.a <= 0.0)
			{
				d60 addon = A_0.b().g().a8().Zone.GetAddon<d60>();
				if (addon != null)
				{
					List<b0b> list = addon.ab4(new string[]
					{
						"beetleVent"
					});
					if (list.Count > 0)
					{
						double num = double.MaxValue;
						c5x c5x = null;
						foreach (b0b b0b in list)
						{
							c5x c5x2 = (c5x)b0b;
							ak1 ak;
							if (c5x2.VisualDirection == HorizontalDirection.South)
							{
								ak = c5x2.Area.b((int)c5x2.Location.X, (int)c5x2.Location.Y + 1);
							}
							else
							{
								ak = c5x2.Area.b((int)c5x2.Location.X + 1, (int)c5x2.Location.Y);
							}
							if (ak != null && !aw1.a(null, ak, false, A_0.b().g().a8()))
							{
								double num2 = aw1.b(c5x2, A_0.b().g().a8());
								if (num2 < num || c5x == null)
								{
									num = num2;
									c5x = c5x2;
								}
							}
						}
						if (c5x != null)
						{
							A_0.b().g().a8().k.b.b(c5x, c5x.s.b.t(), 1, false, null);
						}
					}
				}
			}
		}

		// Token: 0x0600162F RID: 5679 RVA: 0x0006B294 File Offset: 0x00069494
		internal void c(ej0 A_0)
		{
			A_0.b().g().aa().PersonalAttitudes.Clear();
			new bzv(A_0.b().c().y6()).e();
			eaq eaq = new eaq();
			eaq.b(asp.a);
			eaq.a(asp.ew);
			eaq.a(global::h.c);
			eaq.a(true);
			eaq.ym(null, null, null);
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null)
			{
				serviceOrThrow.aqu().r()["npc_tch_superPsiBeetle_incapacitated"] = true;
				if (serviceOrThrow.aqu().v() != null)
				{
					serviceOrThrow.aqu().v().PersonalAttitudes.Remove(asp.ew);
				}
			}
			A_0.b().g().aa().StatusEffects.a(new ab3(0), true, false, false);
			bpo.GetServiceOrThrow<d02>().ahs(true, false);
		}

		// Token: 0x06001630 RID: 5680 RVA: 0x0006B390 File Offset: 0x00069590
		internal bool a(e1k A_0)
		{
			return (double)euf.f(A_0.g().aa()) < 0.25 && (A_0.g().aa().SpecialStates.c || A_0.g().aa().SpecialStates.a);
		}

		// Token: 0x06001631 RID: 5681 RVA: 0x0006B3F4 File Offset: 0x000695F4
		internal object b(e1k A_0)
		{
			amc amc = new bzv(A_0.c().y6()).g();
			if (amc != null && amc.a8() != null && amc.a8().Area != null)
			{
				return amc.a8().Area.a(amc.a8().aj().a());
			}
			return null;
		}

		// Token: 0x06001632 RID: 5682 RVA: 0x0006B45C File Offset: 0x0006965C
		internal void g(ej0 A_0)
		{
			A_0.b().d().RemoveProperty("kited");
			A_0.b().d().RemoveProperty("psiInhibited");
		}

		// Token: 0x06001633 RID: 5683 RVA: 0x0006B498 File Offset: 0x00069698
		internal bool e(e1k A_0)
		{
			if (A_0.d().GetPrimitivePropertyValue<bool>("psiInhibited", new bool?(false)).Value)
			{
				return false;
			}
			dzs dzs = dgk.Get<dzs>();
			return !A_0.g().aa().SpecialStates.d && A_0.g().aa().Offense.aa().zo() >= dzs.e(new eoj(A_0.g().aa(), null, null));
		}

		// Token: 0x06001634 RID: 5684 RVA: 0x0006B524 File Offset: 0x00069724
		internal void e(ej0 A_0)
		{
			A_0.b().d()["CombatMode"] = "o";
			efk efk = A_0.b().g().aa();
			if (efk.Gear.l().Item.fu().a5() != "openShell")
			{
				efk.Offense.a(WeaponKey.Secondary);
				cyu.a(efk, "openShell");
				awx awx = new awx();
				awx.ad().Add(new e4t(A_0.b().g(), CharacterState.Custom1, dz6.b(cux.a), 0, null, 1));
				A_0.b().i().b(awx, atp.a);
			}
		}

		// Token: 0x06001635 RID: 5685 RVA: 0x0006B5E8 File Offset: 0x000697E8
		internal void f(ej0 A_0)
		{
			A_0.b().d()["CombatMode"] = "c";
			efk efk = A_0.b().g().aa();
			if (efk.Gear.l().Item.fu().a5() != "closedShell")
			{
				efk.Offense.a(WeaponKey.Primary);
				cyu.a(efk, "closedShell");
				awx awx = new awx();
				awx.ad().Add(new e4t(A_0.b().g(), CharacterState.Custom2, dz6.b(cux.a), 0, null, 1));
				A_0.b().i().b(awx, atp.a);
			}
		}

		// Token: 0x06001636 RID: 5686 RVA: 0x0006B6AC File Offset: 0x000698AC
		internal bool d(e1k A_0)
		{
			if (A_0.d().GetClassPropertyValue<string>("CombatMode") == "o")
			{
				dzs dzs = dgk.Get<dzs>();
				return !A_0.g().aa().SpecialStates.d && A_0.g().aa().Offense.aa().zo() >= dzs.e(new eoj(A_0.g().aa(), null, null));
			}
			return false;
		}

		// Token: 0x06001637 RID: 5687 RVA: 0x0006B734 File Offset: 0x00069934
		internal bool c(e1k A_0)
		{
			if (!A_0.d().GetPrimitivePropertyValue<bool>("kited", null).GetValueOrDefault() && A_0.d().GetClassPropertyValue<string>("CombatMode") == "c")
			{
				dzs dzs = dgk.Get<dzs>();
				return !A_0.g().aa().SpecialStates.d && A_0.g().aa().Offense.aa().zo() >= dzs.e(new eoj(A_0.g().aa(), null, null));
			}
			return false;
		}

		// Token: 0x06001638 RID: 5688 RVA: 0x0006B7E4 File Offset: 0x000699E4
		internal bool f(e1k A_0)
		{
			return A_0.d().GetClassPropertyValue<string>("CombatMode") == "c";
		}

		// Token: 0x06001639 RID: 5689 RVA: 0x0006B800 File Offset: 0x00069A00
		internal void b(ej0 A_0)
		{
			A_0.b().d()["psiInhibited"] = true;
		}

		// Token: 0x0600163A RID: 5690 RVA: 0x0006B820 File Offset: 0x00069A20
		internal void a(ej0 A_0)
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

		// Token: 0x04000CC5 RID: 3269
		public static readonly cyu.a a = new cyu.a();

		// Token: 0x04000CC6 RID: 3270
		public static Action<ej0> b;

		// Token: 0x04000CC7 RID: 3271
		public static Action<ej0> c;

		// Token: 0x04000CC8 RID: 3272
		public static Func<e1k, bool> d;

		// Token: 0x04000CC9 RID: 3273
		public static Func<e1k, object> e;

		// Token: 0x04000CCA RID: 3274
		public static Action<ej0> f;

		// Token: 0x04000CCB RID: 3275
		public static Func<e1k, bool> g;

		// Token: 0x04000CCC RID: 3276
		public static Action<ej0> h;

		// Token: 0x04000CCD RID: 3277
		public static Action<ej0> i;

		// Token: 0x04000CCE RID: 3278
		public static Func<e1k, bool> j;

		// Token: 0x04000CCF RID: 3279
		public static Func<e1k, bool> k;

		// Token: 0x04000CD0 RID: 3280
		public static Func<e1k, bool> l;

		// Token: 0x04000CD1 RID: 3281
		public static Action<ej0> m;

		// Token: 0x04000CD2 RID: 3282
		public static Action<ej0> n;
	}
}
