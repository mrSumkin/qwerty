using System;
using System.Diagnostics;

// Token: 0x0200212B RID: 8491
[s3("1.1.2.2_CompleteQuintonsBeastQuest", "1.1.2.2")]
public sealed class ux : cwo
{
	// Token: 0x0600C8A2 RID: 51362 RVA: 0x0046C9C0 File Offset: 0x0046ABC0
	public bool ee(cyt A_0)
	{
		try
		{
			if (A_0.r().GetPrimitivePropertyValue<bool>("npc_quinton_examineLarva", new bool?(false)).Value)
			{
				cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
				serviceOrThrow.aqz().atb("fo_psiMorphBiologist", false);
				serviceOrThrow.aqz().atc("fo_psiMorphBiologist", true);
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
