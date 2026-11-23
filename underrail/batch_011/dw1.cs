using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

// Token: 0x0200218F RID: 8591
[bmq("1.0.3.0_Dc_Fs_Chomper", "9.9.9.9", "dc-fs5", false)]
public sealed class dw1 : fg
{
	// Token: 0x0600C971 RID: 51569 RVA: 0x00473344 File Offset: 0x00471544
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			doq a_ = doq.a(Path.Combine(d5x.q(), "dc-fs5_l2_AlwaysImported") + ".uzl");
			A_1.a(a_, 99, null);
			foreach (aud aud in A_1.Areas)
			{
				foreach (b0b b0b in aud.Entities)
				{
					c5x c5x = (c5x)b0b;
					if (c5x.Layer == 99)
					{
						bool flag = false;
						using (List<ak1>.Enumerator enumerator3 = c5x.l.GetEnumerator())
						{
							while (enumerator3.MoveNext())
							{
								if (enumerator3.Current.a((long)((ulong)dm9.a)))
								{
									flag = true;
									break;
								}
							}
						}
						if (flag)
						{
							c5x.a(dm9.a);
						}
						c5x.Layer = aju.x;
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
