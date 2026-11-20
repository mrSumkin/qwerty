using System;
using System.Diagnostics;
using System.Linq;

// Token: 0x02002191 RID: 8593
[bmq("1.0.3.0_Tch_MateosCrawlers", "1.0.3.0", "tch-ww3", false)]
public sealed class coz : fg
{
	// Token: 0x0600C975 RID: 51573 RVA: 0x0047369C File Offset: 0x0047189C
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			foreach (b0b b0b in Enumerable.ToList<b0b>(A_1.n("tch-ww3").Entities))
			{
				c5x c5x = (c5x)b0b;
				if (c5x.y8() == "Crawler" && c5x.h.b != null && c5x.h.b.aa().FactionId == asp.ex)
				{
					bn5 bn = c5x.GetAspect<j7>() as bn5;
					if (bn == null)
					{
						bn = new bn5(c5x);
						c5x.SetAspect<j7>(bn);
					}
					if (bn.d() != "characters\\tch_mateo")
					{
						bn.b("support\\tch_mateosCrawlers");
						bn.a(false);
						bn.b(true);
						bn.a("speaker");
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
