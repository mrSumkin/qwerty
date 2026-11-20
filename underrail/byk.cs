using System;
using System.Diagnostics;
using System.Linq;

// Token: 0x02002109 RID: 8457
[bmq("1.1.3.0_GammaCompound3DoorFix", "1.1.3.0", "GammaCompound3", false)]
public sealed class byk : fg
{
	// Token: 0x0600C85F RID: 51295 RVA: 0x0046A444 File Offset: 0x00468644
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			foreach (aud aud in Enumerable.ToList<aud>(A_1.Areas))
			{
				foreach (b0b b0b in Enumerable.ToList<b0b>(aud.Entities))
				{
					c5x c5x = (c5x)b0b;
					cnb cnb = c5x.GetAspect<bim>() as cnb;
					if (cnb != null && !cnb.q() && !c5x.TileFormationModifiers.a(9))
					{
						c5x.TileFormationModifiers.s3(9);
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
