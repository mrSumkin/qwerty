using System;
using System.Diagnostics;
using System.Linq;

// Token: 0x02002143 RID: 8515
[s3("1.1.2.0_FixSormirbarenWeaponsPlayerInventory", "1.1.2.0")]
public sealed class dsf : cwo
{
	// Token: 0x0600C8CB RID: 51403 RVA: 0x0046DA48 File Offset: 0x0046BC48
	public bool ee(cyt A_0)
	{
		try
		{
			if (A_0.v() != null)
			{
				foreach (coh coh in Enumerable.ToList<coh>(A_0.v().Bag.z2()))
				{
					if (coh.IsLibraryItem && coh.Definition is bke && coh is d48)
					{
						cd1 a_ = new cd1(coh.DefinitionProvider.wm());
						A_0.v().Bag.z3(a_, true);
						A_0.v().Bag.z5(coh);
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
