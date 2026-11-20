using System;
using System.Diagnostics;
using System.IO;

// Token: 0x02002108 RID: 8456
[bmq("1.1.3.0_Pb_BaracksNewArea", "9.9.9.9", "pb-baracks", true)]
public sealed class wg : fg
{
	// Token: 0x0600C85D RID: 51293 RVA: 0x0046A398 File Offset: 0x00468598
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			doq a_ = doq.a(Path.Combine(d5x.q(), "pb-baracks_l2") + ".uzl");
			A_1.a(a_, aju.x, null);
			aud aud = A_1.n("pb-baracks");
			if (aud != null)
			{
				c5x c5x = aud.a(new Guid("f771657e-b680-497d-8eab-c57ddd141c53")) as c5x;
				if (c5x != null && c5x.GetAspect<c3g>() != null)
				{
					c5x.RemoveAspect<c3g>();
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
