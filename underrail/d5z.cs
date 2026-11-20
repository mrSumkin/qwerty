using System;
using System.Runtime.Serialization;

// Token: 0x020016EA RID: 5866
[eiz("SSA")]
[Serializable]
public sealed class d5z : a6k, ISerializable
{
	// Token: 0x06007F85 RID: 32645 RVA: 0x0036066C File Offset: 0x0035E86C
	private d5z(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007F86 RID: 32646 RVA: 0x00360678 File Offset: 0x0035E878
	public d5z()
	{
	}

	// Token: 0x06007F87 RID: 32647 RVA: 0x00360680 File Offset: 0x0035E880
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		c5x c5x = base.vg().h() as c5x;
		if (c5x != null)
		{
			amc b = c5x.h.b;
			if (b != null)
			{
				if (!b.aa().StatusEffects.a(a7k.a) && !b.aa().StatusEffects.a(dn9.a))
				{
					d02 service = bpo.GetService<d02>();
					if (service != null && service.ahg())
					{
						d4n d4n = service.ahu(b.aa());
						if (d4n != null && d4n == service.ahe())
						{
							d4n.d += (double)bbc.b(base.vg().e());
							if (base.vg().e().b8().Feats.Contains<aaf>())
							{
								d4n.c += (double)aaf.a;
							}
						}
					}
				}
				b.aa().StatusEffects.a(bbc.a(base.vg().e()), false, false, false);
				c5x a_ = c5x;
				string a_2 = "SpeedUp";
				int a_3 = 3;
				double maxValue = double.MaxValue;
				bool a_4 = false;
				bool a_5 = true;
				float? a_6 = dz6.b();
				boj.a(a_, a_2, a_3, maxValue, a_4, a_5, null, null, null, a_6, false);
				c5x.c().a("sprint", "Sprint", 1f, c9z.a, false, false);
				return dc4.c;
			}
		}
		return dc4.e;
	}
}
