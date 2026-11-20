using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x02000054 RID: 84
[eiz("AE")]
[Serializable]
public abstract class axv : c7t, ISerializable
{
	// Token: 0x06000140 RID: 320 RVA: 0x000076FC File Offset: 0x000058FC
	protected axv(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.b() != 0)
		{
			this.a = (Point)A_0.GetValue("AE:L", typeof(Point));
			this.b = (esj)A_0.GetValue("AE:S", typeof(esj));
			this.e = (Point)A_0.GetValue("AE:LAL", typeof(Point));
			this.f = (esj)A_0.GetValue("AE:LAS", typeof(esj));
			this.g = A_0.GetBoolean("AE:LAE");
			this.h = (Guid)A_0.GetValue("AE:I", typeof(Guid));
			this.i = A_0.GetString("AE:N");
			return;
		}
		if (base.GetType() == typeof(axv))
		{
			this.a = (Point)A_0.GetValue("_Location", typeof(Point));
			this.b = (esj)A_0.GetValue("_Size", typeof(esj));
			this.e = (Point)A_0.GetValue("_LastAppliedLocation", typeof(Point));
			this.f = (esj)A_0.GetValue("_LastAppliedSize", typeof(esj));
			this.g = A_0.GetBoolean("_LastAppliedEnabled");
			this.h = (Guid)A_0.GetValue("<Id>k__BackingField", typeof(Guid));
			this.i = A_0.GetString("<Name>k__BackingField");
			return;
		}
		this.a = (Point)A_0.GetValue("AreaEffect+_Location", typeof(Point));
		this.b = (esj)A_0.GetValue("AreaEffect+_Size", typeof(esj));
		this.e = (Point)A_0.GetValue("AreaEffect+_LastAppliedLocation", typeof(Point));
		this.f = (esj)A_0.GetValue("AreaEffect+_LastAppliedSize", typeof(esj));
		this.g = A_0.GetBoolean("AreaEffect+_LastAppliedEnabled");
		this.h = (Guid)A_0.GetValue("AreaEffect+<Id>k__BackingField", typeof(Guid));
		this.i = A_0.GetString("AreaEffect+<Name>k__BackingField");
	}

	// Token: 0x06000141 RID: 321 RVA: 0x000079B4 File Offset: 0x00005BB4
	public virtual void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("AE:L", this.a);
		info.AddValue("AE:S", this.b);
		info.AddValue("AE:LAL", this.e);
		info.AddValue("AE:LAS", this.f);
		info.AddValue("AE:LAE", this.g);
		info.AddValue("AE:I", this.h);
		info.AddValue("AE:N", this.i);
	}

	// Token: 0x06000142 RID: 322 RVA: 0x00007A54 File Offset: 0x00005C54
	public Guid qe()
	{
		return this.h;
	}

	// Token: 0x06000143 RID: 323 RVA: 0x00007A5C File Offset: 0x00005C5C
	private void a(Guid A_0)
	{
		this.h = A_0;
	}

	// Token: 0x06000144 RID: 324 RVA: 0x00007A68 File Offset: 0x00005C68
	public string y8()
	{
		return this.i;
	}

	// Token: 0x06000145 RID: 325 RVA: 0x00007A70 File Offset: 0x00005C70
	public void a(string A_0)
	{
		this.i = A_0;
	}

	// Token: 0x06000146 RID: 326 RVA: 0x00007A7C File Offset: 0x00005C7C
	public Point d()
	{
		return this.a;
	}

	// Token: 0x06000147 RID: 327 RVA: 0x00007A84 File Offset: 0x00005C84
	public void b(Point A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06000148 RID: 328 RVA: 0x00007A90 File Offset: 0x00005C90
	public esj e()
	{
		return this.b;
	}

	// Token: 0x06000149 RID: 329 RVA: 0x00007A98 File Offset: 0x00005C98
	public void a(esj A_0)
	{
		this.b = A_0;
	}

	// Token: 0x0600014A RID: 330 RVA: 0x00007AA4 File Offset: 0x00005CA4
	public aud h()
	{
		return this.c;
	}

	// Token: 0x0600014B RID: 331 RVA: 0x00007AAC File Offset: 0x00005CAC
	internal void a(aud A_0)
	{
		this.c = A_0;
	}

	// Token: 0x0600014C RID: 332
	public abstract bool af7();

	// Token: 0x0600014D RID: 333 RVA: 0x00007AB8 File Offset: 0x00005CB8
	protected axv(Guid A_0, string A_1, aud A_2)
	{
		czh.a(A_2, "area");
		this.c = A_2;
		this.a(A_1);
		this.a(A_0);
	}

	// Token: 0x0600014E RID: 334 RVA: 0x00007B24 File Offset: 0x00005D24
	protected axv(string A_0, aud A_1) : this(Guid.NewGuid(), A_0, A_1)
	{
	}

	// Token: 0x0600014F RID: 335 RVA: 0x00007B34 File Offset: 0x00005D34
	protected axv(aud A_0) : this(Guid.NewGuid(), null, A_0)
	{
	}

	// Token: 0x06000150 RID: 336 RVA: 0x00007B44 File Offset: 0x00005D44
	public virtual void g()
	{
		if (this.g && (esj.c(this.f, this.e()) || this.e != this.d() || !this.af7()))
		{
			foreach (ak1 a_ in this.d)
			{
				this.aga(a_);
			}
		}
		this.d = bnx.a(this.h(), this.d(), this.e());
		if (this.af7())
		{
			if (!this.g || esj.c(this.f, this.e()) || this.e != this.d())
			{
				using (List<ak1>.Enumerator enumerator = this.d.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						ak1 a_2 = enumerator.Current;
						this.af9(a_2);
					}
					goto IL_160;
				}
			}
			if (this.agc())
			{
				foreach (ak1 a_3 in this.d)
				{
					this.agb(a_3);
				}
			}
		}
		IL_160:
		this.e = this.d();
		this.f = this.e();
		this.g = this.af7();
	}

	// Token: 0x06000151 RID: 337 RVA: 0x00007D00 File Offset: 0x00005F00
	public virtual void af8()
	{
		this.f();
	}

	// Token: 0x06000152 RID: 338 RVA: 0x00007D08 File Offset: 0x00005F08
	public virtual void f()
	{
		this.e = Point.Zero;
		this.f = esj.a();
		foreach (ak1 a_ in this.d)
		{
			this.aga(a_);
		}
	}

	// Token: 0x06000153 RID: 339 RVA: 0x00007D78 File Offset: 0x00005F78
	public bool a(Point A_0)
	{
		return A_0.X >= this.a.X && A_0.Y >= this.a.Y && A_0.X < this.a.X + this.b.c && A_0.Y < this.a.Y + this.b.d;
	}

	// Token: 0x06000154 RID: 340 RVA: 0x00007DF4 File Offset: 0x00005FF4
	public override string ToString()
	{
		return this.qe().ToString();
	}

	// Token: 0x06000155 RID: 341
	protected abstract void aga(ak1 A_0);

	// Token: 0x06000156 RID: 342
	protected abstract void af9(ak1 A_0);

	// Token: 0x06000157 RID: 343
	protected abstract void agb(ak1 A_0);

	// Token: 0x06000158 RID: 344
	protected abstract bool agc();

	// Token: 0x040002B2 RID: 690
	private Point a = Point.Zero;

	// Token: 0x040002B3 RID: 691
	private esj b = esj.a();

	// Token: 0x040002B4 RID: 692
	[NonSerialized]
	private aud c;

	// Token: 0x040002B5 RID: 693
	[NonSerialized]
	private List<ak1> d = new List<ak1>();

	// Token: 0x040002B6 RID: 694
	private Point e = Point.Zero;

	// Token: 0x040002B7 RID: 695
	private esj f = esj.a();

	// Token: 0x040002B8 RID: 696
	private bool g;

	// Token: 0x040002B9 RID: 697
	private Guid h;

	// Token: 0x040002BA RID: 698
	private string i;
}
