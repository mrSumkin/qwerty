using System;
using System.Diagnostics;

// Token: 0x020020E4 RID: 8420
[s3("1.1.5.9_AcidHuntersQuestRepeatingFix", "1.1.5.9")]
public sealed class db6 : cwo
{
	// Token: 0x0600C821 RID: 51233 RVA: 0x00468B18 File Offset: 0x00466D18
	public bool ee(cyt A_0)
	{
		try
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (A_0.r().GetPrimitivePropertyValue<bool>("cc_acidHunters_finished", new bool?(false)).Value)
			{
				string text = null;
				if (A_0.r().GetPrimitivePropertyValue<bool>("faction_Preatorian_joined", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("cc_ps_acidHunters_started", new bool?(false)).Value)
				{
					A_0.r()["cc_ps_acidHunters_started"] = true;
					text = "cc_ps_acidHunters";
				}
				if (A_0.r().GetPrimitivePropertyValue<bool>("faction_JKK_joined", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("cc_jkk_acidHunters_started", new bool?(false)).Value)
				{
					A_0.r()["cc_jkk_acidHunters_started"] = true;
					text = "cc_jkk_acidHunters";
				}
				if (A_0.r().GetPrimitivePropertyValue<bool>("faction_Coretech_joined", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("cc_ct_acidHunters_started", new bool?(false)).Value)
				{
					A_0.r()["cc_ct_acidHunters_started"] = true;
					text = "cc_ct_acidHunters";
				}
				if (!string.IsNullOrEmpty(text))
				{
					serviceOrThrow.aqz().atb(text, false);
					serviceOrThrow.aqz().atc(text, false);
				}
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
