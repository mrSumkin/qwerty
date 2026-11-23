using System;
using System.Diagnostics;

// Token: 0x0200209D RID: 8349
[bmq("1.2.0.17_Xpbl_D5_JetGuardVigilanceFix", "1.2.0.17", "xpbl_d5", false)]
public sealed class da9 : fg
{
	// Token: 0x0600C7B0 RID: 51120 RVA: 0x00465C1C File Offset: 0x00463E1C
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("0c543c2d-c4c6-473a-85c3-80840b0a0593"), A_1.n("xpbl_d5")).ao() as c5x;
			if (c5x != null && c5x.t.b != null)
			{
				c5x.t.b.y6()[ddq.bs] = new exw(d6n.a, 0.0, true, null);
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
