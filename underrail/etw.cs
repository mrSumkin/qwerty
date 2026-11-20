using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Ouroboros.Playfield.References;
using TimelapseVertigo.AI.Model.TurnBased;
using TimelapseVertigo.Rules;

// Token: 0x020002B4 RID: 692
[apc("coilSpider")]
public sealed class etw : cqw
{
	// Token: 0x06001441 RID: 5185 RVA: 0x0005781C File Offset: 0x00055A1C
	public override bool ef()
	{
		return false;
	}

	// Token: 0x06001442 RID: 5186 RVA: 0x00057820 File Offset: 0x00055A20
	public etw()
	{
		this.h = new fh(new arr[0]);
		this.f = new ej0();
		this.c = new fh(new arr[0]);
		this.d = new fh(new arr[0]);
		this.a = new TryInvokePsiAbilityNode<dl3>();
		this.b = new TryInvokePsiAbilityNode<c2q>();
		this.e = new ej0();
		this.g = new ej0();
		this.i = new a6w(null);
		this.b.a = new Func<e1k, object>(etw.a.a.d);
		this.i.a = new Func<a6w, cst>(this.a);
		this.i.a = this.i.a;
		this.i.b = this.i.a;
		fh fh = this.h;
		arr[] array = new arr[2];
		array[0] = new arr(this.i, new Func<e1k, bool>(etw.a.a.a));
		array[1] = new arr(this.i.a, null);
		fh.a(array);
		this.i.a = this.h;
		this.f.a = new Action<ej0>(etw.a.a.c);
		this.f.a = this.c.a;
		this.c.a = this.f;
		fh fh2 = this.c;
		arr[] array2 = new arr[3];
		array2[0] = new arr(this.e, new Func<e1k, bool>(etw.a.a.c));
		array2[1] = new arr(this.d, new Func<e1k, bool>(etw.a.a.b));
		array2[2] = new arr(this.p.a, null);
		fh2.a(array2);
		this.d.a(new arr[]
		{
			new arr(this.b, new Func<e1k, bool>(this.b)),
			new arr(this.a, new Func<e1k, bool>(this.a)),
			new arr(this.c, null)
		});
		this.a.a = this.d.a;
		this.a.b = this.g;
		this.b.a = this.d.a;
		this.b.b = this.g;
		this.g.a = new Action<ej0>(etw.a.a.a);
		this.g.a = this.c;
		this.e.a = new Action<ej0>(etw.a.a.b);
		this.e.a = this.d.a;
		this.p.a = this.c;
	}

	// Token: 0x06001443 RID: 5187 RVA: 0x00057B8C File Offset: 0x00055D8C
	[CompilerGenerated]
	private new cst a(a6w A_0)
	{
		d60 addon = base.g().a8().Zone.GetAddon<d60>();
		if (addon != null)
		{
			List<b0b> list = addon.ab4(new string[]
			{
				"coilSpiderWeb"
			});
			if (list.Count > 0)
			{
				float value = A_0.b().c().y6().GetPrimitivePropertyValue<float>("MaxRepairDistance", new float?(float.MaxValue)).Value;
				b0b b0b = null;
				double maxValue = double.MaxValue;
				foreach (b0b b0b2 in list)
				{
					b2x aspect = b0b2.GetAspect<b2x>();
					if (aspect != null && !aspect.a())
					{
						double num = aw1.b(base.g().a8(), b0b2);
						if (num <= (double)value)
						{
							ak1 ak = Enumerable.FirstOrDefault<ak1>(b0b2.l);
							if (ak != null && !ak.Formation.c(2L) && ak.f(null) == 0L)
							{
								if (b0b == null)
								{
									b0b = b0b2;
								}
								else if (num < maxValue)
								{
									b0b = b0b2;
								}
							}
						}
					}
				}
				if (b0b != null)
				{
					eu7 eu = ecf.a(dgk.Get<dwz>(), new eru(new EntityAspectReference<amc, amc>(base.g())), null) as eu7;
					if (eu != null && eu.yw())
					{
						return global::cp.b(eu, base.g().a8(), b0b);
					}
				}
			}
		}
		return null;
	}

	// Token: 0x06001444 RID: 5188 RVA: 0x00057D34 File Offset: 0x00055F34
	[CompilerGenerated]
	private new bool b(e1k A_0)
	{
		if (this.b.a(A_0))
		{
			amc amc = new bzv(A_0.c().y6()).g();
			if (amc != null)
			{
				double num = 0.0;
				List<coh> list = new List<coh>();
				list.AddRange(amc.aa().Gear.i());
				cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
				if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().ae() >= GameDifficulty.Hard)
				{
					list.AddRange(amc.aa().Bag.z2());
				}
				foreach (coh coh in list)
				{
					num += coh.Battery;
				}
				return num > 15.0;
			}
		}
		return false;
	}

	// Token: 0x06001445 RID: 5189 RVA: 0x00057E28 File Offset: 0x00056028
	[CompilerGenerated]
	private new bool a(e1k A_0)
	{
		return this.a.a(A_0);
	}

	// Token: 0x04000B11 RID: 2833
	private new TryInvokePsiAbilityNode<dl3> a;

	// Token: 0x04000B12 RID: 2834
	private new TryInvokePsiAbilityNode<c2q> b;

	// Token: 0x04000B13 RID: 2835
	private new fh c;

	// Token: 0x04000B14 RID: 2836
	private new fh d;

	// Token: 0x04000B15 RID: 2837
	private new ej0 e;

	// Token: 0x04000B16 RID: 2838
	private new ej0 f;

	// Token: 0x04000B17 RID: 2839
	private new ej0 g;

	// Token: 0x04000B18 RID: 2840
	private new fh h;

	// Token: 0x04000B19 RID: 2841
	private new a6w i;

	// Token: 0x020002B5 RID: 693
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06001448 RID: 5192 RVA: 0x00057E50 File Offset: 0x00056050
		internal object d(e1k A_0)
		{
			amc amc = new bzv(A_0.c().y6()).g();
			if (amc != null && amc.a8() != null && amc.a8().Area != null)
			{
				return amc.a8().Area.a(amc.a8().aj().a());
			}
			return null;
		}

		// Token: 0x06001449 RID: 5193 RVA: 0x00057EB8 File Offset: 0x000560B8
		internal bool a(e1k A_0)
		{
			if (A_0.g().aa().IsInCombat)
			{
				return false;
			}
			if (!(ecf.a(dgk.Get<dwz>(), new eru(new EntityAspectReference<amc, amc>(A_0.g())), null) is eu7))
			{
				return false;
			}
			d60 addon = A_0.g().a8().Zone.GetAddon<d60>();
			if (addon != null)
			{
				List<b0b> list = addon.ab4(new string[]
				{
					"coilSpiderWeb"
				});
				if (list.Count > 0)
				{
					float value = A_0.c().y6().GetPrimitivePropertyValue<float>("MaxRepairDistance", new float?(float.MaxValue)).Value;
					foreach (b0b b0b in list)
					{
						if (b0b.Area == A_0.g().a8().Area && aw1.b(A_0.c().a8(), b0b) <= (double)value)
						{
							b2x aspect = b0b.GetAspect<b2x>();
							if (aspect != null && !aspect.a())
							{
								ak1 ak = Enumerable.FirstOrDefault<ak1>(aspect.a8().l);
								if (ak != null && !ak.Formation.c(2L) && ak.f(null) == 0L)
								{
									return true;
								}
							}
						}
					}
					return false;
				}
			}
			return false;
		}

		// Token: 0x0600144A RID: 5194 RVA: 0x00058044 File Offset: 0x00056244
		internal void c(ej0 A_0)
		{
			A_0.b().d().RemoveProperty("kited");
			A_0.b().d().RemoveProperty("psiInhibited");
		}

		// Token: 0x0600144B RID: 5195 RVA: 0x00058080 File Offset: 0x00056280
		internal bool c(e1k A_0)
		{
			if (!A_0.d().GetPrimitivePropertyValue<bool>("kited", null).GetValueOrDefault() && awq.f(A_0.g()))
			{
				dl3 dl = dgk.Get<dl3>();
				return !A_0.g().aa().SpecialStates.d && A_0.g().aa().Offense.aa().zo() >= dl.e(new eoj(A_0.g().aa(), null, null)) * 2f;
			}
			return false;
		}

		// Token: 0x0600144C RID: 5196 RVA: 0x00058124 File Offset: 0x00056324
		internal bool b(e1k A_0)
		{
			if (!A_0.d().GetPrimitivePropertyValue<bool>("psiInhibited", new bool?(false)).Value)
			{
				amc amc = new bzv(A_0.c().y6()).g();
				if (amc == null || !awq.a(A_0.g(), amc.a8()))
				{
					dl3 dl = dgk.Get<dl3>();
					return !A_0.g().aa().SpecialStates.d && A_0.g().aa().Offense.aa().zo() >= dl.e(new eoj(A_0.g().aa(), null, null));
				}
			}
			return false;
		}

		// Token: 0x0600144D RID: 5197 RVA: 0x000581E4 File Offset: 0x000563E4
		internal void a(ej0 A_0)
		{
			A_0.b().d()["psiInhibited"] = true;
		}

		// Token: 0x0600144E RID: 5198 RVA: 0x00058204 File Offset: 0x00056404
		internal void b(ej0 A_0)
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

		// Token: 0x04000B1A RID: 2842
		public static readonly etw.a a = new etw.a();

		// Token: 0x04000B1B RID: 2843
		public static Func<e1k, object> b;

		// Token: 0x04000B1C RID: 2844
		public static Func<e1k, bool> c;

		// Token: 0x04000B1D RID: 2845
		public static Action<ej0> d;

		// Token: 0x04000B1E RID: 2846
		public static Func<e1k, bool> e;

		// Token: 0x04000B1F RID: 2847
		public static Func<e1k, bool> f;

		// Token: 0x04000B20 RID: 2848
		public static Action<ej0> g;

		// Token: 0x04000B21 RID: 2849
		public static Action<ej0> h;
	}
}
