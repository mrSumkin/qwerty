using System;
using System.Diagnostics;
using Microsoft.Xna.Framework;

// Token: 0x0200212E RID: 8494
[bmq("1.1.1.7_Jy3_FenceGateMove", "1.1.1.7", "jy3", false)]
public sealed class alj : fg
{
	// Token: 0x0600C8A8 RID: 51368 RVA: 0x0046CC34 File Offset: 0x0046AE34
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("dd505854-c273-4bc3-8782-70079b2f8a5c"), A_1.n("jy3")).ao() as c5x;
			if (c5x != null && c5x.Location.X != 4.2f)
			{
				c5x.Location = new Vector3(4.2f, c5x.Location.Y, c5x.Location.Z);
				c5x.Size = new Vector3(0.5f, c5x.Size.Y, c5x.Size.Z);
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
