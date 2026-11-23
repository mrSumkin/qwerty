using System;
using System.Diagnostics;

// Token: 0x02002135 RID: 8501
[bmq("1.1.2.0_Global_MiningHelmets", "1.1.2.0", "*", false)]
public sealed class aat : fg
{
	// Token: 0x0600C8B3 RID: 51379 RVA: 0x0046D1FC File Offset: 0x0046B3FC
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			foreach (aud aud in A_1.Areas)
			{
				foreach (b0b b0b in aud.Entities)
				{
					c5x c5x = (c5x)b0b;
					amc aspect = c5x.GetAspect<amc>();
					dqv aspect2 = c5x.GetAspect<dqv>();
					if (aspect != null && aspect2 == null && aspect.am().StartsWith("wrkmn") && aspect.aa().Gear.g().Item == null)
					{
						k7 k = new k7(ez2.CreateDefinitonProvider<bqu>("armor\\miningHelmet"));
						if (k != null)
						{
							k.Battery = (double)k.MaxBattery;
							aspect.aa().Gear.g().a(k, true);
						}
					}
				}
			}
			return true;
		}
		catch (Exception ex)
		{
			Trace.WriteLine(ex.ToString());
		}
		return false;
	}
}
