using System;
using System.Diagnostics;

// Token: 0x0200209B RID: 8347
[bmq("1.2.0.19_Xphw_Cc_Rag_TrapDoorOpenedFix", "1.2.0.19", "xphw_cc_rag", false)]
public sealed class eq0 : fg
{
	// Token: 0x0600C7AC RID: 51116 RVA: 0x004659EC File Offset: 0x00463BEC
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("dd7778d6-cbea-48c8-890f-a9fff4156d12"), A_1.n("xphw_cc_rag")).ao() as c5x;
			if (c5x != null && c5x.o.b != null && c5x.o.b.b.X == 1)
			{
				c2r c2r = c5x.GetAspect<bim>() as c2r;
				if (c2r != null)
				{
					c2r.a(true);
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
