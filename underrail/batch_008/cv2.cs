using System;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02002115 RID: 8469
[dp2("1.1.3.0_SteelWeaponsChange", "1.1.3.0")]
public sealed class cv2 : dnv
{
	// Token: 0x0600C874 RID: 51316 RVA: 0x0046AAF4 File Offset: 0x00468CF4
	public bool eq(bk3 A_0)
	{
		bke bke = A_0 as bke;
		if (bke != null && !string.IsNullOrEmpty(bke.az()) && bke.e() == btz.g && bke.ae() != null)
		{
			if (bke.ae().GetValueOrDefault() == WeaponSubtype.Sledgehammer)
			{
				if (bke.az().Contains("верхстал"))
				{
					bke bke2 = bke;
					bke2.f(bke2.ai() + 0.02);
					bke bke3 = bke;
					bke3.a(bke3.v() - 2);
				}
				else if (bke.az().Contains("ольфрамо"))
				{
					bke bke4 = bke;
					bke4.f(bke4.ai() - 0.01);
				}
			}
			else if (bke.ae().GetValueOrDefault() == WeaponSubtype.Spear)
			{
				if (bke.az().Contains("верхстал"))
				{
					bke bke5 = bke;
					bke5.g(bke5.ab() + 0.03);
				}
			}
			else if (bke.ae().GetValueOrDefault() == WeaponSubtype.Machete_Curved || bke.ae().GetValueOrDefault() == WeaponSubtype.Machete_Straight)
			{
				if (bke.az().Contains("верхстал"))
				{
					bke bke6 = bke;
					bke6.g(bke6.ab() + 0.03);
					bke bke7 = bke;
					bke7.a(bke7.v() - 1);
				}
			}
			else if (euf.a(bke.ae().Value) && bke.az().Contains("верхстал"))
			{
				bke bke8 = bke;
				bke8.g(bke8.ab() + 0.05);
			}
		}
		return true;
	}

	// Token: 0x0600C875 RID: 51317 RVA: 0x0046ACBC File Offset: 0x00468EBC
	public bool er(coh A_0)
	{
		return true;
	}
}
