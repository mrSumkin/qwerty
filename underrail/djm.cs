using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;
using TimelapseVertigo.Rules;

// Token: 0x02000AF8 RID: 2808
[eiz("XPBLL12SSPJ")]
[Serializable]
public sealed class djm : cze, ISerializable
{
	// Token: 0x06004129 RID: 16681 RVA: 0x0018DB1C File Offset: 0x0018BD1C
	private djm(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600412A RID: 16682 RVA: 0x0018DB28 File Offset: 0x0018BD28
	public djm()
	{
	}

	// Token: 0x0600412B RID: 16683 RVA: 0x0018DB34 File Offset: 0x0018BD34
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			aud aud = serviceOrThrow.aqu().v().b().Area;
			if (!serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_xpbl_j12_sormirbarenCleared", new bool?(false)).Value && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_xpbl_sormirbaren_fireChieftain_dead", new bool?(false)).Value)
			{
				bu6 service = bpo.GetService<bu6>();
				gx gx = new gx();
				Random random = new Random();
				List<string> list = @is.a(true);
				int num = 0;
				int num2 = 8;
				int num3 = 0;
				if (service != null)
				{
					if (service.aq2() == GameDifficulty.Easy)
					{
						num2 = 6;
					}
					else if (service.aq2() == GameDifficulty.Hard)
					{
						num2 = 10;
						num3 = 15;
					}
					else if (service.aq2() >= GameDifficulty.Dominating)
					{
						num2 = 10;
						num3 = 25;
					}
				}
				foreach (csd csd in Enumerable.ToList<csd>(Enumerable.OrderBy<csd, string>(aud.Zone.Waypoints, new Func<csd, string>(djm.a.a.a))))
				{
					if (num >= num2)
					{
						break;
					}
					if (csd != null && csd.Name.StartsWith("savage") && csd.Name.EndsWith("nostlh"))
					{
						Vector3 a_;
						HorizontalDirection horizontalDirection;
						new bt4(csd.Name).a(aud.Zone, out aud, out a_, out horizontalDirection);
						ak1 ak = aud.a(a_.a());
						if (ak != null && !aw1.a(null, ak, false, null))
						{
							c5x c5x;
							if (random.Next(0, 101) > num3)
							{
								c5x = gx.a(csd, new int?(10), "Sormirbaren", null, null, null, null, false, null, false);
							}
							else
							{
								c5x = vq.a(list[num], csd, false);
							}
							if (c5x != null && c5x.t.b != null)
							{
								c5x.t.b.y6()[ddq.ay] = new bt4("savage" + csd.Name.Substring(6, 1) + "_guard");
							}
							num++;
						}
					}
				}
				serviceOrThrow.aqu().a(new bw0("xpbl_j12", new dy7(), 1));
				serviceOrThrow.aqu().b(new ey3());
				serviceOrThrow.aqu().r()["loc_xpbl_l12_sormirbarenAttacked"] = true;
			}
		}
	}

	// Token: 0x02000AF9 RID: 2809
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x0600412E RID: 16686 RVA: 0x0018DE2C File Offset: 0x0018C02C
		internal string a(csd A_0)
		{
			return A_0.Name;
		}

		// Token: 0x04001C12 RID: 7186
		public static readonly djm.a a = new djm.a();

		// Token: 0x04001C13 RID: 7187
		public static Func<csd, string> b;
	}
}
