using System;
using System.Diagnostics;

// Token: 0x02002125 RID: 8485
[bmq("1.1.2.2_Ojy4_RenameCrumbledRocks", "1.1.2.2", "ojy4", false)]
public sealed class dc : fg
{
	// Token: 0x0600C896 RID: 51350 RVA: 0x0046BDEC File Offset: 0x00469FEC
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("2bf166f0-83f8-4a1e-92e2-d73354d625ba"), A_1.n("ojy4")).ao() as c5x;
			if (c5x != null && c5x.y8().Equals("Crubled Rocks"))
			{
				c5x.q("Crumbled Rocks");
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
