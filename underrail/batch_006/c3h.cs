using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x0200140E RID: 5134
[eiz("WLCATA")]
[bs6("WirelessChargingAuraTickAction")]
[Serializable]
public sealed class c3h : bhv, ISerializable
{
	// Token: 0x06007349 RID: 29513 RVA: 0x00309748 File Offset: 0x00307948
	private c3h(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600734A RID: 29514 RVA: 0x00309754 File Offset: 0x00307954
	public c3h()
	{
	}

	// Token: 0x0600734B RID: 29515 RVA: 0x00309760 File Offset: 0x00307960
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (base.x0().a() != null && base.x2() != null && base.x2().a8() != null)
		{
			coh coh = base.x2().aa().Gear.l().Item;
			if (coh != null)
			{
				if ((int)coh.Battery <= 0)
				{
					return dc4.e;
				}
				List<coh> list = base.x0().a().Gear.i();
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
				double num5 = Math.Min(agj.e, coh.Battery);
				while (list2.Count > 0 && num5 > 0.0)
				{
					double val = num5 / (double)list2.Count * agj.f;
					foreach (coh coh3 in Enumerable.ToList<coh>(list2))
					{
						double num6 = Math.Min((double)coh3.Definition.ba().Value - coh3.Battery, val);
						coh3.Battery = Math.Min((double)coh3.MaxBattery, coh3.Battery + num6);
						double num7 = num6 * (1.0 / agj.f);
						num5 -= num7;
						coh.Battery = Math.Max(0.0, coh.Battery - num7);
						double num8 = coh3.Battery;
						int? num = coh3.Definition.ba();
						double? num4 = (num != null) ? new double?((double)num.GetValueOrDefault()) : null;
						if (num8 == num4.GetValueOrDefault() & num4 != null)
						{
							list2.Remove(coh3);
						}
					}
				}
			}
		}
		return dc4.c;
	}
}
