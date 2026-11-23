using System;
using System.Diagnostics;

// Token: 0x020021F3 RID: 8691
[s3("1.0.0.3_MladyThinkAboutJoiningCheck", "1.0.0.3")]
public sealed class d89 : cwo
{
	// Token: 0x0600CA3F RID: 51775 RVA: 0x0047969C File Offset: 0x0047789C
	public bool ee(cyt A_0)
	{
		try
		{
			if (A_0.r().GetPrimitivePropertyValue<bool>("npc_fd_mlady_met", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("npc_fd_mlady_thinkAboutJoining", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("faction_FreeDrones_joined", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("npc_fd_mlady_declineFreeDrones", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("npc_fd_mlady_pissedOff", new bool?(false)).Value)
			{
				A_0.r()["npc_fd_mlady_thinkAboutJoining"] = true;
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
