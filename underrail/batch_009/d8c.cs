using System;
using System.Collections.Generic;
using System.Diagnostics;

// Token: 0x020021C7 RID: 8647
[bmq("1.0.1.11_MerchantConstantine", "1.0.1.11", "wa-shop", false)]
public sealed class d8c : fg
{
	// Token: 0x0600C9E5 RID: 51685 RVA: 0x00477190 File Offset: 0x00475390
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("1bba6d39-5a05-4fff-a23f-515d802a398a"), A_1.n("wa-shop")).ao() as c5x;
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
					list.Add(55);
					list.Add(95);
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
