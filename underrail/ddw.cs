using System;
using System.Runtime.Serialization;

// Token: 0x020016D4 RID: 5844
[eiz("Y1")]
[Serializable]
public sealed class ddw : a6k, ISerializable
{
	// Token: 0x06007F35 RID: 32565 RVA: 0x0035D760 File Offset: 0x0035B960
	private ddw(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007F36 RID: 32566 RVA: 0x0035D76C File Offset: 0x0035B96C
	public ddw()
	{
	}

	// Token: 0x06007F37 RID: 32567 RVA: 0x0035D778 File Offset: 0x0035B978
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		c5x c5x = base.vg().h() as c5x;
		if (c5x != null)
		{
			amc b = c5x.h.b;
			if (b != null)
			{
				if (b.aa().Defense.q().zo() < b.aa().Defense.q().zm())
				{
					b.aa().Defense.a((int)b.aa().Defense.q().zm(), null, "Последний рубеж", true, true, false, null);
					c5x a_ = c5x;
					string a_2 = "Heal";
					int a_3 = 3;
					double maxValue = double.MaxValue;
					bool a_4 = true;
					bool a_5 = true;
					float? a_6 = dz6.b();
					boj.a(a_, a_2, a_3, maxValue, a_4, a_5, null, null, null, a_6, false);
				}
				bfz a_7 = new bfz(hy.a(base.vg().e()));
				b.aa().StatusEffects.a(a_7, false, false, false);
				return dc4.c;
			}
		}
		return dc4.e;
	}
}
