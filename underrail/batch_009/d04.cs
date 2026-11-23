using System;
using System.Diagnostics;

// Token: 0x0200220B RID: 8715
[bmq("1.0.0.11_Lu_b22DoorInWall", "1.0.0.11", "lu-b22", false)]
public sealed class d04 : fg
{
	// Token: 0x0600CA6F RID: 51823 RVA: 0x0047B490 File Offset: 0x00479690
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("f32562ab-dc40-4711-96d7-0a172f7cd153"), A_1.n("lu-b22")).ao() as c5x;
			if (c5x != null)
			{
				c5x.an();
				c5x.w();
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
