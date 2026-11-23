using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x020016AA RID: 5802
[eiz("TMERA")]
[Serializable]
public sealed class c0g : a6k, ISerializable
{
	// Token: 0x06007EAE RID: 32430 RVA: 0x003586C8 File Offset: 0x003568C8
	private c0g(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007EAF RID: 32431 RVA: 0x003586D4 File Offset: 0x003568D4
	public c0g()
	{
	}

	// Token: 0x06007EB0 RID: 32432 RVA: 0x003586E0 File Offset: 0x003568E0
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		c5x c5x = base.vg().h() as c5x;
		if (c5x != null)
		{
			c5x a_ = c5x;
			string a_2 = "xphw_Recharge";
			int a_3 = 1;
			double maxValue = double.MaxValue;
			bool a_4 = false;
			bool a_5 = true;
			float? a_6 = dz6.b();
			boj.a(a_, a_2, a_3, maxValue, a_4, a_5, null, null, null, a_6, false);
			c5x.c().a("xphw_Recharge");
			amc b = c5x.h.b;
			if (b != null && b.aa() != null)
			{
				coh coh = base.vg().e().b8().Gear.l().Item;
				if (coh != null)
				{
					if ((int)coh.Battery <= aas.d)
					{
						return dc4.e;
					}
					List<coh> list = b.aa().Gear.i();
					List<coh> list2 = new List<coh>();
					foreach (coh coh2 in list)
					{
						if (coh2 != coh && coh2.Definition != null)
						{
							int? num = coh2.Definition.ba();
							int num2 = 0;
							if (num.GetValueOrDefault() > num2 & num != null)
							{
								double num3 = Math.Ceiling(coh2.Battery);
								num = coh2.Definition.ba();
								double? num4 = (num != null) ? new double?((double)num.GetValueOrDefault()) : null;
								if (num3 < num4.GetValueOrDefault() & num4 != null)
								{
									list2.Add(coh2);
								}
							}
						}
					}
					double num5 = coh.Battery;
					double num6 = 0.0;
					while (list2.Count > 0 && num5 > 0.0)
					{
						double val = num5 / (double)list2.Count * aas.e;
						foreach (coh coh3 in Enumerable.ToList<coh>(list2))
						{
							double num7 = Math.Min((double)coh3.Definition.ba().Value - coh3.Battery, val);
							coh3.Battery = Math.Min((double)coh3.MaxBattery, coh3.Battery + num7);
							double num8 = num7 * (1.0 / aas.e);
							num5 -= num8;
							num6 += num8;
							double num9 = coh3.Battery;
							int? num = coh3.Definition.ba();
							double? num4 = (num != null) ? new double?((double)num.GetValueOrDefault()) : null;
							if (num9 == num4.GetValueOrDefault() & num4 != null)
							{
								list2.Remove(coh3);
							}
						}
					}
					num6 = Math.Max((double)aas.d, num6);
					coh.Battery = Math.Max(0.0, coh.Battery - num6);
				}
				return dc4.c;
			}
		}
		return dc4.e;
	}
}
