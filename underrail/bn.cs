using System;
using TimelapseVertigo.Generators.Items;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Items;

// Token: 0x0200100F RID: 4111
public static class bn
{
	// Token: 0x060054D3 RID: 21715 RVA: 0x00257C24 File Offset: 0x00255E24
	public static bool a(efk A_0, coh A_1, AutoEquipMode A_2, ref int A_3)
	{
		if (A_2 != AutoEquipMode.None)
		{
			if (A_1 is k7)
			{
				if (A_2 != AutoEquipMode.FreeSlot || A_0.Gear.g().Item == null)
				{
					bn.SwapIn<k7>(A_0.Gear.g(), A_0.Bag, A_1 as k7);
					return true;
				}
			}
			else if (A_1 is cgd)
			{
				if (A_2 != AutoEquipMode.FreeSlot || A_0.Gear.h().Item == null)
				{
					bn.SwapIn<cgd>(A_0.Gear.h(), A_0.Bag, A_1 as cgd);
					return true;
				}
			}
			else if (A_1 is c8d)
			{
				if (A_2 != AutoEquipMode.FreeSlot || A_0.Gear.l().Item == null)
				{
					bn.SwapIn<c8d>(A_0.Gear.l(), A_0.Bag, A_1 as c8d);
					return true;
				}
			}
			else if (A_1 is cjh)
			{
				if (A_2 != AutoEquipMode.FreeSlot || A_0.Gear.e().Item == null)
				{
					bn.SwapIn<cjh>(A_0.Gear.e(), A_0.Bag, A_1 as cjh);
					return true;
				}
			}
			else if (A_1 is a12)
			{
				if (A_2 != AutoEquipMode.FreeSlot || A_0.Gear.f().Item == null)
				{
					bn.SwapIn<a12>(A_0.Gear.f(), A_0.Bag, A_1 as a12);
					return true;
				}
			}
			else if (A_1 is cd1)
			{
				if (A_2 == AutoEquipMode.Primary)
				{
					bn.SwapIn<cd1>(A_0.Gear.j()[WeaponKey.Primary], A_0.Bag, A_1 as cd1);
					return true;
				}
				if (A_2 == AutoEquipMode.Secondary)
				{
					bn.SwapIn<cd1>(A_0.Gear.j()[WeaponKey.Secondary], A_0.Bag, A_1 as cd1);
					return true;
				}
				if (A_0.Gear.j()[WeaponKey.Primary].Item == null)
				{
					bn.SwapIn<cd1>(A_0.Gear.j()[WeaponKey.Primary], A_0.Bag, A_1 as cd1);
					return true;
				}
				if (A_0.Gear.j()[WeaponKey.Secondary].Item == null)
				{
					bn.SwapIn<cd1>(A_0.Gear.j()[WeaponKey.Secondary], A_0.Bag, A_1 as cd1);
					return true;
				}
			}
			else if (A_1 is acz || (A_1.Definition != null && A_1.Definition.v))
			{
				int? num = bn.a(A_0);
				if (num != null)
				{
					bn.SwapIn<coh>(A_0.Gear.d()[num.Value], A_0.Bag, A_1);
				}
				else
				{
					bn.SwapIn<coh>(A_0.Gear.d()[A_3], A_0.Bag, A_1);
					int num2 = A_3 + 1;
					A_3 = num2;
					if (num2 >= A_0.AvailableQuickSlots)
					{
						A_3 = 0;
					}
				}
				return true;
			}
		}
		return false;
	}

	// Token: 0x060054D4 RID: 21716 RVA: 0x00257F08 File Offset: 0x00256108
	public static int? a(efk A_0)
	{
		int num = 0;
		while (num < A_0.AvailableQuickSlots && num < aiy.ay)
		{
			if (A_0.Gear.d()[num].Enabled && A_0.Gear.d()[num].Item == null)
			{
				return new int?(num);
			}
			num++;
		}
		return null;
	}

	// Token: 0x060054D5 RID: 21717 RVA: 0x00257F7C File Offset: 0x0025617C
	public static void SwapIn<T>(ItemSlot<T> slot, dbi bag, T item) where T : coh
	{
		if (slot.Item != null)
		{
			bag.z3(slot.Item, true);
		}
		slot.a(item, true);
	}
}
