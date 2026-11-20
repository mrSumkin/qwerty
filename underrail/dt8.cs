using System;
using System.Diagnostics;
using System.Linq;

// Token: 0x020020BD RID: 8381
[bmq("1.1.5.5_Lux_GoleDd_ImportLayer", "1.1.5.5", "lux-holeDd", true)]
public sealed class dt8 : t0
{
	// Token: 0x0600C7E6 RID: 51174 RVA: 0x00466EF8 File Offset: 0x004650F8
	public dt8() : base("lux-holeDd", 2)
	{
	}

	// Token: 0x0600C7E7 RID: 51175 RVA: 0x00466F08 File Offset: 0x00465108
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
					"lux-hole_exit"
				})) as c5x;
				if (c5x != null && c5x.s.b != null && c5x.s.b.s().Count <= 1 && dh7.a != null && !string.IsNullOrEmpty(dh7.a.b))
				{
					c5x.s.b.s().Add(new e68
					{
						Destination = new c2w(dh7.a.b, "randomEvent_lux-holeDD_exit")
					});
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
