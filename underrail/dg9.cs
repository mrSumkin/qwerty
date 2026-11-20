using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.References;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;

// Token: 0x0200160C RID: 5644
[eiz("DPCIA")]
[Serializable]
public sealed class dg9 : a6k, ISerializable
{
	// Token: 0x06007C24 RID: 31780 RVA: 0x00342198 File Offset: 0x00340398
	private dg9(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007C25 RID: 31781 RVA: 0x003421A4 File Offset: 0x003403A4
	public dg9()
	{
	}

	// Token: 0x06007C26 RID: 31782 RVA: 0x003421B0 File Offset: 0x003403B0
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
				new dg9.a(base.vg().e(), base.vg().q().h.b).a(c5x);
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
				awb item = new awb(ak, new dg9.a(base.vg().e(), base.vg().q().h.b), null, (float)base.vg().e().g(), null, null, true);
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

	// Token: 0x0200160D RID: 5645
	[eiz("DPCIA_a")]
	[Serializable]
	private new class a : cci, ISerializable
	{
		// Token: 0x06007C27 RID: 31783 RVA: 0x00342404 File Offset: 0x00340604
		protected a(SerializationInfo A_0, StreamingContext A_1)
		{
			this.a = (eu7)A_0.GetValue("DPCIA_a:P", typeof(eu7));
			this.b = (EntityAspectReference<amc, amc>)A_0.GetValue("DPCIA_a:I", typeof(EntityAspectReference<amc, amc>));
			di7.ReadList<Guid>("DPCIA_a:AE", ref this.c, A_0);
		}

		// Token: 0x06007C28 RID: 31784 RVA: 0x00342474 File Offset: 0x00340674
		public void GetObjectData(SerializationInfo info, StreamingContext ctx)
		{
			info.AddValue("DPCIA_a:P", this.a);
			info.AddValue("DPCIA_a:I", this.b);
			di7.WriteList<Guid>("DPCIA_a:AE", this.c, info);
		}

		// Token: 0x06007C29 RID: 31785 RVA: 0x003424AC File Offset: 0x003406AC
		public a(eu7 A_0, amc A_1)
		{
			this.a = A_0;
			if (A_1 != null)
			{
				this.b = new EntityAspectReference<amc, amc>(A_1);
			}
		}

		// Token: 0x06007C2A RID: 31786 RVA: 0x003424D8 File Offset: 0x003406D8
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

		// Token: 0x06007C2B RID: 31787 RVA: 0x003425CC File Offset: 0x003407CC
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
				if (A_0.h.b.aa().c(d8o.e) || A_0.h.b.aa().d(CharacterImmunities.MindAffecting) || !A_0.h.b.aa().Feats.Contains<c3v>())
				{
					etm a_ = new etm(new ap9(A_0.h.b.aa()), "пси-когнитивному прерыванию");
					bey.a(a_, this.a.b8(), A_0.h.b.aa(), A_0.h.b);
					a7v.a(a_);
					bmj.a(A_0, new ba0());
				}
				else
				{
					string a_2 = "MindBurn";
					int a_3 = 1;
					double maxValue = double.MaxValue;
					bool a_4 = true;
					bool a_5 = true;
					Vector3? a_6 = new Vector3?(new Vector3(0f, 0f, A_0.Size.Z * 0.3f));
					float? a_7 = dz6.b();
					a7j item = new a7j(A_0, a_2, a_3, maxValue, a_4, a_5, a_6, null, null, a_7, false, null);
					qy.ad().Add(item);
					bfq bfq = new bfq();
					bfq.b("MindBurn" + Guid.NewGuid().ToString());
					bfq.c("MindBurn");
					bfq.a(bvl.c);
					qy.ad().Add(new a4s(bfq, null, new ar7(A_0), null));
					b1j b1j = px.c(this.a);
					bool flag = !A_0.h.b.aa().ImmuneToCriticalHits && euf.a(euf.a(this.b.ao().aa().Offense.ag()[PsiSchool.ThoughtControl], A_0.h.b.aa()));
					int num = (int)b1j.a();
					if (flag)
					{
						num *= 2;
					}
					if (A_0.h.b.aa().StatusEffects.a(am0.a))
					{
						num *= 2;
					}
					num = Math.Min((int)A_0.h.b.aa().Offense.aa().zo(), num);
					if (num > 0)
					{
						cwt a_8 = this.a(this.b.ao().aa(), A_0.h.b.aa(), num, flag);
						qy.ad().Add(new bea(new EntityAspectReference<amc, amc>(A_0.h.b), -num, true));
						akg item2 = new akg(this.b.ao(), A_0.h.b, a_8, null, false);
						qy.ad().Add(item2);
					}
					if (this.a.b8().Feats.c(typeof(cgu)))
					{
						cr cr = u6.a(A_0.h.b.aa(), 10);
						if (cr != null)
						{
							amd item3 = new amd(A_0.h.b, new els[]
							{
								cr
							});
							qy.ad().Add(item3);
						}
					}
					if (euf.f(px.a(this.a), A_0.h.b.aa()))
					{
						c6f a_9 = new c6f(new ap9(A_0.h.b.aa()), new ap9(this.a.b8()), "псионическому угнетению");
						bey.a(a_9, this.a.b8(), A_0.h.b.aa(), A_0.h.b);
						qy.ad().Add(new b8p(A_0, new dym()));
						qy.ad().Add(new anw(a_9));
					}
					else
					{
						double num2 = euf.d(px.a(this.a), A_0.h.b.aa());
						int num3 = (int)Math.Max(1.0, Math.Ceiling((1.0 - num2) * (double)px.i));
						if (A_0.h.b.aa().StatusEffects.a(am0.a))
						{
							num3 *= 2;
						}
						adg adg = new adg(num3 * d0u.b);
						qy.ad().Add(new bm3(dz6.b(300)));
						qy.ad().Add(new amd(A_0.h.b, new els[]
						{
							adg
						}));
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

		// Token: 0x06007C2C RID: 31788 RVA: 0x00342B78 File Offset: 0x00340D78
		private cwt a(efk A_0, efk A_1, int A_2, bool A_3)
		{
			int num = (int)Math.Max(1.0, (double)A_2 * px.b(this.a));
			double num2 = dzs.a(A_1, this.a);
			cwt cwt = new cwt();
			cwt.l = true;
			cwt.p = true;
			cwt.i = new ap9(A_0);
			cwt.j = new ap9(A_1);
			cwt.b = true;
			cwt.e = A_3;
			cwt.q = false;
			cwt.f.Add(new csk(DamageType.Electricity, (int)((double)num * (1.0 - num2))));
			cwt.ad["PsionicSource"] = PsiSchool.ThoughtControl;
			cwt.ad["IsMindDisrupting"] = true;
			return cwt;
		}

		// Token: 0x0400314E RID: 12622
		private eu7 a;

		// Token: 0x0400314F RID: 12623
		private EntityAspectReference<amc, amc> b;

		// Token: 0x04003150 RID: 12624
		private List<Guid> c = new List<Guid>();
	}
}
