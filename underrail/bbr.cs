using System;
using System.Diagnostics;
using Microsoft.Xna.Framework;

// Token: 0x02002104 RID: 8452
[bmq("1.1.3.0_Cc_Dock_MoveSniper", "1.1.3.0", "cc_dock", false)]
public sealed class bbr : fg
{
	// Token: 0x0600C857 RID: 51287 RVA: 0x0046A160 File Offset: 0x00468360
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("54052151-ab82-4161-adb6-5354869ede80"), A_1.n("cc_dock")).ao() as c5x;
			if (c5x != null && c5x.Location.X != 24f && c5x.Location.Y != 19f)
			{
				c5x.Location = new Vector3(24f, 19f, 0f);
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
