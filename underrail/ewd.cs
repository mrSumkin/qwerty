using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x020015E5 RID: 5605
[eiz("SKABLSA")]
[Serializable]
public sealed class ewd : a4h, ISerializable
{
	// Token: 0x06007B89 RID: 31625 RVA: 0x0033AA70 File Offset: 0x00338C70
	private ewd(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007B8A RID: 31626 RVA: 0x0033AA7C File Offset: 0x00338C7C
	public ewd()
	{
	}

	// Token: 0x06007B8B RID: 31627 RVA: 0x0033AA84 File Offset: 0x00338C84
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
		awx.ad().Add(new a4s(new bfq("AcidBlob"), null, new ar7(base.vg().q()), null));
		awx.ad().Add(new e4t(base.vg().q().h.b, a_, dz6.b(cux.m), 0, null, 1));
		base.vg().q().i.b.b(awx, atp.a);
		dtb dtb = new dtb();
		dtb.b(false);
		dtb.c(false);
		dtb.ad().Add(new bm3(dz6.b(cux.m * 4)));
		cmn cmn = new cmn();
		cd1 cd = dhh.a();
		euf.a(base.vg().e().b8(), c5x.h.b.aa(), cmn, 1.0, cd);
		efk a_2 = base.vg().e().b8();
		efk a_3 = c5x.h.b.aa();
		cmn a_4 = cmn;
		double a_5 = 0.0;
		cd1 a_6 = cd;
		cwt a_7 = euf.a(a_2, a_3, a_4, a_5, null, 1.0, a_6, true);
		dtb.ad().Add(new cdp(base.vg().q().h.b, c5x.h.b, a_7, cd));
		base.vg().q().i.b.b(dtb, atp.a);
		return dc4.c;
	}
}
