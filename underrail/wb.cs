using System;
using System.Diagnostics;

// Token: 0x020020AB RID: 8363
[s3("1.2.0.13_AcidHuntersQuestRepeatingFix", "1.2.0.13")]
public sealed class wb : cwo
{
	// Token: 0x0600C7C8 RID: 51144 RVA: 0x004663DC File Offset: 0x004645DC
	public bool ee(cyt A_0)
	{
		try
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (A_0.r().GetPrimitivePropertyValue<bool>("loc_xphw_exoBase_voidBattleLost", new bool?(false)).Value)
			{
				serviceOrThrow.aqz().atd("xphw_voidBattle", false);
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
