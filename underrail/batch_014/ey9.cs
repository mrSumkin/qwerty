using System;
using System.Linq;
using System.Runtime.CompilerServices;
using TimelapseVertigo.AI.Model.TurnBased;
using TimelapseVertigo.Playfield.Locale;
using TimelapseVertigo.Rules.Characters;

// Token: 0x020002C4 RID: 708
[apc("youngPsiBeetle")]
public sealed class ey9 : or
{
	// Token: 0x06001526 RID: 5414 RVA: 0x00061B74 File Offset: 0x0005FD74
	public override string jw()
	{
		return "PsiBeetleChitter";
	}

	// Token: 0x06001527 RID: 5415 RVA: 0x00061B7C File Offset: 0x0005FD7C
	public ey9()
	{
		this.i = new ej0();
		this.a = new fh(new arr[0]);
		this.b = new ej0();
		this.c = new ej0();
		this.d = new ge
		{
			a = 0.33
		};
		this.f = new fh(new arr[0]);
		this.g = new fh(new arr[0]);
		this.e = new TryInvokePsiAbilityNode<dzs>();
		this.h = new ej0();
		this.j = new ej0();
		this.i.a = new Action<ej0>(ey9.a.a.d);
		this.i.a = this.c.a;
		this.c.a = this.i;
		fh fh = this.a;
		arr[] array = new arr[2];
		array[0] = new arr(this.b, new Func<e1k, bool>(ey9.a.a.b));
		array[1] = new arr(this.c, null);
		fh.a(array);
		this.b.a = new Action<ej0>(ey9.a.a.b);
		this.b.a = this.d;
		this.c.a = new Action<ej0>(ey9.a.a.a);
		this.c.a = this.d;
		this.d.a = this.f;
		fh fh2 = this.f;
		arr[] array2 = new arr[4];
		array2[0] = new arr(this.g, new Func<e1k, bool>(ey9.a.a.a));
		array2[1] = new arr(this.h, new Func<e1k, bool>(ey9.a.a.d));
		array2[2] = new arr(this.p.a, new Func<e1k, bool>(ey9.a.a.c));
		array2[3] = new arr(this.c, null);
		fh2.a(array2);
		this.g.a(new arr[]
		{
			new arr(this.e, new Func<e1k, bool>(this.a)),
			new arr(this.c, null)
		});
		this.e.a = this.d.a;
		this.e.b = this.j;
		this.j.a = new Action<ej0>(ey9.a.a.e);
		this.j.a = this.a;
		this.h.a = new Action<ej0>(ey9.a.a.c);
		this.h.a = this.d.a;
		this.p.a = this.a;
	}

	// Token: 0x06001528 RID: 5416 RVA: 0x00061EF8 File Offset: 0x000600F8
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

	// Token: 0x06001529 RID: 5417 RVA: 0x00061F68 File Offset: 0x00060168
	[CompilerGenerated]
	private new bool a(e1k A_0)
	{
		return this.e.a(A_0);
	}

	// Token: 0x04000BDC RID: 3036
	private new fh a;

	// Token: 0x04000BDD RID: 3037
	private new ej0 b;

	// Token: 0x04000BDE RID: 3038
	private new ej0 c;

	// Token: 0x04000BDF RID: 3039
	private new ge d;

	// Token: 0x04000BE0 RID: 3040
	private new TryInvokePsiAbilityNode<dzs> e;

	// Token: 0x04000BE1 RID: 3041
	private new fh f;

	// Token: 0x04000BE2 RID: 3042
	private new fh g;

	// Token: 0x04000BE3 RID: 3043
	private new ej0 h;

	// Token: 0x04000BE4 RID: 3044
	private new ej0 i;

	// Token: 0x04000BE5 RID: 3045
	private new ej0 j;

	// Token: 0x020002C5 RID: 709
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x0600152C RID: 5420 RVA: 0x00061F8C File Offset: 0x0006018C
		internal void d(ej0 A_0)
		{
			A_0.b().d().RemoveProperty("kited");
			A_0.b().d().RemoveProperty("psiInhibited");
		}

		// Token: 0x0600152D RID: 5421 RVA: 0x00061FC8 File Offset: 0x000601C8
		internal bool b(e1k A_0)
		{
			if (awq.f(A_0.g()))
			{
				return false;
			}
			dzs dzs = dgk.Get<dzs>();
			return !A_0.g().aa().SpecialStates.d && A_0.g().aa().Offense.aa().zo() >= dzs.e(new eoj(A_0.g().aa(), null, null));
		}

		// Token: 0x0600152E RID: 5422 RVA: 0x00062040 File Offset: 0x00060240
		internal void b(ej0 A_0)
		{
			A_0.b().d()["CombatMode"] = "o";
			efk efk = A_0.b().g().aa();
			if (efk.Gear.l().Item.fu().a5() != "openShell")
			{
				efk.Offense.a(WeaponKey.Secondary);
				ey9.a(efk, "openShell");
				awx awx = new awx();
				awx.ad().Add(new e4t(A_0.b().g(), CharacterState.Custom1, dz6.b(cux.a), 0, null, 1));
				A_0.b().i().b(awx, atp.a);
			}
		}

		// Token: 0x0600152F RID: 5423 RVA: 0x00062104 File Offset: 0x00060304
		internal void a(ej0 A_0)
		{
			A_0.b().d()["CombatMode"] = "c";
			efk efk = A_0.b().g().aa();
			if (efk.Gear.l().Item.fu().a5() != "closedShell")
			{
				efk.Offense.a(WeaponKey.Primary);
				ey9.a(efk, "closedShell");
				awx awx = new awx();
				awx.ad().Add(new e4t(A_0.b().g(), CharacterState.Custom2, dz6.b(cux.a), 0, null, 1));
				A_0.b().i().b(awx, atp.a);
			}
		}

		// Token: 0x06001530 RID: 5424 RVA: 0x000621C8 File Offset: 0x000603C8
		internal bool a(e1k A_0)
		{
			if (A_0.d().GetClassPropertyValue<string>("CombatMode") == "o" && !A_0.d().GetPrimitivePropertyValue<bool>("psiInhibited", new bool?(false)).Value)
			{
				dzs dzs = dgk.Get<dzs>();
				return !A_0.g().aa().SpecialStates.d && A_0.g().aa().Offense.aa().zo() >= dzs.e(new eoj(A_0.g().aa(), null, null));
			}
			return false;
		}

		// Token: 0x06001531 RID: 5425 RVA: 0x00062274 File Offset: 0x00060474
		internal bool d(e1k A_0)
		{
			if (!A_0.d().GetPrimitivePropertyValue<bool>("kited", null).GetValueOrDefault() && A_0.d().GetClassPropertyValue<string>("CombatMode") == "c")
			{
				dzs dzs = dgk.Get<dzs>();
				return !A_0.g().aa().SpecialStates.d && A_0.g().aa().Offense.aa().zo() >= dzs.e(new eoj(A_0.g().aa(), null, null));
			}
			return false;
		}

		// Token: 0x06001532 RID: 5426 RVA: 0x00062324 File Offset: 0x00060524
		internal bool c(e1k A_0)
		{
			return A_0.d().GetClassPropertyValue<string>("CombatMode") == "c";
		}

		// Token: 0x06001533 RID: 5427 RVA: 0x00062340 File Offset: 0x00060540
		internal void e(ej0 A_0)
		{
			A_0.b().d()["psiInhibited"] = true;
		}

		// Token: 0x06001534 RID: 5428 RVA: 0x00062360 File Offset: 0x00060560
		internal void c(ej0 A_0)
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

		// Token: 0x04000BE6 RID: 3046
		public static readonly ey9.a a = new ey9.a();

		// Token: 0x04000BE7 RID: 3047
		public static Action<ej0> b;

		// Token: 0x04000BE8 RID: 3048
		public static Func<e1k, bool> c;

		// Token: 0x04000BE9 RID: 3049
		public static Action<ej0> d;

		// Token: 0x04000BEA RID: 3050
		public static Action<ej0> e;

		// Token: 0x04000BEB RID: 3051
		public static Func<e1k, bool> f;

		// Token: 0x04000BEC RID: 3052
		public static Func<e1k, bool> g;

		// Token: 0x04000BED RID: 3053
		public static Func<e1k, bool> h;

		// Token: 0x04000BEE RID: 3054
		public static Action<ej0> i;

		// Token: 0x04000BEF RID: 3055
		public static Action<ej0> j;
	}
}
