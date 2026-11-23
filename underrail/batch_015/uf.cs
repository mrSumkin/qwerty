using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001E55 RID: 7765
public static class uf
{
	// Token: 0x0600AC22 RID: 44066 RVA: 0x003F9018 File Offset: 0x003F7218
	static uf()
	{
		uf.a[CooldownCategory.None] = "nothing";
		uf.a[CooldownCategory.Sprint] = "Sprint";
		uf.a[CooldownCategory.EvasiveManeuvers] = "Evasive Maneuvers";
		uf.a[CooldownCategory.Stealth] = "Stealth";
		uf.a[CooldownCategory.DirtyKick] = "Dirty Kick";
		uf.a[CooldownCategory.TrapArming] = "arming traps";
		uf.a[CooldownCategory.Bilocation] = "Bilocation";
		uf.a[CooldownCategory.PseudoSpatialProjection] = "Pseudo-spatial Projection";
	}

	// Token: 0x0600AC23 RID: 44067 RVA: 0x003F90B8 File Offset: 0x003F72B8
	public static int a(int A_0, cnm A_1, params CooldownCategory[] A_2)
	{
		int num = A_0;
		if (A_1 != null && A_1.b8() != null && A_2 != null)
		{
			foreach (CooldownCategory key in A_2)
			{
				num = Math.Max(0, (int)((double)num * A_1.b8().CooldownModifiersPercentage[key]));
			}
			foreach (CooldownCategory key2 in A_2)
			{
				num = Math.Max(0, num + A_1.b8().CooldownModifiersFlat[key2] * d0u.b);
			}
		}
		else
		{
			num = A_0;
		}
		return num;
	}

	// Token: 0x04004017 RID: 16407
	public static readonly Dictionary<CooldownCategory, string> a = new Dictionary<CooldownCategory, string>();
}
