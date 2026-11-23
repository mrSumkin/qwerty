using System;
using System.Collections.Generic;
using System.Diagnostics;

// Token: 0x020021CD RID: 8653
[bmq("1.0.1.11_MerchantKevin", "1.0.1.11", "fo1", false)]
public sealed class ase : fg
{
	// Token: 0x0600C9F1 RID: 51697 RVA: 0x00477640 File Offset: 0x00475840
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("10dc0895-f6ac-449f-9fe1-61b73a1b44b9"), A_1.n("fo1")).ao() as c5x;
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
					list.Add(40);
					list.Add(80);
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
