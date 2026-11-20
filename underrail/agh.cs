using System;
using System.Diagnostics;

// Token: 0x020020EE RID: 8430
[s3("1.1.5.10_AzifEtherealTorchFlagFix", "1.1.5.10")]
public sealed class agh : cwo
{
	// Token: 0x0600C832 RID: 51250 RVA: 0x004690EC File Offset: 0x004672EC
	public bool ee(cyt A_0)
	{
		try
		{
			bpo.GetServiceOrThrow<cnk>();
			if (A_0.r().GetPrimitivePropertyValue<bool>("npc_azif_shard_decodedItWithYou", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("npc_azif_activatedEtherealTorch", new bool?(false)).Value)
			{
				A_0.r()["npc_azif_activatedEtherealTorch"] = true;
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
