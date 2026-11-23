using System;
using System.Diagnostics;

// Token: 0x020020E9 RID: 8425
[s3("1.1.5.12_ExpeditionStartQuestFailureFix", "1.1.5.12")]
public sealed class d56 : cwo
{
	// Token: 0x0600C82A RID: 51242 RVA: 0x00468E1C File Offset: 0x0046701C
	public bool ee(cyt A_0)
	{
		try
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (A_0.r().GetPrimitivePropertyValue<bool>("playerEnteredBlackSea", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("expeditionReturnsWithPlayer", new bool?(false)).Value)
			{
				serviceOrThrow.aqz().atd("xpbl_heardDockExpedition", true);
				serviceOrThrow.aqz().atd("xpbl_knowDockExpedition", true);
				serviceOrThrow.aqz().atd("xpbl_talkWithBriggs", true);
				serviceOrThrow.aqz().atd("xpbl_proveYourWorthToBriggs", true);
				serviceOrThrow.aqz().atd("xpbl_joinExpedition", true);
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
