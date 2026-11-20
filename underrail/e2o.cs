using System;
using System.Diagnostics;

// Token: 0x0200209E RID: 8350
[bmq("1.2.0.17_Xphw_Cc_Rag_TrapDoorFix", "1.2.0.17", "xphw_cc_rag", false)]
public sealed class e2o : fg
{
	// Token: 0x0600C7B2 RID: 51122 RVA: 0x00465CC8 File Offset: 0x00463EC8
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("dd7778d6-cbea-48c8-890f-a9fff4156d12"), A_1.n("xphw_cc_rag")).ao() as c5x;
			if (c5x != null)
			{
				c2r c2r = c5x.GetAspect<bim>() as c2r;
				if (c2r != null)
				{
					c2r.a("Down");
					c2r.s().Clear();
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
