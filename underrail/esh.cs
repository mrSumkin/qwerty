using System;
using System.Collections.Generic;
using System.Diagnostics;

// Token: 0x020021CE RID: 8654
[bmq("1.0.1.11_MerchantBlaine", "1.0.1.11", "lup-a1", false)]
public sealed class esh : fg
{
	// Token: 0x0600C9F3 RID: 51699 RVA: 0x00477708 File Offset: 0x00475908
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("33fc0622-a1fe-479a-a2be-e9bdf880ba46"), A_1.n("lup-a1")).ao() as c5x;
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
					list.Add(25);
					list.Add(45);
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
