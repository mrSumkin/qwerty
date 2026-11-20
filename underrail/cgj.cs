using System;

// Token: 0x020007D1 RID: 2001
public sealed class cgj : cm9
{
	// Token: 0x06003227 RID: 12839 RVA: 0x00134C7C File Offset: 0x00132E7C
	public double ot()
	{
		return 1000.0;
	}

	// Token: 0x06003228 RID: 12840 RVA: 0x00134C8C File Offset: 0x00132E8C
	public void ou(cnk A_0)
	{
		if (dk2.f() && A_0.aqu() != null)
		{
			TimeSpan? primitivePropertyValue = A_0.aqu().r().GetPrimitivePropertyValue<TimeSpan>("LemurianSavageInvasionRestrictedUntil", null);
			if ((primitivePropertyValue == null || A_0.aqu().o() > primitivePropertyValue.Value) && !A_0.aqu().r().GetPrimitivePropertyValue<bool>("loc_xpbl_camp_underAttack", new bool?(false)).Value && A_0.aqu().e(doc.a).Count == 0)
			{
				int value = A_0.aqu().r().GetPrimitivePropertyValue<int>("LemurianSavageAttacksEnabled", new int?(0)).Value;
				if (value > 0)
				{
					int num = A_0.aqu().r().GetPrimitivePropertyValue<int>("LemurianSavageAttacksCreated", new int?(0)).Value;
					if (value > num)
					{
						num++;
						doc a_ = new doc(num);
						A_0.aqu().b(a_);
						A_0.aqu().r()["LemurianSavageAttacksCreated"] = num;
					}
				}
			}
		}
	}
}
