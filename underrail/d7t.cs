using System;
using System.Collections.Generic;
using System.Diagnostics;

// Token: 0x020020DE RID: 8414
[bmq("1.1.5.0_Lup_FreeDroneBase_HiddenHatchChanges", "1.1.5.0", "lup_freeDroneBase", false)]
public sealed class d7t : fg
{
	// Token: 0x0600C815 RID: 51221 RVA: 0x00468634 File Offset: 0x00466834
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("e5c12df9-0727-4874-ac15-78248d84d44e"), A_1.n("lup_freeDroneBase")).ao() as c5x;
			if (c5x != null && c5x.s.b != null)
			{
				c5x.s.b.s().Clear();
				List<cze> list = c5x.s.b.s();
				bfq bfq = new bfq();
				bfq.a(bvl.c);
				bfq.b("use");
				bfq.c("LowerMetalShipRamp");
				bfq.a(true);
				bfq.a(0.8f);
				list.Add(bfq);
				List<cze> list2 = c5x.s.b.s();
				e2d e2d = new e2d();
				e2d.a(false);
				list2.Add(e2d);
				List<cze> list3 = c5x.s.b.s();
				egx egx = new egx();
				egx.a("Ручка отломалась!");
				list3.Add(egx);
				c0s c0s = new c0s(c5x);
				c5x.SetAspect<c0s>(c0s);
				c0s.a(dsu.b);
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
