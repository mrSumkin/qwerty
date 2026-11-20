using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.References;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;

// Token: 0x020015D8 RID: 5592
[eiz("PPA")]
[Serializable]
public sealed class cu1 : a6k, ISerializable
{
	// Token: 0x06007B55 RID: 31573 RVA: 0x00337EB4 File Offset: 0x003360B4
	private cu1(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007B56 RID: 31574 RVA: 0x00337EC0 File Offset: 0x003360C0
	public cu1()
	{
	}

	// Token: 0x06007B57 RID: 31575 RVA: 0x00337ECC File Offset: 0x003360CC
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
				base.vg().q().c().a("Frighten");
				new cu1.a(base.vg().e(), base.vg().q().h.b).a(c5x);
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
				awb item = new awb(ak, new cu1.a(base.vg().e(), base.vg().q().h.b), null, (float)base.vg().e().g(), null, null, true);
				dtb.ad().Add(new a4s(new bfq("Frighten"), null, new ar7(base.vg().q()), null));
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

	// Token: 0x020015D9 RID: 5593
	[eiz("PPAa")]
	[Serializable]
	private new class a : cci, ISerializable
	{
		// Token: 0x06007B58 RID: 31576 RVA: 0x00338168 File Offset: 0x00336368
		protected a(SerializationInfo A_0, StreamingContext A_1)
		{
			this.a = (eu7)A_0.GetValue("PPAa:P", typeof(eu7));
			this.b = (EntityAspectReference<amc, amc>)A_0.GetValue("PPAa:I", typeof(EntityAspectReference<amc, amc>));
			di7.ReadList<Guid>("PPAa:AE", ref this.c, A_0);
			this.d = A_0.GetBoolean("PPAa:A");
		}

		// Token: 0x06007B59 RID: 31577 RVA: 0x003381E8 File Offset: 0x003363E8
		public void GetObjectData(SerializationInfo info, StreamingContext ctx)
		{
			info.AddValue("PPAa:P", this.a);
			info.AddValue("PPAa:I", this.b);
			di7.WriteList<Guid>("PPAa:AE", this.c, info);
			info.AddValue("PPAa:A", this.d);
		}

		// Token: 0x06007B5A RID: 31578 RVA: 0x0033823C File Offset: 0x0033643C
		public a(eu7 A_0, amc A_1)
		{
			this.a = A_0;
			if (A_1 != null)
			{
				this.b = new EntityAspectReference<amc, amc>(A_1);
			}
		}

		// Token: 0x06007B5B RID: 31579 RVA: 0x0033826C File Offset: 0x0033646C
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

		// Token: 0x06007B5C RID: 31580 RVA: 0x00338360 File Offset: 0x00336560
		public void a(c5x A_0)
		{
			if (this.a == null || this.a.b8() == null || this.a.p() == null || this.b == null || this.b.ao() == null || this.b.ao().a8() == null)
			{
				return;
			}
			efk efk = A_0.h.b.aa();
			if (!efk.Passive && !efk.b(d8o.e))
			{
				awq.a(this.b.ao(), A_0.h.b, true, true, null, true, true, false, false);
			}
			if (efk.Passive || efk.b(d8o.e) || efk.d(CharacterImmunities.MindAffecting | CharacterImmunities.MindControl))
			{
				etm a_ = new etm(new ap9(A_0.h.b.aa()), "психосоматическому хищнику");
				bey.a(a_, this.a.b8(), A_0.h.b.aa(), A_0.h.b);
				a7v.a(a_);
				bmj.a(A_0, new ba0());
				return;
			}
			if (euf.f(this.a.b8().Offense.ag()[PsiSchool.ThoughtControl].b(), efk))
			{
				c6f a_2 = new c6f(new ap9(A_0.h.b.aa()), new ap9(this.a.b8()), "психосоматическому хищнику");
				bey.a(a_2, this.a.b8(), A_0.h.b.aa(), A_0.h.b);
				a7v.a(a_2);
				bmj.a(A_0, new dym());
				return;
			}
			double num = euf.d(this.a.b8().Offense.ag()[PsiSchool.ThoughtControl].b(), efk);
			int num2 = (int)d05.b((double)dfd.c, Math.Ceiling((1.0 - num) * (double)dfd.d), (double)dfd.d);
			els els = Enumerable.FirstOrDefault<am0>(efk.StatusEffects.Get<am0>());
			if (els != null)
			{
				num2 *= 2;
				efk.StatusEffects.d(els);
			}
			d1 d = new d1(num2 * d0u.b, new ar7(this.b.ao().a8()), dfd.a(this.a), this.e);
			efk.StatusEffects.a(d, false, false, false);
			if (!this.d)
			{
				brr a_3 = new brr(d.Duration, this.e);
				this.a.b8().StatusEffects.a(a_3, false, false, false);
				this.d = true;
			}
			if (this.a.b8().Feats.c(typeof(cgu)))
			{
				cr cr = u6.a(A_0.h.b.aa(), 15);
				if (cr != null)
				{
					efk.StatusEffects.a(cr, false, false, false);
				}
			}
		}

		// Token: 0x04003117 RID: 12567
		private eu7 a;

		// Token: 0x04003118 RID: 12568
		private EntityAspectReference<amc, amc> b;

		// Token: 0x04003119 RID: 12569
		private List<Guid> c = new List<Guid>();

		// Token: 0x0400311A RID: 12570
		private bool d;

		// Token: 0x0400311B RID: 12571
		private Guid e;
	}

	// Token: 0x020015DA RID: 5594
	[euj]
	private sealed class b
	{
		// Token: 0x06007B5D RID: 31581 RVA: 0x00338680 File Offset: 0x00336880
		[ayh("PsychosomaticPredation_PreyDied")]
		public void b(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
		{
			d1 d;
			cwt cwt;
			if (A_1 != null && A_1.h != null && A_1.h.b != null && A_1.h.b.aa() != null && A_2 != null && A_2.QuickGet("StatusEffect", out d) && A_2.QuickGet("attackResult", out cwt) && !cwt.w && cwt.i != null && cwt.i.d != Guid.Empty)
			{
				ar7 ar = d.b as ar7;
				if (ar != null)
				{
					c5x c5x = ar.ao() as c5x;
					if (c5x != null && c5x.j == cgy.b && c5x.h.b != null && !c5x.h.b.aa().Dead && c5x.h.b.aa().Uid == cwt.i.d)
					{
						c5x.h.b.aa().Offense.d(dfd.i, true);
						c5x.h.b.aa().Cooldowns.a(dfd.a);
						return;
					}
				}
			}
		}

		// Token: 0x06007B5E RID: 31582 RVA: 0x003387E4 File Offset: 0x003369E4
		[ayh("PsychosomaticPredation_PredatorTick")]
		public void a(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
		{
			brr a_;
			if (A_1 != null && A_1.h != null && A_1.h.b != null && A_1.h.b.aa() != null && A_2 != null && A_2.QuickGet("StatusEffect", out a_))
			{
				foreach (d4n d4n in bpo.GetServiceOrThrow<d02>().ahl())
				{
					if (d4n.b != null && d4n.b.a8() != null && d4n.b.a8() != A_1)
					{
						foreach (d1 d in d4n.b.aa().StatusEffects.Get<d1>())
						{
							ar7 ar = d.b as ar7;
							if (ar != null)
							{
								c5x c5x = ar.ao() as c5x;
								if (c5x != null && c5x == A_1 && aw1.b(d4n.b.a8(), c5x) <= 15.0)
								{
									return;
								}
							}
						}
					}
				}
				A_1.h.b.aa().StatusEffects.d(a_);
			}
		}

		// Token: 0x06007B5F RID: 31583 RVA: 0x00338978 File Offset: 0x00336B78
		[ayh("PsychosomaticPredation_PreyTick")]
		public void c(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
		{
			d1 d;
			if (A_1 != null && A_1.h != null && A_1.h.b != null && A_1.h.b.aa() != null && A_2 != null && A_2.QuickGet("StatusEffect", out d))
			{
				ar7 ar = d.b as ar7;
				if (ar != null)
				{
					c5x c5x = ar.ao() as c5x;
					if (c5x != null && c5x.j == cgy.b && c5x.h.b != null && !c5x.h.b.aa().Dead && aw1.b(A_1, c5x) <= 15.0)
					{
						using (List<brr>.Enumerator enumerator = c5x.h.b.aa().StatusEffects.Get<brr>().GetEnumerator())
						{
							while (enumerator.MoveNext())
							{
								if (enumerator.Current.a == d.d)
								{
									return;
								}
							}
						}
					}
				}
				A_1.h.b.aa().StatusEffects.d(d);
			}
		}
	}
}
