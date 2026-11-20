using System;
using System.Diagnostics;

// Token: 0x02002176 RID: 8566
[bmq("1.0.4.11_SormirbarenBallistaNameChange", "1.0.4.11", "*", true)]
public sealed class ui : fg
{
	// Token: 0x0600C937 RID: 51511 RVA: 0x0047163C File Offset: 0x0046F83C
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			foreach (aud aud in A_1.Areas)
			{
				foreach (b0b b0b in aud.Entities)
				{
					c5x c5x = (c5x)b0b;
					if (c5x.Layer > 0 && c5x.h.b != null && c5x.h.b.am().StartsWith("xpbl_svbl"))
					{
						if (!c5x.y8().Contains("Pilkæster"))
						{
							c5x.q("Sørmirbæren Pilkæster");
						}
						if (!c5x.h.b.aa().Name.Contains("Pilkæster"))
						{
							c5x.h.b.aa().Name = "Sørmirbæren Pilkæster";
						}
					}
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
