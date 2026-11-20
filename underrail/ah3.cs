using System;
using System.Diagnostics;

// Token: 0x020020E5 RID: 8421
[s3("1.1.5.9_QueueForgerDelayedEvents", "1.1.5.9")]
public sealed class ah3 : cwo
{
	// Token: 0x0600C823 RID: 51235 RVA: 0x00468CDC File Offset: 0x00466EDC
	public bool ee(cyt A_0)
	{
		try
		{
			if (A_0.r().GetPrimitivePropertyValue<bool>("quest_cc_forgerTicketTesting_ended", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("npc_forger_noTickets", new bool?(false)).Value)
			{
				d6r d6r = new d6r();
				d6r.a(new dpq());
				d6r.ym(null, null, null);
			}
			if (A_0.r().GetPrimitivePropertyValue<bool>("npc_forger_cacsGiven", new bool?(false)).Value)
			{
				d6r d6r2 = new d6r();
				d6r2.a(new a6r());
				d6r2.ym(null, null, null);
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
