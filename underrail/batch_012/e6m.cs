using System;
using System.Diagnostics;

// Token: 0x020021B8 RID: 8632
[bmq("1.0.1.11_Crys2_ChromiumDeposits", "1.0.1.11", "crys2", false)]
public sealed class e6m : fg
{
	// Token: 0x0600C9C6 RID: 51654 RVA: 0x0047663C File Offset: 0x0047483C
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("9dcff44e-5855-409b-b7f0-cbb6778f73f6"), A_1.n("crys2")).ao() as c5x;
			c5x c5x2 = new ar7(new Guid("91d1eab5-2d68-47c9-9ab2-b772b053487f"), A_1.n("crys2")).ao() as c5x;
			if (c5x != null)
			{
				a2o a2o = c5x.GetAspect<cd0>() as a2o;
				if (a2o != null && a2o.b.X != 0)
				{
					a2o.b.X = 0;
				}
			}
			if (c5x2 != null)
			{
				a2o a2o2 = c5x2.GetAspect<cd0>() as a2o;
				if (a2o2 != null && a2o2.b.X != 0)
				{
					a2o2.b.X = 0;
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
