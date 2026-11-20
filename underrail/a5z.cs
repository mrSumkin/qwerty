using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001836 RID: 6198
[eiz("XDAA")]
[Serializable]
public sealed class a5z : a6k, ISerializable
{
	// Token: 0x06008427 RID: 33831 RVA: 0x00370FC4 File Offset: 0x0036F1C4
	private a5z(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008428 RID: 33832 RVA: 0x00370FD0 File Offset: 0x0036F1D0
	public a5z()
	{
	}

	// Token: 0x06008429 RID: 33833 RVA: 0x00370FDC File Offset: 0x0036F1DC
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (base.vg().q() == null || base.vg().q().h == null || base.vg().q().h.b == null)
		{
			return dc4.e;
		}
		c5x c5x = base.vg().h() as c5x;
		if (c5x == null || c5x.h == null || c5x.h.b == null)
		{
			return dc4.e;
		}
		c8d c8d = base.vg().q().h.b.aa().Gear.l().Item;
		if (c8d == null || c8d.Battery < (double)eoy.a)
		{
			return dc4.e;
		}
		cd1 cd = new cd1(new IndependentItemDefinitionProvider<bke>(eoy.a(base.vg().e())));
		cmn cmn = awq.b(base.vg().q().h.b, c5x.h.b, null);
		cmn.a = c3u.a;
		efk a_ = base.vg().e().b8();
		efk a_2 = c5x.h.b.aa();
		cmn a_3 = cmn;
		double a_4 = 0.0;
		cd1 a_5 = cd;
		cwt a_6 = euf.a(a_, a_2, a_3, a_4, null, 1.0, a_5, false);
		c8d.a((double)eoy.a, true);
		agd.a(base.vg().q());
		awq.a(base.vg().q().h.b, c5x.h.b, a_6, cd, null);
		return dc4.c;
	}
}
