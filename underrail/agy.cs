using System;
using System.Diagnostics;

// Token: 0x020020E2 RID: 8418
[s3("1.1.5.0_JonSpecialReplacement", "1.1.5.0")]
public sealed class agy : cwo
{
	// Token: 0x0600C81D RID: 51229 RVA: 0x00468904 File Offset: 0x00466B04
	public bool ee(cyt A_0)
	{
		try
		{
			d48 d = A_0.v().Bag.b("jonSpecial") as d48;
			if (d != null && !d.IsLibraryItem)
			{
				d48 d2 = new d48(ez2.CreateDefinitonProvider<cv9>("Consumables\\Food\\JonsSpecial"));
				if (d2 != null)
				{
					A_0.v().Bag.z5(d);
					A_0.v().Bag.z3(d2, true);
				}
			}
			if (A_0.r().GetPrimitivePropertyValue<bool>("npc_cc_jon_toldAskSpecial", new bool?(false)).Value)
			{
				A_0.r()["npc_cc_jon_askPatrickPierce"] = true;
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
