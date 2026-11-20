using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Ouroboros.Common.Data;
using TimelapseVertigo.Rules;

// Token: 0x0200067F RID: 1663
[eiz("TG")]
[Serializable]
public sealed class cyt : ISerializable, IDeserializationCallback
{
	// Token: 0x06002A7D RID: 10877 RVA: 0x000EF5D4 File Offset: 0x000ED7D4
	private cyt(SerializationInfo A_0, StreamingContext A_1)
	{
		this.a = (au2)A_0.GetValue("TG:PC", typeof(au2));
		this.b = (c2w)A_0.GetValue("TG:CL", typeof(c2w));
		this.d = (HashSet<string>)A_0.GetValue("TG:RL", typeof(HashSet<string>));
		this.e = (PropertyCollection)A_0.GetValue("TG:GP", typeof(PropertyCollection));
		this.f = (bmw)A_0.GetValue("TG:Q", typeof(bmw));
		this.g = (bau)A_0.GetValue("TG:B", typeof(bau));
		this.h = (oj)A_0.GetValue("TG:F", typeof(oj));
		di7.ReadDictionary<string, string>("TG:FLRM", ref this.i, A_0);
		di7.ReadList<bw0>("TG:LPA", ref this.j, A_0);
		this.l = (TimeSpan)A_0.GetValue("TG:WT", typeof(TimeSpan));
		di7.ReadList<cqh>("TG:NM", ref this.o, A_0);
		if (ell.a() >= 104)
		{
			this.p = (A_0.GetValue("TG:G", typeof(e82)) as e82);
		}
		else
		{
			this.p = new e82();
		}
		if (ell.a() >= 195)
		{
			this.q = (GameDifficulty)A_0.GetValue("TG:D", typeof(GameDifficulty));
		}
		else
		{
			this.q = GameDifficulty.Normal;
		}
		if (ell.a() >= 209)
		{
			this.m = (TimeSpan)A_0.GetValue("TG:TWT", typeof(TimeSpan));
		}
		else
		{
			this.m = this.l;
		}
		if (ell.a() >= 311)
		{
			this.t = (A_0.GetValue("TG:MC", typeof(euk)) as euk);
		}
		else
		{
			this.t = new euk();
		}
		if (ell.a() >= 314)
		{
			this.u = A_0.GetInt32("TG:GS");
		}
		else
		{
			this.u = cuo.a.Next();
		}
		if (ell.a() >= 318)
		{
			this.v = (Version)A_0.GetValue("TG:CV", typeof(Version));
			di7.ReadDictionary<string, cxp>("TG:LP", ref this.w, A_0);
			this.x = (A_0.GetValue("TG:GPA", typeof(HashSet<string>)) as HashSet<string>);
		}
		else
		{
			this.v = new Version(1, 0, 0, 1);
			this.w = new Dictionary<string, cxp>();
			this.x = new HashSet<string>();
		}
		if (ell.a() >= 332)
		{
			this.s = A_0.GetInt32("TG:IF");
		}
		if (ell.a() >= 335)
		{
			this.z = (A_0.GetValue("TG:TURE", typeof(HashSet<string>)) as HashSet<string>);
			this.aa = (A_0.GetValue("TG:ASRE", typeof(HashSet<string>)) as HashSet<string>);
			di7.ReadDictionary<string, a0a>("TG:ALRE", ref this.ab, A_0);
		}
		else
		{
			this.z = new HashSet<string>();
			this.aa = new HashSet<string>();
			this.ab = new Dictionary<string, a0a>();
		}
		if (ell.a() >= 339)
		{
			this.c = (A_0.GetValue("TG:EO", typeof(Point?)) as Point?);
		}
		if (ell.a() >= 359)
		{
			di7.ReadList<bw0>("TG:LPSA", ref this.k, A_0);
		}
		else
		{
			this.k = new List<bw0>();
		}
		if (ell.a() >= 387)
		{
			di7.ReadDictionary<string, alg>("TG:LNF", ref this.ac, A_0);
		}
		else
		{
			this.ac = new Dictionary<string, alg>();
		}
		if (ell.a() >= 429)
		{
			di7.ReadDictionary<string, eaj>("TG:TNF", ref this.ad, A_0);
		}
		else
		{
			this.ad = new Dictionary<string, eaj>();
		}
		if (ell.a() >= 432)
		{
			this.ae = (A_0.GetValue("TG:MO", typeof(ee2)) as ee2);
		}
		else
		{
			this.ae = new ee2();
		}
		if (ell.a() >= 438)
		{
			di7.ReadList<cd2>("TG:DLE", ref this.af, A_0);
		}
		else
		{
			this.af = new List<cd2>();
		}
		if (ell.a() >= 476)
		{
			this.ag = (A_0.GetValue("TG:GU", typeof(HashSet<string>)) as HashSet<string>);
		}
		else
		{
			this.ag = new HashSet<string>();
		}
		if (ell.a() >= 533)
		{
			this.ah = (A_0.GetValue("TG:PRF", typeof(HashSet<string>)) as HashSet<string>);
			di7.ReadDictionary<string, double>("TG:FRCC", ref this.ai, A_0);
			this.aj = new Random();
		}
		else
		{
			this.ah = new HashSet<string>();
			this.ai = new Dictionary<string, double>();
		}
		if (ell.a() >= 533)
		{
			this.ak = (A_0.GetValue("TG:UD", typeof(HashSet<string>)) as HashSet<string>);
		}
		else
		{
			this.ak = new HashSet<string>();
		}
		if (ell.a() >= 607)
		{
			this.y = (A_0.GetValue("TG:LGP", typeof(HashSet<string>)) as HashSet<string>);
		}
		else
		{
			this.y = new HashSet<string>();
		}
		if (ell.a() >= 707)
		{
			this.r = (A_0.GetValue("TG:DS", typeof(GameDifficultySettings)) as GameDifficultySettings);
		}
	}

	// Token: 0x06002A7E RID: 10878 RVA: 0x000EFD04 File Offset: 0x000EDF04
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("TG:PC", this.a);
		info.AddValue("TG:CL", this.b);
		info.AddValue("TG:RL", this.d);
		info.AddValue("TG:GP", this.e);
		info.AddValue("TG:Q", this.f);
		info.AddValue("TG:B", this.g);
		info.AddValue("TG:F", this.h);
		di7.WriteDictionary<string, string>("TG:FLRM", this.i, info);
		di7.WriteList<bw0>("TG:LPA", this.j, info);
		info.AddValue("TG:WT", this.l);
		di7.WriteList<cqh>("TG:NM", this.o, info);
		info.AddValue("TG:G", this.p);
		info.AddValue("TG:D", this.q);
		info.AddValue("TG:TWT", this.m);
		info.AddValue("TG:MC", this.t);
		info.AddValue("TG:GS", this.u);
		info.AddValue("TG:CV", this.v);
		di7.WriteDictionary<string, cxp>("TG:LP", this.w, info);
		info.AddValue("TG:GPA", this.x);
		info.AddValue("TG:IF", this.s);
		info.AddValue("TG:TURE", this.z);
		info.AddValue("TG:ASRE", this.aa);
		di7.WriteDictionary<string, a0a>("TG:ALRE", this.ab, info);
		info.AddValue("TG:EO", this.c);
		di7.WriteList<bw0>("TG:LPSA", this.k, info);
		di7.WriteDictionary<string, alg>("TG:LNF", this.ac, info);
		di7.WriteDictionary<string, eaj>("TG:TNF", this.ad, info);
		info.AddValue("TG:MO", this.ae);
		di7.WriteList<cd2>("TG:DLE", this.af, info);
		info.AddValue("TG:GU", this.ag);
		info.AddValue("TG:PRF", this.ah);
		di7.WriteDictionary<string, double>("TG:FRCC", this.ai, info);
		info.AddValue("TG:FR", this.aj);
		info.AddValue("TG:UD", this.ak);
		info.AddValue("TG:LGP", this.y);
		info.AddValue("TG:DS", this.r);
	}

	// Token: 0x06002A7F RID: 10879 RVA: 0x000EFF8C File Offset: 0x000EE18C
	public au2 v()
	{
		return this.a;
	}

	// Token: 0x06002A80 RID: 10880 RVA: 0x000EFF94 File Offset: 0x000EE194
	public void a(au2 A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06002A81 RID: 10881 RVA: 0x000EFFA0 File Offset: 0x000EE1A0
	public c2w c()
	{
		return this.b;
	}

	// Token: 0x06002A82 RID: 10882 RVA: 0x000EFFA8 File Offset: 0x000EE1A8
	public void a(c2w A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06002A83 RID: 10883 RVA: 0x000EFFB4 File Offset: 0x000EE1B4
	public Point? g()
	{
		return this.c;
	}

	// Token: 0x06002A84 RID: 10884 RVA: 0x000EFFBC File Offset: 0x000EE1BC
	public void a(Point? A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06002A85 RID: 10885 RVA: 0x000EFFC8 File Offset: 0x000EE1C8
	public HashSet<string> af()
	{
		return this.d;
	}

	// Token: 0x06002A86 RID: 10886 RVA: 0x000EFFD0 File Offset: 0x000EE1D0
	public Dictionary<string, string> aa()
	{
		return this.i;
	}

	// Token: 0x06002A87 RID: 10887 RVA: 0x000EFFD8 File Offset: 0x000EE1D8
	public PropertyCollection r()
	{
		return this.e;
	}

	// Token: 0x06002A88 RID: 10888 RVA: 0x000EFFE0 File Offset: 0x000EE1E0
	public bmw t()
	{
		return this.f;
	}

	// Token: 0x06002A89 RID: 10889 RVA: 0x000EFFE8 File Offset: 0x000EE1E8
	public void a(bmw A_0)
	{
		this.f = A_0;
	}

	// Token: 0x06002A8A RID: 10890 RVA: 0x000EFFF4 File Offset: 0x000EE1F4
	public bau m()
	{
		return this.g;
	}

	// Token: 0x06002A8B RID: 10891 RVA: 0x000EFFFC File Offset: 0x000EE1FC
	public void a(bau A_0)
	{
		this.g = A_0;
	}

	// Token: 0x06002A8C RID: 10892 RVA: 0x000F0008 File Offset: 0x000EE208
	public Texture2D f()
	{
		return this.n;
	}

	// Token: 0x06002A8D RID: 10893 RVA: 0x000F0010 File Offset: 0x000EE210
	public void a(Texture2D A_0)
	{
		this.n = A_0;
	}

	// Token: 0x06002A8E RID: 10894 RVA: 0x000F001C File Offset: 0x000EE21C
	public oj ac()
	{
		return this.h;
	}

	// Token: 0x06002A8F RID: 10895 RVA: 0x000F0024 File Offset: 0x000EE224
	public void a(oj A_0)
	{
		this.h = A_0;
	}

	// Token: 0x06002A90 RID: 10896 RVA: 0x000F0030 File Offset: 0x000EE230
	public List<bw0> x()
	{
		return this.j;
	}

	// Token: 0x06002A91 RID: 10897 RVA: 0x000F0038 File Offset: 0x000EE238
	public List<bw0> j()
	{
		return this.k;
	}

	// Token: 0x06002A92 RID: 10898 RVA: 0x000F0040 File Offset: 0x000EE240
	public TimeSpan p()
	{
		return this.l;
	}

	// Token: 0x06002A93 RID: 10899 RVA: 0x000F0048 File Offset: 0x000EE248
	public void a(TimeSpan A_0)
	{
		this.l = A_0;
	}

	// Token: 0x06002A94 RID: 10900 RVA: 0x000F0054 File Offset: 0x000EE254
	public TimeSpan o()
	{
		return this.m;
	}

	// Token: 0x06002A95 RID: 10901 RVA: 0x000F005C File Offset: 0x000EE25C
	public void b(TimeSpan A_0)
	{
		this.m = A_0;
	}

	// Token: 0x06002A96 RID: 10902 RVA: 0x000F0068 File Offset: 0x000EE268
	public List<cqh> w()
	{
		return this.o;
	}

	// Token: 0x06002A97 RID: 10903 RVA: 0x000F0070 File Offset: 0x000EE270
	public e82 b()
	{
		return this.p;
	}

	// Token: 0x06002A98 RID: 10904 RVA: 0x000F0078 File Offset: 0x000EE278
	public GameDifficulty i()
	{
		return this.q;
	}

	// Token: 0x06002A99 RID: 10905 RVA: 0x000F0080 File Offset: 0x000EE280
	public void a(GameDifficulty A_0)
	{
		this.q = A_0;
	}

	// Token: 0x06002A9A RID: 10906 RVA: 0x000F008C File Offset: 0x000EE28C
	public GameDifficulty ae()
	{
		return euf.b().EncounterDifficulty;
	}

	// Token: 0x06002A9B RID: 10907 RVA: 0x000F0098 File Offset: 0x000EE298
	public GameDifficulty a()
	{
		return euf.b().EncounterDifficulty;
	}

	// Token: 0x06002A9C RID: 10908 RVA: 0x000F00A4 File Offset: 0x000EE2A4
	public euk u()
	{
		return this.t;
	}

	// Token: 0x06002A9D RID: 10909 RVA: 0x000F00AC File Offset: 0x000EE2AC
	public int l()
	{
		return this.u;
	}

	// Token: 0x06002A9E RID: 10910 RVA: 0x000F00B4 File Offset: 0x000EE2B4
	public void a(int A_0)
	{
		this.u = A_0;
	}

	// Token: 0x06002A9F RID: 10911 RVA: 0x000F00C0 File Offset: 0x000EE2C0
	public Version y()
	{
		return this.v;
	}

	// Token: 0x06002AA0 RID: 10912 RVA: 0x000F00C8 File Offset: 0x000EE2C8
	public Dictionary<string, cxp> n()
	{
		return this.w;
	}

	// Token: 0x06002AA1 RID: 10913 RVA: 0x000F00D0 File Offset: 0x000EE2D0
	public HashSet<string> k()
	{
		return this.z;
	}

	// Token: 0x06002AA2 RID: 10914 RVA: 0x000F00D8 File Offset: 0x000EE2D8
	public HashSet<string> d()
	{
		return this.aa;
	}

	// Token: 0x06002AA3 RID: 10915 RVA: 0x000F00E0 File Offset: 0x000EE2E0
	public Dictionary<string, a0a> ab()
	{
		return this.ab;
	}

	// Token: 0x06002AA4 RID: 10916 RVA: 0x000F00E8 File Offset: 0x000EE2E8
	public Dictionary<string, alg> z()
	{
		return this.ac;
	}

	// Token: 0x06002AA5 RID: 10917 RVA: 0x000F00F0 File Offset: 0x000EE2F0
	public ee2 q()
	{
		return this.ae;
	}

	// Token: 0x06002AA6 RID: 10918 RVA: 0x000F00F8 File Offset: 0x000EE2F8
	public List<cd2> s()
	{
		return this.af;
	}

	// Token: 0x06002AA7 RID: 10919 RVA: 0x000F0100 File Offset: 0x000EE300
	public HashSet<string> ad()
	{
		return this.ag;
	}

	// Token: 0x06002AA8 RID: 10920 RVA: 0x000F0108 File Offset: 0x000EE308
	public cyt()
	{
		this.v = (Version)dm9.d.Clone();
		this.e.PropertyChanged += this.a;
		this.t = new euk();
	}

	// Token: 0x06002AA9 RID: 10921 RVA: 0x000F025C File Offset: 0x000EE45C
	public alg a(string A_0, bool A_1 = true)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		bfc bfc = serviceOrThrow.ar0(A_0, serviceOrThrow.aqu());
		string key = (bfc != null) ? bfc.Id : A_0;
		alg alg;
		this.ac.TryGetValue(key, out alg);
		if (alg == null && A_1)
		{
			alg = new alg();
			this.ac[key] = alg;
		}
		return alg;
	}

	// Token: 0x06002AAA RID: 10922 RVA: 0x000F02C0 File Offset: 0x000EE4C0
	public bfc h()
	{
		if (this.b != null)
		{
			return bpo.GetServiceOrThrow<cnk>().ar0(this.b.b(), this);
		}
		return null;
	}

	// Token: 0x06002AAB RID: 10923 RVA: 0x000F02E8 File Offset: 0x000EE4E8
	public eaj a(string A_0, string A_1, bool A_2 = true)
	{
		string key = dfz.a(A_0, A_1);
		eaj eaj;
		this.ad.TryGetValue(key, out eaj);
		if (eaj == null && A_2)
		{
			eaj = new eaj();
			this.ad[key] = eaj;
		}
		return eaj;
	}

	// Token: 0x06002AAC RID: 10924 RVA: 0x000F032C File Offset: 0x000EE52C
	public void b(string A_0, string A_1)
	{
		this.a(A_0, A_1, true).a = true;
		bpo.GetServiceOrThrow<e5f>().asg(A_0, A_1);
	}

	// Token: 0x06002AAD RID: 10925 RVA: 0x000F034C File Offset: 0x000EE54C
	public void b(string A_0)
	{
		this.a(A_0, true).b = true;
		bpo.GetServiceOrThrow<e5f>().asf(A_0);
	}

	// Token: 0x06002AAE RID: 10926 RVA: 0x000F0368 File Offset: 0x000EE568
	public void a(string A_0, string A_1)
	{
		this.a(A_0, A_1, true).b = true;
		bpo.GetServiceOrThrow<e5f>().asg(A_0, A_1);
	}

	// Token: 0x06002AAF RID: 10927 RVA: 0x000F0388 File Offset: 0x000EE588
	public void c(string A_0, string A_1 = null)
	{
		string a_;
		if (A_1 != null)
		{
			a_ = A_1;
		}
		else
		{
			a_ = this.b.b();
		}
		alg alg = this.a(a_, true);
		if (!alg.c.Contains(A_0))
		{
			alg.c.Add(A_0);
		}
		bpo.GetServiceOrThrow<e5f>().asf(a_);
	}

	// Token: 0x06002AB0 RID: 10928 RVA: 0x000F03E0 File Offset: 0x000EE5E0
	public dpn e()
	{
		PropertyCollection propertyCollection = new PropertyCollection();
		propertyCollection["player"] = this.v();
		propertyCollection["sys_game"] = this;
		propertyCollection[e49.a] = new edj(this.v().Gender);
		return new dpn(this.e, new bq8[]
		{
			propertyCollection
		});
	}

	// Token: 0x06002AB1 RID: 10929 RVA: 0x000F0440 File Offset: 0x000EE640
	public void c(string A_0)
	{
		czh.a(A_0, "filePath");
		eoq.SerializeToBinaryFileCompressed<cyt>(A_0, this, dds.a(), eh9.c, true);
	}

	// Token: 0x06002AB2 RID: 10930 RVA: 0x000F0460 File Offset: 0x000EE660
	public static cyt a(string A_0)
	{
		czh.a(A_0, "filePath");
		return eoq.DeserializeFromBinaryFileCompressed<cyt>(A_0, dds.a(), true);
	}

	// Token: 0x06002AB3 RID: 10931 RVA: 0x000F047C File Offset: 0x000EE67C
	public void a(bw0 A_0)
	{
		this.j.Add(A_0);
	}

	// Token: 0x06002AB4 RID: 10932 RVA: 0x000F048C File Offset: 0x000EE68C
	public void b(bw0 A_0)
	{
		this.k.Add(A_0);
	}

	// Token: 0x06002AB5 RID: 10933 RVA: 0x000F049C File Offset: 0x000EE69C
	public void b(cd2 A_0)
	{
		czh.a(A_0, "delayedEvent");
		this.af.Add(A_0);
	}

	// Token: 0x06002AB6 RID: 10934 RVA: 0x000F04B8 File Offset: 0x000EE6B8
	public bool a(cd2 A_0)
	{
		czh.a(A_0, "delayedEvent");
		using (List<cd2>.Enumerator enumerator = this.af.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.c() == A_0.c())
				{
					return false;
				}
			}
		}
		this.af.Add(A_0);
		return true;
	}

	// Token: 0x06002AB7 RID: 10935 RVA: 0x000F0540 File Offset: 0x000EE740
	public void d(string A_0)
	{
		for (int i = this.af.Count - 1; i >= 0; i--)
		{
			if (this.af[i].c() == A_0)
			{
				this.af.RemoveAt(i);
			}
		}
	}

	// Token: 0x06002AB8 RID: 10936 RVA: 0x000F0590 File Offset: 0x000EE790
	public List<cd2> e(string A_0)
	{
		List<cd2> list = new List<cd2>();
		foreach (cd2 cd in this.af)
		{
			if (cd.c() == A_0)
			{
				list.Add(cd);
			}
		}
		return list;
	}

	// Token: 0x06002AB9 RID: 10937 RVA: 0x000F0604 File Offset: 0x000EE804
	private void a(object A_0, PropertyChangedEventArgs A_1)
	{
	}

	// Token: 0x06002ABA RID: 10938 RVA: 0x000F0608 File Offset: 0x000EE808
	public void OnDeserialization(object sender)
	{
		this.e.PropertyChanged += this.a;
	}

	// Token: 0x04001711 RID: 5905
	private au2 a;

	// Token: 0x04001712 RID: 5906
	private c2w b;

	// Token: 0x04001713 RID: 5907
	private Point? c;

	// Token: 0x04001714 RID: 5908
	private HashSet<string> d = new HashSet<string>();

	// Token: 0x04001715 RID: 5909
	private PropertyCollection e = new PropertyCollection();

	// Token: 0x04001716 RID: 5910
	private bmw f = new bmw();

	// Token: 0x04001717 RID: 5911
	private bau g;

	// Token: 0x04001718 RID: 5912
	private oj h;

	// Token: 0x04001719 RID: 5913
	private Dictionary<string, string> i = new Dictionary<string, string>();

	// Token: 0x0400171A RID: 5914
	private List<bw0> j = new List<bw0>();

	// Token: 0x0400171B RID: 5915
	private List<bw0> k = new List<bw0>();

	// Token: 0x0400171C RID: 5916
	private TimeSpan l;

	// Token: 0x0400171D RID: 5917
	private TimeSpan m;

	// Token: 0x0400171E RID: 5918
	[NonSerialized]
	private Texture2D n;

	// Token: 0x0400171F RID: 5919
	private List<cqh> o = new List<cqh>();

	// Token: 0x04001720 RID: 5920
	private e82 p = new e82();

	// Token: 0x04001721 RID: 5921
	private GameDifficulty q = GameDifficulty.Normal;

	// Token: 0x04001722 RID: 5922
	public GameDifficultySettings r;

	// Token: 0x04001723 RID: 5923
	public int s;

	// Token: 0x04001724 RID: 5924
	private euk t;

	// Token: 0x04001725 RID: 5925
	private int u = cuo.a.Next();

	// Token: 0x04001726 RID: 5926
	private Version v;

	// Token: 0x04001727 RID: 5927
	private Dictionary<string, cxp> w = new Dictionary<string, cxp>();

	// Token: 0x04001728 RID: 5928
	public HashSet<string> x = new HashSet<string>();

	// Token: 0x04001729 RID: 5929
	public HashSet<string> y = new HashSet<string>();

	// Token: 0x0400172A RID: 5930
	private HashSet<string> z = new HashSet<string>();

	// Token: 0x0400172B RID: 5931
	private HashSet<string> aa = new HashSet<string>();

	// Token: 0x0400172C RID: 5932
	private Dictionary<string, a0a> ab = new Dictionary<string, a0a>();

	// Token: 0x0400172D RID: 5933
	private Dictionary<string, alg> ac = new Dictionary<string, alg>();

	// Token: 0x0400172E RID: 5934
	private Dictionary<string, eaj> ad = new Dictionary<string, eaj>();

	// Token: 0x0400172F RID: 5935
	private ee2 ae = new ee2();

	// Token: 0x04001730 RID: 5936
	private List<cd2> af = new List<cd2>();

	// Token: 0x04001731 RID: 5937
	private HashSet<string> ag = new HashSet<string>();

	// Token: 0x04001732 RID: 5938
	internal HashSet<string> ah = new HashSet<string>();

	// Token: 0x04001733 RID: 5939
	internal Dictionary<string, double> ai = new Dictionary<string, double>();

	// Token: 0x04001734 RID: 5940
	[NonSerialized]
	internal Random aj;

	// Token: 0x04001735 RID: 5941
	internal HashSet<string> ak = new HashSet<string>();
}
