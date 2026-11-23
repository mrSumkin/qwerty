using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.References;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Comm;

// Token: 0x020015D4 RID: 5588
[eiz("CBA0")]
[Serializable]
public sealed class b2a : a6k, ISerializable
{
	// Token: 0x06007B45 RID: 31557 RVA: 0x00336EEC File Offset: 0x003350EC
	private b2a(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007B46 RID: 31558 RVA: 0x00336EF8 File Offset: 0x003350F8
	public b2a()
	{
	}

	// Token: 0x06007B47 RID: 31559 RVA: 0x00336F04 File Offset: 0x00335104
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		ak1 ak = base.vg().h() as ak1;
		if (ak == null || ak.Area == null || ak.Zone == null)
		{
			return dc4.e;
		}
		base.vg().i();
		if (base.vg().q() != null && base.vg().q().h.b != null && base.vg().q().Zone != null)
		{
			u6.a(base.vg().q().h.b);
			u6.a(base.vg().q().h.b, true);
		}
		qy qy = new qy();
		qy.b(false);
		qy.c(false);
		awb item = new awb(ak, new b2a.a(base.vg().e(), base.vg().q().h.b), null, (float)base.vg().e().g(), null, null, false);
		qy.ad().Add(item);
		ak.Zone.ActionManager.g9(qy, atp.a);
		dz6.a(qy);
		return dc4.c;
	}

	// Token: 0x020015D5 RID: 5589
	[eiz("CBA0a")]
	[Serializable]
	private new class a : cci, ISerializable
	{
		// Token: 0x06007B48 RID: 31560 RVA: 0x0033704C File Offset: 0x0033524C
		protected a(SerializationInfo A_0, StreamingContext A_1)
		{
			this.a = (eu7)A_0.GetValue("CBA0a:P", typeof(eu7));
			this.b = (EntityAspectReference<amc, amc>)A_0.GetValue("CBA0a:I", typeof(EntityAspectReference<amc, amc>));
			this.c = (A_0.GetValue("CBA0a:C", typeof(HashSet<Guid>)) as HashSet<Guid>);
		}

		// Token: 0x06007B49 RID: 31561 RVA: 0x003370CC File Offset: 0x003352CC
		public void GetObjectData(SerializationInfo info, StreamingContext ctx)
		{
			info.AddValue("CBA0a:P", this.a);
			info.AddValue("CBA0a:I", this.b);
			info.AddValue("CBA0a:C", this.c);
		}

		// Token: 0x06007B4A RID: 31562 RVA: 0x00337104 File Offset: 0x00335304
		public a(eu7 A_0, amc A_1)
		{
			this.a = A_0;
			if (A_1 != null)
			{
				this.b = new EntityAspectReference<amc, amc>(A_1);
			}
		}

		// Token: 0x06007B4B RID: 31563 RVA: 0x00337134 File Offset: 0x00335334
		public void cq(aud A_0, Point A_1, float A_2)
		{
			if (this.a == null || this.b == null || this.b.ao() == null)
			{
				return;
			}
			ak1 ak = A_0.b(A_1.X, A_1.Y);
			if (ak != null && !ak.Formation.b(4L))
			{
				bool flag = false;
				List<amc> list = new List<amc>();
				foreach (b0b b0b in ak.c.Values)
				{
					c5x c5x = (c5x)b0b;
					if (c5x.h.b != null)
					{
						flag = true;
						if (!this.c.Contains(c5x.qe()))
						{
							this.c.Add(c5x.qe());
							list.Add(c5x.h.b);
						}
					}
				}
				c5x c5x2;
				if (flag)
				{
					c5x2 = vq.a("objects\\obstacles\\IceWall", ak.Zone, new bt4(ak.Area.y8(), ak.Location.a()), false);
				}
				else
				{
					c5x2 = vq.a("object\\obstacles\\IceWall", ak.Zone, new bt4(ak.Area.y8(), ak.Location.a()), false);
				}
				if (c5x2 != null)
				{
					c5x2.ae = new float?(0f);
					if (aw1.a(ak))
					{
						c5x c5x3 = vq.a("floor\\IceWallBase", ak.Zone, new bt4(ak.Area.y8(), ak.Location.a()), false);
						if (c5x3 != null)
						{
							if (c5x3.o.b != null)
							{
								c5x3.o.b.b.Y = cuo.a.Next(3);
							}
							cm aspect = new cm(c5x3, 60000, false);
							c5x3.SetAspect<cm>(aspect);
							dtb dtb = new dtb();
							dtb.b(false);
							dtb.c(false);
							if (c5x3.o.b != null)
							{
								List<auv> list2 = dtb.ad();
								dqm dqm = new dqm(c5x3.o.b);
								dqm.b(0);
								dqm.c(9);
								dqm.a((double)dz6.b(50));
								list2.Add(dqm);
							}
							ak.Zone.ActionManager.g9(dtb, atp.a);
						}
					}
					c5x c5x4 = Enumerable.FirstOrDefault<b0b>(Enumerable.Where<b0b>(ak.c.Values, new Func<b0b, bool>(b2a.a.a.a.a))) as c5x;
					if (c5x4 == null)
					{
						c5x4 = c5x2;
					}
					amc aspect2 = c5x2.GetAspect<amc>();
					if (aspect2 != null)
					{
						c8d c8d = aspect2.aa().Gear.l().Item;
						if (c8d != null)
						{
							du2 item = e7j.a(this.a);
							c8d.fu().i().Add(item);
						}
						string a_ = this.a.b8().FactionId;
						if (a_ == asp.a)
						{
							aspect2.aa().FactionId = asp.c;
						}
						else
						{
							aspect2.aa().FactionId = a_;
						}
						aspect2.aa().Defense.p = new int?(e7j.c(this.a));
						int num = e7j.d(this.a);
						a3f a3f = new a3f(c5x2);
						a3f.a()["Duration"] = num;
						c5x2.SetAspect<a3f>(a3f);
						dm dm = new dm(c5x2);
						dm.d().Add(new cxz("IceWall_Tick"));
						c5x2.SetAspect<dm>(dm);
					}
					c5x2.VisualPriority = 10;
					c5x2.Location = ak.Location.a();
					c5x2.Layer = aju.x;
					dtb dtb2 = new dtb();
					dtb2.b(false);
					dtb2.c(false);
					if (c5x2.o.b != null)
					{
						c5x2.o.b.b.Y = cuo.a.Next(3);
						dtb2.ad().Add(new bm3(dz6.b(300)));
						List<auv> list3 = dtb2.ad();
						ch3 ch = new ch3();
						float? num2 = null;
						ch.a(num2);
						list3.Add(new a4s(ch, null, new ar7(c5x2), null));
						dtb2.ad().Add(new a4s(new bfq("IceWallFreeze"), null, new ar7(c5x4), null));
						List<auv> list4 = dtb2.ad();
						dqm dqm2 = new dqm(c5x2.o.b);
						dqm2.b(0);
						dqm2.c(6);
						dqm2.a((double)dz6.b(30));
						list4.Add(dqm2);
					}
					if (flag)
					{
						foreach (amc amc in list)
						{
							awq.a(dtb2, this.b.ao().a8(), amc.a8(), false, true);
							cwt a_2 = this.a(this.a.b8(), amc.aa());
							akg akg = new akg(this.b.ao(), amc, a_2, null, false);
							akg.q(new EventHandler<EventArgs>(this.a));
							dtb2.ad().Add(akg);
						}
						List<auv> list5 = dtb2.ad();
						aud a_3 = ak.Area;
						Vector3 a_4 = ak.Location.a() + new Vector3(0f, 0f, 0.5f);
						string a_5 = "IceWallExplosion";
						int a_6 = 1;
						double maxValue = double.MaxValue;
						float? num2 = new float?(dz6.c());
						list5.Add(new au0(a_3, a_4, a_5, a_6, maxValue, null, null, num2));
						dtb2.ad().Add(new a4s(new bfq("IceShattering"), null, new ar7(c5x4), null));
						dtb2.ad().Add(new c7(c5x2, false, false, true, false));
					}
					else if (c5x2.o.b != null)
					{
						List<auv> list6 = dtb2.ad();
						dqm dqm3 = new dqm(c5x2.o.b);
						dqm3.b(6);
						dqm3.c(4);
						dqm3.a((double)dz6.b(90));
						list6.Add(dqm3);
						List<auv> list7 = dtb2.ad();
						dqm dqm4 = new dqm(c5x2.o.b);
						dqm4.b(10);
						dqm4.c(4);
						dqm4.a((double)dz6.b(120));
						list7.Add(dqm4);
					}
					ak.Zone.ActionManager.g9(dtb2, atp.a);
					dz6.a(dtb2);
				}
			}
		}

		// Token: 0x06007B4C RID: 31564 RVA: 0x00337830 File Offset: 0x00335A30
		private cwt a(efk A_0, efk A_1)
		{
			bas bas = A_0.Offense.ag()[PsiSchool.Metathermics];
			List<a1q> list = e7j.b(this.a);
			cwt cwt = new cwt();
			cwt.b = true;
			cwt.e = (!A_1.ImmuneToCriticalHits && euf.a(euf.a(bas, A_1)));
			cwt.i = new ap9(A_0);
			cwt.j = new ap9(A_1);
			cwt.f = new List<csk>();
			foreach (a1q a_ in list)
			{
				cwt.f.Add(euf.a(a_, (double)(1f + (cwt.e ? bas.g() : 0f))));
			}
			cwt.h = ImpactSpeed.Low;
			cwt.k = "Криогенный барьер";
			cwt.ad["PsionicSource"] = PsiSchool.Metathermics;
			return cwt;
		}

		// Token: 0x06007B4D RID: 31565 RVA: 0x00337948 File Offset: 0x00335B48
		[dcc("CBA0a:mARA_F")]
		private void a(object A_0, EventArgs A_1)
		{
			akg akg = A_0 as akg;
			if (akg == null || akg.m() == null)
			{
				return;
			}
			c5x c5x = akg.m().a8();
			if (c5x == null || c5x.h.b == null || c5x.h.b.aa().Dead || c5x.Zone == null)
			{
				return;
			}
			akg akg2 = A_0 as akg;
			if (akg2 == null || akg2.b() == null || akg2.b().a == null || akg2.b().a.Count == 0)
			{
				return;
			}
			if (Enumerable.Sum<csk>(Enumerable.Where<csk>(akg2.b().a, new Func<csk, bool>(b2a.a.a.a.a)), new Func<csk, int>(b2a.a.a.a.b)) > 0)
			{
				awq.e(c5x.h.b);
				double num = 1.0 - c5x.h.b.aa().Defense.af()[DamageType.Cold].c();
				if (c5x.h.b.aa().a(CharacterImmunities.Chill) || num <= 0.0)
				{
					etm a_ = new etm(new ap9(c5x.h.b.aa()), "эффекту переохлаждения");
					bey.a(a_, this.b.ao().aa(), c5x.h.b.aa(), c5x.h.b);
					a7v.a(a_);
					bmj.a(c5x, new ba0());
					return;
				}
				int num2;
				if (this.b.ao() != null)
				{
					num2 = euf.j(this.b.ao().aa());
				}
				else
				{
					num2 = 0;
				}
				c5x.h.b.aa().StatusEffects.a(new b34(h7.h + num2, h7.i), false, false, false);
				awq.c(c5x.h.b);
				if (!c5x.h.b.aa().SpecialStates.a && !c5x.h.b.aa().SpecialStates.h)
				{
					a20.a(c5x, new ap9(this.b.ao().aa()), new CombatSpeakEvent[]
					{
						CombatSpeakEvent.Hit_Frost
					});
				}
				if (this.b.ao().a8().IsPlayer && !c5x.IsPlayer)
				{
					cxc.a(eyy.bw);
				}
				if (this.b.ao() != null && this.b.ao().aa().Feats.Contains<qz>())
				{
					if (num > 0.0 && !c5x.h.b.aa().c(d8o.e))
					{
						e6y a_2 = new e6y(Convert.ToInt32((double)(qz.c + num2) * num), qz.b + this.b.ao().aa().GetSpecializationValue<ekf>(true) * ekf.a);
						c5x.h.b.aa().StatusEffects.a(a_2, false, false, false);
						return;
					}
					etm a_3 = new etm(new ap9(c5x.h.b.aa()), "гипотермии");
					bey.a(a_3, this.b.ao().aa(), c5x.h.b.aa(), c5x.h.b);
					a7v.a(a_3);
					bmj.a(c5x, new ba0());
				}
			}
		}

		// Token: 0x04003110 RID: 12560
		private eu7 a;

		// Token: 0x04003111 RID: 12561
		private EntityAspectReference<amc, amc> b;

		// Token: 0x04003112 RID: 12562
		private HashSet<Guid> c = new HashSet<Guid>();

		// Token: 0x020015D6 RID: 5590
		[CompilerGenerated]
		[Serializable]
		private sealed class a
		{
			// Token: 0x06007B50 RID: 31568 RVA: 0x00337D54 File Offset: 0x00335F54
			internal bool a(b0b A_0)
			{
				return A_0.IsFloor || A_0.IsGround;
			}

			// Token: 0x06007B51 RID: 31569 RVA: 0x00337D6C File Offset: 0x00335F6C
			internal bool a(csk A_0)
			{
				return A_0.DamageType == DamageType.Cold;
			}

			// Token: 0x06007B52 RID: 31570 RVA: 0x00337D78 File Offset: 0x00335F78
			internal int b(csk A_0)
			{
				return A_0.Amount;
			}

			// Token: 0x04003113 RID: 12563
			public static readonly b2a.a.a a = new b2a.a.a();

			// Token: 0x04003114 RID: 12564
			public static Func<b0b, bool> b;

			// Token: 0x04003115 RID: 12565
			public static Func<csk, bool> c;

			// Token: 0x04003116 RID: 12566
			public static Func<csk, int> d;
		}
	}
}
