using System;
using System.Diagnostics;

// Token: 0x02002099 RID: 8345
[bmq("1.2.0.24_Xpbl_Rig2_RemoveProtectionFromSonarLaptop", "1.2.0.24", "xpbl_rig2", false)]
public sealed class b80 : fg
{
	// Token: 0x0600C7A7 RID: 51111 RVA: 0x00465740 File Offset: 0x00463940
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			if (A_0.r().GetPrimitivePropertyValue<bool>("loc_xpbl_rig_sonarRoom_allowed", new bool?(false)).Value)
			{
				aud aud = A_1.n("xpbl_rig2");
				if (aud != null)
				{
					c5x c5x = new ar7(new Guid("6ac96f70-4c17-41b6-8bef-3dbc46db1cc7"), aud).ao() as c5x;
					if (c5x != null && c5x.GetAspect<c3g>() != null)
					{
						c5x.RemoveAspect<c3g>();
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
