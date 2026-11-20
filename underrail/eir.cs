using System;
using System.Linq;
using System.Runtime.CompilerServices;
using TimelapseVertigo.Rules.Locale;

// Token: 0x02001164 RID: 4452
public static class eir
{
	// Token: 0x06005F3A RID: 24378 RVA: 0x00286600 File Offset: 0x00284800
	public static ZoneControlLevel d(c1a A_0)
	{
		if (A_0 != null)
		{
			ck1 classPropertyValue = A_0.CustomProperties.GetClassPropertyValue<ck1>("ZoneSecuritySettings");
			if (classPropertyValue != null)
			{
				ZoneControlLevel zoneControlLevel = ZoneControlLevel.Uncontrolled;
				foreach (esz esz in classPropertyValue.a())
				{
					if (esz.ControlLevel > zoneControlLevel)
					{
						zoneControlLevel = esz.ControlLevel;
						if (zoneControlLevel == ZoneControlLevel.Controlled)
						{
							break;
						}
					}
				}
				return zoneControlLevel;
			}
		}
		return ZoneControlLevel.Uncontrolled;
	}

	// Token: 0x06005F3B RID: 24379 RVA: 0x00286694 File Offset: 0x00284894
	public static bool c(c1a A_0)
	{
		return A_0 != null && A_0.CustomProperties.GetPrimitivePropertyValue<bool>("ZoneRecordsCameraFootage", new bool?(false)).Value;
	}

	// Token: 0x06005F3C RID: 24380 RVA: 0x002866C8 File Offset: 0x002848C8
	public static bool b(c1a A_0)
	{
		return A_0 != null && A_0.CustomProperties.GetPrimitivePropertyValue<bool>("LeaveNoWitnesses", new bool?(false)).Value;
	}

	// Token: 0x06005F3D RID: 24381 RVA: 0x002866FC File Offset: 0x002848FC
	public static ZoneControlLevel a(c1a A_0, string A_1)
	{
		eir.a a = new eir.a();
		a.a = A_1;
		if (A_0 != null)
		{
			ck1 classPropertyValue = A_0.CustomProperties.GetClassPropertyValue<ck1>("ZoneSecuritySettings");
			if (classPropertyValue != null)
			{
				esz esz = Enumerable.FirstOrDefault<esz>(Enumerable.Where<esz>(classPropertyValue.a(), new Func<esz, bool>(a.a)));
				if (esz != null)
				{
					return esz.ControlLevel;
				}
			}
		}
		return ZoneControlLevel.Uncontrolled;
	}

	// Token: 0x06005F3E RID: 24382 RVA: 0x00286760 File Offset: 0x00284960
	public static bool a(c1a A_0)
	{
		return A_0 != null && A_0.CustomProperties.GetPrimitivePropertyValue<bool>("SavingDisabled", new bool?(false)).Value;
	}

	// Token: 0x02001165 RID: 4453
	[CompilerGenerated]
	private sealed class a
	{
		// Token: 0x06005F40 RID: 24384 RVA: 0x0028679C File Offset: 0x0028499C
		internal bool a(esz A_0)
		{
			return A_0.FactionId == this.a;
		}

		// Token: 0x040025E1 RID: 9697
		public string a;
	}
}
