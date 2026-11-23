using System;
using System.Diagnostics;

// Token: 0x0200211A RID: 8474
[s3("1.1.3.0_CompleteQuintonsBeastQuest", "1.1.3.0")]
public sealed class er3 : cwo
{
	// Token: 0x0600C882 RID: 51330 RVA: 0x0046B17C File Offset: 0x0046937C
	public bool ee(cyt A_0)
	{
		try
		{
			if (A_0.r().GetPrimitivePropertyValue<bool>("loc_lup_freeDroneBase_gasStarted", new bool?(false)).Value && A_0.r().GetPrimitivePropertyValue<bool>("quest_pr_gasFreeDronesComplete", new bool?(false)).Value)
			{
				A_0.r()["loc_lup_freeDroneBase_gasStopped"] = true;
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
