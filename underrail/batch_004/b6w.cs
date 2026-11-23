using System;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.References;

// Token: 0x020009D1 RID: 2513
[eiz("RKLEA")]
[Serializable]
public sealed class b6w : bdw, ISerializable
{
	// Token: 0x06003C3F RID: 15423 RVA: 0x00163F70 File Offset: 0x00162170
	private b6w(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003C40 RID: 15424 RVA: 0x00163F78 File Offset: 0x00162178
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003C41 RID: 15425 RVA: 0x00163F7C File Offset: 0x0016217C
	public b6w()
	{
	}

	// Token: 0x06003C42 RID: 15426 RVA: 0x00163F88 File Offset: 0x00162188
	public void av(c1a A_0, cyt A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && A_0 != null)
		{
			serviceOrThrow.aqu().r()["HathorKingSituationResolved"] = true;
			aud aud = A_0.n("rkl2");
			if (aud != null)
			{
				c5x c5x = new ar7(new Guid("801f5586-0ffd-4b3c-9a56-7debcacc37a5"), aud).ao() as c5x;
				c5x c5x2 = new ar7(new Guid("47b0f5df-575e-4c8a-8ded-7dee424240a2"), aud).ao() as c5x;
				if (c5x != null)
				{
					a0l.a(c5x, "fightAncient", true);
				}
				if (c5x2 != null)
				{
					a0l.a(c5x2, "fightAlpha", true);
				}
				serviceOrThrow.aqu().ac();
				if (!serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_ch_beck_dead", new bool?(false)).Value)
				{
					csd csd = A_0.g("hunter1in");
					csd csd2 = A_0.g("hunter2in");
					if (csd != null)
					{
						vq.a("creature\\characters\\support\\ch_hunter1", csd, true);
					}
					if (csd2 != null)
					{
						vq.a("creature\\characters\\support\\ch_hunter2", csd2, true);
					}
				}
				cnb cnb = new EntityAspectReference<cnb, bim>(aud, new Guid("ca1d944e-3bb1-4ce3-8dad-59ebcff78131")).ao();
				cnb cnb2 = new EntityAspectReference<cnb, bim>(aud, new Guid("054110c0-7d2c-4669-82a8-0dd99cdc7b95")).ao();
				if (cnb != null)
				{
					cnb.d(true);
				}
				if (cnb2 != null)
				{
					cnb2.d(true);
				}
				if (serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_ch_sarine_captured", new bool?(false)).Value)
				{
					c5x c5x3 = new ar7(new Guid("ce0c147a-b0af-42ff-99f9-4d1c155bb665"), aud).ao() as c5x;
					c5x c5x4 = new ar7(new Guid("63c0cb7e-3bbb-41fc-a467-32933f07337e"), aud).ao() as c5x;
					if (c5x3 != null)
					{
						a0l.a(c5x3, "sarineDead", true);
					}
					if (c5x4 != null)
					{
						cnb cnb3 = c5x4.s.b as cnb;
						if (cnb3 != null)
						{
							cnb3.d(true);
						}
						d2b aspect = c5x4.GetAspect<d2b>();
						if (aspect != null)
						{
							aspect.e(false);
						}
					}
				}
				if (bpo.GetService<d02>() != null)
				{
					foreach (b0b b0b in Enumerable.ToList<b0b>(aud.Entities))
					{
						c5x c5x5 = (c5x)b0b;
						if (c5x5.h.b != null && c5x5.h.b.aa().FactionId != asp.a && !c5x5.h.b.aa().Passive && c5x5.Location.X < 30f)
						{
							c5x5.h.b.aa().a(null, null, false);
							if (!c5x5.h.b.aa().b(d8o.e))
							{
								Vector3 a_ = c5x5.h.b.a8().aj().a().a();
								if (c5x5.h.b.aa().b(d8o.i))
								{
									vq.a("floor\\SlimePuddle", aud.Zone, new bt4(aud.y8(), a_), false);
								}
								else
								{
									vq.a("floor\\bloodPuddle", aud.Zone, new bt4(aud.y8(), a_), false);
								}
							}
						}
					}
				}
			}
		}
	}
}
