using System;
using System.Diagnostics;

// Token: 0x020020AA RID: 8362
[bmq("1.2.0.13_Xphw_Up_MusicFix", "1.2.0.13", "xphw_up", false)]
public sealed class bh4 : fg
{
	// Token: 0x0600C7C6 RID: 51142 RVA: 0x00466354 File Offset: 0x00464554
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			if (A_0.r().GetPrimitivePropertyValue<bool>("quest_xphw_tripToNorthUnderrail_started", new bool?(false)).Value)
			{
				dvn dvn = new dvn("xphw_up", "UpperUnderrail");
				dvn.a(null);
				dvn.ym(null, null, null);
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
