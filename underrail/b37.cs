using System;
using System.Diagnostics;

// Token: 0x020021BC RID: 8636
[bmq("1.0.1.11_Fo_PrisonProtection", "1.0.1.11", "fo_prison", false)]
public sealed class b37 : fg
{
	// Token: 0x0600C9CF RID: 51663 RVA: 0x00476B1C File Offset: 0x00474D1C
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("39ded9ac-82a2-43a9-be80-19586335f6bb"), A_1.n("fo_prison")).ao() as c5x;
			if (c5x != null && A_0.r().GetPrimitivePropertyValue<bool>("loc_fo_prison_securityRoomPass", new bool?(false)).Value && c5x.GetAspect<c3g>() != null)
			{
				c5x.RemoveAspect<c3g>();
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
