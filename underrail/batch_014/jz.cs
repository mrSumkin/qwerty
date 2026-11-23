using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules;

// Token: 0x02000B4D RID: 2893
[eiz("DCMFGJ")]
[Serializable]
public sealed class jz : cze, ISerializable
{
	// Token: 0x06004264 RID: 16996 RVA: 0x0019BBE8 File Offset: 0x00199DE8
	private jz(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() >= 462)
		{
			this.a = (A_0.GetValue("DCMFGJ:N", typeof(int?)) as int?);
		}
	}

	// Token: 0x06004265 RID: 16997 RVA: 0x0019BC28 File Offset: 0x00199E28
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("DCMFGJ:N", this.a);
	}

	// Token: 0x06004266 RID: 16998 RVA: 0x0019BC48 File Offset: 0x00199E48
	public int? b()
	{
		return this.a;
	}

	// Token: 0x06004267 RID: 16999 RVA: 0x0019BC50 File Offset: 0x00199E50
	public void a(int? A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06004268 RID: 17000 RVA: 0x0019BC5C File Offset: 0x00199E5C
	public jz()
	{
	}

	// Token: 0x06004269 RID: 17001 RVA: 0x0019BC64 File Offset: 0x00199E64
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		if (A_2 != null)
		{
			try
			{
				if ((int)A_2["tickCount"] % this.a() != 0)
				{
					return;
				}
			}
			catch
			{
			}
		}
		if (A_1 != null && A_1.Zone != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("global_TchortDefeated", new bool?(false)).Value)
			{
				c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
				if (c5x != null)
				{
					d60 d = A_1.Zone.a();
					if (d != null)
					{
						List<csd> list = new List<csd>();
						foreach (csd csd in A_1.Zone.Waypoints)
						{
							if (csd.Name != null && csd.Name.StartsWith("gaunt", StringComparison.OrdinalIgnoreCase))
							{
								list.Add(csd);
							}
						}
						if (list.Count > 0)
						{
							int num;
							if (this.a != null)
							{
								num = this.a.Value;
							}
							else
							{
								num = list.Count;
							}
							bu6 service = bpo.GetService<bu6>();
							if (service != null)
							{
								if (service.aq2() == GameDifficulty.Easy)
								{
									num = 1;
								}
								else if (service.aq2() == GameDifficulty.Hard)
								{
									num++;
								}
								else if (service.aq2() == GameDifficulty.Dominating)
								{
									num += 2;
								}
							}
							if (d.ab4(new string[]
							{
								"gaunt"
							}).Count < num)
							{
								for (int i = list.Count - 1; i >= 0; i--)
								{
									csd csd2 = list[i];
									if (csd2.Tile == null || aw1.a(null, csd2.Tile, false, null) || aw1.a(c5x, csd2.Tile) < 13.0)
									{
										list.RemoveAt(i);
									}
								}
								if (list.Count > 0)
								{
									csd a_ = list[cuo.a.Next(list.Count)];
									c5x c5x2 = vq.a("creatures\\Faceless\\FacelessGaunt", a_, false);
									if (c5x2 != null)
									{
										if (c5x2.h.b != null)
										{
											c5x2.h.b.aa().FactionId = asp.ch;
										}
										if (c5x2.t.b != null)
										{
											c5x2.t.b.y6()[ddq.bm] = true;
											c5x2.t.b.y6()[ddq.bo] = 5;
											c5x2.t.b.y6()[ddq.bn] = 40;
										}
										e3l e3l = c5x2.GetAspect<e3l>();
										if (e3l == null)
										{
											e3l = new e3l(c5x2);
											c5x2.SetAspect<e3l>(e3l);
										}
										e3l.a.Add("gaunt");
										e3l.a();
									}
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600426A RID: 17002 RVA: 0x0019BFE0 File Offset: 0x0019A1E0
	private int a()
	{
		bu6 service = bpo.GetService<bu6>();
		if (service != null)
		{
			switch (service.aq2())
			{
			case GameDifficulty.Easy:
				return 20;
			case GameDifficulty.Normal:
				return 10;
			case GameDifficulty.Hard:
				return 5;
			case GameDifficulty.Dominating:
				return 2;
			}
		}
		return 10;
	}

	// Token: 0x04001C25 RID: 7205
	private new int? a;
}
