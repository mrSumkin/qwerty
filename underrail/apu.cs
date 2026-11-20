using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Lightning;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02000ABD RID: 2749
[eiz("XPBLSKMCTJ")]
[Serializable]
public sealed class apu : cze, ISerializable
{
	// Token: 0x06004023 RID: 16419 RVA: 0x001858FC File Offset: 0x00183AFC
	private apu(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06004024 RID: 16420 RVA: 0x00185908 File Offset: 0x00183B08
	public apu()
	{
	}

	// Token: 0x06004025 RID: 16421 RVA: 0x00185914 File Offset: 0x00183B14
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			c5x c5x = A_1 as c5x;
			if (c5x != null)
			{
				object obj = null;
				if (A_2 != null)
				{
					A_2.TryGetValue("tickCount", out obj);
				}
				int num = (obj is int) ? ((int)obj) : 0;
				bool value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("savageKingGhostSpawned", new bool?(false)).Value;
				if (value)
				{
					c5x.RemoveAspect<dmu>();
					c5x.RemoveAspect<dm>();
					return;
				}
				if (num >= 20)
				{
					if (value)
					{
						return;
					}
					Vector3 a_ = c5x.Location;
					using (List<ak1>.Enumerator enumerator = c5x.l.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							if (aw1.a(enumerator.Current, false, null, l9.a))
							{
								ak1 ak = Enumerable.FirstOrDefault<ak1>(aw1.a(c5x, null));
								if (ak != null)
								{
									a_ = ak.Location.a();
									break;
								}
								break;
							}
						}
					}
					c5x.RemoveAspect<dmu>();
					c5x.RemoveAspect<dm>();
					serviceOrThrow.aqu().r()["savageKingGhostSpawned"] = true;
					c5x c5x2 = vq.a("Creature\\Critters\\Xpbl\\SpaceDustKing", c5x.Zone, new bt4(c5x.Area.y8(), a_), false);
					if (c5x2 != null && c5x2.h.b != null)
					{
						new ah7("VoidUnlight", null)
						{
							Light = new ae8(Color.White, 0f, LightType.Decrement),
							LightFadeRate = 0.018f,
							Range = 6f,
							Layer = 1
						}.g().be(c5x2);
						b6j a_2 = new b6j(new ar7(c5x2), "VoidUnlight", new float?(0f), 0.2f, 0.0002f, false);
						c5x2.Zone.ActionManager.g9(a_2, atp.a);
						c5x2.VisualDirection = c5x.VisualDirection;
						c5x2.h.b.aa().StatusEffects.a(new cyf(0), false, false, false);
						c5x2.ae = new float?(0f);
						if (eh5.a(cwy.a))
						{
							ad6 ad = new ad6(c5x2);
							ad.a(dz6.a(0.0015));
							c5x.Zone.ActionManager.g9(ad, atp.a);
						}
						else
						{
							ad6 ad2 = new ad6(c5x2);
							ad2.c(0.05000000074505806);
							ad2.a(dz6.a(ad2.d() / 666.0));
							c5x.Zone.ActionManager.g9(ad2, atp.a);
							c5x2.h.b.aa().EtherealBase = true;
							c5x2.h.b.aa().bl();
						}
						awx awx = new awx();
						awx.a(m7.b | m7.k);
						awx.a(false);
						awx.ad().Add(new e4t(c5x2.h.b, CharacterState.Custom1, dz6.b(125), 0, null, 1));
						c5x2.i.b.b(awx, atp.a);
						dz6.a(awx);
						aex.b(c5x2.Area, c5x2.aj(), 300, 500, 2f, 4.25f, true, true);
						c5x2.c().a("Xpbl_SpaceSnakeSpawn");
						return;
					}
				}
				else
				{
					if (num < 20 && num >= 3)
					{
						dmu dmu = c5x.GetAspect<dmu>();
						if (dmu == null)
						{
							dmu = new dmu(c5x);
							c5x.SetAspect<dmu>(dmu);
						}
						dmu.a((double)num / 17.0);
						return;
					}
					c5x.RemoveAspect<dmu>();
				}
			}
		}
	}

	// Token: 0x04001BEB RID: 7147
	private new static readonly int a = 15;
}
