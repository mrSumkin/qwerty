using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using Ouroboros.Common.Data;
using TimelapseVertigo.Rules.Items;

// Token: 0x0200194A RID: 6474
[XmlInclude(typeof(bke))]
[XmlInclude(typeof(dfg))]
[eiz("I")]
[XmlInclude(typeof(ebl))]
[XmlInclude(typeof(avz))]
[XmlInclude(typeof(a1k))]
[XmlInclude(typeof(ett))]
[XmlInclude(typeof(cv9))]
[XmlInclude(typeof(c27))]
[XmlInclude(typeof(c5s))]
[XmlInclude(typeof(bqu))]
[XmlInclude(typeof(b3n))]
[XmlInclude(typeof(ak0))]
[XmlInclude(typeof(dj3))]
[XmlInclude(typeof(diz))]
[XmlInclude(typeof(eya))]
[XmlInclude(typeof(c43))]
[XmlInclude(typeof(dgn))]
[XmlInclude(typeof(ebz))]
[XmlInclude(typeof(cdk))]
[XmlInclude(typeof(dxw))]
[Serializable]
public abstract class bk3 : ISerializable
{
	// Token: 0x060089D8 RID: 35288 RVA: 0x0038B560 File Offset: 0x00389760
	protected bk3(SerializationInfo A_0, StreamingContext A_1)
	{
		this.b = A_0.GetString("I:C");
		this.c = A_0.GetString("I:N");
		this.d = (cr1)A_0.GetValue("I:Q", typeof(cr1));
		this.f = A_0.GetString("I:D");
		this.g = A_0.GetString("I:VM");
		this.i = A_0.GetInt32("I:MS");
		this.j = A_0.GetBoolean("I:C2");
		this.l = (PropertyCollection)A_0.GetValue("I:CP", typeof(PropertyCollection));
		if (this.l == null)
		{
			this.l = new PropertyCollection();
		}
		if (ell.a() >= 6)
		{
			this.k = (A_0.GetValue("I:CV", typeof(double?)) as double?);
			this.m = (A_0.GetValue("I:IVF", typeof(d76)) as d76);
		}
		else
		{
			this.k = new double?(A_0.GetDouble("I:CV"));
		}
		if (ell.a() >= 45)
		{
			this.e = A_0.GetInt32("I:L");
		}
		else
		{
			this.e = 1;
		}
		if (ell.a() >= 55)
		{
			di7.ReadList<aia>("I:CS", ref this.h, A_0);
		}
		else
		{
			this.h = new List<aia>();
			aia aia = (aia)A_0.GetValue("I:C1", typeof(aia));
			if (aia != null)
			{
				this.h.Add(aia);
			}
		}
		if (ell.a() >= 145)
		{
			this.n = A_0.GetBoolean("I:I");
			this.o = (ItemRepairCategory)A_0.GetValue("I:R", typeof(ItemRepairCategory));
		}
		else
		{
			this.n = true;
		}
		if (ell.a() >= 158)
		{
			this.p = (ItemStealingCategory)A_0.GetValue("I:S", typeof(ItemStealingCategory));
		}
		if (ell.a() >= 191)
		{
			this.q = (a0)A_0.GetValue("I:T", typeof(a0));
		}
		else
		{
			this.q = global::a0.b;
		}
		if (ell.a() >= 192)
		{
			this.r = A_0.GetDouble("I:W");
		}
		else
		{
			this.r = 0.0;
		}
		if (ell.a() >= 198)
		{
			this.s = A_0.GetBoolean("I:CR");
		}
		else
		{
			this.s = true;
		}
		if (ell.a() >= 374)
		{
			this.t = (A_0.GetValue("I:MB", typeof(int?)) as int?);
		}
		if (ell.a() >= 509)
		{
			this.u = A_0.GetBoolean("I:UR");
		}
		if (ell.a() >= 608)
		{
			this.v = A_0.GetBoolean("I:QQ");
		}
	}

	// Token: 0x060089D9 RID: 35289 RVA: 0x0038B8F0 File Offset: 0x00389AF0
	public virtual void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("I:C", this.b);
		info.AddValue("I:N", this.c);
		info.AddValue("I:Q", this.d);
		info.AddValue("I:L", this.e);
		info.AddValue("I:D", this.f);
		info.AddValue("I:VM", this.g);
		info.AddValue("I:MS", this.i);
		info.AddValue("I:C2", this.j);
		info.AddValue("I:CV", this.k);
		info.AddValue("I:CP", this.l);
		info.AddValue("I:IVF", this.m);
		di7.WriteList<aia>("I:CS", this.h, info);
		info.AddValue("I:I", this.n);
		info.AddValue("I:R", this.o);
		info.AddValue("I:S", this.p);
		info.AddValue("I:T", this.q);
		info.AddValue("I:W", this.r);
		info.AddValue("I:CR", this.s);
		info.AddValue("I:MB", this.t);
		info.AddValue("I:UR", this.u);
		info.AddValue("I:QQ", this.v);
	}

	// Token: 0x060089DA RID: 35290 RVA: 0x0038BA80 File Offset: 0x00389C80
	public string az()
	{
		return this.c;
	}

	// Token: 0x060089DB RID: 35291 RVA: 0x0038BA88 File Offset: 0x00389C88
	public void g(string A_0)
	{
		this.c = A_0;
	}

	// Token: 0x060089DC RID: 35292 RVA: 0x0038BA94 File Offset: 0x00389C94
	public string a0()
	{
		return this.f;
	}

	// Token: 0x060089DD RID: 35293 RVA: 0x0038BA9C File Offset: 0x00389C9C
	public void i(string A_0)
	{
		this.f = A_0;
	}

	// Token: 0x060089DE RID: 35294 RVA: 0x0038BAA8 File Offset: 0x00389CA8
	public string a3()
	{
		return this.g;
	}

	// Token: 0x060089DF RID: 35295 RVA: 0x0038BAB0 File Offset: 0x00389CB0
	public void f(string A_0)
	{
		this.g = A_0;
	}

	// Token: 0x060089E0 RID: 35296 RVA: 0x0038BABC File Offset: 0x00389CBC
	public List<aia> a2()
	{
		return this.h;
	}

	// Token: 0x060089E1 RID: 35297 RVA: 0x0038BAC4 File Offset: 0x00389CC4
	public void b(List<aia> A_0)
	{
		this.h = A_0;
	}

	// Token: 0x060089E2 RID: 35298 RVA: 0x0038BAD0 File Offset: 0x00389CD0
	public string a5()
	{
		return this.b;
	}

	// Token: 0x060089E3 RID: 35299 RVA: 0x0038BAD8 File Offset: 0x00389CD8
	public void k(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x060089E4 RID: 35300 RVA: 0x0038BAE4 File Offset: 0x00389CE4
	public int be()
	{
		return this.i;
	}

	// Token: 0x060089E5 RID: 35301 RVA: 0x0038BAEC File Offset: 0x00389CEC
	public void f(int A_0)
	{
		this.i = A_0;
	}

	// Token: 0x060089E6 RID: 35302 RVA: 0x0038BAF8 File Offset: 0x00389CF8
	public bool bg()
	{
		return this.j;
	}

	// Token: 0x060089E7 RID: 35303 RVA: 0x0038BB00 File Offset: 0x00389D00
	public void f(bool A_0)
	{
		this.j = A_0;
	}

	// Token: 0x060089E8 RID: 35304 RVA: 0x0038BB0C File Offset: 0x00389D0C
	public virtual string tv()
	{
		return "Разное";
	}

	// Token: 0x060089E9 RID: 35305 RVA: 0x0038BB14 File Offset: 0x00389D14
	public virtual string yi()
	{
		return this.tv();
	}

	// Token: 0x060089EA RID: 35306 RVA: 0x0038BB1C File Offset: 0x00389D1C
	public cr1 bc()
	{
		return this.d;
	}

	// Token: 0x060089EB RID: 35307 RVA: 0x0038BB24 File Offset: 0x00389D24
	public void a(cr1 A_0)
	{
		this.d = A_0;
	}

	// Token: 0x060089EC RID: 35308 RVA: 0x0038BB30 File Offset: 0x00389D30
	public int a8()
	{
		return this.e;
	}

	// Token: 0x060089ED RID: 35309 RVA: 0x0038BB38 File Offset: 0x00389D38
	public void g(int A_0)
	{
		this.e = A_0;
	}

	// Token: 0x060089EE RID: 35310 RVA: 0x0038BB44 File Offset: 0x00389D44
	public double? bf()
	{
		return this.k;
	}

	// Token: 0x060089EF RID: 35311 RVA: 0x0038BB4C File Offset: 0x00389D4C
	public void b(double? A_0)
	{
		this.k = A_0;
	}

	// Token: 0x060089F0 RID: 35312 RVA: 0x0038BB58 File Offset: 0x00389D58
	public d76 a6()
	{
		return this.m;
	}

	// Token: 0x060089F1 RID: 35313 RVA: 0x0038BB60 File Offset: 0x00389D60
	public void a(d76 A_0)
	{
		this.m = A_0;
	}

	// Token: 0x060089F2 RID: 35314 RVA: 0x0038BB6C File Offset: 0x00389D6C
	public PropertyCollection a7()
	{
		return this.l;
	}

	// Token: 0x060089F3 RID: 35315 RVA: 0x0038BB74 File Offset: 0x00389D74
	public void a(PropertyCollection A_0)
	{
		this.l = A_0;
	}

	// Token: 0x060089F4 RID: 35316 RVA: 0x0038BB80 File Offset: 0x00389D80
	public virtual int yj()
	{
		if (this.a8() > 0)
		{
			int num = dwh.d + this.a8() * dwh.e;
			if (this.a8() > dwh.f)
			{
				num += (this.a8() - dwh.f) * dwh.g;
			}
			return num;
		}
		return dwh.c;
	}

	// Token: 0x060089F5 RID: 35317 RVA: 0x0038BBD8 File Offset: 0x00389DD8
	public bool a9()
	{
		return this.n;
	}

	// Token: 0x060089F6 RID: 35318 RVA: 0x0038BBE0 File Offset: 0x00389DE0
	public void g(bool A_0)
	{
		this.n = A_0;
	}

	// Token: 0x060089F7 RID: 35319 RVA: 0x0038BBEC File Offset: 0x00389DEC
	public ItemRepairCategory ay()
	{
		return this.o;
	}

	// Token: 0x060089F8 RID: 35320 RVA: 0x0038BBF4 File Offset: 0x00389DF4
	public void a(ItemRepairCategory A_0)
	{
		this.o = A_0;
	}

	// Token: 0x060089F9 RID: 35321 RVA: 0x0038BC00 File Offset: 0x00389E00
	public ItemStealingCategory bj()
	{
		return this.p;
	}

	// Token: 0x060089FA RID: 35322 RVA: 0x0038BC08 File Offset: 0x00389E08
	public void a(ItemStealingCategory A_0)
	{
		this.p = A_0;
	}

	// Token: 0x060089FB RID: 35323 RVA: 0x0038BC14 File Offset: 0x00389E14
	public a0 bi()
	{
		return this.q;
	}

	// Token: 0x060089FC RID: 35324 RVA: 0x0038BC1C File Offset: 0x00389E1C
	public void a(a0 A_0)
	{
		this.q = A_0;
	}

	// Token: 0x060089FD RID: 35325 RVA: 0x0038BC28 File Offset: 0x00389E28
	public double a4()
	{
		return this.r;
	}

	// Token: 0x060089FE RID: 35326 RVA: 0x0038BC30 File Offset: 0x00389E30
	public void h(double A_0)
	{
		this.r = Math.Round(A_0, 2);
	}

	// Token: 0x060089FF RID: 35327 RVA: 0x0038BC40 File Offset: 0x00389E40
	public bool bd()
	{
		return this.s;
	}

	// Token: 0x06008A00 RID: 35328 RVA: 0x0038BC48 File Offset: 0x00389E48
	public void i(bool A_0)
	{
		this.s = A_0;
	}

	// Token: 0x06008A01 RID: 35329 RVA: 0x0038BC54 File Offset: 0x00389E54
	public int? ba()
	{
		return this.t;
	}

	// Token: 0x06008A02 RID: 35330 RVA: 0x0038BC5C File Offset: 0x00389E5C
	public void c(int? A_0)
	{
		this.t = A_0;
	}

	// Token: 0x06008A03 RID: 35331 RVA: 0x0038BC68 File Offset: 0x00389E68
	public bool bb()
	{
		return this.u;
	}

	// Token: 0x06008A04 RID: 35332 RVA: 0x0038BC70 File Offset: 0x00389E70
	public void h(bool A_0)
	{
		this.u = A_0;
	}

	// Token: 0x06008A05 RID: 35333
	public abstract bk3 tw();

	// Token: 0x06008A06 RID: 35334 RVA: 0x0038BC7C File Offset: 0x00389E7C
	public static Type a(Type A_0)
	{
		if (A_0 == null)
		{
			return null;
		}
		object[] customAttributes = A_0.GetCustomAttributes(typeof(elw), true);
		if (customAttributes.Length != 0)
		{
			return (customAttributes[0] as elw).a() ?? typeof(coh);
		}
		return typeof(coh);
	}

	// Token: 0x06008A07 RID: 35335 RVA: 0x0038BCDC File Offset: 0x00389EDC
	public override string ToString()
	{
		return this.c;
	}

	// Token: 0x06008A08 RID: 35336 RVA: 0x0038BCE4 File Offset: 0x00389EE4
	public virtual int tj(coh A_0)
	{
		return 0;
	}

	// Token: 0x06008A09 RID: 35337 RVA: 0x0038BCE8 File Offset: 0x00389EE8
	protected virtual void ai7(bk3 A_0)
	{
		czh.a(A_0, "clone");
		if (this.h != null)
		{
			A_0.h = new List<aia>();
			using (List<aia>.Enumerator enumerator = this.h.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					aia aia = enumerator.Current;
					A_0.h.Add(aia.b());
				}
				goto IL_6E;
			}
		}
		A_0.h = null;
		IL_6E:
		A_0.b = this.b;
		A_0.i = this.i;
		A_0.c = this.c;
		A_0.g = this.g;
		A_0.j = this.j;
		A_0.f = this.f;
		A_0.d = this.d;
		A_0.k = this.k;
		A_0.e = this.e;
		if (this.l == null)
		{
			A_0.l = new PropertyCollection();
		}
		else
		{
			foreach (Property property in this.l.Properties)
			{
				ICloneable cloneable = property.Value as ICloneable;
				object value;
				if (cloneable != null)
				{
					value = cloneable.Clone();
				}
				else
				{
					value = property.Value;
				}
				A_0.l[property.Name] = value;
			}
		}
		A_0.o = this.o;
		A_0.p = this.p;
		A_0.n = this.n;
		A_0.q = this.q;
		A_0.r = this.r;
		A_0.s = this.s;
		A_0.t = this.t;
		A_0.u = this.u;
		A_0.v = this.v;
	}

	// Token: 0x06008A0A RID: 35338 RVA: 0x0038BEEC File Offset: 0x0038A0EC
	public void h(string A_0)
	{
		eoq.SerializeToXmlFile<bk3>(A_0, this, d2i.a());
	}

	// Token: 0x06008A0B RID: 35339 RVA: 0x0038BEFC File Offset: 0x0038A0FC
	public void j(string A_0)
	{
		eoq.SerializeToBinaryFileCompressed<bk3>(A_0, this, dds.a(), eh9.c, true);
	}

	// Token: 0x06008A0C RID: 35340 RVA: 0x0038BF10 File Offset: 0x0038A110
	public static T LoadFromXmlFile<T>(string filePath) where T : bk3
	{
		return eoq.DeserializeFromXmlFile<T>(filePath, d2i.a());
	}

	// Token: 0x06008A0D RID: 35341 RVA: 0x0038BF20 File Offset: 0x0038A120
	public static T LoadFromBinaryFile<T>(string filePath) where T : bk3
	{
		return eoq.DeserializeFromBinaryFileCompressed<T>(filePath, dds.a(), true);
	}

	// Token: 0x06008A0E RID: 35342 RVA: 0x0038BF30 File Offset: 0x0038A130
	public string a1()
	{
		return eoq.SerializeToXml<bk3>(this, d2i.a());
	}

	// Token: 0x06008A0F RID: 35343 RVA: 0x0038BF40 File Offset: 0x0038A140
	public static T LoadFromXml<T>(string xml) where T : bk3
	{
		return eoq.DeserializeFromXml<T>(xml, d2i.a());
	}

	// Token: 0x06008A10 RID: 35344 RVA: 0x0038BF50 File Offset: 0x0038A150
	public bk3()
	{
	}

	// Token: 0x06008A11 RID: 35345 RVA: 0x0038BFAC File Offset: 0x0038A1AC
	public string bk()
	{
		if (aji.a == null)
		{
			return this.az();
		}
		string text = qv.b("ItemNames/" + this.az());
		if (!string.IsNullOrEmpty(text))
		{
			return text;
		}
		return this.az();
	}

	// Token: 0x06008A12 RID: 35346 RVA: 0x0038BFF4 File Offset: 0x0038A1F4
	public string bh()
	{
		if (aji.a == null)
		{
			return this.a0();
		}
		string text = qv.b("ItemDescriptions/" + this.az());
		if (!string.IsNullOrEmpty(text))
		{
			return text;
		}
		return this.a0();
	}

	// Token: 0x040036E2 RID: 14050
	public const string a = "item";

	// Token: 0x040036E3 RID: 14051
	private string b;

	// Token: 0x040036E4 RID: 14052
	private string c = "Unknown";

	// Token: 0x040036E5 RID: 14053
	private cr1 d = cr1.b;

	// Token: 0x040036E6 RID: 14054
	private int e;

	// Token: 0x040036E7 RID: 14055
	private string f;

	// Token: 0x040036E8 RID: 14056
	private string g = "Misc.0";

	// Token: 0x040036E9 RID: 14057
	private List<aia> h = new List<aia>();

	// Token: 0x040036EA RID: 14058
	private int i = 1;

	// Token: 0x040036EB RID: 14059
	private bool j;

	// Token: 0x040036EC RID: 14060
	private double? k;

	// Token: 0x040036ED RID: 14061
	private PropertyCollection l = new PropertyCollection();

	// Token: 0x040036EE RID: 14062
	private d76 m;

	// Token: 0x040036EF RID: 14063
	private bool n = true;

	// Token: 0x040036F0 RID: 14064
	private ItemRepairCategory o;

	// Token: 0x040036F1 RID: 14065
	private ItemStealingCategory p;

	// Token: 0x040036F2 RID: 14066
	private a0 q;

	// Token: 0x040036F3 RID: 14067
	private double r;

	// Token: 0x040036F4 RID: 14068
	private bool s = true;

	// Token: 0x040036F5 RID: 14069
	private int? t;

	// Token: 0x040036F6 RID: 14070
	private bool u;

	// Token: 0x040036F7 RID: 14071
	public bool v;
}
