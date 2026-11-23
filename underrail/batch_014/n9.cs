using System;
using System.Collections.Generic;
using System.Diagnostics;

// Token: 0x020021C9 RID: 8649
[bmq("1.0.1.11_MerchantFraser", "1.0.1.11", "pb-mainhall", false)]
public sealed class n9 : fg
{
	// Token: 0x0600C9E9 RID: 51689 RVA: 0x00477320 File Offset: 0x00475520
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("c03977bf-88ae-484d-8a17-2d2ac00fa0fc"), A_1.n("pb-mainhall")).ao() as c5x;
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
