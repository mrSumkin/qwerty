using System;
using System.Diagnostics;

// Token: 0x020020E1 RID: 8417
[s3("1.1.5.0_Xpbl_DepotCompletedFlagFix", "1.1.5.0")]
public sealed class sf : cwo
{
	// Token: 0x0600C81B RID: 51227 RVA: 0x0046888C File Offset: 0x00466A8C
	public bool ee(cyt A_0)
	{
		try
		{
			if (A_0.r().GetPrimitivePropertyValue<bool>("event_xpbl_enteringFort_haveImplant", new bool?(false)).Value)
			{
				A_0.r()["quests_xpbl_expedition_investigateDepotCompleted"] = true;
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
