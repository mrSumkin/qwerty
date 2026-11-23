using System;
using System.Diagnostics;

// Token: 0x020021D3 RID: 8659
[bmq("1.0.1.13_Cc18_DoorProtection", "9.9.9.9", "cc18", false)]
public sealed class aa9 : fg
{
	// Token: 0x0600C9FD RID: 51709 RVA: 0x00477A40 File Offset: 0x00475C40
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("f82c3fd8-7f69-4b63-8c1a-9d61d22ab95f"), A_1.n("cc18")).ao() as c5x;
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
