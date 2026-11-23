using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Ouroboros.Playfield.References;
using TimelapseVertigo.Rules.Comm;

// Token: 0x020003A7 RID: 935
[fe("soldier")]
public class bwv : ua
{
	// Token: 0x0600199E RID: 6558 RVA: 0x00087A0C File Offset: 0x00085C0C
	public virtual int or()
	{
		return 15000;
	}

	// Token: 0x0600199F RID: 6559 RVA: 0x00087A14 File Offset: 0x00085C14
	public bwv(bm6 A_0) : base("SoldierBehavior", A_0)
	{
		List<c96> list = new List<c96>();
		list.Add(new b64("Start shield turning off countdown", new Func<TimeSpan, double, bool>(this.ar), new Func<TimeSpan, double, ej1>(this.aq), new Func<bool, float>(bwv.a.a.u), null));
		list.Add(new b64("Turn off shield", new Func<TimeSpan, double, bool>(this.ap), new Func<TimeSpan, double, ej1>(this.ao), new Func<bool, float>(bwv.a.a.a), null));
		string a_ = "CombatNearEnemies";
		List<c96> list2 = new List<c96>();
		string a_2 = "FocusPrimaryTarget";
		List<c96> list3 = new List<c96>();
		list3.Add(new b64("Turn on shield", new Func<TimeSpan, double, bool>(this.an), new Func<TimeSpan, double, ej1>(this.am), new Func<bool, float>(bwv.a.a.q), null));
		list3.Add(new cta("AutoAttackCurrentTarget"));
		list3.Add(new byh("SneakUponEnemy", new Func<TimeSpan, double, bool>(this.al), new Func<TimeSpan, double, cst>(this.ak), new Func<bool, float>(bwv.a.a.k), null)
		{
			e = false
		});
		list3.Add(new rv("GiveUpOnTarget", 180, this.or()));
		list2.Add(new e8n(a_2, list3));
		list2.Add(new chi("ChangeTargetActivity"));
		list.Add(new efs(a_, list2));
		list.Add(new byh("EnterStealth", new Func<TimeSpan, double, bool>(this.aj), new Func<TimeSpan, double, cst>(this.ai), new Func<bool, float>(bwv.a.a.l), null)
		{
			e = false
		});
		list.Add(new byh("UseOnce", new Func<TimeSpan, double, bool>(this.ah), new Func<TimeSpan, double, cst>(this.ag), new Func<bool, float>(bwv.a.a.h), null)
		{
			e = true
		});
		list.Add(new b64("WaitOut", new Func<TimeSpan, double, bool>(this.af), new Func<TimeSpan, double, ej1>(bwv.a.a.a), new Func<bool, float>(bwv.a.a.o), null));
		list.Add(new byh("DisarmTrap", new Func<TimeSpan, double, bool>(this.ae), new Func<TimeSpan, double, cst>(this.ad), new Func<bool, float>(bwv.a.a.f), null)
		{
			e = false
		});
		list.Add(new byh("DisarmGasGrenade", new Func<TimeSpan, double, bool>(this.ac), new Func<TimeSpan, double, cst>(this.ab), new Func<bool, float>(bwv.a.a.e), null)
		{
			e = false
		});
		list.Add(new byh("Init dialog", new Func<TimeSpan, double, bool>(this.z), new Func<TimeSpan, double, cst>(this.y), new Func<bool, float>(bwv.a.a.i), null)
		{
			e = false
		});
		list.Add(new byh("Open Power Box (Multiple)", new Func<TimeSpan, double, bool>(this.x), new Func<TimeSpan, double, cst>(this.w), new Func<bool, float>(bwv.a.a.r), null)
		{
			e = false
		});
		list.Add(new byh("Close Power Box (Multiple)", new Func<TimeSpan, double, bool>(this.v), new Func<TimeSpan, double, cst>(this.u), new Func<bool, float>(bwv.a.a.s), null)
		{
			e = false
		});
		list.Add(new byh("Turn Power On/Off (Multiple)", new Func<TimeSpan, double, bool>(this.t), new Func<TimeSpan, double, cst>(this.s), new Func<bool, float>(bwv.a.a.n), null)
		{
			e = false
		});
		list.Add(new byh("Open Power Box", new Func<TimeSpan, double, bool>(this.r), new Func<TimeSpan, double, cst>(this.q), new Func<bool, float>(bwv.a.a.t), null)
		{
			e = false
		});
		list.Add(new byh("Turn Power On/Off", new Func<TimeSpan, double, bool>(this.p), new Func<TimeSpan, double, cst>(this.o), new Func<bool, float>(bwv.a.a.b), null)
		{
			e = false
		});
		string a_3 = "FulfillNoiseBackupRequest";
		Func<TimeSpan, double, bool> a_4 = new Func<TimeSpan, double, bool>(this.n);
		Func<bool, float> a_5 = new Func<bool, float>(bwv.a.a.p);
		List<c96> list4 = new List<c96>();
		list4.Add(new b64("ChangeBackupLocation", new Func<TimeSpan, double, bool>(this.m), new Func<TimeSpan, double, ej1>(this.l), new Func<bool, float>(bwv.a.a.m), null));
		list4.Add(new ere("RangedBackup", new Func<TimeSpan, double, bool>(this.k), new Func<bool, float>(bwv.a.a.c), new List<c96>
		{
			new ceq("TrekToBackupLoc", new Func<TimeSpan, double, ak1>(this.j))
			{
				f = dnw.c,
				c = 5,
				d = 1000,
				b = double.MaxValue,
				c = new Action<TimeSpan, double>(this.i),
				b = new Action<TimeSpan, double>(this.h),
				e = 3000
			}
		}));
		list4.Add(new ere("MeleeBackup", new Func<TimeSpan, double, bool>(bwv.a.a.b), new Func<bool, float>(bwv.a.a.g), new List<c96>
		{
			new ceq("TrekToBackupLoc", new Func<TimeSpan, double, ak1>(this.g))
			{
				f = dnw.b,
				c = 5,
				d = 1000,
				b = double.MaxValue,
				c = new Action<TimeSpan, double>(this.f),
				b = new Action<TimeSpan, double>(this.e),
				e = 3000
			}
		}));
		list.Add(new ere(a_3, a_4, a_5, list4));
		list.Add(new byh("FlareTheStealthedPlayer", new Func<TimeSpan, double, bool>(this.d), new Func<TimeSpan, double, cst>(this.c), new Func<bool, float>(bwv.a.a.j), null)
		{
			e = false
		});
		list.Add(new b64("ReactToBeingAlertedToPlayerStealthing", new Func<TimeSpan, double, bool>(this.b), new Func<TimeSpan, double, ej1>(this.a), new Func<bool, float>(bwv.a.a.d), null));
		list.Add(new aqs("FollowTarget")
		{
			c = 0.52f
		});
		list.Add(new e1y("IdleMovement", true, new List<c96>
		{
			new e7y("IdleMoveToTile")
			{
				c = 0.75f,
				a = 7000
			},
			new aif("RestActivity")
		})
		{
			c = 0.51f
		});
		list.Add(new aif("Rest"));
		base.a(list);
	}

	// Token: 0x060019A0 RID: 6560 RVA: 0x00088294 File Offset: 0x00086494
	private c5x a(c5x A_0)
	{
		if (A_0 != null)
		{
			return Enumerable.FirstOrDefault<b0b>(Enumerable.Where<b0b>(Enumerable.First<ak1>(A_0.l).c.Values, new Func<b0b, bool>(bwv.a.a.a))) as c5x;
		}
		return null;
	}

	// Token: 0x060019A1 RID: 6561 RVA: 0x000882F0 File Offset: 0x000864F0
	[CompilerGenerated]
	private bool ar(TimeSpan A_0, double A_1)
	{
		amc amc = base.h();
		TimeSpan? primitivePropertyValue = this.Subject.y6().GetPrimitivePropertyValue<TimeSpan>(ddq.br, null);
		return amc.aa().Defense.i4() && !amc.aa().IsInCombat && amc.aa().Gear.h().Item != null && primitivePropertyValue == null;
	}

	// Token: 0x060019A2 RID: 6562 RVA: 0x00088374 File Offset: 0x00086574
	[CompilerGenerated]
	private ej1 aq(TimeSpan A_0, double A_1)
	{
		this.Subject.y6()[ddq.br] = A_0 + TimeSpan.FromSeconds(15.0);
		return ej1.b;
	}

	// Token: 0x060019A3 RID: 6563 RVA: 0x000883B0 File Offset: 0x000865B0
	[CompilerGenerated]
	private bool ap(TimeSpan A_0, double A_1)
	{
		amc amc = base.h();
		if (amc.aa().Defense.i4() && !amc.aa().IsInCombat && amc.aa().Gear.h().Item != null)
		{
			TimeSpan? primitivePropertyValue = this.Subject.y6().GetPrimitivePropertyValue<TimeSpan>(ddq.br, null);
			if (primitivePropertyValue != null && primitivePropertyValue.Value < A_0)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060019A4 RID: 6564 RVA: 0x00088444 File Offset: 0x00086644
	[CompilerGenerated]
	private ej1 ao(TimeSpan A_0, double A_1)
	{
		base.h().aa().Defense.a(false);
		return ej1.b;
	}

	// Token: 0x060019A5 RID: 6565 RVA: 0x00088468 File Offset: 0x00086668
	[CompilerGenerated]
	private bool an(TimeSpan A_0, double A_1)
	{
		amc amc = base.h();
		if (!amc.aa().Defense.i4() && amc.aa().IsInCombat && amc.aa().Gear.h().Item != null && amc.aa().Gear.h().Item.MaxBattery > 0 && amc.aa().Vehicle == null)
		{
			ip ip = amc.aa().Cooldowns.b(d7f.d);
			return ip == null || ip.a <= 0.0;
		}
		return false;
	}

	// Token: 0x060019A6 RID: 6566 RVA: 0x00088520 File Offset: 0x00086720
	[CompilerGenerated]
	private ej1 am(TimeSpan A_0, double A_1)
	{
		base.h().aa().Defense.a(true);
		return ej1.b;
	}

	// Token: 0x060019A7 RID: 6567 RVA: 0x00088544 File Offset: 0x00086744
	[CompilerGenerated]
	private bool al(TimeSpan A_0, double A_1)
	{
		return base.h().aa().SpecialStates.g && (this.Subject.y6().GetPrimitivePropertyValue<bool>(ddq.a9, new bool?(false)).Value || this.Subject.ad().GetPrimitivePropertyValue<bool>(ddq.a9, new bool?(false)).Value);
	}

	// Token: 0x060019A8 RID: 6568 RVA: 0x000885C0 File Offset: 0x000867C0
	[CompilerGenerated]
	private cst ak(TimeSpan A_0, double A_1)
	{
		amc amc = new bzv(this.Subject.y6()).g();
		if (amc != null && amc.a8() != null)
		{
			ale b = this.Subject.a8().k.b;
			if (b != null)
			{
				return b.a(amc.a8(), base.h().aa().Offense.u().TypedDefinition.ad() + 1f, 1, 0);
			}
		}
		return null;
	}

	// Token: 0x060019A9 RID: 6569 RVA: 0x00088648 File Offset: 0x00086848
	[CompilerGenerated]
	private bool aj(TimeSpan A_0, double A_1)
	{
		if (!this.Subject.y6().GetPrimitivePropertyValue<bool>(ddq.ba, new bool?(false)).Value)
		{
			double value = this.Subject.ad().GetPrimitivePropertyValue<double>("StealtherChance", new double?((double)1)).Value;
			if (value < 1.0)
			{
				cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
				int num;
				if (serviceOrThrow.aqu() != null)
				{
					num = serviceOrThrow.aqu().l();
				}
				else
				{
					num = 0;
				}
				num = num / 2 + this.Subject.a8().qe().GetHashCode() / 2;
				if (new Random(num).NextDouble() > value)
				{
					return false;
				}
			}
			amc amc = base.h();
			if (!amc.aa().SpecialStates.g && !amc.aa().IsInCombat && amc.aa().SpecialAbilities.a(typeof(e5b)))
			{
				bl6 bl = ecf.a(dgk.Get<e5b>(), new eru(new EntityAspectReference<amc, amc>(amc)), null) as bl6;
				if (bl != null && bl.yw())
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x060019AA RID: 6570 RVA: 0x00088798 File Offset: 0x00086998
	[CompilerGenerated]
	private cst ai(TimeSpan A_0, double A_1)
	{
		amc amc = base.h();
		if (!amc.aa().SpecialStates.g)
		{
			bl6 bl = ecf.a(dgk.Get<e5b>(), new eru(new EntityAspectReference<amc, amc>(amc)), null) as bl6;
			if (bl != null && bl.yw())
			{
				return cp.a(bl, amc.a8(), false);
			}
		}
		return null;
	}

	// Token: 0x060019AB RID: 6571 RVA: 0x00088800 File Offset: 0x00086A00
	[CompilerGenerated]
	private bool ah(TimeSpan A_0, double A_1)
	{
		if (base.h().aa().IsInControl)
		{
			ar7 classPropertyValue = this.Subject.y6().GetClassPropertyValue<ar7>(ddq.b1);
			if (classPropertyValue != null && classPropertyValue.ao() != null && (classPropertyValue.ao() as c5x).s.b != null)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060019AC RID: 6572 RVA: 0x00088868 File Offset: 0x00086A68
	[CompilerGenerated]
	private cst ag(TimeSpan A_0, double A_1)
	{
		if (base.h().aa().IsInControl)
		{
			ar7 classPropertyValue = this.Subject.y6().GetClassPropertyValue<ar7>(ddq.b1);
			if (classPropertyValue != null && classPropertyValue.ao() != null)
			{
				c5x c5x = classPropertyValue.ao() as c5x;
				if (c5x.s.b != null)
				{
					awx awx = new awx();
					awx.a(m7.b);
					ale aspect = this.Subject.a8().GetAspect<ale>();
					if (aspect != null)
					{
						awx awx2 = aspect.a(classPropertyValue.ao(), c5x.s.b.t(), 1, false, null);
						awx.ad().AddRange(awx2.ad());
					}
					else
					{
						awx.ad().Add(new b9t(this.Subject.a8(), c5x.s.b, null));
					}
					List<auv> list = awx.ad();
					hx hx = new hx();
					hx.a(new List<string>
					{
						ddq.b1
					});
					list.Add(new a4s(hx, null, new ar7(this.Subject.a8()), null));
					return awx;
				}
			}
		}
		return null;
	}

	// Token: 0x060019AD RID: 6573 RVA: 0x00088990 File Offset: 0x00086B90
	[CompilerGenerated]
	private bool af(TimeSpan A_0, double A_1)
	{
		return !base.h().aa().IsInControl;
	}

	// Token: 0x060019AE RID: 6574 RVA: 0x000889A8 File Offset: 0x00086BA8
	[CompilerGenerated]
	private bool ae(TimeSpan A_0, double A_1)
	{
		if (this.Subject.a8().h.b != null && !this.Subject.a8().h.b.aa().IsInCombat && this.Subject.a8().h.b.aa().b(d8o.b | d8o.d | d8o.h))
		{
			int num = this.Subject.a8().h.b.aa().Skills.Get<c0b>().g();
			if (num >= 5)
			{
				ed2 ed = this.Subject.b(num);
				if (ed != null && ed.f == asp.a && ed.d <= num)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x060019AF RID: 6575 RVA: 0x00088A84 File Offset: 0x00086C84
	[CompilerGenerated]
	private cst ad(TimeSpan A_0, double A_1)
	{
		int num = this.Subject.a8().h.b.aa().Skills.Get<c0b>().g();
		if (num >= 5)
		{
			ed2 ed = this.Subject.b(num);
			if (ed != null && ed.f == asp.a)
			{
				c3n c3n = dgk.Get<bb3>();
				if (c3n != null)
				{
					eu7 eu = ecf.a(c3n, new eru(new EntityAspectReference<amc, amc>(this.Subject.a8().h.b)), null) as eu7;
					if (eu != null && eu.yw())
					{
						return cp.b(eu, this.Subject.a8(), ed.a8());
					}
				}
			}
		}
		return null;
	}

	// Token: 0x060019B0 RID: 6576 RVA: 0x00088B4C File Offset: 0x00086D4C
	[CompilerGenerated]
	private bool ac(TimeSpan A_0, double A_1)
	{
		if (this.Subject.a8().h.b != null && !this.Subject.a8().h.b.aa().IsInCombat && this.Subject.a8().h.b.aa().b(d8o.b | d8o.d | d8o.h) && this.Subject.a8().k.b != null)
		{
			yp yp = this.Subject.aa();
			if (yp != null)
			{
				if (yp.a == null)
				{
					return true;
				}
				if (yp.a == base.h().aa().FactionId)
				{
					return false;
				}
				cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
				if (serviceOrThrow != null && serviceOrThrow.aqu() != null && base.h().aa().a(serviceOrThrow.aqu().ac(), yp.a) != global::h.e)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x060019B1 RID: 6577 RVA: 0x00088C5C File Offset: 0x00086E5C
	[CompilerGenerated]
	private cst ab(TimeSpan A_0, double A_1)
	{
		yp yp = this.Subject.aa();
		if (yp != null)
		{
			c3n c3n = dgk.Get<ax9>();
			if (c3n != null)
			{
				eu7 eu = ecf.a(c3n, new eru(new EntityAspectReference<amc, amc>(this.Subject.a8().h.b)), null) as eu7;
				if (eu != null && eu.yw())
				{
					return cp.b(eu, this.Subject.a8(), yp.a8());
				}
			}
		}
		return null;
	}

	// Token: 0x060019B2 RID: 6578 RVA: 0x00088CE0 File Offset: 0x00086EE0
	[CompilerGenerated]
	private bool z(TimeSpan A_0, double A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		string classPropertyValue = this.Subject.y6().GetClassPropertyValue<string>(ddq.bc);
		bool value = this.Subject.y6().GetPrimitivePropertyValue<bool>(ddq.be, new bool?(false)).Value;
		string classPropertyValue2 = this.Subject.y6().GetClassPropertyValue<string>(ddq.bf);
		if (!string.IsNullOrEmpty(classPropertyValue) && !base.h().aa().IsInCombat && this.Subject.a8().GetAspect<j7>() != null && serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			double value2 = this.Subject.y6().GetPrimitivePropertyValue<double>(ddq.bd, new double?((double)5)).Value;
			if (!c5x.h.b.aa().IsInCombat && c5x.h.b.aa().IsInControl && aw1.b(c5x, this.Subject.a8()) <= value2 && (!serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>(classPropertyValue, new bool?(false)).Value || value))
			{
				if (!string.IsNullOrEmpty(classPropertyValue2))
				{
					TimeSpan? primitivePropertyValue = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<TimeSpan>(classPropertyValue2, null);
					if (primitivePropertyValue != null && primitivePropertyValue.Value > serviceOrThrow.aqu().o())
					{
						return false;
					}
				}
				blk blk = new bzv(this.Subject.y6()).c(serviceOrThrow.aqu().v().b().qe());
				return blk != null && blk.b() && blk.f() > global::h.a;
			}
		}
		return false;
	}

	// Token: 0x060019B3 RID: 6579 RVA: 0x00088F00 File Offset: 0x00087100
	[CompilerGenerated]
	private cst y(TimeSpan A_0, double A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null)
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

	// Token: 0x060019B4 RID: 6580 RVA: 0x00088F88 File Offset: 0x00087188
	[CompilerGenerated]
	private bool x(TimeSpan A_0, double A_1)
	{
		if (this.Subject.a8().GetAspect<ale>() == null)
		{
			return false;
		}
		List<d0h> classPropertyValue = this.Subject.y6().GetClassPropertyValue<List<d0h>>(ddq.bl);
		if (classPropertyValue != null && classPropertyValue.Count > 0)
		{
			for (int i = 0; i < classPropertyValue.Count; i++)
			{
				d0h d0h = classPropertyValue[i];
				c5x c5x;
				if (!string.IsNullOrEmpty(d0h.b))
				{
					c5x = (new ar7(d0h.a, this.Subject.a8().Zone.n(d0h.b)).ao() as c5x);
				}
				else
				{
					c5x = (new ar7(d0h.a, this.Subject.a8().Area).ao() as c5x);
				}
				if (c5x != null)
				{
					axh aspect = c5x.GetAspect<axh>();
					if (aspect != null && (string.IsNullOrEmpty(d0h.d) || !base.GetGlobalProperty<bool>(d0h.d, false)) && base.GetGlobalProperty<bool>(bp5.f(aspect.h()), false) == d0h.c)
					{
						b0e b0e = c5x.GetAspect<bim>() as b0e;
						if (b0e != null && !b0e.q())
						{
							return true;
						}
					}
				}
			}
		}
		return false;
	}

	// Token: 0x060019B5 RID: 6581 RVA: 0x000890D8 File Offset: 0x000872D8
	[CompilerGenerated]
	private cst w(TimeSpan A_0, double A_1)
	{
		ale aspect = this.Subject.a8().GetAspect<ale>();
		if (aspect == null)
		{
			return null;
		}
		List<d0h> classPropertyValue = this.Subject.y6().GetClassPropertyValue<List<d0h>>(ddq.bl);
		if (classPropertyValue != null && classPropertyValue.Count > 0)
		{
			for (int i = 0; i < classPropertyValue.Count; i++)
			{
				d0h d0h = classPropertyValue[i];
				c5x c5x;
				if (!string.IsNullOrEmpty(d0h.b))
				{
					c5x = (new ar7(d0h.a, this.Subject.a8().Zone.n(d0h.b)).ao() as c5x);
				}
				else
				{
					c5x = (new ar7(d0h.a, this.Subject.a8().Area).ao() as c5x);
				}
				if (c5x != null)
				{
					axh aspect2 = c5x.GetAspect<axh>();
					if (aspect2 != null && (string.IsNullOrEmpty(d0h.d) || !base.GetGlobalProperty<bool>(d0h.d, false)) && base.GetGlobalProperty<bool>(bp5.f(aspect2.h()), false) == d0h.c)
					{
						b0e b0e = c5x.GetAspect<bim>() as b0e;
						if (b0e != null && !b0e.q())
						{
							return aspect.b(c5x, c5x.s.b.t(), 1, false, null);
						}
					}
				}
			}
		}
		return null;
	}

	// Token: 0x060019B6 RID: 6582 RVA: 0x0008924C File Offset: 0x0008744C
	[CompilerGenerated]
	private bool v(TimeSpan A_0, double A_1)
	{
		if (this.Subject.a8().GetAspect<ale>() == null)
		{
			return false;
		}
		List<d0h> classPropertyValue = this.Subject.y6().GetClassPropertyValue<List<d0h>>(ddq.bl);
		if (classPropertyValue != null && classPropertyValue.Count > 0)
		{
			for (int i = 0; i < classPropertyValue.Count; i++)
			{
				d0h d0h = classPropertyValue[i];
				c5x c5x;
				if (!string.IsNullOrEmpty(d0h.b))
				{
					c5x = (new ar7(d0h.a, this.Subject.a8().Zone.n(d0h.b)).ao() as c5x);
				}
				else
				{
					c5x = (new ar7(d0h.a, this.Subject.a8().Area).ao() as c5x);
				}
				if (c5x != null && c5x.l.Count > 0)
				{
					if (!this.Subject.a(Enumerable.First<ak1>(c5x.l)))
					{
						return false;
					}
					axh aspect = c5x.GetAspect<axh>();
					if (aspect != null && (string.IsNullOrEmpty(d0h.d) || !base.GetGlobalProperty<bool>(d0h.d, false)) && base.GetGlobalProperty<bool>(bp5.f(aspect.h()), false) != d0h.c)
					{
						b0e b0e = c5x.GetAspect<bim>() as b0e;
						if (b0e != null && b0e.q())
						{
							return true;
						}
					}
				}
			}
		}
		return false;
	}

	// Token: 0x060019B7 RID: 6583 RVA: 0x000893CC File Offset: 0x000875CC
	[CompilerGenerated]
	private cst u(TimeSpan A_0, double A_1)
	{
		ale aspect = this.Subject.a8().GetAspect<ale>();
		if (aspect == null)
		{
			return null;
		}
		List<d0h> classPropertyValue = this.Subject.y6().GetClassPropertyValue<List<d0h>>(ddq.bl);
		if (classPropertyValue != null && classPropertyValue.Count > 0)
		{
			for (int i = 0; i < classPropertyValue.Count; i++)
			{
				d0h d0h = classPropertyValue[i];
				c5x c5x;
				if (!string.IsNullOrEmpty(d0h.b))
				{
					c5x = (new ar7(d0h.a, this.Subject.a8().Zone.n(d0h.b)).ao() as c5x);
				}
				else
				{
					c5x = (new ar7(d0h.a, this.Subject.a8().Area).ao() as c5x);
				}
				if (c5x != null && c5x.l.Count > 0)
				{
					if (!this.Subject.a(Enumerable.First<ak1>(c5x.l)))
					{
						return null;
					}
					axh aspect2 = c5x.GetAspect<axh>();
					if (aspect2 != null && (string.IsNullOrEmpty(d0h.d) || !base.GetGlobalProperty<bool>(d0h.d, false)) && base.GetGlobalProperty<bool>(bp5.f(aspect2.h()), false) != d0h.c)
					{
						b0e b0e = c5x.GetAspect<bim>() as b0e;
						if (b0e != null && b0e.q())
						{
							return aspect.b(c5x, c5x.s.b.t(), 1, false, null);
						}
					}
				}
			}
		}
		return null;
	}

	// Token: 0x060019B8 RID: 6584 RVA: 0x00089570 File Offset: 0x00087770
	[CompilerGenerated]
	private bool t(TimeSpan A_0, double A_1)
	{
		if (this.Subject.a8().GetAspect<ale>() == null)
		{
			return false;
		}
		List<d0h> classPropertyValue = this.Subject.y6().GetClassPropertyValue<List<d0h>>(ddq.bl);
		if (classPropertyValue != null && classPropertyValue.Count > 0)
		{
			for (int i = 0; i < classPropertyValue.Count; i++)
			{
				d0h d0h = classPropertyValue[i];
				c5x c5x;
				if (!string.IsNullOrEmpty(d0h.b))
				{
					c5x = (new ar7(d0h.a, this.Subject.a8().Zone.n(d0h.b)).ao() as c5x);
				}
				else
				{
					c5x = (new ar7(d0h.a, this.Subject.a8().Area).ao() as c5x);
				}
				if (c5x != null)
				{
					axh aspect = c5x.GetAspect<axh>();
					if (aspect != null && (string.IsNullOrEmpty(d0h.d) || !base.GetGlobalProperty<bool>(d0h.d, false)) && base.GetGlobalProperty<bool>(bp5.f(aspect.h()), false) == d0h.c && this.a(c5x) != null)
					{
						return true;
					}
				}
			}
		}
		return false;
	}

	// Token: 0x060019B9 RID: 6585 RVA: 0x000896AC File Offset: 0x000878AC
	[CompilerGenerated]
	private cst s(TimeSpan A_0, double A_1)
	{
		ale aspect = this.Subject.a8().GetAspect<ale>();
		if (aspect == null)
		{
			return null;
		}
		List<d0h> classPropertyValue = this.Subject.y6().GetClassPropertyValue<List<d0h>>(ddq.bl);
		if (classPropertyValue != null && classPropertyValue.Count > 0)
		{
			for (int i = 0; i < classPropertyValue.Count; i++)
			{
				d0h d0h = classPropertyValue[i];
				c5x c5x;
				if (!string.IsNullOrEmpty(d0h.b))
				{
					c5x = (new ar7(d0h.a, this.Subject.a8().Zone.n(d0h.b)).ao() as c5x);
				}
				else
				{
					c5x = (new ar7(d0h.a, this.Subject.a8().Area).ao() as c5x);
				}
				if (c5x != null)
				{
					axh aspect2 = c5x.GetAspect<axh>();
					if (aspect2 != null && (string.IsNullOrEmpty(d0h.d) || !base.GetGlobalProperty<bool>(d0h.d, false)) && base.GetGlobalProperty<bool>(bp5.f(aspect2.h()), false) == d0h.c)
					{
						c5x c5x2 = this.a(c5x);
						if (c5x2 != null)
						{
							return aspect.b(c5x2, c5x2.s.b.t(), 1, false, null);
						}
					}
				}
			}
		}
		return null;
	}

	// Token: 0x060019BA RID: 6586 RVA: 0x00089810 File Offset: 0x00087A10
	[CompilerGenerated]
	private bool r(TimeSpan A_0, double A_1)
	{
		Guid? primitivePropertyValue = this.Subject.y6().GetPrimitivePropertyValue<Guid>(ddq.bi, null);
		if (primitivePropertyValue != null)
		{
			string cortexProperty = base.GetCortexProperty<string>(ddq.bj, null);
			c5x c5x;
			if (!string.IsNullOrEmpty(cortexProperty))
			{
				c5x = (new ar7(primitivePropertyValue.Value, this.Subject.a8().Zone.n(cortexProperty)).ao() as c5x);
			}
			else
			{
				c5x = (new ar7(primitivePropertyValue.Value, this.Subject.a8().Area).ao() as c5x);
			}
			if (c5x != null)
			{
				axh aspect = c5x.GetAspect<axh>();
				if (aspect != null && base.GetGlobalProperty<bool>(bp5.f(aspect.h()), false) == this.Subject.y6().GetPrimitivePropertyValue<bool>(ddq.bk, new bool?(false)).Value)
				{
					b0e b0e = c5x.GetAspect<bim>() as b0e;
					if (b0e != null && !b0e.q())
					{
						return true;
					}
				}
			}
		}
		return false;
	}

	// Token: 0x060019BB RID: 6587 RVA: 0x00089930 File Offset: 0x00087B30
	[CompilerGenerated]
	private cst q(TimeSpan A_0, double A_1)
	{
		ale aspect = this.Subject.a8().GetAspect<ale>();
		Guid? primitivePropertyValue = this.Subject.y6().GetPrimitivePropertyValue<Guid>(ddq.bi, null);
		if (primitivePropertyValue != null)
		{
			string cortexProperty = base.GetCortexProperty<string>(ddq.bj, null);
			c5x c5x;
			if (!string.IsNullOrEmpty(cortexProperty))
			{
				c5x = (new ar7(primitivePropertyValue.Value, this.Subject.a8().Zone.n(cortexProperty)).ao() as c5x);
			}
			else
			{
				c5x = (new ar7(primitivePropertyValue.Value, this.Subject.a8().Area).ao() as c5x);
			}
			if (c5x != null && c5x.s.b != null)
			{
				return aspect.b(c5x, c5x.s.b.t(), 1, false, null);
			}
		}
		return null;
	}

	// Token: 0x060019BC RID: 6588 RVA: 0x00089A24 File Offset: 0x00087C24
	[CompilerGenerated]
	private bool p(TimeSpan A_0, double A_1)
	{
		Guid? primitivePropertyValue = this.Subject.y6().GetPrimitivePropertyValue<Guid>(ddq.bi, null);
		if (primitivePropertyValue != null)
		{
			string cortexProperty = base.GetCortexProperty<string>(ddq.bj, null);
			c5x c5x;
			if (!string.IsNullOrEmpty(cortexProperty))
			{
				c5x = (new ar7(primitivePropertyValue.Value, this.Subject.a8().Zone.n(cortexProperty)).ao() as c5x);
			}
			else
			{
				c5x = (new ar7(primitivePropertyValue.Value, this.Subject.a8().Area).ao() as c5x);
			}
			if (c5x != null)
			{
				axh aspect = c5x.GetAspect<axh>();
				if (aspect != null && base.GetGlobalProperty<bool>(bp5.f(aspect.h()), false) == this.Subject.y6().GetPrimitivePropertyValue<bool>(ddq.bk, new bool?(false)).Value && this.a(c5x) != null)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x060019BD RID: 6589 RVA: 0x00089B30 File Offset: 0x00087D30
	[CompilerGenerated]
	private cst o(TimeSpan A_0, double A_1)
	{
		Guid? primitivePropertyValue = this.Subject.y6().GetPrimitivePropertyValue<Guid>(ddq.bi, null);
		if (primitivePropertyValue != null)
		{
			string cortexProperty = base.GetCortexProperty<string>(ddq.bj, null);
			c5x c5x;
			if (!string.IsNullOrEmpty(cortexProperty))
			{
				c5x = (new ar7(primitivePropertyValue.Value, this.Subject.a8().Zone.n(cortexProperty)).ao() as c5x);
			}
			else
			{
				c5x = (new ar7(primitivePropertyValue.Value, this.Subject.a8().Area).ao() as c5x);
			}
			if (c5x != null)
			{
				c5x c5x2 = this.a(c5x);
				if (c5x2 != null && c5x2.s.b != null)
				{
					return this.Subject.a8().GetAspect<ale>().b(c5x2, c5x2.s.b.t(), 1, false, null);
				}
			}
		}
		return null;
	}

	// Token: 0x060019BE RID: 6590 RVA: 0x00089C30 File Offset: 0x00087E30
	[CompilerGenerated]
	private bool n(TimeSpan A_0, double A_1)
	{
		return eth.f(this.Subject) != null || eth.g(this.Subject) != null;
	}

	// Token: 0x060019BF RID: 6591 RVA: 0x00089C54 File Offset: 0x00087E54
	[CompilerGenerated]
	private bool m(TimeSpan A_0, double A_1)
	{
		ak1 ak = eth.g(this.Subject);
		ak1 ak2 = eth.f(this.Subject);
		return ak2 != null && ak != ak2;
	}

	// Token: 0x060019C0 RID: 6592 RVA: 0x00089C8C File Offset: 0x00087E8C
	[CompilerGenerated]
	private ej1 l(TimeSpan A_0, double A_1)
	{
		if (!base.h().aa().SpecialStates.g)
		{
			a20.a(this.Subject.a8(), null, new CombatSpeakEvent[]
			{
				CombatSpeakEvent.Special_HeardNoise
			});
		}
		this.Subject.y6()[ddq.am] = this.Subject.y6()[ddq.an];
		this.Subject.y6().RemoveProperty(ddq.an);
		return ej1.b;
	}

	// Token: 0x060019C1 RID: 6593 RVA: 0x00089D14 File Offset: 0x00087F14
	[CompilerGenerated]
	private bool k(TimeSpan A_0, double A_1)
	{
		return this.Subject.y6().GetPrimitivePropertyValue<bool>(ddq.aj, new bool?(false)).Value;
	}

	// Token: 0x060019C2 RID: 6594 RVA: 0x00089D44 File Offset: 0x00087F44
	[CompilerGenerated]
	private ak1 j(TimeSpan A_0, double A_1)
	{
		return eth.g(this.Subject);
	}

	// Token: 0x060019C3 RID: 6595 RVA: 0x00089D54 File Offset: 0x00087F54
	[CompilerGenerated]
	private void i(TimeSpan A_0, double A_1)
	{
		eth.e(this.Subject);
	}

	// Token: 0x060019C4 RID: 6596 RVA: 0x00089D64 File Offset: 0x00087F64
	[CompilerGenerated]
	private void h(TimeSpan A_0, double A_1)
	{
		eth.e(this.Subject);
	}

	// Token: 0x060019C5 RID: 6597 RVA: 0x00089D74 File Offset: 0x00087F74
	[CompilerGenerated]
	private ak1 g(TimeSpan A_0, double A_1)
	{
		return eth.g(this.Subject);
	}

	// Token: 0x060019C6 RID: 6598 RVA: 0x00089D84 File Offset: 0x00087F84
	[CompilerGenerated]
	private void f(TimeSpan A_0, double A_1)
	{
		eth.e(this.Subject);
	}

	// Token: 0x060019C7 RID: 6599 RVA: 0x00089D94 File Offset: 0x00087F94
	[CompilerGenerated]
	private void e(TimeSpan A_0, double A_1)
	{
		eth.e(this.Subject);
	}

	// Token: 0x060019C8 RID: 6600 RVA: 0x00089DA4 File Offset: 0x00087FA4
	[CompilerGenerated]
	private bool d(TimeSpan A_0, double A_1)
	{
		bool value = this.Subject.y6().GetPrimitivePropertyValue<bool>(ddq.bb, new bool?(false)).Value;
		if ((ew0.b() || value) && base.h().aa().b(d8o.b | d8o.c | d8o.d))
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null)
			{
				c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
				if (c5x != null && c5x.h.b != null && c5x.h.b.aa().SpecialStates.g)
				{
					amc amc = base.h();
					if (amc.a(c5x.h.b) == global::h.a || value)
					{
						erl erl = new bzv(this.Subject.y6()).d(c5x.qe());
						if (erl != null && erl.f() == cem.c && Enumerable.FirstOrDefault<coh>(amc.aa().Bag.b("flare")) != null)
						{
							return true;
						}
					}
				}
			}
		}
		return false;
	}

	// Token: 0x060019C9 RID: 6601 RVA: 0x00089EF4 File Offset: 0x000880F4
	[CompilerGenerated]
	private new cst c(TimeSpan A_0, double A_1)
	{
		bool value = this.Subject.y6().GetPrimitivePropertyValue<bool>(ddq.bb, new bool?(false)).Value;
		if (ew0.b() || value)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null)
			{
				c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
				if (c5x != null && c5x.h.b != null)
				{
					amc amc = base.h();
					if (amc.a(c5x.h.b) == global::h.a || value)
					{
						erl erl = new bzv(this.Subject.y6()).d(c5x.qe());
						if (erl != null && erl.f() == cem.c)
						{
							coh coh = Enumerable.FirstOrDefault<coh>(amc.aa().Bag.b("flare"));
							if (coh != null)
							{
								c3n c3n = dgk.Get<kh>();
								if (c3n != null)
								{
									ak1 ak = c5x.Area.a(c5x.aj().a());
									if (ak != null)
									{
										eu7 eu = ecf.a(c3n, new eru(new EntityAspectReference<amc, amc>(this.Subject.a8().h.b)), coh) as eu7;
										if (eu != null && eu.yw())
										{
											bt4 value2 = new bt4(c5x.Area.y8(), c5x.Location);
											this.Subject.y6()[ddq.an] = value2;
											return cp.b(eu, this.Subject.a8(), ak);
										}
									}
								}
							}
						}
					}
				}
			}
		}
		return null;
	}

	// Token: 0x060019CA RID: 6602 RVA: 0x0008A0C0 File Offset: 0x000882C0
	[CompilerGenerated]
	private bool b(TimeSpan A_0, double A_1)
	{
		if (ew0.b() && !this.Subject.ad().GetPrimitivePropertyValue<bool>("Civilian", new bool?(false)).Value)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null)
			{
				c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
				if (c5x != null && c5x.h.b != null && base.h().a(c5x.h.b) == global::h.a)
				{
					erl erl = new bzv(this.Subject.y6()).d(c5x.qe());
					if (erl != null && erl.f() == cem.c)
					{
						return true;
					}
				}
			}
		}
		return false;
	}

	// Token: 0x060019CB RID: 6603 RVA: 0x0008A1B0 File Offset: 0x000883B0
	[CompilerGenerated]
	private ej1 a(TimeSpan A_0, double A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (c5x != null && c5x.Area != null && c5x.h.b != null)
			{
				bt4 value = new bt4(c5x.Area.y8(), c5x.Location);
				this.Subject.y6()[ddq.an] = value;
			}
		}
		return ej1.b;
	}

	// Token: 0x02000432 RID: 1074
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06001C20 RID: 7200 RVA: 0x00098EC0 File Offset: 0x000970C0
		internal float u(bool A_0)
		{
			return 100f;
		}

		// Token: 0x06001C21 RID: 7201 RVA: 0x00098EC8 File Offset: 0x000970C8
		internal float a(bool A_0)
		{
			return 100f;
		}

		// Token: 0x06001C22 RID: 7202 RVA: 0x00098ED0 File Offset: 0x000970D0
		internal float q(bool A_0)
		{
			if (!A_0)
			{
				return 0.85f;
			}
			return 100f;
		}

		// Token: 0x06001C23 RID: 7203 RVA: 0x00098EE4 File Offset: 0x000970E4
		internal float k(bool A_0)
		{
			return 0.7f;
		}

		// Token: 0x06001C24 RID: 7204 RVA: 0x00098EEC File Offset: 0x000970EC
		internal float l(bool A_0)
		{
			return 0.95f;
		}

		// Token: 0x06001C25 RID: 7205 RVA: 0x00098EF4 File Offset: 0x000970F4
		internal float h(bool A_0)
		{
			return 0.94f;
		}

		// Token: 0x06001C26 RID: 7206 RVA: 0x00098EFC File Offset: 0x000970FC
		internal ej1 a(TimeSpan A_0, double A_1)
		{
			return ej1.a;
		}

		// Token: 0x06001C27 RID: 7207 RVA: 0x00098F00 File Offset: 0x00097100
		internal float o(bool A_0)
		{
			return float.MaxValue;
		}

		// Token: 0x06001C28 RID: 7208 RVA: 0x00098F08 File Offset: 0x00097108
		internal float f(bool A_0)
		{
			return 0.9f;
		}

		// Token: 0x06001C29 RID: 7209 RVA: 0x00098F10 File Offset: 0x00097110
		internal float e(bool A_0)
		{
			return 0.9f;
		}

		// Token: 0x06001C2A RID: 7210 RVA: 0x00098F18 File Offset: 0x00097118
		internal float i(bool A_0)
		{
			return 3f;
		}

		// Token: 0x06001C2B RID: 7211 RVA: 0x00098F20 File Offset: 0x00097120
		internal float r(bool A_0)
		{
			return 100f;
		}

		// Token: 0x06001C2C RID: 7212 RVA: 0x00098F28 File Offset: 0x00097128
		internal float s(bool A_0)
		{
			return 102f;
		}

		// Token: 0x06001C2D RID: 7213 RVA: 0x00098F30 File Offset: 0x00097130
		internal float n(bool A_0)
		{
			return 101f;
		}

		// Token: 0x06001C2E RID: 7214 RVA: 0x00098F38 File Offset: 0x00097138
		internal float t(bool A_0)
		{
			return 100f;
		}

		// Token: 0x06001C2F RID: 7215 RVA: 0x00098F40 File Offset: 0x00097140
		internal float b(bool A_0)
		{
			return 101f;
		}

		// Token: 0x06001C30 RID: 7216 RVA: 0x00098F48 File Offset: 0x00097148
		internal float p(bool A_0)
		{
			return 0.65f;
		}

		// Token: 0x06001C31 RID: 7217 RVA: 0x00098F50 File Offset: 0x00097150
		internal float m(bool A_0)
		{
			return 2f;
		}

		// Token: 0x06001C32 RID: 7218 RVA: 0x00098F58 File Offset: 0x00097158
		internal float c(bool A_0)
		{
			return 1f;
		}

		// Token: 0x06001C33 RID: 7219 RVA: 0x00098F60 File Offset: 0x00097160
		internal bool b(TimeSpan A_0, double A_1)
		{
			return true;
		}

		// Token: 0x06001C34 RID: 7220 RVA: 0x00098F64 File Offset: 0x00097164
		internal float g(bool A_0)
		{
			return 0.5f;
		}

		// Token: 0x06001C35 RID: 7221 RVA: 0x00098F6C File Offset: 0x0009716C
		internal float j(bool A_0)
		{
			if (!A_0)
			{
				return 0.641f;
			}
			return 1000f;
		}

		// Token: 0x06001C36 RID: 7222 RVA: 0x00098F80 File Offset: 0x00097180
		internal float d(bool A_0)
		{
			return 0.64f;
		}

		// Token: 0x06001C37 RID: 7223 RVA: 0x00098F88 File Offset: 0x00097188
		internal bool a(b0b A_0)
		{
			return A_0.y8() == "Рубильник";
		}

		// Token: 0x04000F94 RID: 3988
		public static readonly bwv.a a = new bwv.a();

		// Token: 0x04000F95 RID: 3989
		public static Func<bool, float> b;

		// Token: 0x04000F96 RID: 3990
		public static Func<bool, float> c;

		// Token: 0x04000F97 RID: 3991
		public static Func<bool, float> d;

		// Token: 0x04000F98 RID: 3992
		public static Func<bool, float> e;

		// Token: 0x04000F99 RID: 3993
		public static Func<bool, float> f;

		// Token: 0x04000F9A RID: 3994
		public static Func<bool, float> g;

		// Token: 0x04000F9B RID: 3995
		public static Func<TimeSpan, double, ej1> h;

		// Token: 0x04000F9C RID: 3996
		public static Func<bool, float> i;

		// Token: 0x04000F9D RID: 3997
		public static Func<bool, float> j;

		// Token: 0x04000F9E RID: 3998
		public static Func<bool, float> k;

		// Token: 0x04000F9F RID: 3999
		public static Func<bool, float> l;

		// Token: 0x04000FA0 RID: 4000
		public static Func<bool, float> m;

		// Token: 0x04000FA1 RID: 4001
		public static Func<bool, float> n;

		// Token: 0x04000FA2 RID: 4002
		public static Func<bool, float> o;

		// Token: 0x04000FA3 RID: 4003
		public static Func<bool, float> p;

		// Token: 0x04000FA4 RID: 4004
		public static Func<bool, float> q;

		// Token: 0x04000FA5 RID: 4005
		public static Func<bool, float> r;

		// Token: 0x04000FA6 RID: 4006
		public static Func<bool, float> s;

		// Token: 0x04000FA7 RID: 4007
		public static Func<bool, float> t;

		// Token: 0x04000FA8 RID: 4008
		public static Func<TimeSpan, double, bool> u;

		// Token: 0x04000FA9 RID: 4009
		public static Func<bool, float> v;

		// Token: 0x04000FAA RID: 4010
		public static Func<bool, float> w;

		// Token: 0x04000FAB RID: 4011
		public static Func<bool, float> x;

		// Token: 0x04000FAC RID: 4012
		public static Func<b0b, bool> y;
	}
}
