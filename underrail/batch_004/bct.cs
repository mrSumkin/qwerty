using System;
using System.Diagnostics;
using System.Linq;

// Token: 0x0200209C RID: 8348
[bmq("1.2.0.17_Lux_HoleDd_ZoneExitFix", "1.2.0.17", "lux-holeDd", false)]
public sealed class bct : fg
{
	// Token: 0x0600C7AE RID: 51118 RVA: 0x00465A9C File Offset: 0x00463C9C
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			d60 d = A_1.a();
			if (d != null)
			{
				c5x c5x = Enumerable.FirstOrDefault<b0b>(d.ab4(new string[]
				{
					"lux-hole_exit"
				})) as c5x;
				if (c5x != null && c5x.s.b != null)
				{
					foreach (cze cze in c5x.s.b.s())
					{
						if (cze is e68)
						{
							e68 e = cze as e68;
							if (e != null && !string.IsNullOrEmpty(e.Destination.c()) && !string.Equals(e.Destination.c(), "randomEvent_lux-holeDD_exit"))
							{
								e.Destination = new c2w(e.Destination.b(), "randomEvent_lux-holeDD_exit");
								c5x.s.b.s().Remove(cze);
								c5x.s.b.s().Add(e);
							}
						}
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
