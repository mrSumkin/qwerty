using System;
using System.Diagnostics;

// Token: 0x02002142 RID: 8514
[s3("1.1.2.0_CheckPlayerHouseSecurity", "1.1.2.0")]
public sealed class dlw : cwo
{
	// Token: 0x0600C8C9 RID: 51401 RVA: 0x0046D9D8 File Offset: 0x0046BBD8
	public bool ee(cyt A_0)
	{
		try
		{
			if (A_0.r().GetPrimitivePropertyValue<bool>("loc_coreCity_playerReceivedHouseKeys", new bool?(false)).Value)
			{
				new bt().ym(null, null, null);
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
