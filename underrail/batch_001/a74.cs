using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.References;
using TimelapseVertigo.Rules.Characters;

// Token: 0x020015FD RID: 5629
[eiz("B51")]
[Serializable]
public sealed class a74 : a6k, ISerializable
{
	// Token: 0x06007BDD RID: 31709 RVA: 0x0033EEC0 File Offset: 0x0033D0C0
	private a74(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007BDE RID: 31710 RVA: 0x0033EECC File Offset: 0x0033D0CC
	public a74()
	{
	}

	// Token: 0x06007BDF RID: 31711 RVA: 0x0033EED4 File Offset: 0x0033D0D4
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (base.vg().q() == null || base.vg().q().h.b == null)
		{
			return dc4.e;
		}
		base.vg().q().c().a("darkSecretReveal", "DarkSecretReveal", 1f, c9z.a, false, false);
		c5x c5x = base.vg().h() as c5x;
		if (c5x != null)
		{
			if (c5x.h.b != null && !c5x.h.b.aa().Dead && c5x.Zone != null)
			{
				new a74.a(base.vg().e(), base.vg().q().h.b).a(c5x);
				return dc4.c;
			}
			return dc4.e;
		}
		else
		{
			ak1 ak = base.vg().h() as ak1;
			if (ak != null && ak.Zone != null)
			{
				awb a_ = new awb(ak, new a74.a(base.vg().e(), base.vg().q().h.b), null, (float)base.vg().e().g(), null, null, true);
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

	// Token: 0x020015FE RID: 5630
	[eiz("B51a")]
	[Serializable]
	private new class a : cci, ISerializable
	{
		// Token: 0x06007BE0 RID: 31712 RVA: 0x0033F0BC File Offset: 0x0033D2BC
		protected a(SerializationInfo A_0, StreamingContext A_1)
		{
			this.a = (eu7)A_0.GetValue("B51a:P", typeof(eu7));
			this.b = (EntityAspectReference<amc, amc>)A_0.GetValue("B51a:I", typeof(EntityAspectReference<amc, amc>));
			di7.ReadList<Guid>("B51a:AE", ref this.c, A_0);
		}

		// Token: 0x06007BE1 RID: 31713 RVA: 0x0033F12C File Offset: 0x0033D32C
		public void GetObjectData(SerializationInfo info, StreamingContext ctx)
		{
			info.AddValue("B51a:P", this.a);
			info.AddValue("B51a:I", this.b);
			di7.WriteList<Guid>("B51a:AE", this.c, info);
		}

		// Token: 0x06007BE2 RID: 31714 RVA: 0x0033F164 File Offset: 0x0033D364
		public a(eu7 A_0, amc A_1)
		{
			this.a = A_0;
			if (A_1 != null)
			{
				this.b = new EntityAspectReference<amc, amc>(A_1);
			}
		}

		// Token: 0x06007BE3 RID: 31715 RVA: 0x0033F190 File Offset: 0x0033D390
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
						if (c5x != null && c5x.h.b != null && !this.c.Contains(b0b.qe()) && c5x.h.b.aa().FactionId != asp.d && c5x.h.b != this.b.ao())
						{
							this.a(c5x);
							this.c.Add(c5x.qe());
						}
					}
				}
			}
		}

		// Token: 0x06007BE4 RID: 31716 RVA: 0x0033F2A8 File Offset: 0x0033D4A8
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
			if (efk.Passive || !efk.b(d8o.b | d8o.c) || efk.d(CharacterImmunities.MindAffecting | CharacterImmunities.Bilocation) || efk.Vehicle != null)
			{
				etm a_ = new etm(new ap9(A_0.h.b.aa()), "билокации");
				bey.a(a_, this.a.b8(), A_0.h.b.aa(), A_0.h.b);
				a7v.a(a_);
				bmj.a(A_0, new ba0());
				return;
			}
			int num = 1;
			els els = Enumerable.FirstOrDefault<am0>(efk.StatusEffects.Get<am0>());
			if (els != null)
			{
				num = 2;
				efk.StatusEffects.d(els);
			}
			for (int i = 0; i < num; i++)
			{
				List<ak1> list = aw1.a(A_0, null);
				if (list.Count > 0)
				{
					ak1 ak = list[cuo.a.Next(list.Count)];
					a1q value = eq6.a(this.a);
					new d8g(this.b.ao().a8(), A_0, new bt4(A_0.Area.y8(), ak.Location.a()), new a1q?(value), false, null, null, null, null).ym(null, null, null);
				}
			}
			if (this.a.b8().Feats.c(typeof(cgu)))
			{
				cr cr = u6.a(A_0.h.b.aa(), 10);
				if (cr != null)
				{
					efk.StatusEffects.a(cr, false, false, false);
				}
			}
			awq.a(A_0.h.b, 1);
		}

		// Token: 0x0400313B RID: 12603
		private eu7 a;

		// Token: 0x0400313C RID: 12604
		private EntityAspectReference<amc, amc> b;

		// Token: 0x0400313D RID: 12605
		private List<Guid> c = new List<Guid>();
	}
}
