using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.References;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001626 RID: 5670
[eiz("DNOA")]
[Serializable]
public sealed class csw : a6k, ISerializable
{
	// Token: 0x06007C95 RID: 31893 RVA: 0x00348088 File Offset: 0x00346288
	private csw(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007C96 RID: 31894 RVA: 0x00348094 File Offset: 0x00346294
	public csw()
	{
	}

	// Token: 0x06007C97 RID: 31895 RVA: 0x003480A0 File Offset: 0x003462A0
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (base.vg().q() == null || base.vg().q().h.b == null)
		{
			return dc4.e;
		}
		c5x c5x = base.vg().h() as c5x;
		if (c5x != null)
		{
			if (c5x.h.b != null && !c5x.h.b.aa().Dead && c5x.Zone != null)
			{
				if (base.vg().e().b8().GetMicrofeat<c37>() != null)
				{
					base.vg().q().c().a("Frighten");
				}
				new csw.a(base.vg().e(), base.vg().q().h.b).a(c5x);
				base.vg().q().Zone.ActionManager.g9(new duh(base.vg().q().h.b, new string[]
				{
					b0c.a
				}), atp.a);
				return dc4.c;
			}
			return dc4.e;
		}
		else
		{
			ak1 ak = base.vg().h() as ak1;
			if (ak != null && ak.Zone != null)
			{
				dtb dtb = new dtb();
				dtb.b(false);
				dtb.c(false);
				if (base.vg().e().b8().GetMicrofeat<c37>() != null)
				{
					dtb.ad().Add(new a4s(new bfq("Frighten"), null, new ar7(base.vg().q()), null));
				}
				awb item = new awb(ak, new csw.a(base.vg().e(), base.vg().q().h.b), null, (float)base.vg().e().g(), null, null, true);
				dtb.ad().Add(item);
				dtb.ad().Add(new duh(base.vg().q().h.b, new string[]
				{
					b0c.a
				}));
				ak.Zone.ActionManager.g9(dtb, atp.a);
				dz6.a(dtb);
				foreach (bgo a_ in base.vg().e().b8().StatusEffects.Get<bgo>())
				{
					base.vg().e().b8().StatusEffects.d(a_);
				}
				return dc4.c;
			}
			return dc4.e;
		}
	}

	// Token: 0x02001627 RID: 5671
	[eiz("DNOA_a")]
	[Serializable]
	private new class a : cci, ISerializable
	{
		// Token: 0x06007C98 RID: 31896 RVA: 0x00348370 File Offset: 0x00346570
		protected a(SerializationInfo A_0, StreamingContext A_1)
		{
			this.a = (eu7)A_0.GetValue("DNOA_a:P", typeof(eu7));
			this.b = (EntityAspectReference<amc, amc>)A_0.GetValue("DNOA_a:I", typeof(EntityAspectReference<amc, amc>));
			di7.ReadList<Guid>("DNOA_a:AE", ref this.c, A_0);
		}

		// Token: 0x06007C99 RID: 31897 RVA: 0x003483E0 File Offset: 0x003465E0
		public void GetObjectData(SerializationInfo info, StreamingContext ctx)
		{
			info.AddValue("DNOA_a:P", this.a);
			info.AddValue("DNOA_a:I", this.b);
			di7.WriteList<Guid>("DNOA_a:AE", this.c, info);
		}

		// Token: 0x06007C9A RID: 31898 RVA: 0x00348418 File Offset: 0x00346618
		public a(eu7 A_0, amc A_1)
		{
			this.a = A_0;
			if (A_1 != null)
			{
				this.b = new EntityAspectReference<amc, amc>(A_1);
			}
		}

		// Token: 0x06007C9B RID: 31899 RVA: 0x00348444 File Offset: 0x00346644
		public void cq(aud A_0, Point A_1, float A_2)
		{
			if (this.b != null && this.b.ao() != null)
			{
				ak1 ak = A_0.b(A_1.X, A_1.Y);
				if (ak != null)
				{
					foreach (b0b b0b in Enumerable.ToList<b0b>(ak.Entities))
					{
						c5x c5x = b0b as c5x;
						if (c5x != null && c5x.h.b != null && !this.c.Contains(b0b.qe()) && c5x.h.b != this.b.ao())
						{
							this.a(c5x);
							this.c.Add(c5x.qe());
						}
					}
				}
			}
		}

		// Token: 0x06007C9C RID: 31900 RVA: 0x00348538 File Offset: 0x00346738
		public void a(c5x A_0)
		{
			if (this.a == null || this.a.b8() == null || this.a.p() == null || this.b == null || this.b.ao() == null || this.b.ao().a8() == null)
			{
				return;
			}
			qy qy = new qy();
			qy.b(false);
			qy.c(false);
			cl9 microfeat = this.a.b8().GetMicrofeat<cl9>();
			string text;
			if (microfeat != null)
			{
				text = "Xpbl_SnakeOverload";
			}
			else
			{
				text = "NeuralOverload";
			}
			string a_ = text;
			int a_2 = 1;
			double maxValue = double.MaxValue;
			bool a_3 = true;
			bool a_4 = true;
			Vector3? a_5 = new Vector3?(new Vector3(0f, 0f, A_0.Size.Z / 2f));
			float? a_6 = dz6.b();
			a7j item = new a7j(A_0, a_, a_2, maxValue, a_3, a_4, a_5, null, null, a_6, false, null);
			qy.ad().Add(item);
			bfq bfq = new bfq();
			bfq.b("NeuralOverload" + Guid.NewGuid().ToString());
			if (microfeat != null)
			{
				bfq.c("Xpbl_SnakeOverloadHit");
			}
			else
			{
				bfq.c("NeuralOverloadHit");
			}
			bfq.a(bvl.c);
			qy.ad().Add(new a4s(bfq, null, new ar7(A_0), null));
			awq.a(qy, this.b.ao().a8(), A_0, true, true);
			if (!A_0.h.b.aa().Passive)
			{
				if (A_0.h.b.aa().c(d8o.e) || A_0.h.b.aa().d(CharacterImmunities.MindAffecting))
				{
					etm a_7 = new etm(new ap9(A_0.h.b.aa()), "невральной перегрузке");
					bey.a(a_7, this.a.b8(), A_0.h.b.aa(), A_0.h.b);
					a7v.a(a_7);
					bmj.a(A_0, new ba0());
				}
				else
				{
					cwt cwt = this.a(this.b.ao().aa(), A_0.h.b.aa());
					akg item2 = new akg(this.b.ao(), A_0.h.b, cwt, null, false);
					qy.ad().Add(item2);
					if (this.a.b8().Feats.c(typeof(aio)))
					{
						if (Enumerable.Any<csk>(cwt.f, new Func<csk, bool>(csw.a.a.a.a)) && A_0.h.b.aa().Feats.Contains<c3v>() && A_0.h.b.aa().Offense.aa().zo() > 0f)
						{
							int num = (int)((aio.b + (double)this.a.b8().GetSpecializationValue<dga>(true) * dga.a) * (double)A_0.h.b.aa().Offense.aa().zm());
							if (num > 0)
							{
								qy.ad().Add(new bea(new EntityAspectReference<amc, amc>(A_0.h.b), -num, true));
							}
						}
					}
					if (this.a.b8().Feats.c(typeof(cgu)))
					{
						cr cr = u6.a(A_0.h.b.aa(), 5);
						if (cr != null)
						{
							amd item3 = new amd(A_0.h.b, new els[]
							{
								cr
							});
							qy.ad().Add(item3);
						}
					}
					this.a(A_0, cwt);
				}
			}
			A_0.Zone.ActionManager.g9(qy, atp.a);
			dz6.a(qy);
		}

		// Token: 0x06007C9D RID: 31901 RVA: 0x00348978 File Offset: 0x00346B78
		private cwt a(efk A_0, efk A_1)
		{
			bas bas = A_0.Offense.ag()[PsiSchool.ThoughtControl];
			double num = dzs.a(A_1, this.a);
			double a_ = dzs.a(A_1);
			double a_2 = 1.0;
			if (A_1.StatusEffects.a(am0.a))
			{
				a_2 = 2.0;
			}
			cwt cwt = new cwt();
			cwt.l = true;
			cwt.p = true;
			cwt.i = new ap9(A_0);
			cwt.j = new ap9(A_1);
			cwt.b = true;
			cwt.e = (!A_1.ImmuneToCriticalHits && euf.a(euf.a(bas, A_1)));
			cwt.q = false;
			cwt.f.Add(csk.a(csk.a(csk.a(euf.a(dzs.a(this.a), (double)(1f + (cwt.e ? bas.g() : 0f))), 1.0 - num), a_), a_2));
			cwt.ad["PsionicSource"] = PsiSchool.ThoughtControl;
			cwt.ad["IsMindDisrupting"] = true;
			return cwt;
		}

		// Token: 0x06007C9E RID: 31902 RVA: 0x00348AC4 File Offset: 0x00346CC4
		private void a(c5x A_0, cwt A_1)
		{
			c37 microfeat = this.a.b8().GetMicrofeat<c37>();
			if (microfeat != null)
			{
				efk efk = A_0.h.b.aa();
				if (efk.Passive || (efk.b(d8o.e) | efk.d(CharacterImmunities.MindAffecting | CharacterImmunities.Fear)))
				{
					etm a_ = new etm(new ap9(A_0.h.b.aa()), "страху");
					bey.a(a_, this.a.b8(), A_0.h.b.aa(), A_0.h.b);
					a7v.a(a_);
					bmj.a(A_0, new ba0());
				}
				else if (euf.f(this.a.b8().Offense.ag()[PsiSchool.ThoughtControl].b(), efk))
				{
					c6f a_2 = new c6f(new ap9(A_0.h.b.aa()), new ap9(this.a.b8()), "страху");
					bey.a(a_2, this.a.b8(), A_0.h.b.aa(), A_0.h.b);
					a7v.a(a_2);
					bmj.a(A_0, new dym());
				}
				else
				{
					string a_3 = "FearStill";
					int maxValue = int.MaxValue;
					double a_4 = (double)dz6.b(700);
					bool a_5 = false;
					bool a_6 = true;
					Vector3? a_7 = new Vector3?(new Vector3(0f, 0f, A_0.Size.Z * 0.85f));
					float? a_8 = dz6.b();
					c5x c5x = boj.a(A_0, a_3, maxValue, a_4, a_5, a_6, a_7, null, null, a_8, false);
					if (c5x != null && c5x.o.b != null)
					{
						dtb dtb = new dtb();
						for (int i = 0; i < 7; i++)
						{
							if (i == 3)
							{
								List<auv> list = dtb.ad();
								string a_9 = "RedSmoke";
								int a_10 = 1;
								double maxValue2 = double.MaxValue;
								bool a_11 = false;
								bool a_12 = true;
								Vector3? a_13 = new Vector3?(new Vector3(0f, 0f, A_0.Size.Z * 0.85f));
								float? a_14 = new float?(0.1f);
								a_8 = dz6.b();
								list.Add(new a7j(A_0, a_9, a_10, maxValue2, a_11, a_12, a_13, a_14, null, a_8, false, null));
							}
							List<auv> list2 = dtb.ad();
							c66 c = new c66();
							c.b(true);
							c.a(null);
							list2.Add(new a4s(c, null, new ar7(c5x), null));
							dtb.ad().Add(new bm3(dz6.b(85)));
							List<auv> list3 = dtb.ad();
							c66 c2 = new c66();
							c2.b(true);
							c2.a(new Color?(Color.Red));
							list3.Add(new a4s(c2, null, new ar7(c5x), null));
							dtb.ad().Add(new bm3(dz6.b(15)));
						}
						A_0.Zone.ActionManager.g9(dtb, atp.a);
					}
					ef2 a_15 = new ef2(microfeat.b() * d0u.b, microfeat.a());
					efk.StatusEffects.a(a_15, false, false, false);
				}
			}
			cl9 microfeat2 = this.a.b8().GetMicrofeat<cl9>();
			if (microfeat2 != null)
			{
				efk efk2 = A_0.h.b.aa();
				if (efk2.Passive || efk2.b(d8o.e) || efk2.d(CharacterImmunities.MindAffecting))
				{
					etm a_16 = new etm(new ap9(A_0.h.b.aa()), "разъеданию кислотой мозга");
					bey.a(a_16, this.a.b8(), A_0.h.b.aa(), A_0.h.b);
					a7v.a(a_16);
					bmj.a(A_0, new ba0());
					return;
				}
				int num = Enumerable.Sum<csk>(A_1.f, new Func<csk, int>(csw.a.a.a.b));
				if (num > 0)
				{
					int a_17 = (int)Math.Max(1.0, (double)num * microfeat2.a() / (double)microfeat2.b());
					bni a_18 = new bni(microfeat2.b() * d0u.b, a_17);
					A_0.h.b.aa().StatusEffects.a(a_18, false, false, false);
				}
			}
		}

		// Token: 0x04003180 RID: 12672
		private eu7 a;

		// Token: 0x04003181 RID: 12673
		private EntityAspectReference<amc, amc> b;

		// Token: 0x04003182 RID: 12674
		private List<Guid> c = new List<Guid>();

		// Token: 0x02001628 RID: 5672
		[CompilerGenerated]
		[Serializable]
		private sealed class a
		{
			// Token: 0x06007CA1 RID: 31905 RVA: 0x00348F50 File Offset: 0x00347150
			internal bool a(csk A_0)
			{
				return A_0.Amount > 0;
			}

			// Token: 0x06007CA2 RID: 31906 RVA: 0x00348F5C File Offset: 0x0034715C
			internal int b(csk A_0)
			{
				return A_0.Amount;
			}

			// Token: 0x04003183 RID: 12675
			public static readonly csw.a.a a = new csw.a.a();

			// Token: 0x04003184 RID: 12676
			public static Func<csk, bool> b;

			// Token: 0x04003185 RID: 12677
			public static Func<csk, int> c;
		}
	}
}
