using System;
using System.Diagnostics;

// Token: 0x02002173 RID: 8563
[bmq("1.1.0.5_Rc1LocalCharacterActorEntityAspectDialogPopupFix", "1.1.0.5", "rc1", false)]
public sealed class c14 : fg
{
	// Token: 0x0600C930 RID: 51504 RVA: 0x00471478 File Offset: 0x0046F678
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			foreach (aud aud in A_1.Areas)
			{
				foreach (b0b b0b in aud.Entities)
				{
					bn5 aspect = ((c5x)b0b).GetAspect<bn5>();
					if (aspect != null && !aspect.e())
					{
						aspect.b(true);
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
