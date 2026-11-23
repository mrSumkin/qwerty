using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.References;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;

// Token: 0x020015D2 RID: 5586
[eiz("MCTA")]
[Serializable]
public sealed class e8d : a6k, ISerializable
{
	// Token: 0x06007B3D RID: 31549 RVA: 0x00336508 File Offset: 0x00334708
	private e8d(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007B3E RID: 31550 RVA: 0x00336514 File Offset: 0x00334714
	public e8d()
	{
	}

	// Token: 0x06007B3F RID: 31551 RVA: 0x00336520 File Offset: 0x00334720
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (base.vg().q() == null || base.vg().q().h.b == null)
		{
			return dc4.e;
		}
		base.vg().q().c().a("SkillSteal");
		c5x c5x = base.vg().h() as c5x;
		if (c5x != null)
		{
			if (c5x.h.b != null && !c5x.h.b.aa().Dead && c5x.Zone != null)
			{
				new e8d.a(base.vg().e(), base.vg().q().h.b).a(c5x);
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
				awb item = new awb(ak, new e8d.a(base.vg().e(), base.vg().q().h.b), null, (float)base.vg().e().g(), null, null, true);
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

	// Token: 0x020015D3 RID: 5587
	[eiz("MCTAa")]
	[Serializable]
	private new class a : cci, ISerializable
	{
		// Token: 0x06007B40 RID: 31552 RVA: 0x00336790 File Offset: 0x00334990
		protected a(SerializationInfo A_0, StreamingContext A_1)
		{
			this.a = (eu7)A_0.GetValue("MCTAa:P", typeof(eu7));
			this.b = (EntityAspectReference<amc, amc>)A_0.GetValue("MCTAa:I", typeof(EntityAspectReference<amc, amc>));
			di7.ReadList<Guid>("MCTAa:AE", ref this.c, A_0);
			this.d = A_0.GetBoolean("MCTAa:A");
		}

		// Token: 0x06007B41 RID: 31553 RVA: 0x00336810 File Offset: 0x00334A10
		public void GetObjectData(SerializationInfo info, StreamingContext ctx)
		{
			info.AddValue("MCTAa:P", this.a);
			info.AddValue("MCTAa:I", this.b);
			di7.WriteList<Guid>("MCTAa:AE", this.c, info);
			info.AddValue("MCTAa:A", this.d);
		}

		// Token: 0x06007B42 RID: 31554 RVA: 0x00336864 File Offset: 0x00334A64
		public a(eu7 A_0, amc A_1)
		{
			this.a = A_0;
			if (A_1 != null)
			{
				this.b = new EntityAspectReference<amc, amc>(A_1);
			}
		}

		// Token: 0x06007B43 RID: 31555 RVA: 0x00336894 File Offset: 0x00334A94
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

		// Token: 0x06007B44 RID: 31556 RVA: 0x00336988 File Offset: 0x00334B88
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
			if (efk.Passive || efk.b(d8o.e) || !efk.b(d8o.b | d8o.c) || efk.d(CharacterImmunities.MindAffecting | CharacterImmunities.MindControl))
			{
				etm a_ = new etm(new ap9(A_0.h.b.aa()), "motor-cognitive transference");
				bey.a(a_, this.a.b8(), A_0.h.b.aa(), A_0.h.b);
				a7v.a(a_);
				bmj.a(A_0, new ba0());
				return;
			}
			if (euf.f(this.a.b8().Offense.ag()[PsiSchool.ThoughtControl].b(), efk))
			{
				c6f a_2 = new c6f(new ap9(A_0.h.b.aa()), new ap9(this.a.b8()), "motor-cognitive transference");
				bey.a(a_2, this.a.b8(), A_0.h.b.aa(), A_0.h.b);
				a7v.a(a_2);
				bmj.a(A_0, new dym());
				return;
			}
			double num = euf.d(this.a.b8().Offense.ag()[PsiSchool.ThoughtControl].b(), efk);
			int num2 = (int)d05.b((double)bnw.c, Math.Ceiling((1.0 - num) * (double)bnw.d), (double)bnw.d);
			els els = Enumerable.FirstOrDefault<am0>(efk.StatusEffects.Get<am0>());
			double a_3 = 1.0;
			if (els != null)
			{
				num2 *= 2;
				efk.StatusEffects.d(els);
				a_3 = 2.0;
			}
			Dictionary<SkillEnum, bnw.a> dictionary = bnw.a(this.a, efk, num, a_3);
			a1u a1u = Enumerable.FirstOrDefault<a1u>(efk.StatusEffects.Get<a1u>());
			a1u a1u2;
			if (a1u != null)
			{
				a1u2 = new a1u(Math.Max(num2 * d0u.b, a1u.Duration), a1u.b);
			}
			else
			{
				a1u2 = new a1u(num2 * d0u.b, null);
			}
			bc7 bc = Enumerable.FirstOrDefault<bc7>(this.a.b8().StatusEffects.Get<bc7>());
			bc7 bc2 = new bc7(num2 * d0u.b);
			if (bc != null)
			{
				bc2.Duration = Math.Max(bc2.Duration, bc.Duration);
				bc2.a = new Dictionary<SkillEnum, bnw.a>(bc.a);
			}
			foreach (KeyValuePair<SkillEnum, bnw.a> keyValuePair in dictionary)
			{
				bnw.a value = bc2.a[keyValuePair.Key];
				value.c = Math.Max(bc2.a[keyValuePair.Key].c, keyValuePair.Value.c);
				value.b = Math.Max(bc2.a[keyValuePair.Key].b, keyValuePair.Value.b);
				bc2.a[keyValuePair.Key] = value;
				a1u2.a(keyValuePair.Key, keyValuePair.Value.b);
			}
			this.a.b8().StatusEffects.a(bc2, false, false, false);
			efk.StatusEffects.a(a1u2, false, false, false);
			string a_4 = "SkillStealOut";
			int a_5 = 1;
			double maxValue = double.MaxValue;
			bool a_6 = false;
			bool a_7 = true;
			Vector3? a_8 = new Vector3?(new Vector3(0f, 0f, A_0.Size.Z * 0.85f));
			float? a_9 = dz6.b();
			boj.a(A_0, a_4, a_5, maxValue, a_6, a_7, a_8, null, null, a_9, false);
			if (!this.d)
			{
				this.d = true;
				c5x a_10 = this.b.ao().a8();
				string a_11 = "SkillStealIn";
				int a_12 = 1;
				double maxValue2 = double.MaxValue;
				bool a_13 = false;
				bool a_14 = true;
				Vector3? a_15 = new Vector3?(new Vector3(0f, 0f, A_0.Size.Z * 0.85f));
				a_9 = dz6.b();
				boj.a(a_10, a_11, a_12, maxValue2, a_13, a_14, a_15, null, null, a_9, false);
			}
			if (this.a.b8().Feats.c(typeof(cgu)))
			{
				cr cr = u6.a(A_0.h.b.aa(), 20);
				if (cr != null)
				{
					efk.StatusEffects.a(cr, false, false, false);
				}
			}
		}

		// Token: 0x0400310C RID: 12556
		private eu7 a;

		// Token: 0x0400310D RID: 12557
		private EntityAspectReference<amc, amc> b;

		// Token: 0x0400310E RID: 12558
		private List<Guid> c = new List<Guid>();

		// Token: 0x0400310F RID: 12559
		private bool d;
	}
}
