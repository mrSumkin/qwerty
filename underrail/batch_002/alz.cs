using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using TimelapseVertigo.AI.Model.TurnBased;
using TimelapseVertigo.Rules.Characters;

// Token: 0x0200032A RID: 810
[apc("advancedGreaterPsiBeetle")]
public sealed class alz : b2n
{
	// Token: 0x06001736 RID: 5942 RVA: 0x00074100 File Offset: 0x00072300
	public alz()
	{
		this.a = new TryInvokePsiAbilityNode<ed3>();
		this.b = new TryInvokePsiAbilityNode<c4n>();
		this.c = new TryInvokePsiAbilityNode<e6s>();
		this.d = new TryInvokePsiAbilityNode<c0o>();
		this.e = new TryInvokePsiAbilityNode<eqr>();
		this.f = new TryInvokePsiAbilityNode<eod>();
		this.i = new ej0();
		this.f.a = new Func<e1k, object>(alz.a.a.a);
		this.e.a = this.f.a;
		this.d.a = this.f.a;
		this.g = new TryInvokePsiAbilityNode<evz>();
		this.h = new TryInvokePsiAbilityNode<c5y>();
		this.g.a = this.i.a;
		this.h.a = this.g.a;
		this.i.a = new Action<ej0>(alz.a.a.a);
		this.o.a.Insert(0, new arr(this.d, new Func<e1k, bool>(this.h)));
		this.o.a.Insert(1, new arr(this.e, new Func<e1k, bool>(this.g)));
		this.o.a.Insert(2, new arr(this.b, new Func<e1k, bool>(this.f)));
		this.o.a.Insert(3, new arr(this.c, new Func<e1k, bool>(this.e)));
		this.o.a.Insert(4, new arr(this.a, new Func<e1k, bool>(this.d)));
		this.o.a.Insert(0, new arr(this.f, new Func<e1k, bool>(this.c)));
		this.o.a.Insert(1, new arr(this.g, new Func<e1k, bool>(this.b)));
		this.o.a.Insert(2, new arr(this.h, new Func<e1k, bool>(this.a)));
		this.f.a = this.i;
		this.i.a = this.d.a;
		this.g.a = this.d.a;
		this.h.a = this.d.a;
		this.f.b = this.r;
		this.g.b = this.r;
		this.h.b = this.r;
		this.a.a = this.d.a;
		this.b.a = this.d.a;
		this.c.a = this.d.a;
		this.d.a = this.d.a;
		this.e.a = this.d.a;
		this.a.b = this.r;
		this.b.b = this.r;
		this.c.b = this.r;
		this.d.b = this.r;
		this.e.b = this.r;
	}

	// Token: 0x06001737 RID: 5943 RVA: 0x000744B4 File Offset: 0x000726B4
	[CompilerGenerated]
	private new bool h(e1k A_0)
	{
		if (this.d.a(A_0))
		{
			amc amc = new bzv(A_0.c().y6()).g();
			if (amc != null && amc.aa().IsInControl)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06001738 RID: 5944 RVA: 0x00074504 File Offset: 0x00072704
	[CompilerGenerated]
	private new bool g(e1k A_0)
	{
		if (this.e.a(A_0))
		{
			amc amc = new bzv(A_0.c().y6()).g();
			if (amc != null && euf.f(A_0.g().aa()) < 0.2f)
			{
				List<csk> classPropertyValue = amc.aa().CustomProperties.GetClassPropertyValue<List<csk>>(ddm.g);
				if (classPropertyValue != null)
				{
					if (Enumerable.Sum<csk>(classPropertyValue, new Func<csk, int>(alz.a.a.b)) >= (int)(amc.aa().Defense.q().zm() * 0.1f))
					{
						return true;
					}
				}
			}
		}
		return false;
	}

	// Token: 0x06001739 RID: 5945 RVA: 0x000745C0 File Offset: 0x000727C0
	[CompilerGenerated]
	private new bool f(e1k A_0)
	{
		if (this.b.a(A_0))
		{
			amc amc = new bzv(A_0.c().y6()).g();
			if (amc != null && amc.aa().IsInControl && !amc.aa().d(CharacterImmunities.TemporalEffects))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600173A RID: 5946 RVA: 0x00074624 File Offset: 0x00072824
	[CompilerGenerated]
	private new bool e(e1k A_0)
	{
		if (this.c.a(A_0))
		{
			amc amc = new bzv(A_0.c().y6()).g();
			if (amc != null && !amc.aa().d(CharacterImmunities.TemporalEffects))
			{
				List<csk> classPropertyValue = amc.aa().CustomProperties.GetClassPropertyValue<List<csk>>(ddm.g);
				if (classPropertyValue != null)
				{
					if (Enumerable.Sum<csk>(classPropertyValue, new Func<csk, int>(alz.a.a.a)) >= (int)(amc.aa().Defense.q().zm() * 0.25f))
					{
						return true;
					}
				}
			}
		}
		return false;
	}

	// Token: 0x0600173B RID: 5947 RVA: 0x000746DC File Offset: 0x000728DC
	[CompilerGenerated]
	private new bool d(e1k A_0)
	{
		if (this.a.a(A_0))
		{
			amc amc = new bzv(A_0.c().y6()).g();
			if (amc != null && !amc.aa().d(CharacterImmunities.TemporalEffects))
			{
				int count = amc.aa().StatusEffects.Get<bha>().Count;
				return count >= 3 || count != 2 || cuo.a.NextDouble() >= 0.5;
			}
		}
		return false;
	}

	// Token: 0x0600173C RID: 5948 RVA: 0x00074770 File Offset: 0x00072970
	[CompilerGenerated]
	private new bool c(e1k A_0)
	{
		if (this.f.a(A_0) && !A_0.g().aa().SpecialStates.g && !A_0.g().aa().SpecialStates.b)
		{
			bzv bzv = new bzv(A_0.c().y6());
			if (bzv.g() != null)
			{
				cmb cmb = bzv.d();
				if (cmb == null)
				{
					return false;
				}
				float num = cmb.b(2);
				if (num != -1f && num <= 5f)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x0600173D RID: 5949 RVA: 0x00074810 File Offset: 0x00072A10
	[CompilerGenerated]
	private new bool b(e1k A_0)
	{
		if (this.g.a(A_0))
		{
			bzv bzv = new bzv(A_0.c().y6());
			if (bzv.g() != null)
			{
				evz evz = this.g.a();
				if (evz == null)
				{
					return false;
				}
				cmb cmb = bzv.d();
				if (cmb == null)
				{
					return false;
				}
				eoj a_ = new eoj(A_0.g().aa(), null, null);
				float num = evz.afi(a_);
				float num2 = num * evz.d;
				int num3;
				return cmb.a((int)num, out num3) <= 1.25f && (float)num3 >= num2 * 0.8f;
			}
		}
		return false;
	}

	// Token: 0x0600173E RID: 5950 RVA: 0x000748C0 File Offset: 0x00072AC0
	[CompilerGenerated]
	private new bool a(e1k A_0)
	{
		return this.h.a(A_0) && new bzv(A_0.c().y6()).g() != null;
	}

	// Token: 0x04000DCA RID: 3530
	private new TryInvokePsiAbilityNode<ed3> a;

	// Token: 0x04000DCB RID: 3531
	private new TryInvokePsiAbilityNode<c4n> b;

	// Token: 0x04000DCC RID: 3532
	private new TryInvokePsiAbilityNode<e6s> c;

	// Token: 0x04000DCD RID: 3533
	private new TryInvokePsiAbilityNode<c0o> d;

	// Token: 0x04000DCE RID: 3534
	private new TryInvokePsiAbilityNode<eqr> e;

	// Token: 0x04000DCF RID: 3535
	private new TryInvokePsiAbilityNode<eod> f;

	// Token: 0x04000DD0 RID: 3536
	private new TryInvokePsiAbilityNode<evz> g;

	// Token: 0x04000DD1 RID: 3537
	private new TryInvokePsiAbilityNode<c5y> h;

	// Token: 0x04000DD2 RID: 3538
	private new ej0 i;

	// Token: 0x0200032B RID: 811
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06001741 RID: 5953 RVA: 0x00074904 File Offset: 0x00072B04
		internal object a(e1k A_0)
		{
			if (A_0.g() != null)
			{
				return A_0.g().a8();
			}
			return null;
		}

		// Token: 0x06001742 RID: 5954 RVA: 0x00074920 File Offset: 0x00072B20
		internal void a(ej0 A_0)
		{
			ip ip = A_0.b().g().aa().Cooldowns.b("Psi.ExothermicAura");
			if (ip == null || ip.a > (double)(4 * d0u.b))
			{
				ip.a = (double)(4 * d0u.b);
			}
		}

		// Token: 0x06001743 RID: 5955 RVA: 0x00074974 File Offset: 0x00072B74
		internal int b(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x06001744 RID: 5956 RVA: 0x00074980 File Offset: 0x00072B80
		internal int a(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x04000DD3 RID: 3539
		public static readonly alz.a a = new alz.a();

		// Token: 0x04000DD4 RID: 3540
		public static Func<e1k, object> b;

		// Token: 0x04000DD5 RID: 3541
		public static Action<ej0> c;

		// Token: 0x04000DD6 RID: 3542
		public static Func<csk, int> d;

		// Token: 0x04000DD7 RID: 3543
		public static Func<csk, int> e;
	}
}
