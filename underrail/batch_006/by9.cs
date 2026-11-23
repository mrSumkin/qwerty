using System;
using System.Diagnostics;

// Token: 0x020021FB RID: 8699
[s3("1.0.0.2_GorskyPersuadeNotAdvancingQuestLine", "1.0.0.2")]
public sealed class by9 : cwo
{
	// Token: 0x0600CA4F RID: 51791 RVA: 0x00479E20 File Offset: 0x00478020
	public bool ee(cyt A_0)
	{
		try
		{
			if (A_0.r().GetPrimitivePropertyValue<bool>("talkToBretForRoundupStart", new bool?(false)).Value && A_0.r().GetPrimitivePropertyValue<int>("quest_theVault_state", new int?(0)).Value >= 2 && !A_0.r().GetPrimitivePropertyValue<bool>("gorsky_GMS_Completed", new bool?(false)).Value)
			{
				A_0.r()["gorsky_GMS_Completed"] = true;
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
