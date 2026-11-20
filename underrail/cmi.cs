using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02000A9A RID: 2714
[eiz("LUDWRLPJ")]
[Serializable]
public sealed class cmi : cze, ISerializable
{
	// Token: 0x06003F97 RID: 16279 RVA: 0x001821E4 File Offset: 0x001803E4
	private cmi(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06003F98 RID: 16280 RVA: 0x001821F0 File Offset: 0x001803F0
	public cmi()
	{
	}

	// Token: 0x06003F99 RID: 16281 RVA: 0x001821FC File Offset: 0x001803FC
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		d02 service = bpo.GetService<d02>();
		if (serviceOrThrow.aqu() != null && service != null)
		{
			bool flag = false;
			foreach (d4n d4n in service.ahl())
			{
				if (d4n.b != null && d4n.b.aa().FactionId == asp.by && !d4n.b.aa().Dead)
				{
					flag = true;
					break;
				}
			}
			foreach (d4n d4n2 in Enumerable.ToList<d4n>(service.ahl()))
			{
				if (d4n2.b != null && d4n2.b.a8() != null && !d4n2.b.aa().Dead && (d4n2.b.aa().FactionId == asp.b7 || d4n2.b.aa().FactionId == asp.b8))
				{
					c5x c5x = d4n2.b.a8();
					if (c5x.Location.X < 6f || c5x.Location.Y < 12f || c5x.Location.X > 15f || c5x.Location.Y > 21f)
					{
						if (flag)
						{
							d4n2.b.aa().a(null, null, false);
						}
						else
						{
							c5x.w();
							c5x.an();
							x6 x = new x6();
							x.a("loc_lup-a8prison_prisonersEscaped");
							x.ym(null, null, null);
						}
					}
				}
			}
		}
	}
}
