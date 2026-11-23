using System;
using System.Collections.Generic;
using System.Diagnostics;
using Ouroboros.Playfield.Space;

// Token: 0x02002194 RID: 8596
[bmq("1.0.1.5_Cc18Desk", "1.0.1.5", "cc18", false)]
public sealed class bc1 : fg
{
	// Token: 0x0600C97C RID: 51580 RVA: 0x00473A9C File Offset: 0x00471C9C
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("67b5333b-dcf5-4b72-905c-1e86a2da1023"), A_1.n("cc18")).ao() as c5x;
			if (c5x != null)
			{
				c7j c7j = c5x.GetAspect<bim>() as c7j;
				if (c7j != null)
				{
					c7j.a(new List<HorizontalDirection>
					{
						HorizontalDirection.East
					});
				}
				c3g c3g = c5x.GetAspect<c3g>();
				if (c3g == null)
				{
					c3g = new c3g(c5x);
					c5x.SetAspect<c3g>(c3g);
				}
				c3g.d().Clear();
				c3g.d().Add(asp.dz);
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
