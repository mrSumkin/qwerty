using System;
using System.Diagnostics;

// Token: 0x020021D8 RID: 8664
[bmq("1.0.1.13_Rc_LivingQuartersDoge", "1.0.1.13", "rc1_livingQuarter", false)]
public sealed class aws : fg
{
	// Token: 0x0600CA07 RID: 51719 RVA: 0x00477F78 File Offset: 0x00476178
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("0794099b-0a9d-4999-9c3a-e9a2c93e385f"), A_1.n("rc1_livingQuarter")).ao() as c5x;
			if (c5x != null)
			{
				amc aspect = c5x.GetAspect<amc>();
				if (aspect != null && aspect.aa().FactionId != "railCrossing_doge")
				{
					aspect.aa().FactionId = "railCrossing_doge";
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
