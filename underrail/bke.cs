using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001946 RID: 6470
[eiz("WI")]
[elw(typeof(cd1))]
[Serializable]
public sealed class bke : diz, ISerializable
{
	// Token: 0x06008961 RID: 35169 RVA: 0x00389D58 File Offset: 0x00387F58
	private bke(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (btz)A_0.GetValue("WI:WT", typeof(btz));
		this.b = A_0.GetSingle("WI:S");
		di7.ReadList<a1q>("WI:D", ref this.d, A_0);
		this.f = (ImpactSpeed)A_0.GetValue("WI:IS", typeof(ImpactSpeed));
		this.g = A_0.GetInt32("WI:MS");
		this.h = A_0.GetSingle("WI:MR");
		this.i = A_0.GetSingle("WI:OR");
		if (ell.a() >= 101)
		{
			this.k = A_0.GetDouble("WI:CSC");
		}
		else
		{
			this.k = Math.Round((double)A_0.GetSingle("WI:CSC"), 2);
		}
		di7.ReadList<edm>("WI:OHE", ref this.m, A_0);
		this.z = A_0.GetString("WI:WVM");
		if (ell.a() >= 24)
		{
			this.ab = (esu)A_0.GetValue("WI:ISNDM", typeof(esu));
			if (ell.a() >= 50)
			{
				this.ac = (bhx)A_0.GetValue("WI:P", typeof(bhx));
				if (ell.a() >= 51)
				{
					this.n = (AmmoType)A_0.GetValue("WI:A", typeof(AmmoType));
					this.p = A_0.GetInt32("WI:M");
					if (ell.a() >= 54)
					{
						this.q = A_0.GetDouble("WI:AU");
					}
				}
			}
			if (ell.a() >= 60)
			{
				this.c = A_0.GetInt32("WI:AP");
			}
			else
			{
				this.c = 15;
			}
			if (ell.a() >= 66)
			{
				if (ell.a() >= 131)
				{
					this.r = A_0.GetDouble("WI:PB");
				}
				else
				{
					this.r = Math.Round((double)A_0.GetSingle("WI:PB"), 2);
				}
			}
			if (ell.a() >= 81)
			{
				this.u = A_0.GetSingle("WI:PP");
			}
			if (ell.a() >= 87)
			{
				this.v = A_0.GetDouble("WI:FP");
			}
			if (ell.a() >= 98)
			{
				this.s = A_0.GetDouble("WI:BP");
			}
			if (ell.a() >= 175)
			{
				this.l = A_0.GetDouble("WI:CDB");
			}
			else
			{
				this.l = 1.0;
			}
			if (ell.a() >= 181)
			{
				this.e = A_0.GetBoolean("WI:FD");
			}
			if (ell.a() >= 200)
			{
				this.w = (A_0.GetValue("WI:SB", typeof(double?)) as double?);
			}
			if (ell.a() >= 223)
			{
				this.o = A_0.GetBoolean("WI:IA");
			}
			if (ell.a() >= 260)
			{
				this.t = A_0.GetInt32("WI:EB");
			}
			if (ell.a() >= 360)
			{
				this.x = (A_0.GetValue("WI:ASA", typeof(int?)) as int?);
			}
			if (ell.a() >= 361 && ell.a() < 365)
			{
				List<aia> a_ = new List<aia>();
				di7.ReadList<aia>("WI:SA", ref a_, A_0);
				base.a(a_);
			}
			if (ell.a() >= 390)
			{
				this.ad = (car)A_0.GetValue("WI:WUE", typeof(car));
			}
			if (ell.a() >= 418)
			{
				this.y = A_0.GetDouble("WI:RAC");
			}
			if (ell.a() >= 458)
			{
				di7.ReadList<string>("WI:OHC", ref this.ae, A_0);
			}
			else
			{
				this.ae = new List<string>();
			}
			if (ell.a() >= 471)
			{
				this.ag = (A_0.GetValue("WI:WST", typeof(WeaponSubtype?)) as WeaponSubtype?);
				this.ah = A_0.GetString("WI:CSA");
				this.ai = A_0.GetBoolean("WI:DF");
				this.aj = (A_0.GetValue("WI:CTBD", typeof(int?)) as int?);
				this.ak = A_0.GetString("WI:CAA");
			}
			if (ell.a() >= 517)
			{
				di7.ReadList<bns>("WI:WAM", ref this.al, A_0);
			}
			else
			{
				this.al = new List<bns>();
			}
		}
		if (ell.a() >= 518)
		{
			this.j = A_0.GetInt32("WI:MRB");
		}
		if (ell.a() >= 606)
		{
			this.af = (A_0.GetValue("WI:OHV", typeof(List<string>)) as List<string>);
		}
		else
		{
			this.af = new List<string>();
		}
		if (ell.a() >= 653)
		{
			this.am = (q5)A_0.GetValue("WI:CSD", typeof(q5));
		}
		if (ell.a() >= 693)
		{
			this.aa = A_0.GetString("WI:SWM");
		}
		if (ell.a() >= 699)
		{
			this.an = (cum)A_0.GetValue("WI:T", typeof(cum));
		}
		if (ell.a() >= 701)
		{
			this.ao = A_0.GetBoolean("WI:DS");
		}
	}

	// Token: 0x06008962 RID: 35170 RVA: 0x0038A3C8 File Offset: 0x003885C8
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("WI:WT", this.a);
		info.AddValue("WI:S", this.b);
		di7.WriteList<a1q>("WI:D", this.d, info);
		info.AddValue("WI:IS", this.f);
		info.AddValue("WI:MS", this.g);
		info.AddValue("WI:MR", this.h);
		info.AddValue("WI:OR", this.i);
		info.AddValue("WI:CSC", this.k);
		di7.WriteList<edm>("WI:OHE", this.m, info);
		info.AddValue("WI:P", this.ac);
		info.AddValue("WI:WVM", this.z);
		info.AddValue("WI:ISNDM", this.ab);
		info.AddValue("WI:A", this.n);
		info.AddValue("WI:M", this.p);
		info.AddValue("WI:AU", this.q);
		info.AddValue("WI:AP", this.c);
		info.AddValue("WI:PB", this.r);
		info.AddValue("WI:PP", this.u);
		info.AddValue("WI:FP", this.v);
		info.AddValue("WI:BP", this.s);
		info.AddValue("WI:CDB", this.l);
		info.AddValue("WI:FD", this.e);
		info.AddValue("WI:SB", this.w);
		info.AddValue("WI:IA", this.o);
		info.AddValue("WI:EB", this.t);
		info.AddValue("WI:ASA", this.x);
		info.AddValue("WI:WUE", this.ad);
		info.AddValue("WI:RAC", this.y);
		di7.WriteList<string>("WI:OHC", this.ae, info);
		info.AddValue("WI:WST", this.ag);
		info.AddValue("WI:CSA", this.ah);
		info.AddValue("WI:DF", this.ai);
		info.AddValue("WI:CTBD", this.aj);
		info.AddValue("WI:CAA", this.ak);
		di7.WriteList<bns>("WI:WAM", this.al, info);
		info.AddValue("WI:MRB", this.j);
		info.AddValue("WI:OHV", this.af);
		info.AddValue("WI:CSD", this.am);
		info.AddValue("WI:SWM", this.aa);
		info.AddValue("WI:T", this.an);
		info.AddValue("WI:DS", this.ao);
	}

	// Token: 0x06008963 RID: 35171 RVA: 0x0038A6D4 File Offset: 0x003888D4
	public WeaponSubtype? ae()
	{
		return this.ag;
	}

	// Token: 0x06008964 RID: 35172 RVA: 0x0038A6DC File Offset: 0x003888DC
	public new void a(WeaponSubtype? A_0)
	{
		this.ag = A_0;
	}

	// Token: 0x06008965 RID: 35173 RVA: 0x0038A6E8 File Offset: 0x003888E8
	public string b()
	{
		return this.ah;
	}

	// Token: 0x06008966 RID: 35174 RVA: 0x0038A6F0 File Offset: 0x003888F0
	public void c(string A_0)
	{
		this.ah = A_0;
	}

	// Token: 0x06008967 RID: 35175 RVA: 0x0038A6FC File Offset: 0x003888FC
	public bool al()
	{
		return this.ai;
	}

	// Token: 0x06008968 RID: 35176 RVA: 0x0038A704 File Offset: 0x00388904
	public new void a(bool A_0)
	{
		this.ai = A_0;
	}

	// Token: 0x06008969 RID: 35177 RVA: 0x0038A710 File Offset: 0x00388910
	public int? o()
	{
		return this.aj;
	}

	// Token: 0x0600896A RID: 35178 RVA: 0x0038A718 File Offset: 0x00388918
	public void b(int? A_0)
	{
		this.aj = A_0;
	}

	// Token: 0x0600896B RID: 35179 RVA: 0x0038A724 File Offset: 0x00388924
	public string ag()
	{
		return this.ak;
	}

	// Token: 0x0600896C RID: 35180 RVA: 0x0038A72C File Offset: 0x0038892C
	public void d(string A_0)
	{
		this.ak = A_0;
	}

	// Token: 0x0600896D RID: 35181 RVA: 0x0038A738 File Offset: 0x00388938
	public btz e()
	{
		return this.a;
	}

	// Token: 0x0600896E RID: 35182 RVA: 0x0038A740 File Offset: 0x00388940
	public new void a(btz A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600896F RID: 35183 RVA: 0x0038A74C File Offset: 0x0038894C
	public float an()
	{
		return this.b;
	}

	// Token: 0x06008970 RID: 35184 RVA: 0x0038A754 File Offset: 0x00388954
	public void b(float A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06008971 RID: 35185 RVA: 0x0038A760 File Offset: 0x00388960
	public ImpactSpeed c()
	{
		return this.f;
	}

	// Token: 0x06008972 RID: 35186 RVA: 0x0038A768 File Offset: 0x00388968
	public new void a(ImpactSpeed A_0)
	{
		this.f = A_0;
	}

	// Token: 0x06008973 RID: 35187 RVA: 0x0038A774 File Offset: 0x00388974
	public List<a1q> l()
	{
		return this.d;
	}

	// Token: 0x06008974 RID: 35188 RVA: 0x0038A77C File Offset: 0x0038897C
	public bool t()
	{
		return this.e;
	}

	// Token: 0x06008975 RID: 35189 RVA: 0x0038A784 File Offset: 0x00388984
	public void b(bool A_0)
	{
		this.e = A_0;
	}

	// Token: 0x06008976 RID: 35190 RVA: 0x0038A790 File Offset: 0x00388990
	public int i()
	{
		return this.g;
	}

	// Token: 0x06008977 RID: 35191 RVA: 0x0038A798 File Offset: 0x00388998
	public void b(int A_0)
	{
		this.g = A_0;
	}

	// Token: 0x06008978 RID: 35192 RVA: 0x0038A7A4 File Offset: 0x003889A4
	public float ad()
	{
		return this.h;
	}

	// Token: 0x06008979 RID: 35193 RVA: 0x0038A7AC File Offset: 0x003889AC
	public void c(float A_0)
	{
		this.h = A_0;
	}

	// Token: 0x0600897A RID: 35194 RVA: 0x0038A7B8 File Offset: 0x003889B8
	public float h()
	{
		return this.i;
	}

	// Token: 0x0600897B RID: 35195 RVA: 0x0038A7C0 File Offset: 0x003889C0
	public void d(float A_0)
	{
		this.i = A_0;
	}

	// Token: 0x0600897C RID: 35196 RVA: 0x0038A7CC File Offset: 0x003889CC
	public int ah()
	{
		return this.j;
	}

	// Token: 0x0600897D RID: 35197 RVA: 0x0038A7D4 File Offset: 0x003889D4
	public void e(int A_0)
	{
		this.j = A_0;
	}

	// Token: 0x0600897E RID: 35198 RVA: 0x0038A7E0 File Offset: 0x003889E0
	public int? x()
	{
		return this.x;
	}

	// Token: 0x0600897F RID: 35199 RVA: 0x0038A7E8 File Offset: 0x003889E8
	public new void a(int? A_0)
	{
		this.x = A_0;
	}

	// Token: 0x06008980 RID: 35200 RVA: 0x0038A7F4 File Offset: 0x003889F4
	public double ai()
	{
		return this.k;
	}

	// Token: 0x06008981 RID: 35201 RVA: 0x0038A7FC File Offset: 0x003889FC
	public void f(double A_0)
	{
		this.k = A_0;
	}

	// Token: 0x06008982 RID: 35202 RVA: 0x0038A808 File Offset: 0x00388A08
	public double y()
	{
		return this.l;
	}

	// Token: 0x06008983 RID: 35203 RVA: 0x0038A810 File Offset: 0x00388A10
	public void c(double A_0)
	{
		this.l = A_0;
	}

	// Token: 0x06008984 RID: 35204 RVA: 0x0038A81C File Offset: 0x00388A1C
	public List<edm> aa()
	{
		return this.m;
	}

	// Token: 0x06008985 RID: 35205 RVA: 0x0038A824 File Offset: 0x00388A24
	public override string tv()
	{
		return this.a();
	}

	// Token: 0x06008986 RID: 35206 RVA: 0x0038A82C File Offset: 0x00388A2C
	public override string yi()
	{
		return "Weapon";
	}

	// Token: 0x06008987 RID: 35207 RVA: 0x0038A834 File Offset: 0x00388A34
	public AmmoType ak()
	{
		return this.n;
	}

	// Token: 0x06008988 RID: 35208 RVA: 0x0038A83C File Offset: 0x00388A3C
	public new void a(AmmoType A_0)
	{
		this.n = A_0;
	}

	// Token: 0x06008989 RID: 35209 RVA: 0x0038A848 File Offset: 0x00388A48
	public bool g()
	{
		return this.o;
	}

	// Token: 0x0600898A RID: 35210 RVA: 0x0038A850 File Offset: 0x00388A50
	public void c(bool A_0)
	{
		this.o = A_0;
	}

	// Token: 0x0600898B RID: 35211 RVA: 0x0038A85C File Offset: 0x00388A5C
	public int f()
	{
		return this.p;
	}

	// Token: 0x0600898C RID: 35212 RVA: 0x0038A864 File Offset: 0x00388A64
	public void c(int A_0)
	{
		this.p = A_0;
	}

	// Token: 0x0600898D RID: 35213 RVA: 0x0038A870 File Offset: 0x00388A70
	public double k()
	{
		return this.q;
	}

	// Token: 0x0600898E RID: 35214 RVA: 0x0038A878 File Offset: 0x00388A78
	public void d(double A_0)
	{
		this.q = Math.Round(A_0, 1);
	}

	// Token: 0x0600898F RID: 35215 RVA: 0x0038A888 File Offset: 0x00388A88
	public new int v()
	{
		return this.c;
	}

	// Token: 0x06008990 RID: 35216 RVA: 0x0038A890 File Offset: 0x00388A90
	public new void a(int A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06008991 RID: 35217 RVA: 0x0038A89C File Offset: 0x00388A9C
	public double r()
	{
		return this.y;
	}

	// Token: 0x06008992 RID: 35218 RVA: 0x0038A8A4 File Offset: 0x00388AA4
	public new void a(double A_0)
	{
		this.y = A_0;
	}

	// Token: 0x06008993 RID: 35219 RVA: 0x0038A8B0 File Offset: 0x00388AB0
	public double ab()
	{
		return this.r;
	}

	// Token: 0x06008994 RID: 35220 RVA: 0x0038A8B8 File Offset: 0x00388AB8
	public void g(double A_0)
	{
		this.r = A_0;
	}

	// Token: 0x06008995 RID: 35221 RVA: 0x0038A8C4 File Offset: 0x00388AC4
	public double s()
	{
		return this.s;
	}

	// Token: 0x06008996 RID: 35222 RVA: 0x0038A8CC File Offset: 0x00388ACC
	public void e(double A_0)
	{
		this.s = A_0;
	}

	// Token: 0x06008997 RID: 35223 RVA: 0x0038A8D8 File Offset: 0x00388AD8
	public int d()
	{
		return this.t;
	}

	// Token: 0x06008998 RID: 35224 RVA: 0x0038A8E0 File Offset: 0x00388AE0
	public void d(int A_0)
	{
		this.t = A_0;
	}

	// Token: 0x06008999 RID: 35225 RVA: 0x0038A8EC File Offset: 0x00388AEC
	public float z()
	{
		return this.u;
	}

	// Token: 0x0600899A RID: 35226 RVA: 0x0038A8F4 File Offset: 0x00388AF4
	public new void a(float A_0)
	{
		this.u = A_0;
	}

	// Token: 0x0600899B RID: 35227 RVA: 0x0038A900 File Offset: 0x00388B00
	public double aj()
	{
		return this.v;
	}

	// Token: 0x0600899C RID: 35228 RVA: 0x0038A908 File Offset: 0x00388B08
	public void b(double A_0)
	{
		this.v = A_0;
	}

	// Token: 0x0600899D RID: 35229 RVA: 0x0038A914 File Offset: 0x00388B14
	public double? af()
	{
		return this.w;
	}

	// Token: 0x0600899E RID: 35230 RVA: 0x0038A91C File Offset: 0x00388B1C
	public new void a(double? A_0)
	{
		this.w = A_0;
	}

	// Token: 0x0600899F RID: 35231 RVA: 0x0038A928 File Offset: 0x00388B28
	public string ac()
	{
		return this.z;
	}

	// Token: 0x060089A0 RID: 35232 RVA: 0x0038A930 File Offset: 0x00388B30
	public void b(string A_0)
	{
		this.z = A_0;
	}

	// Token: 0x060089A1 RID: 35233 RVA: 0x0038A93C File Offset: 0x00388B3C
	public string m()
	{
		return this.aa;
	}

	// Token: 0x060089A2 RID: 35234 RVA: 0x0038A944 File Offset: 0x00388B44
	public new void a(string A_0)
	{
		this.aa = A_0;
	}

	// Token: 0x060089A3 RID: 35235 RVA: 0x0038A950 File Offset: 0x00388B50
	public esu q()
	{
		return this.ab;
	}

	// Token: 0x060089A4 RID: 35236 RVA: 0x0038A958 File Offset: 0x00388B58
	public new void a(esu A_0)
	{
		this.ab = A_0;
	}

	// Token: 0x060089A5 RID: 35237 RVA: 0x0038A964 File Offset: 0x00388B64
	public bhx w()
	{
		return this.ac;
	}

	// Token: 0x060089A6 RID: 35238 RVA: 0x0038A96C File Offset: 0x00388B6C
	public new void a(bhx A_0)
	{
		this.ac = A_0;
	}

	// Token: 0x060089A7 RID: 35239 RVA: 0x0038A978 File Offset: 0x00388B78
	public car p()
	{
		return this.ad;
	}

	// Token: 0x060089A8 RID: 35240 RVA: 0x0038A980 File Offset: 0x00388B80
	public new void a(car A_0)
	{
		this.ad = A_0;
	}

	// Token: 0x060089A9 RID: 35241 RVA: 0x0038A98C File Offset: 0x00388B8C
	public List<string> am()
	{
		return this.ae;
	}

	// Token: 0x060089AA RID: 35242 RVA: 0x0038A994 File Offset: 0x00388B94
	public void b(List<string> A_0)
	{
		this.ae = A_0;
	}

	// Token: 0x060089AB RID: 35243 RVA: 0x0038A9A0 File Offset: 0x00388BA0
	public List<string> j()
	{
		return this.af;
	}

	// Token: 0x060089AC RID: 35244 RVA: 0x0038A9A8 File Offset: 0x00388BA8
	public new void a(List<string> A_0)
	{
		this.af = A_0;
	}

	// Token: 0x060089AD RID: 35245 RVA: 0x0038A9B4 File Offset: 0x00388BB4
	public List<bns> n()
	{
		return this.al;
	}

	// Token: 0x060089AE RID: 35246 RVA: 0x0038A9BC File Offset: 0x00388BBC
	public new void a(List<bns> A_0)
	{
		this.al = A_0;
	}

	// Token: 0x060089AF RID: 35247 RVA: 0x0038A9C8 File Offset: 0x00388BC8
	public q5 u()
	{
		return this.am;
	}

	// Token: 0x060089B0 RID: 35248 RVA: 0x0038A9D0 File Offset: 0x00388BD0
	public new void a(q5 A_0)
	{
		this.am = A_0;
	}

	// Token: 0x060089B1 RID: 35249 RVA: 0x0038A9DC File Offset: 0x00388BDC
	public override int yj()
	{
		if (this.e() == btz.j || this.e() == btz.k)
		{
			return base.yj() * 2;
		}
		return base.yj();
	}

	// Token: 0x060089B2 RID: 35250 RVA: 0x0038AA08 File Offset: 0x00388C08
	public bke()
	{
		base.g(false);
	}

	// Token: 0x060089B3 RID: 35251 RVA: 0x0038AAA4 File Offset: 0x00388CA4
	public override bk3 tw()
	{
		bke bke = new bke();
		this.ai7(bke);
		return bke;
	}

	// Token: 0x060089B4 RID: 35252 RVA: 0x0038AAC0 File Offset: 0x00388CC0
	protected override void ai7(bk3 A_0)
	{
		base.ai7(A_0);
		bke bke = (bke)A_0;
		bke.k = this.k;
		bke.l = this.l;
		bke.d = new List<a1q>();
		if (this.d != null)
		{
			bke.d.AddRange(this.d);
		}
		bke.ab = this.ab;
		bke.ac = this.ac;
		bke.f = this.f;
		bke.h = this.h;
		bke.g = this.g;
		bke.p = this.p;
		bke.n = this.n;
		bke.m = new List<edm>();
		if (this.m != null)
		{
			bke.m.AddRange(Enumerable.Select<edm, edm>(this.m, new Func<edm, edm>(bke.a.a.a)));
		}
		bke.i = this.i;
		bke.ac = this.ac;
		bke.b = this.b;
		bke.a = this.a;
		bke.z = this.z;
		bke.aa = this.aa;
		bke.c = this.c;
		bke.r = this.r;
		bke.u = this.u;
		bke.v = this.v;
		bke.s = this.s;
		bke.e = this.e;
		bke.w = this.w;
		bke.o = this.o;
		bke.t = this.t;
		bke.x = this.x;
		bke.ad = this.ad;
		bke.y = this.y;
		bke.ae = new List<string>(this.ae);
		bke.ag = this.ag;
		bke.ah = this.ah;
		bke.ai = this.ai;
		bke.aj = this.aj;
		bke.ak = this.ak;
		if (this.al != null)
		{
			bke.al.AddRange(Enumerable.Select<bns, bns>(this.al, new Func<bns, bns>(bke.a.a.a)));
		}
		bke.j = this.j;
		bke.af.AddRange(this.af);
		bke.am = this.am;
		bke.an = this.an;
		bke.ao = this.ao;
	}

	// Token: 0x060089B5 RID: 35253 RVA: 0x0038AD68 File Offset: 0x00388F68
	private new string a()
	{
		switch (this.a)
		{
		case btz.a:
			return "Пистолет";
		case btz.b:
			return "Пистолет-пулемёт";
		case btz.c:
			return "Автомат";
		case btz.d:
			return "Снайперская винтовка";
		case btz.e:
		{
			WeaponSubtype? weaponSubtype = euf.d(this);
			if (weaponSubtype != null)
			{
				return as3.ak[weaponSubtype.Value];
			}
			return "Дробовик";
		}
		case btz.f:
			return "Арбалет";
		case btz.g:
			return "Оружие ближнего боя";
		case btz.h:
			return "Гранатомёт";
		case btz.i:
			return "Термоядерная пушка";
		case btz.j:
			return "Пулемёт";
		case btz.k:
			return "Миниган";
		case btz.l:
			return "Ракетница";
		default:
			return "Weapon";
		}
	}

	// Token: 0x040036AF RID: 13999
	private new btz a;

	// Token: 0x040036B0 RID: 14000
	private float b = 1f;

	// Token: 0x040036B1 RID: 14001
	private int c = 15;

	// Token: 0x040036B2 RID: 14002
	private List<a1q> d = new List<a1q>();

	// Token: 0x040036B3 RID: 14003
	private new bool e;

	// Token: 0x040036B4 RID: 14004
	private ImpactSpeed f;

	// Token: 0x040036B5 RID: 14005
	private int g;

	// Token: 0x040036B6 RID: 14006
	private new float h;

	// Token: 0x040036B7 RID: 14007
	private float i;

	// Token: 0x040036B8 RID: 14008
	private new int j;

	// Token: 0x040036B9 RID: 14009
	internal double k = 0.05;

	// Token: 0x040036BA RID: 14010
	private double l = 1.0;

	// Token: 0x040036BB RID: 14011
	private List<edm> m = new List<edm>();

	// Token: 0x040036BC RID: 14012
	private AmmoType n;

	// Token: 0x040036BD RID: 14013
	private bool o;

	// Token: 0x040036BE RID: 14014
	private int p = 10;

	// Token: 0x040036BF RID: 14015
	private double q;

	// Token: 0x040036C0 RID: 14016
	public double r;

	// Token: 0x040036C1 RID: 14017
	public double s;

	// Token: 0x040036C2 RID: 14018
	private int t;

	// Token: 0x040036C3 RID: 14019
	public float u;

	// Token: 0x040036C4 RID: 14020
	public new double v;

	// Token: 0x040036C5 RID: 14021
	private double? w;

	// Token: 0x040036C6 RID: 14022
	private int? x;

	// Token: 0x040036C7 RID: 14023
	private double y = 1.0;

	// Token: 0x040036C8 RID: 14024
	private string z;

	// Token: 0x040036C9 RID: 14025
	private string aa;

	// Token: 0x040036CA RID: 14026
	private esu ab;

	// Token: 0x040036CB RID: 14027
	private bhx ac;

	// Token: 0x040036CC RID: 14028
	private car ad;

	// Token: 0x040036CD RID: 14029
	private List<string> ae = new List<string>();

	// Token: 0x040036CE RID: 14030
	private List<string> af = new List<string>();

	// Token: 0x040036CF RID: 14031
	private WeaponSubtype? ag;

	// Token: 0x040036D0 RID: 14032
	private string ah;

	// Token: 0x040036D1 RID: 14033
	private bool ai;

	// Token: 0x040036D2 RID: 14034
	private int? aj;

	// Token: 0x040036D3 RID: 14035
	private string ak;

	// Token: 0x040036D4 RID: 14036
	private List<bns> al = new List<bns>();

	// Token: 0x040036D5 RID: 14037
	private q5 am;

	// Token: 0x040036D6 RID: 14038
	public cum an;

	// Token: 0x040036D7 RID: 14039
	public bool ao;

	// Token: 0x02001952 RID: 6482
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06008A55 RID: 35413 RVA: 0x0038CC50 File Offset: 0x0038AE50
		internal edm a(edm A_0)
		{
			return A_0.g();
		}

		// Token: 0x06008A56 RID: 35414 RVA: 0x0038CC58 File Offset: 0x0038AE58
		internal bns a(bns A_0)
		{
			return A_0.h1();
		}

		// Token: 0x04003703 RID: 14083
		public static readonly bke.a a = new bke.a();

		// Token: 0x04003704 RID: 14084
		public static Func<edm, edm> b;

		// Token: 0x04003705 RID: 14085
		public static Func<bns, bns> c;
	}
}
