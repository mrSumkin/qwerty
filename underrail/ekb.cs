using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ouroboros.Common.Aspects;
using TimelapseVertigo.Rules;

// Token: 0x02000F82 RID: 3970
[eiz("FBTCEA")]
[Serializable]
public sealed class ekb : Aspect<c5x>, c98, chb
{
	// Token: 0x060050BD RID: 20669 RVA: 0x00245B1C File Offset: 0x00243D1C
	private ekb(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.f = A_0.GetInt32("FBTCEA:T");
		this.e = A_0.GetDouble("FBTCEA:C");
		this.g = A_0.GetBoolean("FBTCEA:E");
		if (ell.a() >= 316)
		{
			this.i = A_0.GetBoolean("FBTCEA:I");
		}
		di7.ReadList<string>("FBTCEA:I", ref this.h, A_0);
	}

	// Token: 0x060050BE RID: 20670 RVA: 0x00245BA8 File Offset: 0x00243DA8
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("FBTCEA:T", this.f);
		info.AddValue("FBTCEA:C", this.e);
		info.AddValue("FBTCEA:E", this.g);
		info.AddValue("FBTCEA:I", this.i);
		di7.WriteList<string>("FBTCEA:I", this.h, info);
	}

	// Token: 0x060050BF RID: 20671 RVA: 0x00245C14 File Offset: 0x00243E14
	public bool d()
	{
		return this.g;
	}

	// Token: 0x060050C0 RID: 20672 RVA: 0x00245C1C File Offset: 0x00243E1C
	public void b(bool A_0)
	{
		this.g = A_0;
	}

	// Token: 0x060050C1 RID: 20673 RVA: 0x00245C28 File Offset: 0x00243E28
	public int e()
	{
		return this.f;
	}

	// Token: 0x060050C2 RID: 20674 RVA: 0x00245C30 File Offset: 0x00243E30
	public List<string> b()
	{
		return this.h;
	}

	// Token: 0x060050C3 RID: 20675 RVA: 0x00245C38 File Offset: 0x00243E38
	public void a(List<string> A_0)
	{
		this.h = A_0;
	}

	// Token: 0x060050C4 RID: 20676 RVA: 0x00245C44 File Offset: 0x00243E44
	public ekb(c5x A_0) : base(A_0)
	{
		this.e = 0.0;
	}

	// Token: 0x060050C5 RID: 20677 RVA: 0x00245C70 File Offset: 0x00243E70
	public void r7(eds A_0)
	{
		if (!this.i)
		{
			this.i = true;
			this.e = (double)(d0u.b * 6);
		}
		if (this.g && !dz6.e())
		{
			if ((this.e -= A_0.b.TotalMilliseconds) <= 0.0)
			{
				this.e += (double)(d0u.b * ekb.d);
				this.a(false);
				return;
			}
		}
		else
		{
			this.e = (double)d0u.b;
		}
	}

	// Token: 0x060050C6 RID: 20678 RVA: 0x00245D08 File Offset: 0x00243F08
	public void c()
	{
		if (this.g && (this.e -= (double)d0u.b) <= 0.0)
		{
			this.e += (double)(d0u.b * ekb.d);
			this.a(false);
		}
	}

	// Token: 0x060050C7 RID: 20679 RVA: 0x00245D64 File Offset: 0x00243F64
	private void a(bool A_0 = false)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (c5x != null && c5x.h.b != null)
			{
				bool value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_dc_tchb_tentacleTrueDeathTime", new bool?(false)).Value;
				bool value2 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("global_TchortDefeated", new bool?(false)).Value;
				d60 d = base.a8().Zone.a();
				if (d != null)
				{
					List<b0b> list = d.ab4(new string[]
					{
						"tchortlingSurger"
					});
					HashSet<string> hashSet = new HashSet<string>();
					foreach (b0b b0b in list)
					{
						c5x c5x2 = (c5x)b0b;
						if (c5x2 != null && c5x2.t.b != null)
						{
							string classPropertyValue = c5x2.t.b.y6().GetClassPropertyValue<string>("TchortlingOriginWaypoint");
							if (!string.IsNullOrEmpty(classPropertyValue))
							{
								hashSet.Add(classPropertyValue);
								if (!value2)
								{
									c5x2.t.b.y6().RemoveProperty(ddq.ay);
									c5x2.t.b.y6().RemoveProperty(ddq.bg);
									c5x2.t.b.y6()[ddq.bo] = 5;
									c5x2.t.b.y6()[ddq.bn] = 40;
									c5x2.t.b.y6()[ddq.bm] = true;
								}
							}
						}
					}
					if (!value && !value2 && list.Count < this.a())
					{
						List<string> list2 = new List<string>(this.h);
						while (list2.Count > 0)
						{
							int index = cuo.a.Next(list2.Count);
							string text = list2[index];
							list2.RemoveAt(index);
							if (hashSet.Count >= this.h.Count || !hashSet.Contains(text))
							{
								csd csd = base.a8().Zone.g(text);
								if (csd != null && csd.Tile != null && !aw1.a(null, csd.Tile, false, null) && !this.a(c5x.t.b, csd.Tile))
								{
									c5x c5x3 = vq.a(ekb.c[cuo.a.Next(ekb.c.Length)], csd, false);
									if (c5x3 != null)
									{
										if (c5x3.t.b != null)
										{
											c5x3.t.b.y6()["TchortlingOriginWaypoint"] = text;
											c5x3.t.b.y6()[ddq.bo] = 5;
											c5x3.t.b.y6()[ddq.bn] = 40;
											c5x3.t.b.y6()[ddq.bm] = true;
										}
										e3l e3l = c5x3.GetAspect<e3l>();
										if (e3l == null)
										{
											e3l = new e3l(c5x3);
											c5x3.SetAspect<e3l>(e3l);
										}
										e3l.a.Add("tchortlingSurger");
										e3l.a();
										return;
									}
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060050C8 RID: 20680 RVA: 0x00246160 File Offset: 0x00244360
	private bool a(bm6 A_0, ak1 A_1)
	{
		return A_0 != null && A_0.ai() && A_0.a(A_1);
	}

	// Token: 0x060050C9 RID: 20681 RVA: 0x00246180 File Offset: 0x00244380
	private int a()
	{
		double num = 1.0;
		bu6 service = bpo.GetService<bu6>();
		if (service != null)
		{
			switch (service.aq2())
			{
			case GameDifficulty.Easy:
				num = 0.5;
				break;
			case GameDifficulty.Normal:
				num = 1.0;
				break;
			case GameDifficulty.Hard:
				num = 1.75;
				break;
			case GameDifficulty.Dominating:
				num = 2.5;
				break;
			}
		}
		return (int)Math.Ceiling((double)this.h.Count * num);
	}

	// Token: 0x04002119 RID: 8473
	private const string a = "tchortlingSurger";

	// Token: 0x0400211A RID: 8474
	private const string b = "TchortlingOriginWaypoint";

	// Token: 0x0400211B RID: 8475
	private static readonly string[] c = new string[]
	{
		"creatures\\TchortlingDevourer",
		"creatures\\TchortlingScanner",
		"creatures\\TchortlingSower"
	};

	// Token: 0x0400211C RID: 8476
	private static int d = 2;

	// Token: 0x0400211D RID: 8477
	private double e;

	// Token: 0x0400211E RID: 8478
	private int f;

	// Token: 0x0400211F RID: 8479
	private bool g = true;

	// Token: 0x04002120 RID: 8480
	private List<string> h = new List<string>();

	// Token: 0x04002121 RID: 8481
	private bool i;
}
