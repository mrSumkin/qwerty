using System;
using System.Diagnostics;
using Microsoft.Xna.Framework;

// Token: 0x020020BA RID: 8378
[bmq("1.2.0.0_Lup_a9_MoveContainer", "1.2.0.0", "lup-a9", false)]
public sealed class chl : fg
{
	// Token: 0x0600C7E0 RID: 51168 RVA: 0x00466B74 File Offset: 0x00464D74
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			aud aud = A_1.n("lup-a9");
			if (aud != null)
			{
				c5x c5x = new ar7(new Guid("4b03709f-e73b-4c8b-851e-faf96996a413"), aud).ao() as c5x;
				if (c5x != null)
				{
					c5x.Location = new Vector3(13f, 14f, 1f);
					c5x.ah();
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
