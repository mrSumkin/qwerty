using System;
using Microsoft.Xna.Framework;

// Token: 0x02000583 RID: 1411
public sealed class b88 : amw
{
	// Token: 0x06002475 RID: 9333 RVA: 0x000CDA68 File Offset: 0x000CBC68
	public bool aet()
	{
		return this.e != null;
	}

	// Token: 0x06002476 RID: 9334 RVA: 0x000CDA78 File Offset: 0x000CBC78
	public Guid? aeu()
	{
		return this.j;
	}

	// Token: 0x06002477 RID: 9335 RVA: 0x000CDA80 File Offset: 0x000CBC80
	public bool a()
	{
		return this.k != null;
	}

	// Token: 0x06002478 RID: 9336 RVA: 0x000CDA8C File Offset: 0x000CBC8C
	public b0b aev()
	{
		ar7 ar = this.k;
		if (ar == null)
		{
			return null;
		}
		return ar.ao();
	}

	// Token: 0x06002479 RID: 9337 RVA: 0x000CDAA4 File Offset: 0x000CBCA4
	public Vector3 aew()
	{
		if (this.d == null || this.d.ac() == null || this.d.ac().q() == null || this.d.ac().q().an9() == null)
		{
			return Vector3.Zero;
		}
		return this.d.ac().q().an9().t1();
	}

	// Token: 0x0600247A RID: 9338 RVA: 0x000CDB1C File Offset: 0x000CBD1C
	public b88(dka A_0)
	{
		czh.a(A_0, "localeController");
		this.d = A_0;
	}

	// Token: 0x0600247B RID: 9339 RVA: 0x000CDB3C File Offset: 0x000CBD3C
	public Vector3 b()
	{
		return this.d.ac().q().an9().t1();
	}

	// Token: 0x0600247C RID: 9340 RVA: 0x000CDB64 File Offset: 0x000CBD64
	public void a(double A_0)
	{
		c5m c5m = this.d.ac().q().an9();
		if (this.k != null)
		{
			if (this.k.ao() != null && this.k.ao().Area != null)
			{
				if ((this.m += A_0) > 100.0)
				{
					this.m = 0.0;
					this.aex(this.k.ao().Area, this.k.ao().aj(), false, new float?(this.l));
				}
			}
			else
			{
				this.ae1();
			}
		}
		if (this.e != null)
		{
			c5m c5m2 = c5m;
			c5m2.t2(c5m2.t1() + this.f * (float)A_0);
			if (Math.Sign(this.e.Value.X - c5m.t1().X) != this.g || Math.Sign(this.e.Value.Y - c5m.t1().Y) != this.h || Math.Sign(this.e.Value.Z - c5m.t1().Z) != this.i)
			{
				c5m.t2(this.e.Value);
				this.aey();
			}
		}
	}

	// Token: 0x0600247D RID: 9341 RVA: 0x000CDCEC File Offset: 0x000CBEEC
	public Guid? aex(aud A_0, Vector3 A_1, bool A_2, float? A_3 = null)
	{
		bool flag = this.d.ac().q().anz() != A_0;
		if (flag)
		{
			this.d.ac().q().an0(A_0);
			if (A_0 != null && A_0.Zone != null)
			{
				this.d.ac().q().ah = A_0.Zone.CustomProperties.GetPrimitivePropertyValue<int>("ExtraTopSpan", new int?(0)).Value;
				this.d.ac().q().ai = A_0.Zone.CustomProperties.GetPrimitivePropertyValue<int>("ExtraBottomSpan", new int?(0)).Value;
				this.d.ac().q().aj = A_0.Zone.CustomProperties.GetPrimitivePropertyValue<int>("ExtraLeftSpan", new int?(0)).Value;
				this.d.ac().q().ak = A_0.Zone.CustomProperties.GetPrimitivePropertyValue<int>("ExtraRightSpan", new int?(0)).Value;
			}
			this.d.ac().q().an9().t7(new Vector2((float)this.d.ac().q().anz().Size.c, (float)this.d.ac().q().anz().Size.d));
			this.d.ac().q().an9().uq(true, true, true);
		}
		if (flag || A_2)
		{
			this.e = null;
			this.d.ac().q().an9().t2(A_1);
			this.j = null;
			return null;
		}
		if (A_1 == this.d.ac().q().an9().t1())
		{
			return null;
		}
		this.e = new Vector3?(A_1);
		Vector3 vector = this.e.Value - this.d.ac().q().an9().t1();
		vector.Normalize();
		this.f = vector / 1000f * ((A_3 != null) ? A_3.Value : 4.5f);
		this.g = Math.Sign(vector.X);
		this.h = Math.Sign(vector.Y);
		this.i = Math.Sign(vector.Z);
		return this.j = new Guid?(Guid.NewGuid());
	}

	// Token: 0x0600247E RID: 9342 RVA: 0x000CDFC8 File Offset: 0x000CC1C8
	public void aey()
	{
		this.e = null;
		this.j = null;
	}

	// Token: 0x0600247F RID: 9343 RVA: 0x000CDFE4 File Offset: 0x000CC1E4
	public void aez(b0b A_0, bool A_1 = true)
	{
		this.ae0(A_0, 3f, A_1);
	}

	// Token: 0x06002480 RID: 9344 RVA: 0x000CDFF4 File Offset: 0x000CC1F4
	public void ae0(b0b A_0, float A_1, bool A_2 = true)
	{
		if (A_2 || (A_0 != null && A_0 != this.aev()))
		{
			this.ae1();
		}
		if (A_0 != null)
		{
			this.k = new ar7(A_0);
			this.l = A_1;
		}
		if (A_2)
		{
			this.m = 0.0;
		}
	}

	// Token: 0x06002481 RID: 9345 RVA: 0x000CE050 File Offset: 0x000CC250
	public void ae1()
	{
		this.k = null;
		this.aey();
	}

	// Token: 0x0400152C RID: 5420
	private const float a = 4.5f;

	// Token: 0x0400152D RID: 5421
	private const float b = 100f;

	// Token: 0x0400152E RID: 5422
	private const float c = 3f;

	// Token: 0x0400152F RID: 5423
	private dka d;

	// Token: 0x04001530 RID: 5424
	private Vector3? e;

	// Token: 0x04001531 RID: 5425
	private Vector3 f;

	// Token: 0x04001532 RID: 5426
	private int g;

	// Token: 0x04001533 RID: 5427
	private int h;

	// Token: 0x04001534 RID: 5428
	private int i;

	// Token: 0x04001535 RID: 5429
	private Guid? j;

	// Token: 0x04001536 RID: 5430
	private ar7 k;

	// Token: 0x04001537 RID: 5431
	private float l;

	// Token: 0x04001538 RID: 5432
	private double m;
}
