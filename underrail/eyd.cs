using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02000C9A RID: 3226
[e79("Dun_Lup_A_LurkersCapture")]
public sealed class eyd : dgy
{
	// Token: 0x06004903 RID: 18691 RVA: 0x001DCFFC File Offset: 0x001DB1FC
	public eyd()
	{
		eyd.a a = new eyd.a();
		base..ctor();
		a.a = this;
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null && serviceOrThrow.aqw() != null)
		{
			a.b = (serviceOrThrow.aqu().v().b() as c5x);
			if (a.b != null)
			{
				a.b.i.b.a(true, false);
				a.d = (new ar7(new Guid("331e216c-ff8b-49ec-8485-7d4567bfa7f3"), a.b.Area).ao() as c5x);
				a.e = (new ar7(new Guid("a62f7d1c-0f86-4822-8572-863056cf5a17"), a.b.Area).ao() as c5x);
				a.c = (new ar7(new Guid("e31d3155-a71e-42e0-9892-ecee4ed295b3"), a.b.Area).ao() as c5x);
				if (a.d != null && a.c != null && a.e != null)
				{
					base.a(new btm[]
					{
						new ace(new e80(false))
					});
					btm[] array = new btm[1];
					int num = 0;
					dky dky = new dky();
					dky.a(0.2f);
					dky.a(false);
					array[num] = dky;
					base.a(array);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
					});
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(a.b), null, null, null)
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(2.0))
					});
					btm[] array2 = new btm[1];
					int num2 = 0;
					c8s c8s = new c8s();
					c8s.a(0.2f);
					c8s.IsAsync = false;
					array2[num2] = c8s;
					base.a(array2);
					serviceOrThrow.aqu().r()["loc_dun_lup-a_captured"] = true;
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(a.a), null, null, null)
					});
					base.a(new btm[]
					{
						new ace(new e80(true))
					});
				}
			}
		}
	}

	// Token: 0x06004904 RID: 18692 RVA: 0x001DD244 File Offset: 0x001DB444
	private void a(efk A_0, dbi A_1)
	{
		List<a0> list = new List<a0>
		{
			a0.q,
			a0.s,
			a0.w,
			a0.ar,
			a0.h,
			a0.ay,
			a0.aj,
			a0.f,
			a0.e,
			a0.ao,
			a0.r,
			a0.o,
			a0.p,
			a0.ap,
			a0.g,
			a0.@as,
			a0.u,
			a0.v,
			a0.a1
		};
		foreach (c1e c1e in Enumerable.Union<c1e>(A_0.Gear.d(), new c1e[]
		{
			A_0.Gear.l(),
			A_0.Gear.e(),
			A_0.Gear.f(),
			A_0.Gear.g(),
			A_0.Gear.h(),
			A_0.Gear.j()[WeaponKey.Primary],
			A_0.Gear.j()[WeaponKey.Secondary]
		}))
		{
			if (c1e.Value != null && !euf.o(c1e.Value as cd1) && c1e.Value.Stealable && list.Contains(c1e.Value.Definition.bi()))
			{
				A_1.z3(c1e.Value, false);
				c1e.po(null);
			}
		}
		foreach (coh coh in Enumerable.ToList<coh>(A_0.Bag.z2()))
		{
			if (coh.Stealable && list.Contains(coh.Definition.bi()))
			{
				A_0.Bag.z5(coh);
				coh.Lootable = true;
				coh.Stealable = true;
				A_1.z3(coh, false);
			}
		}
	}

	// Token: 0x02000C9B RID: 3227
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004906 RID: 18694 RVA: 0x001DD4CC File Offset: 0x001DB6CC
		internal bool b(e6d A_0)
		{
			c7j c7j = this.c.s.b as c7j;
			if (c7j != null)
			{
				this.a.a(this.b.h.b.aa(), c7j.ItemContainer);
			}
			a0l.a(this.d, "Krix_capture", true);
			a0l.a(this.e, "Greg_capture", true);
			List<string> value = new List<string>
			{
				"Krix_pee",
				"g1_p2"
			};
			List<string> value2 = new List<string>
			{
				"g2_p3",
				"g2",
				"g2_p1",
				"g2_p2"
			};
			this.d.t.b.y6().RemoveProperty(ddq.ay);
			this.d.t.b.y6()[ddq.k] = value;
			this.e.t.b.y6()[ddq.k] = value2;
			a0l.a(this.b, "player_capture", true);
			return true;
		}

		// Token: 0x06004907 RID: 18695 RVA: 0x001DD600 File Offset: 0x001DB800
		internal bool a(e6d A_0)
		{
			this.b.GetAspect<j7>().a(this.d.GetAspect<j7>(), false, null, false);
			return true;
		}

		// Token: 0x04001CD6 RID: 7382
		public eyd a;

		// Token: 0x04001CD7 RID: 7383
		public c5x b;

		// Token: 0x04001CD8 RID: 7384
		public c5x c;

		// Token: 0x04001CD9 RID: 7385
		public c5x d;

		// Token: 0x04001CDA RID: 7386
		public c5x e;
	}
}
