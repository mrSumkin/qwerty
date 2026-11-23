using System;
using System.Diagnostics;

// Token: 0x020020F1 RID: 8433
[bmq("1.1.4.0_Dc_Tch_HarmostModelReplacement", "1.1.4.0", "dc-tch", false)]
public sealed class do1 : fg
{
	// Token: 0x0600C838 RID: 51256 RVA: 0x004695C4 File Offset: 0x004677C4
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("d70b981f-eba8-4e1c-9d12-71c3007f9bf9"), A_1.n("dc-tch")).ao() as c5x;
			if (c5x != null && c5x.h.b != null)
			{
				c5x.h.b.a(bln.ck);
				cgk cgk = c5x.h.b.aa().Gear.l().Item;
				if (cgk != null)
				{
					cgk.Stealable = false;
					cgk.Lootable = false;
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
