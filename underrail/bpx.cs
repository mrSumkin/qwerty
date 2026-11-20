using System;
using System.Diagnostics;

// Token: 0x020021A4 RID: 8612
[bmq("1.0.1.5_Cc_tmEntranceDoor", "1.0.1.5", "cc_tm", false)]
public sealed class bpx : fg
{
	// Token: 0x0600C99C RID: 51612 RVA: 0x00474FA0 File Offset: 0x004731A0
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("2582fb65-ef30-4561-a254-efcd4ab8740a"), A_1.n("cc_tm2")).ao() as c5x;
			c5x c5x2 = new ar7(new Guid("98c8a8c6-0cf8-439c-997c-88d2dabe8678"), A_1.n("cc_tm2")).ao() as c5x;
			c5x c5x3 = new ar7(new Guid("fa38132c-d916-4037-95a4-8a57c12bf85d"), A_1.n("cc_tm1")).ao() as c5x;
			c5x c5x4 = new ar7(new Guid("838d0181-f00e-4063-9779-f0d102c3465d"), A_1.n("cc_tm1")).ao() as c5x;
			if (c5x != null)
			{
				bim aspect = c5x.GetAspect<bim>();
				if (aspect != null && !aspect.af1())
				{
					aspect.af2(true);
				}
			}
			if (c5x2 != null)
			{
				bim aspect2 = c5x2.GetAspect<bim>();
				if (aspect2 != null && !aspect2.af1())
				{
					aspect2.af2(true);
				}
			}
			if (c5x3 != null)
			{
				bim aspect3 = c5x3.GetAspect<bim>();
				if (aspect3 != null && !aspect3.af1())
				{
					aspect3.af2(true);
				}
			}
			if (c5x4 != null)
			{
				bim aspect4 = c5x4.GetAspect<bim>();
				if (aspect4 != null && !aspect4.af1())
				{
					aspect4.af2(true);
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
