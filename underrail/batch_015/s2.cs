using System;
using System.Diagnostics;

// Token: 0x020021D4 RID: 8660
[bmq("1.0.1.13_Cc20_DoorProtection", "9.9.9.9", "cc20", false)]
public sealed class s2 : fg
{
	// Token: 0x0600C9FF RID: 51711 RVA: 0x00477B10 File Offset: 0x00475D10
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("83fbaddc-6241-4a6e-884a-97c41ea6003a"), A_1.n("cc20")).ao() as c5x;
			c5x c5x2 = new ar7(new Guid("0145564f-e7b8-4d73-92d5-6a9853623619"), A_1.n("cc20")).ao() as c5x;
			c5x c5x3 = new ar7(new Guid("e50a471d-2b99-4847-b044-c01b71cfeb58"), A_1.n("cc20")).ao() as c5x;
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
				c3g.d().Add(asp.ea);
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
				c3g2.d().Add(asp.ea);
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
				c3g3.d().Add(asp.ea);
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
