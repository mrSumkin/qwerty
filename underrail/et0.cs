using System;
using System.Runtime.Serialization;

// Token: 0x020016BA RID: 5818
[eiz("SBA0")]
[Serializable]
public sealed class et0 : a6k, ISerializable
{
	// Token: 0x06007EDE RID: 32478 RVA: 0x00359C3C File Offset: 0x00357E3C
	private et0(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007EDF RID: 32479 RVA: 0x00359C48 File Offset: 0x00357E48
	public et0()
	{
	}

	// Token: 0x06007EE0 RID: 32480 RVA: 0x00359C54 File Offset: 0x00357E54
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
		cd1 cd = a5p.c(base.vg().e());
		cmn cmn = awq.b(base.vg().q().h.b, c5x.h.b, cd);
		efk a_ = base.vg().e().b8();
		efk a_2 = c5x.h.b.aa();
		cmn a_3 = cmn;
		double a_4 = 0.0;
		cd1 a_5 = cd;
		cwt cwt = euf.a(a_, a_2, a_3, a_4, null, 1.0, a_5, false);
		cwt.k = "Удар щитом";
		awq.a(base.vg().q().h.b, c5x.h.b, cwt, cd, null);
		if (cwt.b)
		{
			c5x a_6 = c5x;
			string a_7 = "SuperSlamHit";
			int a_8 = 1;
			double maxValue = double.MaxValue;
			bool a_9 = true;
			bool a_10 = true;
			float? a_11 = dz6.b();
			boj.a(a_6, a_7, a_8, maxValue, a_9, a_10, null, null, null, a_11, false);
		}
		return dc4.c;
	}
}
