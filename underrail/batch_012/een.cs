using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.References;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02001615 RID: 5653
[eiz("M77")]
[Serializable]
public sealed class een : a6k, ISerializable
{
	// Token: 0x06007C4D RID: 31821 RVA: 0x00344540 File Offset: 0x00342740
	private een(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007C4E RID: 31822 RVA: 0x0034454C File Offset: 0x0034274C
	public een()
	{
	}

	// Token: 0x06007C4F RID: 31823 RVA: 0x00344554 File Offset: 0x00342754
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
				new een.a(base.vg().e(), base.vg().q().h.b).a(c5x);
				return dc4.c;
			}
			return dc4.e;
		}
		else
		{
			ak1 ak = base.vg().h() as ak1;
			if (ak != null && ak.Zone != null)
			{
				awb a_ = new awb(ak, new een.a(base.vg().e(), base.vg().q().h.b), null, (float)base.vg().e().g(), null, null, true);
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

	// Token: 0x02001616 RID: 5654
	[eiz("M77a")]
	[Serializable]
	private new class a : cci, ISerializable
	{
		// Token: 0x06007C50 RID: 31824 RVA: 0x0034473C File Offset: 0x0034293C
		protected a(SerializationInfo A_0, StreamingContext A_1)
		{
			this.a = (eu7)A_0.GetValue("M77a:P", typeof(eu7));
			this.b = (EntityAspectReference<amc, amc>)A_0.GetValue("M77a:I", typeof(EntityAspectReference<amc, amc>));
			di7.ReadList<Guid>("M77a:AE", ref this.c, A_0);
		}

		// Token: 0x06007C51 RID: 31825 RVA: 0x003447AC File Offset: 0x003429AC
		public void GetObjectData(SerializationInfo info, StreamingContext ctx)
		{
			info.AddValue("M77a:P", this.a);
			info.AddValue("M77a:I", this.b);
			di7.WriteList<Guid>("M77a:AE", this.c, info);
		}

		// Token: 0x06007C52 RID: 31826 RVA: 0x003447E4 File Offset: 0x003429E4
		public a(eu7 A_0, amc A_1)
		{
			this.a = A_0;
			if (A_1 != null)
			{
				this.b = new EntityAspectReference<amc, amc>(A_1);
			}
		}

		// Token: 0x06007C53 RID: 31827 RVA: 0x00344810 File Offset: 0x00342A10
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

		// Token: 0x06007C54 RID: 31828 RVA: 0x00344904 File Offset: 0x00342B04
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
			if (efk.Passive || (efk.b(d8o.e) | efk.d(CharacterImmunities.MindAffecting)))
			{
				etm a_ = new etm(new ap9(A_0.h.b.aa()), "ментальному разложению");
				bey.a(a_, this.a.b8(), A_0.h.b.aa(), A_0.h.b);
				a7v.a(a_);
				bmj.a(A_0, new ba0());
				return;
			}
			if (euf.f(be7.a(this.a), efk))
			{
				c6f a_2 = new c6f(new ap9(A_0.h.b.aa()), new ap9(this.a.b8()), "ментальному разложению");
				bey.a(a_2, this.a.b8(), A_0.h.b.aa(), A_0.h.b);
				a7v.a(a_2);
				bmj.a(A_0, new dym());
				return;
			}
			string a_3 = "SonicBlast";
			int a_4 = 2;
			double maxValue = double.MaxValue;
			bool a_5 = true;
			bool a_6 = true;
			Vector3? a_7 = new Vector3?(new Vector3(0f, 0f, A_0.Size.Z / 2f));
			float? a_8 = dz6.b();
			boj.a(A_0, a_3, a_4, maxValue, a_5, a_6, a_7, null, null, a_8, false);
			if (this.a.b8().Feats.c(typeof(cgu)))
			{
				cr cr = u6.a(A_0.h.b.aa(), 10);
				if (cr != null)
				{
					efk.StatusEffects.a(cr, false, false, false);
				}
			}
			double num = euf.d(be7.a(this.a), efk);
			am0 a_9 = new am0((int)d05.b(1.0, Math.Ceiling((1.0 - num) * (double)be7.c), (double)be7.c) * d0u.b);
			efk.StatusEffects.a(a_9, false, false, false);
			if (A_0.t.b != null)
			{
				A_0.t.b.ah();
			}
			awq.a(A_0.h.b, 1);
		}

		// Token: 0x0400315F RID: 12639
		private eu7 a;

		// Token: 0x04003160 RID: 12640
		private EntityAspectReference<amc, amc> b;

		// Token: 0x04003161 RID: 12641
		private List<Guid> c = new List<Guid>();
	}
}
