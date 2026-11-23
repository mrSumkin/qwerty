using System;
using System.Collections.Generic;
using System.Diagnostics;
using Ouroboros.Playfield.Space;

// Token: 0x020021A7 RID: 8615
[bmq("1.0.1.5_Cc20Desk", "1.0.1.5", "cc20", false)]
public sealed class ub : fg
{
	// Token: 0x0600C9A2 RID: 51618 RVA: 0x004752D8 File Offset: 0x004734D8
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("0b6ea0f5-6a45-47bf-adf4-5a02880980b6"), A_1.n("cc20")).ao() as c5x;
			if (c5x != null)
			{
				c7j c7j = c5x.GetAspect<bim>() as c7j;
				if (c7j != null)
				{
					c7j.a(new List<HorizontalDirection>
					{
						HorizontalDirection.West
					});
				}
				c3g c3g = c5x.GetAspect<c3g>();
				if (c3g == null)
				{
					c3g = new c3g(c5x);
					c5x.SetAspect<c3g>(c3g);
				}
				c3g.d().Clear();
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
