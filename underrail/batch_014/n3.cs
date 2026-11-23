using System;
using System.Diagnostics;

// Token: 0x0200212C RID: 8492
[bmq("1.1.1.7_Tch_labGen_FixPsychoTacticsProperties", "1.1.1.7", "tch-labgen", false)]
public sealed class n3 : fg
{
	// Token: 0x0600C8A4 RID: 51364 RVA: 0x0046CA4C File Offset: 0x0046AC4C
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("ce0e3d10-9834-43aa-a207-9a70aa12f779"), A_1.n("tch-wh")).ao() as c5x;
			if (c5x != null && c5x.t.b != null && c5x.t.b.ab() != "superPsiBeetle")
			{
				c5x.t.b.c("superPsiBeetle");
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
