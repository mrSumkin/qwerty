using System;
using System.Diagnostics;

// Token: 0x020021F0 RID: 8688
[bmq("1.0.0.4_DeepCavernsCommanderLocker", "1.0.0.4", "dc-flo", false)]
public sealed class d9x : fg
{
	// Token: 0x0600CA39 RID: 51769 RVA: 0x004794E4 File Offset: 0x004776E4
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("b3f2901e-b389-4ae7-9a4e-bc51e7a44da7"), A_1.n("dc-flo")).ao() as c5x;
			if (c5x != null && c5x.z != null)
			{
				c5x.z = null;
				c5x.ah();
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
