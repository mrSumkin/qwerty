using System;
using System.Collections.Generic;
using System.Diagnostics;

// Token: 0x020021CB RID: 8651
[bmq("1.0.1.11_MerchantOla", "1.0.1.11", "cc20", false)]
public sealed class ak : fg
{
	// Token: 0x0600C9ED RID: 51693 RVA: 0x004774B0 File Offset: 0x004756B0
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("0b777b0b-2bd1-426e-b10d-ca3791663b59"), A_1.n("cc20")).ao() as c5x;
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
