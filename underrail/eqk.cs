using System;
using System.Diagnostics;

// Token: 0x02002134 RID: 8500
[bmq("1.1.2.0_FixSormirbarenWeaponsGlobal", "1.1.2.0", "*", false)]
public sealed class eqk : fg
{
	// Token: 0x0600C8B1 RID: 51377 RVA: 0x0046D030 File Offset: 0x0046B230
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			if (A_1.y8().StartsWith("xpbl_"))
			{
				foreach (aud aud in A_1.Areas)
				{
					foreach (b0b b0b in aud.Entities)
					{
						c7j c7j = ((c5x)b0b).GetAspect<bim>() as c7j;
						if (c7j != null)
						{
							foreach (coh coh in c7j.ItemContainer.z2())
							{
								if (coh.IsLibraryItem && coh.Definition is bke && coh is d48)
								{
									cd1 a_ = new cd1(coh.DefinitionProvider.wm());
									A_0.v().Bag.z3(a_, true);
									A_0.v().Bag.z5(coh);
								}
							}
						}
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
