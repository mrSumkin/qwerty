using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x020016C4 RID: 5828
[eiz("TCOAX")]
[Serializable]
public sealed class dgi : a6k, ISerializable
{
	// Token: 0x06007F03 RID: 32515 RVA: 0x0035B200 File Offset: 0x00359400
	private dgi(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007F04 RID: 32516 RVA: 0x0035B20C File Offset: 0x0035940C
	public dgi()
	{
	}

	// Token: 0x06007F05 RID: 32517 RVA: 0x0035B214 File Offset: 0x00359414
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		ak1 ak = base.vg().h() as ak1;
		if (ak == null || ak.Area == null)
		{
			return dc4.e;
		}
		base.vg().i();
		string classPropertyValue = base.vg().e().b8().CustomProperties.GetClassPropertyValue<string>(ddm.i);
		if (string.IsNullOrEmpty(classPropertyValue))
		{
			return dc4.e;
		}
		lh lh = ckw.a(classPropertyValue);
		if (lh == null)
		{
			return dc4.e;
		}
		double a_ = aw1.a(base.vg().q(), ak);
		int a_2 = euf.c(base.vg().e().b8(), a_);
		ak1 ak2 = awq.a(this, ak, a_2, false);
		b0b b0b = null;
		dvv item = es2.a(base.vg().q(), ak2.Location.a() + new Vector3(0.5f, 0.5f, 0f), lh.me(), out b0b, null, null, true, 0.8f, null);
		dz6.a(base.vg().q(), int.MaxValue, true);
		if (b0b != null && b0b.Zone != null)
		{
			lh.akc(base.vg().q().h.b);
			((c5x)b0b).ae = new float?(0f);
			awx awx = new awx();
			awx awx2 = awx;
			awx2.a(awx2.kh() | (m7.b | m7.k));
			awx.a(false);
			awx.b(false);
			awx.c(false);
			awx.ad().Add(new a4s(new bfq("LargeObjectThrow"), null, new ar7(base.vg().q()), null));
			awx.ad().Add(new e4t(base.vg().q().h.b, CharacterState.Throw, dz6.b(65), 0, null, 1));
			base.vg().q().i.b.b(awx, atp.a);
			dtb dtb = new dtb();
			dtb.b(false);
			dtb.c(false);
			dtb.ad().Add(new bm3(3 * dz6.b(65)));
			List<auv> list = dtb.ad();
			ch3 ch = new ch3();
			ch.a(null);
			list.Add(new a4s(ch, null, new ar7(b0b), null));
			afw afw = new afw();
			afw.a()[ddm.i] = null;
			dtb.ad().Add(new a4s(afw, null, new ar7(base.vg().q()), null));
			dtb.ad().Add(new a4s(new ctl(), null, new ar7(base.vg().q()), null));
			dtb.ad().Add(item);
			c7 c = new c7(b0b, false, false, true, false);
			c.a(true);
			dtb.ad().Add(new a4s(new agk(classPropertyValue, ak2), new ar7(b0b), null, null));
			dtb.ad().Add(c);
			base.vg().q().i.b.b(dtb, atp.a);
			dz6.a(dtb);
			return dc4.c;
		}
		return dc4.e;
	}
}
