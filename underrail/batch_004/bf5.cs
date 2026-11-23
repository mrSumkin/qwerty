using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;
using TimelapseVertigo.Rules;

// Token: 0x02000CDC RID: 3292
[e79("Xpbl_Pir_RigRaidBoatArrives")]
public sealed class bf5 : dgy
{
	// Token: 0x060049BB RID: 18875 RVA: 0x001ED2F4 File Offset: 0x001EB4F4
	public bf5()
	{
		bf5.b b = new bf5.b();
		b.a = bpo.GetServiceOrThrow<cnk>();
		if (b.a != null && b.a.aqu() != null)
		{
			bf5.a a = new bf5.a();
			a.g = b;
			a.a = (a.g.a.aqu().v().b() as c5x);
			if (a.a != null && a.a.Area != null)
			{
				a.g.a.aqw().a();
				a.b = (new ar7(new Guid("57ba8fd0-b986-461f-a9a0-983453ddf4c6"), a.a.Area).ao() as c5x);
				a.f = null;
				a.c = null;
				a.d = null;
				a.e = null;
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
					new dva(null, new Func<e6d, bool>(a.d), null, null, null)
				});
				base.a(new btm[]
				{
					new ace(new bfq("FerrySailing"))
					{
						TargetRef = new ar7(a.a)
					}
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(2.0))
				});
				btm[] array2 = new btm[1];
				int num2 = 0;
				kw kw = new kw();
				kw.a(new bt4("cvw27", new Vector3(14f, 34f, 0f)));
				kw.IsAsync = true;
				kw.a(true);
				array2[num2] = kw;
				base.a(array2);
				btm[] array3 = new btm[1];
				int num3 = 0;
				c8s c8s = new c8s();
				c8s.a(0.2f);
				c8s.a(false);
				array3[num3] = c8s;
				base.a(array3);
				base.a(new btm[]
				{
					new dva(null, new Func<e6d, bool>(a.c), null, null, null)
				});
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
					new os(TimeSpan.FromSeconds(4.0))
				});
				base.a(new btm[]
				{
					new dva(null, new Func<e6d, bool>(a.a), null, null, null)
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(5.0))
				});
				btm[] array4 = new btm[1];
				int num4 = 0;
				dky dky2 = new dky();
				dky2.a(0.2f);
				dky2.a(false);
				array4[num4] = dky2;
				base.a(array4);
				base.a(new btm[]
				{
					new dva(null, new Func<e6d, bool>(a.e), null, null, null)
				});
				base.a(new btm[]
				{
					new di4(new c2w("xpbl_rig1", "player_start"), false, new bool?(false), 0, null, false, false, false)
				});
				base.a(new btm[]
				{
					new ace(new bfq("FerrySailingShort"))
					{
						TargetRef = new ar7(a.a)
					}
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(2.0))
				});
				base.a(new btm[]
				{
					new dva(null, new Func<e6d, bool>(a.g.b), null, null, null)
				});
				btm[] array5 = new btm[1];
				int num5 = 0;
				c8s c8s2 = new c8s();
				c8s2.a(0.2f);
				c8s2.a(false);
				array5[num5] = c8s2;
				base.a(array5);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				base.a(new btm[]
				{
					new dva(null, new Func<e6d, bool>(a.g.a), null, null, null)
				});
				base.a(new btm[]
				{
					new ace(new e80(true))
				});
				btm[] array6 = new btm[1];
				int num6 = 0;
				bu0 bu = new bu0();
				bu.a("cp_attackingTheRig");
				array6[num6] = new ace(bu);
				base.a(array6);
			}
		}
	}

	// Token: 0x02000CDD RID: 3293
	[CompilerGenerated]
	private new sealed class b
	{
		// Token: 0x060049BD RID: 18877 RVA: 0x001ED788 File Offset: 0x001EB988
		internal bool b(e6d A_0)
		{
			erb.a(this.a.aqu(), this.a.aqw(), "xpbl_rig_ps", this.a.aqw().g("RigRaidFerry"));
			dys dys = new dys();
			dys.a(true);
			dys.ym(this.a.aqu().v().b(), null, null);
			return true;
		}

		// Token: 0x060049BE RID: 18878 RVA: 0x001ED7F4 File Offset: 0x001EB9F4
		internal bool a(e6d A_0)
		{
			c5x c5x = new ar7(new Guid("40fc535a-4678-4c6b-bc8e-d19a0c09e3b2"), this.a.aqw().n("xpbl_rig1")).ao() as c5x;
			if (c5x != null && c5x.t.b != null)
			{
				int num = 90000;
				bu6 service = bpo.GetService<bu6>();
				if (service != null)
				{
					if (service.aq2() >= GameDifficulty.Dominating)
					{
						num -= 20000;
					}
					else if (service.aq2() == GameDifficulty.Hard)
					{
						num -= 10000;
					}
					else if (service.aq2() == GameDifficulty.Easy)
					{
						num += 20000;
					}
				}
				c5x.t.b.y6()[ddq.k] = new List<string>
				{
					"snoop1",
					"snoop2",
					"snoop3",
					"snoop4"
				};
				c5x.t.b.y6()[ddq.n] = true;
				c5x.t.b.y6()[ddq.l] = num;
				c5x.t.b.y6()[ddq.bc] = "loc_xpbl_rig_dockGuard_talked";
			}
			return true;
		}

		// Token: 0x04001D42 RID: 7490
		public cnk a;
	}

	// Token: 0x02000CDE RID: 3294
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x060049C0 RID: 18880 RVA: 0x001ED950 File Offset: 0x001EBB50
		internal bool d(e6d A_0)
		{
			ps service = bpo.GetService<ps>();
			if (service != null)
			{
				service.anf(edg.a);
			}
			erb.a(this.g.a.aqu(), this.g.a.aqw(), "xpbl_rig_ps", this.g.a.aqw().g("RigRaidFerry"));
			this.g.a.aqz().atb("theRigSonarPartyTurrets", true);
			a0l.a(this.a, "player_ferry", true);
			a0l.a(this.b, "sneak_ferry", true);
			this.c = vq.a("creature\\characters\\xpbl\\Cruzer", this.g.a.aqw().g("cruzer"), true);
			this.d = vq.a("creature\\characters\\support\\xpbl\\pir_pirateRaider1", this.g.a.aqw().g("pirate1"), true);
			this.e = vq.a("creature\\characters\\support\\xpbl\\pir_pirateRaider2", this.g.a.aqw().g("pirate2"), true);
			this.f = vq.a("creature\\characters\\support\\xpbl\\pir_pirateRaider3", this.g.a.aqw().g("pirate3"), true);
			return true;
		}

		// Token: 0x060049C1 RID: 18881 RVA: 0x001EDAA0 File Offset: 0x001EBCA0
		internal bool c(e6d A_0)
		{
			if (this.f != null)
			{
				this.f.VisualDirection = HorizontalDirection.West;
			}
			return true;
		}

		// Token: 0x060049C2 RID: 18882 RVA: 0x001EDAC0 File Offset: 0x001EBCC0
		internal bool b(e6d A_0)
		{
			if (this.f != null)
			{
				c0s aspect = this.f.GetAspect<c0s>();
				if (aspect != null)
				{
					aspect.a("Запрыгивай, банга. Остальные уже ждут в контейнере.", true, null, null);
				}
			}
			return true;
		}

		// Token: 0x060049C3 RID: 18883 RVA: 0x001EDB0C File Offset: 0x001EBD0C
		internal bool a(e6d A_0)
		{
			if (this.f != null)
			{
				c0s aspect = this.f.GetAspect<c0s>();
				if (aspect != null)
				{
					aspect.a("Как мы и планировали: ты разбираешься с турелями, после чего мы выдвигаемся.", true, null, null);
				}
			}
			return true;
		}

		// Token: 0x060049C4 RID: 18884 RVA: 0x001EDB58 File Offset: 0x001EBD58
		internal bool e(e6d A_0)
		{
			ps service = bpo.GetService<ps>();
			if (service != null)
			{
				service.anf(edg.b);
			}
			erb.a("xpbl_rig_ps", this.g.a.aqw().g("RigRaidFerry"));
			this.c.an();
			this.d.an();
			this.e.an();
			this.f.an();
			this.g.a.aqu().r()["quests_xpbl_pirates_theRig_partyDocksAtRig"] = true;
			return true;
		}

		// Token: 0x04001D43 RID: 7491
		public c5x a;

		// Token: 0x04001D44 RID: 7492
		public c5x b;

		// Token: 0x04001D45 RID: 7493
		public c5x c;

		// Token: 0x04001D46 RID: 7494
		public c5x d;

		// Token: 0x04001D47 RID: 7495
		public c5x e;

		// Token: 0x04001D48 RID: 7496
		public c5x f;

		// Token: 0x04001D49 RID: 7497
		public bf5.b g;
	}
}
