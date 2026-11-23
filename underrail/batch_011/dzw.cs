using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Ouroboros.Playfield.Space;
using TimelapseVertigo.Playfield.Locale;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02000313 RID: 787
[apc("plasmaSentry")]
public sealed class dzw : cqw
{
	// Token: 0x06001694 RID: 5780 RVA: 0x0006F068 File Offset: 0x0006D268
	public dzw()
	{
		this.b = new ej0();
		this.c = new ej0();
		this.d = new ej0();
		this.e = new ej0();
		this.f = new a6w(null);
		this.g = new fh(new arr[0]);
		this.g.a.Add(new arr(this.b, new Func<e1k, bool>(dzw.a.a.d)));
		this.g.a.Add(new arr(this.d.a, null));
		this.d.a = this.g;
		this.d.a = new Action<ej0>(dzw.a.a.c);
		this.d.a = base.f();
		base.b(this.d);
		this.e.a = new Action<ej0>(dzw.a.a.d);
		this.e.a = this.c.a;
		this.c.a = this.e;
		this.a = new fh(new arr[0]);
		fh fh = this.a;
		arr[] array = new arr[4];
		array[0] = new arr(this.f, new Func<e1k, bool>(dzw.a.a.a));
		array[1] = new arr(this.b, new Func<e1k, bool>(dzw.a.a.b));
		array[2] = new arr(this.c, new Func<e1k, bool>(dzw.a.a.c));
		array[3] = new arr(this.p.a, null);
		fh.a(array);
		this.p.a = this.a;
		this.f.a = new Func<a6w, cst>(dzw.a.a.a);
		this.f.b = this.a;
		this.f.a = this.a;
		this.b.a = new Action<ej0>(dzw.a.a.b);
		this.b.a = this.c;
		this.c.a = new Action<ej0>(dzw.a.a.a);
		this.c.a = this.a;
		this.b.b = new Func<bud, int>(dzw.a.a.a);
	}

	// Token: 0x04000D30 RID: 3376
	private new fh a;

	// Token: 0x04000D31 RID: 3377
	private new ej0 b;

	// Token: 0x04000D32 RID: 3378
	private new ej0 c;

	// Token: 0x04000D33 RID: 3379
	private new ej0 d;

	// Token: 0x04000D34 RID: 3380
	private new ej0 e;

	// Token: 0x04000D35 RID: 3381
	private new a6w f;

	// Token: 0x04000D36 RID: 3382
	private new fh g;

	// Token: 0x02000314 RID: 788
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06001697 RID: 5783 RVA: 0x0006F3B4 File Offset: 0x0006D5B4
		internal bool d(e1k A_0)
		{
			if (eth.a(A_0.c()))
			{
				d4n d4n = A_0.e();
				return d4n != null && d4n.g();
			}
			return false;
		}

		// Token: 0x06001698 RID: 5784 RVA: 0x0006F3E8 File Offset: 0x0006D5E8
		internal void c(ej0 A_0)
		{
			A_0.b().d()["timeTillPlasma"] = 1;
		}

		// Token: 0x06001699 RID: 5785 RVA: 0x0006F408 File Offset: 0x0006D608
		internal void d(ej0 A_0)
		{
			int num = A_0.b().d().GetPrimitivePropertyValue<int>("timeTillPlasma", new int?(0)).Value;
			num--;
			A_0.b().d()["timeTillPlasma"] = num;
			A_0.b().d()["trekkedToBay"] = false;
		}

		// Token: 0x0600169A RID: 5786 RVA: 0x0006F474 File Offset: 0x0006D674
		internal bool a(e1k A_0)
		{
			if (A_0.g().aa().Offense.au() == WeaponKey.Primary && !A_0.d().GetPrimitivePropertyValue<bool>("trekkedToBay", new bool?(false)).Value && !ein.a(A_0.g().a8()))
			{
				amc amc = new bzv(A_0.c().y6()).g();
				return ein.a(A_0.g().a8(), (amc != null) ? amc.a8() : null) != null;
			}
			return false;
		}

		// Token: 0x0600169B RID: 5787 RVA: 0x0006F510 File Offset: 0x0006D710
		internal bool b(e1k A_0)
		{
			if (A_0.g().aa().Offense.au() == WeaponKey.Primary && A_0.d().GetPrimitivePropertyValue<int>("timeTillPlasma", new int?(0)).Value <= 0)
			{
				amc amc = new bzv(A_0.c().y6()).g();
				if (amc != null && amc.aa().Defense.q().zo() > 50f)
				{
					blk blk = new bzv(A_0.c().y6()).c(amc.a8().qe());
					if (blk.b() && blk.a().f() == cem.d)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x0600169C RID: 5788 RVA: 0x0006F5D8 File Offset: 0x0006D7D8
		internal bool c(e1k A_0)
		{
			if (A_0.g().aa().Offense.au() == WeaponKey.Secondary)
			{
				amc amc = new bzv(A_0.c().y6()).g();
				if (amc == null || amc.a8() == null || amc.aa().Dead)
				{
					return !eth.a(A_0.c());
				}
				blk blk = new bzv(A_0.c().y6()).c(amc.a8().qe());
				HorizontalDirection? horizontalDirection = aw1.a(A_0.g().a8(), amc.a8(), false);
				if (horizontalDirection == null || horizontalDirection.Value != A_0.g().a8().VisualDirection)
				{
					return true;
				}
				double num = aw1.b(A_0.g().a8(), amc.a8());
				if (!blk.b() || blk.a().f() != cem.d || num > (double)A_0.g().aa().Offense.u().TypedDefinition.ad() - 0.5)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0600169D RID: 5789 RVA: 0x0006F714 File Offset: 0x0006D914
		internal cst a(a6w A_0)
		{
			ale ale = A_0.b().g().a8().k.b;
			if (ale != null)
			{
				amc amc = new bzv(A_0.b().c().y6()).g();
				ak1 ak = Enumerable.FirstOrDefault<ak1>(ein.a(A_0.b().g().a8(), (amc != null) ? amc.a8() : null).l);
				if (ak != null)
				{
					A_0.b().d()["trekkedToBay"] = true;
					return ale.a(ak, 0.0, 1, 0, true);
				}
			}
			A_0.b().d()["trekkedToBay"] = true;
			return null;
		}

		// Token: 0x0600169E RID: 5790 RVA: 0x0006F7E0 File Offset: 0x0006D9E0
		internal void b(ej0 A_0)
		{
			if (A_0.b().g().aa().Offense.au() == WeaponKey.Primary)
			{
				amc amc = new bzv(A_0.b().c().y6()).g();
				if ((amc != null && amc.a8() != null) || (!A_0.b().g().aa().IsInCombat && eth.a(A_0.b().c())))
				{
					if (amc != null && amc.a8() != null)
					{
						aw1.b(A_0.b().g().a8(), amc.a8(), false);
					}
					A_0.b().g().aa().Offense.a(WeaponKey.Secondary);
					awx awx = new awx();
					awx.a(m7.b);
					List<auv> list = awx.ad();
					bfq bfq = new bfq("transformation", "PlasmaSentryActivate");
					bfq.a(true);
					list.Add(new a4s(bfq, null, new ar7(A_0.b().g().a8()), null));
					awx.ad().Add(new e4t(A_0.b().g(), CharacterState.Custom1, dz6.b(cux.a), 0, null, 1));
					awx.ad().Add(new a4s(new epw(new CharacterState?(CharacterState.Custom1)), null, new ar7(A_0.b().g().a8()), null));
					awx.ad().Add(new a4s(new b16(new int?(9)), null, new ar7(A_0.b().g().a8()), null));
					A_0.b().g().a8().i.b.b(awx, atp.a);
				}
			}
		}

		// Token: 0x0600169F RID: 5791 RVA: 0x0006F9B4 File Offset: 0x0006DBB4
		internal void a(ej0 A_0)
		{
			if (A_0.b().g().aa().Offense.au() == WeaponKey.Secondary)
			{
				A_0.b().g().aa().Offense.a(WeaponKey.Primary);
				A_0.b().d()["timeTillPlasma"] = 3;
				awx awx = new awx();
				awx.a(m7.b);
				List<auv> list = awx.ad();
				bfq bfq = new bfq("transformation", "PlasmaSentryDeactivate");
				bfq.a(true);
				list.Add(new a4s(bfq, null, new ar7(A_0.b().g().a8()), null));
				awx.ad().Add(new e4t(A_0.b().g(), CharacterState.Custom2, dz6.b(cux.a), 0, null, 1));
				awx.ad().Add(new a4s(new epw(null), null, new ar7(A_0.b().g().a8()), null));
				awx.ad().Add(new a4s(new b16(null), null, new ar7(A_0.b().g().a8()), null));
				A_0.b().g().a8().i.b.b(awx, atp.a);
			}
		}

		// Token: 0x060016A0 RID: 5792 RVA: 0x0006FB20 File Offset: 0x0006DD20
		internal int a(bud A_0)
		{
			if (A_0.b().c().y6().GetPrimitivePropertyValue<int>(ddq.j, null) == null)
			{
				eth.k(A_0.b().c());
			}
			ak1 ak = eth.l(A_0.b().c());
			if (ak != null)
			{
				ale ale = A_0.b().c().a8().k.b;
				if (ale != null)
				{
					ny ny = ale.a8().i.b;
					if (ny != null && A_0.b().g().aa().Offense.au() == WeaponKey.Secondary)
					{
						djk djk = ale.a(ak, 3.0, 1, 0, false);
						if (djk != null)
						{
							A_0.b().g().aa().Offense.a(WeaponKey.Primary);
							awx awx = new awx();
							awx.a(m7.b | m7.k);
							awx.a(false);
							List<auv> list = awx.ad();
							bfq bfq = new bfq("transformation", "PlasmaSentryDeactivate");
							bfq.a(true);
							list.Add(new a4s(bfq, null, new ar7(A_0.b().g().a8()), null));
							awx.ad().Add(new e4t(A_0.b().g(), CharacterState.Custom2, dz6.b(cux.a), 0, null, 1));
							awx.ad().Add(new a4s(new epw(null), null, new ar7(A_0.b().g().a8()), null));
							awx.ad().Add(new a4s(new b16(null), null, new ar7(A_0.b().g().a8()), null));
							awx.ad().Add(djk);
							ny.b(awx, atp.a);
						}
					}
					else
					{
						ale.a(ak, 3.0, 1, 0, true);
					}
					return 1;
				}
			}
			return 0;
		}

		// Token: 0x04000D37 RID: 3383
		public static readonly dzw.a a = new dzw.a();

		// Token: 0x04000D38 RID: 3384
		public static Func<e1k, bool> b;

		// Token: 0x04000D39 RID: 3385
		public static Action<ej0> c;

		// Token: 0x04000D3A RID: 3386
		public static Action<ej0> d;

		// Token: 0x04000D3B RID: 3387
		public static Func<e1k, bool> e;

		// Token: 0x04000D3C RID: 3388
		public static Func<e1k, bool> f;

		// Token: 0x04000D3D RID: 3389
		public static Func<e1k, bool> g;

		// Token: 0x04000D3E RID: 3390
		public static Func<a6w, cst> h;

		// Token: 0x04000D3F RID: 3391
		public static Action<ej0> i;

		// Token: 0x04000D40 RID: 3392
		public static Action<ej0> j;

		// Token: 0x04000D41 RID: 3393
		public static Func<bud, int> k;
	}
}
