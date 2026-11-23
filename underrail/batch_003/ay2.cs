using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x020012B1 RID: 4785
[eiz("SVESEA")]
[a(typeof(bbw))]
[Serializable]
public sealed class ay2 : bbw, ISerializable
{
	// Token: 0x06006906 RID: 26886 RVA: 0x002C59D8 File Offset: 0x002C3BD8
	private ay2(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06006907 RID: 26887 RVA: 0x002C59E4 File Offset: 0x002C3BE4
	public override int s6()
	{
		bcx bcx = this.a();
		if (bcx != null)
		{
			return bcx.am();
		}
		return 0;
	}

	// Token: 0x06006908 RID: 26888 RVA: 0x002C5A08 File Offset: 0x002C3C08
	public override void s7(int A_0)
	{
	}

	// Token: 0x06006909 RID: 26889 RVA: 0x002C5A0C File Offset: 0x002C3C0C
	public override double s8()
	{
		bcx bcx = this.a();
		if (bcx != null)
		{
			return bcx.g();
		}
		return 0.0;
	}

	// Token: 0x0600690A RID: 26890 RVA: 0x002C5A38 File Offset: 0x002C3C38
	public override void s9(double A_0)
	{
	}

	// Token: 0x0600690B RID: 26891 RVA: 0x002C5A3C File Offset: 0x002C3C3C
	public override Point ta()
	{
		return new Point(-40, 0);
	}

	// Token: 0x0600690C RID: 26892 RVA: 0x002C5A48 File Offset: 0x002C3C48
	public ay2(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x0600690D RID: 26893 RVA: 0x002C5A54 File Offset: 0x002C3C54
	public override bool tb()
	{
		return this.s8() < (double)this.s6();
	}

	// Token: 0x0600690E RID: 26894 RVA: 0x002C5A68 File Offset: 0x002C3C68
	public override double tc(c5x A_0, double A_1)
	{
		bcx bcx = this.a();
		if (bcx != null)
		{
			return bcx.a(A_1);
		}
		return 0.0;
	}

	// Token: 0x0600690F RID: 26895 RVA: 0x002C5A94 File Offset: 0x002C3C94
	public override double td(c5x A_0, double A_1, bool A_2 = true)
	{
		bcx bcx = this.a();
		if (bcx != null)
		{
			return bcx.h(A_1);
		}
		return 0.0;
	}

	// Token: 0x06006910 RID: 26896 RVA: 0x002C5AC0 File Offset: 0x002C3CC0
	private bcx a()
	{
		if (base.a8() != null)
		{
			wv wv = base.a8().GetAspect<bim>() as wv;
			if (wv != null)
			{
				return wv.g();
			}
		}
		return null;
	}
}
