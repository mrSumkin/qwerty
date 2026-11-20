using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.References;
using Ouroboros.Playfield.Space;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Comm;

// Token: 0x020015EE RID: 5614
[eiz("SH1R")]
[Serializable]
public sealed class eh2 : a6k, ISerializable
{
	// Token: 0x06007BA4 RID: 31652 RVA: 0x0033C168 File Offset: 0x0033A368
	private eh2(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007BA5 RID: 31653 RVA: 0x0033C174 File Offset: 0x0033A374
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x06007BA6 RID: 31654 RVA: 0x0033C180 File Offset: 0x0033A380
	public eh2()
	{
	}

	// Token: 0x06007BA7 RID: 31655 RVA: 0x0033C18C File Offset: 0x0033A38C
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		ak1 ak = base.vg().h() as ak1;
		if (ak == null || ak.Area == null)
		{
			return dc4.e;
		}
		base.vg().i();
		double a_ = aw1.a(base.vg().q(), ak);
		int a_2 = euf.b(base.vg().e().b8(), euf.a(base.vg().e().b8(), true), a_, 0.0);
		ak1 ak2 = awq.a(this, ak, a_2, false);
		qy qy = new qy();
		qy.b(false);
		qy.c(false);
		qy.ad().Add(new a0f(base.vg().q(), null, new CombatSpeakEvent[]
		{
			CombatSpeakEvent.Custom1
		}));
		b0b b0b = null;
		boj.a(base.vg().q(), "Xpbl_SharkJetskiShoot", 1, double.MaxValue, false, true, null, null, null, null, true);
		dvv item = es2.a(base.vg().q(), ak2.Location.a() + new Vector3(0.5f, 0.5f, 0f), "Harp1Rocket", out b0b, null, null, true, 0.5f, null);
		if (b0b != null && b0b.Zone != null)
		{
			if (base.vg().e().b8().Vehicle != null)
			{
				agt agt;
				base.vg().e().b8().Vehicle.o().TryGetValue("rockets", out agt);
				if (agt != null && agt.fu().a5() == "harp1Rocket")
				{
					if (agt.Stacks > 1)
					{
						agt agt2 = agt;
						int num = agt2.Stacks;
						agt2.Stacks = num - 1;
					}
					else
					{
						base.vg().e().b8().Vehicle.o().Remove("rockets");
					}
					base.vg().e().b8().Vehicle.k();
				}
			}
			c5x c5x = b0b as c5x;
			if (c5x != null)
			{
				b4u aspect = c5x.GetAspect<b4u>();
				if (aspect != null)
				{
					aspect.b().Add(new eh2.a(c5x));
				}
			}
			qy.ad().Add(item);
			c7 c = new c7(b0b, false, false, true, false);
			c.a(true);
			qy.ad().Add(c);
			c5x c5x2 = Enumerable.FirstOrDefault<b0b>(Enumerable.Where<b0b>(ak2.Entities, new Func<b0b, bool>(eh2.b.a.a))) as c5x;
			if (c5x2 != null)
			{
				bfq bfq = new bfq();
				bfq.b("RocketExplode" + Guid.NewGuid().ToString());
				bfq.c("RocketExplode");
				bfq.a(bvl.c);
				qy.ad().Add(new a4s(bfq, null, new ar7(c5x2), null));
				eym.a(qy, c5x2, (double)aju.a2);
			}
			awb awb = new awb(ak2, new eh2.c(base.vg().e(), base.vg().q().h.b, ak2), bby.i(), (float)base.vg().e().g(), null);
			awb.b((double)bby.h());
			awb.r = true;
			qy.ad().Add(awb);
			b0b.Zone.ActionManager.g9(qy, atp.a);
			dz6.a(qy);
			aru aru = base.vg().q().c();
			aru.a("LaunchRocket" + Guid.NewGuid().ToString(), "LaunchRocket", 1f, c9z.a, false, false);
			aru.a("fireballLaunch" + Guid.NewGuid().ToString(), "FireballLaunch", 1f, c9z.a, false, false);
			eym.a(base.vg().q(), (double)aju.bo);
			return dc4.c;
		}
		return dc4.e;
	}

	// Token: 0x020015EF RID: 5615
	[eiz("SH1Ra")]
	[Serializable]
	private new class a : aig, ISerializable
	{
		// Token: 0x06007BA8 RID: 31656 RVA: 0x0033C5FC File Offset: 0x0033A7FC
		protected a(SerializationInfo A_0, StreamingContext A_1)
		{
			this.b = (ar7)A_0.GetValue("SH1Ra:ER", typeof(ar7));
			this.c = A_0.GetSingle("SH1Ra:DC");
		}

		// Token: 0x06007BA9 RID: 31657 RVA: 0x0033C638 File Offset: 0x0033A838
		public virtual void GetObjectData(SerializationInfo info, StreamingContext ctx)
		{
			info.AddValue("SH1Ra:ER", this.b);
			info.AddValue("SH1Ra:DC", this.c);
		}

		// Token: 0x06007BAA RID: 31658 RVA: 0x0033C65C File Offset: 0x0033A85C
		public a(b0b A_0)
		{
			this.b = new ar7(A_0);
		}

		// Token: 0x06007BAB RID: 31659 RVA: 0x0033C670 File Offset: 0x0033A870
		public bool hj(b0b A_0, Vector3 A_1, Vector3 A_2, float A_3)
		{
			if ((this.c += A_3) >= 0.5f)
			{
				this.c -= 0.5f;
				if (this.b != null && this.b.ao() != null && this.b.ao().Area != null)
				{
					aud a_ = this.b.ao().Area;
					HorizontalDirection? a_2 = null;
					string a_3 = "Smoke";
					int a_4 = 1;
					double maxValue = double.MaxValue;
					float? a_5 = dz6.b();
					boj.a(a_, A_1, a_2, a_3, a_4, maxValue, null, null, a_5, null);
				}
			}
			return false;
		}

		// Token: 0x04003127 RID: 12583
		private const float a = 0.5f;

		// Token: 0x04003128 RID: 12584
		private ar7 b;

		// Token: 0x04003129 RID: 12585
		private float c;
	}

	// Token: 0x020015F0 RID: 5616
	[eiz("SH1Rb")]
	[Serializable]
	private class c : cci, ISerializable
	{
		// Token: 0x06007BAC RID: 31660 RVA: 0x0033C730 File Offset: 0x0033A930
		protected c(SerializationInfo A_0, StreamingContext A_1)
		{
			this.a = (eu7)A_0.GetValue("SH1Rb:P", typeof(eu7));
			di7.ReadList<Guid>("SH1Rb:AE", ref this.b, A_0);
			this.c = (EntityAspectReference<amc, amc>)A_0.GetValue("SH1Rb:IR", typeof(EntityAspectReference<amc, amc>));
			if (ell.a() >= 675)
			{
				this.d = (A_0.GetValue("SH1Rb:S", typeof(edx)) as edx);
			}
		}

		// Token: 0x06007BAD RID: 31661 RVA: 0x0033C7D0 File Offset: 0x0033A9D0
		public void GetObjectData(SerializationInfo info, StreamingContext ctx)
		{
			info.AddValue("SH1Rb:P", this.a);
			di7.WriteList<Guid>("SH1Rb:AE", this.b, info);
			info.AddValue("SH1Rb:IR", this.c);
			info.AddValue("SH1Rb:S", this.d);
		}

		// Token: 0x06007BAE RID: 31662 RVA: 0x0033C824 File Offset: 0x0033AA24
		public c(eu7 A_0, amc A_1, ak1 A_2)
		{
			this.a = A_0;
			if (A_1 != null)
			{
				this.c = new EntityAspectReference<amc, amc>(A_1);
			}
			this.d = new edx(A_2);
		}

		// Token: 0x06007BAF RID: 31663 RVA: 0x0033C860 File Offset: 0x0033AA60
		public void cq(aud A_0, Point A_1, float A_2)
		{
			if (A_2 == 0f)
			{
				boj.c(A_0, A_1);
				if (boj.b(A_0, A_1))
				{
					boj.a(A_0, A_1);
					Vector3 a_ = A_1.a() + new Vector3(0.4f, 0.4f, 0f);
					HorizontalDirection? a_2 = null;
					string a_3 = "BlurredSmokeSlow" + (cuo.a.Next(3) + 1).ToString();
					int a_4 = 1;
					double maxValue = double.MaxValue;
					float? num = new float?(0.66f);
					int? num2 = null;
					int? a_5 = num2;
					float? a_6 = num;
					float? a_7 = null;
					num2 = null;
					boj.a(A_0, a_, a_2, a_3, a_4, maxValue, a_5, a_6, a_7, num2);
				}
			}
			int value;
			if (this.d != null && this.d.ao() != null)
			{
				value = (int)bnx.a(this.d.ao().Location.a(), A_1.a());
			}
			value = 0;
			double num3 = 0.7;
			if (A_2 == 0f)
			{
				Vector3 a_8 = new Vector3((float)A_1.X, (float)A_1.Y, 0f);
				HorizontalDirection? a_9 = null;
				string a_10 = "ExplosionHE_C_Flame";
				int a_11 = 1;
				double maxValue2 = double.MaxValue;
				float? num = dz6.b();
				int? num2 = null;
				int? a_12 = num2;
				float? a_13 = null;
				float? a_14 = num;
				num2 = null;
				boj.a(A_0, a_8, a_9, a_10, a_11, maxValue2, a_12, a_13, a_14, num2);
				Vector3 a_15 = new Vector3((float)A_1.X, (float)A_1.Y, 0f);
				HorizontalDirection? a_16 = null;
				string a_17 = "ExplosionHE_C_Smoke";
				int a_18 = 1;
				double maxValue3 = double.MaxValue;
				num = dz6.b();
				num2 = null;
				int? a_19 = num2;
				float? a_20 = null;
				float? a_21 = num;
				num2 = null;
				boj.a(A_0, a_15, a_16, a_17, a_18, maxValue3, a_19, a_20, a_21, num2);
			}
			else if (A_2 == 1f)
			{
				if (cuo.a.NextDouble() < num3)
				{
					Vector3 a_22 = new Vector3((float)A_1.X, (float)A_1.Y, 0f);
					HorizontalDirection? a_23 = null;
					string a_24 = "ExplosionHE_O_Flame";
					int a_25 = 1;
					double maxValue4 = double.MaxValue;
					float? num = dz6.b();
					int? num2 = new int?(value);
					boj.a(A_0, a_22, a_23, a_24, a_25, maxValue4, null, null, num, num2);
					Vector3 a_26 = new Vector3((float)A_1.X, (float)A_1.Y, 0f);
					HorizontalDirection? a_27 = null;
					string a_28 = "ExplosionHE_O_Smoke";
					int a_29 = 1;
					double maxValue5 = double.MaxValue;
					num = dz6.b();
					num2 = new int?(value);
					boj.a(A_0, a_26, a_27, a_28, a_29, maxValue5, null, null, num, num2);
				}
				else
				{
					Vector3 a_30 = new Vector3((float)A_1.X, (float)A_1.Y, 0f);
					HorizontalDirection? a_31 = null;
					string a_32 = "ExplosionHE_O_Weak_Flame";
					int a_33 = 1;
					double maxValue6 = double.MaxValue;
					float? num = dz6.b();
					int? num2 = null;
					int? a_34 = num2;
					float? a_35 = null;
					float? a_36 = num;
					num2 = null;
					boj.a(A_0, a_30, a_31, a_32, a_33, maxValue6, a_34, a_35, a_36, num2);
					Vector3 a_37 = new Vector3((float)A_1.X, (float)A_1.Y, 0f);
					HorizontalDirection? a_38 = null;
					string a_39 = "ExplosionHE_O_Weak_Smoke";
					int a_40 = 1;
					double maxValue7 = double.MaxValue;
					num = dz6.b();
					num2 = null;
					int? a_41 = num2;
					float? a_42 = null;
					float? a_43 = num;
					num2 = null;
					boj.a(A_0, a_37, a_38, a_39, a_40, maxValue7, a_41, a_42, a_43, num2);
				}
			}
			else if (cuo.a.NextDouble() < num3)
			{
				Vector3 a_44 = new Vector3((float)A_1.X, (float)A_1.Y, 0f);
				HorizontalDirection? a_45 = null;
				string a_46 = "ExplosionHE_O_Weak_Flame1";
				int a_47 = 1;
				double maxValue8 = double.MaxValue;
				float? num = dz6.b();
				int? num2 = new int?(value);
				boj.a(A_0, a_44, a_45, a_46, a_47, maxValue8, null, null, num, num2);
				Vector3 a_48 = new Vector3((float)A_1.X, (float)A_1.Y, 0f);
				HorizontalDirection? a_49 = null;
				string a_50 = "ExplosionHE_O_Weak_Smoke1";
				int a_51 = 1;
				double maxValue9 = double.MaxValue;
				num = dz6.b();
				num2 = new int?(value);
				boj.a(A_0, a_48, a_49, a_50, a_51, maxValue9, null, null, num, num2);
			}
			else
			{
				Vector3 a_52 = new Vector3((float)A_1.X, (float)A_1.Y, 0f);
				HorizontalDirection? a_53 = null;
				string a_54 = "ExplosionHE_O_Weak_Flame";
				int a_55 = 1;
				double maxValue10 = double.MaxValue;
				float? num = dz6.b();
				int? num2 = null;
				int? a_56 = num2;
				float? a_57 = null;
				float? a_58 = num;
				num2 = null;
				boj.a(A_0, a_52, a_53, a_54, a_55, maxValue10, a_56, a_57, a_58, num2);
				Vector3 a_59 = new Vector3((float)A_1.X, (float)A_1.Y, 0f);
				HorizontalDirection? a_60 = null;
				string a_61 = "ExplosionHE_O_Weak_Smoke";
				int a_62 = 1;
				double maxValue11 = double.MaxValue;
				num = dz6.b();
				num2 = null;
				int? a_63 = num2;
				float? a_64 = null;
				float? a_65 = num;
				num2 = null;
				boj.a(A_0, a_59, a_60, a_61, a_62, maxValue11, a_63, a_64, a_65, num2);
			}
			ak1 ak = A_0.b(A_1.X, A_1.Y);
			if (ak != null)
			{
				foreach (b0b b0b in Enumerable.ToList<b0b>(ak.Entities))
				{
					c5x c5x = b0b as c5x;
					if (c5x != null)
					{
						if (c5x.h.b != null && !this.b.Contains(b0b.qe()))
						{
							this.a(this.c.ao(), c5x.h.b, A_2);
							this.b.Add(c5x.qe());
						}
						if (c5x.y.b != null)
						{
							c5x.y.b.a(null);
							this.b.Add(c5x.qe());
						}
					}
				}
			}
		}

		// Token: 0x06007BB0 RID: 31664 RVA: 0x0033CE40 File Offset: 0x0033B040
		private void a(amc A_0, amc A_1, float A_2)
		{
			if (this.a == null || this.a.b8() == null || !(this.a.p() is de0))
			{
				return;
			}
			if (!A_1.a8().IsPlayer)
			{
				awq.a(this.c.ao(), A_1, true, true, null, true, true, false, false);
			}
			double num;
			if (A_2 > 0f)
			{
				num = Math.Min(c18.az, (double)(A_2 - 1f) * c18.a0);
			}
			else
			{
				num = 0.0;
			}
			double num2 = 1.0 - num;
			cwt cwt = new cwt();
			if (A_0 != null && A_0.aa().Feats.Contains<chc>())
			{
				num2 *= 1.0 + chc.b(A_0.aa());
				cwt.ak += chc.a(A_0.aa());
			}
			cwt.b = true;
			cwt.e = false;
			cwt.i = new ap9(this.a.b8());
			cwt.j = new ap9(A_1.aa());
			cwt.f.AddRange(de0.a(num2));
			cwt.k = "Ракета Арфа-1";
			cwt.q = true;
			cwt.h = ImpactSpeed.High;
			A_1.aa().Defense.a(cwt);
		}

		// Token: 0x0400312A RID: 12586
		private eu7 a;

		// Token: 0x0400312B RID: 12587
		private List<Guid> b = new List<Guid>();

		// Token: 0x0400312C RID: 12588
		private EntityAspectReference<amc, amc> c;

		// Token: 0x0400312D RID: 12589
		private edx d;
	}

	// Token: 0x020015F1 RID: 5617
	[CompilerGenerated]
	[Serializable]
	private sealed class b
	{
		// Token: 0x06007BB3 RID: 31667 RVA: 0x0033CFBC File Offset: 0x0033B1BC
		internal bool a(b0b A_0)
		{
			return A_0.IsFloor;
		}

		// Token: 0x0400312E RID: 12590
		public static readonly eh2.b a = new eh2.b();

		// Token: 0x0400312F RID: 12591
		public static Func<b0b, bool> b;
	}
}
