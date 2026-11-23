using System;
using System.Collections.Generic;
using System.Diagnostics;

// Token: 0x020021CA RID: 8650
[bmq("1.0.1.11_MerchantHarlan", "1.0.1.11", "cc18", false)]
public sealed class em3 : fg
{
	// Token: 0x0600C9EB RID: 51691 RVA: 0x004773E8 File Offset: 0x004755E8
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("8b023371-abc2-4915-9d0f-f792588684e2"), A_1.n("cc18")).ao() as c5x;
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
