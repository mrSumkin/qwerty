using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.References;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;

// Token: 0x0200161F RID: 5663
[eiz("F14")]
[Serializable]
public sealed class dy2 : a6k, ISerializable
{
	// Token: 0x06007C7D RID: 31869 RVA: 0x003471C4 File Offset: 0x003453C4
	private dy2(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007C7E RID: 31870 RVA: 0x003471D0 File Offset: 0x003453D0
	public dy2()
	{
	}

	// Token: 0x06007C7F RID: 31871 RVA: 0x003471DC File Offset: 0x003453DC
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (base.vg().q() == null || base.vg().q().h.b == null)
		{
			return dc4.e;
		}
		base.vg().q().c().a("frighten", "Frighten", 1f, c9z.a, false, false);
		c5x c5x = base.vg().h() as c5x;
		if (c5x != null)
		{
			if (c5x.h.b != null && !c5x.h.b.aa().Dead && c5x.Zone != null)
			{
				new dy2.a(base.vg().e(), base.vg().q().h.b).a(c5x);
				return dc4.c;
			}
			return dc4.e;
		}
		else
		{
			ak1 ak = base.vg().h() as ak1;
			if (ak != null && ak.Zone != null)
			{
				awb a_ = new awb(ak, new dy2.a(base.vg().e(), base.vg().q().h.b), null, (float)base.vg().e().g(), null, null, true);
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

	// Token: 0x02001620 RID: 5664
	[eiz("F14a")]
	[Serializable]
	private new class a : cci, ISerializable
	{
		// Token: 0x06007C80 RID: 31872 RVA: 0x003473C4 File Offset: 0x003455C4
		protected a(SerializationInfo A_0, StreamingContext A_1)
		{
			this.a = (eu7)A_0.GetValue("F14a:P", typeof(eu7));
			this.b = (EntityAspectReference<amc, amc>)A_0.GetValue("F14a:I", typeof(EntityAspectReference<amc, amc>));
			di7.ReadList<Guid>("F14a:AE", ref this.c, A_0);
		}

		// Token: 0x06007C81 RID: 31873 RVA: 0x00347434 File Offset: 0x00345634
		public void GetObjectData(SerializationInfo info, StreamingContext ctx)
		{
			info.AddValue("F14a:P", this.a);
			info.AddValue("F14a:I", this.b);
			di7.WriteList<Guid>("F14a:AE", this.c, info);
		}

		// Token: 0x06007C82 RID: 31874 RVA: 0x0034746C File Offset: 0x0034566C
		public a(eu7 A_0, amc A_1)
		{
			this.a = A_0;
			if (A_1 != null)
			{
				this.b = new EntityAspectReference<amc, amc>(A_1);
			}
		}

		// Token: 0x06007C83 RID: 31875 RVA: 0x00347498 File Offset: 0x00345698
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

		// Token: 0x06007C84 RID: 31876 RVA: 0x0034758C File Offset: 0x0034578C
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
			if (efk.Passive || efk.b(d8o.e) || efk.d(CharacterImmunities.MindAffecting | CharacterImmunities.Fear))
			{
				etm a_ = new etm(new ap9(A_0.h.b.aa()), "страху");
				bey.a(a_, this.a.b8(), A_0.h.b.aa(), A_0.h.b);
				a7v.a(a_);
				bmj.a(A_0, new ba0());
				return;
			}
			if (euf.f(this.a.b8().Offense.ag()[PsiSchool.ThoughtControl].b(), efk))
			{
				c6f a_2 = new c6f(new ap9(A_0.h.b.aa()), new ap9(this.a.b8()), "страху");
				bey.a(a_2, this.a.b8(), A_0.h.b.aa(), A_0.h.b);
				a7v.a(a_2);
				bmj.a(A_0, new dym());
				return;
			}
			double num = euf.d(this.a.b8().Offense.ag()[PsiSchool.ThoughtControl].b(), efk);
			int num2 = (int)d05.b((double)dx2.d, Math.Ceiling((1.0 - num) * (double)dx2.c / (double)d0u.b) * (double)d0u.b, (double)dx2.c);
			els els = Enumerable.FirstOrDefault<am0>(efk.StatusEffects.Get<am0>());
			if (els != null)
			{
				num2 *= 2;
				efk.StatusEffects.d(els);
			}
			axo a_3 = new axo(num2, new ar7(this.b.ao().a8()));
			efk.StatusEffects.a(a_3, false, false, false);
			if (this.a.b8().Feats.c(typeof(cgu)))
			{
				cr cr = u6.a(A_0.h.b.aa(), 8);
				if (cr != null)
				{
					efk.StatusEffects.a(cr, false, false, false);
				}
			}
			awq.a(A_0.h.b, 1);
		}

		// Token: 0x04003176 RID: 12662
		private eu7 a;

		// Token: 0x04003177 RID: 12663
		private EntityAspectReference<amc, amc> b;

		// Token: 0x04003178 RID: 12664
		private List<Guid> c = new List<Guid>();
	}
}
