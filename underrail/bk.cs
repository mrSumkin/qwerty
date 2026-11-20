using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02000B91 RID: 2961
[eiz("TSPPAW")]
[Serializable]
public sealed class bk : cze, ISerializable
{
	// Token: 0x06004374 RID: 17268 RVA: 0x001A63BC File Offset: 0x001A45BC
	private bk(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06004375 RID: 17269 RVA: 0x001A63C8 File Offset: 0x001A45C8
	public bk()
	{
	}

	// Token: 0x06004376 RID: 17270 RVA: 0x001A63D4 File Offset: 0x001A45D4
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null)
		{
			aud aud = serviceOrThrow.aqu().v().b().Area;
			if (aud != null)
			{
				foreach (csd csd in Enumerable.ToList<csd>(aud.Zone.Waypoints))
				{
					if (csd != null && csd.Name.Equals("spawn_pseudoPlayer"))
					{
						c5x c5x = vq.a("creature\\characters\\xpbl\\Cruzer", csd, false);
						if (c5x != null && c5x.h.b != null)
						{
							c5x.h.b.aa().FactionId = asp.a3;
						}
						dtb dtb = new dtb();
						dtb dtb2 = dtb;
						dtb2.a(dtb2.kh() | m7.b);
						dtb.ad().Add(new bm3(5000));
						List<auv> list = dtb.ad();
						dve dve = new dve();
						dve.a(asp.@as);
						dve.a(new Guid?(c5x.qe()));
						list.Add(new a4s(dve, new ar7(c5x), null, null));
						aud.Zone.ActionManager.g9(dtb, atp.a);
					}
				}
			}
		}
	}
}
