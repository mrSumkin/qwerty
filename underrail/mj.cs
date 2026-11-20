using System;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Common.Aspects;
using Ouroboros.Playfield.Aspects;

// Token: 0x02000285 RID: 645
[eiz("MEA")]
[Serializable]
public sealed class mj : Aspect<b0b>, ISerializable
{
	// Token: 0x060012B4 RID: 4788 RVA: 0x0004DE00 File Offset: 0x0004C000
	private mj(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.b() != 0)
		{
			this.a = A_0.GetSingle("MEA:CS");
			this.b = (Vector3)A_0.GetValue("MEA:CM", typeof(Vector3));
			this.c = A_0.GetSingle("MEA:MS");
			this.d = A_0.GetSingle("MEA:SS");
			this.e = (aig)A_0.GetValue("MEA:MH", typeof(aig));
			this.f = (c02)A_0.GetValue("MEA:ME", typeof(c02));
			return;
		}
		this.a = A_0.GetSingle("_CurrentSpeed");
		this.b = (Vector3)A_0.GetValue("_CurrentMomentum", typeof(Vector3));
		this.c = A_0.GetSingle("_MaxSpeed");
		this.d = A_0.GetSingle("_StartSpeed");
		this.e = (A_0.GetValue("_MovementHandler", typeof(aig)) as aig);
		this.f = (A_0.GetValue("_MobileEntity", typeof(c02)) as c02);
	}

	// Token: 0x060012B5 RID: 4789 RVA: 0x0004DF48 File Offset: 0x0004C148
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("MEA:CS", this.a);
		info.AddValue("MEA:CM", this.b);
		info.AddValue("MEA:MS", this.c);
		info.AddValue("MEA:SS", this.d);
		info.AddValue("MEA:MH", this.e);
		info.AddValue("MEA:ME", this.f);
	}

	// Token: 0x060012B6 RID: 4790 RVA: 0x0004DFC8 File Offset: 0x0004C1C8
	public float b()
	{
		return this.a;
	}

	// Token: 0x060012B7 RID: 4791 RVA: 0x0004DFD0 File Offset: 0x0004C1D0
	public void a(float A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060012B8 RID: 4792 RVA: 0x0004DFDC File Offset: 0x0004C1DC
	public Vector3 a()
	{
		return this.b;
	}

	// Token: 0x060012B9 RID: 4793 RVA: 0x0004DFE4 File Offset: 0x0004C1E4
	public void a(Vector3 A_0)
	{
		this.b = A_0;
	}

	// Token: 0x060012BA RID: 4794 RVA: 0x0004DFF0 File Offset: 0x0004C1F0
	public float d()
	{
		return this.f.h9();
	}

	// Token: 0x060012BB RID: 4795 RVA: 0x0004E000 File Offset: 0x0004C200
	public float e()
	{
		return this.f.ia();
	}

	// Token: 0x060012BC RID: 4796 RVA: 0x0004E010 File Offset: 0x0004C210
	public aig f()
	{
		return this.e;
	}

	// Token: 0x060012BD RID: 4797 RVA: 0x0004E018 File Offset: 0x0004C218
	public void a(aig A_0)
	{
		this.e = A_0;
	}

	// Token: 0x060012BE RID: 4798 RVA: 0x0004E024 File Offset: 0x0004C224
	public mj(b0b A_0) : base(A_0)
	{
		czh.a(A_0, "container");
		foreach (cn7 cn in A_0.Aspects)
		{
			c02 c = cn as c02;
			if (c != null)
			{
				a a = Enumerable.FirstOrDefault<a>(Enumerable.OfType<a>(c.GetType().GetCustomAttributes(typeof(a), true)));
				if (a != null)
				{
					this.f = mj.a(a.FacadeType, A_0);
				}
				else
				{
					this.f = mj.a(c.GetType(), A_0);
				}
				if (this.f != null)
				{
					break;
				}
			}
		}
		if (this.f == null)
		{
			throw new Exception("Supplied container did not have any aspects that implement IMobileEntity.");
		}
	}

	// Token: 0x060012BF RID: 4799 RVA: 0x0004E108 File Offset: 0x0004C308
	public mj(b0b A_0, c02 A_1) : base(A_0)
	{
		this.f = A_1;
	}

	// Token: 0x060012C0 RID: 4800 RVA: 0x0004E118 File Offset: 0x0004C318
	private static c02 a(Type A_0, object A_1)
	{
		c02 result;
		try
		{
			if (typeof(cn7).IsAssignableFrom(A_0) && typeof(c02).IsAssignableFrom(A_0))
			{
				result = (Activator.CreateInstance(typeof(MobileEntityAspectAccessor<>).MakeGenericType(new Type[]
				{
					A_0
				}), new object[]
				{
					A_1
				}) as c02);
			}
			else
			{
				result = null;
			}
		}
		catch (Exception innerException)
		{
			throw new Exception("Error occurred while creating mobile aspect accessor.", innerException);
		}
		return result;
	}

	// Token: 0x04000A4E RID: 2638
	private float a;

	// Token: 0x04000A4F RID: 2639
	private Vector3 b;

	// Token: 0x04000A50 RID: 2640
	private float c;

	// Token: 0x04000A51 RID: 2641
	private float d;

	// Token: 0x04000A52 RID: 2642
	private aig e;

	// Token: 0x04000A53 RID: 2643
	private c02 f;
}
