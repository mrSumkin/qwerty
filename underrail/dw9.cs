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

// Token: 0x0200161B RID: 5659
[eiz("LD9")]
[Serializable]
public sealed class dw9 : a6k, ISerializable
{
	// Token: 0x06007C6D RID: 31853 RVA: 0x00346564 File Offset: 0x00344764
	private dw9(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007C6E RID: 31854 RVA: 0x00346570 File Offset: 0x00344770
	public dw9()
	{
	}

	// Token: 0x06007C6F RID: 31855 RVA: 0x00346578 File Offset: 0x00344778
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		ak1 ak = base.vg().h() as ak1;
		if (ak == null || ak.Area == null)
		{
			return dc4.e;
		}
		base.vg().i();
		double a_ = aw1.a(base.vg().q(), ak);
		int a_2 = (int)euf.a(base.vg().e().b8(), btz.l, false);
		int a_3 = euf.b(base.vg().e().b8(), a_2, a_, 0.0);
		ak1 ak2 = awq.a(this, ak, a_3, false);
		qy qy = new qy();
		qy.b(false);
		qy.c(false);
		qy.ad().Add(new a0f(base.vg().q(), null, new CombatSpeakEvent[]
		{
			CombatSpeakEvent.Custom1
		}));
		b0b b0b = null;
		dvv item = es2.a(base.vg().q(), ak2.Location.a() + new Vector3(0.5f, 0.5f, 0f), "redrocket", out b0b, null, null, true, 0.5f, null);
		if (b0b != null && b0b.Zone != null)
		{
			c5x c5x = b0b as c5x;
			if (c5x != null)
			{
				b4u aspect = c5x.GetAspect<b4u>();
				if (aspect != null)
				{
					aspect.b().Add(new dw9.a());
				}
			}
			qy.ad().Add(item);
			c7 c = new c7(b0b, false, false, true, false);
			c.a(true);
			qy.ad().Add(c);
			c5x c5x2 = Enumerable.FirstOrDefault<b0b>(Enumerable.Where<b0b>(ak2.Entities, new Func<b0b, bool>(dw9.b.a.a))) as c5x;
			if (c5x2 != null)
			{
				bfq bfq = new bfq();
				bfq.b("RocketExplode" + Guid.NewGuid().ToString());
				bfq.c("RocketExplode");
				bfq.a(bvl.c);
				qy.ad().Add(new a4s(bfq, null, new ar7(c5x2), null));
				eym.a(qy, c5x2, (double)aju.a2);
			}
			awb awb = new awb(ak2, new dw9.c(base.vg().e(), base.vg().q().h.b), bby.i(), (float)base.vg().e().g(), null);
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

	// Token: 0x0200161C RID: 5660
	[eiz("LD9a")]
	[Serializable]
	private new class a : aig, ISerializable
	{
		// Token: 0x06007C70 RID: 31856 RVA: 0x003468DC File Offset: 0x00344ADC
		protected a(SerializationInfo A_0, StreamingContext A_1)
		{
			this.b = A_0.GetSingle("LD9a:DC");
		}

		// Token: 0x06007C71 RID: 31857 RVA: 0x003468F8 File Offset: 0x00344AF8
		public virtual void GetObjectData(SerializationInfo info, StreamingContext ctx)
		{
			info.AddValue("LD9a:DC", this.b);
		}

		// Token: 0x06007C72 RID: 31858 RVA: 0x0034690C File Offset: 0x00344B0C
		public a()
		{
		}

		// Token: 0x06007C73 RID: 31859 RVA: 0x00346918 File Offset: 0x00344B18
		public bool hj(b0b A_0, Vector3 A_1, Vector3 A_2, float A_3)
		{
			if ((this.b += A_3) >= 0.5f)
			{
				this.b -= 0.5f;
				if (A_0 != null && A_0.Area != null)
				{
					Vector3 vector = A_1 + bnx.b(aw1.b(A_0.VisualDirection)).b() * 0.3f;
					int value = (int)((A_0.VisualDirection + 9) % (HorizontalDirection)8);
					aud a_ = A_0.Area;
					Vector3 a_2 = vector;
					HorizontalDirection? a_3 = null;
					string a_4 = "rocket_exhaust_smoke_" + cuo.a.Next(3).ToString();
					int a_5 = 1;
					double maxValue = double.MaxValue;
					float? a_6 = dz6.b();
					int? a_7 = new int?(value);
					boj.a(a_, a_2, a_3, a_4, a_5, maxValue, null, null, a_6, a_7);
				}
			}
			return false;
		}

		// Token: 0x0400316E RID: 12654
		private const float a = 0.5f;

		// Token: 0x0400316F RID: 12655
		private float b;
	}

	// Token: 0x0200161D RID: 5661
	[eiz("LD9b")]
	[Serializable]
	private class c : cci, ISerializable
	{
		// Token: 0x06007C74 RID: 31860 RVA: 0x00346A00 File Offset: 0x00344C00
		protected c(SerializationInfo A_0, StreamingContext A_1)
		{
			this.a = (eu7)A_0.GetValue("LD9b:P", typeof(eu7));
			di7.ReadList<Guid>("LD9b:AE", ref this.b, A_0);
			this.c = (EntityAspectReference<amc, amc>)A_0.GetValue("LD9b:IR", typeof(EntityAspectReference<amc, amc>));
			if (ell.a() >= 704)
			{
				this.d = (A_0.GetValue("LD9b:T", typeof(edx)) as edx);
			}
		}

		// Token: 0x06007C75 RID: 31861 RVA: 0x00346AA0 File Offset: 0x00344CA0
		public void GetObjectData(SerializationInfo info, StreamingContext ctx)
		{
			info.AddValue("LD9b:P", this.a);
			di7.WriteList<Guid>("LD9b:AE", this.b, info);
			info.AddValue("LD9b:IR", this.c);
			info.AddValue("LD9b:T", this.d);
		}

		// Token: 0x06007C76 RID: 31862 RVA: 0x00346AF4 File Offset: 0x00344CF4
		public c(eu7 A_0, amc A_1)
		{
			this.a = A_0;
			if (A_1 != null)
			{
				this.c = new EntityAspectReference<amc, amc>(A_1);
			}
		}

		// Token: 0x06007C77 RID: 31863 RVA: 0x00346B24 File Offset: 0x00344D24
		public void cq(aud A_0, Point A_1, float A_2)
		{
			ak1 ak = A_0.b(A_1.X, A_1.Y);
			if (ak != null)
			{
				int value = (int)this.a(A_1);
				double num = 0.7;
				if (A_2 == 0f)
				{
					this.d = new edx(ak);
					Vector3 a_ = new Vector3((float)A_1.X, (float)A_1.Y, 0f);
					HorizontalDirection? a_2 = null;
					string a_3 = "ExplosionHE_C_Flame";
					int a_4 = 1;
					double maxValue = double.MaxValue;
					float? num2 = dz6.b();
					int? num3 = null;
					int? a_5 = num3;
					float? a_6 = null;
					float? a_7 = num2;
					num3 = null;
					boj.a(A_0, a_, a_2, a_3, a_4, maxValue, a_5, a_6, a_7, num3);
					Vector3 a_8 = new Vector3((float)A_1.X, (float)A_1.Y, 0f);
					HorizontalDirection? a_9 = null;
					string a_10 = "ExplosionHE_C_Smoke";
					int a_11 = 1;
					double maxValue2 = double.MaxValue;
					num2 = dz6.b();
					num3 = null;
					int? a_12 = num3;
					float? a_13 = null;
					float? a_14 = num2;
					num3 = null;
					boj.a(A_0, a_8, a_9, a_10, a_11, maxValue2, a_12, a_13, a_14, num3);
				}
				else if (A_2 == 1f)
				{
					if (cuo.a.NextDouble() < num)
					{
						Vector3 a_15 = new Vector3((float)A_1.X, (float)A_1.Y, 0f);
						HorizontalDirection? a_16 = null;
						string a_17 = "ExplosionHE_O_Flame";
						int a_18 = 1;
						double maxValue3 = double.MaxValue;
						float? num2 = dz6.b();
						int? num3 = new int?(value);
						boj.a(A_0, a_15, a_16, a_17, a_18, maxValue3, null, null, num2, num3);
						Vector3 a_19 = new Vector3((float)A_1.X, (float)A_1.Y, 0f);
						HorizontalDirection? a_20 = null;
						string a_21 = "ExplosionHE_O_Smoke";
						int a_22 = 1;
						double maxValue4 = double.MaxValue;
						num2 = dz6.b();
						num3 = new int?(value);
						boj.a(A_0, a_19, a_20, a_21, a_22, maxValue4, null, null, num2, num3);
					}
					else
					{
						Vector3 a_23 = new Vector3((float)A_1.X, (float)A_1.Y, 0f);
						HorizontalDirection? a_24 = null;
						string a_25 = "ExplosionHE_O_Weak_Flame";
						int a_26 = 1;
						double maxValue5 = double.MaxValue;
						float? num2 = dz6.b();
						int? num3 = null;
						int? a_27 = num3;
						float? a_28 = null;
						float? a_29 = num2;
						num3 = null;
						boj.a(A_0, a_23, a_24, a_25, a_26, maxValue5, a_27, a_28, a_29, num3);
						Vector3 a_30 = new Vector3((float)A_1.X, (float)A_1.Y, 0f);
						HorizontalDirection? a_31 = null;
						string a_32 = "ExplosionHE_O_Weak_Smoke";
						int a_33 = 1;
						double maxValue6 = double.MaxValue;
						num2 = dz6.b();
						num3 = null;
						int? a_34 = num3;
						float? a_35 = null;
						float? a_36 = num2;
						num3 = null;
						boj.a(A_0, a_30, a_31, a_32, a_33, maxValue6, a_34, a_35, a_36, num3);
					}
				}
				else if (cuo.a.NextDouble() < num)
				{
					Vector3 a_37 = new Vector3((float)A_1.X, (float)A_1.Y, 0f);
					HorizontalDirection? a_38 = null;
					string a_39 = "ExplosionHE_O_Weak_Flame1";
					int a_40 = 1;
					double maxValue7 = double.MaxValue;
					float? num2 = dz6.b();
					int? num3 = new int?(value);
					boj.a(A_0, a_37, a_38, a_39, a_40, maxValue7, null, null, num2, num3);
					Vector3 a_41 = new Vector3((float)A_1.X, (float)A_1.Y, 0f);
					HorizontalDirection? a_42 = null;
					string a_43 = "ExplosionHE_O_Weak_Smoke1";
					int a_44 = 1;
					double maxValue8 = double.MaxValue;
					num2 = dz6.b();
					num3 = new int?(value);
					boj.a(A_0, a_41, a_42, a_43, a_44, maxValue8, null, null, num2, num3);
				}
				else
				{
					Vector3 a_45 = new Vector3((float)A_1.X, (float)A_1.Y, 0f);
					HorizontalDirection? a_46 = null;
					string a_47 = "ExplosionHE_O_Weak_Flame";
					int a_48 = 1;
					double maxValue9 = double.MaxValue;
					float? num2 = dz6.b();
					int? num3 = null;
					int? a_49 = num3;
					float? a_50 = null;
					float? a_51 = num2;
					num3 = null;
					boj.a(A_0, a_45, a_46, a_47, a_48, maxValue9, a_49, a_50, a_51, num3);
					Vector3 a_52 = new Vector3((float)A_1.X, (float)A_1.Y, 0f);
					HorizontalDirection? a_53 = null;
					string a_54 = "ExplosionHE_O_Weak_Smoke";
					int a_55 = 1;
					double maxValue10 = double.MaxValue;
					num2 = dz6.b();
					num3 = null;
					int? a_56 = num3;
					float? a_57 = null;
					float? a_58 = num2;
					num3 = null;
					boj.a(A_0, a_52, a_53, a_54, a_55, maxValue10, a_56, a_57, a_58, num3);
				}
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

		// Token: 0x06007C78 RID: 31864 RVA: 0x0034704C File Offset: 0x0034524C
		private void a(amc A_0, amc A_1, float A_2)
		{
			if (this.a == null || this.a.b8() == null || !(this.a.p() is a40))
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
			cwt cwt = new cwt();
			cwt.b = true;
			cwt.e = false;
			cwt.i = new ap9(this.a.b8());
			cwt.j = new ap9(A_1.aa());
			cwt.f.AddRange(a40.a(1.0 - num));
			cwt.k = "Ракета дредноута";
			cwt.q = true;
			cwt.h = ImpactSpeed.High;
			A_1.aa().Defense.a(cwt);
		}

		// Token: 0x06007C79 RID: 31865 RVA: 0x00347168 File Offset: 0x00345368
		private HorizontalDirection a(Point A_0)
		{
			if (this.d != null && this.d.ao() != null)
			{
				return bnx.a(this.d.ao().Location.a(), A_0.a());
			}
			return HorizontalDirection.North;
		}

		// Token: 0x04003170 RID: 12656
		private eu7 a;

		// Token: 0x04003171 RID: 12657
		private List<Guid> b = new List<Guid>();

		// Token: 0x04003172 RID: 12658
		private EntityAspectReference<amc, amc> c;

		// Token: 0x04003173 RID: 12659
		private edx d;
	}

	// Token: 0x0200161E RID: 5662
	[CompilerGenerated]
	[Serializable]
	private sealed class b
	{
		// Token: 0x06007C7C RID: 31868 RVA: 0x003471BC File Offset: 0x003453BC
		internal bool a(b0b A_0)
		{
			return A_0.IsFloor;
		}

		// Token: 0x04003174 RID: 12660
		public static readonly dw9.b a = new dw9.b();

		// Token: 0x04003175 RID: 12661
		public static Func<b0b, bool> b;
	}
}
