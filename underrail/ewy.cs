using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Lightning;
using Ouroboros.Playfield.Space;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Items;

// Token: 0x020013F0 RID: 5104
public sealed class ewy : ajr, e4
{
	// Token: 0x060072E0 RID: 29408 RVA: 0x00305F40 File Offset: 0x00304140
	public override void pe(amc A_0, amc A_1, cd1 A_2, cwt A_3, AmmoType A_4, enp A_5 = null, Action<cwt, amc> A_6 = null)
	{
		if (A_1 == null || A_1.a8() == null || A_1.a8().Area == null || A_1.a8().Zone == null)
		{
			return;
		}
		Point a_ = A_1.a8().aj().a();
		ak1 a_2 = A_1.a8().Area.a(a_);
		this.a(A_0, a_2, A_2, A_4, A_5);
	}

	// Token: 0x060072E1 RID: 29409 RVA: 0x00305FB0 File Offset: 0x003041B0
	public void a(amc A_0, ak1 A_1, cd1 A_2, AmmoType A_3, enp A_4 = null)
	{
		if (A_1 != null && A_1.Area != null && A_1.Area.Zone != null && A_0 != null && A_0.a8() != null && A_0.a8().t.b != null && A_2 != null)
		{
			double a_ = aw1.a(A_0.a8(), A_1);
			double num = aw1.a(A_0.a8(), A_1);
			cmn cmn = awq.a(A_0, null, null, null);
			bool flag = awq.f(A_0);
			bg3 bg = this.zj(A_0.aa(), null, num, flag, 1.0, A_3, cmn);
			efk a_2 = A_0.aa();
			efk a_3 = null;
			double a_4 = num;
			cmn a_5 = cmn;
			double a_6 = -10000.0;
			double a_7 = 1.0;
			bool a_8 = false;
			bool a_9 = flag;
			double a_10 = 1.0;
			bool a_11 = true;
			double? a_12 = new double?(0.0);
			cwt cwt = euf.a(a_2, a_3, a_4, a_5, a_6, a_7, a_8, A_3, a_9, a_10, a_11, A_2, null, true, a_12);
			if (cwt.f == null || cwt.f.Count == 0)
			{
				return;
			}
			int a_13 = cwt.f[0].Amount;
			efk a_14 = A_0.aa();
			efk a_15 = null;
			double a_16 = num;
			cmn a_17 = cmn;
			double a_18 = -10000.0;
			double a_19 = 1.0;
			bool a_20 = false;
			bool a_21 = flag;
			double a_22 = 1.0;
			bool a_23 = true;
			a_12 = new double?((double)1);
			cwt = euf.a(a_14, a_15, a_16, a_17, a_18, a_19, a_20, A_3, a_21, a_22, a_23, A_2, null, true, a_12);
			if (cwt.f == null || cwt.f.Count == 0)
			{
				return;
			}
			int a_24 = cwt.f[0].Amount;
			A_0.aa().Offense.a0();
			A_0.aa().Offense.am();
			int a_25 = A_0.aa().Skills.Get<e8k>().g();
			double[] array = euf.a(A_0.aa(), a_25, a_, 0.0);
			double num2 = bg.a / array[0];
			int a_26 = 3;
			double num3 = cuo.a.NextDouble();
			for (int i = 0; i < array.Length; i++)
			{
				double num4 = array[i] * num2;
				if (num3 < num4)
				{
					a_26 = i;
					break;
				}
			}
			ak1 ak = awq.a(A_0.a8().t.b, A_1, a_26, false);
			qy qy = new qy();
			qy.b(false);
			qy.c(false);
			qy.ad().Add(new a4s(new bfq("FusionCannon"), null, new ar7(A_0.a8()), null));
			qy.ad().Add(new cg6(A_0));
			Vector3 vector = es2.a(A_0.a8(), 0.8f, true);
			aud a_27 = A_0.a8().Area;
			Vector3 a_28 = vector;
			HorizontalDirection? a_29 = null;
			string a_30 = "xphw_Fusion_Shoot";
			int a_31 = 3;
			double maxValue = double.MaxValue;
			float? a_32 = dz6.b();
			c5x c5x = boj.a(a_27, a_28, a_29, a_30, a_31, maxValue, null, null, a_32, null);
			if (c5x != null && c5x.o.b != null)
			{
				c5x.o.b.b = new Point(c5x.o.b.b.X, A_0.a8().ac);
			}
			b0b b0b;
			dvv item = es2.a(es2.a(A_0.a8(), 0.8f, true), ak.Location.a() + new Vector3(0.5f, 0.5f, 0f), A_0.a8().Area, "fusion", null, out b0b);
			if (b0b != null && b0b.Zone != null)
			{
				(b0b as c5x).ae = new float?(0f);
				qy.ad().Add(new bm3(500));
				List<auv> list = qy.ad();
				ch3 ch = new ch3();
				ch.a(null);
				list.Add(new a4s(ch, null, new ar7(b0b), null));
				qy.ad().Add(item);
				c7 c = new c7(b0b, false, false, true, false);
				c.a(true);
				qy.ad().Add(c);
				new ah7("fusionProjectileLantern", null)
				{
					LightFadeRate = 0.33f,
					Range = 3f,
					Light = new ae8(adi.@as, 1f, LightType.Increment)
				}.g().be(b0b);
				c5x c5x2 = Enumerable.FirstOrDefault<b0b>(Enumerable.Where<b0b>(ak.Entities, new Func<b0b, bool>(ewy.a.a.a))) as c5x;
				if (c5x2 != null)
				{
					bfq bfq = new bfq();
					bfq.b("FusionExplosion" + Guid.NewGuid().ToString());
					bfq.c("FusionExplosion");
					bfq.a(bvl.c);
					qy.ad().Add(new a4s(bfq, null, new ar7(c5x2), null));
					eym.a(qy, c5x2, (double)aju.bu);
				}
				awb awb = new awb(ak, new d40(A_0)
				{
					c = new a1q(DamageType.Energy, a_13, a_24),
					d = new a1q(DamageType.Electricity, a_13, a_24),
					f = new vu(null),
					g = new ekt
					{
						a = A_0.aa().Offense.a0(),
						b = A_0.aa().Offense.am()
					}
				}, new ae8?(new ae8(adi.@as, 1f, LightType.Increment)), 3f, null, null, false);
				awb.r = true;
				awb.c(0.2f);
				awb.b(0.15f);
				awb.a(6f);
				awb.s = true;
				qy.ad().Add(awb);
			}
			b0b.Zone.ActionManager.g9(qy, atp.a);
			dz6.a(qy);
			A_0.a8().c();
		}
	}

	// Token: 0x060072E2 RID: 29410 RVA: 0x00306610 File Offset: 0x00304810
	public override int pd()
	{
		return 500;
	}

	// Token: 0x060072E3 RID: 29411 RVA: 0x00306618 File Offset: 0x00304818
	public bg3 zj(efk A_0, efk A_1, double A_2, bool A_3, double A_4, AmmoType A_5, cmn A_6)
	{
		if (A_0 == null)
		{
			return null;
		}
		bg3 bg = euf.a(A_0, null, A_2, 1.0, true, A_5, A_3, 1.0, A_6, null, null);
		int a_ = A_0.Skills.Get<e8k>().g();
		if (euf.a(A_0, a_, A_2, 0.0)[0] >= 1.0)
		{
			bg.a = 1.0;
		}
		return bg;
	}

	// Token: 0x020013F1 RID: 5105
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x060072E7 RID: 29415 RVA: 0x003066B8 File Offset: 0x003048B8
		internal bool a(b0b A_0)
		{
			return A_0.IsFloor;
		}

		// Token: 0x04002EF3 RID: 12019
		public static readonly ewy.a a = new ewy.a();

		// Token: 0x04002EF4 RID: 12020
		public static Func<b0b, bool> b;
	}
}
