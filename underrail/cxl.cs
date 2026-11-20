using System;
using System.Collections.Generic;
using System.Diagnostics;

// Token: 0x020021CC RID: 8652
[bmq("1.0.1.11_MerchantStratford", "1.0.1.11", "cc23", false)]
public sealed class cxl : fg
{
	// Token: 0x0600C9EF RID: 51695 RVA: 0x00477578 File Offset: 0x00475778
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("1c58ce8d-f8c9-4773-9f49-fe63740940cb"), A_1.n("cc23")).ao() as c5x;
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
					list.Add(50);
					list.Add(90);
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
