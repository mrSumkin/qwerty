using System;
using System.Diagnostics;

// Token: 0x02002186 RID: 8582
[bmq("1.0.3.24_RemoveOldDude", "1.0.3.24", "rc1", false)]
public sealed class rr : fg
{
	// Token: 0x0600C95D RID: 51549 RVA: 0x00472754 File Offset: 0x00470954
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			aud aud = A_1.n("rc1");
			if (aud != null)
			{
				c5x c5x = new ar7(new Guid("3fb178ab-ee1d-4ac2-96b1-0f4bcce38750"), aud).ao() as c5x;
				if (c5x != null)
				{
					c5x.w();
					c5x.an();
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
