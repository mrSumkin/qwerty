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

// Token: 0x02001601 RID: 5633
[eiz("LCO")]
[Serializable]
public sealed class bvt : a6k, ISerializable
{
	// Token: 0x06007BEB RID: 31723 RVA: 0x0033F814 File Offset: 0x0033DA14
	private bvt(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007BEC RID: 31724 RVA: 0x0033F820 File Offset: 0x0033DA20
	public bvt()
	{
	}

	// Token: 0x06007BED RID: 31725 RVA: 0x0033F82C File Offset: 0x0033DA2C
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		ak1 ak = base.vg().h() as ak1;
		if (ak == null || ak.Area == null)
		{
			return dc4.e;
		}
		base.vg().i();
		double a_ = aw1.a(base.vg().q(), ak);
		int a_2 = euf.b(base.vg().e().b8(), base.vg().e().b8().Skills.Get<rs>().g(), a_, 0.0);
		ak1 ak2 = awq.a(this, ak, a_2, false);
		qy qy = new qy();
		qy.b(false);
		qy.c(false);
		b0b b0b = null;
		dvv item = es2.a(base.vg().q(), ak2.Location.a() + new Vector3(0.5f, 0.5f, 0f), "IceOrb", out b0b, null, null, true, 0.5f, null);
		if (b0b != null && b0b.Zone != null)
		{
			if (base.vg().q() != null && base.vg().q().h.b != null && base.vg().q().Zone != null)
			{
				u6.a(base.vg().q().h.b);
				u6.a(base.vg().q().h.b, true);
			}
			bvt.a(b0b);
			qy.ad().Add(item);
			c7 item2 = new c7(b0b, false, false, true, false);
			qy.ad().Add(item2);
			bfq bfq = new bfq();
			bfq.b("cyrokinesisHit" + Guid.NewGuid().ToString());
			bfq.c("CyrokinesisHit");
			bfq bfq2 = new bfq();
			bfq2.b("IceOrbSmash" + Guid.NewGuid().ToString());
			bfq2.c("IceOrbSmash");
			bfq2.a(0.5f);
			c5x c5x = Enumerable.FirstOrDefault<b0b>(ak2.c.Values) as c5x;
			if (c5x != null)
			{
				qy.ad().Add(new a4s(bfq, null, new ar7(c5x), null));
				qy.ad().Add(new a4s(bfq2, null, new ar7(c5x), null));
				eym.a(qy, c5x, (double)aju.bk);
			}
			aud a_3 = ak.Area;
			Vector3 a_4 = ak.Location.a();
			string a_5 = "ColdHit";
			int a_6 = 1;
			double maxValue = double.MaxValue;
			float? a_7 = dz6.b();
			au0 item3 = new au0(a_3, a_4, a_5, a_6, maxValue, null, null, a_7);
			qy.ad().Add(item3);
			aud a_8 = ak.Area;
			Vector3 a_9 = ak.Location.a();
			string a_10 = "IceOrbExplosion";
			int a_11 = 1;
			double maxValue2 = double.MaxValue;
			a_7 = dz6.b();
			au0 item4 = new au0(a_8, a_9, a_10, a_11, maxValue2, null, null, a_7);
			qy.ad().Add(item4);
			base.vg().q().c().a("cryokinesisLaunch" + Guid.NewGuid().ToString(), "CyrokinesisLaunch", 1f, c9z.a, false, false);
			eym.a(base.vg().q(), (double)aju.bi);
			qy.ad().Add(new bvt.b(base.vg().q().h.b, ak2));
			b0b.Zone.ActionManager.g9(qy, atp.a);
			dz6.a(qy);
			return dc4.c;
		}
		return dc4.e;
	}

	// Token: 0x06007BEE RID: 31726 RVA: 0x0033FC10 File Offset: 0x0033DE10
	private static void a(b0b A_0)
	{
		b4u aspect = A_0.GetAspect<b4u>();
		if (aspect != null)
		{
			aspect.b().Add(new ee1());
		}
	}

	// Token: 0x02001602 RID: 5634
	[eiz("LCO_a")]
	[Serializable]
	private sealed class b : b1z, ISerializable
	{
		// Token: 0x06007BEF RID: 31727 RVA: 0x0033FC3C File Offset: 0x0033DE3C
		private b(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
		{
			this.a = (EntityAspectReference<amc, amc>)A_0.GetValue("LCO_a:I", typeof(EntityAspectReference<amc, amc>));
			this.b = (edx)A_0.GetValue("LCO_a:T", typeof(edx));
		}

		// Token: 0x06007BF0 RID: 31728 RVA: 0x0033FC94 File Offset: 0x0033DE94
		public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
		{
			info.AddValue("LCO_a:I", this.a);
			info.AddValue("LCO_a:T", this.b);
		}

		// Token: 0x06007BF1 RID: 31729 RVA: 0x0033FCB8 File Offset: 0x0033DEB8
		public b(amc A_0, ak1 A_1)
		{
			this.a = new EntityAspectReference<amc, amc>(A_0);
			this.b = new edx(A_1);
		}

		// Token: 0x06007BF2 RID: 31730 RVA: 0x0033FCDC File Offset: 0x0033DEDC
		protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
		{
			if (this.a.ao() == null || this.b.ao() == null)
			{
				return dc4.e;
			}
			Vector3 a_ = new Vector3(0.15f, 0.15f, 0.15f);
			Vector2 vector = this.b.ao().Location.b() + new Vector2(0.5f, 0.5f) - a_.b() / 2f;
			int num = d7l.i / 5;
			int num2 = 0;
			double num3 = 0.2;
			double num4 = 0.1;
			int i = 0;
			while (i < d7l.i)
			{
				bvt.a a = new bvt.a(this.a.ao());
				Vector2 vector2 = bvt.b.a((float)(i * (360 / d7l.i)));
				Vector2 value = vector2 / 100f;
				if (num2 >= num)
				{
					goto IL_1C6;
				}
				bool flag = false;
				foreach (b0b b0b in this.b.ao().c.Values)
				{
					c5x c5x = (c5x)b0b;
					if (c5x.h.b != null)
					{
						double num5 = (double)Math.Abs(Vector2.Distance(c5x.aj().b(), vector));
						if ((double)Math.Abs(Vector2.Distance(c5x.aj().b(), vector + value)) <= num5)
						{
							if (cuo.a.NextDouble() < num3)
							{
								num2++;
								a.kn(this.b.ao().Area, null, c5x, amu.b);
								flag = true;
								break;
							}
							num3 += num4;
						}
					}
				}
				if (!flag)
				{
					goto IL_1C6;
				}
				IL_314:
				i++;
				continue;
				IL_1C6:
				Vector2 vector3 = vector + vector2 * 5f;
				b0b b0b2;
				bpr bpr = es2.a(new Vector3(vector.X, vector.Y, 0.5f), new Vector3(vector3.X, vector3.Y, 1.3f), this.b.ao().Area, "IceShard", new aig[]
				{
					a
				}, out b0b2);
				bpr.a(new bvt.a(this.a.ao()));
				c5x c5x2 = b0b2 as c5x;
				if (c5x2 != null)
				{
					c5x2.Size = a_;
					if (c5x2.i.b == null)
					{
						ny aspect = new ny(c5x2);
						c5x2.SetAspect<ny>(aspect);
					}
					dtb dtb = new dtb();
					dtb.b(false);
					dtb.b(false);
					dtb.ad().Add(bpr);
					dtb.ad().Add(new c7(c5x2, false, false, true, false));
					c5x2.i.b.b(dtb, atp.a);
					dz6.a(dtb);
				}
				this.b.ao().Zone.ActionManager.g9(new duh(this.a.ao(), new string[]
				{
					b0c.a
				}), atp.a);
				goto IL_314;
			}
			return dc4.c;
		}

		// Token: 0x06007BF3 RID: 31731 RVA: 0x00340020 File Offset: 0x0033E220
		private static Vector2 a(float A_0)
		{
			return new Vector2((float)Math.Cos((double)A_0), (float)Math.Sin((double)A_0));
		}

		// Token: 0x06007BF4 RID: 31732 RVA: 0x00340038 File Offset: 0x0033E238
		private static float a(Vector2 A_0)
		{
			return (float)Math.Atan2((double)A_0.Y, (double)A_0.X);
		}

		// Token: 0x0400313E RID: 12606
		private new EntityAspectReference<amc, amc> a;

		// Token: 0x0400313F RID: 12607
		private edx b;
	}

	// Token: 0x02001603 RID: 5635
	[eiz("LCO_b")]
	[Serializable]
	private new sealed class a : aig, a7o, ISerializable
	{
		// Token: 0x06007BF5 RID: 31733 RVA: 0x00340054 File Offset: 0x0033E254
		private a(SerializationInfo A_0, StreamingContext A_1)
		{
			this.b = (EntityAspectReference<amc, amc>)A_0.GetValue("LCO_b:I", typeof(EntityAspectReference<amc, amc>));
			this.c = (EntityAspectReference<amc, amc>)A_0.GetValue("LCO_b:T", typeof(EntityAspectReference<amc, amc>));
			this.d = A_0.GetBoolean("LCO_b:C");
		}

		// Token: 0x06007BF6 RID: 31734 RVA: 0x003400B8 File Offset: 0x0033E2B8
		public void GetObjectData(SerializationInfo info, StreamingContext ctx)
		{
			info.AddValue("LCO_b:I", this.b);
			info.AddValue("LCO_b:T", this.c);
			info.AddValue("LCO_b:C", this.d);
		}

		// Token: 0x06007BF7 RID: 31735 RVA: 0x003400F0 File Offset: 0x0033E2F0
		static a()
		{
			bvt.a.a.c(new byte[]
			{
				2,
				5
			});
		}

		// Token: 0x06007BF8 RID: 31736 RVA: 0x00340118 File Offset: 0x0033E318
		public a(amc A_0)
		{
			this.b = new EntityAspectReference<amc, amc>(A_0);
			this.d = A_0.aa().StatusEffects.a(b0c.a);
		}

		// Token: 0x06007BF9 RID: 31737 RVA: 0x00340154 File Offset: 0x0033E354
		public bool hj(b0b A_0, Vector3 A_1, Vector3 A_2, float A_3)
		{
			return A_0 != null && A_0.Area != null && (A_2.X <= 0f || A_2.Y <= 0f || A_2.X > (float)(A_0.Area.Size.c - 1) || A_2.Y > (float)(A_0.Area.Size.d - 1));
		}

		// Token: 0x06007BFA RID: 31738 RVA: 0x003401D4 File Offset: 0x0033E3D4
		public e0b kn(aud A_0, b0b A_1, b0b A_2, amu A_3)
		{
			if (this.b.ao() != null)
			{
				c5x c5x = A_2 as c5x;
				if (c5x != null && c5x.h.b != null)
				{
					cwt a_ = this.a(this.b.ao().aa(), c5x.h.b.aa());
					qy qy = new qy();
					qy.b(false);
					qy.c(false);
					awq.a(qy, this.b.ao().a8(), c5x, true, true);
					akg akg = new akg(this.b.ao(), c5x.h.b, a_, null, false);
					akg.q(new EventHandler<EventArgs>(this.a));
					qy.ad().Add(akg);
					c5x.Zone.ActionManager.g9(qy, atp.a);
					dz6.a(qy);
					this.c = new EntityAspectReference<amc, amc>(c5x.h.b);
					cix cix = c5x.Zone.ActionManager;
					c5x a_2 = c5x;
					string a_3 = "IceChipImpact";
					int a_4 = 1;
					double maxValue = double.MaxValue;
					bool a_5 = true;
					bool a_6 = true;
					float? a_7 = dz6.b();
					cix.g9(new a7j(a_2, a_3, a_4, maxValue, a_5, a_6, null, null, null, a_7, false, null), atp.a);
					c5x.c().a("IceHit");
					return e0b.b;
				}
			}
			return e0b.c;
		}

		// Token: 0x06007BFB RID: 31739 RVA: 0x0034033C File Offset: 0x0033E53C
		public e0b ko(aud A_0, b0b A_1, ak1 A_2, amu A_3)
		{
			if (A_2.Formation.c(8L))
			{
				foreach (b0b b0b in A_2.c.Values)
				{
					c5x c5x = (c5x)b0b;
					if (c5x.h.b != null && c5x.z == null)
					{
						this.kn(A_0, A_1, c5x, A_3);
					}
				}
				return e0b.b;
			}
			if (A_1 != null && A_1.Area != null)
			{
				cix cix = A_1.Zone.ActionManager;
				aud a_ = A_1.Area;
				Vector3 a_2 = A_1.Location;
				string a_3 = "IceChipImpact";
				int a_4 = 1;
				double maxValue = double.MaxValue;
				float? a_5 = dz6.b();
				cix.g9(new au0(a_, a_2, a_3, a_4, maxValue, null, null, a_5), atp.a);
				(Enumerable.FirstOrDefault<b0b>(A_2.c.Values) as c5x).c().a("IceHit");
			}
			return e0b.b;
		}

		// Token: 0x06007BFC RID: 31740 RVA: 0x00340458 File Offset: 0x0033E658
		public bjp kp(b0b A_0)
		{
			return bvt.a.a;
		}

		// Token: 0x06007BFD RID: 31741 RVA: 0x00340460 File Offset: 0x0033E660
		public bool? kq(b0b A_0)
		{
			c5x c5x = A_0 as c5x;
			if (c5x != null && c5x.h.b != null)
			{
				return new bool?(true);
			}
			return null;
		}

		// Token: 0x06007BFE RID: 31742 RVA: 0x0034049C File Offset: 0x0033E69C
		private cwt a(efk A_0, efk A_1)
		{
			bas bas = A_0.Offense.ag()[PsiSchool.Metathermics];
			eoj a_ = new eoj(this.b.ao().aa(), null, null);
			List<a1q> list = new List<a1q>();
			list.Add(d7l.a(a_));
			list.Add(d7l.b(a_));
			cwt cwt = new cwt();
			cwt.b = true;
			cwt.e = (!A_1.ImmuneToCriticalHits && (this.d || euf.a(euf.a(bas, A_1))));
			cwt.i = new ap9(A_0);
			cwt.j = new ap9(A_1);
			cwt.f = new List<csk>();
			foreach (a1q a_2 in list)
			{
				cwt.f.Add(euf.a(a_2, (double)(1f + (cwt.e ? bas.g() : 0f))));
			}
			cwt.h = ImpactSpeed.Low;
			cwt.k = "Криокинетическая сфера";
			cwt.ad["PsionicSource"] = PsiSchool.Metathermics;
			return cwt;
		}

		// Token: 0x06007BFF RID: 31743 RVA: 0x003405F4 File Offset: 0x0033E7F4
		[dcc("LCO_b:mARA_F")]
		private void a(object A_0, EventArgs A_1)
		{
			if (this.c.ao() == null)
			{
				return;
			}
			c5x c5x = this.c.ao().a8();
			if (c5x == null || c5x.h.b == null || c5x.h.b.aa().Dead || c5x.Zone == null)
			{
				return;
			}
			akg akg = A_0 as akg;
			if (akg == null || akg.b() == null || akg.b().a == null || akg.b().a.Count == 0)
			{
				return;
			}
			if (Enumerable.Sum<csk>(Enumerable.Where<csk>(akg.b().a, new Func<csk, bool>(bvt.a.a.a.a)), new Func<csk, int>(bvt.a.a.a.d)) > 0)
			{
				awq.e(c5x.h.b);
				double num = 1.0 - c5x.h.b.aa().Defense.af()[DamageType.Cold].c();
				if (c5x.h.b.aa().a(CharacterImmunities.Chill) || num <= 0.0)
				{
					etm a_ = new etm(new ap9(c5x.h.b.aa()), "эффекту переохлаждения");
					bey.a(a_, this.b.ao().aa(), c5x.h.b.aa(), c5x.h.b);
					a7v.a(a_);
					bmj.a(c5x, new ba0());
				}
				else
				{
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
						}
						else
						{
							etm a_3 = new etm(new ap9(c5x.h.b.aa()), "гипотермии");
							bey.a(a_3, this.b.ao().aa(), c5x.h.b.aa(), c5x.h.b);
							a7v.a(a_3);
							bmj.a(c5x, new ba0());
						}
					}
				}
			}
			if (cuo.a.NextDouble() < d7l.j)
			{
				int num3 = Enumerable.Sum<csk>(Enumerable.Where<csk>(akg.b().a, new Func<csk, bool>(bvt.a.a.a.c)), new Func<csk, int>(bvt.a.a.a.b));
				if (num3 > 0 && !c5x.h.b.aa().Passive && !c5x.h.b.aa().b(d8o.e) && !c5x.h.b.aa().d(CharacterImmunities.Bleeding))
				{
					int a_4 = Math.Max(1, num3 / d7l.l);
					a5e a_5 = new a5e((akg.n() != null) ? akg.n().aa().FactionId : null, d7l.l * d0u.b, a_4, "bleedingWound", null);
					c5x.h.b.aa().StatusEffects.a(a_5, false, false, false);
				}
			}
		}

		// Token: 0x04003140 RID: 12608
		private static bjp a = new bjp();

		// Token: 0x04003141 RID: 12609
		private EntityAspectReference<amc, amc> b;

		// Token: 0x04003142 RID: 12610
		private EntityAspectReference<amc, amc> c;

		// Token: 0x04003143 RID: 12611
		private bool d;

		// Token: 0x02001604 RID: 5636
		[CompilerGenerated]
		[Serializable]
		private sealed class a
		{
			// Token: 0x06007C02 RID: 31746 RVA: 0x00340B3C File Offset: 0x0033ED3C
			internal bool a(csk A_0)
			{
				return A_0.DamageType == DamageType.Cold;
			}

			// Token: 0x06007C03 RID: 31747 RVA: 0x00340B48 File Offset: 0x0033ED48
			internal int d(csk A_0)
			{
				return A_0.Amount;
			}

			// Token: 0x06007C04 RID: 31748 RVA: 0x00340B54 File Offset: 0x0033ED54
			internal bool c(csk A_0)
			{
				return A_0.DamageType == DamageType.Mechanical;
			}

			// Token: 0x06007C05 RID: 31749 RVA: 0x00340B60 File Offset: 0x0033ED60
			internal int b(csk A_0)
			{
				return A_0.Amount;
			}

			// Token: 0x04003144 RID: 12612
			public static readonly bvt.a.a a = new bvt.a.a();

			// Token: 0x04003145 RID: 12613
			public static Func<csk, bool> b;

			// Token: 0x04003146 RID: 12614
			public static Func<csk, int> c;

			// Token: 0x04003147 RID: 12615
			public static Func<csk, bool> d;

			// Token: 0x04003148 RID: 12616
			public static Func<csk, int> e;
		}
	}
}
