using System;
using System.Diagnostics;

// Token: 0x020021A3 RID: 8611
[bmq("1.0.1.5_CC22CrateClimb", "1.0.1.5", "cc22", false)]
public sealed class rj : fg
{
	// Token: 0x0600C99A RID: 51610 RVA: 0x00474F14 File Offset: 0x00473114
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("89d1ed00-1001-4336-9066-d57c78398863"), A_1.n("cc22")).ao() as c5x;
			if (c5x != null && c5x.y8() != "Залезть наверх")
			{
				c5x.q("Залезть наверх");
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
