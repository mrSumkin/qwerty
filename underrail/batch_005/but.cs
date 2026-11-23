using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

// Token: 0x02000AE4 RID: 2788
[eiz("XPBLSSAJ")]
[Serializable]
public sealed class but : cze, ISerializable
{
	// Token: 0x060040E4 RID: 16612 RVA: 0x0018BCA8 File Offset: 0x00189EA8
	private but(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060040E5 RID: 16613 RVA: 0x0018BCB4 File Offset: 0x00189EB4
	public but()
	{
	}

	// Token: 0x060040E6 RID: 16614 RVA: 0x0018BCC0 File Offset: 0x00189EC0
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		try
		{
			c5x c5x = A_1 as c5x;
			if (c5x != null && c5x.h.b != null && c5x.Area != null && c5x.Zone != null && A_2 != null)
			{
				cwt cwt = A_2["attackResult"] as cwt;
				List<csk> list = A_2["damage"] as List<csk>;
				if (cwt != null && cwt.b)
				{
					if (list != null)
					{
						if (Enumerable.Sum<csk>(list, new Func<csk, int>(but.a.a.a)) > 10)
						{
							aex.a(c5x.Area, c5x.aj(), 40, 250, 1f, 4.25f, false, true);
							c5x.c().a("Xpbl_SpaceSnakeHit");
							goto IL_12B;
						}
					}
					aex.a(c5x.Area, c5x.aj(), 20, 250, 0.5f, 4.25f, false, true);
					c5x.c().a(Guid.NewGuid().ToString(), "Xpbl_SpaceSnakeHit", 0.7f, c9z.a, false, false);
				}
			}
			IL_12B:;
		}
		catch
		{
		}
	}

	// Token: 0x02000AE5 RID: 2789
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x060040E9 RID: 16617 RVA: 0x0018BE34 File Offset: 0x0018A034
		internal int a(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x04001C0B RID: 7179
		public static readonly but.a a = new but.a();

		// Token: 0x04001C0C RID: 7180
		public static Func<csk, int> b;
	}
}
