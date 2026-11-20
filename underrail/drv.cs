using System;
using System.Diagnostics;

// Token: 0x020021D1 RID: 8657
[bmq("1.0.1.13_Cc11_DoorProtection", "9.9.9.9", "cc11", false)]
public sealed class drv : fg
{
	// Token: 0x0600C9F9 RID: 51705 RVA: 0x004778A0 File Offset: 0x00475AA0
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("2f06630c-22ef-4164-b2c0-5c9a85a6aa5b"), A_1.n("cc11")).ao() as c5x;
			if (c5x != null)
			{
				c3g c3g = c5x.GetAspect<c3g>();
				if (c3g == null)
				{
					c3g = new c3g(c5x);
					c5x.SetAspect<c3g>(c3g);
				}
				c3g.d().Clear();
				c3g.d().Add(asp.di);
				c3g.d().Add(asp.dz);
				c3g.d().Add(asp.d0);
				c3g.d().Add(asp.d1);
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
