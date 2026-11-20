using System;
using System.Diagnostics;

// Token: 0x020021FA RID: 8698
[bmq("1.0.0.2_StationAlpha-8", "1.0.0.2", "StationAlpha-Level8", false)]
public sealed class dmd : fg
{
	// Token: 0x0600CA4D RID: 51789 RVA: 0x00479D40 File Offset: 0x00477F40
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("15107d12-64c2-4d36-96e9-23e548352f84"), A_1.Areas[0]).ao() as c5x;
			c5x c5x2 = new ar7(new Guid("1ce6bc3a-3181-4a1f-ae2f-0c68484cfdfd"), A_1.Areas[0]).ao() as c5x;
			if (c5x != null)
			{
				c5x.TileFormationModifiers.c();
				c5x.z();
			}
			if (c5x2 != null)
			{
				c3g c3g = c5x2.GetAspect<c3g>();
				if (c3g == null)
				{
					c3g = new c3g(c5x2);
					c5x2.SetAspect<c3g>(c3g);
				}
				c3g.d().Clear();
				c3g.d().Add(asp.f);
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
