using System;
using System.Diagnostics;

// Token: 0x0200220C RID: 8716
[bmq("1.0.0.11_TchortVases", "1.0.0.11", "tch-ew1,tch-ew2,tch-lib,tch-mainhall,tch-sq1,tch-sq2,tch-wwg", false)]
public sealed class bcz : fg
{
	// Token: 0x0600CA71 RID: 51825 RVA: 0x0047B508 File Offset: 0x00479708
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			foreach (aud aud in A_1.Areas)
			{
				foreach (b0b b0b in aud.Entities)
				{
					c5x c5x = (c5x)b0b;
					if (c5x.o != null && c5x.o.b != null && c5x.o.b.a == "Objects\\Obstacles\\TchortVase" && c5x.s != null && c5x.s.b is c7j)
					{
						c5x.q("Vase");
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
