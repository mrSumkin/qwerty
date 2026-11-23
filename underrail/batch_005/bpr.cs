using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Common.Data;
using Ouroboros.Playfield.References;

// Token: 0x02000290 RID: 656
[eiz("SMA")]
[Serializable]
public class bpr : dvv, ISerializable
{
	// Token: 0x06001328 RID: 4904 RVA: 0x0004F5A8 File Offset: 0x0004D7A8
	protected bpr(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (Vector3)A_0.GetValue("SMA:D", typeof(Vector3));
		this.b = (EntityAspectReference<mj, mj>)A_0.GetValue("SMA:MAR", typeof(EntityAspectReference<mj, mj>));
		this.c = (TimeSpan)A_0.GetValue("SMA:TT", typeof(TimeSpan));
		this.d = (TimeSpan)A_0.GetValue("SMA:TC", typeof(TimeSpan));
		this.e = A_0.GetSingle("SMA:S");
		this.f = A_0.GetSingle("SMA:MS");
		this.g = A_0.GetInt32("SMA:SX");
		this.h = A_0.GetInt32("SMA:SY");
		this.i = A_0.GetInt32("SMA:SZ");
		this.j = A_0.GetBoolean("SMA:C");
		this.k = (bjp)A_0.GetValue("SMA:CS", typeof(bjp));
		this.l = (yo)A_0.GetValue("SMA:E", typeof(yo));
		this.m = A_0.GetString("SMA:CE");
		this.n = A_0.GetSingle("SMA:CP1");
		this.o = A_0.GetBoolean("SMA:R");
		this.p = (float?)A_0.GetValue("SMA:OS", typeof(float?));
		if (ell.b() >= 23)
		{
			this.q = A_0.GetBoolean("SMA:UC");
		}
		else
		{
			this.q = true;
		}
		if (ell.b() >= 26)
		{
			di7.ReadList<aig>("SMA:CM", ref this.t, A_0);
		}
		else
		{
			this.t = new List<aig>();
		}
		if (ell.b() >= 281)
		{
			this.u = (A_0.GetValue("SMA:CC", typeof(a7o)) as a7o);
		}
	}

	// Token: 0x06001329 RID: 4905 RVA: 0x0004F7D4 File Offset: 0x0004D9D4
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SMA:D", this.a);
		info.AddValue("SMA:MAR", this.b);
		info.AddValue("SMA:TT", this.c);
		info.AddValue("SMA:TC", this.d);
		info.AddValue("SMA:S", this.e);
		info.AddValue("SMA:MS", this.f);
		info.AddValue("SMA:SX", this.g);
		info.AddValue("SMA:SY", this.h);
		info.AddValue("SMA:SZ", this.i);
		info.AddValue("SMA:C", this.j);
		info.AddValue("SMA:CS", this.k);
		info.AddValue("SMA:E", this.l);
		info.AddValue("SMA:CE", this.m);
		info.AddValue("SMA:CP1", this.n);
		info.AddValue("SMA:R", this.o);
		info.AddValue("SMA:OS", this.p);
		info.AddValue("SMA:UC", this.q);
		di7.WriteList<aig>("SMA:CM", this.t, info);
		info.AddValue("SMA:CC", this.u);
	}

	// Token: 0x0600132A RID: 4906 RVA: 0x0004F948 File Offset: 0x0004DB48
	public a7o h()
	{
		return this.u;
	}

	// Token: 0x0600132B RID: 4907 RVA: 0x0004F950 File Offset: 0x0004DB50
	public void a(a7o A_0)
	{
		this.u = A_0;
	}

	// Token: 0x0600132C RID: 4908 RVA: 0x0004F95C File Offset: 0x0004DB5C
	public a7o n()
	{
		if (!this.r)
		{
			if (this.u != null)
			{
				this.s = this.u;
			}
			else if (this.b != null && this.b.ao() != null && this.b.ao().a8() != null && this.b.ao().a8().Playfield != null)
			{
				this.s = this.b.ao().a8().Playfield.CollisionHandler;
			}
			this.r = true;
		}
		return this.s;
	}

	// Token: 0x0600132D RID: 4909 RVA: 0x0004FA08 File Offset: 0x0004DC08
	public bool i()
	{
		return this.q;
	}

	// Token: 0x0600132E RID: 4910 RVA: 0x0004FA10 File Offset: 0x0004DC10
	public void a(bool A_0)
	{
		this.q = A_0;
	}

	// Token: 0x0600132F RID: 4911 RVA: 0x0004FA1C File Offset: 0x0004DC1C
	public Vector3 f()
	{
		return this.a;
	}

	// Token: 0x06001330 RID: 4912 RVA: 0x0004FA24 File Offset: 0x0004DC24
	public yo e()
	{
		return this.l;
	}

	// Token: 0x06001331 RID: 4913 RVA: 0x0004FA2C File Offset: 0x0004DC2C
	public string o()
	{
		return this.m;
	}

	// Token: 0x06001332 RID: 4914 RVA: 0x0004FA34 File Offset: 0x0004DC34
	public bool m()
	{
		return this.o;
	}

	// Token: 0x06001333 RID: 4915 RVA: 0x0004FA3C File Offset: 0x0004DC3C
	public void b(bool A_0)
	{
		this.o = A_0;
	}

	// Token: 0x06001334 RID: 4916 RVA: 0x0004FA48 File Offset: 0x0004DC48
	public mj l()
	{
		return this.b.ao();
	}

	// Token: 0x06001335 RID: 4917 RVA: 0x0004FA58 File Offset: 0x0004DC58
	public List<aig> g()
	{
		return this.t;
	}

	// Token: 0x06001336 RID: 4918 RVA: 0x0004FA64 File Offset: 0x0004DC64
	public bpr(mj A_0, Vector3 A_1, float? A_2 = null, aig[] A_3 = null)
	{
		czh.a(A_0, "aspect");
		b0b b0b = A_0.a8();
		this.p = A_2;
		this.b = new EntityAspectReference<mj, mj>(A_0);
		this.a = A_1;
		this.n = b0b.Playfield.Schema.a().b();
		if (A_3 != null)
		{
			this.t.AddRange(A_3);
		}
	}

	// Token: 0x06001337 RID: 4919 RVA: 0x0004FAEC File Offset: 0x0004DCEC
	public bpr(mj A_0, Vector3 A_1) : this(A_0, A_1, null, null)
	{
	}

	// Token: 0x06001338 RID: 4920 RVA: 0x0004FB0C File Offset: 0x0004DD0C
	public void c(bool A_0 = false)
	{
		float num = this.e;
		this.a();
		if (num != this.e)
		{
			this.b();
			this.d = TimeSpan.Zero;
		}
	}

	// Token: 0x06001339 RID: 4921 RVA: 0x0004FB3C File Offset: 0x0004DD3C
	protected sealed override dc4 dt()
	{
		if (this.a == this.l().a8().Location)
		{
			return dc4.c;
		}
		if (this.l() == null || this.l().a8() == null || this.l().a8().Area == null)
		{
			return dc4.e;
		}
		this.d = TimeSpan.Zero;
		this.a();
		this.b();
		this.c();
		return dc4.b;
	}

	// Token: 0x0600133A RID: 4922 RVA: 0x0004FBBC File Offset: 0x0004DDBC
	protected sealed override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (this.l() == null || this.l().a8() == null || this.l().a8().Area == null)
		{
			return dc4.e;
		}
		if (this.g == 0 && this.h == 0 && this.i == 0)
		{
			this.d();
			return dc4.c;
		}
		aud aud = this.l().a8().Area;
		this.d += A_1;
		b0b b0b = this.l().a8();
		while (this.d > this.c)
		{
			bool flag = false;
			this.d -= this.c;
			Vector3 vector = b0b.Location + this.l().a();
			if (Math.Sign(this.a.X - vector.X) != this.g || Math.Sign(this.a.Y - vector.Y) != this.h || Math.Sign(this.a.Z - vector.Z) != this.i)
			{
				vector = this.a;
				flag = true;
			}
			if (this.j)
			{
				bool flag2 = true;
				float a_ = float.MinValue;
				float num = float.MaxValue;
				float a_2 = float.MinValue;
				float num2 = float.MaxValue;
				bool flag3 = false;
				CollectionDelta<ak1> collectionDelta = null;
				if (b0b.Playfield.Schema.a().a() != c3.a)
				{
					collectionDelta = bnx.a(b0b, b0b.Playfield.Schema, aud, b0b.l, vector, b0b.Size);
				}
				if ((b0b.Playfield.Schema.a().a() & c3.b) == c3.b)
				{
					foreach (ak1 ak in collectionDelta.b)
					{
						if (this.s != null && ak.Formation.c(this.k.b()) && this.s.ko(aud, b0b, ak, amu.b) == e0b.b)
						{
							flag2 = false;
							if ((this.g == 1 && (float)ak.Location.X + this.n > b0b.Location.X + b0b.Size.X) || (this.g == -1 && (float)ak.Location.X + (1f - this.n) < b0b.Location.X))
							{
								float num3;
								float num4;
								if (this.g == 1)
								{
									num3 = (float)ak.Location.X - (b0b.Location.X + b0b.Size.X);
									num4 = (float)ak.Location.X;
								}
								else
								{
									num3 = b0b.Location.X - (float)(ak.Location.X + 1);
									num4 = (float)(ak.Location.X + 1);
								}
								if (num3 < num)
								{
									num = num3;
									a_ = num4;
								}
							}
							if ((this.h == 1 && (float)ak.Location.Y + this.n > b0b.Location.Y + b0b.Size.Y) || (this.h == -1 && (float)ak.Location.Y + (1f - this.n) < b0b.Location.Y))
							{
								float num5;
								float num6;
								if (this.h == 1)
								{
									num5 = (float)ak.Location.Y - (b0b.Location.Y + b0b.Size.Y);
									num6 = (float)ak.Location.Y;
								}
								else
								{
									num5 = b0b.Location.Y - (float)(ak.Location.Y + 1);
									num6 = (float)(ak.Location.Y + 1);
								}
								if (num5 < num2)
								{
									num2 = num5;
									a_2 = num6;
								}
							}
						}
					}
				}
				if (this.u != null || ((b0b.Playfield.Schema.a().a() & c3.c) == c3.c && b0b.z != null))
				{
					foreach (ak1 ak2 in collectionDelta.d)
					{
						Rectangle value = new Rectangle(ak2.b.X * 100 + 5, ak2.b.Y * 100 + 5, 90, 90);
						foreach (b0b b0b2 in ak2.Entities)
						{
							bool? flag4 = this.s.kq(b0b2);
							bool? flag5 = flag4;
							bool flag6 = false;
							if (!(flag5.GetValueOrDefault() == flag6 & flag5 != null) && b0b2 != b0b && (b0b2.z != null || flag4.GetValueOrDefault()))
							{
								Vector2 vector2;
								Vector2 vector3;
								this.a(b0b, out vector2, out vector3);
								Vector2 vector4;
								Vector2 vector5;
								this.a(b0b2, out vector4, out vector5);
								Rectangle value2 = new Rectangle(Convert.ToInt32(vector2.X * 100f), Convert.ToInt32(vector2.Y * 100f), Convert.ToInt32(vector3.X * 100f), Convert.ToInt32(vector3.Y * 100f));
								Rectangle rectangle = new Rectangle(Convert.ToInt32(vector4.X * 100f), Convert.ToInt32(vector4.Y * 100f), Convert.ToInt32(vector5.X * 100f), Convert.ToInt32(vector5.Y * 100f));
								value2 = Rectangle.Intersect(value, value2);
								rectangle = Rectangle.Intersect(value, rectangle);
								if (!collectionDelta.c.Contains(ak2) || !value2.Intersects(rectangle))
								{
									this.a(b0b, vector, out vector2, out vector3);
									value2 = new Rectangle(Convert.ToInt32(vector2.X * 100f), Convert.ToInt32(vector2.Y * 100f), Convert.ToInt32(vector3.X * 100f), Convert.ToInt32(vector3.Y * 100f));
									value2 = Rectangle.Intersect(value, value2);
									if (value2.Intersects(rectangle) && this.q && this.s.kn(aud, b0b, b0b2, amu.b) == e0b.b)
									{
										flag3 = true;
										flag2 = false;
									}
								}
							}
						}
					}
				}
				if (!flag2)
				{
					if (!flag3)
					{
						this.c(a_, a_2);
					}
					this.d();
					this.l = yo.c;
					return dc4.e;
				}
			}
			Vector3 vector6 = b0b.Location;
			b0b.Location = vector;
			b0b.ah();
			float a_3 = (vector - vector6).Length();
			if (this.l().f() != null && this.l().f().hj(this.l().a8(), vector6, vector, a_3))
			{
				return dc4.e;
			}
			if (this.t != null && this.t.Count > 0)
			{
				bool flag7 = false;
				foreach (aig aig in this.t)
				{
					flag7 |= aig.hj(this.l().a8(), vector6, vector, (vector - vector6).Length());
				}
				if (flag7)
				{
					return dc4.e;
				}
			}
			if (flag)
			{
				this.d();
				return dc4.c;
			}
		}
		return dc4.b;
	}

	// Token: 0x0600133B RID: 4923 RVA: 0x0005043C File Offset: 0x0004E63C
	private void a(b0b A_0, out Vector2 A_1, out Vector2 A_2)
	{
		float num = 0.25f;
		Point point;
		Point point2;
		A_0.b(out point, out point2);
		float num2 = 0f;
		A_1 = new Vector2((float)point.X * num + num2, (float)point.Y * num + num2);
		A_2 = new Vector2((float)(point2.X - point.X + 1) * num - 2f * num2, (float)(point2.Y - point.Y + 1) * num - 2f * num2);
	}

	// Token: 0x0600133C RID: 4924 RVA: 0x000504C0 File Offset: 0x0004E6C0
	private void a(b0b A_0, Vector3 A_1, out Vector2 A_2, out Vector2 A_3)
	{
		float num = 0.25f;
		Point point;
		Point point2;
		A_0.a(out point, out point2, A_1);
		A_2 = new Vector2((float)point.X * num, (float)point.Y * num);
		A_3 = new Vector2((float)(point2.X - point.X + 1) * num, (float)(point2.Y - point.Y + 1) * num);
	}

	// Token: 0x0600133D RID: 4925 RVA: 0x0005052C File Offset: 0x0004E72C
	private void c(float A_0, float A_1)
	{
		b0b b0b = this.l().a8();
		if (A_0 == -3.4028235E+38f && A_1 == -3.4028235E+38f)
		{
			return;
		}
		Vector3 vector = b0b.Location;
		float num = float.MaxValue;
		float num2 = float.MaxValue;
		if (A_0 != -3.4028235E+38f)
		{
			float num3;
			if (this.g > 0)
			{
				num3 = A_0 + (this.n - 1E-05f) - (b0b.Location.X + b0b.Size.X);
			}
			else
			{
				num3 = b0b.Location.X - (A_0 - (this.n - 1E-05f));
			}
			num = num3 / this.l().a().X;
		}
		if (A_1 != -3.4028235E+38f)
		{
			float num4;
			if (this.h > 0)
			{
				num4 = A_1 + (this.n - 1E-05f) - (b0b.Location.Y + b0b.Size.Y);
			}
			else
			{
				num4 = b0b.Location.Y - (A_1 - (this.n - 1E-05f));
			}
			num2 = num4 / this.l().a().Y;
		}
		float num5;
		if (num < num2)
		{
			num5 = num;
		}
		else
		{
			num5 = num2;
		}
		if (num5 > 0f)
		{
			vector += this.l().a() * num5;
			b0b.Location = vector;
			b0b.ah();
		}
	}

	// Token: 0x0600133E RID: 4926 RVA: 0x000506B0 File Offset: 0x0004E8B0
	private void d()
	{
		this.l().a(0f);
		this.l().a(Vector3.Zero);
	}

	// Token: 0x0600133F RID: 4927 RVA: 0x000506E0 File Offset: 0x0004E8E0
	private void c()
	{
		if (this.q)
		{
			this.k = this.n().kp(this.l().a8());
		}
		this.j = (this.k != null && this.k.b.Count > 0);
		if (this.k == null)
		{
			this.k = new bjp();
		}
	}

	// Token: 0x06001340 RID: 4928 RVA: 0x00050754 File Offset: 0x0004E954
	private void b()
	{
		Vector3 vector = this.a - this.l().a8().Location;
		vector.Normalize();
		float num = 16f;
		float num2 = bpr.a(this.e, num);
		if (num2 < this.l().a8().Playfield.Settings.a())
		{
			num2 = this.l().a8().Playfield.Settings.a();
			num = bpr.b(num2, this.e);
		}
		else if (num2 > this.l().a8().Playfield.Settings.e())
		{
			num2 = this.l().a8().Playfield.Settings.e();
			num = bpr.b(num2, this.e);
		}
		if (num > 16f)
		{
			float num3 = num / 16f;
			num = 16f;
			num2 /= num3;
		}
		this.f = num2;
		this.c = TimeSpan.FromMilliseconds((double)num);
		if (float.IsNaN(vector.X) || float.IsNaN(vector.Y) || float.IsNaN(vector.Z))
		{
			this.g = 0;
			this.h = 0;
			this.i = 0;
		}
		else
		{
			this.g = Math.Sign(vector.X);
			this.h = Math.Sign(vector.Y);
			this.i = Math.Sign(vector.Z);
		}
		this.l().a(this.e);
		this.l().a(vector * this.f);
		if (this.o)
		{
			this.l().a8().VisualDirection = bnx.a(vector);
		}
	}

	// Token: 0x06001341 RID: 4929 RVA: 0x00050934 File Offset: 0x0004EB34
	private static float b(float A_0, float A_1)
	{
		return 1000f * (A_0 / A_1);
	}

	// Token: 0x06001342 RID: 4930 RVA: 0x00050940 File Offset: 0x0004EB40
	private static float a(float A_0, float A_1)
	{
		return A_0 * A_1 / 1000f;
	}

	// Token: 0x06001343 RID: 4931 RVA: 0x0005094C File Offset: 0x0004EB4C
	private void a()
	{
		if (this.p != null)
		{
			this.e = this.p.Value;
			return;
		}
		this.e = this.l().d();
	}

	// Token: 0x04000A6C RID: 2668
	private new Vector3 a;

	// Token: 0x04000A6D RID: 2669
	private EntityAspectReference<mj, mj> b;

	// Token: 0x04000A6E RID: 2670
	private TimeSpan c;

	// Token: 0x04000A6F RID: 2671
	private TimeSpan d;

	// Token: 0x04000A70 RID: 2672
	private float e;

	// Token: 0x04000A71 RID: 2673
	private float f;

	// Token: 0x04000A72 RID: 2674
	private int g;

	// Token: 0x04000A73 RID: 2675
	private int h;

	// Token: 0x04000A74 RID: 2676
	private int i;

	// Token: 0x04000A75 RID: 2677
	private new bool j;

	// Token: 0x04000A76 RID: 2678
	private new bjp k;

	// Token: 0x04000A77 RID: 2679
	private yo l;

	// Token: 0x04000A78 RID: 2680
	private string m;

	// Token: 0x04000A79 RID: 2681
	private new float n;

	// Token: 0x04000A7A RID: 2682
	private bool o = true;

	// Token: 0x04000A7B RID: 2683
	private float? p;

	// Token: 0x04000A7C RID: 2684
	private bool q = true;

	// Token: 0x04000A7D RID: 2685
	[NonSerialized]
	private bool r;

	// Token: 0x04000A7E RID: 2686
	[NonSerialized]
	private a7o s;

	// Token: 0x04000A7F RID: 2687
	private List<aig> t = new List<aig>();

	// Token: 0x04000A80 RID: 2688
	private a7o u;
}
