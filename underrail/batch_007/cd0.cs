using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Common.Aspects;

// Token: 0x020012A8 RID: 4776
[a(typeof(cd0))]
[eiz("SEA")]
[Serializable]
public class cd0 : Aspect<c5x>, b0w, bdi, ISerializable
{
	// Token: 0x0600687F RID: 26751 RVA: 0x002C2CA0 File Offset: 0x002C0EA0
	protected cd0(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = A_0.GetString("SEA:M");
			this.b = (Point)A_0.GetValue("SEA:F", typeof(Point));
			this.c = (Color?)A_0.GetValue("SEA:CO", typeof(Color?));
			this.d = (float?)A_0.GetValue("SEA:AO", typeof(float?));
			if (ell.a() >= 64)
			{
				this.e = A_0.GetString("SEA:T");
			}
			if (ell.a() >= 68)
			{
				this.f = A_0.GetSingle("SEA:B");
			}
			else
			{
				this.f = 1f;
			}
			if (ell.a() >= 481)
			{
				this.h = A_0.GetBoolean("SEA:D");
			}
			if (ell.a() >= 543)
			{
				this.g = (A_0.GetValue("SEA:L", typeof(float?)) as float?);
			}
			if (ell.a() >= 605)
			{
				this.i = (Vector2)A_0.GetValue("SEA:S", typeof(Vector2));
			}
			else
			{
				this.i = Vector2.One;
			}
			if (ell.a() >= 630)
			{
				this.j = (A_0.GetValue("SEA:W", typeof(int?)) as int?);
			}
			if (ell.a() >= 674)
			{
				this.k = A_0.GetBoolean("SEA:RW");
				return;
			}
		}
		else
		{
			this.a = A_0.GetString("_Model");
			this.b = (Point)A_0.GetValue("_Frame", typeof(Point));
			this.c = (A_0.GetValue("_ColorOverride", typeof(Color?)) as Color?);
			try
			{
				this.d = (A_0.GetValue("_AlphaOverride", typeof(float?)) as float?);
			}
			catch
			{
				byte? b = A_0.GetValue("_AlphaOverride", typeof(byte?)) as byte?;
				if (b != null)
				{
					this.d = new float?((float)b.Value / 255f);
				}
			}
		}
	}

	// Token: 0x06006880 RID: 26752 RVA: 0x002C2F54 File Offset: 0x002C1154
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SEA:M", this.a);
		info.AddValue("SEA:F", this.b);
		info.AddValue("SEA:CO", this.c);
		info.AddValue("SEA:AO", this.d);
		info.AddValue("SEA:T", this.e);
		info.AddValue("SEA:B", this.f);
		info.AddValue("SEA:D", this.h);
		info.AddValue("SEA:L", this.g);
		info.AddValue("SEA:S", this.i);
		info.AddValue("SEA:W", this.j);
		info.AddValue("SEA:RW", this.k);
	}

	// Token: 0x06006881 RID: 26753 RVA: 0x002C3044 File Offset: 0x002C1244
	public Point l()
	{
		return this.b;
	}

	// Token: 0x06006882 RID: 26754 RVA: 0x002C304C File Offset: 0x002C124C
	public void a(Point A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06006883 RID: 26755 RVA: 0x002C3058 File Offset: 0x002C1258
	public int? k()
	{
		return this.j;
	}

	// Token: 0x06006884 RID: 26756 RVA: 0x002C3060 File Offset: 0x002C1260
	public void d(int? A_0)
	{
		this.j = A_0;
	}

	// Token: 0x06006885 RID: 26757 RVA: 0x002C306C File Offset: 0x002C126C
	public bool j()
	{
		return this.k;
	}

	// Token: 0x06006886 RID: 26758 RVA: 0x002C3074 File Offset: 0x002C1274
	public void b(bool A_0)
	{
		this.k = A_0;
	}

	// Token: 0x06006887 RID: 26759 RVA: 0x002C3080 File Offset: 0x002C1280
	public Point p8()
	{
		if (this.j != null)
		{
			return new Point(this.b.Y * this.j.Value + this.b.X, 0);
		}
		return this.b;
	}

	// Token: 0x06006888 RID: 26760 RVA: 0x002C30D0 File Offset: 0x002C12D0
	public cd0(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x06006889 RID: 26761 RVA: 0x002C30F0 File Offset: 0x002C12F0
	public virtual Point oc(bool A_0)
	{
		return this.b;
	}

	// Token: 0x0600688A RID: 26762 RVA: 0x002C30F8 File Offset: 0x002C12F8
	public virtual void v2()
	{
		this.b = new Point(this.b.X + 1, this.b.Y);
		if (this.k && this.j != null && this.b.X >= this.j.Value)
		{
			this.b.Y = this.b.Y + this.b.X / this.j.Value;
			this.b.X = this.b.X % this.j.Value;
		}
	}

	// Token: 0x0600688B RID: 26763 RVA: 0x002C31A8 File Offset: 0x002C13A8
	public virtual void v3()
	{
		if (this.k && this.j != null)
		{
			if (this.b.X > 0 || this.b.Y > 0)
			{
				this.b.X = this.b.X - 1;
				if (this.b.X < 0)
				{
					this.b.X = this.j.Value - 1;
					this.b.Y = Math.Max(0, this.b.Y - 1);
					return;
				}
			}
		}
		else if (this.b.X > 0)
		{
			this.b = new Point(this.b.X - 1, this.b.Y);
		}
	}

	// Token: 0x0600688C RID: 26764 RVA: 0x002C3280 File Offset: 0x002C1480
	public virtual void qa()
	{
		this.b = new Point(0, this.b.Y);
	}

	// Token: 0x0600688D RID: 26765 RVA: 0x002C329C File Offset: 0x002C149C
	public void p9(b0b A_0)
	{
		czh.a(A_0, "entity");
		cd0 aspect = A_0.GetAspect<cd0>();
		if (aspect != null)
		{
			aspect.b = this.b;
		}
	}

	// Token: 0x0600688E RID: 26766 RVA: 0x002C32D0 File Offset: 0x002C14D0
	public void qb(int A_0, bool A_1 = false)
	{
		if (A_1)
		{
			if (this.j != null && this.j.Value > 0)
			{
				int num = this.b.X + this.b.Y * this.j.Value;
				if (num == 0)
				{
					int x = A_0 - A_0 / this.j.Value * this.j.Value - 1;
					this.b = new Point(x, A_0 / this.j.Value);
					return;
				}
				num--;
				this.b.X = num % this.j.Value;
				this.b.Y = num / this.j.Value;
				return;
			}
			else
			{
				if (this.b.X == 0)
				{
					this.b = new Point(A_0 - 1, this.b.Y);
					return;
				}
				this.b = new Point(this.b.X - 1, this.b.Y);
				return;
			}
		}
		else if (this.j != null)
		{
			int num2 = this.b.X + this.b.Y * this.j.Value;
			if (num2 >= A_0 - 1)
			{
				this.b = new Point(0, 0);
				return;
			}
			num2++;
			this.b.X = num2 % this.j.Value;
			this.b.Y = num2 / this.j.Value;
			return;
		}
		else
		{
			if (this.b.X >= A_0 - 1)
			{
				this.b = new Point(0, this.b.Y);
				return;
			}
			this.b = new Point(this.b.X + 1, this.b.Y);
			return;
		}
	}

	// Token: 0x0600688F RID: 26767 RVA: 0x002C34B8 File Offset: 0x002C16B8
	public void qc(int A_0)
	{
		this.b = new Point(this.b.X, base.a8().ac);
	}

	// Token: 0x04002B28 RID: 11048
	public string a;

	// Token: 0x04002B29 RID: 11049
	public Point b;

	// Token: 0x04002B2A RID: 11050
	public Color? c;

	// Token: 0x04002B2B RID: 11051
	public float? d;

	// Token: 0x04002B2C RID: 11052
	public string e;

	// Token: 0x04002B2D RID: 11053
	public float f = 1f;

	// Token: 0x04002B2E RID: 11054
	public float? g;

	// Token: 0x04002B2F RID: 11055
	public bool h;

	// Token: 0x04002B30 RID: 11056
	public Vector2 i = Vector2.One;

	// Token: 0x04002B31 RID: 11057
	private int? j;

	// Token: 0x04002B32 RID: 11058
	private bool k;
}
