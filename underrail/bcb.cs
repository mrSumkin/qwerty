using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Lightning;
using TimelapseVertigo.Rules.Items;

// Token: 0x020013F7 RID: 5111
public class bcb : ay7
{
	// Token: 0x060072F8 RID: 29432 RVA: 0x00306D7C File Offset: 0x00304F7C
	public void pe(amc A_0, amc A_1, cd1 A_2, cwt A_3, AmmoType A_4, enp A_5 = null, Action<cwt, amc> A_6 = null)
	{
		if (A_1 != null && A_1.a8() != null && A_1.a8().Area != null && A_1.a8().Zone != null && A_0 != null && A_0.a8() != null && A_0.a8().t.b != null)
		{
			Point a_ = A_1.a8().aj().a();
			ak1 ak = A_1.a8().Area.a(a_);
			if (ak != null)
			{
				double a_2 = aw1.a(A_0.a8(), ak);
				int a_3 = euf.b(A_0.aa(), A_0.aa().Skills.Get<ct7>().g(), a_2, 0.0);
				ak1 ak2 = awq.a(A_0.a8().t.b, ak, a_3, false);
				qy qy = new qy();
				qy.b(false);
				qy.c(false);
				qy.ad().Add(new a4s(new bfq("FusionCannon"), null, new ar7(A_0.a8()), null));
				this.of(qy, A_0, A_1, A_2, A_3, A_4);
				qy.ad().Add(new bm3(dz6.b(750)));
				b0b b0b;
				dvv item = es2.a(A_0.a8(), ak2.Location.a() + new Vector3(0.5f, 0.5f, 0f), "fusion", out b0b, null, null, true, 0.5f, null);
				if (b0b != null && b0b.Zone != null)
				{
					(b0b as c5x).ae = new float?(0f);
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
					c5x c5x = Enumerable.FirstOrDefault<b0b>(Enumerable.Where<b0b>(ak2.Entities, new Func<b0b, bool>(bcb.a.a.a))) as c5x;
					if (c5x != null)
					{
						bfq bfq = new bfq();
						bfq.b("FusionExplosion" + Guid.NewGuid().ToString());
						bfq.c("FusionExplosion");
						bfq.a(bvl.c);
						qy.ad().Add(new a4s(bfq, null, new ar7(c5x), null));
						eym.a(qy, c5x, (double)aju.bu);
					}
					awb awb = new awb(ak2, new ct1(A_0, A_2), new ae8?(new ae8(adi.@as, 1f, LightType.Increment)), 2f, null, null, false);
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
	}

	// Token: 0x060072F9 RID: 29433 RVA: 0x00307130 File Offset: 0x00305330
	protected virtual void of(qy A_0, amc A_1, amc A_2, cd1 A_3, cwt A_4, AmmoType A_5)
	{
	}

	// Token: 0x060072FA RID: 29434 RVA: 0x00307134 File Offset: 0x00305334
	public void ae(amc A_0, amc A_1, cd1 A_2, AmmoType A_3)
	{
	}

	// Token: 0x020013F8 RID: 5112
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x060072FE RID: 29438 RVA: 0x00307154 File Offset: 0x00305354
		internal bool a(b0b A_0)
		{
			return A_0.IsFloor;
		}

		// Token: 0x04002EF5 RID: 12021
		public static readonly bcb.a a = new bcb.a();

		// Token: 0x04002EF6 RID: 12022
		public static Func<b0b, bool> b;
	}
}
