using System;
using System.Diagnostics;

// Token: 0x020020A4 RID: 8356
[s3("1.2.0.16_MlanRatulaFactionRelationFix", "1.2.0.16")]
public sealed class af0 : cwo
{
	// Token: 0x0600C7BB RID: 51131 RVA: 0x00465F48 File Offset: 0x00464148
	public bool ee(cyt A_0)
	{
		try
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (A_0.r().GetPrimitivePropertyValue<bool>("fls_allowedRatkingToStay", new bool?(false)).Value)
			{
				bv9 bv = A_0.ac() as bv9;
				cky cky = serviceOrThrow.aqu().ac().abu(asp.a4, asp.a);
				if (cky != null && cky.a == h.b)
				{
					bv.a(asp.a, asp.a4, h.d, null, true, false, false);
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
