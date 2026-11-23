using System;
using System.Diagnostics;
using System.IO;

// Token: 0x020020BF RID: 8383
[bmq("1.1.5.5_Lu_B24_LeonieFootlockerFix", "1.1.5.5", "lu-b24", false)]
public sealed class eha : fg
{
	// Token: 0x0600C7E9 RID: 51177 RVA: 0x00467008 File Offset: 0x00465208
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			if (new ar7(new Guid("e0ec9d7d-e551-4ebe-ac32-ae02c3fa1b66"), A_1.n("lu-b24")).ao() is c5x)
			{
				A_0.r()["npc_fo_leonie_superSteelFootlocker_present"] = true;
			}
			if (A_0.r().GetPrimitivePropertyValue<bool>("npc_fo_leonie_aboutSupersteel", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("npc_fo_leonie_superSteelFootlocker_present", new bool?(false)).Value)
			{
				doq a_ = doq.a(Path.Combine(d5x.q(), "lu-b24_l2") + ".uzl");
				A_1.a(a_, 1, null);
				A_0.r()["npc_fo_leonie_superSteelFootlocker_present"] = true;
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
