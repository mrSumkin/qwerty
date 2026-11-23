using System;
using System.Diagnostics;
using System.IO;

// Token: 0x0200217A RID: 8570
[bmq("1.0.3.6_Cc18_AlwaysImport", "9.9.9.9", "cc18", false)]
public sealed class chy : fg
{
	// Token: 0x0600C93F RID: 51519 RVA: 0x00471AAC File Offset: 0x0046FCAC
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			doq a_ = doq.a(Path.Combine(d5x.q(), "cc18_L2_importDoors") + ".uzl");
			A_1.a(a_, aju.x, null);
			return true;
		}
		catch (Exception ex)
		{
			Trace.WriteLine(ex.ToString());
		}
		return false;
	}
}
