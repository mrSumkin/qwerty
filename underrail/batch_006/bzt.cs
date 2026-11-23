using System;
using System.Diagnostics;

// Token: 0x02002209 RID: 8713
[bmq("1.0.0.11_Dc_TlLocker", "1.0.0.11", "dc-tl", false)]
public sealed class bzt : fg
{
	// Token: 0x0600CA6B RID: 51819 RVA: 0x0047B260 File Offset: 0x00479460
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("1251a8f4-07e4-4288-8457-48d2ef246876"), A_1.n("dc-tl")).ao() as c5x;
			if (c5x != null && c5x.VisualPriority == 0)
			{
				c5x.VisualPriority = 1;
				c5x.@as();
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
