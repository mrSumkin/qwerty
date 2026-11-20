using System;
using System.Diagnostics;
using System.Linq;

// Token: 0x0200212D RID: 8493
[bmq("1.1.1.7_Xpbl_Cc-Dock2_CameraFix", "1.1.1.7", "xpbl_cc-dock2", false)]
public sealed class afe : fg
{
	// Token: 0x0600C8A6 RID: 51366 RVA: 0x0046CAFC File Offset: 0x0046ACFC
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			foreach (b0b b0b in Enumerable.ToList<b0b>(A_1.n("xpbl_cc-dock2").Entities))
			{
				c5x c5x = (c5x)b0b;
				if (c5x.y8() != null && c5x.y8() == "Security Camera" && c5x.p.b != null && c5x.p.b.a[0].a == "Objects\\Devices\\Camera2" && c5x.p.b.a[2].c != null)
				{
					c5x.p.b.a[2].c = null;
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
