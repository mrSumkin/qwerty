using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;

// Token: 0x0200096C RID: 2412
[eiz("DCMF")]
[Serializable]
public sealed class d7k : bdw, ISerializable
{
	// Token: 0x06003AAA RID: 15018 RVA: 0x0015BAAC File Offset: 0x00159CAC
	private d7k(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003AAB RID: 15019 RVA: 0x0015BAB4 File Offset: 0x00159CB4
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003AAC RID: 15020 RVA: 0x0015BAB8 File Offset: 0x00159CB8
	public d7k()
	{
	}

	// Token: 0x06003AAD RID: 15021 RVA: 0x0015BAC4 File Offset: 0x00159CC4
	public void av(c1a A_0, cyt A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && A_0 != null)
		{
			bool value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("dc_mushroomHeartDestroyed", new bool?(false)).Value;
			bool value2 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("dc_mushroomForestAreaDead_" + A_0.y8(), new bool?(false)).Value;
			if (value && !value2)
			{
				serviceOrThrow.aqu().r()["dc_mushroomForestAreaDead_" + A_0.y8()] = true;
				foreach (aud aud in A_0.Areas)
				{
					if (aud.y8() == "dc-f4")
					{
						c5x c5x = new ar7(new Guid("c9ce76f6-d428-42a5-ba12-0542f374e226"), aud).ao() as c5x;
						c5x c5x2 = new ar7(new Guid("46e8e9dc-d07a-48e5-9044-1251b1e2e52a"), aud).ao() as c5x;
						if (c5x != null && c5x.o.b != null)
						{
							c5x.o.b.b = new Point(1, 0);
							c5x.q("Пролезть");
							bim bim = new bim(c5x);
							bim.a(new List<HorizontalDirection>
							{
								HorizontalDirection.East
							});
							bim.s().Add(new e68
							{
								Destination = new c2w("dc-fs5", "FromUp")
							});
							c5x.SetAspect<bim>(bim);
						}
						if (c5x2 != null)
						{
							c5x2.w();
							c5x2.an();
						}
					}
					foreach (b0b b0b in aud.Entities)
					{
						c5x c5x3 = (c5x)b0b;
						if (c5x3.h.b != null && c5x3.h.b.am() == bln.e8)
						{
							c5x3.h.b.a(null, false);
						}
						else
						{
							etz etz = c5x3.o.b as etz;
							if (etz != null && etz.a == "Objects\\Natural\\BioTurretPlatform")
							{
								if (etz.b.Y == 0)
								{
									etz.b = new Point(0, 2);
									etz.c(0);
								}
								else if (etz.b.Y == 1)
								{
									etz.b = new Point(0, 3);
									etz.c(0);
								}
							}
						}
					}
				}
			}
		}
	}
}
