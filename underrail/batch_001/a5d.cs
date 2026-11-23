using System;
using System.Diagnostics;

// Token: 0x020020D1 RID: 8401
[bmq("1.1.5.0_Tch_LibraryCards", "1.1.5.0", "tch-lib", false)]
public sealed class a5d : fg
{
	// Token: 0x0600C807 RID: 51207 RVA: 0x004684C0 File Offset: 0x004666C0
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("a6797da8-2a2d-4b9a-b467-c71414c24c47"), A_1.n("tch-lib")).ao() as c5x;
			if (c5x != null)
			{
				amc aspect = c5x.GetAspect<amc>();
				if (aspect != null && aspect.aa().a("libraryPropagatorCard", false) == null)
				{
					coh coh = new d48(ez2.CreateDefinitonProvider<a0z>("plot\\libraryPropagatorCard"));
					if (coh != null)
					{
						aspect.aa().Bag.z3(coh, true);
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
