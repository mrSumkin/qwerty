using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.References;
using TimelapseVertigo.Rules.Characters;

// Token: 0x020016DC RID: 5852
[eiz("Y0")]
[Serializable]
public sealed class a01 : a6k, ISerializable
{
	// Token: 0x06007F52 RID: 32594 RVA: 0x0035E660 File Offset: 0x0035C860
	private a01(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007F53 RID: 32595 RVA: 0x0035E66C File Offset: 0x0035C86C
	public a01()
	{
	}

	// Token: 0x06007F54 RID: 32596 RVA: 0x0035E678 File Offset: 0x0035C878
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (base.vg().q() == null || base.vg().q().Zone == null || base.vg().q().h.b == null)
		{
			return dc4.e;
		}
		string a_;
		if (base.vg().q().h.b.am().StartsWith("mutated_human", StringComparison.InvariantCultureIgnoreCase) || base.vg().q().h.b.am().StartsWith("mhun", StringComparison.InvariantCultureIgnoreCase) || base.vg().e().b8().b(d8o.t))
		{
			a_ = "MutatedHumanGrowl";
		}
		else
		{
			a_ = "Frighten";
		}
		base.vg().q().c().a("frighten", a_, 1f, c9z.a, false, false);
		eym.a(base.vg().q(), (double)aju.aj);
		ak1 ak = base.vg().q().Area.a(base.vg().q().aj().a());
		awb a_2 = new awb(ak, new a01.a(base.vg().e(), base.vg().q().h.b), null, (float)base.vg().e().g(), null, null, false);
		ak.Zone.ActionManager.g9(a_2, atp.a);
		dz6.a(a_2);
		return dc4.c;
	}

	// Token: 0x020016DD RID: 5853
	[eiz("Y0a")]
	[Serializable]
	private new class a : cci, ISerializable
	{
		// Token: 0x06007F55 RID: 32597 RVA: 0x0035E81C File Offset: 0x0035CA1C
		protected a(SerializationInfo A_0, StreamingContext A_1)
		{
			this.a = (eu7)A_0.GetValue("Y0a:P", typeof(eu7));
			this.b = (EntityAspectReference<amc, amc>)A_0.GetValue("Y0a:I", typeof(EntityAspectReference<amc, amc>));
			di7.ReadList<Guid>("Y0a:AE", ref this.c, A_0);
		}

		// Token: 0x06007F56 RID: 32598 RVA: 0x0035E88C File Offset: 0x0035CA8C
		public void GetObjectData(SerializationInfo info, StreamingContext ctx)
		{
			info.AddValue("Y0a:P", this.a);
			info.AddValue("Y0a:I", this.b);
			di7.WriteList<Guid>("Y0a:AE", this.c, info);
		}

		// Token: 0x06007F57 RID: 32599 RVA: 0x0035E8C4 File Offset: 0x0035CAC4
		public a(eu7 A_0, amc A_1)
		{
			this.a = A_0;
			if (A_1 != null)
			{
				this.b = new EntityAspectReference<amc, amc>(A_1);
			}
		}

		// Token: 0x06007F58 RID: 32600 RVA: 0x0035E8F0 File Offset: 0x0035CAF0
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
						if (c5x != null && c5x.h.b != null && !this.c.Contains(b0b.qe()))
						{
							if (this.b.ao().a(c5x.h.b) == h.a)
							{
								this.a(c5x);
							}
							this.c.Add(c5x.qe());
						}
					}
				}
			}
		}

		// Token: 0x06007F59 RID: 32601 RVA: 0x0035E9E8 File Offset: 0x0035CBE8
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
			if (efk.Passive || (efk.b(d8o.e) | efk.d(CharacterImmunities.MindAffecting | CharacterImmunities.Fear)))
			{
				etm a_ = new etm(new ap9(A_0.h.b.aa()), "страху");
				bey.a(a_, this.a.b8(), A_0.h.b.aa(), A_0.h.b);
				a7v.a(a_);
				bmj.a(A_0, new ba0());
				return;
			}
			if (euf.f(this.a.b8().Skills.Get<bec>().g(), efk))
			{
				c6f a_2 = new c6f(new ap9(A_0.h.b.aa()), new ap9(this.a.b8()), "страху");
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
			ef2 a_9 = new ef2(cv5.d, cv5.a(this.a));
			efk.StatusEffects.a(a_9, false, false, false);
			if (this.a.b8().Feats.Contains<dcv>() && cuo.a.NextDouble() < dcv.a)
			{
				object a_10 = null;
				if (this.b != null && this.b.ao() != null)
				{
					a_10 = this.b.ao().a8();
				}
				axo a_11 = new axo(dcv.b * d0u.b, a_10);
				efk.StatusEffects.a(a_11, false, false, false);
			}
		}

		// Token: 0x04003237 RID: 12855
		private eu7 a;

		// Token: 0x04003238 RID: 12856
		private EntityAspectReference<amc, amc> b;

		// Token: 0x04003239 RID: 12857
		private List<Guid> c = new List<Guid>();
	}
}
