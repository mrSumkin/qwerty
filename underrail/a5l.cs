using System;
using System.Diagnostics;

// Token: 0x020021E8 RID: 8680
[bmq("1.0.0.9_AgronomyDoorsProtection", "1.0.0.9", "StationAlpha-Level8", false)]
public sealed class a5l : fg
{
	// Token: 0x0600CA29 RID: 51753 RVA: 0x00478E2C File Offset: 0x0047702C
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("a1392497-5397-48d0-893c-187a877c89fb"), A_1.n("StationAlpha-Level8")).ao() as c5x;
			c5x c5x2 = new ar7(new Guid("8522953a-b640-4493-9b34-9bd8fa39b5d5"), A_1.n("StationAlpha-Level8")).ao() as c5x;
			if (c5x != null)
			{
				c3g c3g = c5x.GetAspect<c3g>();
				if (c3g == null)
				{
					c3g = new c3g(c5x);
					c5x.SetAspect<c3g>(c3g);
				}
				c3g.d().Clear();
				c3g.d().Add(asp.f);
				d2b aspect = c5x.GetAspect<d2b>();
				if (aspect != null)
				{
					aspect.a(d1c.b);
				}
			}
			if (c5x2 != null)
			{
				d2b aspect2 = c5x2.GetAspect<d2b>();
				if (aspect2 != null)
				{
					aspect2.a(d1c.b);
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
