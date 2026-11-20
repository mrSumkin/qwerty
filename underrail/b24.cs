using System;
using System.Diagnostics;

// Token: 0x02002167 RID: 8551
[s3("1.1.0.11_SavedProfessorButStillPirateFix", "1.1.0.11")]
public sealed class b24 : cwo
{
	// Token: 0x0600C91B RID: 51483 RVA: 0x00470F04 File Offset: 0x0046F104
	public bool ee(cyt A_0)
	{
		try
		{
			if (A_0.r().GetPrimitivePropertyValue<bool>("loc_xpbl_e3_attackedPiratesDuringInterrogation", new bool?(false)).Value && A_0.r().GetPrimitivePropertyValue<bool>("global_xpbl_pirates_joined", new bool?(false)).Value)
			{
				A_0.r()["global_xpbl_pirates_joined"] = false;
				A_0.r()["faction_xpbl_expedition_cutCommunication"] = false;
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
