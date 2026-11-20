using System;
using System.Collections.Generic;
using System.Diagnostics;

// Token: 0x020021BA RID: 8634
[bmq("1.0.1.11_Lux_A3_CorpsesAndSwitch", "1.0.1.11", "lux-a3", false)]
public sealed class lo : fg
{
	// Token: 0x0600C9CA RID: 51658 RVA: 0x004767A4 File Offset: 0x004749A4
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("f6770a3f-6fc1-4bab-af0f-3ec29aee44c9"), A_1.n("lux-a3")).ao() as c5x;
			c5x c5x2 = new ar7(new Guid("eeb91b9e-3e52-41c4-8d49-5fe4474dd837"), A_1.n("lux-a3")).ao() as c5x;
			c5x c5x3 = new ar7(new Guid("56fb9c9b-cdf0-40f7-ad12-c72a7c5cfb4f"), A_1.n("lux-a3")).ao() as c5x;
			c5x c5x4 = new ar7(new Guid("4b421b08-f340-482c-84ce-3d47114c9b87"), A_1.n("lux-a3")).ao() as c5x;
			if (c5x != null)
			{
				c7j c7j = c5x.GetAspect<bim>() as c7j;
				if (c7j != null)
				{
					c7j.c("CarcassOpen");
				}
			}
			if (c5x2 != null)
			{
				c7j c7j2 = c5x2.GetAspect<bim>() as c7j;
				if (c7j2 != null)
				{
					c7j2.c("CarcassOpen");
				}
			}
			if (c5x3 != null)
			{
				c7j c7j3 = c5x3.GetAspect<bim>() as c7j;
				if (c7j3 != null)
				{
					c7j3.c("CarcassOpen");
				}
			}
			if (c5x4 != null)
			{
				bsl bsl = c5x4.GetAspect<bim>() as bsl;
				if (bsl != null)
				{
					bsl.s().Clear();
					List<cze> list = bsl.s();
					bfq bfq = new bfq();
					bfq.a(bvl.c);
					bfq.b("switch");
					bfq.a(true);
					bfq.c("LeverSwitchPull");
					list.Add(bfq);
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
