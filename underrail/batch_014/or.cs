using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Ouroboros.Playfield.References;
using TimelapseVertigo.Playfield.Locale;
using TimelapseVertigo.Rules.Comm;

// Token: 0x020002AE RID: 686
[apc("kill")]
[apc("soldier")]
public class or : e1k
{
	// Token: 0x06001406 RID: 5126 RVA: 0x00053CC8 File Offset: 0x00051EC8
	public virtual CharacterState? jv()
	{
		return null;
	}

	// Token: 0x06001407 RID: 5127 RVA: 0x00053CE0 File Offset: 0x00051EE0
	public virtual int jx()
	{
		return 0;
	}

	// Token: 0x06001408 RID: 5128 RVA: 0x00053CE4 File Offset: 0x00051EE4
	public virtual string jw()
	{
		return null;
	}

	// Token: 0x06001409 RID: 5129 RVA: 0x00053CE8 File Offset: 0x00051EE8
	public virtual bool jy()
	{
		return false;
	}

	// Token: 0x0600140A RID: 5130 RVA: 0x00053CEC File Offset: 0x00051EEC
	public virtual bool h3()
	{
		return true;
	}

	// Token: 0x170000FC RID: 252
	// (get) Token: 0x0600140B RID: 5131 RVA: 0x00053CF0 File Offset: 0x00051EF0
	// (set) Token: 0x0600140C RID: 5132 RVA: 0x00053CF8 File Offset: 0x00051EF8
	public bool Civilian
	{
		get
		{
			return this.al;
		}
		set
		{
			this.al = value;
		}
	}

	// Token: 0x0600140D RID: 5133 RVA: 0x00053D04 File Offset: 0x00051F04
	public virtual bool cp()
	{
		return false;
	}

	// Token: 0x0600140E RID: 5134 RVA: 0x00053D08 File Offset: 0x00051F08
	public virtual bool m2()
	{
		return false;
	}

	// Token: 0x0600140F RID: 5135 RVA: 0x00053D10 File Offset: 0x00051F10
	public or()
	{
		this.c = new aij();
		this.d = new clo();
		this.e = new vw(new string[]
		{
			"Nb",
			"PriTarAct",
			"PriTarTr",
			"AdjRel"
		});
		this.f = new vw(new string[]
		{
			"PriTarTr"
		});
		this.g = new bd();
		this.h = new cf4();
		this.i = new bq1();
		this.p = new ej0();
		this.q = new ej0();
		this.r = new ej0();
		this.o = new ej0();
		this.m = new ej0();
		this.n = new ej0();
		this.s = new ej0();
		this.t = new a6w(null);
		this.u = new a6w(null);
		this.v = new a6w(null);
		this.w = new a6w(null);
		this.x = new a6w(null);
		this.y = new ej0();
		this.z = new bud();
		this.aa = new fh(new arr[0]);
		this.ab = new ej0();
		this.ac = new a6w(null);
		this.ad = new a6w(null);
		this.ae = new fh(new arr[0]);
		this.af = new ej0();
		this.ag = new a6w(null);
		this.ah = new a6w(null);
		this.ai = new ej0();
		this.aj = new fh(new arr[0]);
		this.ak = new b4a();
		this.s.a = new Action<ej0>(or.a.a.k);
		this.s.a = this.e;
		ej0 ej = new ej0();
		ej.a = new Action<ej0>(or.a.a.j);
		ej.a = this.c;
		this.l = ej;
		ej0 ej2 = new ej0();
		ej2.a = new Action<ej0>(or.a.a.a);
		ej2.a = this.c;
		this.k = ej2;
		arr[] array = new arr[16];
		array[0] = new arr(this.o, new Func<e1k, bool>(or.a.a.f));
		array[1] = new arr(this.k, new Func<e1k, bool>(this.k));
		array[2] = new arr(this.l, new Func<e1k, bool>(this.j));
		array[3] = new arr(this.m, new Func<e1k, bool>(or.a.a.i));
		array[4] = new arr(this.ac, new Func<e1k, bool>(or.a.a.g));
		array[5] = new arr(this.n, new Func<e1k, bool>(or.a.a.h));
		array[6] = new arr(this.c, new Func<e1k, bool>(or.a.a.b));
		array[7] = new arr(this.q, new Func<e1k, bool>(or.a.a.j));
		array[8] = new arr(this.r, new Func<e1k, bool>(or.a.a.e));
		array[9] = new arr(this.ah, new Func<e1k, bool>(or.a.a.a));
		array[10] = new arr(this.v, new Func<e1k, bool>(this.i));
		array[11] = new arr(this.w, new Func<e1k, bool>(this.h));
		array[12] = new arr(this.x, new Func<e1k, bool>(this.g));
		array[13] = new arr(this.t, new Func<e1k, bool>(this.f));
		array[14] = new arr(this.u, new Func<e1k, bool>(this.e));
		array[15] = new arr(this.g, null);
		this.j = new fh(array);
		this.y.a = new Action<ej0>(or.a.a.g);
		this.y.a = this.j;
		this.ai.a = new Action<ej0>(or.a.a.f);
		this.ai.a = this.j;
		this.v.a = new Func<a6w, cst>(this.f);
		this.v.a = this.j;
		this.v.b = this.y;
		this.x.a = new Func<a6w, cst>(this.e);
		this.x.a = this.j;
		this.x.b = this.y;
		this.w.a = new Func<a6w, cst>(this.d);
		this.w.a = this.j;
		this.w.b = this.y;
		this.t.a = new Func<a6w, cst>(or.a.a.a);
		this.t.a = this.j;
		this.t.b = this.y;
		this.u.a = new Func<a6w, cst>(this.c);
		this.u.a = this.j;
		this.u.b = this.y;
		this.ah.a = new Func<a6w, cst>(or.a.a.b);
		this.ah.b = this.ai;
		this.ah.a = this.j;
		this.m.a = new Action<ej0>(or.a.a.b);
		this.m.a = this.j;
		this.n.a = new Action<ej0>(or.a.a.h);
		this.n.a = this.j;
		this.o.a = new Action<ej0>(or.a.a.d);
		this.o.a = this.j;
		this.q.a = new Action<ej0>(or.a.a.c);
		this.q.a = this.j;
		this.r.a = new Action<ej0>(or.a.a.e);
		this.r.a = this.j;
		this.e.a = this.j;
		this.g.a = this.h;
		this.g.b = this.i;
		this.h.a = this.i;
		this.h.b = this.p;
		this.ak.a = this.i;
		this.ak.b = this.p;
		this.f.a = this.aj;
		this.i.b = this.f;
		this.i.a = this.ae;
		this.c.a = this.s;
		this.d.a = this.j;
		this.d.b = this.c;
		this.p.a = new Action<ej0>(this.b);
		this.p.a = this.d;
		base.b(this.e);
		this.z.a.Add(this.ab);
		this.z.a.Add(this.aa);
		this.z.b = new Func<bud, int>(or.a.a.a);
		this.aj.a(new arr[]
		{
			new arr(this.ak, new Func<e1k, bool>(this.d)),
			new arr(this.p, null)
		});
		this.ae.a(new arr[]
		{
			new arr(this.ag, new Func<e1k, bool>(this.c)),
			new arr(this.af, new Func<e1k, bool>(this.b)),
			new arr(this.ad, new Func<e1k, bool>(this.a)),
			new arr(this.z, null)
		});
		fh fh = this.aa;
		arr[] array2 = new arr[3];
		array2[0] = new arr(this.j, new Func<e1k, bool>(or.a.a.c));
		array2[1] = new arr(this.ab, new Func<e1k, bool>(or.a.a.d));
		array2[2] = new arr(this.c, null);
		fh.a(array2);
		this.ab.a = new Action<ej0>(or.a.a.i);
		this.ab.a = this.c;
		this.af.a = new Action<ej0>(this.a);
		this.af.a = this.j;
		this.ag.a = new Func<a6w, cst>(this.b);
		this.ag.a = this.j;
		this.ag.b = this.j;
		this.ac.a = new Func<a6w, cst>(or.a.a.c);
		this.ac.b = this.j;
		this.ac.a = this.j;
		this.ad.a = new Func<a6w, cst>(this.a);
		this.ad.b = this.j;
		this.ad.a = this.j;
		this.c.a.Add(new Action<aij>(or.a.a.a));
	}

	// Token: 0x06001410 RID: 5136 RVA: 0x0005490C File Offset: 0x00052B0C
	public override void jm()
	{
		base.jm();
		if (base.g() != null)
		{
			foreach (ho a_ in base.g().aa().StatusEffects.Get<ho>())
			{
				base.g().aa().StatusEffects.d(a_);
			}
		}
	}

	// Token: 0x06001411 RID: 5137 RVA: 0x00054994 File Offset: 0x00052B94
	protected T GetGlobalProperty<T>(string propName, T defaultValue = default(T))
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			object propertyValue = serviceOrThrow.aqu().r().GetPropertyValue(propName);
			if (propertyValue is T)
			{
				return (T)((object)propertyValue);
			}
		}
		return defaultValue;
	}

	// Token: 0x06001412 RID: 5138 RVA: 0x000549D8 File Offset: 0x00052BD8
	private c5x a(c5x A_0)
	{
		if (A_0 != null)
		{
			return Enumerable.FirstOrDefault<b0b>(Enumerable.Where<b0b>(Enumerable.First<ak1>(A_0.l).c.Values, new Func<b0b, bool>(or.a.a.a))) as c5x;
		}
		return null;
	}

	// Token: 0x06001413 RID: 5139 RVA: 0x00054A34 File Offset: 0x00052C34
	private bool b(amc A_0)
	{
		if (A_0 != null && A_0.a8() != null && A_0.a8().t.b != null)
		{
			foreach (blk blk in new bzv(A_0.a8().t.b.y6()).a().Values)
			{
				if (blk.b() && blk.a().f() == cem.d && blk.e() != null && blk.e().aa().IsInCombat)
				{
					return true;
				}
			}
			return false;
		}
		return false;
	}

	// Token: 0x06001414 RID: 5140 RVA: 0x00054B10 File Offset: 0x00052D10
	public static c5x a(amc A_0)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && A_0 != null && A_0.a8() != null && A_0.a8().t.b != null)
		{
			c5x c5x = null;
			bool flag = false;
			bool flag2 = false;
			double num = 0.0;
			foreach (blk blk in new bzv(A_0.a8().t.b.y6()).a().Values)
			{
				if (blk.e() != null && blk.e().a8() != null && blk.a().f() == cem.d)
				{
					bool flag3 = blk.e().aa().a(serviceOrThrow.aqu().ac(), A_0.aa().FactionId) == global::h.a;
					bool flag4 = blk.b();
					double num2 = aw1.b(A_0.a8(), blk.e().a8());
					if (c5x == null || (flag3 && !flag) || (flag3 == flag && flag4 && !flag2) || (flag3 == flag && flag4 == flag2 && num2 < num))
					{
						c5x = blk.e().a8();
						flag = flag3;
						flag2 = flag4;
						num = num2;
					}
				}
			}
			return c5x;
		}
		return null;
	}

	// Token: 0x06001415 RID: 5141 RVA: 0x00054CA4 File Offset: 0x00052EA4
	protected b0b cz(e1k A_0)
	{
		string classPropertyValue = A_0.c().y6().GetClassPropertyValue<string>(ddq.bz);
		if (!string.IsNullOrEmpty(classPropertyValue))
		{
			if (!(classPropertyValue == "player"))
			{
				return A_0.c().a8().Zone.a().ab5(classPropertyValue);
			}
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null)
			{
				return serviceOrThrow.aqu().v().b();
			}
		}
		return null;
	}

	// Token: 0x06001416 RID: 5142 RVA: 0x00054D34 File Offset: 0x00052F34
	protected float c0(e1k A_0)
	{
		return A_0.c().y6().GetPrimitivePropertyValue<float>(ddq.b0, new float?(3f)).Value;
	}

	// Token: 0x06001417 RID: 5143 RVA: 0x00054D68 File Offset: 0x00052F68
	[CompilerGenerated]
	private bool k(e1k A_0)
	{
		return A_0.g().aa().SpecialStates.i || ((A_0.g().aa().IsInCombat || this.b(A_0.g())) && (this.Civilian || this.cp())) || (Enumerable.FirstOrDefault<afx>(A_0.g().aa().StatusEffects.Get<afx>()) != null && cuo.a.NextDouble() < 0.33);
	}

	// Token: 0x06001418 RID: 5144 RVA: 0x00054E0C File Offset: 0x0005300C
	[CompilerGenerated]
	private bool j(e1k A_0)
	{
		if (this.h3() && (A_0.g().aa().Vehicle == null || (A_0.g().aa().Vehicle.s() & d8o.l) == d8o.a) && A_0.g().aa().Offense.u().TypedDefinition.ad() == as3.bk && A_0.g().aa().Offense.q().TypedDefinition.ad() == as3.bk && !A_0.g().aa().Feats.Contains<c3v>())
		{
			amc amc = new bzv(A_0.c().y6()).g();
			if (amc != null && amc.aa().Vehicle != null && (amc.aa().Vehicle.s() & d8o.l) != d8o.a)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06001419 RID: 5145 RVA: 0x00054F14 File Offset: 0x00053114
	[CompilerGenerated]
	private bool i(e1k A_0)
	{
		if (!A_0.g().aa().IsInCombat && A_0.g().a8().k.b != null && !A_0.d().GetPrimitivePropertyValue<bool>("failedToRestorePower", new bool?(false)).Value)
		{
			List<d0h> classPropertyValue = A_0.c().y6().GetClassPropertyValue<List<d0h>>(ddq.bl);
			if (classPropertyValue != null && classPropertyValue.Count > 0)
			{
				for (int i = 0; i < classPropertyValue.Count; i++)
				{
					d0h d0h = classPropertyValue[i];
					c5x c5x;
					if (!string.IsNullOrEmpty(d0h.b))
					{
						c5x = (new ar7(d0h.a, A_0.c().a8().Zone.n(d0h.b)).ao() as c5x);
					}
					else
					{
						c5x = (new ar7(d0h.a, A_0.c().a8().Area).ao() as c5x);
					}
					if (c5x != null)
					{
						axh aspect = c5x.GetAspect<axh>();
						if (aspect != null && (string.IsNullOrEmpty(d0h.d) || !this.GetGlobalProperty<bool>(d0h.d, false)) && this.GetGlobalProperty<bool>(bp5.f(aspect.h()), false) == d0h.c)
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
		}
		return false;
	}

	// Token: 0x0600141A RID: 5146 RVA: 0x000550A4 File Offset: 0x000532A4
	[CompilerGenerated]
	private bool h(e1k A_0)
	{
		if (!A_0.g().aa().IsInCombat && A_0.g().a8().k.b != null && !A_0.d().GetPrimitivePropertyValue<bool>("failedToRestorePower", new bool?(false)).Value)
		{
			List<d0h> classPropertyValue = A_0.c().y6().GetClassPropertyValue<List<d0h>>(ddq.bl);
			if (classPropertyValue != null && classPropertyValue.Count > 0)
			{
				for (int i = 0; i < classPropertyValue.Count; i++)
				{
					d0h d0h = classPropertyValue[i];
					c5x c5x;
					if (!string.IsNullOrEmpty(d0h.b))
					{
						c5x = (new ar7(d0h.a, A_0.c().a8().Zone.n(d0h.b)).ao() as c5x);
					}
					else
					{
						c5x = (new ar7(d0h.a, A_0.c().a8().Area).ao() as c5x);
					}
					if (c5x != null)
					{
						axh aspect = c5x.GetAspect<axh>();
						if (aspect != null && (string.IsNullOrEmpty(d0h.d) || !this.GetGlobalProperty<bool>(d0h.d, false)) && this.GetGlobalProperty<bool>(bp5.f(aspect.h()), false) == d0h.c && this.a(c5x) != null)
						{
							return true;
						}
					}
				}
			}
		}
		return false;
	}

	// Token: 0x0600141B RID: 5147 RVA: 0x00055220 File Offset: 0x00053420
	[CompilerGenerated]
	private bool g(e1k A_0)
	{
		if (!A_0.g().aa().IsInCombat && A_0.g().a8().k.b != null && !A_0.d().GetPrimitivePropertyValue<bool>("failedToRestorePower", new bool?(false)).Value)
		{
			List<d0h> classPropertyValue = A_0.c().y6().GetClassPropertyValue<List<d0h>>(ddq.bl);
			if (classPropertyValue != null && classPropertyValue.Count > 0)
			{
				for (int i = 0; i < classPropertyValue.Count; i++)
				{
					d0h d0h = classPropertyValue[i];
					c5x c5x;
					if (!string.IsNullOrEmpty(d0h.b))
					{
						c5x = (new ar7(d0h.a, A_0.c().a8().Zone.n(d0h.b)).ao() as c5x);
					}
					else
					{
						c5x = (new ar7(d0h.a, A_0.c().a8().Area).ao() as c5x);
					}
					if (c5x != null && c5x.l.Count > 0)
					{
						if (!A_0.c().a(Enumerable.First<ak1>(c5x.l)))
						{
							return false;
						}
						axh aspect = c5x.GetAspect<axh>();
						if (aspect != null && (string.IsNullOrEmpty(d0h.d) || !this.GetGlobalProperty<bool>(d0h.d, false)) && this.GetGlobalProperty<bool>(bp5.f(aspect.h()), false) != d0h.c)
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
		}
		return false;
	}

	// Token: 0x0600141C RID: 5148 RVA: 0x000553E0 File Offset: 0x000535E0
	[CompilerGenerated]
	private bool f(e1k A_0)
	{
		if (!A_0.g().aa().IsInCombat && A_0.g().a8().k.b != null && !A_0.d().GetPrimitivePropertyValue<bool>("failedToRestorePower", new bool?(false)).Value)
		{
			Guid? primitivePropertyValue = A_0.c().y6().GetPrimitivePropertyValue<Guid>(ddq.bi, null);
			if (primitivePropertyValue != null)
			{
				string classPropertyValue = A_0.c().y6().GetClassPropertyValue<string>(ddq.bj);
				c5x c5x;
				if (!string.IsNullOrEmpty(classPropertyValue))
				{
					c5x = (new ar7(primitivePropertyValue.Value, A_0.g().a8().Zone.n(classPropertyValue)).ao() as c5x);
				}
				else
				{
					c5x = (new ar7(primitivePropertyValue.Value, A_0.g().a8().Area).ao() as c5x);
				}
				if (c5x != null)
				{
					axh aspect = c5x.GetAspect<axh>();
					if (aspect != null && this.GetGlobalProperty<bool>(bp5.f(aspect.h()), false) == A_0.c().y6().GetPrimitivePropertyValue<bool>(ddq.bk, new bool?(false)).Value)
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

	// Token: 0x0600141D RID: 5149 RVA: 0x0005555C File Offset: 0x0005375C
	[CompilerGenerated]
	private bool e(e1k A_0)
	{
		if (!A_0.g().aa().IsInCombat && A_0.g().a8().k.b != null && !A_0.d().GetPrimitivePropertyValue<bool>("failedToRestorePower", new bool?(false)).Value)
		{
			Guid? primitivePropertyValue = A_0.c().y6().GetPrimitivePropertyValue<Guid>(ddq.bi, null);
			if (primitivePropertyValue != null)
			{
				string classPropertyValue = A_0.c().y6().GetClassPropertyValue<string>(ddq.bj);
				c5x c5x;
				if (!string.IsNullOrEmpty(classPropertyValue))
				{
					c5x = (new ar7(primitivePropertyValue.Value, A_0.g().a8().Zone.n(classPropertyValue)).ao() as c5x);
				}
				else
				{
					c5x = (new ar7(primitivePropertyValue.Value, A_0.g().a8().Area).ao() as c5x);
				}
				if (c5x != null)
				{
					axh aspect = c5x.GetAspect<axh>();
					if (aspect != null && this.GetGlobalProperty<bool>(bp5.f(aspect.h()), false) == A_0.c().y6().GetPrimitivePropertyValue<bool>(ddq.bk, new bool?(false)).Value && this.a(c5x) != null)
					{
						return true;
					}
				}
			}
		}
		return false;
	}

	// Token: 0x0600141E RID: 5150 RVA: 0x000556C4 File Offset: 0x000538C4
	[CompilerGenerated]
	private cst f(a6w A_0)
	{
		ale aspect = A_0.b().g().a8().GetAspect<ale>();
		List<d0h> classPropertyValue = A_0.b().c().y6().GetClassPropertyValue<List<d0h>>(ddq.bl);
		if (classPropertyValue != null && classPropertyValue.Count > 0)
		{
			for (int i = 0; i < classPropertyValue.Count; i++)
			{
				d0h d0h = classPropertyValue[i];
				c5x c5x;
				if (!string.IsNullOrEmpty(d0h.b))
				{
					c5x = (new ar7(d0h.a, A_0.b().c().a8().Zone.n(d0h.b)).ao() as c5x);
				}
				else
				{
					c5x = (new ar7(d0h.a, A_0.b().c().a8().Area).ao() as c5x);
				}
				if (c5x != null)
				{
					axh aspect2 = c5x.GetAspect<axh>();
					if (aspect2 != null && (string.IsNullOrEmpty(d0h.d) || !this.GetGlobalProperty<bool>(d0h.d, false)) && this.GetGlobalProperty<bool>(bp5.f(aspect2.h()), false) == d0h.c)
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

	// Token: 0x0600141F RID: 5151 RVA: 0x00055844 File Offset: 0x00053A44
	[CompilerGenerated]
	private cst e(a6w A_0)
	{
		ale aspect = A_0.b().g().a8().GetAspect<ale>();
		List<d0h> classPropertyValue = A_0.b().c().y6().GetClassPropertyValue<List<d0h>>(ddq.bl);
		if (classPropertyValue != null && classPropertyValue.Count > 0)
		{
			for (int i = 0; i < classPropertyValue.Count; i++)
			{
				d0h d0h = classPropertyValue[i];
				c5x c5x;
				if (!string.IsNullOrEmpty(d0h.b))
				{
					c5x = (new ar7(d0h.a, A_0.b().c().a8().Zone.n(d0h.b)).ao() as c5x);
				}
				else
				{
					c5x = (new ar7(d0h.a, A_0.b().c().a8().Area).ao() as c5x);
				}
				if (c5x != null)
				{
					axh aspect2 = c5x.GetAspect<axh>();
					if (aspect2 != null && (string.IsNullOrEmpty(d0h.d) || !this.GetGlobalProperty<bool>(d0h.d, false)) && this.GetGlobalProperty<bool>(bp5.f(aspect2.h()), false) != d0h.c)
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

	// Token: 0x06001420 RID: 5152 RVA: 0x000559C4 File Offset: 0x00053BC4
	[CompilerGenerated]
	private cst d(a6w A_0)
	{
		ale aspect = A_0.b().g().a8().GetAspect<ale>();
		List<d0h> classPropertyValue = A_0.b().c().y6().GetClassPropertyValue<List<d0h>>(ddq.bl);
		if (classPropertyValue != null && classPropertyValue.Count > 0)
		{
			for (int i = 0; i < classPropertyValue.Count; i++)
			{
				d0h d0h = classPropertyValue[i];
				c5x c5x;
				if (!string.IsNullOrEmpty(d0h.b))
				{
					c5x = (new ar7(d0h.a, A_0.b().c().a8().Zone.n(d0h.b)).ao() as c5x);
				}
				else
				{
					c5x = (new ar7(d0h.a, A_0.b().c().a8().Area).ao() as c5x);
				}
				if (c5x != null)
				{
					axh aspect2 = c5x.GetAspect<axh>();
					if (aspect2 != null && (string.IsNullOrEmpty(d0h.d) || !this.GetGlobalProperty<bool>(d0h.d, false)) && this.GetGlobalProperty<bool>(bp5.f(aspect2.h()), false) == d0h.c)
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

	// Token: 0x06001421 RID: 5153 RVA: 0x00055B34 File Offset: 0x00053D34
	[CompilerGenerated]
	private cst c(a6w A_0)
	{
		Guid? primitivePropertyValue = A_0.b().c().y6().GetPrimitivePropertyValue<Guid>(ddq.bi, null);
		if (primitivePropertyValue != null)
		{
			string classPropertyValue = A_0.b().c().y6().GetClassPropertyValue<string>(ddq.bj);
			c5x c5x;
			if (!string.IsNullOrEmpty(classPropertyValue))
			{
				c5x = (new ar7(primitivePropertyValue.Value, A_0.b().g().a8().Zone.n(classPropertyValue)).ao() as c5x);
			}
			else
			{
				c5x = (new ar7(primitivePropertyValue.Value, A_0.b().g().a8().Area).ao() as c5x);
			}
			if (c5x != null)
			{
				c5x c5x2 = this.a(c5x);
				if (c5x2 != null && c5x2.s.b != null)
				{
					return A_0.b().g().a8().GetAspect<ale>().b(c5x2, c5x2.s.b.t(), 1, false, null);
				}
			}
		}
		return null;
	}

	// Token: 0x06001422 RID: 5154 RVA: 0x00055C54 File Offset: 0x00053E54
	[CompilerGenerated]
	private void b(ej0 A_0)
	{
		amc amc = new bzv(A_0.b().c().y6()).g();
		if (amc != null)
		{
			bja bja = e5v.f(A_0.b().c());
			if (bja != null)
			{
				string classPropertyValue = A_0.b().c().y6().GetClassPropertyValue<string>(ddq.ak);
				if (!string.IsNullOrEmpty(classPropertyValue) && A_0.b().g().aa().a(classPropertyValue, true) == null)
				{
					return;
				}
				bt4 a_ = new bt4(amc.a8().Area.y8(), amc.a8().aj());
				bja.d(new asf(A_0.b().c().a8().qe(), a_));
				if (!A_0.b().d().GetPrimitivePropertyValue<bool>(e2z.c, new bool?(false)).Value)
				{
					if (!A_0.b().g().aa().SpecialStates.g)
					{
						A_0.b().c().a(null, new CombatSpeakEvent[]
						{
							CombatSpeakEvent.Special_RemoteCallForHelp
						}, 10.0, true);
					}
					A_0.b().d()[e2z.c] = true;
				}
				cze cze = e5v.e(A_0.b().c());
				if (cze != null)
				{
					cze.ym(A_0.b().c().a8(), (bja != null) ? bja.a8() : null, null);
					return;
				}
			}
			else if (!A_0.b().d().GetPrimitivePropertyValue<bool>(e2z.d, new bool?(false)).Value && !A_0.b().g().aa().SpecialStates.g)
			{
				exw exw = eym.a(A_0.b().g());
				cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
				if (serviceOrThrow != null && exw != null && exw.a())
				{
					d02 serviceOrThrow2 = bpo.GetServiceOrThrow<d02>();
					int num = 0;
					int num2 = 0;
					foreach (d4n d4n in serviceOrThrow2.ahl())
					{
						if (d4n.b != null && d4n.b.a8() != null && d4n.b != A_0.b().g() && !d4n.b.aa().Passive && d4n.b.a8().k.b != null)
						{
							h h = A_0.b().g().aa().a(serviceOrThrow.aqu().ac(), d4n.b.aa().FactionId);
							if ((d4n.b.aa().FactionId == A_0.b().g().aa().FactionId || h == global::h.e) && (d4n.b.aa().b(d8o.b | d8o.c | d8o.d) || this.jy()))
							{
								num++;
								if (d4n.b.aa().IsInCombat || A_0.b().c().b(d4n.b, false))
								{
									num2++;
								}
							}
						}
					}
					ak1 ak = A_0.b().g().a8().Area.a(A_0.b().g().a8().aj().a());
					if (ak != null)
					{
						double num3;
						if (num > 0 && num2 == 0)
						{
							num3 = 1.0;
						}
						else if (num2 < num && num2 < 2 && euf.f(A_0.b().g().aa()) < 0.5f)
						{
							num3 = 0.75;
						}
						else
						{
							num3 = (double)(Math.Max(0, num - num2) / Math.Max(1, num));
						}
						if (cuo.a.NextDouble() < num3)
						{
							int num4 = this.jx();
							if (num4 > 0)
							{
								awx awx = new awx();
								awx.a(m7.b);
								for (int i = 0; i < num4; i++)
								{
									if (this.jw() != null)
									{
										List<auv> list = awx.ad();
										bfq bfq = new bfq("callForHelp", this.jw());
										bfq.a(true);
										list.Add(new a4s(bfq, null, new ar7(base.g().a8()), null));
									}
									if (this.jv() != null && base.i() != null)
									{
										awx.ad().Add(new e4t(base.g(), this.jv().Value, dz6.b(cux.l), 0, null, 1));
									}
								}
								base.i().b(awx, atp.a);
							}
							float value;
							if (exw != null && exw.d() != null)
							{
								value = exw.d().Value;
							}
							else
							{
								value = aju.aj;
							}
							A_0.b().c().a(null, new CombatSpeakEvent[]
							{
								CombatSpeakEvent.Special_CallForHelp
							}, 10.0, false);
							cn9 a_2 = new cn9(new edx(ak), (double)value);
							A_0.b().g().a8().Zone.ActionManager.g9(a_2, atp.a);
							dz6.a(a_2);
							dfx a_3 = new dfx(new ap9(A_0.b().g().aa()));
							bey.a(a_3, A_0.b().g().aa(), A_0.b().g());
							a7v.a(a_3);
						}
						A_0.b().d()[e2z.d] = true;
					}
				}
			}
		}
	}

	// Token: 0x06001423 RID: 5155 RVA: 0x000562A0 File Offset: 0x000544A0
	[CompilerGenerated]
	private bool d(e1k A_0)
	{
		if (!base.d().GetPrimitivePropertyValue<bool>("forcefieldCheck", new bool?(false)).Value)
		{
			amc amc = new bzv(A_0.c().y6()).g();
			if (amc != null && amc.aa().FactionId == asp.a)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06001424 RID: 5156 RVA: 0x0005630C File Offset: 0x0005450C
	[CompilerGenerated]
	private bool c(e1k A_0)
	{
		if (!base.d().GetPrimitivePropertyValue<bool>("triedToThrowFlareAtPlayer", new bool?(false)).Value && ew0.b() && A_0.g().aa().b(d8o.b | d8o.c | d8o.d))
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null)
			{
				c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
				if (c5x != null && c5x.h.b != null && c5x.h.b.aa().SpecialStates.g && A_0.g().a(c5x.h.b) == global::h.a)
				{
					erl erl = new bzv(A_0.c().y6()).d(c5x.qe());
					if (erl != null && erl.f() == cem.c && Enumerable.FirstOrDefault<coh>(A_0.g().aa().Bag.b("flare")) != null)
					{
						return true;
					}
				}
			}
		}
		return false;
	}

	// Token: 0x06001425 RID: 5157 RVA: 0x00056450 File Offset: 0x00054650
	[CompilerGenerated]
	private bool b(e1k A_0)
	{
		if (!base.d().GetPrimitivePropertyValue<bool>("setNoiseBackupToBumpPlayerOutOfStealth", new bool?(false)).Value && ew0.b())
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null)
			{
				c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
				if (c5x != null && c5x.h.b != null && A_0.g().a(c5x.h.b) == global::h.a)
				{
					erl erl = new bzv(A_0.c().y6()).d(c5x.qe());
					if (erl != null && erl.f() == cem.c)
					{
						return true;
					}
				}
			}
		}
		return false;
	}

	// Token: 0x06001426 RID: 5158 RVA: 0x00056538 File Offset: 0x00054738
	[CompilerGenerated]
	private bool a(e1k A_0)
	{
		if (A_0.c().a8().k == null || A_0.c().a8().k.b == null || A_0.d().GetPrimitivePropertyValue<bool>("attemptedToFollowTarget", new bool?(false)).Value)
		{
			return false;
		}
		if (!A_0.g().aa().IsInControl)
		{
			return false;
		}
		b0b b0b = this.cz(A_0);
		if (b0b == null || b0b.Area == null)
		{
			return false;
		}
		if (b0b.Area != A_0.c().a8().Area)
		{
		}
		bpo.GetServiceOrThrow<d02>();
		ak1 a_ = b0b.Area.a(b0b.aj().a());
		if (!A_0.c().a(a_))
		{
		}
		float num = (float)aw1.b(b0b, A_0.c().a8());
		this.c0(A_0);
		return this.c0(A_0) + 1f < num;
	}

	// Token: 0x06001427 RID: 5159 RVA: 0x0005664C File Offset: 0x0005484C
	[CompilerGenerated]
	private void a(ej0 A_0)
	{
		base.d()["setNoiseBackupToBumpPlayerOutOfStealth"] = true;
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (c5x != null && c5x.Area != null && c5x.h.b != null)
			{
				bt4 value = new bt4(c5x.Area.y8(), c5x.Location);
				A_0.b().c().y6()[ddq.an] = value;
			}
		}
	}

	// Token: 0x06001428 RID: 5160 RVA: 0x00056710 File Offset: 0x00054910
	[CompilerGenerated]
	private cst b(a6w A_0)
	{
		base.d()["triedToThrowFlareAtPlayer"] = true;
		if (ew0.b())
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null)
			{
				c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
				if (c5x != null && c5x.h.b != null && A_0.b().g().a(c5x.h.b) == global::h.a)
				{
					erl erl = new bzv(A_0.b().c().y6()).d(c5x.qe());
					if (erl != null && erl.f() == cem.c)
					{
						coh coh = Enumerable.FirstOrDefault<coh>(A_0.b().g().aa().Bag.b("flare"));
						if (coh != null)
						{
							c3n c3n = dgk.Get<kh>();
							if (c3n != null)
							{
								ak1 ak = c5x.Area.a(c5x.aj().a());
								if (ak != null)
								{
									eu7 eu = ecf.a(c3n, new eru(new EntityAspectReference<amc, amc>(A_0.b().g())), coh) as eu7;
									if (eu != null && eu.yw())
									{
										bt4 value = new bt4(c5x.Area.y8(), c5x.Location);
										A_0.b().c().y6()[ddq.an] = value;
										return global::cp.b(eu, A_0.b().g().a8(), ak);
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

	// Token: 0x06001429 RID: 5161 RVA: 0x000568D0 File Offset: 0x00054AD0
	[CompilerGenerated]
	private cst a(a6w A_0)
	{
		A_0.b().d()["attemptedToFollowTarget"] = true;
		b0b b0b = this.cz(A_0.b());
		if (b0b != null)
		{
			return A_0.b().c().a8().k.b.a(b0b, Math.Max(0f, this.c0(A_0.b()) - 1f), 1, 0);
		}
		return null;
	}

	// Token: 0x04000ACD RID: 2765
	protected const float a = 1f;

	// Token: 0x04000ACE RID: 2766
	protected const float b = 3f;

	// Token: 0x04000ACF RID: 2767
	protected aij c;

	// Token: 0x04000AD0 RID: 2768
	protected clo d;

	// Token: 0x04000AD1 RID: 2769
	protected new vw e;

	// Token: 0x04000AD2 RID: 2770
	protected vw f;

	// Token: 0x04000AD3 RID: 2771
	protected bd g;

	// Token: 0x04000AD4 RID: 2772
	protected cf4 h;

	// Token: 0x04000AD5 RID: 2773
	protected bq1 i;

	// Token: 0x04000AD6 RID: 2774
	protected fh j;

	// Token: 0x04000AD7 RID: 2775
	protected ej0 k;

	// Token: 0x04000AD8 RID: 2776
	protected ej0 l;

	// Token: 0x04000AD9 RID: 2777
	protected ej0 m;

	// Token: 0x04000ADA RID: 2778
	protected ej0 n;

	// Token: 0x04000ADB RID: 2779
	protected ej0 o;

	// Token: 0x04000ADC RID: 2780
	protected ej0 p;

	// Token: 0x04000ADD RID: 2781
	protected ej0 q;

	// Token: 0x04000ADE RID: 2782
	protected ej0 r;

	// Token: 0x04000ADF RID: 2783
	private ej0 s;

	// Token: 0x04000AE0 RID: 2784
	private a6w t;

	// Token: 0x04000AE1 RID: 2785
	private a6w u;

	// Token: 0x04000AE2 RID: 2786
	private a6w v;

	// Token: 0x04000AE3 RID: 2787
	private a6w w;

	// Token: 0x04000AE4 RID: 2788
	private a6w x;

	// Token: 0x04000AE5 RID: 2789
	private ej0 y;

	// Token: 0x04000AE6 RID: 2790
	protected bud z;

	// Token: 0x04000AE7 RID: 2791
	private fh aa;

	// Token: 0x04000AE8 RID: 2792
	private ej0 ab;

	// Token: 0x04000AE9 RID: 2793
	protected a6w ac;

	// Token: 0x04000AEA RID: 2794
	protected a6w ad;

	// Token: 0x04000AEB RID: 2795
	private fh ae;

	// Token: 0x04000AEC RID: 2796
	private ej0 af;

	// Token: 0x04000AED RID: 2797
	private a6w ag;

	// Token: 0x04000AEE RID: 2798
	private a6w ah;

	// Token: 0x04000AEF RID: 2799
	private ej0 ai;

	// Token: 0x04000AF0 RID: 2800
	private fh aj;

	// Token: 0x04000AF1 RID: 2801
	private b4a ak;

	// Token: 0x04000AF2 RID: 2802
	private bool al;

	// Token: 0x02000326 RID: 806
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x06001713 RID: 5907 RVA: 0x00072D3C File Offset: 0x00070F3C
		internal void k(ej0 A_0)
		{
			A_0.b().d().RemoveProperty("ranFromFire");
			A_0.b().d().RemoveProperty("ranFromGas");
			A_0.b().d().RemoveProperty("failedToRestorePower");
			A_0.b().d().RemoveProperty("failedUseOnce");
			A_0.b().d().RemoveProperty(e2z.c);
			A_0.b().d().RemoveProperty(e2z.d);
			A_0.b().d().RemoveProperty("attemptedToAdvanceOnRequest");
			A_0.b().d().RemoveProperty("setNoiseBackupToBumpPlayerOutOfStealth");
			A_0.b().d().RemoveProperty("triedToThrowFlareAtPlayer");
			A_0.b().d().RemoveProperty("attemptedToFollowTarget");
			A_0.b().d().RemoveProperty("forcefieldCheck");
			A_0.b().d().RemoveProperty("forceFieldKillingMode");
		}

		// Token: 0x06001714 RID: 5908 RVA: 0x00072E54 File Offset: 0x00071054
		internal void j(ej0 A_0)
		{
			c5x a_ = null;
			amc amc = new bzv(A_0.b().c().y6()).g();
			if (amc != null)
			{
				a_ = amc.a8();
			}
			ak1 ak = g8.a(A_0.b().c(), a_, 10);
			if (ak != null)
			{
				A_0.b().g().a8().k.b.a(ak, 0.0, 1, 0, true);
			}
		}

		// Token: 0x06001715 RID: 5909 RVA: 0x00072ED4 File Offset: 0x000710D4
		internal void a(ej0 A_0)
		{
			c5x c5x = null;
			axo axo = Enumerable.FirstOrDefault<axo>(A_0.b().g().aa().StatusEffects.Get<axo>());
			if (axo != null)
			{
				ar7 ar = axo.ObjectOfFear as ar7;
				if (ar != null)
				{
					c5x = (ar.ao() as c5x);
				}
			}
			if (c5x == null)
			{
				c5x = or.a(A_0.b().g());
			}
			ak1 ak = g8.a(A_0.b().c(), c5x, 10);
			if (ak != null)
			{
				A_0.b().g().a8().k.b.a(ak, 0.0, 1, 0, true);
				if (!A_0.b().g().aa().SpecialStates.a && !A_0.b().g().aa().SpecialStates.c)
				{
					exw exw = eym.a(A_0.b().g());
					float num;
					if (exw != null && exw.d() != null)
					{
						num = exw.d().Value;
					}
					else
					{
						num = aju.aj;
					}
					if (A_0.b().g().aa().StatusEffects.a(bk9.a))
					{
						if (A_0.b().c().a(null, new CombatSpeakEvent[]
						{
							CombatSpeakEvent.Affliction_Burning
						}, 10.0, false))
						{
							eym.a(A_0.b().g().a8(), (double)num);
							return;
						}
					}
					else if (A_0.b().c().a(null, new CombatSpeakEvent[]
					{
						CombatSpeakEvent.Affliction_Fear
					}, 10.0, false))
					{
						eym.a(A_0.b().g().a8(), (double)num);
					}
				}
			}
		}

		// Token: 0x06001716 RID: 5910 RVA: 0x000730C0 File Offset: 0x000712C0
		internal bool f(e1k A_0)
		{
			return A_0.g().aa().SpecialStates.l && A_0.g().aa().FactionId != asp.e;
		}

		// Token: 0x06001717 RID: 5911 RVA: 0x00073104 File Offset: 0x00071304
		internal bool i(e1k A_0)
		{
			if (A_0.g().a8().k.b != null && !A_0.d().GetPrimitivePropertyValue<bool>("ranFromFire", new bool?(false)).Value)
			{
				int num = dd5.b(A_0.g().a8());
				if (num > 0)
				{
					int num2 = dd5.a(A_0.g());
					if (num > num2)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06001718 RID: 5912 RVA: 0x0007317C File Offset: 0x0007137C
		internal bool g(e1k A_0)
		{
			return A_0.g().aa().IsInControl && !A_0.g().aa().SpecialStates.b && A_0.c().y6().GetPrimitivePropertyValue<bool>(ddq.bt, new bool?(false)).Value && !A_0.d().GetPrimitivePropertyValue<bool>("attemptedToAdvanceOnRequest", new bool?(false)).Value;
		}

		// Token: 0x06001719 RID: 5913 RVA: 0x00073208 File Offset: 0x00071408
		internal bool h(e1k A_0)
		{
			if (A_0.g().a8().k.b != null && !A_0.d().GetPrimitivePropertyValue<bool>("ranFromFire", new bool?(false)).Value && !A_0.d().GetPrimitivePropertyValue<bool>("ranFromGas", new bool?(false)).Value)
			{
				int num = bpv.a(A_0.g().a8());
				if (num > 0)
				{
					int num2 = bpv.a(A_0.g());
					if (num > num2)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x0600171A RID: 5914 RVA: 0x000732A4 File Offset: 0x000714A4
		internal bool b(e1k A_0)
		{
			return !A_0.g().aa().IsInControl;
		}

		// Token: 0x0600171B RID: 5915 RVA: 0x000732BC File Offset: 0x000714BC
		internal bool j(e1k A_0)
		{
			if (A_0.g().aa().Vehicle != null)
			{
				return false;
			}
			if (!A_0.g().aa().Defense.i4() && A_0.g().aa().IsInCombat && A_0.g().aa().Gear.h().Item != null && (int)A_0.g().aa().Defense.i5() > 0)
			{
				ip ip = A_0.g().aa().Cooldowns.b(d7f.d);
				return ip == null || ip.a <= 0.0;
			}
			return false;
		}

		// Token: 0x0600171C RID: 5916 RVA: 0x00073384 File Offset: 0x00071584
		internal bool e(e1k A_0)
		{
			return A_0.g().aa().Defense.i4() && A_0.g().aa().Gear.h().Item != null && !A_0.g().aa().IsInCombat;
		}

		// Token: 0x0600171D RID: 5917 RVA: 0x000733E0 File Offset: 0x000715E0
		internal bool a(e1k A_0)
		{
			if (A_0.g().aa().IsInControl && !A_0.d().GetPrimitivePropertyValue<bool>("failedUseOnce", new bool?(false)).Value)
			{
				ar7 classPropertyValue = A_0.c().y6().GetClassPropertyValue<ar7>(ddq.b1);
				if (classPropertyValue != null && classPropertyValue.ao() != null && (classPropertyValue.ao() as c5x).s.b != null)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0600171E RID: 5918 RVA: 0x0007346C File Offset: 0x0007166C
		internal void g(ej0 A_0)
		{
			A_0.b().d()["failedToRestorePower"] = true;
		}

		// Token: 0x0600171F RID: 5919 RVA: 0x0007348C File Offset: 0x0007168C
		internal void f(ej0 A_0)
		{
			A_0.b().d()["failedUseOnce"] = true;
		}

		// Token: 0x06001720 RID: 5920 RVA: 0x000734AC File Offset: 0x000716AC
		internal cst a(a6w A_0)
		{
			ale aspect = A_0.b().g().a8().GetAspect<ale>();
			Guid? primitivePropertyValue = A_0.b().c().y6().GetPrimitivePropertyValue<Guid>(ddq.bi, null);
			if (primitivePropertyValue != null)
			{
				string classPropertyValue = A_0.b().c().y6().GetClassPropertyValue<string>(ddq.bj);
				c5x c5x;
				if (!string.IsNullOrEmpty(classPropertyValue))
				{
					c5x = (new ar7(primitivePropertyValue.Value, A_0.b().g().a8().Zone.n(classPropertyValue)).ao() as c5x);
				}
				else
				{
					c5x = (new ar7(primitivePropertyValue.Value, A_0.b().g().a8().Area).ao() as c5x);
				}
				if (c5x != null && c5x.s.b != null)
				{
					return aspect.b(c5x, c5x.s.b.t(), 1, false, null);
				}
			}
			return null;
		}

		// Token: 0x06001721 RID: 5921 RVA: 0x000735C0 File Offset: 0x000717C0
		internal cst b(a6w A_0)
		{
			if (A_0.b().g().aa().IsInControl)
			{
				ar7 classPropertyValue = A_0.b().c().y6().GetClassPropertyValue<ar7>(ddq.b1);
				if (classPropertyValue != null && classPropertyValue.ao() != null)
				{
					c5x c5x = classPropertyValue.ao() as c5x;
					if (c5x.s.b != null)
					{
						awx awx = new awx();
						awx.a(m7.b);
						ale aspect = A_0.b().g().a8().GetAspect<ale>();
						if (aspect != null)
						{
							awx awx2 = aspect.a(classPropertyValue.ao(), c5x.s.b.t(), 1, false, null);
							awx.ad().AddRange(awx2.ad());
						}
						else
						{
							awx.ad().Add(new b9t(A_0.b().g().a8(), c5x.s.b, null));
						}
						List<auv> list = awx.ad();
						hx hx = new hx();
						hx.a(new List<string>
						{
							ddq.b1
						});
						list.Add(new a4s(hx, null, new ar7(A_0.b().g().a8()), null));
						A_0.b().i().b(awx, atp.a);
						return awx;
					}
				}
			}
			return null;
		}

		// Token: 0x06001722 RID: 5922 RVA: 0x00073714 File Offset: 0x00071914
		internal void b(ej0 A_0)
		{
			A_0.b().d()["ranFromFire"] = true;
			ak1 ak = g8.b(A_0.b().c());
			if (ak != null)
			{
				A_0.b().g().a8().k.b.a(ak, 0.0, 1, 0, true);
			}
		}

		// Token: 0x06001723 RID: 5923 RVA: 0x00073780 File Offset: 0x00071980
		internal void h(ej0 A_0)
		{
			A_0.b().d()["ranFromGas"] = true;
			ak1 ak = g8.a(A_0.b().c());
			if (ak != null)
			{
				A_0.b().g().a8().k.b.a(ak, 0.0, 1, 0, true);
			}
		}

		// Token: 0x06001724 RID: 5924 RVA: 0x000737EC File Offset: 0x000719EC
		internal void d(ej0 A_0)
		{
			A_0.b().c().y6()[ddq.bp] = A_0.b().g().aa().FactionId;
			A_0.b().c().y6()[ddq.bq] = new Dictionary<string, h>(A_0.b().g().aa().PersonalAttitudes);
			A_0.b().g().aa().FactionId = asp.e;
			if (A_0.b().g().a8().t.b != null)
			{
				new bzv(A_0.b().g().a8().t.b.y6()).h();
			}
		}

		// Token: 0x06001725 RID: 5925 RVA: 0x000738C0 File Offset: 0x00071AC0
		internal void c(ej0 A_0)
		{
			A_0.b().g().aa().Defense.a(true);
		}

		// Token: 0x06001726 RID: 5926 RVA: 0x000738E8 File Offset: 0x00071AE8
		internal void e(ej0 A_0)
		{
			A_0.b().g().aa().Defense.a(false);
		}

		// Token: 0x06001727 RID: 5927 RVA: 0x00073910 File Offset: 0x00071B10
		internal int a(bud A_0)
		{
			ak1 ak = eth.g(A_0.b().c());
			ak1 ak2 = eth.f(A_0.b().c());
			if (ak2 != null && ak != ak2)
			{
				if (!A_0.b().g().aa().SpecialStates.g)
				{
					a20.a(A_0.b().c().a8(), null, new CombatSpeakEvent[]
					{
						CombatSpeakEvent.Special_HeardNoise
					});
				}
				A_0.b().c().y6()[ddq.am] = A_0.b().c().y6()[ddq.an];
				A_0.b().c().y6().RemoveProperty(ddq.an);
				ak = ak2;
			}
			if (ak != null)
			{
				ale ale = A_0.b().c().a8().k.b;
				if (ale != null)
				{
					if (A_0.b().c().y6().GetPrimitivePropertyValue<bool>(ddq.aj, new bool?(false)).Value)
					{
						ale.a(ak, A_0.b().g().aa().SightRange, 1, 0);
					}
					else
					{
						ale.a(ak, double.MaxValue, 1, 0);
					}
					return 1;
				}
			}
			return 0;
		}

		// Token: 0x06001728 RID: 5928 RVA: 0x00073A70 File Offset: 0x00071C70
		internal bool c(e1k A_0)
		{
			return !A_0.g().aa().IsInControl;
		}

		// Token: 0x06001729 RID: 5929 RVA: 0x00073A88 File Offset: 0x00071C88
		internal bool d(e1k A_0)
		{
			d4n d4n = A_0.e();
			return d4n != null && d4n.g();
		}

		// Token: 0x0600172A RID: 5930 RVA: 0x00073AAC File Offset: 0x00071CAC
		internal void i(ej0 A_0)
		{
			eth.e(A_0.b().c());
		}

		// Token: 0x0600172B RID: 5931 RVA: 0x00073AC0 File Offset: 0x00071CC0
		internal cst c(a6w A_0)
		{
			A_0.b().d()["attemptedToAdvanceOnRequest"] = true;
			if (A_0.b().g().a8().k.b != null && !A_0.b().g().aa().SpecialStates.b)
			{
				bzv bzv = new bzv(A_0.b().c().y6());
				amc amc = bzv.g();
				if (amc != null)
				{
					cmb cmb = bzv.d();
					if (cmb != null)
					{
						d4n d4n = bpo.GetServiceOrThrow<d02>().ahu(A_0.b().g().aa());
						if (d4n != null)
						{
							int num = (int)Math.Min(d4n.c + d4n.d, 30.0);
							double num2 = aw1.b(amc.a8(), A_0.b().g().a8());
							if (num2 >= 1.5)
							{
								int num3 = -1;
								for (int i = 1; i <= (int)num2; i++)
								{
									float num4 = cmb.b(i);
									if (num4 == 0f)
									{
										break;
									}
									if (num4 != -1f && num4 * 10f <= (float)num)
									{
										num3 = i;
										break;
									}
								}
								if (num3 != -1)
								{
									return A_0.b().g().a8().k.b.a(amc.a8(), (float)num3, 1, 0);
								}
							}
							else
							{
								ak1 ak = g8.b(A_0.b().c(), amc.a8().t.b, num / 10);
								if (ak != null)
								{
									return A_0.b().g().a8().k.b.a(ak, 0.0, 1, 0, true);
								}
							}
						}
					}
				}
				else
				{
					ak1 ak2 = g8.a(A_0.b().c(), int.MaxValue, 5);
					if (ak2 != null)
					{
						return A_0.b().g().a8().k.b.a(ak2, 0.0, 1, 0, true);
					}
				}
			}
			return null;
		}

		// Token: 0x0600172C RID: 5932 RVA: 0x00073CF4 File Offset: 0x00071EF4
		internal void a(aij A_0)
		{
			if (ew0.b() && !A_0.b().g().aa().SpecialStates.b && A_0.b().g().aa().IsInControl && A_0.b().g().aa().IsInCombat && A_0.b().g().a8().k.b != null)
			{
				amc amc = new bzv(A_0.b().c().y6()).g();
				if (amc != null && !amc.aa().Dead)
				{
					d4n d4n = bpo.GetServiceOrThrow<d02>().ahu(A_0.b().g().aa());
					if (d4n != null && d4n.c >= (double)A_0.b().g().aa().Offense.n() * 0.75)
					{
						es3 a_ = new es3(A_0.b().g());
						A_0.b().g().a8().Zone.ActionManager.g9(a_, atp.a);
						dz6.a(a_);
					}
				}
			}
		}

		// Token: 0x0600172D RID: 5933 RVA: 0x00073E38 File Offset: 0x00072038
		internal bool a(b0b A_0)
		{
			return A_0.y8() == "Рубильник";
		}

		// Token: 0x04000DA9 RID: 3497
		public static readonly or.a a = new or.a();

		// Token: 0x04000DAA RID: 3498
		public static Action<ej0> b;

		// Token: 0x04000DAB RID: 3499
		public static Action<ej0> c;

		// Token: 0x04000DAC RID: 3500
		public static Action<ej0> d;

		// Token: 0x04000DAD RID: 3501
		public static Func<e1k, bool> e;

		// Token: 0x04000DAE RID: 3502
		public static Func<e1k, bool> f;

		// Token: 0x04000DAF RID: 3503
		public static Func<e1k, bool> g;

		// Token: 0x04000DB0 RID: 3504
		public static Func<e1k, bool> h;

		// Token: 0x04000DB1 RID: 3505
		public static Func<e1k, bool> i;

		// Token: 0x04000DB2 RID: 3506
		public static Func<e1k, bool> j;

		// Token: 0x04000DB3 RID: 3507
		public static Func<e1k, bool> k;

		// Token: 0x04000DB4 RID: 3508
		public static Func<e1k, bool> l;

		// Token: 0x04000DB5 RID: 3509
		public static Action<ej0> m;

		// Token: 0x04000DB6 RID: 3510
		public static Action<ej0> n;

		// Token: 0x04000DB7 RID: 3511
		public static Func<a6w, cst> o;

		// Token: 0x04000DB8 RID: 3512
		public static Func<a6w, cst> p;

		// Token: 0x04000DB9 RID: 3513
		public static Action<ej0> q;

		// Token: 0x04000DBA RID: 3514
		public static Action<ej0> r;

		// Token: 0x04000DBB RID: 3515
		public static Action<ej0> s;

		// Token: 0x04000DBC RID: 3516
		public static Action<ej0> t;

		// Token: 0x04000DBD RID: 3517
		public static Action<ej0> u;

		// Token: 0x04000DBE RID: 3518
		public static Func<bud, int> v;

		// Token: 0x04000DBF RID: 3519
		public static Func<e1k, bool> w;

		// Token: 0x04000DC0 RID: 3520
		public static Func<e1k, bool> x;

		// Token: 0x04000DC1 RID: 3521
		public static Action<ej0> y;

		// Token: 0x04000DC2 RID: 3522
		public static Func<a6w, cst> z;

		// Token: 0x04000DC3 RID: 3523
		public static Action<aij> aa;

		// Token: 0x04000DC4 RID: 3524
		public static Func<b0b, bool> ab;
	}
}
