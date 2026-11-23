using System;
using System.Collections.Generic;
using System.Diagnostics;

// Token: 0x020021C6 RID: 8646
[bmq("1.0.1.11_MerchantHanna", "1.0.1.11", "tch-mil", false)]
public sealed class dll : fg
{
	// Token: 0x0600C9E3 RID: 51683 RVA: 0x004770C8 File Offset: 0x004752C8
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("06ae55ce-56b7-4988-8650-a3f40c551c93"), A_1.n("tch-mil")).ao() as c5x;
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
					list.Add(70);
					list.Add(105);
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
