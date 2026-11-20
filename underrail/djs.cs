using System;
using System.Diagnostics;

// Token: 0x020021F5 RID: 8693
[bmq("1.0.0.2_SouthGateStationLowerUnderrailNorth", "1.0.0.2", "LU-SouthGateStation-N", false)]
public sealed class djs : fg
{
	// Token: 0x0600CA43 RID: 51779 RVA: 0x0047994C File Offset: 0x00477B4C
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("ed359f96-cfba-4c2a-a878-32631e19935d"), A_1.n("LU-SouthGateStation-N")).ao() as c5x;
			if (c5x != null && c5x.y8() != "Desk")
			{
				c5x.q("Desk");
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
