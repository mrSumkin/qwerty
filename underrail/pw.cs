using System;
using System.Diagnostics;

// Token: 0x020021F1 RID: 8689
[bmq("1.0.0.4_Harriette", "1.0.0.4", "cc10", false)]
public sealed class pw : fg
{
	// Token: 0x0600CA3B RID: 51771 RVA: 0x00479570 File Offset: 0x00477770
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("b15a8c36-a99e-405b-8c53-f95518929fc1"), A_1.n("cc10")).ao() as c5x;
			if (c5x != null)
			{
				amc aspect = c5x.GetAspect<amc>();
				if (aspect != null && aspect.aa().Name != "Harriette")
				{
					aspect.aa().Name = "Harriette";
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
