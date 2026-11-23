using System;
using System.Diagnostics;

// Token: 0x020021AC RID: 8620
[bmq("1.0.1.14_Oligarchs", "1.0.1.14", "cc19,cc21,cc23", false)]
public sealed class bwo : fg
{
	// Token: 0x0600C9AD RID: 51629 RVA: 0x00475774 File Offset: 0x00473974
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("72c394b8-dfe9-463c-9cd0-29f83eac7aea"), A_1.n("cc19")).ao() as c5x;
			c5x c5x2 = new ar7(new Guid("591601a6-8a3a-4f07-8aee-667f9c25464f"), A_1.n("cc23")).ao() as c5x;
			c5x c5x3 = new ar7(new Guid("b92ca778-f933-4f0d-b030-e7ac09fbd8b9"), A_1.n("cc21")).ao() as c5x;
			if (c5x != null)
			{
				bm6 aspect = c5x.GetAspect<bm6>();
				if (aspect != null)
				{
					aspect.y6()[ddq.bs] = new exw(d6n.a, 0.0, false, null);
				}
				amc aspect2 = c5x.GetAspect<amc>();
				if (aspect2 != null && aspect2.am() != "rups")
				{
					aspect2.a("rups");
				}
			}
			if (c5x2 != null)
			{
				bm6 aspect3 = c5x2.GetAspect<bm6>();
				if (aspect3 != null)
				{
					aspect3.y6()[ddq.bs] = new exw(d6n.c, 0.0, true, null);
				}
				amc aspect4 = c5x2.GetAspect<amc>();
				if (aspect4 != null && aspect4.am() != "archk")
				{
					aspect4.a("archk");
				}
			}
			if (c5x3 != null)
			{
				bm6 aspect5 = c5x3.GetAspect<bm6>();
				if (aspect5 != null)
				{
					aspect5.y6()[ddq.bs] = new exw(d6n.a, 0.0, false, null);
				}
				amc aspect6 = c5x3.GetAspect<amc>();
				if (aspect6 != null && aspect6.am() != "guned")
				{
					aspect6.a("guned");
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
