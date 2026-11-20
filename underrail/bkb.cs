using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

// Token: 0x02000A19 RID: 2585
[eiz("XPBLE3UMHL")]
[Serializable]
public sealed class bkb : bdw, ISerializable
{
	// Token: 0x06003D86 RID: 15750 RVA: 0x00170B58 File Offset: 0x0016ED58
	private bkb(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003D87 RID: 15751 RVA: 0x00170B60 File Offset: 0x0016ED60
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003D88 RID: 15752 RVA: 0x00170B64 File Offset: 0x0016ED64
	public bkb()
	{
	}

	// Token: 0x06003D89 RID: 15753 RVA: 0x00170B70 File Offset: 0x0016ED70
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			aud aud = A_0.n("xpbl_e3_u");
			if (serviceOrThrow != null && serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_xpbl_e3_manhole_opened", new bool?(false)).Value)
			{
				bzm bzm = new bzm();
				if (bzm != null)
				{
					bzm.a(true);
					bzm.a("RustyLight");
					bzm.ym(null, null, null);
				}
				c5x c5x = new ar7(new Guid("9d17581c-0910-4255-9f2c-c5864dbb2b43"), aud).ao() as c5x;
				if (c5x != null)
				{
					bb2 bb = c5x.GetAspect<bim>() as bb2;
					if (bb != null)
					{
						bb.a(true);
					}
				}
				ya ya = Enumerable.FirstOrDefault<ya>(Enumerable.Where<ya>(aud.Triggers, new Func<ya, bool>(bkb.a.a.a)));
				if (ya != null)
				{
					ya.o();
				}
			}
		}
	}

	// Token: 0x02000A1A RID: 2586
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x06003D8C RID: 15756 RVA: 0x00170C84 File Offset: 0x0016EE84
		internal bool a(ya A_0)
		{
			return A_0.Name == "ManholeNarration";
		}

		// Token: 0x04001BA1 RID: 7073
		public static readonly bkb.a a = new bkb.a();

		// Token: 0x04001BA2 RID: 7074
		public static Func<ya, bool> b;
	}
}
