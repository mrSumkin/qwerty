using System;
using System.Diagnostics;

// Token: 0x020021EC RID: 8684
[s3("1.0.0.8_MladyJoinedFreeDronesAlreadySet", "1.0.0.8")]
public sealed class gj : cwo
{
	// Token: 0x0600CA31 RID: 51761 RVA: 0x0047917C File Offset: 0x0047737C
	public bool ee(cyt A_0)
	{
		try
		{
			if (A_0.r().GetPrimitivePropertyValue<bool>("faction_FreeDrones_joined", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("quest_fd_KillEnvoyStarted", new bool?(false)).Value)
			{
				A_0.r()["faction_FreeDrones_joined"] = false;
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
