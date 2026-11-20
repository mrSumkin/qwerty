using System;
using System.Diagnostics;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Items;

// Token: 0x0200215A RID: 8538
[bmq("1.1.0.15_Tch_ww3_Needler", "1.1.0.15", "tch-ww3", false)]
public sealed class efm : fg
{
	// Token: 0x0600C900 RID: 51456 RVA: 0x00470038 File Offset: 0x0046E238
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("48cdfa63-ed50-43d7-8097-775a6b26df06"), A_1.n("tch-ww3")).ao() as c5x;
			if (c5x != null)
			{
				amc aspect = c5x.GetAspect<amc>();
				if (aspect != null)
				{
					LibraryItemDefinitionProvider<bke> libraryItemDefinitionProvider = ez2.CreateDefinitonProvider<bke>("weapons\\needler");
					if (libraryItemDefinitionProvider != null && libraryItemDefinitionProvider.wl() != null)
					{
						cd1 a_ = new cd1(libraryItemDefinitionProvider);
						aspect.aa().Gear.j()[WeaponKey.Primary].a(a_, true);
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
