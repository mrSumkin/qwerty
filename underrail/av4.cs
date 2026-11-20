using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

// Token: 0x02002105 RID: 8453
[bmq("1.1.3.0_Xpbl_F1_FixKatyasPositionAfterCaveEncounter", "1.1.3.0", "xpbl_f1", false)]
public sealed class av4 : fg
{
	// Token: 0x0600C859 RID: 51289 RVA: 0x0046A210 File Offset: 0x00468410
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			if (!A_0.r().GetPrimitivePropertyValue<bool>("npc_xpbl_pir_katya_died", new bool?(false)).Value && A_0.r().GetPrimitivePropertyValue<bool>("npc_xpbl_pir_katya_talkedInCave", new bool?(false)).Value && A_0.r().GetPrimitivePropertyValue<bool>("npc_xpbl_pir_katya_returnedFromCave", new bool?(false)).Value)
			{
				c5x c5x = new ar7(new Guid("5c4e9e80-fa71-4977-82bc-93ca150844ee"), A_1.n("xpbl_f1_cave")).ao() as c5x;
				if (c5x != null && c5x.t.b != null)
				{
					List<string> classPropertyValue = c5x.t.b.y6().GetClassPropertyValue<List<string>>(ddq.k);
					if (classPropertyValue != null && !Enumerable.Any<string>(classPropertyValue))
					{
						c5x.t.b.y6().RemoveProperty(ddq.k);
						a0l.a(c5x, "katya_home", true);
						c5x.t.b.y6()[ddq.ay] = new bt4("katya_home");
					}
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
