using System;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02002164 RID: 8548
[dp2("1.1.0.12_ShotgunDamageNerfOptRangeInc", "1.1.0.12")]
public sealed class ees : dnv
{
	// Token: 0x0600C914 RID: 51476 RVA: 0x00470CC4 File Offset: 0x0046EEC4
	public bool eq(bk3 A_0)
	{
		bke bke = A_0 as bke;
		if (bke != null && (bke.ae().GetValueOrDefault() == WeaponSubtype.Shotgun_Regular || bke.ae().GetValueOrDefault() == WeaponSubtype.Shotgun_Combat))
		{
			bke.d(4f);
			for (int i = 0; i < bke.l().Count; i++)
			{
				a1q value = bke.l()[i];
				if (value.DamageType == DamageType.Mechanical)
				{
					value = new a1q(value.DamageType, Convert.ToInt32((double)value.LowerBoundary * 0.9), Convert.ToInt32((double)value.UpperBoundary * 0.9));
					bke.l()[i] = value;
				}
			}
		}
		return true;
	}

	// Token: 0x0600C915 RID: 51477 RVA: 0x00470D90 File Offset: 0x0046EF90
	public bool er(coh A_0)
	{
		return true;
	}
}
