using System;
using System.Diagnostics;

// Token: 0x020020E0 RID: 8416
[s3("1.1.5.0_ForgerHandleEnding", "1.1.5.0")]
public sealed class ctk : cwo
{
	// Token: 0x0600C819 RID: 51225 RVA: 0x0046881C File Offset: 0x00466A1C
	public bool ee(cyt A_0)
	{
		try
		{
			if (A_0.r().GetPrimitivePropertyValue<bool>("cc_acidHunters_secretEntranceKnown", new bool?(false)).Value)
			{
				new gc().ym(null, null, null);
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
