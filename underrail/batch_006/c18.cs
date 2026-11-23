using System;
using TimelapseVertigo.Rules.Combat;

// Token: 0x020018F3 RID: 6387
public static class c18
{
	// Token: 0x0600879C RID: 34716 RVA: 0x00380898 File Offset: 0x0037EA98
	public static int a(cnm A_0)
	{
		if (A_0 != null)
		{
			return c18.a(A_0.b9() as coh);
		}
		return 1;
	}

	// Token: 0x0600879D RID: 34717 RVA: 0x003808B8 File Offset: 0x0037EAB8
	public static int a(coh A_0)
	{
		if (A_0 != null && A_0.Definition != null && A_0.Definition.a7() != null)
		{
			int? primitivePropertyValue = A_0.Definition.a7().GetPrimitivePropertyValue<int>("power", null);
			if (primitivePropertyValue != null)
			{
				return primitivePropertyValue.Value;
			}
		}
		return 1;
	}

	// Token: 0x0600879E RID: 34718 RVA: 0x0038091C File Offset: 0x0037EB1C
	public static a1q t(int A_0)
	{
		return new a1q(DamageType.Mechanical, 5 + Convert.ToInt32(8.0 * (double)A_0), 5 + Convert.ToInt32(15.0 * (double)A_0));
	}

	// Token: 0x0600879F RID: 34719 RVA: 0x0038094C File Offset: 0x0037EB4C
	public static a1q s(int A_0)
	{
		return new a1q(DamageType.Heat, 12 + Convert.ToInt32(8.0 * (double)A_0), 12 + Convert.ToInt32(12.0 * (double)A_0));
	}

	// Token: 0x060087A0 RID: 34720 RVA: 0x0038097C File Offset: 0x0037EB7C
	public static int j()
	{
		return 3;
	}

	// Token: 0x060087A1 RID: 34721 RVA: 0x00380980 File Offset: 0x0037EB80
	public static a1q r(int A_0)
	{
		return new a1q(DamageType.Heat, 5 + Convert.ToInt32(15.0 * (double)A_0), 5 + Convert.ToInt32(25.0 * (double)A_0));
	}

	// Token: 0x060087A2 RID: 34722 RVA: 0x003809B0 File Offset: 0x0037EBB0
	public static a1q q(int A_0)
	{
		return new a1q(DamageType.Mechanical, 10 + Convert.ToInt32(20.0 * (double)A_0), 10 + Convert.ToInt32(35.0 * (double)A_0));
	}

	// Token: 0x060087A3 RID: 34723 RVA: 0x003809E0 File Offset: 0x0037EBE0
	public static int i()
	{
		return 3;
	}

	// Token: 0x060087A4 RID: 34724 RVA: 0x003809E4 File Offset: 0x0037EBE4
	public static a1q p(int A_0)
	{
		return new a1q(DamageType.Heat, Convert.ToInt32(60.0 * (double)A_0), Convert.ToInt32(80.0 * (double)A_0));
	}

	// Token: 0x060087A5 RID: 34725 RVA: 0x00380A10 File Offset: 0x0037EC10
	public static a1q o(int A_0)
	{
		return new a1q(DamageType.Energy, Convert.ToInt32(60.0 * (double)A_0), Convert.ToInt32(80.0 * (double)A_0));
	}

	// Token: 0x060087A6 RID: 34726 RVA: 0x00380A3C File Offset: 0x0037EC3C
	public static int h()
	{
		return 2;
	}

	// Token: 0x060087A7 RID: 34727 RVA: 0x00380A40 File Offset: 0x0037EC40
	public static int g()
	{
		return 2;
	}

	// Token: 0x060087A8 RID: 34728 RVA: 0x00380A44 File Offset: 0x0037EC44
	public static a1q n(int A_0)
	{
		return new a1q(DamageType.Electricity, 30 + Convert.ToInt32(35.0 * (double)(A_0 - 1)), 45 + Convert.ToInt32(60.0 * (double)(A_0 - 1)));
	}

	// Token: 0x060087A9 RID: 34729 RVA: 0x00380A78 File Offset: 0x0037EC78
	public static int m(int A_0)
	{
		return (int)((double)c18.bb + c18.bc * (double)A_0);
	}

	// Token: 0x060087AA RID: 34730 RVA: 0x00380A8C File Offset: 0x0037EC8C
	public static a1q l(int A_0)
	{
		return new a1q(DamageType.Acid, 75 + Convert.ToInt32(35.0 * (double)A_0), 75 + Convert.ToInt32(60.0 * (double)A_0));
	}

	// Token: 0x060087AB RID: 34731 RVA: 0x00380ABC File Offset: 0x0037ECBC
	public static a1q k(int A_0)
	{
		return new a1q(DamageType.Acid, 100 + Convert.ToInt32(50.0 * (double)A_0), 100 + Convert.ToInt32(85.0 * (double)A_0));
	}

	// Token: 0x060087AC RID: 34732 RVA: 0x00380AEC File Offset: 0x0037ECEC
	public static a1q j(int A_0)
	{
		return new a1q(DamageType.Acid, 85 + Convert.ToInt32(40.0 * (double)A_0), 85 + Convert.ToInt32(70.0 * (double)A_0));
	}

	// Token: 0x060087AD RID: 34733 RVA: 0x00380B1C File Offset: 0x0037ED1C
	public static a1q i(int A_0)
	{
		return new a1q(DamageType.Cold, 40 + Convert.ToInt32(15.0 * (double)A_0), 40 + Convert.ToInt32(30.0 * (double)A_0));
	}

	// Token: 0x060087AE RID: 34734 RVA: 0x00380B4C File Offset: 0x0037ED4C
	public static int h(int A_0)
	{
		return 2 + A_0;
	}

	// Token: 0x060087AF RID: 34735 RVA: 0x00380B54 File Offset: 0x0037ED54
	public static a1q g(int A_0)
	{
		return new a1q(DamageType.Heat, 75 + Convert.ToInt32(30.0 * (double)A_0), 75 + Convert.ToInt32(60.0 * (double)A_0));
	}

	// Token: 0x060087B0 RID: 34736 RVA: 0x00380B84 File Offset: 0x0037ED84
	public static int f(int A_0)
	{
		return 3 + A_0;
	}

	// Token: 0x060087B1 RID: 34737 RVA: 0x00380B8C File Offset: 0x0037ED8C
	public static a1q f()
	{
		return new a1q(DamageType.Mechanical, 3, 5);
	}

	// Token: 0x060087B2 RID: 34738 RVA: 0x00380B98 File Offset: 0x0037ED98
	public static int e()
	{
		return 3;
	}

	// Token: 0x060087B3 RID: 34739 RVA: 0x00380B9C File Offset: 0x0037ED9C
	public static int c(efk A_0)
	{
		int num = as3.au;
		if (A_0 != null && A_0.Feats.Contains<ev>())
		{
			num -= ev.a;
		}
		return num * d0u.b;
	}

	// Token: 0x060087B4 RID: 34740 RVA: 0x00380BD4 File Offset: 0x0037EDD4
	public static int b(efk A_0)
	{
		return c18.a(A_0, as3.av);
	}

	// Token: 0x060087B5 RID: 34741 RVA: 0x00380BE4 File Offset: 0x0037EDE4
	public static int a(efk A_0, int A_1)
	{
		int num = A_1;
		if (A_0 != null && A_0.Feats.Contains<ev>())
		{
			num -= ev.b;
		}
		return num * d0u.b;
	}

	// Token: 0x060087B6 RID: 34742 RVA: 0x00380C18 File Offset: 0x0037EE18
	public static double a(efk A_0)
	{
		if (A_0 != null && A_0.Feats.Contains<dws>())
		{
			double num = dws.a;
			int num2 = A_0.Skills.Get<dei>().g();
			if (num2 > dws.b)
			{
				num += (double)((num2 - dws.b) / 10) * (dws.c + (double)A_0.GetSpecializationValue<ed8>(true) * ed8.a);
			}
			return num;
		}
		return 0.0;
	}

	// Token: 0x060087B7 RID: 34743 RVA: 0x00380C8C File Offset: 0x0037EE8C
	public static a1q e(int A_0)
	{
		return new a1q(DamageType.Heat, 10 + Convert.ToInt32(25 * A_0), 5 + Convert.ToInt32(45 * A_0));
	}

	// Token: 0x060087B8 RID: 34744 RVA: 0x00380CAC File Offset: 0x0037EEAC
	public static b1j d()
	{
		return new b1j(0.06, 0.03 + 0.03 * (double)c18.y);
	}

	// Token: 0x060087B9 RID: 34745 RVA: 0x00380CD8 File Offset: 0x0037EED8
	public static b1j c()
	{
		return new b1j(7.0, (double)(5 + 6 * c18.y));
	}

	// Token: 0x060087BA RID: 34746 RVA: 0x00380CF4 File Offset: 0x0037EEF4
	public static b1j b()
	{
		return new b1j(16.0, (double)(8 + 8 * c18.y));
	}

	// Token: 0x060087BB RID: 34747 RVA: 0x00380D10 File Offset: 0x0037EF10
	public static int a()
	{
		return 3;
	}

	// Token: 0x060087BC RID: 34748 RVA: 0x00380D14 File Offset: 0x0037EF14
	public static a1q a(efk A_0, int A_1, bool A_2 = false)
	{
		int num = 5 + 2 * A_1;
		int num2 = 5 + 6 * A_1;
		double num3 = 0.03 + 0.03 * (double)A_1;
		int num4 = (int)Math.Min((double)(8 + A_1 * 8), num3 * (double)A_0.Defense.q().zm());
		num += num4;
		num2 += num4;
		if (A_2)
		{
			num /= 3;
			num2 /= 3;
		}
		return new a1q(DamageType.Heat, num, num2);
	}

	// Token: 0x060087BD RID: 34749 RVA: 0x00380D84 File Offset: 0x0037EF84
	public static a1q d(int A_0)
	{
		return new a1q(DamageType.Bio, c18.z + c18.aa * A_0, c18.z + c18.ab * A_0);
	}

	// Token: 0x060087BE RID: 34750 RVA: 0x00380DA8 File Offset: 0x0037EFA8
	public static a1q c(int A_0)
	{
		return new a1q(DamageType.Heat, 10 + 3 * A_0, 10 + 6 * A_0);
	}

	// Token: 0x060087BF RID: 34751 RVA: 0x00380DBC File Offset: 0x0037EFBC
	public static a1q b(int A_0)
	{
		return new a1q(DamageType.Cold, c18.ad + c18.ae * A_0, c18.ad + c18.af * A_0);
	}

	// Token: 0x060087C0 RID: 34752 RVA: 0x00380DE0 File Offset: 0x0037EFE0
	public static a1q a(int A_0)
	{
		return new a1q(DamageType.Bio, c18.ah + c18.ai * A_0, c18.ah + c18.aj * A_0);
	}

	// Token: 0x060087C1 RID: 34753 RVA: 0x00380E04 File Offset: 0x0037F004
	public static a1q a(int A_0, bool A_1)
	{
		double num;
		if (A_1)
		{
			num = c18.ap;
		}
		else
		{
			num = 1.0;
		}
		return new a1q(DamageType.Bio, Convert.ToInt32((double)(c18.al + c18.am * A_0) * num), Convert.ToInt32((double)(c18.al + c18.an * A_0) * num));
	}

	// Token: 0x040034DF RID: 13535
	private const int a = 5;

	// Token: 0x040034E0 RID: 13536
	private const double b = 15.0;

	// Token: 0x040034E1 RID: 13537
	private const double c = 25.0;

	// Token: 0x040034E2 RID: 13538
	private const int d = 10;

	// Token: 0x040034E3 RID: 13539
	private const double e = 20.0;

	// Token: 0x040034E4 RID: 13540
	private const double f = 35.0;

	// Token: 0x040034E5 RID: 13541
	public static readonly double g = 0.4;

	// Token: 0x040034E6 RID: 13542
	public static readonly double h = 0.3;

	// Token: 0x040034E7 RID: 13543
	private const int i = 10;

	// Token: 0x040034E8 RID: 13544
	private const int j = 25;

	// Token: 0x040034E9 RID: 13545
	private const int k = 45;

	// Token: 0x040034EA RID: 13546
	private const int l = 5;

	// Token: 0x040034EB RID: 13547
	private const int m = 2;

	// Token: 0x040034EC RID: 13548
	private const int n = 6;

	// Token: 0x040034ED RID: 13549
	private const int o = 10;

	// Token: 0x040034EE RID: 13550
	private const int p = 3;

	// Token: 0x040034EF RID: 13551
	private const int q = 6;

	// Token: 0x040034F0 RID: 13552
	private const double r = 0.03;

	// Token: 0x040034F1 RID: 13553
	private const double s = 0.03;

	// Token: 0x040034F2 RID: 13554
	private const int t = 8;

	// Token: 0x040034F3 RID: 13555
	private const int u = 8;

	// Token: 0x040034F4 RID: 13556
	public static readonly double v = 0.5;

	// Token: 0x040034F5 RID: 13557
	public static readonly double w = 1.5;

	// Token: 0x040034F6 RID: 13558
	public static readonly int x = 3;

	// Token: 0x040034F7 RID: 13559
	public static readonly int y = 4;

	// Token: 0x040034F8 RID: 13560
	public static readonly int z = 5;

	// Token: 0x040034F9 RID: 13561
	public static readonly int aa = 5;

	// Token: 0x040034FA RID: 13562
	public static readonly int ab = 10;

	// Token: 0x040034FB RID: 13563
	public static readonly int ac = 10;

	// Token: 0x040034FC RID: 13564
	public static readonly int ad = 2;

	// Token: 0x040034FD RID: 13565
	public static readonly int ae = 1;

	// Token: 0x040034FE RID: 13566
	public static readonly int af = 3;

	// Token: 0x040034FF RID: 13567
	public static readonly int ag = 10;

	// Token: 0x04003500 RID: 13568
	public static readonly int ah = 6;

	// Token: 0x04003501 RID: 13569
	public static readonly int ai = 7;

	// Token: 0x04003502 RID: 13570
	public static readonly int aj = 13;

	// Token: 0x04003503 RID: 13571
	public static readonly int ak = 10;

	// Token: 0x04003504 RID: 13572
	public static readonly int al = 3;

	// Token: 0x04003505 RID: 13573
	public static readonly int am = 3;

	// Token: 0x04003506 RID: 13574
	public static readonly int an = 6;

	// Token: 0x04003507 RID: 13575
	public static readonly int ao = 10;

	// Token: 0x04003508 RID: 13576
	public static readonly double ap = 3.0;

	// Token: 0x04003509 RID: 13577
	public static readonly int aq = 4;

	// Token: 0x0400350A RID: 13578
	public static int ar = 3;

	// Token: 0x0400350B RID: 13579
	public static int @as = 7;

	// Token: 0x0400350C RID: 13580
	private const int at = 5;

	// Token: 0x0400350D RID: 13581
	private const double au = 8.0;

	// Token: 0x0400350E RID: 13582
	private const double av = 15.0;

	// Token: 0x0400350F RID: 13583
	private const int aw = 12;

	// Token: 0x04003510 RID: 13584
	private const double ax = 8.0;

	// Token: 0x04003511 RID: 13585
	private const double ay = 12.0;

	// Token: 0x04003512 RID: 13586
	public static readonly double az = 0.8;

	// Token: 0x04003513 RID: 13587
	public static readonly double a0 = 0.2;

	// Token: 0x04003514 RID: 13588
	public static readonly double a1 = 0.2;

	// Token: 0x04003515 RID: 13589
	public static readonly double a2 = 0.1;

	// Token: 0x04003516 RID: 13590
	public static readonly double a3 = 0.2;

	// Token: 0x04003517 RID: 13591
	public static readonly double a4 = 0.85;

	// Token: 0x04003518 RID: 13592
	public static readonly double a5 = 0.5;

	// Token: 0x04003519 RID: 13593
	private const int a6 = 10;

	// Token: 0x0400351A RID: 13594
	private const int a7 = 20;

	// Token: 0x0400351B RID: 13595
	private const int a8 = 35;

	// Token: 0x0400351C RID: 13596
	private const double a9 = 35.0;

	// Token: 0x0400351D RID: 13597
	private const double ba = 60.0;

	// Token: 0x0400351E RID: 13598
	private static readonly int bb = 2;

	// Token: 0x0400351F RID: 13599
	private static readonly double bc = 0.35;

	// Token: 0x04003520 RID: 13600
	private const int bd = 75;

	// Token: 0x04003521 RID: 13601
	private const double be = 35.0;

	// Token: 0x04003522 RID: 13602
	private const double bf = 60.0;

	// Token: 0x04003523 RID: 13603
	public static readonly int bg = 3;

	// Token: 0x04003524 RID: 13604
	private const int bh = 100;

	// Token: 0x04003525 RID: 13605
	private const double bi = 50.0;

	// Token: 0x04003526 RID: 13606
	private const double bj = 85.0;

	// Token: 0x04003527 RID: 13607
	public static readonly int bk = 3;

	// Token: 0x04003528 RID: 13608
	public static readonly int bl = 3;

	// Token: 0x04003529 RID: 13609
	private const int bm = 85;

	// Token: 0x0400352A RID: 13610
	private const double bn = 40.0;

	// Token: 0x0400352B RID: 13611
	private const double bo = 70.0;

	// Token: 0x0400352C RID: 13612
	public static readonly int bp = 3;

	// Token: 0x0400352D RID: 13613
	public static readonly int bq = 3;

	// Token: 0x0400352E RID: 13614
	private const int br = 40;

	// Token: 0x0400352F RID: 13615
	private const double bs = 15.0;

	// Token: 0x04003530 RID: 13616
	private const double bt = 30.0;

	// Token: 0x04003531 RID: 13617
	private const int bu = 2;

	// Token: 0x04003532 RID: 13618
	private const int bv = 1;

	// Token: 0x04003533 RID: 13619
	private const int bw = 75;

	// Token: 0x04003534 RID: 13620
	private const double bx = 30.0;

	// Token: 0x04003535 RID: 13621
	private const double by = 60.0;

	// Token: 0x04003536 RID: 13622
	private const int bz = 3;

	// Token: 0x04003537 RID: 13623
	private const int b0 = 1;

	// Token: 0x04003538 RID: 13624
	public static readonly int b1 = 5;

	// Token: 0x04003539 RID: 13625
	private const int b2 = 0;

	// Token: 0x0400353A RID: 13626
	private const double b3 = 60.0;

	// Token: 0x0400353B RID: 13627
	private const double b4 = 80.0;

	// Token: 0x0400353C RID: 13628
	private const int b5 = 0;

	// Token: 0x0400353D RID: 13629
	private const double b6 = 60.0;

	// Token: 0x0400353E RID: 13630
	private const double b7 = 80.0;

	// Token: 0x0400353F RID: 13631
	public const float b8 = 0.5f;

	// Token: 0x04003540 RID: 13632
	public const float b9 = 0.5f;

	// Token: 0x04003541 RID: 13633
	public const int ca = 3;

	// Token: 0x04003542 RID: 13634
	public const float cb = 0.2f;

	// Token: 0x04003543 RID: 13635
	public const float cc = 0.45f;

	// Token: 0x04003544 RID: 13636
	public const float cd = 0.4f;

	// Token: 0x04003545 RID: 13637
	public const float ce = 2f;

	// Token: 0x04003546 RID: 13638
	public const int cf = 5;

	// Token: 0x04003547 RID: 13639
	public const float cg = 1f;

	// Token: 0x04003548 RID: 13640
	public const float ch = 0.25f;

	// Token: 0x04003549 RID: 13641
	public const float ci = 0.5f;

	// Token: 0x0400354A RID: 13642
	public const int cj = 2;

	// Token: 0x0400354B RID: 13643
	public const int ck = 2;

	// Token: 0x0400354C RID: 13644
	public const int cl = 4;

	// Token: 0x0400354D RID: 13645
	public const float cm = 2f;

	// Token: 0x0400354E RID: 13646
	public const int cn = 5;

	// Token: 0x0400354F RID: 13647
	public const float co = 0.1f;

	// Token: 0x04003550 RID: 13648
	public const float cp = 0.1f;

	// Token: 0x04003551 RID: 13649
	public const float cq = 0.6f;

	// Token: 0x04003552 RID: 13650
	public const float cr = 1f;

	// Token: 0x04003553 RID: 13651
	public const int cs = 3;

	// Token: 0x04003554 RID: 13652
	public const float ct = 1f;

	// Token: 0x04003555 RID: 13653
	public const int cu = 3;

	// Token: 0x04003556 RID: 13654
	public const float cv = 0.4f;

	// Token: 0x04003557 RID: 13655
	public const float cw = 0.3f;

	// Token: 0x04003558 RID: 13656
	public const float cx = 0.3f;

	// Token: 0x04003559 RID: 13657
	public const int cy = 1;

	// Token: 0x0400355A RID: 13658
	public const int cz = 2;

	// Token: 0x0400355B RID: 13659
	public const float c0 = 0.5f;

	// Token: 0x0400355C RID: 13660
	public const float c1 = 0.5f;

	// Token: 0x0400355D RID: 13661
	public const int c2 = 3;
}
