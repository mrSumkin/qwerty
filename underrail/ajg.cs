using System;
using System.Diagnostics;

// Token: 0x020021E9 RID: 8681
[bmq("1.0.0.8_Dc-Cp1Locker", "1.0.0.8", "dc-cp1", false)]
public sealed class ajg : fg
{
	// Token: 0x0600CA2B RID: 51755 RVA: 0x00478F24 File Offset: 0x00477124
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("74dafd47-2cce-46d5-8d1e-14408ec0b305"), A_1.n("dc-cp1")).ao() as c5x;
			if (c5x != null && c5x.VisualPriority == 0)
			{
				c5x.VisualPriority = 1;
				c5x.@as();
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
