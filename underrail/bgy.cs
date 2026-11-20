using System;
using System.Diagnostics;
using System.Linq;

// Token: 0x020020E3 RID: 8419
[bmq("1.1.5.9_Lux_Lep_ImportLayer", "1.1.5.9", "lux-lep", true)]
public sealed class bgy : t0
{
	// Token: 0x0600C81F RID: 51231 RVA: 0x004689E4 File Offset: 0x00466BE4
	public bgy() : base("lux-lep", 2)
	{
	}

	// Token: 0x0600C820 RID: 51232 RVA: 0x004689F4 File Offset: 0x00466BF4
	public override bool b5(cyt A_0, c1a A_1)
	{
		base.b5(A_0, A_1);
		try
		{
			d60 d = A_1.a();
			if (d != null)
			{
				c5x c5x = Enumerable.FirstOrDefault<b0b>(d.ab4(new string[]
				{
					"ladder"
				})) as c5x;
				if (c5x != null && c5x.s.b != null && c5x.s.b.s().Count <= 1)
				{
					if (dh7.a != null && !string.IsNullOrEmpty(dh7.a.b))
					{
						c5x.s.b.s().Add(new e68
						{
							Destination = new c2w(dh7.a.b, "randomEvent_lux_lep_exit")
						});
					}
					else
					{
						c5x.s.b.s().Add(new e68
						{
							Destination = new c2w("lux-b19", "FromCave")
						});
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
