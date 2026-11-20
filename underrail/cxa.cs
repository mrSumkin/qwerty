using System;
using System.Diagnostics;
using Microsoft.Xna.Framework;

// Token: 0x020020A3 RID: 8355
[bmq("1.2.0.16_Dc_La1_MoveSecurityMonitor", "1.2.0.16", "dc-la1", false)]
public sealed class cxa : fg
{
	// Token: 0x0600C7B9 RID: 51129 RVA: 0x00465EA8 File Offset: 0x004640A8
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			aud aud = A_1.n("dc-la1");
			if (aud != null)
			{
				c5x c5x = new ar7(new Guid("c7bc1e35-8e53-49bb-9de7-60c0d0afdde0"), aud).ao() as c5x;
				if (c5x != null && c5x.Location.X != 12f)
				{
					c5x.Location = new Vector3(12f, 23.2f, 1.65f);
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
