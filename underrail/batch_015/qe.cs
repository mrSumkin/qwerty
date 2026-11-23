using System;
using System.Diagnostics;

// Token: 0x020021E4 RID: 8676
[bmq("1.0.0.9_Oj4Box", "1.0.0.9", "ojy4", false)]
public sealed class qe : fg
{
	// Token: 0x0600CA21 RID: 51745 RVA: 0x00478B3C File Offset: 0x00476D3C
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("43f5facf-621f-44f5-9a51-b787c195a6fa"), A_1.n("ojy4")).ao() as c5x;
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
