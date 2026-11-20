using System;
using System.Diagnostics;

// Token: 0x0200220F RID: 8719
[s3("1.0.0.11_OliviaAndNicolasFail", "1.0.0.11")]
public sealed class dcq : cwo
{
	// Token: 0x0600CA77 RID: 51831 RVA: 0x0047B87C File Offset: 0x00479A7C
	public bool ee(cyt A_0)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		try
		{
			if (A_0.r().GetPrimitivePropertyValue<bool>("npc_fo_nicolas_dies", new bool?(false)).Value)
			{
				serviceOrThrow.aqz().atd("fo_tillDeathDoUsPartNicolas", true);
			}
			if (A_0.r().GetPrimitivePropertyValue<bool>("npc_fo_olivia_dies", new bool?(false)).Value)
			{
				serviceOrThrow.aqz().atd("fo_tillDeathDoUsPartOlivia", true);
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
