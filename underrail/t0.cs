using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

// Token: 0x02002092 RID: 8338
public abstract class t0 : fg
{
	// Token: 0x0600C79B RID: 51099 RVA: 0x00465150 File Offset: 0x00463350
	public virtual bool rh()
	{
		return false;
	}

	// Token: 0x0600C79C RID: 51100 RVA: 0x00465154 File Offset: 0x00463354
	protected t0(string A_0, int A_1)
	{
		this.a = A_0;
		this.b = A_1;
	}

	// Token: 0x0600C79D RID: 51101 RVA: 0x00465170 File Offset: 0x00463370
	public virtual bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			doq doq = doq.a(Path.Combine(d5x.q(), string.Format("{0}_l{1}", this.a, this.b)) + ".uzl");
			acu.a(A_1, doq);
			A_1.a(doq, 99, null);
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
				foreach (ya ya in aud.Triggers)
				{
					if (ya.Layer == 99)
					{
						ya.Layer = aju.x;
					}
				}
			}
			foreach (csd csd in A_1.Waypoints)
			{
				if (csd.Layer == 99)
				{
					csd.Layer = aju.x;
				}
			}
			foreach (ah7 ah in A_1.LanternDefinitions)
			{
				if (ah.Layer == 99)
				{
					ah.Layer = aju.x;
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

	// Token: 0x040049FC RID: 18940
	private string a;

	// Token: 0x040049FD RID: 18941
	private int b;
}
