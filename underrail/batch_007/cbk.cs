using System;
using System.Diagnostics;

// Token: 0x020021F6 RID: 8694
[bmq("1.0.0.2_RaiderLeaderLocker", "1.0.0.2", "cv14", false)]
public sealed class cbk : fg
{
	// Token: 0x0600CA45 RID: 51781 RVA: 0x004799D8 File Offset: 0x00477BD8
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("b0c9fa2e-e433-4885-ab14-fa56dc5d0bb5"), A_1.n("cv14")).ao() as c5x;
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
