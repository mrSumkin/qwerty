using System;
using System.Diagnostics;

// Token: 0x02002166 RID: 8550
[s3("1.1.0.11_SetPesticideGrenadesFoundAtHCProperty", "1.1.0.11")]
public sealed class ewx : cwo
{
	// Token: 0x0600C919 RID: 51481 RVA: 0x00470E54 File Offset: 0x0046F054
	public bool ee(cyt A_0)
	{
		try
		{
			if (!A_0.r().GetPrimitivePropertyValue<bool>("loc_xpbl_hc_foundPesticideGrenades", new bool?(false)).Value)
			{
				bfc bfc = bpo.GetServiceOrThrow<cnk>().ar0("xpbl_hc4", A_0);
				if (bfc != null)
				{
					alg alg = A_0.a(bfc.Id, true);
					if (alg != null && alg.a)
					{
						A_0.r()["loc_xpbl_hc_foundPesticideGrenades"] = true;
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
