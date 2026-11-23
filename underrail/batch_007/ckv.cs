using System;
using System.Diagnostics;
using Microsoft.Xna.Framework;

// Token: 0x02002210 RID: 8720
[bmq("1.0.0.10_Cc_PhWeightRack", "1.0.0.10", "cc_ph", false)]
public sealed class ckv : fg
{
	// Token: 0x0600CA79 RID: 51833 RVA: 0x0047B92C File Offset: 0x00479B2C
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("2e471eb2-7232-4975-ac53-c83d7846345b"), A_1.n("cc_ph2")).ao() as c5x;
			if (c5x != null && c5x.Size.X == 2f)
			{
				c5x.Size = new Vector3(c5x.Size.X - 1f, c5x.Size.Y, c5x.Size.Z);
				c5x.ah();
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
