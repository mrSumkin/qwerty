using System;
using System.Collections.Generic;

// Token: 0x0200209A RID: 8346
[dp2("1.2.0.22_CraftedCrossbowScopeFix", "1.2.0.22")]
public sealed class an1 : dnv
{
	// Token: 0x0600C7A9 RID: 51113 RVA: 0x004657E8 File Offset: 0x004639E8
	public bool eq(bk3 A_0)
	{
		bke bke = A_0 as bke;
		if (bke != null && bke.e() == btz.f)
		{
			List<coh> classPropertyValue = bke.a7().GetClassPropertyValue<List<coh>>("Components");
			if (classPropertyValue != null)
			{
				for (int i = 0; i < classPropertyValue.Count; i++)
				{
					fv fv = classPropertyValue[i] as fv;
					if (fv != null && fv.TypedDefinition != null && fv.TypedDefinition.i() == ms.q)
					{
						if (fv.TypedDefinition.a5() == "anatomicallyAwareScope")
						{
							string[] array = bke.a0().Split(new char[]
							{
								'.'
							}, StringSplitOptions.RemoveEmptyEntries);
							bke.i("");
							for (int j = 0; j < array.Length - 1; j++)
							{
								bke bke2 = bke;
								bke2.i(bke2.a0() + array[j] + ".");
							}
							bke bke3 = bke;
							bke3.i(bke3.a0() + " Прицел со встроенным компьютером способен распознавать анатомию млекопитающих и насекомых.");
							bke.f(bke.a3().Substring(0, bke.a3().Length - 1) + "d");
						}
						else if (fv.TypedDefinition.a5() == "highResolutionDigitalScope")
						{
							string[] array2 = bke.a0().Split(new char[]
							{
								'.'
							}, StringSplitOptions.RemoveEmptyEntries);
							bke.i("");
							for (int k = 0; k < array2.Length - 1; k++)
							{
								bke bke4 = bke;
								bke4.i(bke4.a0() + array2[k] + ".");
							}
							bke bke5 = bke;
							bke5.i(bke5.a0() + " Цифровой прицел облегчает точность стрельбы, благодаря захвату цели.");
							bke.f(bke.a3().Substring(0, bke.a3().Length - 1) + "f");
						}
						return true;
					}
				}
			}
		}
		return true;
	}

	// Token: 0x0600C7AA RID: 51114 RVA: 0x004659DC File Offset: 0x00463BDC
	public bool er(coh A_0)
	{
		return true;
	}
}
