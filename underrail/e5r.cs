using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x020015E7 RID: 5607
[eiz("SKTHSLA")]
[Serializable]
public sealed class e5r : a4h, ISerializable
{
	// Token: 0x06007B8F RID: 31631 RVA: 0x0033AD64 File Offset: 0x00338F64
	private e5r(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007B90 RID: 31632 RVA: 0x0033AD70 File Offset: 0x00338F70
	public e5r()
	{
	}

	// Token: 0x06007B91 RID: 31633 RVA: 0x0033AD7C File Offset: 0x00338F7C
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		c5x c5x = base.vg().h() as c5x;
		if (c5x == null || c5x.Area == null || c5x.h.b == null || base.vg().q() == null || base.vg().q().i.b == null)
		{
			return dc4.e;
		}
		base.vg().i();
		CharacterState a_ = base.a();
		awx awx = new awx();
		awx awx2 = awx;
		awx2.a(awx2.kh() | m7.b);
		awx.b(false);
		awx.c(false);
		awx.ad().Add(new a4s(new bfq("Xpbl_SkerderTentacleHandAttack"), null, new ar7(base.vg().q()), null));
		awx.ad().Add(new e4t(base.vg().q().h.b, a_, dz6.b(cux.m), 0, null, 1));
		base.vg().q().i.b.b(awx, atp.a);
		dtb dtb = new dtb();
		dtb.b(false);
		dtb.c(false);
		dtb.ad().Add(new bm3(dz6.b(cux.m * 4)));
		cmn cmn = new cmn();
		cd1 cd = cmu.a();
		euf.a(base.vg().e().b8(), c5x.h.b.aa(), cmn, 1.0, cd);
		efk a_2 = base.vg().e().b8();
		efk a_3 = c5x.h.b.aa();
		cmn a_4 = cmn;
		double a_5 = 0.0;
		cd1 a_6 = cd;
		cwt cwt = euf.a(a_2, a_3, a_4, a_5, null, 1.0, a_6, true);
		dtb.ad().Add(new a89(base.vg().q().h.b, c5x.h.b, cwt, cd, null));
		if (cwt.b)
		{
			List<auv> list = dtb.ad();
			c5x a_7 = c5x;
			string a_8 = "tchortGooSplash";
			int a_9 = 1;
			double maxValue = double.MaxValue;
			bool a_10 = true;
			bool a_11 = true;
			float? a_12 = dz6.b();
			list.Add(new a7j(a_7, a_8, a_9, maxValue, a_10, a_11, null, null, null, a_12, false, null));
		}
		base.vg().q().i.b.b(dtb, atp.a);
		return dc4.c;
	}
}
