using System;
using System.Diagnostics;

// Token: 0x02002124 RID: 8484
[s3("1.1.2.4_CompleteQuintonsBeastQuest", "1.1.2.4")]
public sealed class ahm : cwo
{
	// Token: 0x0600C894 RID: 51348 RVA: 0x0046BD74 File Offset: 0x00469F74
	public bool ee(cyt A_0)
	{
		try
		{
			if (A_0.r().GetPrimitivePropertyValue<bool>("quest_sgs_dun_investigateUnderPassages_harlandToldSituation", new bool?(false)).Value)
			{
				bpo.GetServiceOrThrow<cnk>().aqz().atc("dun_lup-a_lucasSent", true);
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
