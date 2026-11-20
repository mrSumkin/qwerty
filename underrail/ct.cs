using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x020015E9 RID: 5609
[eiz("SKSSLA")]
[Serializable]
public sealed class ct : a4h, ISerializable
{
	// Token: 0x06007B95 RID: 31637 RVA: 0x0033B260 File Offset: 0x00339460
	private ct(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007B96 RID: 31638 RVA: 0x0033B26C File Offset: 0x0033946C
	public ct()
	{
	}

	// Token: 0x06007B97 RID: 31639 RVA: 0x0033B278 File Offset: 0x00339478
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
		awx.ad().Add(new a4s(new bfq("KnifeWhoosh"), null, new ar7(base.vg().q()), null));
		awx.ad().Add(new e4t(base.vg().q().h.b, a_, dz6.b(cux.m), 0, null, 1));
		base.vg().q().i.b.b(awx, atp.a);
		dtb dtb = new dtb();
		dtb.b(false);
		dtb.c(false);
		dtb.ad().Add(new bm3(dz6.b(cux.m * 4)));
		cmn cmn = new cmn();
		cd1 cd = btf.a();
		euf.a(base.vg().e().b8(), c5x.h.b.aa(), cmn, 1.0, cd);
		efk a_2 = base.vg().e().b8();
		efk a_3 = c5x.h.b.aa();
		cmn a_4 = cmn;
		double a_5 = 0.0;
		cd1 a_6 = cd;
		cwt a_7 = euf.a(a_2, a_3, a_4, a_5, null, 1.0, a_6, true);
		dtb.ad().Add(new a89(base.vg().q().h.b, c5x.h.b, a_7, cd, null));
		base.vg().q().i.b.b(dtb, atp.a);
		return dc4.c;
	}
}
