using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Ouroboros.Common.Data;
using Ouroboros.Playfield.References;
using TimelapseVertigo.AI.Behaviors.Custom.Xphw;
using TimelapseVertigo.Playfield.Locale;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;

// Token: 0x0200044C RID: 1100
[fe("xphw_gunslinger")]
public sealed class ah9 : b5g
{
	// Token: 0x06001C8C RID: 7308 RVA: 0x0009BD64 File Offset: 0x00099F64
	public ah9(bm6 A_0) : base(A_0)
	{
		List<c96> list = new List<c96>();
		list.Add(new byh("MoveOutOfThePlayersWay", new Func<TimeSpan, double, bool>(this.aj), new Func<TimeSpan, double, cst>(this.ai), new Func<bool, float>(ah9.a.a.q), null)
		{
			e = false
		});
		list.Add(new byh("EquipDefaultEnergyPistol", new Func<TimeSpan, double, bool>(this.ah), new Func<TimeSpan, double, cst>(this.ag), new Func<bool, float>(ah9.a.a.m), null)
		{
			e = true
		});
		list.Add(new byh("EquipEnergyWeapon", new Func<TimeSpan, double, bool>(this.af), new Func<TimeSpan, double, cst>(this.ae), new Func<bool, float>(ah9.a.a.j), null)
		{
			e = true
		});
		list.Add(new b64("EquipShieldEmitter", new Func<TimeSpan, double, bool>(this.ad), new Func<TimeSpan, double, ej1>(this.ac), new Func<bool, float>(ah9.a.a.k), null));
		list.Add(new byh("EquipQuickSlotItems", new Func<TimeSpan, double, bool>(this.ab), new Func<TimeSpan, double, cst>(this.z), new Func<bool, float>(ah9.a.a.h), null)
		{
			e = true
		});
		list.Add(new byh("EnterStealthWithPlayer", new Func<TimeSpan, double, bool>(this.y), new Func<TimeSpan, double, cst>(this.x), new Func<bool, float>(ah9.a.a.e), null)
		{
			e = false
		});
		list.Add(new byh("ExitStealthWithPlayer", new Func<TimeSpan, double, bool>(this.w), new Func<TimeSpan, double, cst>(this.v), new Func<bool, float>(ah9.a.a.i), null)
		{
			e = false
		});
		list.Add(new byh("TurnOnEnergyShieldWithPlayer", new Func<TimeSpan, double, bool>(this.u), new Func<TimeSpan, double, cst>(this.t), new Func<bool, float>(ah9.a.a.f), null)
		{
			e = false
		});
		list.Add(new byh("TurnOffEnergyShieldWithPlayer", new Func<TimeSpan, double, bool>(this.s), new Func<TimeSpan, double, cst>(this.r), new Func<bool, float>(ah9.a.a.d), null)
		{
			e = false
		});
		list.Add(new byh("AvoidEngagingEnemies", new Func<TimeSpan, double, bool>(this.q), new Func<TimeSpan, double, cst>(this.p), new Func<bool, float>(ah9.a.a.b), null)
		{
			e = false
		});
		list.Add(new byh("EngageEnemiesAtWill", new Func<TimeSpan, double, bool>(this.o), new Func<TimeSpan, double, cst>(ah9.a.a.a), new Func<bool, float>(ah9.a.a.p), null)
		{
			e = false
		});
		list.Add(new byh("ConsumeFood", new Func<TimeSpan, double, bool>(this.n), new Func<TimeSpan, double, cst>(this.m), new Func<bool, float>(ah9.a.a.a), null)
		{
			e = false
		});
		list.Add(new byh("ReplenishEnergyCells", new Func<TimeSpan, double, bool>(this.l), new Func<TimeSpan, double, cst>(this.k), new Func<bool, float>(ah9.a.a.l), null)
		{
			e = false
		});
		list.Add(new byh("RepairEquipment", new Func<TimeSpan, double, bool>(this.j), new Func<TimeSpan, double, cst>(this.i), new Func<bool, float>(ah9.a.a.r), null)
		{
			e = false
		});
		list.Add(new byh("RetryComment", new Func<TimeSpan, double, bool>(this.h), new Func<TimeSpan, double, cst>(this.g), new Func<bool, float>(ah9.a.a.g), null)
		{
			e = false
		});
		list.Add(new byh("IdleCustomWeaponAnimation", new Func<TimeSpan, double, bool>(this.f), new Func<TimeSpan, double, cst>(this.e), new Func<bool, float>(ah9.a.a.c), null)
		{
			f = false
		});
		list.Add(new b64("FirstFightTryComment", new Func<TimeSpan, double, bool>(this.d), new Func<TimeSpan, double, ej1>(this.c), new Func<bool, float>(ah9.a.a.n), null));
		list.Add(new b64("TryIdleComment", new Func<TimeSpan, double, bool>(this.b), new Func<TimeSpan, double, ej1>(this.a), new Func<bool, float>(ah9.a.a.o), null));
		base.a(list);
	}

	// Token: 0x06001C8D RID: 7309 RVA: 0x0009C348 File Offset: 0x0009A548
	[CompilerGenerated]
	private bool aj(TimeSpan A_0, double A_1)
	{
		return this.Subject.y6().GetPrimitivePropertyValue<bool>(c29.h, new bool?(false)).Value;
	}

	// Token: 0x06001C8E RID: 7310 RVA: 0x0009C378 File Offset: 0x0009A578
	[CompilerGenerated]
	private cst ai(TimeSpan A_0, double A_1)
	{
		cnk service = bpo.GetService<cnk>();
		if (service.aqu() != null)
		{
			ak1 ak = g8.a(this.Subject, service.aqu().v().b() as c5x, 2);
			if (ak != null)
			{
				this.Subject.a8().k.b.a(ak, 0.0, 1, 0, true);
			}
			this.Subject.y6().RemoveProperty(c29.h);
		}
		return null;
	}

	// Token: 0x06001C8F RID: 7311 RVA: 0x0009C400 File Offset: 0x0009A600
	[CompilerGenerated]
	private bool ah(TimeSpan A_0, double A_1)
	{
		amc amc = base.h();
		if (amc != null && amc.aa().Offense.au() != WeaponKey.Primary && amc.aa().Gear.j()[WeaponKey.Secondary].Item == null)
		{
			foreach (coh coh in Enumerable.ToList<coh>(amc.aa().Bag.z2()))
			{
				cd1 cd = coh as cd1;
				if (cd != null && cd.TypedDefinition.ae() != null && euf.a(cd.TypedDefinition.ae().Value, WeaponAggregateSubtype.EnergyPistol))
				{
					return false;
				}
			}
			return true;
		}
		return false;
	}

	// Token: 0x06001C90 RID: 7312 RVA: 0x0009C4F4 File Offset: 0x0009A6F4
	[CompilerGenerated]
	private cst ag(TimeSpan A_0, double A_1)
	{
		amc amc = base.h();
		if (amc != null)
		{
			amc.aa().Offense.a(WeaponKey.Primary);
			if (amc.aa().Gear.j()[WeaponKey.Primary].Item.Battery <= 0.0)
			{
				amc.aa().Gear.j()[WeaponKey.Primary].Item.Battery = (double)amc.aa().Gear.j()[WeaponKey.Primary].Item.MaxBattery;
			}
		}
		return null;
	}

	// Token: 0x06001C91 RID: 7313 RVA: 0x0009C590 File Offset: 0x0009A790
	[CompilerGenerated]
	private bool af(TimeSpan A_0, double A_1)
	{
		amc amc = base.h();
		if (amc != null && amc.aa().Gear.j()[WeaponKey.Secondary].Item == null)
		{
			foreach (coh coh in Enumerable.ToList<coh>(amc.aa().Bag.z2()))
			{
				cd1 cd = coh as cd1;
				if (cd != null && cd.TypedDefinition.ae() != null && euf.a(cd.TypedDefinition.ae().Value, WeaponAggregateSubtype.EnergyPistol))
				{
					return true;
				}
			}
			return false;
		}
		return false;
	}

	// Token: 0x06001C92 RID: 7314 RVA: 0x0009C66C File Offset: 0x0009A86C
	[CompilerGenerated]
	private cst ae(TimeSpan A_0, double A_1)
	{
		amc amc = base.h();
		if (amc != null)
		{
			foreach (coh coh in Enumerable.ToList<coh>(amc.aa().Bag.z2()))
			{
				cd1 cd = coh as cd1;
				if (cd != null && cd.TypedDefinition.ae() != null && euf.a(cd.TypedDefinition.ae().Value, WeaponAggregateSubtype.EnergyPistol))
				{
					amc.aa().Gear.j()[WeaponKey.Secondary].Item = cd;
					amc.aa().Bag.z5(cd);
					amc.aa().Offense.a(WeaponKey.Secondary);
					if (amc.aa().Gear.j()[WeaponKey.Secondary].Item.Battery <= 0.0)
					{
						amc.aa().Gear.j()[WeaponKey.Secondary].Item.Battery = (double)amc.aa().Gear.j()[WeaponKey.Secondary].Item.MaxBattery;
					}
					return null;
				}
			}
		}
		return null;
	}

	// Token: 0x06001C93 RID: 7315 RVA: 0x0009C7E4 File Offset: 0x0009A9E4
	[CompilerGenerated]
	private bool ad(TimeSpan A_0, double A_1)
	{
		amc amc = base.h();
		if (amc != null)
		{
			if (amc.aa().Gear.h().Item == null)
			{
				using (List<coh>.Enumerator enumerator = Enumerable.ToList<coh>(amc.aa().Bag.z2()).GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						coh coh = enumerator.Current;
						if (coh is cgd && !coh.Stealable)
						{
							return true;
						}
					}
					return false;
				}
			}
			if (!amc.aa().Gear.h().Item.Stealable)
			{
				using (List<coh>.Enumerator enumerator = amc.aa().Bag.z2().GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (enumerator.Current is cgd)
						{
							return true;
						}
					}
				}
				return false;
			}
			return false;
		}
		return false;
	}

	// Token: 0x06001C94 RID: 7316 RVA: 0x0009C908 File Offset: 0x0009AB08
	[CompilerGenerated]
	private ej1 ac(TimeSpan A_0, double A_1)
	{
		amc amc = base.h();
		if (amc != null)
		{
			foreach (coh coh in amc.aa().Bag.z2())
			{
				if (coh is cgd)
				{
					if (amc.aa().Gear.h().Item != null)
					{
						amc.aa().Bag.z3(amc.aa().Gear.h().Item, true);
						amc.aa().Gear.h().a(null, true);
					}
					amc.aa().Gear.h().po(coh);
					amc.aa().Bag.z5(coh);
					return ej1.b;
				}
			}
			return ej1.b;
		}
		return ej1.b;
	}

	// Token: 0x06001C95 RID: 7317 RVA: 0x0009CA0C File Offset: 0x0009AC0C
	[CompilerGenerated]
	private bool ab(TimeSpan A_0, double A_1)
	{
		amc amc = base.h();
		if (amc != null)
		{
			foreach (coh coh in Enumerable.ToList<coh>(amc.aa().Bag.z2()))
			{
				if (coh is acz || (coh.Definition != null && coh.Definition.v))
				{
					return bn.a(amc.aa()) != null;
				}
			}
			return false;
		}
		return false;
	}

	// Token: 0x06001C96 RID: 7318 RVA: 0x0009CAC0 File Offset: 0x0009ACC0
	[CompilerGenerated]
	private cst z(TimeSpan A_0, double A_1)
	{
		amc amc = base.h();
		if (amc != null)
		{
			foreach (coh coh in Enumerable.ToList<coh>(amc.aa().Bag.z2()))
			{
				if (coh is acz || (coh.Definition != null && coh.Definition.v))
				{
					int? num = bn.a(amc.aa());
					if (num != null)
					{
						a6p aspect = this.Subject.a8().GetAspect<a6p>();
						if (aspect != null && !aspect.d().Contains("-utility"))
						{
							aspect.d().Add("-utility");
						}
						amc.aa().Gear.d()[num.Value].Item = coh;
						amc.aa().Bag.z5(coh);
					}
				}
			}
		}
		return null;
	}

	// Token: 0x06001C97 RID: 7319 RVA: 0x0009CBE4 File Offset: 0x0009ADE4
	[CompilerGenerated]
	private bool y(TimeSpan A_0, double A_1)
	{
		amc amc = base.h();
		if (amc != null && this.Subject.y6().GetPrimitivePropertyValue<bool>(c29.e, new bool?(false)).Value && !amc.aa().IsInCombat && amc.aa().SpecialAbilities.a(typeof(e5b)))
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null)
			{
				blk blk = new bzv(this.Subject.y6()).c((serviceOrThrow.aqu().v().b() as c5x).qe());
				if (blk != null && blk.b() && serviceOrThrow.aqu().v().SpecialStates.g)
				{
					this.Subject.y6()[ddq.ba] = true;
					if (!amc.aa().SpecialStates.g)
					{
						amc.aa().Cooldowns.a(e5b.d);
						bl6 bl = ecf.a(dgk.Get<e5b>(), new eru(new EntityAspectReference<amc, amc>(base.h())), null) as bl6;
						if (bl != null && bl.yw())
						{
							return true;
						}
					}
				}
			}
		}
		return false;
	}

	// Token: 0x06001C98 RID: 7320 RVA: 0x0009CD40 File Offset: 0x0009AF40
	[CompilerGenerated]
	private cst x(TimeSpan A_0, double A_1)
	{
		bl6 bl = ecf.a(dgk.Get<e5b>(), new eru(new EntityAspectReference<amc, amc>(base.h())), null) as bl6;
		if (bl != null && bl.yw())
		{
			return cp.a(bl, this.Subject.a8(), false);
		}
		return null;
	}

	// Token: 0x06001C99 RID: 7321 RVA: 0x0009CD94 File Offset: 0x0009AF94
	[CompilerGenerated]
	private bool w(TimeSpan A_0, double A_1)
	{
		amc amc = base.h();
		if (amc != null && this.Subject.y6().GetPrimitivePropertyValue<bool>(c29.e, new bool?(false)).Value && this.Subject.y6().GetPrimitivePropertyValue<bool>(ddq.ba, new bool?(false)).Value && amc.aa().SpecialStates.g && !amc.aa().IsInCombat && amc.aa().SpecialAbilities.a(typeof(e5b)))
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null)
			{
				blk blk = new bzv(this.Subject.y6()).c((serviceOrThrow.aqu().v().b() as c5x).qe());
				if (blk != null && blk.b() && !serviceOrThrow.aqu().v().SpecialStates.g)
				{
					bl6 bl = ecf.a(dgk.Get<e5b>(), new eru(new EntityAspectReference<amc, amc>(base.h())), null) as bl6;
					if (bl != null && bl.yw())
					{
						return true;
					}
				}
			}
		}
		return false;
	}

	// Token: 0x06001C9A RID: 7322 RVA: 0x0009CEE8 File Offset: 0x0009B0E8
	[CompilerGenerated]
	private cst v(TimeSpan A_0, double A_1)
	{
		bl6 bl = ecf.a(dgk.Get<e5b>(), new eru(new EntityAspectReference<amc, amc>(base.h())), null) as bl6;
		if (bl != null && bl.yw())
		{
			return cp.a(bl, this.Subject.a8(), false);
		}
		return null;
	}

	// Token: 0x06001C9B RID: 7323 RVA: 0x0009CF3C File Offset: 0x0009B13C
	[CompilerGenerated]
	private bool u(TimeSpan A_0, double A_1)
	{
		if (this.Subject.y6().GetPrimitivePropertyValue<bool>(c29.d, new bool?(false)).Value && !base.h().aa().Defense.i4() && !base.h().aa().IsInCombat)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null)
			{
				blk blk = new bzv(this.Subject.y6()).c((serviceOrThrow.aqu().v().b() as c5x).qe());
				return blk != null && blk.b() && serviceOrThrow.aqu().v().Defense.i4();
			}
		}
		return false;
	}

	// Token: 0x06001C9C RID: 7324 RVA: 0x0009D00C File Offset: 0x0009B20C
	[CompilerGenerated]
	private cst t(TimeSpan A_0, double A_1)
	{
		if (base.h().aa().Gear.h().Item != null)
		{
			base.h().aa().Defense.a(true);
		}
		this.Subject.y6()[ddq.br] = TimeSpan.MaxValue;
		return null;
	}

	// Token: 0x06001C9D RID: 7325 RVA: 0x0009D070 File Offset: 0x0009B270
	[CompilerGenerated]
	private bool s(TimeSpan A_0, double A_1)
	{
		if (this.Subject.y6().GetPrimitivePropertyValue<bool>(c29.d, new bool?(false)).Value && base.h().aa().Defense.i4() && !base.h().aa().IsInCombat)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null)
			{
				blk blk = new bzv(this.Subject.y6()).c((serviceOrThrow.aqu().v().b() as c5x).qe());
				return blk != null && blk.b() && !serviceOrThrow.aqu().v().Defense.i4();
			}
		}
		return false;
	}

	// Token: 0x06001C9E RID: 7326 RVA: 0x0009D144 File Offset: 0x0009B344
	[CompilerGenerated]
	private cst r(TimeSpan A_0, double A_1)
	{
		if (base.h().aa().Gear.h().Item != null)
		{
			base.h().aa().Defense.a(false);
		}
		this.Subject.y6()[ddq.br] = TimeSpan.Zero;
		return null;
	}

	// Token: 0x06001C9F RID: 7327 RVA: 0x0009D1A8 File Offset: 0x0009B3A8
	[CompilerGenerated]
	private bool q(TimeSpan A_0, double A_1)
	{
		if (!base.h().aa().IsInCombat && this.Subject.y6().GetPrimitivePropertyValue<bool>(c29.f, new bool?(false)).Value)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null)
			{
				foreach (cky cky in new List<cky>
				{
					serviceOrThrow.aqu().ac().abu(asp.go, asp.gq),
					serviceOrThrow.aqu().ac().abu(asp.go, asp.bw),
					serviceOrThrow.aqu().ac().abu(asp.go, asp.a0),
					serviceOrThrow.aqu().ac().abu(asp.go, asp.gr)
				})
				{
					if (cky != null && cky.a == global::h.a)
					{
						return true;
					}
				}
				return false;
			}
		}
		return false;
	}

	// Token: 0x06001CA0 RID: 7328 RVA: 0x0009D2E4 File Offset: 0x0009B4E4
	[CompilerGenerated]
	private cst p(TimeSpan A_0, double A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			bv9 bv = serviceOrThrow.aqu().ac() as bv9;
			foreach (string text in new string[]
			{
				asp.gq,
				asp.gr,
				asp.bw,
				asp.a0
			})
			{
				bv.a(asp.go, text, global::h.b, null, false, false, false);
				base.h().aa().c(text);
			}
			bv.a(asp.go, asp.a, global::h.e, new h?(global::h.a), true, false, false);
		}
		return null;
	}

	// Token: 0x06001CA1 RID: 7329 RVA: 0x0009D3A0 File Offset: 0x0009B5A0
	[CompilerGenerated]
	private bool o(TimeSpan A_0, double A_1)
	{
		if (!base.h().aa().IsInCombat && !this.Subject.y6().GetPrimitivePropertyValue<bool>(c29.f, new bool?(false)).Value)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null)
			{
				foreach (cky cky in new List<cky>
				{
					serviceOrThrow.aqu().ac().abu(asp.go, asp.gq),
					serviceOrThrow.aqu().ac().abu(asp.go, asp.bw),
					serviceOrThrow.aqu().ac().abu(asp.go, asp.a0),
					serviceOrThrow.aqu().ac().abu(asp.go, asp.gr)
				})
				{
					if (cky != null && cky.a != global::h.a)
					{
						return true;
					}
				}
				return false;
			}
		}
		return false;
	}

	// Token: 0x06001CA2 RID: 7330 RVA: 0x0009D4DC File Offset: 0x0009B6DC
	[CompilerGenerated]
	private bool n(TimeSpan A_0, double A_1)
	{
		if (this.Subject.a8().Zone.y8().StartsWith("xphw_exoBase") && this.Subject.a8().Zone.y8().StartsWith("xphw_darkTer"))
		{
			amc amc = base.h();
			if (amc != null)
			{
				return Enumerable.FirstOrDefault<coh>(Enumerable.Where<coh>(amc.aa().Bag.z2(), new Func<coh, bool>(ah9.a.a.a))) != null;
			}
		}
		return false;
	}

	// Token: 0x06001CA3 RID: 7331 RVA: 0x0009D580 File Offset: 0x0009B780
	[CompilerGenerated]
	private cst m(TimeSpan A_0, double A_1)
	{
		amc amc = base.h();
		coh coh = Enumerable.FirstOrDefault<coh>(Enumerable.Where<coh>(amc.aa().Bag.z2(), new Func<coh, bool>(ah9.a.a.b)));
		if (coh != null)
		{
			b0p b0p = dgk.Get<b0p>();
			if (b0p != null)
			{
				eu7 eu = ecf.a(b0p, new eru(new EntityAspectReference<amc, amc>(amc)), coh) as eu7;
				if (eu != null && eu.yw())
				{
					d7o.a(Xphw_GunslingerCommentCodeEnum.Food_Repeatable, false, false);
					return cp.b(eu, amc.a8(), amc.a8());
				}
			}
		}
		return null;
	}

	// Token: 0x06001CA4 RID: 7332 RVA: 0x0009D62C File Offset: 0x0009B82C
	[CompilerGenerated]
	private bool l(TimeSpan A_0, double A_1)
	{
		amc amc = base.h();
		if ((amc != null && amc.aa().a("Battery.FusionCell", false) == null) || amc.aa().a("Battery.FusionCell", false).Stacks < 10)
		{
			TimeSpan? timeSpan = new TimeSpan?(base.GetCortexProperty<TimeSpan>(c29.g, default(TimeSpan)));
			return timeSpan == null || timeSpan.Value <= A_0;
		}
		return false;
	}

	// Token: 0x06001CA5 RID: 7333 RVA: 0x0009D6B4 File Offset: 0x0009B8B4
	[CompilerGenerated]
	private cst k(TimeSpan A_0, double A_1)
	{
		this.Subject.y6()[c29.g] = A_0 + TimeSpan.FromSeconds((double)cuo.a.Next(5, 10));
		d48 d = new d48(ez2.CreateDefinitonProvider<sz>("expendables\\energySources\\FusionCell"));
		if (d != null)
		{
			d.Stealable = false;
			amc amc = base.h();
			if (amc != null)
			{
				amc.aa().a("Battery.FusionCell", false).Stealable = false;
				amc.aa().Bag.z3(d, true);
			}
		}
		return null;
	}

	// Token: 0x06001CA6 RID: 7334 RVA: 0x0009D748 File Offset: 0x0009B948
	[CompilerGenerated]
	private bool j(TimeSpan A_0, double A_1)
	{
		amc amc = base.h();
		if (amc != null)
		{
			foreach (coh coh in amc.aa().Gear.i())
			{
				if (coh.Durability <= (double)coh.MaxDurability * 0.3)
				{
					return true;
				}
			}
			return false;
		}
		return false;
	}

	// Token: 0x06001CA7 RID: 7335 RVA: 0x0009D7D8 File Offset: 0x0009B9D8
	[CompilerGenerated]
	private cst i(TimeSpan A_0, double A_1)
	{
		amc amc = base.h();
		if (amc != null)
		{
			foreach (coh coh in amc.aa().Gear.i())
			{
				if (coh.Durability <= (double)coh.MaxDurability * 0.3)
				{
					coh.Durability = (double)coh.MaxDurability * 0.9;
				}
			}
		}
		return null;
	}

	// Token: 0x06001CA8 RID: 7336 RVA: 0x0009D878 File Offset: 0x0009BA78
	[CompilerGenerated]
	private bool h(TimeSpan A_0, double A_1)
	{
		foreach (Property property in this.Subject.y6().Properties)
		{
			if (property != null && !string.IsNullOrEmpty(property.Name) && property.Name.StartsWith(c29.n))
			{
				int num = property.Name.IndexOf("_");
				if (num != -1 && num != property.Name.Length - 1)
				{
					string value = property.Name.Substring(num + 1);
					if (property.Value != null && (TimeSpan)property.Value < A_0)
					{
						this.Subject.y6()[c29.m] = value;
						return true;
					}
				}
			}
		}
		return false;
	}

	// Token: 0x06001CA9 RID: 7337 RVA: 0x0009D980 File Offset: 0x0009BB80
	[CompilerGenerated]
	private cst g(TimeSpan A_0, double A_1)
	{
		string classPropertyValue = this.Subject.y6().GetClassPropertyValue<string>(c29.m);
		if (!string.IsNullOrEmpty(classPropertyValue))
		{
			d7o.a(classPropertyValue, true);
		}
		return null;
	}

	// Token: 0x06001CAA RID: 7338 RVA: 0x0009D9B8 File Offset: 0x0009BBB8
	[CompilerGenerated]
	private bool f(TimeSpan A_0, double A_1)
	{
		if (!base.h().aa().IsInCombat && base.h().aa().IsInControl && d3k.a(base.h().aa()))
		{
			if (this.Subject.y6().HasProperty(ddq.w) && this.Subject.y6().GetPrimitivePropertyValue<CharacterState>(ddq.w, null).GetValueOrDefault() == CharacterState.Custom1)
			{
				return false;
			}
			TimeSpan? primitivePropertyValue = this.Subject.y6().GetPrimitivePropertyValue<TimeSpan>(c29.i, null);
			if (primitivePropertyValue == null)
			{
				this.Subject.y6()[c29.i] = A_0 + TimeSpan.FromSeconds((double)(15 + cuo.a.Next(15)));
				return false;
			}
			if (primitivePropertyValue.Value <= A_0)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06001CAB RID: 7339 RVA: 0x0009DAC4 File Offset: 0x0009BCC4
	[CompilerGenerated]
	private cst e(TimeSpan A_0, double A_1)
	{
		this.Subject.y6()[c29.i] = A_0 + TimeSpan.FromSeconds((double)(15 + cuo.a.Next(15)));
		amc amc = base.h();
		if (amc != null && this.Subject.a8().i.b != null && this.Subject.a8().i.b.a() == null && amc.aa().Offense.u() != null && amc.aa().Offense.u().TypedDefinition.ae() != null)
		{
			awx awx = new awx();
			awx awx2 = awx;
			awx2.a(awx2.kh() | m7.b);
			int num = 120;
			if (euf.a(amc.aa().Offense.u().TypedDefinition.ae().Value, WeaponAggregateSubtype.EnergyPistol))
			{
				awx.ad().Add(new bm3(50));
				List<auv> list = awx.ad();
				amc b = this.Subject.a8().h.b;
				CharacterState a_ = CharacterState.Custom2;
				int a_2 = num;
				int a_3 = 0;
				int a_4 = cuo.a.Next(1, 3);
				list.Add(new e4t(b, a_, a_2, a_3, null, a_4));
			}
			if (Enumerable.Any<auv>(awx.ad()))
			{
				return awx;
			}
		}
		return null;
	}

	// Token: 0x06001CAC RID: 7340 RVA: 0x0009DC34 File Offset: 0x0009BE34
	[CompilerGenerated]
	private bool d(TimeSpan A_0, double A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqw() != null && serviceOrThrow.aqw().y8().Equals("xphw_exobase_tun") && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("faction_xphw_exoBase_entered", new bool?(false)).Value && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("faction_xphw_exoBase_exosoldiers_stopDeployment", new bool?(false)).Value)
		{
			List<Xphw_GunslingerCommentCodeEnum> classPropertyValue = this.Subject.y6().GetClassPropertyValue<List<Xphw_GunslingerCommentCodeEnum>>(c29.l);
			if (classPropertyValue == null || !classPropertyValue.Contains(Xphw_GunslingerCommentCodeEnum.Combat_FirstFightEnded))
			{
				d02 service = bpo.GetService<d02>();
				if (service != null)
				{
					using (List<d4n>.Enumerator enumerator = Enumerable.ToList<d4n>(service.ahl()).GetEnumerator())
					{
						if (enumerator.MoveNext())
						{
							d4n d4n = enumerator.Current;
							if (d4n.b != null && d4n.b.a8() != null && !d4n.b.aa().Dead && (d4n.b.aa().FactionId == asp.gq || d4n.b.aa().FactionId == asp.gr))
							{
								return false;
							}
							return d7o.a(Xphw_GunslingerCommentCodeEnum.Combat_FirstFightEnded, true, true);
						}
					}
					return false;
				}
			}
		}
		return false;
	}

	// Token: 0x06001CAD RID: 7341 RVA: 0x0009DDD8 File Offset: 0x0009BFD8
	[CompilerGenerated]
	private new ej1 c(TimeSpan A_0, double A_1)
	{
		if (base.h() != null)
		{
			d7o.a(Xphw_GunslingerCommentCodeEnum.Combat_FirstFightEnded, true, false);
		}
		return ej1.b;
	}

	// Token: 0x06001CAE RID: 7342 RVA: 0x0009DDF0 File Offset: 0x0009BFF0
	[CompilerGenerated]
	private bool b(TimeSpan A_0, double A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqw() != null && serviceOrThrow.aqw().y8().StartsWith("xphw_exobase") && !serviceOrThrow.aqw().y8().EndsWith("lab2") && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_xphw_gunslinger_followPlayer", new bool?(false)).Value)
		{
			TimeSpan? primitivePropertyValue = this.Subject.y6().GetPrimitivePropertyValue<TimeSpan>(c29.p, null);
			if (primitivePropertyValue == null || primitivePropertyValue.Value <= A_0)
			{
				if (this.Subject.y6().HasProperty(ddq.ay))
				{
					string text = this.Subject.y6().GetClassPropertyValue<bt4>(ddq.ay).b();
					if (!string.IsNullOrEmpty(text) && text.StartsWith("xphw_gunslinger_"))
					{
						return true;
					}
				}
				if (this.Subject.y6().HasProperty(ddq.k))
				{
					List<string> classPropertyValue = this.Subject.y6().GetClassPropertyValue<List<string>>(ddq.k);
					if (classPropertyValue != null && Enumerable.Any<string>(classPropertyValue))
					{
						using (List<string>.Enumerator enumerator = classPropertyValue.GetEnumerator())
						{
							while (enumerator.MoveNext())
							{
								if (enumerator.Current.StartsWith("xphw_gunslinger_"))
								{
									return true;
								}
							}
						}
						return false;
					}
				}
			}
		}
		return false;
	}

	// Token: 0x06001CAF RID: 7343 RVA: 0x0009DFA8 File Offset: 0x0009C1A8
	[CompilerGenerated]
	private ej1 a(TimeSpan A_0, double A_1)
	{
		if (this.Subject.y6().GetPrimitivePropertyValue<TimeSpan>(c29.p, null) == null)
		{
			this.Subject.y6()[c29.p] = A_0 + TimeSpan.FromSeconds((double)cuo.a.Next(6, 15));
			return ej1.b;
		}
		if (base.h() != null)
		{
			string text = eth.b(this.Subject);
			if (!string.IsNullOrEmpty(text) && text.Contains("_animated"))
			{
				d7o.a(Xphw_GunslingerCommentCodeEnum.IdleCommentAnimated_Repeatable, false, false);
			}
			else
			{
				d7o.a(Xphw_GunslingerCommentCodeEnum.IdleComment_Repeatable, false, false);
			}
			this.Subject.y6()[c29.p] = A_0 + TimeSpan.FromSeconds((double)cuo.a.Next(15, 25));
		}
		return ej1.b;
	}

	// Token: 0x0200044D RID: 1101
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06001CB2 RID: 7346 RVA: 0x0009E0AC File Offset: 0x0009C2AC
		internal float q(bool A_0)
		{
			return 3f;
		}

		// Token: 0x06001CB3 RID: 7347 RVA: 0x0009E0B4 File Offset: 0x0009C2B4
		internal float m(bool A_0)
		{
			return 0.9f;
		}

		// Token: 0x06001CB4 RID: 7348 RVA: 0x0009E0BC File Offset: 0x0009C2BC
		internal float j(bool A_0)
		{
			return 0.95f;
		}

		// Token: 0x06001CB5 RID: 7349 RVA: 0x0009E0C4 File Offset: 0x0009C2C4
		internal float k(bool A_0)
		{
			return 0.95f;
		}

		// Token: 0x06001CB6 RID: 7350 RVA: 0x0009E0CC File Offset: 0x0009C2CC
		internal float h(bool A_0)
		{
			return 0.95f;
		}

		// Token: 0x06001CB7 RID: 7351 RVA: 0x0009E0D4 File Offset: 0x0009C2D4
		internal float e(bool A_0)
		{
			return 0.95f;
		}

		// Token: 0x06001CB8 RID: 7352 RVA: 0x0009E0DC File Offset: 0x0009C2DC
		internal float i(bool A_0)
		{
			return 0.95f;
		}

		// Token: 0x06001CB9 RID: 7353 RVA: 0x0009E0E4 File Offset: 0x0009C2E4
		internal float f(bool A_0)
		{
			return 0.95f;
		}

		// Token: 0x06001CBA RID: 7354 RVA: 0x0009E0EC File Offset: 0x0009C2EC
		internal float d(bool A_0)
		{
			return 0.95f;
		}

		// Token: 0x06001CBB RID: 7355 RVA: 0x0009E0F4 File Offset: 0x0009C2F4
		internal float b(bool A_0)
		{
			return 4f;
		}

		// Token: 0x06001CBC RID: 7356 RVA: 0x0009E0FC File Offset: 0x0009C2FC
		internal cst a(TimeSpan A_0, double A_1)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null)
			{
				foreach (string a_ in new string[]
				{
					asp.gq,
					asp.gr,
					asp.bw,
					asp.a0
				})
				{
					(serviceOrThrow.aqu().ac() as bv9).a(asp.go, a_, global::h.a, null, false, false, false);
				}
			}
			return null;
		}

		// Token: 0x06001CBD RID: 7357 RVA: 0x0009E188 File Offset: 0x0009C388
		internal float p(bool A_0)
		{
			return 4f;
		}

		// Token: 0x06001CBE RID: 7358 RVA: 0x0009E190 File Offset: 0x0009C390
		internal bool a(coh A_0)
		{
			return A_0.Definition is a3e;
		}

		// Token: 0x06001CBF RID: 7359 RVA: 0x0009E1A0 File Offset: 0x0009C3A0
		internal bool b(coh A_0)
		{
			return A_0.Definition is a3e;
		}

		// Token: 0x06001CC0 RID: 7360 RVA: 0x0009E1B0 File Offset: 0x0009C3B0
		internal float a(bool A_0)
		{
			return 0.82f;
		}

		// Token: 0x06001CC1 RID: 7361 RVA: 0x0009E1B8 File Offset: 0x0009C3B8
		internal float l(bool A_0)
		{
			return 0.81f;
		}

		// Token: 0x06001CC2 RID: 7362 RVA: 0x0009E1C0 File Offset: 0x0009C3C0
		internal float r(bool A_0)
		{
			return 0.8f;
		}

		// Token: 0x06001CC3 RID: 7363 RVA: 0x0009E1C8 File Offset: 0x0009C3C8
		internal float g(bool A_0)
		{
			return 0.8f;
		}

		// Token: 0x06001CC4 RID: 7364 RVA: 0x0009E1D0 File Offset: 0x0009C3D0
		internal float c(bool A_0)
		{
			return 0.7f;
		}

		// Token: 0x06001CC5 RID: 7365 RVA: 0x0009E1D8 File Offset: 0x0009C3D8
		internal float n(bool A_0)
		{
			return 0.7f;
		}

		// Token: 0x06001CC6 RID: 7366 RVA: 0x0009E1E0 File Offset: 0x0009C3E0
		internal float o(bool A_0)
		{
			return 0.7f;
		}

		// Token: 0x04000FCD RID: 4045
		public static readonly ah9.a a = new ah9.a();

		// Token: 0x04000FCE RID: 4046
		public static Func<bool, float> b;

		// Token: 0x04000FCF RID: 4047
		public static Func<bool, float> c;

		// Token: 0x04000FD0 RID: 4048
		public static Func<bool, float> d;

		// Token: 0x04000FD1 RID: 4049
		public static Func<bool, float> e;

		// Token: 0x04000FD2 RID: 4050
		public static Func<bool, float> f;

		// Token: 0x04000FD3 RID: 4051
		public static Func<bool, float> g;

		// Token: 0x04000FD4 RID: 4052
		public static Func<bool, float> h;

		// Token: 0x04000FD5 RID: 4053
		public static Func<bool, float> i;

		// Token: 0x04000FD6 RID: 4054
		public static Func<bool, float> j;

		// Token: 0x04000FD7 RID: 4055
		public static Func<bool, float> k;

		// Token: 0x04000FD8 RID: 4056
		public static Func<TimeSpan, double, cst> l;

		// Token: 0x04000FD9 RID: 4057
		public static Func<bool, float> m;

		// Token: 0x04000FDA RID: 4058
		public static Func<coh, bool> n;

		// Token: 0x04000FDB RID: 4059
		public static Func<coh, bool> o;

		// Token: 0x04000FDC RID: 4060
		public static Func<bool, float> p;

		// Token: 0x04000FDD RID: 4061
		public static Func<bool, float> q;

		// Token: 0x04000FDE RID: 4062
		public static Func<bool, float> r;

		// Token: 0x04000FDF RID: 4063
		public static Func<bool, float> s;

		// Token: 0x04000FE0 RID: 4064
		public static Func<bool, float> t;

		// Token: 0x04000FE1 RID: 4065
		public static Func<bool, float> u;

		// Token: 0x04000FE2 RID: 4066
		public static Func<bool, float> v;
	}
}
