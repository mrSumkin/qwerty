using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

// Token: 0x020021A0 RID: 8608
[bmq("1.0.1.5_Rc_Shop_CleanupLayer", "9.9.9.9", "rc_shop", false)]
public sealed class chw : fg
{
	// Token: 0x0600C994 RID: 51604 RVA: 0x00474A10 File Offset: 0x00472C10
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			doq a_ = doq.a(Path.Combine(d5x.q(), "rc_shop_l2") + ".uzl");
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
