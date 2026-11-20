using System;
using System.Diagnostics;
using System.IO;

// Token: 0x020021B4 RID: 8628
[bmq("1.0.1.11_Cc_cityEnter", "9.9.9.9", "cc_cityEnter", false)]
public sealed class d9u : fg
{
	// Token: 0x0600C9BE RID: 51646 RVA: 0x004762A4 File Offset: 0x004744A4
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			doq a_ = doq.a(Path.Combine(d5x.q(), "cc_cityEnter_l2") + ".uzl");
			A_1.a(a_, aju.x, null);
			aud aud = A_1.n("cc_cityEnter");
			if (aud != null)
			{
				c5x c5x = aud.a(new Guid("a24beb24-5dd4-43e7-8651-7047181c2ac8")) as c5x;
				if (c5x != null)
				{
					d2b aspect = c5x.GetAspect<d2b>();
					if (aspect != null)
					{
						aspect.a(10);
					}
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
