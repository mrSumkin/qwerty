using System;
using System.Diagnostics;

// Token: 0x020021D6 RID: 8662
[bmq("1.0.1.13_Oculus_InjuredMan", "1.0.1.13", "wa-mf", false)]
public sealed class c2k : fg
{
	// Token: 0x0600CA03 RID: 51715 RVA: 0x00477DDC File Offset: 0x00475FDC
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("6a94ba03-6667-4872-9888-8bb263beada0"), A_1.n("wa-mf")).ao() as c5x;
			if (c5x != null)
			{
				bn5 bn = c5x.GetAspect<j7>() as bn5;
				if (bn == null)
				{
					bn = new bn5(c5x);
					c5x.SetAspect<j7>(bn);
				}
				bn.b("support\\wa_injured");
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
