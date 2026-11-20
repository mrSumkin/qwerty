using System;
using System.Diagnostics;

// Token: 0x020020C3 RID: 8387
[bmq("1.1.5.0_Up7_QuakeBattery", "1.1.5.0", "up7", false)]
public sealed class dp4 : fg
{
	// Token: 0x0600C7F0 RID: 51184 RVA: 0x00467414 File Offset: 0x00465614
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("8b829b60-10db-4d64-ae25-669b397b6c33"), A_1.n("up7")).ao() as c5x;
			if (c5x != null && c5x.h.b != null)
			{
				coh coh = c5x.h.b.aa().a("wep.quake", true);
				if (coh != null && coh.Battery == 0.0)
				{
					coh.Battery = (double)coh.MaxBattery;
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
