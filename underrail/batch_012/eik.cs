using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

// Token: 0x020009BC RID: 2492
[eiz("LUCBCAP")]
[Serializable]
public sealed class eik : bdw, ISerializable
{
	// Token: 0x06003BED RID: 15341 RVA: 0x00162730 File Offset: 0x00160930
	private eik(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003BEE RID: 15342 RVA: 0x00162738 File Offset: 0x00160938
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003BEF RID: 15343 RVA: 0x0016273C File Offset: 0x0016093C
	public eik()
	{
	}

	// Token: 0x06003BF0 RID: 15344 RVA: 0x00162748 File Offset: 0x00160948
	public void av(c1a A_0, cyt A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && A_0 != null)
		{
			serviceOrThrow.aqu().ac();
			aud aud = A_0.n("lu-b26x");
			if (aud != null)
			{
				c5x c5x = new ar7(new Guid("316de200-fd86-452b-9e0a-17ecfac6d487"), aud).ao() as c5x;
				c5x c5x2 = new ar7(new Guid("8b99691b-ad4e-47ae-ab7d-8cded47516da"), aud).ao() as c5x;
				c5x c5x3 = new ar7(new Guid("45bc7a5c-c5d7-4434-bbb5-ed2f897c8397"), aud).ao() as c5x;
				ya ya = Enumerable.FirstOrDefault<ya>(Enumerable.Where<ya>(aud.Triggers, new Func<ya, bool>(eik.a.a.a)));
				if (c5x != null)
				{
					c5x.w();
					c5x.an();
				}
				if (c5x2 != null)
				{
					c5x2.w();
					c5x2.an();
				}
				if (c5x3 != null)
				{
					c5x3.w();
					c5x3.an();
				}
				foreach (d4n d4n in Enumerable.ToList<d4n>(bpo.GetService<d02>().ahl()))
				{
					if (d4n.b != null && d4n.b.a8() != null && d4n.b.a8().j == cgy.b && d4n.b.aa().FactionId == asp.c8)
					{
						d4n.b.a8().w();
						d4n.b.a8().an();
					}
				}
				if (ya != null)
				{
					ya.o();
				}
			}
		}
	}

	// Token: 0x020009BD RID: 2493
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x06003BF3 RID: 15347 RVA: 0x0016293C File Offset: 0x00160B3C
		internal bool a(ya A_0)
		{
			return A_0.Name == "BanditsTerritory";
		}

		// Token: 0x04001B94 RID: 7060
		public static readonly eik.a a = new eik.a();

		// Token: 0x04001B95 RID: 7061
		public static Func<ya, bool> b;
	}
}
