using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules;

// Token: 0x02000B76 RID: 2934
[eiz("FOUPSJ")]
[Serializable]
public sealed class e4n : cze, ISerializable
{
	// Token: 0x06004314 RID: 17172 RVA: 0x001A3224 File Offset: 0x001A1424
	private e4n(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06004315 RID: 17173 RVA: 0x001A3230 File Offset: 0x001A1430
	public e4n()
	{
	}

	// Token: 0x06004316 RID: 17174 RVA: 0x001A323C File Offset: 0x001A143C
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && A_1 != null)
		{
			int num = (int)(2 + serviceOrThrow.aqu().ae());
			int num2;
			int num3;
			if (serviceOrThrow.aqu().ae() == GameDifficulty.Easy)
			{
				num2 = 3;
				num3 = 2;
			}
			else if (serviceOrThrow.aqu().ae() == GameDifficulty.Normal)
			{
				num2 = 2;
				num3 = 2;
			}
			else
			{
				num2 = 1;
				num3 = 1;
				num += 2;
			}
			if (serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quest_fo_turnOnPsiAmplifier", new bool?(false)).Value && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quest_fo_beastKilled", new bool?(false)).Value)
			{
				if (serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("loc_fo5_wavesDone", new int?(0)).Value < num)
				{
					int num4 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("loc_fo5_timeTillWave", new int?(d0u.b * 3)).Value;
					num4 -= d0u.b;
					serviceOrThrow.aqu().r()["loc_fo5_timeTillWave"] = num4;
					if (num4 <= 0)
					{
						int num5 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("loc_fo5_wavesDone", new int?(0)).Value + 1;
						serviceOrThrow.aqu().r()["loc_fo5_wavesDone"] = num5;
						serviceOrThrow.aqu().r()["loc_fo5_timeTillWave"] = d0u.b * (num2 + num5 * num3);
						this.a(num5, A_1, serviceOrThrow);
						return;
					}
				}
				else if (!serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_fo5_beastArrived", new bool?(false)).Value)
				{
					d02 service = bpo.GetService<d02>();
					if (service != null)
					{
						bool flag = false;
						using (List<d4n>.Enumerator enumerator = service.ahl().GetEnumerator())
						{
							while (enumerator.MoveNext())
							{
								if (enumerator.Current.b.aa().FactionId == asp.aw)
								{
									flag = true;
									break;
								}
							}
						}
						if (!flag && !dz6.e())
						{
							serviceOrThrow.aqu().r()["loc_fo5_beastArrived"] = true;
							serviceOrThrow.aqu().a(new bw0("crys5", new dov(), 1));
							bpo.GetServiceOrThrow<ps>().am3("Fo_BeastDies");
						}
					}
				}
			}
		}
	}

	// Token: 0x06004317 RID: 17175 RVA: 0x001A34F0 File Offset: 0x001A16F0
	private void a(int A_0, b0b A_1, cnk A_2)
	{
		new List<csd>();
		List<string> list = new List<string>
		{
			"bladeling1",
			"bladeling2",
			"bladeling3"
		};
		Random random = new Random();
		int num = (int)A_2.aqu().ae();
		int num2 = A_0 + num;
		int num3 = 0;
		for (int i = 1; i <= 30; i++)
		{
			csd csd = A_1.Zone.g("c" + i.ToString());
			if (csd != null && csd.Tile != null && !aw1.a(csd.Tile, false, null, l9.a))
			{
				c5x c5x = vq.a("creatures\\bladeling", csd, false);
				if (c5x != null && c5x.t.b != null)
				{
					c5x.t.b.y6()[ddq.bn] = 20;
					c5x.t.b.y6()[ddq.bo] = 10;
				}
				if (c5x != null && c5x.h.b != null)
				{
					c5x.h.b.a(list[random.Next(0, list.Count)]);
					if (A_2.aqu().ae() >= GameDifficulty.Dominating)
					{
						c5x.h.b.aa().StatusEffects.a(new uj(0.5f, 0f, 0.1f, 0, 0, 15, 4), false, false, false);
						c5x.h.b.aa().StatusEffects.a(new dd(0)
						{
							Stacks = aq0.b
						}, false, false, false);
					}
				}
				num3++;
				if (num3 >= num2)
				{
					break;
				}
			}
		}
	}
}
