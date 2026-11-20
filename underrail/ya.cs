using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Core.Logging;

// Token: 0x02000243 RID: 579
[eiz("T")]
[Serializable]
public abstract class ya : c7t, a9q, dcm, bvq, ISerializable
{
	// Token: 0x06001068 RID: 4200 RVA: 0x00043ED0 File Offset: 0x000420D0
	protected ya(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.b() != 0)
		{
			this.a = (Guid)A_0.GetValue("T:I", typeof(Guid));
			this.b = A_0.GetString("T:N");
			this.c = (aud)A_0.GetValue("T:A", typeof(aud));
			this.d = (Point)A_0.GetValue("T:L", typeof(Point));
			this.e = (esj)A_0.GetValue("T:S", typeof(esj));
			this.f = A_0.GetInt32("T:L1");
			return;
		}
		if (base.GetType() == typeof(ya))
		{
			this.a = (Guid)A_0.GetValue("_Id", typeof(Guid));
			this.b = A_0.GetString("_Name");
			this.c = (aud)A_0.GetValue("_Area", typeof(aud));
			this.d = (Point)A_0.GetValue("_Location", typeof(Point));
			this.e = (esj)A_0.GetValue("_Size", typeof(esj));
			this.f = A_0.GetInt32("_Layer");
			return;
		}
		this.a = (Guid)A_0.GetValue("Trigger+_Id", typeof(Guid));
		this.b = A_0.GetString("Trigger+_Name");
		this.c = (aud)A_0.GetValue("Trigger+_Area", typeof(aud));
		this.d = (Point)A_0.GetValue("Trigger+_Location", typeof(Point));
		this.e = (esj)A_0.GetValue("Trigger+_Size", typeof(esj));
		this.f = A_0.GetInt32("Trigger+_Layer");
	}

	// Token: 0x06001069 RID: 4201 RVA: 0x000440FC File Offset: 0x000422FC
	public virtual void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("T:I", this.a);
		info.AddValue("T:N", this.b);
		info.AddValue("T:A", this.c);
		info.AddValue("T:L", this.d);
		info.AddValue("T:S", this.e);
		info.AddValue("T:L1", this.f);
	}

	// Token: 0x170000AB RID: 171
	// (get) Token: 0x0600106A RID: 4202 RVA: 0x00044180 File Offset: 0x00042380
	public Guid Id
	{
		get
		{
			return this.a;
		}
	}

	// Token: 0x170000AC RID: 172
	// (get) Token: 0x0600106B RID: 4203 RVA: 0x00044188 File Offset: 0x00042388
	// (set) Token: 0x0600106C RID: 4204 RVA: 0x00044190 File Offset: 0x00042390
	[Category("System")]
	public string Name
	{
		get
		{
			return this.b;
		}
		set
		{
			this.b = value;
		}
	}

	// Token: 0x170000AD RID: 173
	// (get) Token: 0x0600106D RID: 4205 RVA: 0x0004419C File Offset: 0x0004239C
	[Browsable(false)]
	public bool Initialized
	{
		get
		{
			return this.g;
		}
	}

	// Token: 0x170000AE RID: 174
	// (get) Token: 0x0600106E RID: 4206 RVA: 0x000441A4 File Offset: 0x000423A4
	// (set) Token: 0x0600106F RID: 4207 RVA: 0x000441AC File Offset: 0x000423AC
	[Category("Meta")]
	public int Layer
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

	// Token: 0x170000AF RID: 175
	// (get) Token: 0x06001070 RID: 4208 RVA: 0x000441B8 File Offset: 0x000423B8
	[Browsable(false)]
	public bool Deployed
	{
		get
		{
			return this.c != null;
		}
	}

	// Token: 0x170000B0 RID: 176
	// (get) Token: 0x06001071 RID: 4209 RVA: 0x000441C4 File Offset: 0x000423C4
	// (set) Token: 0x06001072 RID: 4210 RVA: 0x000441CC File Offset: 0x000423CC
	[Browsable(false)]
	public aud Area
	{
		get
		{
			return this.c;
		}
		internal set
		{
			this.c = value;
		}
	}

	// Token: 0x170000B1 RID: 177
	// (get) Token: 0x06001073 RID: 4211 RVA: 0x000441D8 File Offset: 0x000423D8
	// (set) Token: 0x06001074 RID: 4212 RVA: 0x000441E0 File Offset: 0x000423E0
	[Category("Spatial")]
	public Point Location
	{
		get
		{
			return this.d;
		}
		set
		{
			if (!this.Deployed)
			{
				this.d = value;
			}
		}
	}

	// Token: 0x170000B2 RID: 178
	// (get) Token: 0x06001075 RID: 4213 RVA: 0x000441F4 File Offset: 0x000423F4
	// (set) Token: 0x06001076 RID: 4214 RVA: 0x000441FC File Offset: 0x000423FC
	[Category("Spatial")]
	public esj Size
	{
		get
		{
			return this.e;
		}
		set
		{
			if (!this.Deployed)
			{
				this.e = value;
			}
		}
	}

	// Token: 0x170000B3 RID: 179
	// (get) Token: 0x06001077 RID: 4215 RVA: 0x00044210 File Offset: 0x00042410
	public Type TriggerTypes
	{
		get
		{
			return base.GetType();
		}
	}

	// Token: 0x06001078 RID: 4216 RVA: 0x00044218 File Offset: 0x00042418
	protected ya()
	{
		this.a = Guid.NewGuid();
	}

	// Token: 0x06001079 RID: 4217 RVA: 0x00044238 File Offset: 0x00042438
	public void d(b0b A_0)
	{
		czh.a(A_0, "entity");
		this.ac2(A_0);
	}

	// Token: 0x0600107A RID: 4218 RVA: 0x00044250 File Offset: 0x00042450
	public bool o()
	{
		if (!this.Deployed)
		{
			cvq cvq = dr3.e();
			if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.Warning, 112))
			{
				string a_ = string.Format("[Playfield] - Attempted to undeploy a trigger that is not deployed ('{0}').", this.b);
				cvq.n7(LogSeverity.Error, 112, a_);
			}
			return false;
		}
		this.bd(true);
		this.c.a(this);
		this.c = null;
		return true;
	}

	// Token: 0x0600107B RID: 4219 RVA: 0x000442C8 File Offset: 0x000424C8
	public bool bc(bool A_0)
	{
		if (this.g)
		{
			return false;
		}
		this.c.d(this);
		this.g = true;
		this.n();
		return true;
	}

	// Token: 0x0600107C RID: 4220 RVA: 0x000442F4 File Offset: 0x000424F4
	public bool bd(bool A_0)
	{
		if (!this.g)
		{
			return false;
		}
		this.c.c(this);
		this.g = false;
		this.q();
		return true;
	}

	// Token: 0x0600107D RID: 4221 RVA: 0x00044320 File Offset: 0x00042520
	public void e(b0b A_0)
	{
		czh.a(A_0, "entity");
		this.jk(A_0);
	}

	// Token: 0x0600107E RID: 4222 RVA: 0x00044334 File Offset: 0x00042534
	public void f(b0b A_0)
	{
		czh.a(A_0, "entity");
		this.pq(A_0);
	}

	// Token: 0x0600107F RID: 4223 RVA: 0x00044348 File Offset: 0x00042548
	public void g(b0b A_0)
	{
		czh.a(A_0, "entity");
		this.tk(A_0);
	}

	// Token: 0x06001080 RID: 4224 RVA: 0x0004435C File Offset: 0x0004255C
	public void h(b0b A_0)
	{
		czh.a(A_0, "entity");
		this.tl(A_0);
	}

	// Token: 0x06001081 RID: 4225 RVA: 0x00044370 File Offset: 0x00042570
	protected virtual void ac2(b0b A_0)
	{
	}

	// Token: 0x06001082 RID: 4226 RVA: 0x00044374 File Offset: 0x00042574
	protected virtual void jk(b0b A_0)
	{
	}

	// Token: 0x06001083 RID: 4227 RVA: 0x00044378 File Offset: 0x00042578
	protected virtual void tk(b0b A_0)
	{
	}

	// Token: 0x06001084 RID: 4228 RVA: 0x0004437C File Offset: 0x0004257C
	protected virtual void pq(b0b A_0)
	{
	}

	// Token: 0x06001085 RID: 4229 RVA: 0x00044380 File Offset: 0x00042580
	protected virtual void tl(b0b A_0)
	{
	}

	// Token: 0x06001086 RID: 4230 RVA: 0x00044384 File Offset: 0x00042584
	protected virtual void n()
	{
	}

	// Token: 0x06001087 RID: 4231 RVA: 0x00044388 File Offset: 0x00042588
	protected virtual void q()
	{
	}

	// Token: 0x0400097E RID: 2430
	private Guid a;

	// Token: 0x0400097F RID: 2431
	private string b = "UnnamedTrigger";

	// Token: 0x04000980 RID: 2432
	private aud c;

	// Token: 0x04000981 RID: 2433
	private Point d;

	// Token: 0x04000982 RID: 2434
	private esj e;

	// Token: 0x04000983 RID: 2435
	private int f;

	// Token: 0x04000984 RID: 2436
	[NonSerialized]
	private bool g;
}
