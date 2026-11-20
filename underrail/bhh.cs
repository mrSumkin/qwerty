using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;

// Token: 0x02000A07 RID: 2567
[eiz("XPBLLEBJE")]
[Serializable]
public sealed class bhh : bdw, ISerializable
{
	// Token: 0x06003D32 RID: 15666 RVA: 0x0016C37C File Offset: 0x0016A57C
	private bhh(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003D33 RID: 15667 RVA: 0x0016C384 File Offset: 0x0016A584
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003D34 RID: 15668 RVA: 0x0016C388 File Offset: 0x0016A588
	public bhh()
	{
	}

	// Token: 0x06003D35 RID: 15669 RVA: 0x0016C394 File Offset: 0x0016A594
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (serviceOrThrow != null && c5x != null)
			{
				gx gx = new gx();
				aud aud = c5x.Area;
				if (gx != null && aud != null)
				{
					List<csd> list = new List<csd>();
					foreach (csd csd in Enumerable.ToList<csd>(A_0.Waypoints))
					{
						if (csd != null && csd.Name.StartsWith("aegis", StringComparison.OrdinalIgnoreCase))
						{
							Vector3 a_;
							HorizontalDirection horizontalDirection;
							new bt4(csd.Name).a(A_0, out aud, out a_, out horizontalDirection);
							ak1 ak = aud.a(a_.a());
							if (ak != null && !aw1.a(ak, false, null, l9.b))
							{
								list.Add(csd);
							}
						}
					}
					foreach (csd csd2 in list)
					{
						if (csd2 != null)
						{
							bh8.b(gx.a(csd2, new int?(10), "Aegis_Jetski", null, null, null, null, false, null, false)).b("briggs'sEscort");
						}
					}
				}
			}
		}
	}
}
