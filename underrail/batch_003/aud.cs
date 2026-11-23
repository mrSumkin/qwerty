using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Common.Data;
using Ouroboros.Core.Logging;

// Token: 0x0200024D RID: 589
[eiz("A6")]
[Serializable]
public class aud : cae, dcm, ISerializable
{
	// Token: 0x060010BF RID: 4287 RVA: 0x00045008 File Offset: 0x00043208
	protected aud(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.b() != 0)
		{
			this.b = (ak1[,])A_0.GetValue("A6:T", typeof(ak1[,]));
			this.c = (List<b0b>)A_0.GetValue("A6:E", typeof(List<b0b>));
			di7.ReadList<ya>("A6:T1", ref this.d, A_0);
			this.f = (c1a)A_0.GetValue("A6:Z", typeof(c1a));
			this.g = (esj)A_0.GetValue("A6:S", typeof(esj));
			this.h = (Queue<b0b>)A_0.GetValue("A6:MFU", typeof(Queue<b0b>));
			this.i = (Color)A_0.GetValue("A6:ML", typeof(Color));
			this.j = (Color)A_0.GetValue("A6:ML1", typeof(Color));
			this.k = (Color)A_0.GetValue("A6:SL", typeof(Color));
			this.l = (dml)A_0.GetValue("A6:SLA", typeof(dml));
			this.m = (cup)A_0.GetValue("A6:D", typeof(cup));
			if (ell.b() >= 28)
			{
				this.n = (PropertyCollection)A_0.GetValue("A6:CP", typeof(PropertyCollection));
				return;
			}
			this.n = new PropertyCollection();
			return;
		}
		else
		{
			if (base.GetType() == typeof(aud))
			{
				this.b = (ak1[,])A_0.GetValue("_Tiles", typeof(ak1[,]));
				this.c = (List<b0b>)A_0.GetValue("_Entities", typeof(List<b0b>));
				this.d = (List<ya>)A_0.GetValue("_Triggers", typeof(List<ya>));
				this.f = (c1a)A_0.GetValue("_Zone", typeof(c1a));
				this.g = (esj)A_0.GetValue("_Size", typeof(esj));
				this.h = (Queue<b0b>)A_0.GetValue("_MarkedForUndeployment", typeof(Queue<b0b>));
				this.i = (Color)A_0.GetValue("_MinimalLightning", typeof(Color));
				this.j = (Color)A_0.GetValue("_MaximalLightning", typeof(Color));
				this.k = (Color)A_0.GetValue("_StartingLightning", typeof(Color));
				this.l = (dml)A_0.GetValue("_SoftLightAreas", typeof(dml));
				this.m = (cup)A_0.GetValue("_Divinations", typeof(cup));
				return;
			}
			this.b = (ak1[,])A_0.GetValue("Area+_Tiles", typeof(ak1[,]));
			this.c = (List<b0b>)A_0.GetValue("Area+_Entities", typeof(List<b0b>));
			this.d = (List<ya>)A_0.GetValue("Area+_Triggers", typeof(List<ya>));
			this.f = (c1a)A_0.GetValue("Area+_Zone", typeof(c1a));
			this.g = (esj)A_0.GetValue("Area+_Size", typeof(esj));
			this.h = (Queue<b0b>)A_0.GetValue("Area+_MarkedForUndeployment", typeof(Queue<b0b>));
			this.i = (Color)A_0.GetValue("Area+_MinimalLightning", typeof(Color));
			this.j = (Color)A_0.GetValue("Area+_MaximalLightning", typeof(Color));
			this.k = (Color)A_0.GetValue("Area+_StartingLightning", typeof(Color));
			this.l = (dml)A_0.GetValue("Area+_SoftLightAreas", typeof(dml));
			this.m = (cup)A_0.GetValue("Area+_Divinations", typeof(cup));
			return;
		}
	}

	// Token: 0x060010C0 RID: 4288 RVA: 0x000454D0 File Offset: 0x000436D0
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("A6:T", this.b);
		info.AddValue("A6:E", this.c);
		di7.WriteList<ya>("A6:T1", this.d, info);
		info.AddValue("A6:Z", this.f);
		info.AddValue("A6:S", this.g);
		info.AddValue("A6:MFU", this.h);
		info.AddValue("A6:ML", this.i);
		info.AddValue("A6:ML1", this.j);
		info.AddValue("A6:SL", this.k);
		info.AddValue("A6:SLA", this.l);
		info.AddValue("A6:D", this.m);
		info.AddValue("A6:CP", this.n);
	}

	// Token: 0x170000BF RID: 191
	// (get) Token: 0x060010C1 RID: 4289 RVA: 0x000455C8 File Offset: 0x000437C8
	// (set) Token: 0x060010C2 RID: 4290 RVA: 0x000455D0 File Offset: 0x000437D0
	[Browsable(false)]
	public c1a Zone
	{
		get
		{
			return this.f;
		}
		set
		{
			this.f = value;
		}
	}

	// Token: 0x170000C0 RID: 192
	// (get) Token: 0x060010C3 RID: 4291 RVA: 0x000455DC File Offset: 0x000437DC
	[Browsable(false)]
	public e3h Playfield
	{
		get
		{
			if (this.Zone == null)
			{
				return null;
			}
			return this.Zone.Playfield;
		}
	}

	// Token: 0x170000C1 RID: 193
	// (get) Token: 0x060010C4 RID: 4292 RVA: 0x000455F8 File Offset: 0x000437F8
	[Category("Spatial")]
	public esj Size
	{
		get
		{
			return this.g;
		}
	}

	// Token: 0x170000C2 RID: 194
	// (get) Token: 0x060010C5 RID: 4293 RVA: 0x00045600 File Offset: 0x00043800
	// (set) Token: 0x060010C6 RID: 4294 RVA: 0x00045608 File Offset: 0x00043808
	[Category("Behavior")]
	public Color MinimalLightning
	{
		get
		{
			return this.i;
		}
		set
		{
			this.i = value;
		}
	}

	// Token: 0x170000C3 RID: 195
	// (get) Token: 0x060010C7 RID: 4295 RVA: 0x00045614 File Offset: 0x00043814
	// (set) Token: 0x060010C8 RID: 4296 RVA: 0x0004561C File Offset: 0x0004381C
	[Category("Behavior")]
	public Color MaximalLightning
	{
		get
		{
			return this.j;
		}
		set
		{
			this.j = value;
		}
	}

	// Token: 0x170000C4 RID: 196
	// (get) Token: 0x060010C9 RID: 4297 RVA: 0x00045628 File Offset: 0x00043828
	// (set) Token: 0x060010CA RID: 4298 RVA: 0x00045630 File Offset: 0x00043830
	[Category("Behavior")]
	public Color StartingLightning
	{
		get
		{
			return this.k;
		}
		set
		{
			this.k = value;
		}
	}

	// Token: 0x170000C5 RID: 197
	// (get) Token: 0x060010CB RID: 4299 RVA: 0x0004563C File Offset: 0x0004383C
	[Browsable(false)]
	public dml SoftLightAreas
	{
		get
		{
			return this.l;
		}
	}

	// Token: 0x170000C6 RID: 198
	// (get) Token: 0x060010CC RID: 4300 RVA: 0x00045644 File Offset: 0x00043844
	[Browsable(false)]
	public cup Divinations
	{
		get
		{
			return this.m;
		}
	}

	// Token: 0x170000C7 RID: 199
	// (get) Token: 0x060010CD RID: 4301 RVA: 0x0004564C File Offset: 0x0004384C
	[Browsable(false)]
	public List<b0b> Entities
	{
		get
		{
			return this.c;
		}
	}

	// Token: 0x170000C8 RID: 200
	// (get) Token: 0x060010CE RID: 4302 RVA: 0x00045654 File Offset: 0x00043854
	[Browsable(false)]
	public List<ya> Triggers
	{
		get
		{
			return this.d;
		}
	}

	// Token: 0x170000C9 RID: 201
	// (get) Token: 0x060010CF RID: 4303 RVA: 0x0004565C File Offset: 0x0004385C
	// (set) Token: 0x060010D0 RID: 4304 RVA: 0x0004567C File Offset: 0x0004387C
	public PropertyCollection CustomProperties
	{
		get
		{
			if (this.n == null)
			{
				this.n = new PropertyCollection();
			}
			return this.n;
		}
		set
		{
			this.n = value;
		}
	}

	// Token: 0x060010D1 RID: 4305 RVA: 0x00045688 File Offset: 0x00043888
	internal aud(string A_0, esj A_1) : this(Guid.NewGuid(), A_0, A_1)
	{
	}

	// Token: 0x060010D2 RID: 4306 RVA: 0x00045698 File Offset: 0x00043898
	public aud(Guid A_0, string A_1, esj A_2) : this(A_0, A_1, A_2, true)
	{
	}

	// Token: 0x060010D3 RID: 4307 RVA: 0x000456A8 File Offset: 0x000438A8
	public aud(Guid A_0, string A_1, esj A_2, bool A_3) : base(A_0, A_1)
	{
		this.g = A_2;
		this.b = new ak1[A_2.c, A_2.d];
		this.l = new dml(this);
		this.m = new cup(this);
		if (A_3)
		{
			this.bc(true);
		}
	}

	// Token: 0x170000CA RID: 202
	public ak1 this[int A_0, int A_1]
	{
		get
		{
			return this.b[A_0, A_1];
		}
	}

	// Token: 0x060010D5 RID: 4309 RVA: 0x00045754 File Offset: 0x00043954
	public void FillTiles<T>() where T : ak1
	{
		if (typeof(T).GetConstructor(new Type[]
		{
			typeof(aud)
		}) == null)
		{
			throw new Exception("Specified tile type ('" + typeof(T).FullName + "') does not have a default constructor.");
		}
		if (this.g.c > 0 || this.g.d > 0)
		{
			for (int i = 0; i < this.g.c; i++)
			{
				for (int j = 0; j < this.g.d; j++)
				{
					ak1 ak = Activator.CreateInstance(typeof(T), new object[]
					{
						this
					}) as ak1;
					ak.Location = new Point(i, j);
					this.b[i, j] = ak;
				}
			}
		}
	}

	// Token: 0x060010D6 RID: 4310 RVA: 0x00045840 File Offset: 0x00043A40
	public new ak1 b(int A_0, int A_1)
	{
		if (A_0 < 0 || A_1 < 0 || A_0 >= this.Size.c || A_1 >= this.Size.d)
		{
			return null;
		}
		return this.b[A_0, A_1];
	}

	// Token: 0x060010D7 RID: 4311 RVA: 0x0004588C File Offset: 0x00043A8C
	public new ak1 a(Point A_0)
	{
		return this.b(A_0.X, A_0.Y);
	}

	// Token: 0x060010D8 RID: 4312 RVA: 0x000458A0 File Offset: 0x00043AA0
	public new b0b a(Guid A_0)
	{
		aud.a a = new aud.a();
		a.a = A_0;
		if (this.c != null)
		{
			return Enumerable.FirstOrDefault<b0b>(Enumerable.Where<b0b>(this.c, new Func<b0b, bool>(a.a)));
		}
		return null;
	}

	// Token: 0x060010D9 RID: 4313 RVA: 0x000458E4 File Offset: 0x00043AE4
	public new b0b a(string A_0)
	{
		aud.b b = new aud.b();
		b.a = A_0;
		if (this.c != null)
		{
			return Enumerable.FirstOrDefault<b0b>(Enumerable.Where<b0b>(this.c, new Func<b0b, bool>(b.a)));
		}
		return null;
	}

	// Token: 0x060010DA RID: 4314 RVA: 0x00045928 File Offset: 0x00043B28
	public new void a(int A_0, int A_1, ak1 A_2)
	{
		this.b[A_0, A_1] = A_2;
	}

	// Token: 0x060010DB RID: 4315 RVA: 0x00045938 File Offset: 0x00043B38
	public new void a(b0b A_0)
	{
		if (!this.c.Contains(A_0))
		{
			this.c.Add(A_0);
			A_0.f(this);
		}
	}

	// Token: 0x060010DC RID: 4316 RVA: 0x00045964 File Offset: 0x00043B64
	public new bool b(ya A_0)
	{
		if (A_0.Deployed)
		{
			cvq cvq = dr3.e();
			if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.Error, 112))
			{
				string a_ = string.Format("[Playfield] - Attempted to deploy an already deployed trigger '{0}' into area: {1}", A_0.Name, base.y8());
				cvq.n7(LogSeverity.Error, 112, a_);
			}
			return false;
		}
		A_0.Area = this;
		this.d.Add(A_0);
		if (this.Initialized)
		{
			A_0.bc(true);
		}
		return true;
	}

	// Token: 0x060010DD RID: 4317 RVA: 0x000459EC File Offset: 0x00043BEC
	public new void a()
	{
		for (int i = 0; i < this.g.d; i++)
		{
			for (int j = 0; j < this.g.c; j++)
			{
				ak1 ak = this.b(j, i);
				if (ak != null)
				{
					ak.e();
				}
			}
		}
	}

	// Token: 0x060010DE RID: 4318 RVA: 0x00045A40 File Offset: 0x00043C40
	public int c()
	{
		if (this.o == null)
		{
			if (this.f != null)
			{
				this.o = new int?(this.f.b(this));
			}
			else
			{
				this.o = new int?(-1);
			}
		}
		return this.o.Value;
	}

	// Token: 0x060010DF RID: 4319 RVA: 0x00045A9C File Offset: 0x00043C9C
	public new void a(cpe A_0, int A_1, Point A_2)
	{
		nf.a(this, A_0, A_1, A_2, null);
	}

	// Token: 0x060010E0 RID: 4320 RVA: 0x00045AA8 File Offset: 0x00043CA8
	internal void c(b0b A_0)
	{
		if (this.c.Contains(A_0))
		{
			this.c.Remove(A_0);
		}
	}

	// Token: 0x060010E1 RID: 4321 RVA: 0x00045AC8 File Offset: 0x00043CC8
	internal new void b(b0b A_0)
	{
		this.h.Enqueue(A_0);
	}

	// Token: 0x060010E2 RID: 4322 RVA: 0x00045AD8 File Offset: 0x00043CD8
	internal void g()
	{
		while (this.h.Count > 0)
		{
			this.h.Dequeue().an();
		}
	}

	// Token: 0x060010E3 RID: 4323 RVA: 0x00045B00 File Offset: 0x00043D00
	internal new void a(ya A_0)
	{
		if (this.Initialized)
		{
			A_0.bd(true);
		}
		if (this.d != null)
		{
			this.d.Remove(A_0);
		}
	}

	// Token: 0x060010E4 RID: 4324 RVA: 0x00045B30 File Offset: 0x00043D30
	internal void d(ya A_0)
	{
		if (this.e == null)
		{
			this.e = new Dictionary<ya, bqt>();
		}
		bqt bqt = new bqt(A_0);
		this.e[A_0] = bqt;
		bqt.bc(true);
	}

	// Token: 0x060010E5 RID: 4325 RVA: 0x00045B70 File Offset: 0x00043D70
	internal void c(ya A_0)
	{
		if (this.e != null)
		{
			bqt bqt;
			this.e.TryGetValue(A_0, out bqt);
			if (bqt != null)
			{
				bqt.bd(true);
				this.e.Remove(A_0);
			}
		}
	}

	// Token: 0x060010E6 RID: 4326 RVA: 0x00045BB4 File Offset: 0x00043DB4
	internal new void b()
	{
		this.l.a(this);
		this.m.a(this);
	}

	// Token: 0x170000CB RID: 203
	// (get) Token: 0x060010E7 RID: 4327 RVA: 0x00045BD0 File Offset: 0x00043DD0
	[Browsable(false)]
	public bool Initialized
	{
		get
		{
			return this.a;
		}
	}

	// Token: 0x060010E8 RID: 4328 RVA: 0x00045BD8 File Offset: 0x00043DD8
	public void l()
	{
		for (int i = 0; i < this.Size.d; i++)
		{
			for (int j = 0; j < this.Size.c; j++)
			{
				ak1 ak = this.b[j, i];
				if (ak != null)
				{
					if (ak.a == this)
					{
						return;
					}
					ak.b = new Point(j, i);
					ak.a = this;
				}
			}
		}
	}

	// Token: 0x060010E9 RID: 4329 RVA: 0x00045C4C File Offset: 0x00043E4C
	public bool bc(bool A_0)
	{
		if (this.a)
		{
			return false;
		}
		this.l();
		if (A_0)
		{
			foreach (b0b b0b in this.c)
			{
				b0b.bc(true);
			}
			foreach (ya ya in this.d)
			{
				ya.bc(true);
			}
		}
		for (int i = 0; i < this.Size.d; i++)
		{
			for (int j = 0; j < this.Size.c; j++)
			{
				ak1 ak = this.b[j, i];
				if (ak != null)
				{
					ak.j();
				}
			}
		}
		this.a = true;
		return true;
	}

	// Token: 0x060010EA RID: 4330 RVA: 0x00045D5C File Offset: 0x00043F5C
	public bool bd(bool A_0)
	{
		if (!this.a)
		{
			return false;
		}
		if (A_0)
		{
			foreach (ya ya in this.d)
			{
				ya.bd(true);
			}
			foreach (b0b b0b in this.c)
			{
				b0b.bd(true);
			}
		}
		this.a = false;
		return true;
	}

	// Token: 0x040009A3 RID: 2467
	[NonSerialized]
	private new bool a;

	// Token: 0x040009A4 RID: 2468
	private new ak1[,] b;

	// Token: 0x040009A5 RID: 2469
	public List<b0b> c = new List<b0b>();

	// Token: 0x040009A6 RID: 2470
	private List<ya> d = new List<ya>();

	// Token: 0x040009A7 RID: 2471
	[NonSerialized]
	private Dictionary<ya, bqt> e;

	// Token: 0x040009A8 RID: 2472
	private c1a f;

	// Token: 0x040009A9 RID: 2473
	private esj g;

	// Token: 0x040009AA RID: 2474
	private Queue<b0b> h = new Queue<b0b>();

	// Token: 0x040009AB RID: 2475
	private new Color i = Color.Black;

	// Token: 0x040009AC RID: 2476
	private Color j = Color.White;

	// Token: 0x040009AD RID: 2477
	private Color k = Color.White;

	// Token: 0x040009AE RID: 2478
	private dml l;

	// Token: 0x040009AF RID: 2479
	private cup m;

	// Token: 0x040009B0 RID: 2480
	private PropertyCollection n;

	// Token: 0x040009B1 RID: 2481
	[NonSerialized]
	private int? o;

	// Token: 0x0200024E RID: 590
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x060010EC RID: 4332 RVA: 0x00045E20 File Offset: 0x00044020
		internal bool a(b0b A_0)
		{
			return A_0.qe() == this.a;
		}

		// Token: 0x040009B2 RID: 2482
		public Guid a;
	}

	// Token: 0x0200024F RID: 591
	[CompilerGenerated]
	private new sealed class b
	{
		// Token: 0x060010EE RID: 4334 RVA: 0x00045E3C File Offset: 0x0004403C
		internal bool a(b0b A_0)
		{
			return A_0.y8() == this.a;
		}

		// Token: 0x040009B3 RID: 2483
		public string a;
	}
}
