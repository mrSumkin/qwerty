using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules;

// Token: 0x02000B94 RID: 2964
[eiz("LURAFMAJ")]
[Serializable]
public sealed class cwq : cze, ISerializable
{
	// Token: 0x0600437E RID: 17278 RVA: 0x001A68B0 File Offset: 0x001A4AB0
	private cwq(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600437F RID: 17279 RVA: 0x001A68BC File Offset: 0x001A4ABC
	public cwq()
	{
	}

	// Token: 0x06004380 RID: 17280 RVA: 0x001A68C8 File Offset: 0x001A4AC8
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		aud aud = null;
		if (A_0 != null)
		{
			aud = A_0.Area;
		}
		else if (A_1 != null)
		{
			aud = A_1.Area;
		}
		if (aud != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null)
			{
				bool flag = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_lu_raf_machineInvasionStarted", new bool?(false)).Value;
				bool value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_lu_raf_cameFromVent", new bool?(false)).Value;
				bool value2 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_lu_raf_machineInvasionEnded", new bool?(false)).Value;
				int num = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("loc_lu_raf_machineInvasionWavesDone", new int?(0)).Value;
				int num2 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("loc_lu_raf_turnsTillNextWave", new int?(0)).Value;
				int value3 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("loc_lu_raf_machinesKilled", new int?(0)).Value;
				int value4 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("loc_lu_raf_machinesFailedSpawning", new int?(0)).Value;
				bool flag2 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_lu_raf_allMachinesKilled", new bool?(false)).Value;
				bool value5 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("lu-raf_hackedConsole", new bool?(false)).Value;
				if (value && !flag)
				{
					flag = true;
					serviceOrThrow.aqu().r()["loc_lu_raf_machineInvasionStarted"] = flag;
					num2 = 12;
					serviceOrThrow.aqu().r()["loc_lu_raf_turnsTillNextWave"] = num2;
				}
				if (value2 && !flag2 && value3 >= 25 - value4)
				{
					flag2 = true;
					serviceOrThrow.aqu().r()["loc_lu_raf_allMachinesKilled"] = flag2;
					axh aspect = (new ar7(new Guid("72fe5195-2c9a-431b-a976-b9e0981d85d4"), aud).ao() as c5x).GetAspect<axh>();
					if (aspect != null)
					{
						aspect.a(null, false, null);
					}
				}
				if (flag && !value2 && !value5)
				{
					if (--num2 <= 0)
					{
						serviceOrThrow.aqu().r()["loc_lu_raf_machineInvasionWavesDone"] = ++num;
						bu6 serviceOrThrow2 = bpo.GetServiceOrThrow<bu6>();
						List<string> list = new List<string>();
						switch (serviceOrThrow2.aq2())
						{
						default:
							list.Add("PlasmaSentry");
							break;
						case GameDifficulty.Hard:
							list.Add("PlasmaSentry");
							list.Add("PlasmaSentry");
							list.Add("ThreadBot");
							break;
						case GameDifficulty.Dominating:
							list.Add("PlasmaSentry");
							list.Add("ThreadBot");
							break;
						}
						List<string> list2 = new List<string>();
						GameDifficulty gameDifficulty = serviceOrThrow2.aq2();
						if (gameDifficulty <= GameDifficulty.Hard || gameDifficulty != GameDifficulty.Dominating)
						{
							list2.Add("WheeledBot1");
						}
						else
						{
							list2.Add("WheeledBot1");
							list2.Add("PlasmaSentry");
						}
						List<string> a_ = new List<string>
						{
							"SuicideBot"
						};
						if (num == 1)
						{
							b6r b6r = new b6r();
							b6r.b(aud.y8());
							b6r.b(new Guid("e01ad73d-d02a-45b6-9d4f-9a436f211b1e"));
							b6r.a(new Guid("566ecca8-26ca-4943-8c52-185d72294768"));
							b6r.a(bbo.b);
							b6r.ym(A_0, A_1, null);
							this.a(a_, aud, "w1b1", "1");
							this.a(list2, aud, "w1b2", "2");
							this.a(list, aud, "w1b3", "3");
							this.a(list, aud, "w1b4", "4");
							this.a(list, aud, "w1b5", "5");
							num2 = this.a(5);
						}
						else if (num == 2)
						{
							b6r b6r2 = new b6r();
							b6r2.b(aud.y8());
							b6r2.b(new Guid("89d5d569-f56c-43ca-ba93-5d0f2d231fe6"));
							b6r2.a(new Guid("f6b13a03-2e4b-45d3-94bf-e3e0f4f88f8d"));
							b6r2.a(bbo.b);
							b6r2.ym(A_0, A_1, null);
							this.a(a_, aud, "w2b1", "1");
							this.a(a_, aud, "w2b2", "2");
							this.a(list, aud, "w2b3", "3");
							this.a(list, aud, "w2b4", "4");
							this.a(list2, aud, "w2b4", "6");
							num2 = this.a(3);
						}
						else if (num == 3)
						{
							b6r b6r3 = new b6r();
							b6r3.b(aud.y8());
							b6r3.b(new Guid("c0e791ff-c6f5-4597-9002-777625c6b154"));
							b6r3.a(new Guid("53e1a339-2984-47b6-9bbf-395dd7b1d3db"));
							b6r3.a(bbo.b);
							b6r3.ym(A_0, A_1, null);
							b6r b6r4 = new b6r();
							b6r4.b(aud.y8());
							b6r4.b(new Guid("b4afd57e-5544-450c-a118-cff788da0e8c"));
							b6r4.a(new Guid("6eb2be89-dce6-4ff1-a524-f8212e34ad08"));
							b6r4.a(bbo.b);
							b6r4.ym(A_0, A_1, null);
							this.a(a_, aud, "w3b1", "6");
							this.a(list, aud, "w3b2", "2");
							this.a(list, aud, "w3b3", "3");
							this.a(list, aud, "w3b4", "4");
							this.a(list2, aud, "w3b5", "5");
							this.a(list2, aud, "w3b6", "6");
							this.a(a_, aud, "w3b1d2", "1");
							this.a(a_, aud, "w3b2d2", "4");
							this.a(list2, aud, "w3b3d2", "5");
							num2 = this.a(6);
						}
						else if (num == 4)
						{
							b6r b6r5 = new b6r();
							b6r5.b(aud.y8());
							b6r5.b(new Guid("ed506b58-5395-41cf-a77d-59b11f874ae0"));
							b6r5.a(new Guid("d9eac7b5-7c53-4fec-b861-73b5373d5563"));
							b6r5.a(bbo.b);
							b6r5.ym(A_0, A_1, null);
							this.a(list, aud, "w4b1", "1");
							this.a(list, aud, "w4b2", "2");
							this.a(a_, aud, "w4b3", "3");
							this.a(list, aud, "w4b4", "4");
							this.a(list2, aud, "w4b5", "5");
							this.a(list2, aud, "w4b6", "6");
						}
						if (num >= 4)
						{
							serviceOrThrow.aqu().r()["loc_lu_raf_machineInvasionEnded"] = true;
						}
					}
					serviceOrThrow.aqu().r()["loc_lu_raf_turnsTillNextWave"] = num2;
				}
			}
		}
	}

	// Token: 0x06004381 RID: 17281 RVA: 0x001A6FD8 File Offset: 0x001A51D8
	private int a(int A_0)
	{
		int num = A_0;
		bu6 serviceOrThrow = bpo.GetServiceOrThrow<bu6>();
		if (serviceOrThrow.aq2() == GameDifficulty.Dominating)
		{
			num -= 2;
		}
		else if (serviceOrThrow.aq2() == GameDifficulty.Hard)
		{
			num--;
		}
		return Math.Max(2, num);
	}

	// Token: 0x06004382 RID: 17282 RVA: 0x001A701C File Offset: 0x001A521C
	private void a(List<string> A_0, aud A_1, string A_2, string A_3)
	{
		string str = A_0[cuo.a.Next(A_0.Count)];
		List<string> list = new List<string>();
		string item = "pe" + A_3;
		string item2 = "ps" + A_3;
		csd a_ = A_1.Zone.g(A_2);
		list.Add(item2);
		list.Add(item);
		c5x c5x = vq.a("creatures\\machines\\" + str, a_, false);
		if (c5x != null)
		{
			if (c5x.h.b != null)
			{
				c5x.h.b.aa().FactionId = asp.b9;
				List<cze> list2 = c5x.h.b.ay();
				x6 x = new x6();
				x.a("loc_lu_raf_machinesKilled");
				list2.Add(x);
			}
			if (c5x.t.b != null)
			{
				c5x.t.b.y6()[ddq.l] = 1000;
				c5x.t.b.y6()[ddq.n] = false;
				c5x.t.b.y6()[ddq.k] = list;
			}
			a6p aspect = c5x.GetAspect<a6p>();
			if (aspect != null)
			{
				if (aspect.d() == null)
				{
					aspect.a(new List<string>());
				}
				if (!aspect.d().Contains("-jobs"))
				{
					aspect.d().Add("-jobs");
					return;
				}
			}
		}
		else
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null)
			{
				int value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("loc_lu_raf_machinesFailedSpawning", new int?(0)).Value;
				serviceOrThrow.aqu().r()["loc_lu_raf_machinesFailedSpawning"] = value + 1;
			}
		}
	}

	// Token: 0x04001C43 RID: 7235
	private new const int a = 4;
}
