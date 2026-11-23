using System;
using System.Diagnostics;

// Token: 0x02002118 RID: 8472
[s3("1.1.3.0_ReduceWrestlingSpecPoints", "1.1.3.0")]
public sealed class dcy : cwo
{
	// Token: 0x0600C87D RID: 51325 RVA: 0x0046AE14 File Offset: 0x00469014
	public bool ee(cyt A_0)
	{
		try
		{
			f f;
			if (A_0.v() != null && A_0.v().Specializations.TryGetValue("WrestlingApplyChance", out f) && f.Value > 5)
			{
				f.Value = 5;
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
