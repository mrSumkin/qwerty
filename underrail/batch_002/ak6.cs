using System;
using System.Collections.Generic;
using System.Diagnostics;

// Token: 0x020021EF RID: 8687
[bmq("1.0.0.5_HecateConsole", "1.0.0.5", "hro1", false)]
public sealed class ak6 : fg
{
	// Token: 0x0600CA37 RID: 51767 RVA: 0x0047944C File Offset: 0x0047764C
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("45211670-4c48-4e93-9562-df720f49235f"), A_1.n("hro1")).ao() as c5x;
			if (c5x != null)
			{
				dt5 aspect = c5x.GetAspect<dt5>();
				if (aspect != null)
				{
					aspect.a(new List<string>());
					aspect.g().Add("hro_mainPower");
					aspect.h();
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
