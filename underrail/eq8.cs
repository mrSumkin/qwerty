using System;
using System.Diagnostics;

// Token: 0x020021D2 RID: 8658
[bmq("1.0.1.13_Cc10_DoorProtection", "9.9.9.9", "cc10", false)]
public sealed class eq8 : fg
{
	// Token: 0x0600C9FB RID: 51707 RVA: 0x00477970 File Offset: 0x00475B70
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("6a33e755-7fcd-4c93-964a-c9fdce9242a8"), A_1.n("cc10")).ao() as c5x;
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
