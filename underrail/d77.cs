using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.References;

// Token: 0x020009A8 RID: 2472
[eiz("LULUB")]
[Serializable]
public sealed class d77 : bdw, ISerializable
{
	// Token: 0x06003B9C RID: 15260 RVA: 0x00160CB0 File Offset: 0x0015EEB0
	private d77(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003B9D RID: 15261 RVA: 0x00160CB8 File Offset: 0x0015EEB8
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003B9E RID: 15262 RVA: 0x00160CBC File Offset: 0x0015EEBC
	public d77()
	{
	}

	// Token: 0x06003B9F RID: 15263 RVA: 0x00160CC8 File Offset: 0x0015EEC8
	public void av(c1a A_0, cyt A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && A_0 != null)
		{
			serviceOrThrow.aqu().ac();
			aud aud = A_0.n("lup-a8");
			if (aud != null)
			{
				List<string> classPropertyValue = serviceOrThrow.aqu().r().GetClassPropertyValue<List<string>>("loc_lup-a8prison_escapedPrisonerModels");
				if (classPropertyValue != null && classPropertyValue.Count > 0)
				{
					cnb cnb = new EntityAspectReference<cnb, bim>(aud, new Guid("ad508d4b-bdfd-492b-b12c-14f3852eed0d")).ao();
					if (cnb != null)
					{
						cnb.d(true);
					}
					bool flag = false;
					d02 service = bpo.GetService<d02>();
					if (service != null)
					{
						foreach (d4n d4n in service.ahl())
						{
							if (d4n.b != null && d4n.b.aa().FactionId == asp.by && d4n.b.aa().IsInControl && d4n.b.a8().Location.X >= 20f && d4n.b.a8().Location.X <= 28f && d4n.b.a8().Location.Y >= 1f && d4n.b.a8().Location.Y <= 16f)
							{
								flag = true;
								break;
							}
						}
					}
					if (flag)
					{
						int num = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("loc_lup-a8prison_prisonersKilledUpstairs", new int?(0)).Value;
						foreach (string arg in classPropertyValue)
						{
							num++;
							csd csd = aud.Zone.g("dead" + num.ToString());
							if (csd != null)
							{
								c5x c5x = new c5x();
								c5x.Size = new Vector3(1f, 1f, 0.2f);
								c5x.Location = csd.Location;
								c5x.IsGround = true;
								c5x.Layer = aju.x;
								c5x.VisualPriority = 2;
								c5x.SetAspect<cd0>(new cd0(c5x)
								{
									b = new Point(7, (int)csd.Direction),
									a = string.Format("Creatures\\{0}\\di", arg)
								});
								vq.a("floor\\bloodPuddle", aud.Zone, new bt4(csd.Name), false);
								aud.a(c5x);
							}
						}
						serviceOrThrow.aqu().r()["loc_lup-a8prison_prisonersKilledUpstairs"] = num;
						int num2 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("loc_lup-a8prison_prisonersDied", new int?(0)).Value;
						num2 += classPropertyValue.Count;
						serviceOrThrow.aqu().r()["loc_lup-a8prison_prisonersDied"] = num2;
					}
					else
					{
						int num3 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("loc_lup-a8prison_prisonersEscaped", new int?(0)).Value;
						num3 += classPropertyValue.Count;
						serviceOrThrow.aqu().r()["loc_lup-a8prison_prisonersEscaped"] = num3;
					}
					classPropertyValue.Clear();
				}
			}
		}
	}
}
