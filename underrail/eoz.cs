using System;

// Token: 0x02000BEC RID: 3052
public sealed class eoz : jn
{
	// Token: 0x0600459A RID: 17818 RVA: 0x001C4DD0 File Offset: 0x001C2FD0
	public eoz() : base("fd_marcella", "creature\\characters\\fd_marcella")
	{
	}

	// Token: 0x0600459B RID: 17819 RVA: 0x001C4DE8 File Offset: 0x001C2FE8
	public override string b1(cyt A_0)
	{
		if (A_0.r().GetPrimitivePropertyValue<bool>("npc_fd_trenton_dead", new bool?(false)).Value && A_0.r().GetPrimitivePropertyValue<bool>("quest_fd_revealSpyCompleted", new bool?(false)).Value)
		{
			return "lup_freeDroneBase";
		}
		if (A_0.r().GetPrimitivePropertyValue<bool>("quest_fd_revealSpyCompleted", new bool?(false)).Value)
		{
			A_0.r()["quest_fd_revealSpy_marcellaLeft"] = true;
			return null;
		}
		if (A_0.r().GetPrimitivePropertyValue<bool>("npc_fd_marcella_Found", new bool?(false)).Value)
		{
			return "lup_freeDroneBase";
		}
		return "lux-b11";
	}

	// Token: 0x0600459C RID: 17820 RVA: 0x001C4EAC File Offset: 0x001C30AC
	public override void cf(b0b A_0, cyt A_1, string A_2)
	{
		amc aspect = A_0.GetAspect<amc>();
		if (aspect != null && (aspect.am().StartsWith("mutated_human") || aspect.am().StartsWith("mhun")))
		{
			return;
		}
		if (aspect != null)
		{
			if (string.Equals(A_2, "lup_freeDroneBase", StringComparison.OrdinalIgnoreCase))
			{
				aspect.aa().FactionId = "free_drones";
				aspect.aa().Name = "Марселла";
				A_0.q("Марселла");
			}
			if (string.Equals(A_2, "lux-b11", StringComparison.OrdinalIgnoreCase))
			{
				aspect.aa().FactionId = "HangingRat_Bar";
				aspect.aa().Name = "Посетитель";
				A_0.q("Посетитель");
			}
		}
	}
}
