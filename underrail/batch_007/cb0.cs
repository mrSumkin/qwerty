using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.References;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;

// Token: 0x0200160E RID: 5646
[eiz("E14")]
[Serializable]
public sealed class cb0 : a6k, ISerializable
{
	// Token: 0x06007C2D RID: 31789 RVA: 0x00342C40 File Offset: 0x00340E40
	private cb0(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007C2E RID: 31790 RVA: 0x00342C4C File Offset: 0x00340E4C
	public cb0()
	{
	}

	// Token: 0x06007C2F RID: 31791 RVA: 0x00342C58 File Offset: 0x00340E58
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
				new cb0.a(base.vg().e(), base.vg().q().h.b).a(c5x);
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
				awb item = new awb(ak, new cb0.a(base.vg().e(), base.vg().q().h.b), null, (float)base.vg().e().g(), null, null, true);
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

	// Token: 0x0200160F RID: 5647
	[eiz("E14a")]
	[Serializable]
	private new class a : cci, ISerializable
	{
		// Token: 0x06007C30 RID: 31792 RVA: 0x00342ED4 File Offset: 0x003410D4
		protected a(SerializationInfo A_0, StreamingContext A_1)
		{
			this.a = (eu7)A_0.GetValue("E14a:P", typeof(eu7));
			this.b = (EntityAspectReference<amc, amc>)A_0.GetValue("E14a:I", typeof(EntityAspectReference<amc, amc>));
			di7.ReadList<Guid>("E14a:AE", ref this.c, A_0);
		}

		// Token: 0x06007C31 RID: 31793 RVA: 0x00342F44 File Offset: 0x00341144
		public void GetObjectData(SerializationInfo info, StreamingContext ctx)
		{
			info.AddValue("E14a:P", this.a);
			info.AddValue("E14a:I", this.b);
			di7.WriteList<Guid>("E14a:AE", this.c, info);
		}

		// Token: 0x06007C32 RID: 31794 RVA: 0x00342F7C File Offset: 0x0034117C
		public a(eu7 A_0, amc A_1)
		{
			this.a = A_0;
			if (A_1 != null)
			{
				this.b = new EntityAspectReference<amc, amc>(A_1);
			}
		}

		// Token: 0x06007C33 RID: 31795 RVA: 0x00342FA8 File Offset: 0x003411A8
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

		// Token: 0x06007C34 RID: 31796 RVA: 0x0034309C File Offset: 0x0034129C
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
			if (efk.Passive || (efk.b(d8o.e) | efk.d(CharacterImmunities.MindAffecting | CharacterImmunities.MindControl)))
			{
				etm a_ = new etm(new ap9(A_0.h.b.aa()), "взбешению");
				bey.a(a_, this.a.b8(), A_0.h.b.aa(), A_0.h.b);
				a7v.a(a_);
				bmj.a(A_0, new ba0());
				return;
			}
			if (euf.f(this.a.b8().Offense.ag()[PsiSchool.ThoughtControl].b(), efk))
			{
				c6f a_2 = new c6f(new ap9(A_0.h.b.aa()), new ap9(this.a.b8()), "взбешению");
				bey.a(a_2, this.a.b8(), A_0.h.b.aa(), A_0.h.b);
				a7v.a(a_2);
				bmj.a(A_0, new dym());
				return;
			}
			double num = euf.d(this.a.b8().Offense.ag()[PsiSchool.ThoughtControl].b(), efk);
			int num2 = (int)d05.b((double)g7.d, Math.Ceiling((1.0 - num) * (double)g7.c), (double)g7.c);
			els els = Enumerable.FirstOrDefault<am0>(efk.StatusEffects.Get<am0>());
			if (els != null)
			{
				num2 *= 2;
				efk.StatusEffects.d(els);
			}
			bv0 a_3 = new bv0(num2 * d0u.b);
			efk.StatusEffects.a(a_3, false, false, false);
			if (this.a.b8().Feats.c(typeof(cgu)))
			{
				cr cr = u6.a(A_0.h.b.aa(), 15);
				if (cr != null)
				{
					efk.StatusEffects.a(cr, false, false, false);
				}
			}
			awq.a(A_0.h.b, 1);
		}

		// Token: 0x04003151 RID: 12625
		private eu7 a;

		// Token: 0x04003152 RID: 12626
		private EntityAspectReference<amc, amc> b;

		// Token: 0x04003153 RID: 12627
		private List<Guid> c = new List<Guid>();
	}
}
