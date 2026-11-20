using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;

// Token: 0x02000A0A RID: 2570
[eiz("XPBLLEARTADE")]
[Serializable]
public sealed class e8y : bdw, ISerializable
{
	// Token: 0x06003D3F RID: 15679 RVA: 0x0016CDB0 File Offset: 0x0016AFB0
	private e8y(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003D40 RID: 15680 RVA: 0x0016CDB8 File Offset: 0x0016AFB8
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003D41 RID: 15681 RVA: 0x0016CDBC File Offset: 0x0016AFBC
	public e8y()
	{
	}

	// Token: 0x06003D42 RID: 15682 RVA: 0x0016CDC4 File Offset: 0x0016AFC4
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
					List<csd> list2 = new List<csd>();
					foreach (csd csd in Enumerable.ToList<csd>(A_0.Waypoints))
					{
						if (csd != null && csd.Name.Contains("aegis"))
						{
							Vector3 a_;
							HorizontalDirection horizontalDirection;
							new bt4(csd.Name).a(A_0, out aud, out a_, out horizontalDirection);
							ak1 ak = aud.a(a_.a());
							if (ak != null)
							{
								if (csd.Name.StartsWith("jet_aegis") && aw1.a(new bt4(csd.Name), aud, l9.b))
								{
									list2.Add(csd);
								}
								else if (!aw1.a(null, ak, false, null))
								{
									list.Add(csd);
								}
							}
						}
					}
					foreach (csd csd2 in list)
					{
						if (csd2 != null)
						{
							bh8.b(gx.a(csd2, new int?(10), "Aegis", null, null, null, "support\\xpbl\\le_aegis", false, null, false)).b("loc_" + A_0.y8() + "_aegisSecTroopers");
						}
					}
					foreach (csd csd3 in list2)
					{
						if (csd3 != null)
						{
							c5x c5x2 = vq.a("object\\vehicles\\xpbl\\aegisPatroller", csd3, true);
							c5x2.b("loc_" + A_0.y8() + "_aegisJets");
							if (c5x2 != null)
							{
								c5x2.VisualDirection = csd3.Direction;
							}
						}
					}
				}
			}
		}
	}
}
