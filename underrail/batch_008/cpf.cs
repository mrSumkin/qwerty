using System;
using System.Diagnostics;
using System.Linq;

// Token: 0x020020EA RID: 8426
[s3("1.1.5.12_JonSpecialReplacement", "1.1.5.12")]
public sealed class cpf : cwo
{
	// Token: 0x0600C82C RID: 51244 RVA: 0x00468F00 File Offset: 0x00467100
	public bool ee(cyt A_0)
	{
		try
		{
			efk efk = A_0.v();
			if (efk != null)
			{
				foreach (coh coh in Enumerable.ToList<coh>(efk.Bag.z2()))
				{
					if (coh is k7 && !string.IsNullOrEmpty(coh.Definition.az()) && coh.Definition.az().ToLower() == "unknown")
					{
						efk.Bag.z5(coh);
						a12 a = new a12(ez2.CreateDefinitonProvider<c5s>("armor\\JumpingStilts"));
						if (a != null)
						{
							efk.Bag.z3(a, true);
						}
						return true;
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
