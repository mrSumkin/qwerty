using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.References;
using Ouroboros.Playfield.Space;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001578 RID: 5496
[eiz("S25")]
[Serializable]
public sealed class bob : d64, ISerializable
{
	// Token: 0x06007A38 RID: 31288 RVA: 0x00331EE0 File Offset: 0x003300E0
	private bob(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007A39 RID: 31289 RVA: 0x00331EEC File Offset: 0x003300EC
	public bob()
	{
	}

	// Token: 0x06007A3A RID: 31290 RVA: 0x00331EF8 File Offset: 0x003300F8
	protected override bool gq()
	{
		if (!base.gq())
		{
			return false;
		}
		awq.a(base.c().aa());
		cd1 cd = base.c().aa().Offense.u();
		if (cd.TypedDefinition != null && base.b().a8().j == cgy.b && base.b().a8().Area == base.c().a8().Area)
		{
			double a_ = aw1.b(base.c().a8(), base.b().a8());
			double a_2 = awq.a(base.vg().e(), base.b(), a_);
			cwt cwt = euf.a(base.c().aa(), base.b().aa(), a_, awq.a(base.c(), base.b(), null, null), 0.0, base.b().a8().l(), base.c().aa().Darkvision, cd.CurrentBullet, awq.f(base.c()), a_2, false, null, null, true, null);
			double a_3;
			if (cwt.e)
			{
				a_3 = 1.0 + base.c().aa().Offense.am();
			}
			else
			{
				a_3 = 1.0;
			}
			int num = eyv.a(base.vg().e().b9() as coh);
			cwt.f.Add(euf.a(ezy.a(base.vg().e().b8(), num), a_3));
			amc a_4 = base.c();
			amc a_5 = base.b();
			cwt a_6 = cwt;
			cd1 a_7 = cd;
			enp a_8 = new bob.a(this, num);
			bool a_9 = true;
			aig[] a_10 = new aig[]
			{
				new bob.b(num, base.c(), base.b())
			};
			awq.a(a_4, a_5, a_6, a_7, a_8, a_9, null, "incendiaryBolt", a_10, false, false, true, null, null);
			return true;
		}
		return false;
	}

	// Token: 0x02001579 RID: 5497
	[eiz("S25a")]
	[Serializable]
	private new sealed class a : enp, ISerializable
	{
		// Token: 0x06007A3B RID: 31291 RVA: 0x00332114 File Offset: 0x00330314
		private a(SerializationInfo A_0, StreamingContext A_1)
		{
			this.a = (A_0.GetValue("S25a:P", typeof(bob)) as bob);
			this.b = A_0.GetInt32("S25a:O");
		}

		// Token: 0x06007A3C RID: 31292 RVA: 0x00332150 File Offset: 0x00330350
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("S25a:P", this.a);
			info.AddValue("S25a:O", this.b);
		}

		// Token: 0x06007A3D RID: 31293 RVA: 0x00332174 File Offset: 0x00330374
		public a(bob A_0, int A_1)
		{
			this.a = A_0;
			this.b = A_1;
		}

		// Token: 0x06007A3E RID: 31294 RVA: 0x0033218C File Offset: 0x0033038C
		public void af(amc A_0, amc A_1, cwt A_2, cru A_3)
		{
			if (A_1 != null && A_2.b)
			{
				dtb dtb = new dtb();
				dtb.b(false);
				dtb.c(false);
				List<auv> list = dtb.ad();
				c5x a_ = A_1.a8();
				string a_2 = "ScorchGround";
				int a_3 = 1;
				double maxValue = double.MaxValue;
				bool a_4 = true;
				bool a_5 = true;
				float? a_6 = dz6.b();
				list.Add(new a7j(a_, a_2, a_3, maxValue, a_4, a_5, null, null, null, a_6, false, null));
				dtb.ad().Add(new a4s(new bfq(Guid.NewGuid().ToString(), "FireballSpread"), null, new ar7(A_1.a8()), null));
				dtb.ad().Add(new eu8(A_0.a8(), d8o.g, Enumerable.FirstOrDefault<ak1>(A_1.a8().l), 5, d0u.b * 2, null));
				if (A_3.a != null)
				{
					int num = Enumerable.Sum<csk>(Enumerable.Where<csk>(A_3.a, new Func<csk, bool>(bob.a.a.a.b)), new Func<csk, int>(bob.a.a.a.a));
					if (num > 0 && euf.a(ezy.b))
					{
						if (A_1.aa().Passive || A_1.aa().d(CharacterImmunities.Burning))
						{
							if (A_0 != null)
							{
								etm a_7 = new etm(new ap9(A_1.aa()), "burning");
								bey.a(a_7, A_0.aa(), A_1.aa(), A_1);
								a7v.a(a_7);
							}
							bmj.a(A_1.a8(), new ba0());
						}
						else
						{
							int a_8 = Math.Max(1, num / ezy.a);
							bk9 bk = new bk9((A_0 != null) ? A_0.aa() : null, 3 * d0u.b, a_8, false);
							dtb.ad().Add(new amd(A_1, new els[]
							{
								bk
							}));
							dd5.a(dtb, A_1);
							awq.a(dtb, A_1);
							if (A_0 != null && A_0.aa() is e3q && !(A_1.aa() is e3q))
							{
								cxc.a(eyy.b1);
							}
						}
					}
				}
				A_1.a8().Zone.ActionManager.g9(dtb, atp.a);
				dz6.a(dtb);
			}
		}

		// Token: 0x040030DE RID: 12510
		private bob a;

		// Token: 0x040030DF RID: 12511
		private int b;

		// Token: 0x0200157A RID: 5498
		[CompilerGenerated]
		[Serializable]
		private sealed class a
		{
			// Token: 0x06007A41 RID: 31297 RVA: 0x00332428 File Offset: 0x00330628
			internal bool b(csk A_0)
			{
				return A_0.DamageType == DamageType.Heat;
			}

			// Token: 0x06007A42 RID: 31298 RVA: 0x00332434 File Offset: 0x00330634
			internal int a(csk A_0)
			{
				return A_0.Amount;
			}

			// Token: 0x040030E0 RID: 12512
			public static readonly bob.a.a a = new bob.a.a();

			// Token: 0x040030E1 RID: 12513
			public static Func<csk, bool> b;

			// Token: 0x040030E2 RID: 12514
			public static Func<csk, int> c;
		}
	}

	// Token: 0x0200157B RID: 5499
	[eiz("S25b")]
	[Serializable]
	private sealed class b : aig, ISerializable
	{
		// Token: 0x06007A43 RID: 31299 RVA: 0x00332440 File Offset: 0x00330640
		private b(SerializationInfo A_0, StreamingContext A_1)
		{
			this.b = A_0.GetSingle("S25b:D");
			this.c = (a1q)A_0.GetValue("S25b:B", typeof(a1q));
			this.d = (A_0.GetValue("S25b:A", typeof(EntityAspectReference<amc, amc>)) as EntityAspectReference<amc, amc>);
			this.e = (A_0.GetValue("S25b:P", typeof(EntityAspectReference<amc, amc>)) as EntityAspectReference<amc, amc>);
			this.f = (A_0.GetValue("S25b:T", typeof(HashSet<Point>)) as HashSet<Point>);
			this.g = (A_0.GetValue("S25b:E", typeof(HashSet<Guid>)) as HashSet<Guid>);
		}

		// Token: 0x06007A44 RID: 31300 RVA: 0x0033251C File Offset: 0x0033071C
		public void GetObjectData(SerializationInfo info, StreamingContext ctx)
		{
			info.AddValue("S25b:D", this.b);
			info.AddValue("S25b:B", this.c);
			info.AddValue("S25b:A", this.d);
			info.AddValue("S25b:P", this.e);
			info.AddValue("S25b:T", this.f);
			info.AddValue("S25b:E", this.g);
		}

		// Token: 0x06007A45 RID: 31301 RVA: 0x00332594 File Offset: 0x00330794
		public b(int A_0, amc A_1, amc A_2)
		{
			this.c = ezy.b(A_1.aa(), A_0);
			this.d = new EntityAspectReference<amc, amc>(A_1);
			this.e = new EntityAspectReference<amc, amc>(A_2);
		}

		// Token: 0x06007A46 RID: 31302 RVA: 0x003325E8 File Offset: 0x003307E8
		public bool hj(b0b A_0, Vector3 A_1, Vector3 A_2, float A_3)
		{
			if ((this.b += A_3) >= 1.5f)
			{
				this.b -= 1.5f;
				if (A_0 != null && A_0.Area != null)
				{
					aud a_ = A_0.Area;
					HorizontalDirection? a_2 = null;
					string a_3 = "Smoke";
					int a_4 = 1;
					double maxValue = double.MaxValue;
					float? num = dz6.b();
					boj.a(a_, A_1, a_2, a_3, a_4, maxValue, null, null, num, null);
				}
			}
			if (this.d.ao() != null && A_0 != null && A_0.Area != null)
			{
				Point point = A_0.aj().a();
				if (!this.f.Contains(point))
				{
					ak1 ak = A_0.Area.a(point);
					if (ak != null)
					{
						foreach (b0b b0b in Enumerable.ToList<b0b>(ak.c.Values))
						{
							c5x c5x = (c5x)b0b;
							if (c5x.h.b != null && !this.g.Contains(c5x.qe()))
							{
								if (c5x.h.b != this.d.ao() && c5x.h.b != this.e.ao())
								{
									dtb dtb = new dtb();
									dtb.b(false);
									dtb.c(false);
									List<auv> list = dtb.ad();
									c5x a_5 = c5x;
									string a_6 = "ExplosionSmall";
									int a_7 = 1;
									double maxValue2 = double.MaxValue;
									bool a_8 = true;
									bool a_9 = true;
									float? num = dz6.b();
									list.Add(new a7j(a_5, a_6, a_7, maxValue2, a_8, a_9, null, null, null, num, false, null));
									dtb.ad().Add(new a4s(new bfq(Guid.NewGuid().ToString(), "Flare"), null, new ar7(c5x), null));
									dtb.ad().Add(new akg(this.d.ao(), c5x.h.b, this.a(c5x.h.b), new b7x(null), false));
									if (this.d.ao().aa() is e3q)
									{
										awq.a(dtb, this.d.ao().a8(), c5x, true, true);
									}
									dtb.ad().Add(new eu8(this.d.ao().a8(), d8o.g, ak, 5, d0u.b * 2, null));
									c5x.Zone.ActionManager.g9(dtb, atp.a);
									dz6.a(dtb);
								}
								this.g.Add(c5x.qe());
							}
						}
					}
					this.f.Add(point);
				}
			}
			return false;
		}

		// Token: 0x06007A47 RID: 31303 RVA: 0x0033291C File Offset: 0x00330B1C
		private cwt a(amc A_0)
		{
			cwt cwt = new cwt();
			cwt.b = true;
			cwt.f.Add(euf.a(this.c, 1.0));
			cwt.v = "зажигательный болт";
			cwt.h = ImpactSpeed.VeryHigh;
			cwt.ae = new WeaponSubtype?(WeaponSubtype.Crossbow);
			if (this.d.ao() != null)
			{
				cwt.i = new ap9(this.d.ao().aa());
			}
			cwt.j = new ap9(A_0.aa());
			return cwt;
		}

		// Token: 0x040030E3 RID: 12515
		private const float a = 1.5f;

		// Token: 0x040030E4 RID: 12516
		private float b;

		// Token: 0x040030E5 RID: 12517
		private a1q c;

		// Token: 0x040030E6 RID: 12518
		private EntityAspectReference<amc, amc> d;

		// Token: 0x040030E7 RID: 12519
		private EntityAspectReference<amc, amc> e;

		// Token: 0x040030E8 RID: 12520
		private HashSet<Point> f = new HashSet<Point>();

		// Token: 0x040030E9 RID: 12521
		private HashSet<Guid> g = new HashSet<Guid>();
	}
}
