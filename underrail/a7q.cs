using System;
using System.Diagnostics;

// Token: 0x0200214E RID: 8526
[bmq("1.1.1.3_Cc_JkkFemale2Correction", "1.1.1.3", "*", true)]
public sealed class a7q : fg
{
	// Token: 0x0600C8E2 RID: 51426 RVA: 0x0046EFD4 File Offset: 0x0046D1D4
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			foreach (aud aud in A_1.Areas)
			{
				foreach (b0b b0b in aud.Entities)
				{
					amc aspect = ((c5x)b0b).GetAspect<amc>();
					if (aspect != null && aspect.am() == "jkk_f2")
					{
						aspect.a("jkk_f1");
					}
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
