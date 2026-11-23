using System;
using System.Diagnostics;

// Token: 0x020020C0 RID: 8384
[bmq("1.1.5.0_LemurianBoxCloseSoundFix", "1.1.5.0", "*", true)]
public sealed class cpw : fg
{
	// Token: 0x0600C7EB RID: 51179 RVA: 0x0046710C File Offset: 0x0046530C
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			if (dk2.b("xpbl") && A_1.y8().StartsWith("xpbl"))
			{
				foreach (aud aud in A_1.Areas)
				{
					foreach (b0b b0b in aud.Entities)
					{
						c5x c5x = (c5x)b0b;
						if (c5x.p.b != null && c5x.p.b.a[0] != null && c5x.p.b.a[0].a == "Objects\\Furniture\\xpbl_LemuriaBox")
						{
							c7j c7j = c5x.GetAspect<bim>() as c7j;
							if (c7j != null && c7j.k() == "ChestOpen")
							{
								c7j.d("ChestClose");
							}
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
