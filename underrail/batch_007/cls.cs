using System;
using System.Collections.Generic;
using System.Diagnostics;

// Token: 0x020021E7 RID: 8679
[bmq("1.0.0.9_Lu_c1RespawningLunatics", "1.0.0.9", "lu-c1", false)]
public sealed class cls : fg
{
	// Token: 0x0600CA27 RID: 51751 RVA: 0x00478CF0 File Offset: 0x00476EF0
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			List<c5x> list = new List<c5x>();
			foreach (aud aud in A_1.Areas)
			{
				foreach (b0b b0b in aud.Entities)
				{
					c5x c5x = (c5x)b0b;
					if (c5x.GetAspect<c4k>() != null)
					{
						list.Add(c5x);
					}
					else if (c5x.GetAspect<abh>() != null)
					{
						c5x.RemoveAspect<abh>();
					}
				}
			}
			foreach (c5x c5x2 in list)
			{
				c5x2.w();
				c5x2.an();
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
