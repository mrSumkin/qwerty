using System;
using System.Diagnostics;

// Token: 0x020021ED RID: 8685
[bmq("1.0.0.7_fo3_slums", "1.0.0.7", "fo3_slums", false)]
public sealed class cz3 : fg
{
	// Token: 0x0600CA33 RID: 51763 RVA: 0x00479218 File Offset: 0x00477418
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("d2df784e-cabc-4b6c-a672-f053e8b4f0ab"), A_1.n("fo3_slums")).ao() as c5x;
			if (c5x != null)
			{
				c7j c7j = c5x.GetAspect<bim>() as c7j;
				if (c7j != null)
				{
					c7j.c("JunkRummage");
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
