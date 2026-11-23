using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Common.Data;
using Ouroboros.Common.Events;

// Token: 0x02000239 RID: 569
[eiz("L")]
[Serializable]
public sealed class bsf : u, IEventSubscriber<a8f>, ok, aue, ISerializable
{
	// Token: 0x0600100C RID: 4108 RVA: 0x00042738 File Offset: 0x00040938
	private bsf(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.b() != 0)
		{
			this.a = (ah7)A_0.GetValue("L:D", typeof(ah7));
			this.c = (Point?)A_0.GetValue("L:OSN", typeof(Point?));
			return;
		}
		if (base.GetType() == typeof(bsf))
		{
			this.a = (ah7)A_0.GetValue("_Definition", typeof(ah7));
			this.c = (Point?)A_0.GetValue("_OldSourceNode", typeof(Point?));
			return;
		}
		this.a = (ah7)A_0.GetValue("Lantern+_Definition", typeof(ah7));
		this.c = (Point?)A_0.GetValue("Lantern+_OldSourceNode", typeof(Point?));
	}

	// Token: 0x0600100D RID: 4109 RVA: 0x00042834 File Offset: 0x00040A34
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("L:D", this.a);
		info.AddValue("L:OSN", this.c);
	}

	// Token: 0x170000A3 RID: 163
	// (get) Token: 0x0600100E RID: 4110 RVA: 0x00042868 File Offset: 0x00040A68
	public ah7 Definition
	{
		get
		{
			return this.a;
		}
	}

	// Token: 0x170000A4 RID: 164
	// (get) Token: 0x0600100F RID: 4111 RVA: 0x00042870 File Offset: 0x00040A70
	public override object SourceDefinition
	{
		get
		{
			return this.a;
		}
	}

	// Token: 0x06001010 RID: 4112 RVA: 0x00042878 File Offset: 0x00040A78
	public bsf(ah7 A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06001011 RID: 4113 RVA: 0x00042888 File Offset: 0x00040A88
	public override void ig()
	{
		this.ij();
		this.e();
		this.a.a(this);
	}

	// Token: 0x06001012 RID: 4114 RVA: 0x000428A8 File Offset: 0x00040AA8
	public override void ii(bool A_0)
	{
		Point point = new Point((int)base.Location.X, (int)base.Location.Y);
		if (A_0 || point != this.c)
		{
			this.b.aj(point);
			this.b.al();
			this.c = new Point?(point);
		}
	}

	// Token: 0x06001013 RID: 4115 RVA: 0x0004292C File Offset: 0x00040B2C
	public override void ij()
	{
		if (this.b != null)
		{
			this.b.am();
			this.b = null;
		}
	}

	// Token: 0x06001014 RID: 4116 RVA: 0x00042950 File Offset: 0x00040B50
	public new void b()
	{
		this.b.ag().a(this.a.Range);
		this.b.ag().a(false);
		this.b.al();
	}

	// Token: 0x06001015 RID: 4117 RVA: 0x00042994 File Offset: 0x00040B94
	public override void ih()
	{
		this.b = new dlx();
		this.b.a(a6h.a);
		this.b.anu(this);
		this.b.a(this.b.Playfield.LightProcessor);
		this.b.a(new bbg());
		foreach (TypedObjectReference<ok> typedObjectReference in this.a.AdditionalPenetrationPredicates)
		{
			if (typedObjectReference.ao() != null)
			{
				this.b.ag().a().Add(typedObjectReference.ao());
			}
		}
		foreach (TypedObjectReference<aue> typedObjectReference2 in this.a.AdditionalImpactPredicates)
		{
			if (typedObjectReference2.ao() != null)
			{
				this.b.ag().c().Add(typedObjectReference2.ao());
			}
		}
		this.b.ag().a(this.a.Range);
		this.b.ag().a(false);
		this.b.ag().c().Add(this);
		this.b.ag().a().Add(this);
		this.ii(true);
	}

	// Token: 0x06001016 RID: 4118 RVA: 0x00042B2C File Offset: 0x00040D2C
	public alr a(float A_0, float A_1)
	{
		ae8 a_ = this.a.Light;
		a_.a(Math.Max(0f, a_.c() - A_0 * this.a.LightFadeRate) * A_1);
		return new b60(a_);
	}

	// Token: 0x06001017 RID: 4119 RVA: 0x00042B74 File Offset: 0x00040D74
	void IEventSubscriber<a8f>.b(object A_0, EventHandler<a8f> A_1)
	{
		if (this.b != null && this.b.m != null)
		{
			Point point = (Point)A_0;
			ak1 ak = this.b.m.b(point.X, point.Y);
			if (ak != null)
			{
				ak.c(A_1);
			}
		}
	}

	// Token: 0x06001018 RID: 4120 RVA: 0x00042BD0 File Offset: 0x00040DD0
	void IEventSubscriber<a8f>.a(object A_0, EventHandler<a8f> A_1)
	{
		if (this.b != null && this.b.m != null)
		{
			Point point = (Point)A_0;
			ak1 ak = this.b.m.b(point.X, point.Y);
			if (ak != null)
			{
				ak.a(A_1);
			}
		}
	}

	// Token: 0x06001019 RID: 4121 RVA: 0x00042C2C File Offset: 0x00040E2C
	public bool q8(anl A_0)
	{
		return this.b != null && this.b.m != null;
	}

	// Token: 0x0600101A RID: 4122 RVA: 0x00042C4C File Offset: 0x00040E4C
	public void q9(Point A_0, object A_1, float A_2)
	{
		if (this.b != null && this.b.m != null && this.a.Enabled)
		{
			ak1 ak = this.b.m.b(A_0.X, A_0.Y);
			if (ak != null)
			{
				float a_ = A_2;
				if (this.a.n != 0f && this.a.m != Vector2.Zero)
				{
					Vector2 vector = new Vector2(this.b.Location.X + this.b.Size.X / 2f, this.b.Location.Y + this.b.Size.Y / 2f);
					Vector2 vector2 = new Vector2((float)A_0.X + 0.5f, (float)A_0.Y + 0.5f);
					Point point = vector.a();
					Point point2 = vector2.a();
					if (point != point2)
					{
						double num = bnx.a(vector, vector + this.a.m, vector2) - (double)(this.a.n / 2f);
						if (num > 0.0)
						{
							a_ = Convert.ToSingle((double)A_2 * Math.Max(0.0, 1.0 - num / (double)(this.a.n * 0.5f)));
						}
					}
				}
				c3y a_2 = new c3y(base.Id, this.a((float)A_1, a_), dqc.c);
				ak.a(a_2);
				ak.e();
			}
		}
	}

	// Token: 0x0600101B RID: 4123 RVA: 0x00042E04 File Offset: 0x00041004
	public bool ra(Point A_0, object A_1, float A_2)
	{
		return this.b != null && this.b.m != null;
	}

	// Token: 0x0600101C RID: 4124 RVA: 0x00042E24 File Offset: 0x00041024
	public void rb(Point A_0, object A_1, float A_2)
	{
		if (this.b != null && this.b.m != null)
		{
			ak1 ak = this.b.m.b(A_0.X, A_0.Y);
			if (ak != null)
			{
				ak.a(base.Id);
				ak.e();
			}
		}
	}

	// Token: 0x0600101D RID: 4125 RVA: 0x00042E84 File Offset: 0x00041084
	public object rc(anl A_0)
	{
		return A_0.a();
	}

	// Token: 0x0600101E RID: 4126 RVA: 0x00042E94 File Offset: 0x00041094
	public bool g5(anl A_0)
	{
		if (base.Carrier != null && this.b.m != null)
		{
			ak1 ak = this.b.m.b(A_0.d().X, A_0.d().Y);
			return ak != null && !ak.Formation.c(1L);
		}
		return false;
	}

	// Token: 0x04000967 RID: 2407
	private new ah7 a;

	// Token: 0x04000968 RID: 2408
	[NonSerialized]
	private new dlx b;

	// Token: 0x04000969 RID: 2409
	private Point? c;
}
