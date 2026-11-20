using System;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;
using TimelapseVertigo.Rules;

// Token: 0x02000A09 RID: 2569
[eiz("XPBLF12SA")]
[Serializable]
public sealed class cj2 : bdw, ISerializable
{
	// Token: 0x06003D3A RID: 15674 RVA: 0x0016C6E0 File Offset: 0x0016A8E0
	private cj2(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003D3B RID: 15675 RVA: 0x0016C6E8 File Offset: 0x0016A8E8
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003D3C RID: 15676 RVA: 0x0016C6EC File Offset: 0x0016A8EC
	public cj2()
	{
	}

	// Token: 0x06003D3D RID: 15677 RVA: 0x0016C6F4 File Offset: 0x0016A8F4
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow != null && serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_xpbl_sc_finishedScanningSuccessfully", new bool?(false)).Value && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_xpbl_f12_SpawnedSavages", new bool?(false)).Value && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_xpbl_d10_besekar_died", new bool?(false)).Value && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_xpbl_sormirbaren_king_dead", new bool?(false)).Value && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("faction_xpbl_sormirbaren_defeated", new bool?(false)).Value)
			{
				int num = 0;
				bool flag = false;
				aud aud = A_0.n("xpbl_f12");
				if (aud != null)
				{
					foreach (b0b b0b in Enumerable.ToList<b0b>(aud.Entities))
					{
						c5x c5x = (c5x)b0b;
						if (c5x != null && c5x.h.b != null && !c5x.h.b.aa().Dead && c5x.h.b.aa().FactionId == asp.f9)
						{
							num++;
						}
					}
					bool value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_xpbl_sc_turretsDisabled", new bool?(false)).Value;
					if (num < 3 || value)
					{
						if (num <= 0 || value)
						{
							flag = true;
						}
						if (flag)
						{
							c5x c5x2 = new ar7(new Guid("41d89a28-6622-4990-8fc2-1cdfdb20e97c"), aud).ao() as c5x;
							if (c5x2 != null)
							{
								ak1 ak = c5x2.Area.b(27, 27);
								ak1 ak2 = c5x2.Area.b(28, 27);
								if (ak != null && ak2 != null)
								{
									if (aw1.a(ak, false, null, l9.b) || aw1.a(ak2, false, null, l9.b))
									{
										flag = false;
										for (int i = 27; i >= 18; i--)
										{
											ak = c5x2.Area.b(27, i);
											ak2 = c5x2.Area.b(28, i);
											if (!aw1.a(ak, false, null, l9.b) && !aw1.a(ak2, false, null, l9.b))
											{
												flag = true;
												c5x2.Location = new Vector3((float)ak.Location.X, (float)ak.Location.Y, 0f);
												c5x2.ah();
												break;
											}
										}
									}
									if (flag)
									{
										c5x2.ae = new float?((float)1);
										c5x2.TileFormationModifiers = new bjp(new byte[]
										{
											1,
											18
										});
									}
								}
							}
						}
						foreach (csd csd in Enumerable.ToList<csd>(aud.Zone.Waypoints))
						{
							if (csd != null && csd.Name.Contains("spawn"))
							{
								if (!flag)
								{
									if (csd.Name.Contains("10") || csd.Name.Contains("11"))
									{
										break;
									}
									if (csd.Name.Contains("12"))
									{
										break;
									}
								}
								Vector3 a_;
								HorizontalDirection horizontalDirection;
								new bt4(csd.Name).a(aud.Zone, out aud, out a_, out horizontalDirection);
								ak1 ak3 = aud.a(a_.a());
								if (ak3 != null && !aw1.a(null, ak3, false, null))
								{
									this.a(csd);
								}
							}
						}
						serviceOrThrow.aqu().r()["loc_xpbl_f12_SpawnedSavages"] = true;
						bfq bfq = new bfq();
						bfq.a(bvl.a);
						bfq.a("xpbl_f12");
						bfq.a(new Guid?(new Guid("74729bc6-ea2e-44a3-9c8b-fb8520d03187")));
						bfq.b("horn");
						bfq.c("xpbl_SavageWarHorn");
						bfq.ym(null, null, null);
					}
				}
			}
		}
	}

	// Token: 0x06003D3E RID: 15678 RVA: 0x0016CB90 File Offset: 0x0016AD90
	private void a(csd A_0)
	{
		gx gx = new gx();
		if (gx != null)
		{
			bu6 service = bpo.GetService<bu6>();
			int num = int.Parse(Regex.Match(A_0.Name, "\\d+").Value);
			int num2 = 2;
			if (service != null)
			{
				num2 = (int)(service.aq2() + 1);
			}
			c5x c5x;
			if (num > num2 && num != 9)
			{
				c5x = gx.a(A_0, new int?(10), "Sormirbaren", null, null, null, null, false, null, false);
			}
			else
			{
				Random random = new Random();
				if (num == 9)
				{
					if (service.aq2() > GameDifficulty.Normal)
					{
						c5x = vq.a("creatures\\genericHumans\\xpbl\\savageShamanGreater", A_0, false);
					}
					else
					{
						c5x = vq.a("creatures\\generichumans\\xpbl\\savageShaman", A_0, false);
					}
					if (c5x != null && c5x.h.b != null)
					{
						if (c5x.h.b.am().Contains("svgsg"))
						{
							int num3 = random.Next(1, 4);
							c5x.h.b.a("xpbl_svgsg" + num3.ToString());
						}
						else
						{
							int num4 = random.Next(1, 3);
							c5x.h.b.a("xpbl_svgs" + num4.ToString());
						}
					}
				}
				else
				{
					c5x = vq.a(@is.a(true)[num - 1], A_0, false);
				}
			}
			if (c5x != null)
			{
				if (c5x.h.b != null && cuo.a.Next(0, 101) <= 50)
				{
					c5x = @is.a(c5x);
				}
				if (c5x.t.b != null)
				{
					c5x.t.b.y6()[ddq.ay] = new bt4("savage" + num.ToString() + "_guard");
					c5x.t.b.y6()[ddq.bs] = new exw(d6n.a, 0.0, true, null);
				}
			}
		}
	}
}
