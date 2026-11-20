using System;
using System.Diagnostics;

// Token: 0x02002187 RID: 8583
[bmq("1.0.3.24_RemoveSilentIsleLantern", "1.0.3.24", "si1", false)]
public sealed class x8 : fg
{
	// Token: 0x0600C95F RID: 51551 RVA: 0x004727D4 File Offset: 0x004709D4
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("d0a104f2-af43-43ee-b79e-e9a8bcaca179"), A_1.n("si1")).ao() as c5x;
			if (c5x != null)
			{
				c5x.w();
				c5x.an();
			}
		}
		catch (Exception ex)
		{
			Trace.WriteLine(ex.ToString());
		}
		return false;
	}
}
