using System;
using System.Runtime.Serialization;

// Token: 0x020016B6 RID: 5814
[eiz("AFA")]
[Serializable]
public sealed class q0 : a6k, ISerializable
{
	// Token: 0x06007ED2 RID: 32466 RVA: 0x00359450 File Offset: 0x00357650
	private q0(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007ED3 RID: 32467 RVA: 0x0035945C File Offset: 0x0035765C
	public q0()
	{
	}

	// Token: 0x06007ED4 RID: 32468 RVA: 0x00359464 File Offset: 0x00357664
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		c5x c5x = base.vg().h() as c5x;
		if (c5x != null)
		{
			amc b = c5x.h.b;
			if (b != null)
			{
				br2 microfeat = b.aa().GetMicrofeat<br2>();
				if (microfeat != null && microfeat.a() > 0)
				{
					ip ip = b.aa().Cooldowns.b(d2g.a);
					if (ip != null)
					{
						ip.a -= (double)(microfeat.a() * d0u.b);
						if (ip.a < 0.0)
						{
							b.aa().Cooldowns.a(d2g.a);
						}
					}
				}
				int num = euf.a(b.aa(), 1.0 + b84.a(base.vg().e()));
				if (num > 0)
				{
					cl8.a(b.aa(), num);
					b.a8().c().a("xpbl_Fend");
					c5x a_ = c5x;
					string a_2 = "Fend";
					int a_3 = 1;
					double maxValue = double.MaxValue;
					bool a_4 = true;
					bool a_5 = true;
					float? a_6 = dz6.b();
					boj.a(a_, a_2, a_3, maxValue, a_4, a_5, null, null, null, a_6, false);
					return dc4.c;
				}
			}
		}
		return dc4.e;
	}
}
