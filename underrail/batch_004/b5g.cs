using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Ouroboros.Playfield.References;

// Token: 0x02000393 RID: 915
[fe("humanSoldier")]
public class b5g : am2
{
	// Token: 0x06001948 RID: 6472 RVA: 0x00084EB4 File Offset: 0x000830B4
	public b5g(bm6 A_0) : base(A_0)
	{
		List<c96> list = new List<c96>();
		list.Add(new byh("HealSelf", new Func<TimeSpan, double, bool>(this.w), new Func<TimeSpan, double, cst>(this.v), new Func<bool, float>(b5g.a.a.b), null)
		{
			e = false
		});
		list.Add(new byh("ReloadShield", new Func<TimeSpan, double, bool>(this.u), new Func<TimeSpan, double, cst>(this.t), new Func<bool, float>(b5g.a.a.i), null)
		{
			e = true
		});
		list.Add(new byh("ReloadWeapon", new Func<TimeSpan, double, bool>(this.s), new Func<TimeSpan, double, cst>(this.r), new Func<bool, float>(b5g.a.a.l), null)
		{
			e = false
		});
		list.Add(new byh("RechargeArmor", new Func<TimeSpan, double, bool>(this.q), new Func<TimeSpan, double, cst>(this.p), new Func<bool, float>(b5g.a.a.e), null)
		{
			e = false
		});
		list.Add(new byh("Turn-on Combat Exoskeleton", new Func<TimeSpan, double, bool>(this.o), new Func<TimeSpan, double, cst>(this.n), new Func<bool, float>(b5g.a.a.h), null)
		{
			e = false
		});
		list.Add(new byh("Turn-on Industrial Exoskeleton", new Func<TimeSpan, double, bool>(this.m), new Func<TimeSpan, double, cst>(this.l), new Func<bool, float>(b5g.a.a.a), null)
		{
			e = false
		});
		list.Add(new byh("Turn-on Wireless Charging", new Func<TimeSpan, double, bool>(this.k), new Func<TimeSpan, double, cst>(this.j), new Func<bool, float>(b5g.a.a.g), null)
		{
			e = false
		});
		list.Add(new byh("RechageVehicle", new Func<TimeSpan, double, bool>(this.i), new Func<TimeSpan, double, cst>(this.h), new Func<bool, float>(b5g.a.a.j), null)
		{
			e = false
		});
		list.Add(new b64("ChangeWeapon", new Func<TimeSpan, double, bool>(this.g), new Func<TimeSpan, double, ej1>(this.f), new Func<bool, float>(b5g.a.a.f), null));
		list.Add(new b64("Chill while bartering", new Func<TimeSpan, double, bool>(this.e), new Func<TimeSpan, double, ej1>(b5g.a.a.a), new Func<bool, float>(b5g.a.a.k), null));
		list.Add(new byh("ConsumeFood", new Func<TimeSpan, double, bool>(this.d), new Func<TimeSpan, double, cst>(this.c), new Func<bool, float>(b5g.a.a.c), null)
		{
			e = false
		});
		list.Add(new byh("Smoke Cigar", new Func<TimeSpan, double, bool>(this.b), new Func<TimeSpan, double, cst>(this.a), new Func<bool, float>(b5g.a.a.d), null)
		{
			e = false
		});
		base.a(list);
	}

	// Token: 0x06001949 RID: 6473 RVA: 0x000852B4 File Offset: 0x000834B4
	[CompilerGenerated]
	private bool w(TimeSpan A_0, double A_1)
	{
		return cot.b(this.Subject.a8().h.b);
	}

	// Token: 0x0600194A RID: 6474 RVA: 0x000852D0 File Offset: 0x000834D0
	[CompilerGenerated]
	private cst v(TimeSpan A_0, double A_1)
	{
		return cot.a(this.Subject.a8().h.b);
	}

	// Token: 0x0600194B RID: 6475 RVA: 0x000852F0 File Offset: 0x000834F0
	[CompilerGenerated]
	private bool u(TimeSpan A_0, double A_1)
	{
		amc amc = base.h();
		if (!amc.aa().IsInCombat && amc.aa().Gear.h().Item != null && amc.aa().Gear.h().Item.Battery <= (double)(amc.aa().Gear.h().Item.MaxBattery / 2))
		{
			return Enumerable.ToList<coh>(Enumerable.Where<coh>(amc.aa().Bag.z2(), new Func<coh, bool>(b5g.a.a.a))).Count > 0;
		}
		return false;
	}

	// Token: 0x0600194C RID: 6476 RVA: 0x000853B0 File Offset: 0x000835B0
	[CompilerGenerated]
	private cst t(TimeSpan A_0, double A_1)
	{
		amc amc = base.h();
		return a4d.a(amc.aa().Gear.h().Item, amc.a8());
	}

	// Token: 0x0600194D RID: 6477 RVA: 0x000853E4 File Offset: 0x000835E4
	[CompilerGenerated]
	private bool s(TimeSpan A_0, double A_1)
	{
		return d3k.b(this.Subject.a8().h.b.aa());
	}

	// Token: 0x0600194E RID: 6478 RVA: 0x00085408 File Offset: 0x00083608
	[CompilerGenerated]
	private cst r(TimeSpan A_0, double A_1)
	{
		return d3k.a(this.Subject.a8().h.b.aa(), this.Subject.a8().h.b);
	}

	// Token: 0x0600194F RID: 6479 RVA: 0x0008544C File Offset: 0x0008364C
	[CompilerGenerated]
	private bool q(TimeSpan A_0, double A_1)
	{
		return dqe.a(this.Subject.a8().h.b.aa());
	}

	// Token: 0x06001950 RID: 6480 RVA: 0x00085470 File Offset: 0x00083670
	[CompilerGenerated]
	private cst p(TimeSpan A_0, double A_1)
	{
		return dqe.a(this.Subject.a8().h.b.aa(), this.Subject.a8().h.b);
	}

	// Token: 0x06001951 RID: 6481 RVA: 0x000854B4 File Offset: 0x000836B4
	[CompilerGenerated]
	private bool o(TimeSpan A_0, double A_1)
	{
		efk efk = this.Subject.a8().h.b.aa();
		cgk cgk = efk.Gear.l().Item;
		if (cgk != null && cgk.Definition != null)
		{
			if (Enumerable.Any<aia>(cgk.fu().@as(), new Func<aia, bool>(b5g.a.a.c)) && cgk.Battery > 0.0 && !efk.StatusEffects.a(bzz.a))
			{
				amc a_ = base.h();
				bl6 bl = ecf.a(dgk.Get<bem>(), new eru(new EntityAspectReference<amc, amc>(a_)), null) as bl6;
				if (bl != null && bl.yw())
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x06001952 RID: 6482 RVA: 0x00085598 File Offset: 0x00083798
	[CompilerGenerated]
	private cst n(TimeSpan A_0, double A_1)
	{
		amc amc = base.h();
		if (dgk.Get<bem>() != null)
		{
			bl6 bl = ecf.a(dgk.Get<bem>(), new eru(new EntityAspectReference<amc, amc>(amc)), null) as bl6;
			if (bl != null && bl.yw())
			{
				return cp.a(bl, amc.a8(), false);
			}
		}
		return null;
	}

	// Token: 0x06001953 RID: 6483 RVA: 0x000855F4 File Offset: 0x000837F4
	[CompilerGenerated]
	private bool m(TimeSpan A_0, double A_1)
	{
		efk efk = this.Subject.a8().h.b.aa();
		cgk cgk = efk.Gear.l().Item;
		if (cgk != null && cgk.Definition != null)
		{
			if (Enumerable.Any<aia>(cgk.fu().@as(), new Func<aia, bool>(b5g.a.a.a)) && cgk.Battery > 0.0 && !efk.StatusEffects.a(jg.a))
			{
				amc a_ = base.h();
				bl6 bl = ecf.a(dgk.Get<e6v>(), new eru(new EntityAspectReference<amc, amc>(a_)), null) as bl6;
				if (bl != null && bl.yw())
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x06001954 RID: 6484 RVA: 0x000856D8 File Offset: 0x000838D8
	[CompilerGenerated]
	private cst l(TimeSpan A_0, double A_1)
	{
		amc amc = base.h();
		if (dgk.Get<e6v>() != null)
		{
			bl6 bl = ecf.a(dgk.Get<e6v>(), new eru(new EntityAspectReference<amc, amc>(amc)), null) as bl6;
			if (bl != null && bl.yw())
			{
				return cp.a(bl, amc.a8(), false);
			}
		}
		return null;
	}

	// Token: 0x06001955 RID: 6485 RVA: 0x00085734 File Offset: 0x00083934
	[CompilerGenerated]
	private bool k(TimeSpan A_0, double A_1)
	{
		efk efk = this.Subject.a8().h.b.aa();
		cgk cgk = efk.Gear.l().Item;
		if (cgk != null && cgk.Definition != null)
		{
			if (Enumerable.Any<aia>(cgk.fu().@as(), new Func<aia, bool>(b5g.a.a.b)) && cgk.Battery > 0.0 && !efk.StatusEffects.a(aee.a))
			{
				amc a_ = base.h();
				bl6 bl = ecf.a(dgk.Get<agj>(), new eru(new EntityAspectReference<amc, amc>(a_)), null) as bl6;
				if (bl != null && bl.yw())
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x06001956 RID: 6486 RVA: 0x00085818 File Offset: 0x00083A18
	[CompilerGenerated]
	private cst j(TimeSpan A_0, double A_1)
	{
		amc amc = base.h();
		if (dgk.Get<agj>() != null)
		{
			bl6 bl = ecf.a(dgk.Get<agj>(), new eru(new EntityAspectReference<amc, amc>(amc)), null) as bl6;
			if (bl != null && bl.yw())
			{
				return cp.a(bl, amc.a8(), false);
			}
		}
		return null;
	}

	// Token: 0x06001957 RID: 6487 RVA: 0x00085874 File Offset: 0x00083A74
	[CompilerGenerated]
	private bool i(TimeSpan A_0, double A_1)
	{
		return brf.a(this.Subject.a8().h.b.aa());
	}

	// Token: 0x06001958 RID: 6488 RVA: 0x00085898 File Offset: 0x00083A98
	[CompilerGenerated]
	private cst h(TimeSpan A_0, double A_1)
	{
		return brf.a(this.Subject.a8().h.b.aa(), this.Subject.a8().h.b);
	}

	// Token: 0x06001959 RID: 6489 RVA: 0x000858DC File Offset: 0x00083ADC
	[CompilerGenerated]
	private bool g(TimeSpan A_0, double A_1)
	{
		return d3k.d(this.Subject.a8().h.b.aa(), true);
	}

	// Token: 0x0600195A RID: 6490 RVA: 0x00085900 File Offset: 0x00083B00
	[CompilerGenerated]
	private ej1 f(TimeSpan A_0, double A_1)
	{
		this.Subject.a8().h.b.aa().Offense.k();
		return ej1.b;
	}

	// Token: 0x0600195B RID: 6491 RVA: 0x00085934 File Offset: 0x00083B34
	[CompilerGenerated]
	private bool e(TimeSpan A_0, double A_1)
	{
		dvp aspect = this.Subject.a8().GetAspect<dvp>();
		if (aspect != null)
		{
			ps service = bpo.GetService<ps>();
			if (service != null)
			{
				return service.ak8() as dvp == aspect;
			}
		}
		return false;
	}

	// Token: 0x0600195C RID: 6492 RVA: 0x00085974 File Offset: 0x00083B74
	[CompilerGenerated]
	private bool d(TimeSpan A_0, double A_1)
	{
		efk efk = this.Subject.a8().h.b.aa();
		if (base.GetCortexProperty<bool>(ddq.b2, false) && !efk.StatusEffects.a(c9i.a))
		{
			if (Enumerable.FirstOrDefault<coh>(Enumerable.Where<coh>(efk.Bag.z2(), new Func<coh, bool>(b5g.a.a.b))) != null)
			{
				TimeSpan? cortexProperty = base.GetCortexProperty<TimeSpan?>("ConsumeFoodTimeSpan_Internal", null);
				if (cortexProperty == null)
				{
					int num = (base.GetCortexProperty<int?>(ddq.b4, null) != null) ? base.GetCortexProperty<int>(ddq.b4, 0) : (cuo.a.Next(3, 16) * 1000);
					cortexProperty = new TimeSpan?(A_0 + TimeSpan.FromMilliseconds((double)num));
					this.Subject.y6()["ConsumeFoodTimeSpan_Internal"] = cortexProperty;
				}
				return cortexProperty != null && cortexProperty <= A_0;
			}
		}
		return false;
	}

	// Token: 0x0600195D RID: 6493 RVA: 0x00085AC8 File Offset: 0x00083CC8
	[CompilerGenerated]
	private new cst c(TimeSpan A_0, double A_1)
	{
		amc b = this.Subject.a8().h.b;
		coh coh = null;
		if (base.GetCortexProperty<string>(ddq.b3, null) != null)
		{
			coh = Enumerable.FirstOrDefault<coh>(b.aa().Bag.b(base.GetCortexProperty<string>(ddq.b3, null)));
		}
		else
		{
			List<coh> list = new List<coh>();
			foreach (coh coh2 in b.aa().Bag.z2())
			{
				if (coh2.Definition is a3e)
				{
					list.Add(coh2);
				}
			}
			if (Enumerable.Any<coh>(list))
			{
				coh = list[cuo.a.Next(0, list.Count)];
			}
		}
		if (coh != null)
		{
			double cortexProperty = base.GetCortexProperty<double>(ddq.b5, 1.0);
			b0p b0p = dgk.Get<b0p>();
			if (b0p != null)
			{
				eu7 eu = ecf.a(b0p, new eru(new EntityAspectReference<amc, amc>(b)), coh) as eu7;
				if (eu != null && eu.yw())
				{
					if (cuo.a.NextDouble() >= cortexProperty)
					{
						coh coh3 = coh.fy();
						coh3.Stacks = 1;
						b.aa().Bag.z2().Add(coh3);
					}
					return cp.b(eu, b.a8(), b.a8());
				}
			}
		}
		return null;
	}

	// Token: 0x0600195E RID: 6494 RVA: 0x00085C5C File Offset: 0x00083E5C
	[CompilerGenerated]
	private bool b(TimeSpan A_0, double A_1)
	{
		efk efk = this.Subject.a8().h.b.aa();
		if (base.GetCortexProperty<bool>(ddq.b6, false) && !efk.StatusEffects.a(eys.a))
		{
			TimeSpan? cortexProperty = base.GetCortexProperty<TimeSpan?>("SmokingTimeSpan_Internal", null);
			if (cortexProperty == null)
			{
				cortexProperty = new TimeSpan?(A_0 + TimeSpan.FromMilliseconds((double)(cuo.a.Next(1, 4) * 1000)));
				this.Subject.y6()["SmokingTimeSpan_Internal"] = cortexProperty;
			}
			return cortexProperty != null && cortexProperty <= A_0;
		}
		return false;
	}

	// Token: 0x0600195F RID: 6495 RVA: 0x00085D3C File Offset: 0x00083F3C
	[CompilerGenerated]
	private cst a(TimeSpan A_0, double A_1)
	{
		amc b = this.Subject.a8().h.b;
		coh coh = Enumerable.FirstOrDefault<coh>(b.aa().Bag.b("cigar"));
		coh coh2 = Enumerable.FirstOrDefault<coh>(b.aa().Bag.b("lighter"));
		if (coh != null && coh2 != null)
		{
			double cortexProperty = base.GetCortexProperty<double>(ddq.b7, 1.0);
			eu7 eu = ecf.a(dgk.Get<d1h>(), new eru(new EntityAspectReference<amc, amc>(b)), coh) as eu7;
			if (eu != null && eu.yw())
			{
				if (cuo.a.NextDouble() >= cortexProperty)
				{
					coh coh3 = coh.fy();
					coh3.Stacks = 1;
					b.aa().Bag.z2().Add(coh3);
				}
				return cp.b(eu, b.a8(), b.a8());
			}
		}
		return null;
	}

	// Token: 0x0200042A RID: 1066
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06001BD9 RID: 7129 RVA: 0x00098328 File Offset: 0x00096528
		internal float b(bool A_0)
		{
			if (!A_0)
			{
				return 1.2f;
			}
			return 100f;
		}

		// Token: 0x06001BDA RID: 7130 RVA: 0x0009833C File Offset: 0x0009653C
		internal bool a(coh A_0)
		{
			return A_0.Definition.GetType() == typeof(sz);
		}

		// Token: 0x06001BDB RID: 7131 RVA: 0x00098358 File Offset: 0x00096558
		internal float i(bool A_0)
		{
			if (!A_0)
			{
				return 1.1f;
			}
			return 100f;
		}

		// Token: 0x06001BDC RID: 7132 RVA: 0x0009836C File Offset: 0x0009656C
		internal float l(bool A_0)
		{
			if (!A_0)
			{
				return 1.1f;
			}
			return 100f;
		}

		// Token: 0x06001BDD RID: 7133 RVA: 0x00098380 File Offset: 0x00096580
		internal float e(bool A_0)
		{
			if (!A_0)
			{
				return 1.09f;
			}
			return 100f;
		}

		// Token: 0x06001BDE RID: 7134 RVA: 0x00098394 File Offset: 0x00096594
		internal bool c(aia A_0)
		{
			return A_0.CapabilityFullTypeName == "CombatExoskeletonAura";
		}

		// Token: 0x06001BDF RID: 7135 RVA: 0x000983A8 File Offset: 0x000965A8
		internal float h(bool A_0)
		{
			if (!A_0)
			{
				return 1.08f;
			}
			return 100f;
		}

		// Token: 0x06001BE0 RID: 7136 RVA: 0x000983BC File Offset: 0x000965BC
		internal bool a(aia A_0)
		{
			return A_0.CapabilityFullTypeName == "IndustrialExoskeletonAura";
		}

		// Token: 0x06001BE1 RID: 7137 RVA: 0x000983D0 File Offset: 0x000965D0
		internal float a(bool A_0)
		{
			if (!A_0)
			{
				return 1.08f;
			}
			return 100f;
		}

		// Token: 0x06001BE2 RID: 7138 RVA: 0x000983E4 File Offset: 0x000965E4
		internal bool b(aia A_0)
		{
			return A_0.CapabilityFullTypeName == "WirelessChargingAura";
		}

		// Token: 0x06001BE3 RID: 7139 RVA: 0x000983F8 File Offset: 0x000965F8
		internal float g(bool A_0)
		{
			if (!A_0)
			{
				return 1.08f;
			}
			return 100f;
		}

		// Token: 0x06001BE4 RID: 7140 RVA: 0x0009840C File Offset: 0x0009660C
		internal float j(bool A_0)
		{
			if (!A_0)
			{
				return 1.1f;
			}
			return 100f;
		}

		// Token: 0x06001BE5 RID: 7141 RVA: 0x00098420 File Offset: 0x00096620
		internal float f(bool A_0)
		{
			return 1.1f;
		}

		// Token: 0x06001BE6 RID: 7142 RVA: 0x00098428 File Offset: 0x00096628
		internal ej1 a(TimeSpan A_0, double A_1)
		{
			return ej1.b;
		}

		// Token: 0x06001BE7 RID: 7143 RVA: 0x0009842C File Offset: 0x0009662C
		internal float k(bool A_0)
		{
			return 0.95f;
		}

		// Token: 0x06001BE8 RID: 7144 RVA: 0x00098434 File Offset: 0x00096634
		internal bool b(coh A_0)
		{
			return A_0.Definition is a3e;
		}

		// Token: 0x06001BE9 RID: 7145 RVA: 0x00098444 File Offset: 0x00096644
		internal float c(bool A_0)
		{
			return 0.8f;
		}

		// Token: 0x06001BEA RID: 7146 RVA: 0x0009844C File Offset: 0x0009664C
		internal float d(bool A_0)
		{
			return 0.8f;
		}

		// Token: 0x04000F63 RID: 3939
		public static readonly b5g.a a = new b5g.a();

		// Token: 0x04000F64 RID: 3940
		public static Func<bool, float> b;

		// Token: 0x04000F65 RID: 3941
		public static Func<coh, bool> c;

		// Token: 0x04000F66 RID: 3942
		public static Func<bool, float> d;

		// Token: 0x04000F67 RID: 3943
		public static Func<bool, float> e;

		// Token: 0x04000F68 RID: 3944
		public static Func<bool, float> f;

		// Token: 0x04000F69 RID: 3945
		public static Func<aia, bool> g;

		// Token: 0x04000F6A RID: 3946
		public static Func<bool, float> h;

		// Token: 0x04000F6B RID: 3947
		public static Func<aia, bool> i;

		// Token: 0x04000F6C RID: 3948
		public static Func<bool, float> j;

		// Token: 0x04000F6D RID: 3949
		public static Func<aia, bool> k;

		// Token: 0x04000F6E RID: 3950
		public static Func<bool, float> l;

		// Token: 0x04000F6F RID: 3951
		public static Func<bool, float> m;

		// Token: 0x04000F70 RID: 3952
		public static Func<bool, float> n;

		// Token: 0x04000F71 RID: 3953
		public static Func<TimeSpan, double, ej1> o;

		// Token: 0x04000F72 RID: 3954
		public static Func<bool, float> p;

		// Token: 0x04000F73 RID: 3955
		public static Func<coh, bool> q;

		// Token: 0x04000F74 RID: 3956
		public static Func<bool, float> r;

		// Token: 0x04000F75 RID: 3957
		public static Func<bool, float> s;
	}
}
