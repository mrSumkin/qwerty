using System;
using System.Diagnostics;

// Token: 0x020021B3 RID: 8627
[bmq("1.0.1.11_Cc22_DoorProtection", "9.9.9.9", "cc22", false)]
public sealed class dup : fg
{
	// Token: 0x0600C9BC RID: 51644 RVA: 0x00476090 File Offset: 0x00474290
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("97fbbf0b-6518-4161-93e4-1ea79824be56"), A_1.n("cc22")).ao() as c5x;
			c5x c5x2 = new ar7(new Guid("bb4af48b-7116-45fe-8593-548fc30fd6c1"), A_1.n("cc22")).ao() as c5x;
			c5x c5x3 = new ar7(new Guid("93020f9c-0a8b-4137-9bb9-ae2b99a5bf40"), A_1.n("cc22")).ao() as c5x;
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
			if (c5x2 != null)
			{
				c3g c3g2 = c5x2.GetAspect<c3g>();
				if (c3g2 == null)
				{
					c3g2 = new c3g(c5x2);
					c5x2.SetAspect<c3g>(c3g2);
				}
				c3g2.d().Clear();
				c3g2.d().Add(asp.di);
				c3g2.d().Add(asp.dz);
				c3g2.d().Add(asp.d0);
				c3g2.d().Add(asp.d1);
			}
			if (c5x3 != null)
			{
				c3g c3g3 = c5x3.GetAspect<c3g>();
				if (c3g3 == null)
				{
					c3g3 = new c3g(c5x3);
					c5x3.SetAspect<c3g>(c3g3);
				}
				c3g3.d().Clear();
				c3g3.d().Add(asp.di);
				c3g3.d().Add(asp.dz);
				c3g3.d().Add(asp.d0);
				c3g3.d().Add(asp.d1);
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
