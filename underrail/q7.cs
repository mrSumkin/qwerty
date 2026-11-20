using System;
using System.Diagnostics;

// Token: 0x02002214 RID: 8724
[s3("1.0.0.10_FixRafCounter", "1.0.0.10")]
public sealed class q7 : cwo
{
	// Token: 0x0600CA81 RID: 51841 RVA: 0x0047BD10 File Offset: 0x00479F10
	public bool ee(cyt A_0)
	{
		try
		{
			if (A_0.r().GetPrimitivePropertyValue<bool>("loc_lu_raf_machineInvasionEnded", new bool?(false)).Value && A_0.r().GetPrimitivePropertyValue<int>("loc_lu_raf_machinesKilled", new int?(0)).Value < 25 && !A_0.r().GetPrimitivePropertyValue<bool>("loc_lu_raf_allMachinesKilled", new bool?(false)).Value)
			{
				A_0.r()["loc_lu_raf_machinesKilled"] = 25;
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
