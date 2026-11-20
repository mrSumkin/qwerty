using System;
using System.Diagnostics;

// Token: 0x0200216A RID: 8554
[s3("1.0.4.7_SetAegisFactionRelationsAfterLeavingCC", "1.0.4.7")]
public sealed class dcn : cwo
{
	// Token: 0x0600C923 RID: 51491 RVA: 0x004710BC File Offset: 0x0046F2BC
	public bool ee(cyt A_0)
	{
		try
		{
			if (A_0.r().GetPrimitivePropertyValue<bool>("npc_xpbl_briggs_arrivedAtDock", new bool?(false)).Value)
			{
				new a1b().ym(null, null, null);
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
