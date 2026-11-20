using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001936 RID: 6454
public static class asy
{
	// Token: 0x060088F6 RID: 35062 RVA: 0x00388990 File Offset: 0x00386B90
	public static List<coh> a(efk A_0)
	{
		List<coh> list = new List<coh>();
		if (A_0 != null)
		{
			foreach (coh a_ in A_0.Bag.z2())
			{
				asy.a(list, a_);
			}
			asy.a(list, A_0.Gear.l().Item);
			asy.a(list, A_0.Gear.e().Item);
			asy.a(list, A_0.Gear.f().Item);
			asy.a(list, A_0.Gear.g().Item);
			asy.a(list, A_0.Gear.h().Item);
			asy.a(list, A_0.Gear.j()[WeaponKey.Primary].Item);
			asy.a(list, A_0.Gear.j()[WeaponKey.Secondary].Item);
			foreach (ItemSlot<coh> itemSlot in A_0.Gear.d())
			{
				asy.a(list, itemSlot.Item);
			}
		}
		return list;
	}

	// Token: 0x060088F7 RID: 35063 RVA: 0x00388ADC File Offset: 0x00386CDC
	private static void a(List<coh> A_0, coh A_1)
	{
		if (A_1 != null && A_1.Lootable)
		{
			if (A_1.Definition != null && !A_1.Definition.a9() && A_1.MaxDurability > 0)
			{
				double num = A_1.Durability / (double)A_1.MaxDurability;
				double num2 = dwh.k.a();
				if (num > num2)
				{
					A_1.Durability = num2 * (double)A_1.MaxDurability;
				}
			}
			A_0.Add(A_1);
		}
	}
}
