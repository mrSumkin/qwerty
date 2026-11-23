using System;
using System.Diagnostics;

// Token: 0x02002208 RID: 8712
[bmq("1.0.0.11_Dc_TwBox", "1.0.0.11", "dc-tw", false)]
public sealed class dmg : fg
{
	// Token: 0x0600CA69 RID: 51817 RVA: 0x0047B1E8 File Offset: 0x004793E8
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("96160426-800d-492a-8edc-24e3434fdda4"), A_1.n("dc-tw")).ao() as c5x;
			if (c5x != null)
			{
				c5x.an();
				c5x.w();
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
