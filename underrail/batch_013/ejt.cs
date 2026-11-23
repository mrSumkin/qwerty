using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x02000250 RID: 592
[eiz("RE")]
[Serializable]
public abstract class ejt : c7t, ISerializable
{
	// Token: 0x060010EF RID: 4335 RVA: 0x00045E54 File Offset: 0x00044054
	protected ejt(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.b() != 0)
		{
			this.a = (Guid)A_0.GetValue("RE:I", typeof(Guid));
			this.b = (b0b)A_0.GetValue("RE:C", typeof(b0b));
			this.c = (Vector3)A_0.GetValue("RE:L", typeof(Vector3));
			return;
		}
		if (base.GetType() == typeof(ejt))
		{
			this.a = (Guid)A_0.GetValue("_Id", typeof(Guid));
			this.b = (b0b)A_0.GetValue("_Carrier", typeof(b0b));
			this.c = (Vector3)A_0.GetValue("_Location", typeof(Vector3));
			return;
		}
		this.a = (Guid)A_0.GetValue("RaysEmitter+_Id", typeof(Guid));
		this.b = (b0b)A_0.GetValue("RaysEmitter+_Carrier", typeof(b0b));
		this.c = (Vector3)A_0.GetValue("RaysEmitter+_Location", typeof(Vector3));
	}

	// Token: 0x060010F0 RID: 4336 RVA: 0x00045FB0 File Offset: 0x000441B0
	public virtual void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("RE:I", this.a);
		info.AddValue("RE:C", this.b);
		info.AddValue("RE:L", this.c);
	}

	// Token: 0x170000CC RID: 204
	// (get) Token: 0x060010F1 RID: 4337 RVA: 0x00045FF0 File Offset: 0x000441F0
	public Guid Id
	{
		get
		{
			return this.a;
		}
	}

	// Token: 0x170000CD RID: 205
	// (get) Token: 0x060010F2 RID: 4338 RVA: 0x00045FF8 File Offset: 0x000441F8
	// (set) Token: 0x060010F3 RID: 4339 RVA: 0x00046000 File Offset: 0x00044200
	public Vector3 Location
	{
		get
		{
			return this.c;
		}
		set
		{
			this.c = value;
		}
	}

	// Token: 0x170000CE RID: 206
	// (get) Token: 0x060010F4 RID: 4340 RVA: 0x0004600C File Offset: 0x0004420C
	public b0b Carrier
	{
		get
		{
			return this.b;
		}
	}

	// Token: 0x170000CF RID: 207
	// (get) Token: 0x060010F5 RID: 4341 RVA: 0x00046014 File Offset: 0x00044214
	public virtual object SourceDefinition
	{
		get
		{
			return null;
		}
	}

	// Token: 0x060010F6 RID: 4342 RVA: 0x00046018 File Offset: 0x00044218
	protected ejt()
	{
		this.a = Guid.NewGuid();
	}

	// Token: 0x060010F7 RID: 4343 RVA: 0x0004602C File Offset: 0x0004422C
	public virtual void be(b0b A_0)
	{
		czh.a(A_0, "entity");
		if (this.b != null && this.b != A_0)
		{
			this.e();
		}
		this.b = A_0;
		A_0.b(this);
	}

	// Token: 0x060010F8 RID: 4344 RVA: 0x00046064 File Offset: 0x00044264
	public virtual void e()
	{
		if (this.b != null)
		{
			this.b.c(this);
		}
	}

	// Token: 0x060010F9 RID: 4345
	public abstract void ig();

	// Token: 0x060010FA RID: 4346
	public abstract void ih();

	// Token: 0x060010FB RID: 4347
	public abstract void ii(bool A_0);

	// Token: 0x060010FC RID: 4348
	public abstract void ij();

	// Token: 0x060010FD RID: 4349 RVA: 0x00046080 File Offset: 0x00044280
	internal void g()
	{
		this.b = null;
	}

	// Token: 0x060010FE RID: 4350 RVA: 0x0004608C File Offset: 0x0004428C
	internal void a(Guid A_0)
	{
		this.a = A_0;
	}

	// Token: 0x040009B4 RID: 2484
	private Guid a;

	// Token: 0x040009B5 RID: 2485
	protected b0b b;

	// Token: 0x040009B6 RID: 2486
	private Vector3 c;
}
