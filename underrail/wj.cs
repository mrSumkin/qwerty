using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Common.Settings;

// Token: 0x0200068A RID: 1674
public sealed class wj
{
	// Token: 0x06002AEF RID: 10991 RVA: 0x000F59C4 File Offset: 0x000F3BC4
	public bool c()
	{
		return this.d == UiSize.Classic;
	}

	// Token: 0x06002AF0 RID: 10992 RVA: 0x000F59D0 File Offset: 0x000F3BD0
	public static UiSize b()
	{
		return bpo.GetServiceOrThrow<cnk>().aq1().b().e();
	}

	// Token: 0x06002AF1 RID: 10993 RVA: 0x000F59E8 File Offset: 0x000F3BE8
	public static wj a()
	{
		return wj.a(wj.b());
	}

	// Token: 0x06002AF2 RID: 10994 RVA: 0x000F59F8 File Offset: 0x000F3BF8
	public static wj a(UiSize A_0)
	{
		wj wj;
		if (wj.a != null && wj.a.TryGetValue(A_0, out wj))
		{
			return wj;
		}
		wj = new wj();
		wj.d = A_0;
		if (A_0 == UiSize.Classic)
		{
			wj.ac = new esj(700, 15);
		}
		else if (A_0 == UiSize.Huge)
		{
			wj.e = "h";
			wj.f = "gui\\ui_h_gen1";
			wj.p = 2;
			wj.n = new esj(89, 89);
			wj.h = 2;
			wj.i = 7;
			wj.j = 0.8f;
			wj.k = 1f;
			wj.l = 2;
			wj.m = 1;
			wj.o = new esj(66, 66);
			wj.g = 4;
			wj.q = new Vector2(12f, 12f);
			wj.r = egg.au;
			wj.s = egg.au;
			wj.t = new esj(38, 86);
			wj.u = new Point(337, 442);
			wj.v = new esj(23, 42);
			wj.w = new Vector2(8f, 55f);
			wj.x = new Vector2(267f, 0f);
			wj.y = new esj(66, 66);
			wj.z = 3;
			wj.aa = new Point(332, 682);
			wj.ab = new esj(109, 18);
			wj.ac = new esj(1400, 18);
			wj.ad = new esj(650, 60);
			wj.ae = egg.k;
			wj.af = 11;
			wj.ag = egg.i;
			wj.ah = egg.i;
			wj.ai = new Point(20, 20);
			wj.aj = new Rectangle(1432, 1509, 65, 99);
			wj.ak = new Rectangle(1497, 1509, 65, 99);
			wj.al = new esj(500, 140);
			wj.am = new esj(69, 1439);
			wj.an = new Rectangle(374, 0, 82, 24);
			wj.ao = new Rectangle(374, 24, 82, 66);
			wj.ap = new Rectangle(374, 354, 82, 66);
			wj.aq = new Rectangle(374, 222, 41, 66);
			wj.ar = new Rectangle(415, 222, 41, 66);
			wj.@as = 458;
			wj.at = 1;
			wj.au = 71;
			wj.av = 6;
			wj.aw = 20;
			wj.ax = new Tuple<int, int>(3, 5);
			wj.ay = new esj(39, 41);
			wj.az = new Point(375, 526);
			wj.a0 = wj.ay;
			wj.a1 = new Point(252, 703);
			wj.a2 = 10;
			wj.a3 = new Rectangle(332, 769, 50, 54);
			wj.a4 = 1500;
			wj.a5 = new Point(336, 852);
			wj.a6 = new esj(40, 88);
			wj.a7 = new Point(0, 852);
			wj.a8 = new esj(112, 90);
			wj.a9 = new Point(376, 852);
			wj.ba = new esj(40, 45);
			wj.bb = new Point(75, 10);
			wj.bc = new Point(1632, 0);
			wj.bd = new esj(32, 32);
			wj.be = new Point(1344, 0);
			wj.bf = new esj(48, 48);
			wj.bg = new Point(291, 1783);
			wj.bh = new esj(38, 38);
			wj.bi = 20;
			wj.bj = new Point(291, 1821);
			wj.bk = new esj(38, 38);
			wj.bl = new Point(1863, 78);
			wj.bm = new esj(39, 39);
			wj.bn = new Point(199, 1138);
			wj.bo = new esj(27, 45);
			wj.bp = new Point(197, 1360);
			wj.bq = new esj(45, 27);
			wj.br = 3;
			wj.bs = new Point(1, 787);
			wj.bt = new esj(109, 21);
			wj.bu = new Point(1, 1443);
			wj.bv = 120;
			wj.bw = 41;
			wj.bx = new esj(96, 96);
			wj.by = new Point(1, 1685);
			wj.bz = new Point(1, 1247);
			wj.b0 = new esj(50, 50);
			wj.b1 = new esj(44, 42);
			wj.b2 = new esj(89, 89);
			wj.b3 = 25;
			wj.b4 = 0;
			wj.b5 = egg.a1;
			wj.b6 = new Point(883, 528);
			wj.b7 = new esj(96, 96);
			wj.b8 = new Point(912, 144);
			wj.b9 = new esj(48, 48);
			wj.ca = new Point(1488, 144);
			wj.cb = new esj(48, 48);
			wj.cc = new Point(1171, 528);
			wj.cd = new esj(96, 96);
			wj.ce = egg.a2;
			wj.cf = 15;
			wj.cg = new esj(39, 39);
			wj.ch = new Point(1824, 0);
			wj.ci = new esj(37, 39);
			wj.ck = new esj(375, 900);
			wj.cl = new Point(105, 5);
			wj.cq = new Point(485, 1443);
			wj.cm = new esj(75, 75);
			wj.cn = 2;
			wj.co = new Point(572, 1682);
			wj.cp = new esj(111, 111);
			wj.cr = new Point(485, 1595);
			wj.cs = new esj(85, 85);
			wj.ct = new Point(1297, 1538);
			wj.cu = new esj(71, 71);
			wj.cv = 1500;
			wj.cw = 1000;
			wj.cx = 20;
			wj.cy = new Point(15, 51);
			wj.cz = new Point(1145, 1585);
			wj.c0 = new esj(50, 50);
			wj.c1 = 1;
			wj.c2 = new esj(240, 50);
			wj.c5 = egg.a2;
			wj.c3 = new Point(841, 1795);
			wj.c4 = new esj(70, 70);
			wj.c6 = new Point(1488, 288);
			wj.c7 = new esj(48, 48);
			wj.c8 = 2;
			wj.c9 = new Point(912, 1188);
			wj.da = new esj(77, 77);
			wj.db = 3;
			wj.dc = new Point(1728, 192);
			wj.dd = new esj(32, 32);
			wj.de = egg.ay;
			wj.df = 40;
			wj.dg = 10;
			wj.dh = egg.ay;
			wj.di = egg.a2;
			wj.dj = new esj(8, 8);
			wj.dk = new esj(8, 4);
			wj.dl = new esj(200, 40);
			wj.dm = egg.a2;
			wj.@do = -6;
			wj.dn = egg.be;
			wj.dp = egg.x;
			wj.dq = new Vector2(1.65f, 1.4f);
			wj.dr = new esj(830, 680);
			wj.ds = 10;
			wj.dt = 64;
			wj.du = 150;
			wj.dv = new esj(200, 40);
			wj.dw = new Point(1370, 1387);
			wj.dx = new esj(60, 60);
			wj.dy = new Rectangle(1829, 1666, 66, 66);
			wj.dz = new Point(1488, 288);
			wj.d0 = new esj(48, 48);
			wj.d1 = 1500;
			wj.d2 = 1000;
			wj.d3 = 15;
			wj.d4 = egg.a2;
			wj.d5 = new Point(1728, 192);
			wj.d6 = new esj(32, 32);
			wj.d7 = new Point(485, 1767);
			wj.d8 = new esj(75, 75);
			wj.d9 = 2;
			wj.ea = 400;
			wj.eb = new esj(85, 85);
			wj.ec = new Point(1790, 921);
			wj.ed = new Point(1790, 1093);
			wj.ee = egg.ay;
			wj.ef = new Point(1897, 1447);
			wj.eg = new esj(50, 50);
			wj.ek = new Point(331, 737);
			wj.el = new esj(25, 31);
			wj.em = egg.a5;
			wj.en = egg.a4;
			wj.eo = egg.be;
			wj.ep = 45;
			wj.eq = 18;
			wj.er = new esj(85, 48);
			wj.es = new Point(1507, 1119);
			wj.et = new esj(106, 100);
			wj.eu = egg.au;
			wj.ev = egg.at;
			wj.ew = new esj(500, 366);
			wj.ex = new esj(900, 820);
			wj.ey = new Point(1, 1899);
			wj.ez = new esj(76, 76);
			wj.e0 = egg.a2;
			wj.e1 = new Point(50, 125);
			wj.e2 = new Point(120, 120);
			wj.e3 = new Point(1508, 1784);
			wj.e4 = new esj(43, 25);
			wj.e5 = new Point(884, 868);
			wj.e6 = new esj(43, 25);
			wj.e7 = new Point(1508, 1859);
			wj.e8 = new esj(43, 16);
			wj.e9 = new Point(884, 943);
			wj.fa = new esj(43, 16);
			wj.fb = 50;
			wj.fc = egg.a2;
			wj.fd = new Point(99, 1124);
			wj.fe = new esj(21, 25);
			wj.ff = new esj(10, 10);
			wj.fg = new Point(1600, 1942);
			wj.fh = new esj(48, 48);
			wj.fi = new Point(1552, 1942);
			wj.fj = new esj(48, 48);
			wj.fk = new Point(1504, 1942);
			wj.fl = new esj(48, 48);
			wj.fm = new Point(1632, 0);
			wj.fn = new esj(32, 32);
			wj.fo = egg.bd;
			wj.fp = new Point(10, 8);
			wj.fr = 56;
			wj.fq = 1500;
			wj.fs = new Point(282, 1124);
			wj.ft = new esj(50, 50);
			wj.fu = new esj(1700, 1041);
			wj.fv = new esj(40, 40);
			wj.fw = new esj(320, 50);
			wj.fx = new esj(3, 3);
			wj.fy = 8;
			wj.fz = egg.e;
			wj.f0 = 10;
			wj.f3 = new esj(240, 50);
			wj.f4 = 7;
			wj.f5 = egg.d;
			wj.f6 = 15;
			wj.f2 = 2;
			wj.f9 = new esj(800, 70);
			wj.ga = egg.l;
			wj.gb = new Point(30, 11);
			wj.gc = egg.j;
			wj.gd = new Point(30, 10);
			wj.ge = egg.e;
			wj.gf = new esj(800, 55);
			wj.gg = egg.bg;
			wj.gh = egg.h;
			wj.gi = egg.f;
			wj.gj = egg.h;
			wj.gk = 43;
			wj.gl = 20;
			wj.gm = egg.f;
			wj.gn = 10;
			wj.go = egg.h;
			wj.gp = 76;
			wj.gq = 20;
			wj.gr = 5;
			wj.gs = 43;
			wj.gt = 20;
			wj.gu = egg.e;
			wj.gv = 10;
			wj.gw = new Point(1432, 1387);
			wj.gx = new esj(60, 60);
			wj.gy = new Point(1145, 1387);
			wj.gz = new esj(36, 36);
			wj.g0 = new Point(1647, 1387);
			wj.g1 = new esj(60, 25);
			wj.g2 = new Point(1, 1124);
			wj.g3 = new esj(32, 32);
			wj.g4 = new Vector2(1.75f, 1.75f);
			wj.g5 = egg.f;
			wj.g6 = 10;
			wj.g7 = new esj(1000, 852);
			wj.g8 = egg.bd;
			wj.g9 = new esj(222, 418);
			wj.ha = 50;
			wj.hb = egg.m;
			wj.hc = egg.h;
			wj.hd = new Point(1, 1);
			wj.he = new esj(200, 200);
			wj.hf = 0;
			wj.hg = new esj(200, 155);
			wj.hi = new esj(240, 50);
			wj.hh = egg.a5;
			wj.hj = 30;
			wj.hk = 30;
			wj.hl = 30;
			wj.hm = 15;
			wj.hn = 800;
			wj.ho = 300;
			wj.hp = 425;
			wj.hq = 25;
			wj.hu = 70;
			wj.hr = 35;
			wj.hs = 40;
			wj.ht = 880;
			wj.hv = new esj(450, 45);
			wj.hw = egg.g;
			wj.hx = 20;
			wj.hy = 15;
			wj.hz = 10;
			wj.h0 = egg.j;
			wj.h1 = 65;
			wj.h2 = egg.bh;
			wj.h3 = 45;
			wj.h4 = 66;
			wj.h5 = 924;
			wj.h6 = 10;
			wj.h7 = new esj(800, 132);
			wj.h8 = new esj(200, 50);
			wj.h9 = egg.k;
			wj.ia = egg.g;
			wj.ib = egg.e;
			wj.ic = egg.a5;
			wj.id = 1;
			wj.ig = new Point(1432, 1610);
			wj.@if = new esj(109, 18);
			wj.ie = new esj(14, 33);
			wj.ih = new esj(800, 120);
			wj.ij = egg.a2;
			wj.ii = 10;
			wj.ik = 40;
			wj.il = new Point(1632, 192);
			wj.im = new esj(32, 32);
			wj.@in = 1050;
			wj.io = 1000;
			wj.ip = new esj(512, 512);
			wj.iq = new esj(512, 512);
			wj.ir = new Vector2(1.8f, 1.4f);
			wj.@is = new Vector2(1.7f, 2.18f);
			wj.it = new Point(1273, 818);
			wj.iu = new esj(71, 71);
			wj.iv = 15;
			wj.iw = 2f;
			wj.ix = 1360;
			wj.iy = new esj(32, 40);
			wj.iz = new Point(647, 1795);
			wj.i0 = new Point(743, 1795);
			wj.i1 = egg.i;
			wj.i2 = egg.g;
		}
		else if (A_0 == UiSize.Large)
		{
			wj.e = "l";
			wj.f = "gui\\ui_l_gen1";
			wj.p = 2;
			wj.n = new esj(62, 62);
			wj.h = 2;
			wj.i = 7;
			wj.j = 0.6f;
			wj.k = 0.8f;
			wj.l = 1;
			wj.m = 1;
			wj.o = new esj(50, 50);
			wj.g = 4;
			wj.q = new Vector2(10f, 10f);
			wj.r = egg.am;
			wj.s = egg.am;
			wj.t = new esj(27, 62);
			wj.u = new Point(1, 828);
			wj.v = new esj(21, 43);
			wj.w = new Vector2(8f, 47f);
			wj.x = new Vector2(186f, 0f);
			wj.y = new esj(50, 50);
			wj.aa = new Point(220, 332);
			wj.ab = new esj(60, 15);
			wj.ac = new esj(1000, 15);
			wj.ad = new esj(430, 46);
			wj.ae = egg.h;
			wj.af = 10;
			wj.ag = egg.e;
			wj.ah = egg.f;
			wj.ai = new Point(15, 15);
			wj.aj = new Rectangle(1115, 433, 50, 76);
			wj.ak = new Rectangle(1165, 433, 50, 76);
			wj.al = new esj(400, 100);
			wj.am = new esj(61, 1440);
			wj.an = new Rectangle(216, 0, 65, 19);
			wj.ao = new Rectangle(216, 19, 65, 50);
			wj.ap = new Rectangle(216, 269, 65, 50);
			wj.aq = new Rectangle(216, 169, 32, 50);
			wj.ar = new Rectangle(248, 169, 32, 50);
			wj.@as = 281;
			wj.at = 1;
			wj.au = 61;
			wj.av = 5;
			wj.aw = 14;
			wj.ax = new Tuple<int, int>(3, 3);
			wj.ay = new esj(26, 27);
			wj.az = new Point(28, 914);
			wj.a0 = wj.ay;
			wj.a1 = new Point(82, 914);
			wj.a2 = 8;
			wj.a3 = new Rectangle(72, 828, 43, 46);
			wj.a4 = 850;
			wj.a5 = new Point(243, 1443);
			wj.a6 = new esj(27, 52);
			wj.a7 = new Point(3, 1443);
			wj.a8 = new esj(80, 47);
			wj.a9 = new Point(270, 1443);
			wj.ba = new esj(27, 26);
			wj.bb = new Point(60, 10);
			wj.bc = new Point(1160, 0);
			wj.bd = new esj(20, 20);
			wj.be = new Point(968, 0);
			wj.bf = new esj(32, 32);
			wj.bg = new Point(1, 733);
			wj.bh = new esj(31, 31);
			wj.bi = 20;
			wj.bj = new Point(1, 764);
			wj.bk = new esj(31, 31);
			wj.bl = new Point(1307, 54);
			wj.bm = new esj(27, 27);
			wj.bn = new Point(208, 379);
			wj.bo = new esj(24, 39);
			wj.bp = new Point(124, 982);
			wj.bq = new esj(39, 24);
			wj.br = 3;
			wj.bs = new Point(2, 326);
			wj.bt = new esj(72, 17);
			wj.bu = new Point(299, 1443);
			wj.bv = 90;
			wj.bw = 30;
			wj.bx = new esj(48, 48);
			wj.by = new Point(1, 379);
			wj.bz = new Point(1, 477);
			wj.b0 = new esj(50, 50);
			wj.b1 = new esj(36, 36);
			wj.b2 = wj.n;
			wj.b3 = 20;
			wj.b4 = 0;
			wj.b5 = egg.ax;
			wj.b6 = new Point(883, 528);
			wj.b7 = new esj(96, 96);
			wj.b8 = new Point(680, 96);
			wj.b9 = new esj(32, 32);
			wj.ca = new Point(1064, 96);
			wj.cb = new esj(32, 32);
			wj.cc = new Point(1171, 528);
			wj.cd = new esj(96, 96);
			wj.ce = egg.am;
			wj.cf = 10;
			wj.cg = new esj(27, 27);
			wj.ch = new Point(1280, 0);
			wj.ci = new esj(37, 27);
			wj.ck = new esj(250, 600);
			wj.cl = new Point(90, 5);
			wj.cq = new Point(1, 1625);
			wj.cm = new esj(62, 62);
			wj.cn = 2;
			wj.co = new Point(71, 1822);
			wj.cp = new esj(88, 88);
			wj.cr = new Point(0, 1751);
			wj.cs = new esj(69, 69);
			wj.ct = new Point(219, 541);
			wj.cu = new esj(61, 61);
			wj.cv = 930;
			wj.cw = 800;
			wj.cx = 20;
			wj.cy = new Point(10, 51);
			wj.cz = new Point(1781, 1);
			wj.c0 = new esj(40, 40);
			wj.c1 = 1;
			wj.c2 = new esj(200, 40);
			wj.c5 = egg.au;
			wj.c3 = new Point(156, 797);
			wj.c4 = new esj(61, 61);
			wj.c6 = new Point(1488, 288);
			wj.c7 = new esj(48, 48);
			wj.c8 = 2;
			wj.c9 = new Point(648, 814);
			wj.da = new esj(57, 57);
			wj.db = 3;
			wj.dc = new Point(1220, 120);
			wj.dd = new esj(20, 20);
			wj.de = egg.am;
			wj.df = 35;
			wj.dg = 10;
			wj.dh = egg.au;
			wj.di = egg.ay;
			wj.dj = new esj(8, 8);
			wj.dk = new esj(8, 4);
			wj.dl = new esj(200, 40);
			wj.dm = egg.ay;
			wj.@do = -6;
			wj.dn = egg.a6;
			wj.dp = egg.x;
			wj.dq = new Vector2(1.5f, 1.25f);
			wj.dr = new esj(750, 600);
			wj.ds = 10;
			wj.dt = 50;
			wj.du = 125;
			wj.dv = new esj(160, 35);
			wj.dw = new Point(821, 817);
			wj.dx = new esj(50, 50);
			wj.dy = new Rectangle(821, 1369, 55, 55);
			wj.dz = new Point(1488, 288);
			wj.d0 = new esj(48, 48);
			wj.d1 = 930;
			wj.d2 = 800;
			wj.d3 = 15;
			wj.d4 = egg.au;
			wj.d5 = new Point(1220, 120);
			wj.d6 = new esj(20, 20);
			wj.d7 = new Point(507, 1625);
			wj.d8 = new esj(60, 60);
			wj.d9 = 2;
			wj.ea = 355;
			wj.eb = new esj(69, 69);
			wj.ec = new Point(648, 534);
			wj.ed = new Point(648, 674);
			wj.ee = egg.am;
			wj.ef = new Point(160, 1081);
			wj.eg = new esj(40, 40);
			wj.ek = new Point(71, 796);
			wj.el = new esj(25, 31);
			wj.em = egg.ay;
			wj.en = egg.aw;
			wj.eo = egg.a6;
			wj.ep = 35;
			wj.eq = 13;
			wj.er = new esj(59, 35);
			wj.es = new Point(648, 427);
			wj.et = new esj(90, 80);
			wj.eu = egg.am;
			wj.ev = egg.al;
			wj.ew = new esj(380, 278);
			wj.ex = new esj(780, 680);
			wj.ey = new Point(1217, 433);
			wj.ez = new esj(69, 69);
			wj.e0 = egg.ay;
			wj.e1 = new Point(40, 100);
			wj.e2 = new Point(95, 95);
			wj.e7 = new Point(1392, 188);
			wj.e8 = new esj(43, 13);
			wj.e3 = wj.e7;
			wj.e4 = wj.e8;
			wj.e9 = new Point(1633, 470);
			wj.fa = new esj(43, 13);
			wj.e5 = wj.e9;
			wj.e6 = wj.fa;
			wj.fb = 35;
			wj.fc = egg.au;
			wj.fd = new Point(1217, 504);
			wj.fe = new esj(18, 21);
			wj.ff = new esj(10, 10);
			wj.fg = new Point(1600, 1942);
			wj.fh = new esj(48, 48);
			wj.fi = new Point(1552, 1942);
			wj.fj = new esj(48, 48);
			wj.fk = new Point(1504, 1942);
			wj.fl = new esj(48, 48);
			wj.fm = new Point(1160, 0);
			wj.fn = new esj(20, 20);
			wj.fo = egg.ay;
			wj.fp = new Point(10, 6);
			wj.fr = 42;
			wj.fq = 1200;
			wj.fs = new Point(1903, 153);
			wj.ft = new esj(40, 40);
			wj.fu = new esj(1400, 800);
			wj.fv = new esj(25, 25);
			wj.fw = new esj(240, 40);
			wj.fx = new esj(2, 2);
			wj.fy = 6;
			wj.fz = egg.c;
			wj.f0 = 7;
			wj.f3 = new esj(180, 40);
			wj.f4 = 6;
			wj.f5 = egg.b;
			wj.f6 = 10;
			wj.f2 = 2;
			wj.f9 = new esj(600, 55);
			wj.ga = egg.i;
			wj.gb = new Point(20, 9);
			wj.gc = egg.g;
			wj.gd = new Point(20, 8);
			wj.ge = egg.c;
			wj.gf = new esj(600, 48);
			wj.gg = egg.a8;
			wj.gh = egg.f;
			wj.gi = egg.e;
			wj.gj = egg.f;
			wj.gk = 35;
			wj.gl = 15;
			wj.gm = egg.e;
			wj.gn = 8;
			wj.go = egg.f;
			wj.gp = 60;
			wj.gq = 15;
			wj.gr = 4;
			wj.gs = 36;
			wj.gt = 15;
			wj.gu = egg.d;
			wj.gv = 8;
			wj.gw = new Point(1775, 818);
			wj.gx = new esj(50, 50);
			wj.gy = new Point(1903, 1);
			wj.gz = new esj(30, 30);
			wj.g0 = new Point(346, 1723);
			wj.g1 = new esj(50, 16);
			wj.g2 = new Point(146, 136);
			wj.g3 = new esj(23, 23);
			wj.g4 = new Vector2(1.5f, 1.5f);
			wj.g5 = egg.e;
			wj.g6 = 8;
			wj.g7 = new esj(900, 720);
			wj.g8 = egg.a5;
			wj.g9 = new esj(177, 348);
			wj.ha = 40;
			wj.hb = egg.k;
			wj.hc = egg.g;
			wj.hd = new Point(1, 1);
			wj.he = new esj(160, 160);
			wj.hf = 0;
			wj.hg = new esj(160, 124);
			wj.hi = new esj(200, 40);
			wj.hh = egg.ay;
			wj.hj = 20;
			wj.hk = 20;
			wj.hl = 20;
			wj.hm = 10;
			wj.hn = 650;
			wj.ho = 300;
			wj.hp = 300;
			wj.hq = 20;
			wj.hu = 55;
			wj.hr = 30;
			wj.hs = 34;
			wj.ht = 646;
			wj.hv = new esj(350, 35);
			wj.hw = egg.e;
			wj.hx = 15;
			wj.hy = 10;
			wj.hz = 10;
			wj.h0 = egg.f;
			wj.h1 = 50;
			wj.h2 = egg.a9;
			wj.h3 = 35;
			wj.h4 = 52;
			wj.h5 = 704;
			wj.h6 = 5;
			wj.h7 = new esj(550, 108);
			wj.h8 = new esj(160, 40);
			wj.h9 = egg.j;
			wj.ia = egg.e;
			wj.ib = egg.b;
			wj.ic = egg.aq;
			wj.id = 1;
			wj.ig = new Point(648, 398);
			wj.@if = new esj(109, 14);
			wj.ie = new esj(9, 27);
			wj.ih = new esj(500, 100);
			wj.ij = egg.ay;
			wj.ii = 10;
			wj.ik = 35;
			wj.il = new Point(1160, 120);
			wj.im = new esj(20, 20);
			wj.@in = 820;
			wj.io = 800;
			wj.ip = new esj(385, 385);
			wj.iq = new esj(385, 385);
			wj.ir = new Vector2(1.5f, 1.25f);
			wj.@is = new Vector2(1.28f, 1.64f);
			wj.it = new Point(873, 916);
			wj.iu = new esj(61, 61);
			wj.iv = 10;
			wj.iw = 1.5f;
			wj.ix = 970;
			wj.iy = new esj(32, 40);
			wj.iz = new Point(1, 1912);
			wj.i0 = new Point(97, 1912);
			wj.i1 = egg.e;
			wj.i2 = egg.e;
		}
		else
		{
			wj.e = "s";
			wj.f = "gui\\ui_s_gen1";
			wj.p = 2;
			wj.n = new esj(41, 41);
			wj.h = 1;
			wj.i = 5;
			wj.j = 0.75f;
			wj.k = 1f;
			wj.l = 1;
			wj.m = 0;
			wj.o = new esj(33, 33);
			wj.g = 2;
			wj.q = new Vector2(7f, 5f);
			wj.r = egg.ad;
			wj.s = egg.n;
			wj.t = new esj(19, 41);
			wj.u = new Point(1, 126);
			wj.v = new esj(19, 41);
			wj.w = new Vector2(4f, 29f);
			wj.x = new Vector2(123f, 0f);
			wj.y = new esj(33, 33);
			wj.aa = new Point(63, 208);
			wj.ab = new esj(60, 12);
			wj.ac = new esj(700, 12);
			wj.ad = new esj(350, 40);
			wj.ae = egg.e;
			wj.af = 8;
			wj.ag = egg.b;
			wj.ah = egg.c;
			wj.ai = new Point(10, 10);
			wj.aj = new Rectangle(36, 551, 40, 61);
			wj.ak = new Rectangle(76, 551, 40, 61);
			wj.al = new esj(300, 80);
			wj.am = new esj(39, 1200);
			wj.an = new Rectangle(133, 0, 41, 13);
			wj.ao = new Rectangle(133, 13, 41, 33);
			wj.ap = new Rectangle(133, 178, 41, 33);
			wj.aq = new Rectangle(133, 112, 21, 33);
			wj.ar = new Rectangle(154, 112, 20, 33);
			wj.@as = 174;
			wj.at = 1;
			wj.au = 39;
			wj.av = 4;
			wj.aw = 9;
			wj.ax = new Tuple<int, int>(3, 3);
			wj.ay = new esj(19, 20);
			wj.az = new Point(58, 126);
			wj.a0 = wj.ay;
			wj.a1 = new Point(58, 166);
			wj.a2 = 5;
			wj.a3 = new Rectangle(102, 476, 20, 22);
			wj.a4 = 450;
			wj.a5 = new Point(243, 1204);
			wj.a6 = new esj(23, 48);
			wj.a7 = new Point(2, 1204);
			wj.a8 = new esj(80, 48);
			wj.a9 = new Point(266, 1204);
			wj.ba = new esj(23, 24);
			wj.bb = new Point(55, 10);
			wj.bc = new Point(1160, 0);
			wj.bd = new esj(20, 20);
			wj.be = new Point(968, 0);
			wj.bf = new esj(32, 32);
			wj.bg = new Point(1, 924);
			wj.bh = new esj(22, 22);
			wj.bi = 15;
			wj.bj = new Point(1, 946);
			wj.bk = new esj(22, 22);
			wj.bl = new Point(1304, 48);
			wj.bm = new esj(24, 24);
			wj.bn = new Point(128, 1017);
			wj.bo = new esj(15, 27);
			wj.bp = new Point(65, 970);
			wj.br = 2;
			wj.bq = new esj(27, 15);
			wj.bs = new Point(1, 1476);
			wj.bt = new esj(78, 15);
			wj.bu = new Point(1, 1350);
			wj.bv = 62;
			wj.bw = 21;
			wj.bx = new esj(33, 33);
			wj.by = new Point(1, 477);
			wj.bz = new Point(1, 1019);
			wj.b0 = new esj(30, 30);
			wj.b1 = new esj(18, 18);
			wj.b2 = wj.n;
			wj.b3 = 10;
			wj.b4 = 0;
			wj.b5 = egg.ap;
			wj.b6 = new Point(883, 528);
			wj.b7 = new esj(96, 96);
			wj.b8 = new Point(680, 96);
			wj.b9 = new esj(32, 32);
			wj.ca = new Point(1064, 96);
			wj.cb = new esj(32, 32);
			wj.cc = new Point(1171, 528);
			wj.cd = new esj(96, 96);
			wj.ce = egg.am;
			wj.cf = 10;
			wj.cg = new esj(24, 24);
			wj.ch = new Point(1280, 0);
			wj.ci = new esj(30, 24);
			wj.cj = -15;
			wj.ck = new esj(160, 384);
			wj.cl = new Point(60, 5);
			wj.cq = new Point(1, 1523);
			wj.cm = new esj(44, 44);
			wj.cn = 2;
			wj.co = new Point(47, 1569);
			wj.cp = new esj(57, 57);
			wj.cr = new Point(1, 1628);
			wj.cs = new esj(44, 44);
			wj.ct = new Point(1, 551);
			wj.cu = new esj(33, 33);
			wj.cv = 700;
			wj.cw = 460;
			wj.cx = 10;
			wj.cy = new Point(0, 51);
			wj.cz = new Point(36, 634);
			wj.c0 = new esj(30, 30);
			wj.c1 = 0;
			wj.c2 = new esj(150, 28);
			wj.c5 = egg.ap;
			wj.c3 = new Point(250, 1350);
			wj.c4 = new esj(39, 39);
			wj.c6 = new Point(0, 401);
			wj.c7 = new esj(25, 25);
			wj.c8 = 2;
			wj.c9 = new Point(291, 1204);
			wj.da = new esj(39, 39);
			wj.db = 2;
			wj.dc = new Point(1220, 120);
			wj.dd = new esj(20, 20);
			wj.de = egg.p;
			wj.df = 28;
			wj.dg = 7;
			wj.dh = egg.ad;
			wj.di = egg.am;
			wj.dj = new esj(8, 6);
			wj.dk = new esj(8, 3);
			wj.dl = new esj(130, 28);
			wj.dm = egg.am;
			wj.@do = -2;
			wj.dn = egg.au;
			wj.dp = egg.w;
			wj.dq = new Vector2(1f, 1f);
			wj.dr = new esj(495, 480);
			wj.ds = 5;
			wj.dt = 36;
			wj.du = 110;
			wj.dv = new esj(88, 26);
			wj.dw = new Point(409, 1);
			wj.dx = new esj(40, 40);
			wj.dy = new Rectangle(409, 443, 42, 42);
			wj.dz = new Point(0, 401);
			wj.d0 = new esj(25, 25);
			wj.d1 = 700;
			wj.d2 = 490;
			wj.d3 = 8;
			wj.d4 = egg.al;
			wj.d5 = new Point(1220, 120);
			wj.d6 = new esj(20, 20);
			wj.d7 = new Point(223, 1523);
			wj.d8 = new esj(41, 41);
			wj.d9 = 2;
			wj.ea = 264;
			wj.eb = new esj(43, 43);
			wj.ec = new Point(1811, 159);
			wj.ed = new Point(1811, 247);
			wj.ee = egg.ad;
			wj.ef = new Point(1942, 1);
			wj.eg = new esj(35, 35);
			wj.eh = 3;
			wj.ei = 3;
			wj.ej = 20;
			wj.ek = new Point(35, 613);
			wj.el = new esj(18, 20);
			wj.em = egg.au;
			wj.en = egg.@as;
			wj.eo = egg.at;
			wj.ep = 30;
			wj.eq = 10;
			wj.er = new esj(59, 23);
			wj.es = new Point(1223, 191);
			wj.et = new esj(53, 56);
			wj.eu = egg.ad;
			wj.ev = egg.ac;
			wj.ew = new esj(256, 187);
			wj.ex = new esj(500, 450);
			wj.ey = new Point(1142, 261);
			wj.ez = new esj(43, 43);
			wj.e0 = egg.ai;
			wj.e1 = new Point(30, 65);
			wj.e2 = new Point(60, 60);
			wj.e7 = new Point(1402, 132);
			wj.e8 = new esj(43, 12);
			wj.e3 = wj.e7;
			wj.e4 = wj.e8;
			wj.e9 = new Point(1402, 271);
			wj.fa = new esj(43, 11);
			wj.e5 = wj.e9;
			wj.e6 = wj.fa;
			wj.fb = 30;
			wj.fc = egg.aq;
			wj.fd = new Point(1109, 286);
			wj.fe = new esj(16, 18);
			wj.ff = new esj(5, 5);
			wj.fg = new Point(728, 303);
			wj.fh = new esj(48, 48);
			wj.fi = new Point(680, 303);
			wj.fj = new esj(48, 48);
			wj.fk = new Point(632, 303);
			wj.fl = new esj(48, 48);
			wj.fm = new Point(1160, 0);
			wj.fn = new esj(20, 20);
			wj.fo = egg.am;
			wj.fp = new Point(5, 3);
			wj.fr = 36;
			wj.fq = 900;
			wj.fs = new Point(1679, 306);
			wj.ft = new esj(35, 35);
			wj.fu = new esj(965, 689);
			wj.fv = new esj(25, 25);
			wj.fw = new esj(200, 35);
			wj.fx = new esj(2, 2);
			wj.fy = 5;
			wj.fz = egg.b;
			wj.f0 = 6;
			wj.f3 = new esj(120, 35);
			wj.f4 = 6;
			wj.f5 = egg.b;
			wj.f6 = 5;
			wj.f2 = 1;
			wj.f9 = new esj(480, 40);
			wj.ga = egg.f;
			wj.gb = new Point(20, 8);
			wj.gc = egg.e;
			wj.gd = new Point(20, 8);
			wj.ge = egg.@as;
			wj.gf = new esj(480, 42);
			wj.gg = egg.@as;
			wj.gh = egg.e;
			wj.gi = egg.b;
			wj.gj = egg.c;
			wj.gk = 30;
			wj.gl = 10;
			wj.gm = egg.b;
			wj.gn = 7;
			wj.go = egg.d;
			wj.gp = 46;
			wj.gq = 10;
			wj.gr = 3;
			wj.gs = 30;
			wj.gt = 10;
			wj.gu = egg.a2;
			wj.gv = 7;
			wj.gw = new Point(1865, 335);
			wj.gx = new esj(35, 35);
			wj.gy = new Point(1972, 318);
			wj.gz = new esj(25, 25);
			wj.g0 = new Point(1791, 1);
			wj.g1 = new esj(50, 13);
			wj.g2 = new Point(1, 210);
			wj.g3 = new esj(20, 20);
			wj.g4 = new Vector2(1f, 1f);
			wj.g5 = egg.b;
			wj.g6 = 6;
			wj.g7 = new esj(600, 520);
			wj.g8 = egg.ad;
			wj.g9 = new esj(148, 279);
			wj.ha = 35;
			wj.hb = egg.e;
			wj.hc = egg.e;
			wj.hd = new Point(1, 1);
			wj.he = new esj(100, 100);
			wj.hf = 0;
			wj.hg = new esj(100, 78);
			wj.hi = new esj(160, 35);
			wj.hh = egg.aq;
			wj.hj = 20;
			wj.hk = 20;
			wj.hl = 20;
			wj.hm = 10;
			wj.hn = 475;
			wj.ho = 200;
			wj.hp = 265;
			wj.hq = 15;
			wj.hu = 50;
			wj.hr = 22;
			wj.hs = 30;
			wj.ht = 550;
			wj.hv = new esj(275, 30);
			wj.hw = egg.c;
			wj.hx = 10;
			wj.hy = 7;
			wj.hz = 8;
			wj.h0 = egg.b;
			wj.h1 = 30;
			wj.h2 = egg.@as;
			wj.h3 = 25;
			wj.h4 = 39;
			wj.h5 = 588;
			wj.h6 = 5;
			wj.h7 = new esj(500, 100);
			wj.h8 = new esj(120, 35);
			wj.h9 = egg.f;
			wj.ia = egg.e;
			wj.ib = egg.b;
			wj.ic = egg.ai;
			wj.id = 1;
			wj.ig = new Point(1854, 407);
			wj.@if = new esj(109, 13);
			wj.ie = new esj(7, 23);
			wj.ih = new esj(380, 80);
			wj.ij = egg.am;
			wj.ii = 5;
			wj.ik = 30;
			wj.il = new Point(1160, 120);
			wj.im = new esj(20, 20);
			wj.@in = 700;
			wj.io = 560;
			wj.ip = new esj(300, 235);
			wj.iq = new esj(300, 235);
			wj.ir = new Vector2(1.15f, 1f);
			wj.@is = new Vector2(1f, 1f);
			wj.it = new Point(451, 1);
			wj.iu = new esj(33, 33);
			wj.iv = 4;
			wj.iw = 1f;
			wj.ix = 600;
			wj.iy = new esj(24, 25);
			wj.iz = new Point(1, 1127);
			wj.i0 = new Point(73, 1127);
			wj.i1 = egg.b;
			wj.i2 = egg.b;
			wj.i3 = 10;
			wj.i4 = 1;
			wj.i5 = 60;
			wj.i6 = new Rectangle(777, 440, 56, 21);
			wj.i7 = new Rectangle(834, 440, 21, 28);
			wj.i8 = new Rectangle(856, 440, 21, 28);
			wj.i9 = new Rectangle(883, 440, 19, 19);
			wj.ja = new Rectangle(902, 440, 19, 19);
			wj.jb = new Rectangle(921, 440, 19, 19);
			wj.jc = new Rectangle(940, 440, 19, 19);
		}
		wj.a[A_0] = wj;
		return wj;
	}

	// Token: 0x06002AF3 RID: 10995 RVA: 0x000F915C File Offset: 0x000F735C
	public void a(ref int A_0)
	{
		A_0 += this.g - A_0 % this.g;
	}

	// Token: 0x0400174B RID: 5963
	private static Dictionary<UiSize, wj> a = new Dictionary<UiSize, wj>();

	// Token: 0x0400174C RID: 5964
	public static readonly double b = 100.0;

	// Token: 0x0400174D RID: 5965
	public static readonly double c = 50.0;

	// Token: 0x0400174E RID: 5966
	public UiSize d;

	// Token: 0x0400174F RID: 5967
	public string e;

	// Token: 0x04001750 RID: 5968
	public string f;

	// Token: 0x04001751 RID: 5969
	public int g;

	// Token: 0x04001752 RID: 5970
	public int h;

	// Token: 0x04001753 RID: 5971
	public int i;

	// Token: 0x04001754 RID: 5972
	public float j;

	// Token: 0x04001755 RID: 5973
	public float k;

	// Token: 0x04001756 RID: 5974
	public int l;

	// Token: 0x04001757 RID: 5975
	public int m;

	// Token: 0x04001758 RID: 5976
	public esj n;

	// Token: 0x04001759 RID: 5977
	public esj o;

	// Token: 0x0400175A RID: 5978
	public int p;

	// Token: 0x0400175B RID: 5979
	public Vector2 q;

	// Token: 0x0400175C RID: 5980
	public string r;

	// Token: 0x0400175D RID: 5981
	public string s;

	// Token: 0x0400175E RID: 5982
	public esj t;

	// Token: 0x0400175F RID: 5983
	public Point u;

	// Token: 0x04001760 RID: 5984
	public esj v;

	// Token: 0x04001761 RID: 5985
	public Vector2 w;

	// Token: 0x04001762 RID: 5986
	public Vector2 x;

	// Token: 0x04001763 RID: 5987
	public esj y;

	// Token: 0x04001764 RID: 5988
	public int z;

	// Token: 0x04001765 RID: 5989
	public Point aa;

	// Token: 0x04001766 RID: 5990
	public esj ab;

	// Token: 0x04001767 RID: 5991
	public esj ac;

	// Token: 0x04001768 RID: 5992
	public esj ad;

	// Token: 0x04001769 RID: 5993
	public string ae;

	// Token: 0x0400176A RID: 5994
	public int af;

	// Token: 0x0400176B RID: 5995
	public string ag;

	// Token: 0x0400176C RID: 5996
	public string ah;

	// Token: 0x0400176D RID: 5997
	public Point ai;

	// Token: 0x0400176E RID: 5998
	public Rectangle aj;

	// Token: 0x0400176F RID: 5999
	public Rectangle ak;

	// Token: 0x04001770 RID: 6000
	public esj al;

	// Token: 0x04001771 RID: 6001
	public esj am;

	// Token: 0x04001772 RID: 6002
	public Rectangle an;

	// Token: 0x04001773 RID: 6003
	public Rectangle ao;

	// Token: 0x04001774 RID: 6004
	public Rectangle ap;

	// Token: 0x04001775 RID: 6005
	public Rectangle aq;

	// Token: 0x04001776 RID: 6006
	public Rectangle ar;

	// Token: 0x04001777 RID: 6007
	public int @as;

	// Token: 0x04001778 RID: 6008
	public int at;

	// Token: 0x04001779 RID: 6009
	public int au;

	// Token: 0x0400177A RID: 6010
	public int av;

	// Token: 0x0400177B RID: 6011
	public int aw;

	// Token: 0x0400177C RID: 6012
	public Tuple<int, int> ax;

	// Token: 0x0400177D RID: 6013
	public esj ay;

	// Token: 0x0400177E RID: 6014
	public Point az;

	// Token: 0x0400177F RID: 6015
	public esj a0;

	// Token: 0x04001780 RID: 6016
	public Point a1;

	// Token: 0x04001781 RID: 6017
	public int a2;

	// Token: 0x04001782 RID: 6018
	public Rectangle a3;

	// Token: 0x04001783 RID: 6019
	public int a4;

	// Token: 0x04001784 RID: 6020
	public Point a5;

	// Token: 0x04001785 RID: 6021
	public esj a6;

	// Token: 0x04001786 RID: 6022
	public Point a7;

	// Token: 0x04001787 RID: 6023
	public esj a8;

	// Token: 0x04001788 RID: 6024
	public Point a9;

	// Token: 0x04001789 RID: 6025
	public esj ba;

	// Token: 0x0400178A RID: 6026
	public Point bb;

	// Token: 0x0400178B RID: 6027
	public Point bc;

	// Token: 0x0400178C RID: 6028
	public esj bd;

	// Token: 0x0400178D RID: 6029
	public Point be;

	// Token: 0x0400178E RID: 6030
	public esj bf;

	// Token: 0x0400178F RID: 6031
	public Point bg;

	// Token: 0x04001790 RID: 6032
	public esj bh;

	// Token: 0x04001791 RID: 6033
	public int bi;

	// Token: 0x04001792 RID: 6034
	public Point bj;

	// Token: 0x04001793 RID: 6035
	public esj bk;

	// Token: 0x04001794 RID: 6036
	public Point bl;

	// Token: 0x04001795 RID: 6037
	public esj bm;

	// Token: 0x04001796 RID: 6038
	public Point bn;

	// Token: 0x04001797 RID: 6039
	public esj bo;

	// Token: 0x04001798 RID: 6040
	public Point bp;

	// Token: 0x04001799 RID: 6041
	public esj bq;

	// Token: 0x0400179A RID: 6042
	public int br;

	// Token: 0x0400179B RID: 6043
	public Point bs;

	// Token: 0x0400179C RID: 6044
	public esj bt;

	// Token: 0x0400179D RID: 6045
	public Point bu;

	// Token: 0x0400179E RID: 6046
	public int bv;

	// Token: 0x0400179F RID: 6047
	public int bw;

	// Token: 0x040017A0 RID: 6048
	public esj bx;

	// Token: 0x040017A1 RID: 6049
	public Point by;

	// Token: 0x040017A2 RID: 6050
	public Point bz;

	// Token: 0x040017A3 RID: 6051
	public esj b0;

	// Token: 0x040017A4 RID: 6052
	public esj b1;

	// Token: 0x040017A5 RID: 6053
	public esj b2;

	// Token: 0x040017A6 RID: 6054
	public int b3;

	// Token: 0x040017A7 RID: 6055
	public int b4;

	// Token: 0x040017A8 RID: 6056
	public string b5;

	// Token: 0x040017A9 RID: 6057
	public Point b6;

	// Token: 0x040017AA RID: 6058
	public esj b7;

	// Token: 0x040017AB RID: 6059
	public Point b8;

	// Token: 0x040017AC RID: 6060
	public esj b9;

	// Token: 0x040017AD RID: 6061
	public Point ca;

	// Token: 0x040017AE RID: 6062
	public esj cb;

	// Token: 0x040017AF RID: 6063
	public Point cc;

	// Token: 0x040017B0 RID: 6064
	public esj cd;

	// Token: 0x040017B1 RID: 6065
	public string ce;

	// Token: 0x040017B2 RID: 6066
	public int cf;

	// Token: 0x040017B3 RID: 6067
	public esj cg;

	// Token: 0x040017B4 RID: 6068
	public Point ch;

	// Token: 0x040017B5 RID: 6069
	public esj ci;

	// Token: 0x040017B6 RID: 6070
	public int cj;

	// Token: 0x040017B7 RID: 6071
	public esj ck;

	// Token: 0x040017B8 RID: 6072
	public Point cl;

	// Token: 0x040017B9 RID: 6073
	public esj cm;

	// Token: 0x040017BA RID: 6074
	public int cn;

	// Token: 0x040017BB RID: 6075
	public Point co;

	// Token: 0x040017BC RID: 6076
	public esj cp;

	// Token: 0x040017BD RID: 6077
	public Point cq;

	// Token: 0x040017BE RID: 6078
	public Point cr;

	// Token: 0x040017BF RID: 6079
	public esj cs;

	// Token: 0x040017C0 RID: 6080
	public Point ct;

	// Token: 0x040017C1 RID: 6081
	public esj cu;

	// Token: 0x040017C2 RID: 6082
	public int cv;

	// Token: 0x040017C3 RID: 6083
	public int cw;

	// Token: 0x040017C4 RID: 6084
	public int cx;

	// Token: 0x040017C5 RID: 6085
	public Point cy;

	// Token: 0x040017C6 RID: 6086
	public Point cz;

	// Token: 0x040017C7 RID: 6087
	public esj c0;

	// Token: 0x040017C8 RID: 6088
	public int c1;

	// Token: 0x040017C9 RID: 6089
	public esj c2;

	// Token: 0x040017CA RID: 6090
	public Point c3;

	// Token: 0x040017CB RID: 6091
	public esj c4;

	// Token: 0x040017CC RID: 6092
	public string c5;

	// Token: 0x040017CD RID: 6093
	public Point c6;

	// Token: 0x040017CE RID: 6094
	public esj c7;

	// Token: 0x040017CF RID: 6095
	public int c8;

	// Token: 0x040017D0 RID: 6096
	public Point c9;

	// Token: 0x040017D1 RID: 6097
	public esj da;

	// Token: 0x040017D2 RID: 6098
	public int db;

	// Token: 0x040017D3 RID: 6099
	public Point dc;

	// Token: 0x040017D4 RID: 6100
	public esj dd;

	// Token: 0x040017D5 RID: 6101
	public string de;

	// Token: 0x040017D6 RID: 6102
	public int df;

	// Token: 0x040017D7 RID: 6103
	public int dg;

	// Token: 0x040017D8 RID: 6104
	public string dh;

	// Token: 0x040017D9 RID: 6105
	public string di;

	// Token: 0x040017DA RID: 6106
	public esj dj;

	// Token: 0x040017DB RID: 6107
	public esj dk;

	// Token: 0x040017DC RID: 6108
	public esj dl;

	// Token: 0x040017DD RID: 6109
	public string dm;

	// Token: 0x040017DE RID: 6110
	public string dn;

	// Token: 0x040017DF RID: 6111
	public int @do;

	// Token: 0x040017E0 RID: 6112
	public string dp;

	// Token: 0x040017E1 RID: 6113
	public Vector2 dq;

	// Token: 0x040017E2 RID: 6114
	public esj dr;

	// Token: 0x040017E3 RID: 6115
	public int ds;

	// Token: 0x040017E4 RID: 6116
	public int dt;

	// Token: 0x040017E5 RID: 6117
	public int du;

	// Token: 0x040017E6 RID: 6118
	public esj dv;

	// Token: 0x040017E7 RID: 6119
	public Point dw;

	// Token: 0x040017E8 RID: 6120
	public esj dx;

	// Token: 0x040017E9 RID: 6121
	public Rectangle dy;

	// Token: 0x040017EA RID: 6122
	public Point dz;

	// Token: 0x040017EB RID: 6123
	public esj d0;

	// Token: 0x040017EC RID: 6124
	public int d1;

	// Token: 0x040017ED RID: 6125
	public int d2;

	// Token: 0x040017EE RID: 6126
	public int d3;

	// Token: 0x040017EF RID: 6127
	public string d4;

	// Token: 0x040017F0 RID: 6128
	public Point d5;

	// Token: 0x040017F1 RID: 6129
	public esj d6;

	// Token: 0x040017F2 RID: 6130
	public Point d7;

	// Token: 0x040017F3 RID: 6131
	public esj d8;

	// Token: 0x040017F4 RID: 6132
	public int d9;

	// Token: 0x040017F5 RID: 6133
	public int ea;

	// Token: 0x040017F6 RID: 6134
	public esj eb;

	// Token: 0x040017F7 RID: 6135
	public Point ec;

	// Token: 0x040017F8 RID: 6136
	public Point ed;

	// Token: 0x040017F9 RID: 6137
	public string ee;

	// Token: 0x040017FA RID: 6138
	public Point ef;

	// Token: 0x040017FB RID: 6139
	public esj eg;

	// Token: 0x040017FC RID: 6140
	public int eh = 5;

	// Token: 0x040017FD RID: 6141
	public int ei = 5;

	// Token: 0x040017FE RID: 6142
	public int ej = 30;

	// Token: 0x040017FF RID: 6143
	public Point ek;

	// Token: 0x04001800 RID: 6144
	public esj el;

	// Token: 0x04001801 RID: 6145
	public string em;

	// Token: 0x04001802 RID: 6146
	public string en;

	// Token: 0x04001803 RID: 6147
	public string eo;

	// Token: 0x04001804 RID: 6148
	public int ep;

	// Token: 0x04001805 RID: 6149
	public int eq;

	// Token: 0x04001806 RID: 6150
	public esj er;

	// Token: 0x04001807 RID: 6151
	public Point es;

	// Token: 0x04001808 RID: 6152
	public esj et;

	// Token: 0x04001809 RID: 6153
	public string eu;

	// Token: 0x0400180A RID: 6154
	public string ev;

	// Token: 0x0400180B RID: 6155
	public esj ew;

	// Token: 0x0400180C RID: 6156
	public esj ex;

	// Token: 0x0400180D RID: 6157
	public Point ey;

	// Token: 0x0400180E RID: 6158
	public esj ez;

	// Token: 0x0400180F RID: 6159
	public string e0;

	// Token: 0x04001810 RID: 6160
	public Point e1;

	// Token: 0x04001811 RID: 6161
	public Point e2;

	// Token: 0x04001812 RID: 6162
	public Point e3;

	// Token: 0x04001813 RID: 6163
	public esj e4;

	// Token: 0x04001814 RID: 6164
	public Point e5;

	// Token: 0x04001815 RID: 6165
	public esj e6;

	// Token: 0x04001816 RID: 6166
	public Point e7;

	// Token: 0x04001817 RID: 6167
	public esj e8;

	// Token: 0x04001818 RID: 6168
	public Point e9;

	// Token: 0x04001819 RID: 6169
	public esj fa;

	// Token: 0x0400181A RID: 6170
	public int fb;

	// Token: 0x0400181B RID: 6171
	public string fc;

	// Token: 0x0400181C RID: 6172
	public Point fd;

	// Token: 0x0400181D RID: 6173
	public esj fe;

	// Token: 0x0400181E RID: 6174
	public esj ff;

	// Token: 0x0400181F RID: 6175
	public Point fg;

	// Token: 0x04001820 RID: 6176
	public esj fh;

	// Token: 0x04001821 RID: 6177
	public Point fi;

	// Token: 0x04001822 RID: 6178
	public esj fj;

	// Token: 0x04001823 RID: 6179
	public Point fk;

	// Token: 0x04001824 RID: 6180
	public esj fl;

	// Token: 0x04001825 RID: 6181
	public Point fm;

	// Token: 0x04001826 RID: 6182
	public esj fn;

	// Token: 0x04001827 RID: 6183
	public string fo;

	// Token: 0x04001828 RID: 6184
	public Point fp;

	// Token: 0x04001829 RID: 6185
	public int fq;

	// Token: 0x0400182A RID: 6186
	public int fr;

	// Token: 0x0400182B RID: 6187
	public Point fs;

	// Token: 0x0400182C RID: 6188
	public esj ft;

	// Token: 0x0400182D RID: 6189
	public esj fu;

	// Token: 0x0400182E RID: 6190
	public esj fv;

	// Token: 0x0400182F RID: 6191
	public esj fw;

	// Token: 0x04001830 RID: 6192
	public esj fx;

	// Token: 0x04001831 RID: 6193
	public int fy;

	// Token: 0x04001832 RID: 6194
	public string fz;

	// Token: 0x04001833 RID: 6195
	public int f0;

	// Token: 0x04001834 RID: 6196
	public string f1;

	// Token: 0x04001835 RID: 6197
	public int f2;

	// Token: 0x04001836 RID: 6198
	public esj f3;

	// Token: 0x04001837 RID: 6199
	public int f4;

	// Token: 0x04001838 RID: 6200
	public string f5;

	// Token: 0x04001839 RID: 6201
	public int f6;

	// Token: 0x0400183A RID: 6202
	public string f7;

	// Token: 0x0400183B RID: 6203
	public string f8;

	// Token: 0x0400183C RID: 6204
	public esj f9;

	// Token: 0x0400183D RID: 6205
	public string ga;

	// Token: 0x0400183E RID: 6206
	public Point gb;

	// Token: 0x0400183F RID: 6207
	public string gc;

	// Token: 0x04001840 RID: 6208
	public Point gd;

	// Token: 0x04001841 RID: 6209
	public string ge;

	// Token: 0x04001842 RID: 6210
	public esj gf;

	// Token: 0x04001843 RID: 6211
	public string gg;

	// Token: 0x04001844 RID: 6212
	public string gh;

	// Token: 0x04001845 RID: 6213
	public string gi;

	// Token: 0x04001846 RID: 6214
	public string gj;

	// Token: 0x04001847 RID: 6215
	public int gk;

	// Token: 0x04001848 RID: 6216
	public int gl;

	// Token: 0x04001849 RID: 6217
	public string gm;

	// Token: 0x0400184A RID: 6218
	public int gn;

	// Token: 0x0400184B RID: 6219
	public string go;

	// Token: 0x0400184C RID: 6220
	public int gp;

	// Token: 0x0400184D RID: 6221
	public int gq;

	// Token: 0x0400184E RID: 6222
	public int gr;

	// Token: 0x0400184F RID: 6223
	public int gs;

	// Token: 0x04001850 RID: 6224
	public int gt;

	// Token: 0x04001851 RID: 6225
	public string gu;

	// Token: 0x04001852 RID: 6226
	public int gv;

	// Token: 0x04001853 RID: 6227
	public Point gw;

	// Token: 0x04001854 RID: 6228
	public esj gx;

	// Token: 0x04001855 RID: 6229
	public Point gy;

	// Token: 0x04001856 RID: 6230
	public esj gz;

	// Token: 0x04001857 RID: 6231
	public Point g0;

	// Token: 0x04001858 RID: 6232
	public esj g1;

	// Token: 0x04001859 RID: 6233
	public Point g2;

	// Token: 0x0400185A RID: 6234
	public esj g3;

	// Token: 0x0400185B RID: 6235
	public Vector2 g4;

	// Token: 0x0400185C RID: 6236
	public string g5;

	// Token: 0x0400185D RID: 6237
	public int g6;

	// Token: 0x0400185E RID: 6238
	public esj g7;

	// Token: 0x0400185F RID: 6239
	public string g8;

	// Token: 0x04001860 RID: 6240
	public esj g9;

	// Token: 0x04001861 RID: 6241
	public int ha;

	// Token: 0x04001862 RID: 6242
	public string hb;

	// Token: 0x04001863 RID: 6243
	public string hc;

	// Token: 0x04001864 RID: 6244
	public Point hd;

	// Token: 0x04001865 RID: 6245
	public esj he;

	// Token: 0x04001866 RID: 6246
	public int hf;

	// Token: 0x04001867 RID: 6247
	public esj hg;

	// Token: 0x04001868 RID: 6248
	public string hh;

	// Token: 0x04001869 RID: 6249
	public esj hi;

	// Token: 0x0400186A RID: 6250
	public int hj;

	// Token: 0x0400186B RID: 6251
	public int hk;

	// Token: 0x0400186C RID: 6252
	public int hl;

	// Token: 0x0400186D RID: 6253
	public int hm;

	// Token: 0x0400186E RID: 6254
	public int hn;

	// Token: 0x0400186F RID: 6255
	public int ho;

	// Token: 0x04001870 RID: 6256
	public int hp;

	// Token: 0x04001871 RID: 6257
	public int hq;

	// Token: 0x04001872 RID: 6258
	public int hr;

	// Token: 0x04001873 RID: 6259
	public int hs;

	// Token: 0x04001874 RID: 6260
	public int ht;

	// Token: 0x04001875 RID: 6261
	public int hu;

	// Token: 0x04001876 RID: 6262
	public esj hv;

	// Token: 0x04001877 RID: 6263
	public string hw;

	// Token: 0x04001878 RID: 6264
	public int hx;

	// Token: 0x04001879 RID: 6265
	public int hy;

	// Token: 0x0400187A RID: 6266
	public int hz;

	// Token: 0x0400187B RID: 6267
	public string h0;

	// Token: 0x0400187C RID: 6268
	public int h1;

	// Token: 0x0400187D RID: 6269
	public string h2;

	// Token: 0x0400187E RID: 6270
	public int h3;

	// Token: 0x0400187F RID: 6271
	public int h4;

	// Token: 0x04001880 RID: 6272
	public int h5;

	// Token: 0x04001881 RID: 6273
	public int h6;

	// Token: 0x04001882 RID: 6274
	public esj h7;

	// Token: 0x04001883 RID: 6275
	public esj h8;

	// Token: 0x04001884 RID: 6276
	public string h9;

	// Token: 0x04001885 RID: 6277
	public string ia;

	// Token: 0x04001886 RID: 6278
	public string ib;

	// Token: 0x04001887 RID: 6279
	public string ic;

	// Token: 0x04001888 RID: 6280
	public int id;

	// Token: 0x04001889 RID: 6281
	public esj ie;

	// Token: 0x0400188A RID: 6282
	public esj @if;

	// Token: 0x0400188B RID: 6283
	public Point ig;

	// Token: 0x0400188C RID: 6284
	public esj ih;

	// Token: 0x0400188D RID: 6285
	public int ii;

	// Token: 0x0400188E RID: 6286
	public string ij;

	// Token: 0x0400188F RID: 6287
	public int ik;

	// Token: 0x04001890 RID: 6288
	public Point il;

	// Token: 0x04001891 RID: 6289
	public esj im;

	// Token: 0x04001892 RID: 6290
	public int @in;

	// Token: 0x04001893 RID: 6291
	public int io;

	// Token: 0x04001894 RID: 6292
	public esj ip;

	// Token: 0x04001895 RID: 6293
	public esj iq;

	// Token: 0x04001896 RID: 6294
	public Vector2 ir;

	// Token: 0x04001897 RID: 6295
	public Vector2 @is;

	// Token: 0x04001898 RID: 6296
	public Point it;

	// Token: 0x04001899 RID: 6297
	public esj iu;

	// Token: 0x0400189A RID: 6298
	public int iv;

	// Token: 0x0400189B RID: 6299
	public float iw;

	// Token: 0x0400189C RID: 6300
	public int ix;

	// Token: 0x0400189D RID: 6301
	public esj iy;

	// Token: 0x0400189E RID: 6302
	public Point iz;

	// Token: 0x0400189F RID: 6303
	public Point i0;

	// Token: 0x040018A0 RID: 6304
	public string i1;

	// Token: 0x040018A1 RID: 6305
	public string i2;

	// Token: 0x040018A2 RID: 6306
	public int i3;

	// Token: 0x040018A3 RID: 6307
	public int i4;

	// Token: 0x040018A4 RID: 6308
	public int i5;

	// Token: 0x040018A5 RID: 6309
	public Rectangle i6;

	// Token: 0x040018A6 RID: 6310
	public Rectangle i7;

	// Token: 0x040018A7 RID: 6311
	public Rectangle i8;

	// Token: 0x040018A8 RID: 6312
	public Rectangle i9;

	// Token: 0x040018A9 RID: 6313
	public Rectangle ja;

	// Token: 0x040018AA RID: 6314
	public Rectangle jb;

	// Token: 0x040018AB RID: 6315
	public Rectangle jc;
}
