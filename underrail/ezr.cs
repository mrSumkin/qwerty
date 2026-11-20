using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.References;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001609 RID: 5641
[eiz("NDA")]
[Serializable]
public sealed class ezr : a6k, ISerializable
{
	// Token: 0x06007C19 RID: 31769 RVA: 0x00341874 File Offset: 0x0033FA74
	private ezr(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007C1A RID: 31770 RVA: 0x00341880 File Offset: 0x0033FA80
	public ezr()
	{
	}

	// Token: 0x06007C1B RID: 31771 RVA: 0x0034188C File Offset: 0x0033FA8C
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
				new ezr.a(base.vg().e(), base.vg().q().h.b).a(c5x);
				return dc4.c;
			}
			return dc4.e;
		}
		else
		{
			ak1 ak = base.vg().h() as ak1;
			if (ak != null && ak.Zone != null)
			{
				awb a_ = new awb(ak, new ezr.a(base.vg().e(), base.vg().q().h.b), null, (float)base.vg().e().g(), null, null, true);
				ak.Zone.ActionManager.g9(a_, atp.a);
				dz6.a(a_);
				foreach (bgo a_2 in base.vg().e().b8().StatusEffects.Get<bgo>())
				{
					base.vg().e().b8().StatusEffects.d(a_2);
				}
				return dc4.c;
			}
			return dc4.e;
		}
	}

	// Token: 0x0200160A RID: 5642
	[eiz("NDA_a")]
	[Serializable]
	private new class a : cci, ISerializable
	{
		// Token: 0x06007C1C RID: 31772 RVA: 0x00341A4C File Offset: 0x0033FC4C
		protected a(SerializationInfo A_0, StreamingContext A_1)
		{
			this.a = (eu7)A_0.GetValue("NDA_a:P", typeof(eu7));
			this.b = (EntityAspectReference<amc, amc>)A_0.GetValue("NDA_a:I", typeof(EntityAspectReference<amc, amc>));
			di7.ReadList<Guid>("NDA_a:AE", ref this.c, A_0);
			this.d = A_0.GetBoolean("NDA_a:S");
		}

		// Token: 0x06007C1D RID: 31773 RVA: 0x00341ACC File Offset: 0x0033FCCC
		public void GetObjectData(SerializationInfo info, StreamingContext ctx)
		{
			info.AddValue("NDA_a:P", this.a);
			info.AddValue("NDA_a:I", this.b);
			info.AddValue("NDA_a:S", this.d);
			di7.WriteList<Guid>("NDA_a:AE", this.c, info);
		}

		// Token: 0x06007C1E RID: 31774 RVA: 0x00341B20 File Offset: 0x0033FD20
		public a(eu7 A_0, amc A_1)
		{
			this.a = A_0;
			if (A_1 != null)
			{
				this.b = new EntityAspectReference<amc, amc>(A_1);
			}
		}

		// Token: 0x06007C1F RID: 31775 RVA: 0x00341B50 File Offset: 0x0033FD50
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

		// Token: 0x06007C20 RID: 31776 RVA: 0x00341C44 File Offset: 0x0033FE44
		public void a(c5x A_0)
		{
			if (this.a == null || this.a.b8() == null || this.a.p() == null || this.b == null || this.b.ao() == null || this.b.ao().a8() == null)
			{
				return;
			}
			qy qy = new qy();
			qy.b(false);
			qy.c(false);
			awq.a(qy, this.b.ao().a8(), A_0, true, true);
			if (!A_0.h.b.aa().Passive)
			{
				if (A_0.h.b.aa().c(d8o.e) || A_0.h.b.aa().d(CharacterImmunities.MindAffecting) || A_0.h.b.aa().Truesighted)
				{
					etm a_ = new etm(new ap9(A_0.h.b.aa()), "нейровизуальной помехе");
					bey.a(a_, this.a.b8(), A_0.h.b.aa(), A_0.h.b);
					a7v.a(a_);
					bmj.a(A_0, new ba0());
				}
				else
				{
					string a_2 = "NeurovisionDisruption";
					int a_3 = 1;
					double maxValue = double.MaxValue;
					bool a_4 = true;
					bool a_5 = true;
					Vector3? a_6 = new Vector3?(new Vector3(0f, 0f, A_0.Size.Z / 2f));
					float? a_7 = dz6.b();
					a7j item = new a7j(A_0, a_2, a_3, maxValue, a_4, a_5, a_6, null, null, a_7, false, null);
					qy.ad().Add(item);
					bfq bfq = new bfq();
					bfq.b("NeuralOverload" + Guid.NewGuid().ToString());
					bfq.c("NeurovisualDisruption");
					bfq.a(bvl.c);
					qy.ad().Add(new a4s(bfq, null, new ar7(A_0), null));
					if (this.a.b8().Feats.c(typeof(cgu)))
					{
						cr cr = u6.a(A_0.h.b.aa(), 10);
						if (cr != null)
						{
							amd item2 = new amd(A_0.h.b, new els[]
							{
								cr
							});
							qy.ad().Add(item2);
						}
					}
					if (euf.f(this.a.b8().Offense.ag()[PsiSchool.ThoughtControl].b(), A_0.h.b.aa()))
					{
						c6f a_8 = new c6f(new ap9(A_0.h.b.aa()), new ap9(this.a.b8()), "нейровизуальной помехе");
						bey.a(a_8, this.a.b8(), A_0.h.b.aa(), A_0.h.b);
						qy.ad().Add(new b8p(A_0, new dym()));
						qy.ad().Add(new anw(a_8));
					}
					else
					{
						int num = 1;
						if (A_0.h.b.aa().StatusEffects.a(am0.a))
						{
							num = 2;
						}
						e81 e = new e81(ati.e * d0u.b * num);
						qy.ad().Add(new amd(A_0.h.b, new els[]
						{
							e
						}));
						ak2 ak = new ak2(ati.f * d0u.b * num);
						qy.ad().Add(new amd(A_0.h.b, new els[]
						{
							ak
						}));
						if (!this.d)
						{
							this.d = true;
							qy.ad().Add(new e3(this.b.ao()));
						}
						qy.ad().Add(new bm3(100));
						be9 item3 = new be9(A_0.t.b);
						qy.ad().Add(item3);
					}
				}
			}
			qy.ad().Add(new duh(A_0.h.b, new string[]
			{
				am0.a
			}));
			A_0.Zone.ActionManager.g9(qy, atp.a);
			dz6.a(qy);
		}

		// Token: 0x0400314A RID: 12618
		private eu7 a;

		// Token: 0x0400314B RID: 12619
		private EntityAspectReference<amc, amc> b;

		// Token: 0x0400314C RID: 12620
		private List<Guid> c = new List<Guid>();

		// Token: 0x0400314D RID: 12621
		private bool d;
	}
}
