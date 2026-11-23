using System;
using System.Runtime.Serialization;

// Token: 0x020016B3 RID: 5811
[eiz("AVTA")]
[Serializable]
public sealed class bjb : a6k, ISerializable
{
	// Token: 0x06007EC9 RID: 32457 RVA: 0x00359158 File Offset: 0x00357358
	private bjb(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007ECA RID: 32458 RVA: 0x00359164 File Offset: 0x00357364
	public bjb()
	{
	}

	// Token: 0x06007ECB RID: 32459 RVA: 0x00359170 File Offset: 0x00357370
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		c5x c5x = base.vg().h() as c5x;
		if (c5x != null)
		{
			amc b = c5x.h.b;
			if (b != null && b.aa() != null && b.aa().Vehicle != null && b.aa().Vehicle.g() >= (double)cd8.e)
			{
				b.aa().Vehicle.h((double)cd8.e);
				ckc a_ = new ckc(cd8.d * d0u.b);
				b.aa().StatusEffects.a(a_, false, false, false);
				b.aa().Vehicle.k();
				c5x a_2 = c5x;
				string a_3 = "SpeedUp";
				int a_4 = 3;
				double maxValue = double.MaxValue;
				bool a_5 = false;
				bool a_6 = true;
				float? a_7 = dz6.b();
				boj.a(a_2, a_3, a_4, maxValue, a_5, a_6, null, null, null, a_7, false);
				c5x a_8 = c5x;
				string a_9 = "VehicleSpeedUp";
				int a_10 = 1;
				double maxValue2 = double.MaxValue;
				bool a_11 = true;
				bool a_12 = true;
				a_7 = dz6.b();
				boj.a(a_8, a_9, a_10, maxValue2, a_11, a_12, null, null, null, a_7, false);
				c5x.c().a("sprint", "Sprint", 1f, c9z.a, false, false);
				d02 service = bpo.GetService<d02>();
				if (service != null && service.ahu(b.aa()) == service.ahe())
				{
					service.ahe().d += (double)Convert.ToInt32((double)b.aa().Offense.m() * cd8.c);
				}
				return dc4.c;
			}
		}
		return dc4.e;
	}
}
