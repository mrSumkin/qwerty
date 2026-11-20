using System;
using System.Diagnostics;
using System.Linq;

// Token: 0x020020F0 RID: 8432
[bmq("1.1.4.0_BlackCrawlerOnDeathJobs", "1.1.4.0", "lu-b10u2", false)]
public sealed class c2c : fg
{
	// Token: 0x0600C836 RID: 51254 RVA: 0x004694DC File Offset: 0x004676DC
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("d1c256f8-8f4d-450f-999c-9b07c1833009"), A_1.n("lu-b10u2b")).ao() as c5x;
			if (c5x != null && c5x.h.b != null && !Enumerable.Any<c4f>(Enumerable.OfType<c4f>(c5x.h.b.ay())))
			{
				c4f c4f = new c4f();
				c4f.Properties["npc_blackCrawler_died"] = true;
				c5x.h.b.ay().Add(c4f);
				a6p aspect = c5x.GetAspect<a6p>();
				if (aspect != null)
				{
					aspect.d().Add("-jobs");
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
