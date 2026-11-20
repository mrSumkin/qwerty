using System;
using System.Collections.Generic;
using System.Diagnostics;

// Token: 0x020021C8 RID: 8648
[bmq("1.0.1.11_MerchantBecket", "1.0.1.11", "lup_freeDroneBase", false)]
public sealed class ezb : fg
{
	// Token: 0x0600C9E7 RID: 51687 RVA: 0x00477258 File Offset: 0x00475458
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("89944698-0d9f-4322-9658-c00be8a0a2d3"), A_1.n("lup_freeDroneBase")).ao() as c5x;
			if (c5x != null)
			{
				a3f a3f = c5x.GetAspect<a3f>();
				if (a3f == null)
				{
					a3f = new a3f(c5x);
					c5x.SetAspect<a3f>(a3f);
				}
				if (a3f != null && a3f.a().GetClassPropertyValue<List<int>>("SpecialMercandiseLevels") == null)
				{
					List<int> list = new List<int>();
					list.Add(45);
					list.Add(85);
					a3f.a()["SpecialMercandiseLevels"] = list;
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
