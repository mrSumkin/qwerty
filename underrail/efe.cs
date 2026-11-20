using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Lightning;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x020015EC RID: 5612
[eiz("SDFCA")]
[Serializable]
public sealed class efe : a6k, ISerializable
{
	// Token: 0x06007B9E RID: 31646 RVA: 0x0033BC64 File Offset: 0x00339E64
	private efe(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007B9F RID: 31647 RVA: 0x0033BC70 File Offset: 0x00339E70
	public efe()
	{
	}

	// Token: 0x06007BA0 RID: 31648 RVA: 0x0033BC7C File Offset: 0x00339E7C
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
		b0b b0b = null;
		dvv item = es2.a(base.vg().q(), ak2.Location.a() + new Vector3(0.5f, 0.5f, 0f), "fusion", out b0b, null, null, true, 0.5f, null);
		if (b0b != null && b0b.Zone != null)
		{
			((c5x)b0b).ae = new float?(0f);
			awx awx = new awx();
			awx awx2 = awx;
			awx2.a(awx2.kh() | m7.b);
			awx.b(false);
			awx.c(false);
			awx.ad().Add(new a7j(base.vg().q(), "Firing\\xpbl_Devastator_Shoot", 1, double.MaxValue, false, true, null, null, null, null, true, null));
			awx.ad().Add(new e4t(base.vg().q().h.b, CharacterState.Custom4, dz6.b(75), 0, null, 1));
			base.vg().q().i.b.b(awx, atp.a);
			base.vg().q().h.b.aa().Vehicle.h((double)eex.f);
			dtb dtb = new dtb();
			dtb.b(false);
			dtb.c(false);
			dtb.ad().Add(new a4s(new bfq("FusionCannon"), null, new ar7(base.vg().q()), null));
			dtb.ad().Add(new a7j(base.vg().q(), "Firing\\xpbl_Devastator_ChargeUp", 3, double.MaxValue, false, true, null, null, null, null, true, null));
			dtb.ad().Add(new bm3(dz6.b(650)));
			List<auv> list = dtb.ad();
			ch3 ch = new ch3();
			ch.a(null);
			list.Add(new a4s(ch, null, new ar7(b0b), null));
			dtb.ad().Add(item);
			c7 c = new c7(b0b, false, false, true, false);
			c.a(true);
			dtb.ad().Add(c);
			new ah7("fusionProjectileLantern", null)
			{
				LightFadeRate = 0.33f,
				Range = 3f,
				Light = new ae8(adi.@as, 1f, LightType.Increment)
			}.g().be(b0b);
			c5x c5x = Enumerable.FirstOrDefault<b0b>(Enumerable.Where<b0b>(ak2.Entities, new Func<b0b, bool>(efe.a.a.a))) as c5x;
			if (c5x != null)
			{
				bfq bfq = new bfq();
				bfq.b("FusionExplosion" + Guid.NewGuid().ToString());
				bfq.c("FusionExplosion");
				bfq.a(bvl.c);
				dtb.ad().Add(new a4s(bfq, null, new ar7(c5x), null));
				eym.a(dtb, c5x, (double)aju.bu);
			}
			awb awb = new awb(ak2, new ct1(base.vg().q().h.b, eex.a()), new ae8?(new ae8(adi.@as, 1f, LightType.Increment)), 2f, null, null, false);
			awb.r = true;
			awb.c(0.2f);
			awb.b(0.15f);
			awb.a(6f);
			dtb.ad().Add(awb);
			base.vg().q().i.b.b(dtb, atp.a);
			return dc4.c;
		}
		return dc4.e;
	}

	// Token: 0x020015ED RID: 5613
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06007BA3 RID: 31651 RVA: 0x0033C160 File Offset: 0x0033A360
		internal bool a(b0b A_0)
		{
			return A_0.IsFloor;
		}

		// Token: 0x04003125 RID: 12581
		public static readonly efe.a a = new efe.a();

		// Token: 0x04003126 RID: 12582
		public static Func<b0b, bool> b;
	}
}
