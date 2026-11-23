using System;
using System.Collections.Generic;
using System.Linq;
using TimelapseVertigo.Generators.Items;

// Token: 0x0200080F RID: 2063
public abstract class q : el4
{
	// Token: 0x06003411 RID: 13329 RVA: 0x00142A28 File Offset: 0x00140C28
	protected override esj a3()
	{
		return new esj(3, 3);
	}

	// Token: 0x06003412 RID: 13330 RVA: 0x00142A34 File Offset: 0x00140C34
	public override string a4()
	{
		return "DB_PT" + this.a.ToString();
	}

	// Token: 0x06003413 RID: 13331 RVA: 0x00142A4C File Offset: 0x00140C4C
	public override string a5()
	{
		return "Dead Body " + this.a.ToString();
	}

	// Token: 0x06003414 RID: 13332 RVA: 0x00142A64 File Offset: 0x00140C64
	protected override bool a6()
	{
		return false;
	}

	// Token: 0x06003415 RID: 13333 RVA: 0x00142A68 File Offset: 0x00140C68
	protected override bool a7()
	{
		return false;
	}

	// Token: 0x06003416 RID: 13334 RVA: 0x00142A70 File Offset: 0x00140C70
	protected override TimeSpan? a8()
	{
		return null;
	}

	// Token: 0x06003417 RID: 13335 RVA: 0x00142A88 File Offset: 0x00140C88
	public override bool a9()
	{
		return true;
	}

	// Token: 0x06003418 RID: 13336 RVA: 0x00142A8C File Offset: 0x00140C8C
	public q(int A_0) : base(new string[]
	{
		ega.a,
		ega.g,
		ega.h,
		ega.e,
		ega.l
	})
	{
		this.a = A_0;
	}

	// Token: 0x06003419 RID: 13337 RVA: 0x00142ACC File Offset: 0x00140CCC
	public override void ov(cyt A_0, c1a A_1, bop A_2)
	{
		base.ov(A_0, A_1, A_2);
		d60 d = A_1.a();
		if (d != null)
		{
			c5x c5x = Enumerable.FirstOrDefault<b0b>(d.ab6(new string[]
			{
				"deadBody",
				base.c()
			})) as c5x;
			c5x a_ = Enumerable.FirstOrDefault<b0b>(d.ab6(new string[]
			{
				"blood",
				base.c()
			})) as c5x;
			if (c5x != null)
			{
				cd0 aspect = c5x.GetAspect<cd0>();
				if (aspect != null)
				{
					Random random = new Random();
					string text = this.a(this.a, random);
					aspect.b.Y = random.Next(0, 8);
					aspect.a = "Creatures\\" + text + "\\di";
					if (text.Contains("_f"))
					{
						c5x.q("Тело женщины");
					}
					a_ = d06.a(a_);
				}
				cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
				bfc bfc = serviceOrThrow.aqu().h();
				if (serviceOrThrow.aqu() != null && bfc != null)
				{
					ery aspect2 = c5x.GetAspect<ery>();
					if (aspect2 != null)
					{
						int a_2 = Math.Max(1, bfc.BaseLevel - 5);
						int a_3 = bfc.BaseLevel + 3;
						int a_4 = bfc.BaseLevel + 7;
						foreach (xs xs in aspect2.f().g())
						{
							if (xs.Generator != null)
							{
								xs.Generator.na(a_2);
								if ((xs.Generator is df8 && ((df8)xs.Generator).b() / (ItemRange)100 == ItemRange.MedicalDrugs) || (xs.Generator is a64 && ((a64)xs.Generator).c() is fv))
								{
									xs.Generator.nc(a_4);
								}
								else
								{
									xs.Generator.nc(a_3);
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600341A RID: 13338 RVA: 0x00142CF4 File Offset: 0x00140EF4
	private string a(int A_0, Random A_1)
	{
		List<string> list;
		switch (A_0)
		{
		case 2:
			list = new List<string>
			{
				"hu1",
				"hu_f1"
			};
			break;
		case 3:
			list = new List<string>
			{
				"rg1",
				"rg2",
				"rg_f1",
				"rg_f2"
			};
			break;
		case 4:
			list = new List<string>
			{
				"scavle1",
				"scavle2",
				"scavle3",
				"scavle_f1",
				"scavle_f2"
			};
			break;
		case 5:
			list = new List<string>
			{
				"blve1",
				"blve2",
				"blve_f1"
			};
			break;
		case 6:
			list = new List<string>
			{
				"cmd1",
				"cmd2",
				"cmd3",
				"cmd_f1"
			};
			break;
		case 7:
			list = new List<string>
			{
				"ag1",
				"ag2",
				"ag_f1",
				"ag_f2"
			};
			break;
		case 8:
			list = new List<string>
			{
				"pl_ri",
				"pl_f_ri"
			};
			break;
		case 9:
			list = new List<string>
			{
				"mt1",
				"mt2",
				"mt3",
				"mt_f1"
			};
			break;
		default:
			list = new List<string>
			{
				"punk1",
				"punk2",
				"punk_f1",
				"punk_f2",
				"drifter",
				"brw1",
				"brw2"
			};
			break;
		}
		return list[A_1.Next(0, list.Count)];
	}

	// Token: 0x04001B81 RID: 7041
	private new int a;
}
