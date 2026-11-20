using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;

// Token: 0x02002112 RID: 8466
[bmq("1.1.3.0_Up_Lw_Tweaks", "1.1.3.0", "up-lw", false)]
public sealed class cga : fg
{
	// Token: 0x0600C86C RID: 51308 RVA: 0x0046A870 File Offset: 0x00468A70
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("db749364-e8be-413e-a66b-534ad3a40627"), A_1.n("up-lw1")).ao() as c5x;
			if (c5x != null)
			{
				c5x.TileFormationModifiers.s3(0);
				c5x.Location = new Vector3(17f, 10f, 0f);
				c5x.ah();
			}
			c5x c5x2 = new ar7(new Guid("0bcd9165-44df-4edb-b740-87716ac977b2"), A_1.n("up-lw1")).ao() as c5x;
			if (c5x2 != null)
			{
				c5x2.Location = new Vector3(16.3f, 10f, 0f);
				c5x2.Size = new Vector3(0.5f, 1f, 1f);
				c5x2.ah();
			}
			a1w a1w = Enumerable.FirstOrDefault<ya>(Enumerable.Where<ya>(A_1.n("up-lw1").Triggers, new Func<ya, bool>(cga.a.a.a))) as a1w;
			if (a1w != null)
			{
				aud aud = a1w.Area;
				a1w.o();
				a1w.Location = new Point(0, 10);
				a1w.Size = new esj(13, 20);
				aud.b(a1w);
			}
			return true;
		}
		catch (Exception ex)
		{
			Trace.WriteLine(ex.ToString());
		}
		return false;
	}

	// Token: 0x02002113 RID: 8467
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x0600C870 RID: 51312 RVA: 0x0046AA04 File Offset: 0x00468C04
		internal bool a(ya A_0)
		{
			return A_0.Id == new Guid("bcd0c9ac-65ff-47df-851e-717fc49e1aee");
		}

		// Token: 0x04004A00 RID: 18944
		public static readonly cga.a a = new cga.a();

		// Token: 0x04004A01 RID: 18945
		public static Func<ya, bool> b;
	}
}
