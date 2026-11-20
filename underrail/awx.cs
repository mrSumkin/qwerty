using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02001436 RID: 5174
[eiz("PTSCA")]
[Serializable]
public class awx : dtb, bgn, evp, ISerializable
{
	// Token: 0x06007407 RID: 29703 RVA: 0x003118E8 File Offset: 0x0030FAE8
	protected awx(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() >= 155)
		{
			this.a = A_0.GetBoolean("PTSCA:I");
		}
		else
		{
			this.a = true;
		}
		if (ell.a() >= 182)
		{
			this.b = (A_0.GetValue("PTSCA:P", typeof(int?)) as int?);
			this.c = (A_0.GetValue("PTSCA:S", typeof(CharacterState?)) as CharacterState?);
		}
	}

	// Token: 0x06007408 RID: 29704 RVA: 0x0031198C File Offset: 0x0030FB8C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("PTSCA:I", this.a);
		info.AddValue("PTSCA:P", this.b);
		info.AddValue("PTSCA:S", this.c);
	}

	// Token: 0x06007409 RID: 29705 RVA: 0x003119E0 File Offset: 0x0030FBE0
	public bool v()
	{
		return this.a;
	}

	// Token: 0x0600740A RID: 29706 RVA: 0x003119E8 File Offset: 0x0030FBE8
	public new void a(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600740B RID: 29707 RVA: 0x003119F4 File Offset: 0x0030FBF4
	public virtual int? tm()
	{
		bgn bgn = base.aa() as bgn;
		if (bgn != null)
		{
			this.b = bgn.tm();
			return bgn.tm();
		}
		return this.b;
	}

	// Token: 0x0600740C RID: 29708 RVA: 0x00311A2C File Offset: 0x0030FC2C
	public virtual CharacterState? q1()
	{
		bgn bgn = base.aa() as bgn;
		if (bgn != null)
		{
			this.c = bgn.q1();
			return bgn.q1();
		}
		return this.c;
	}

	// Token: 0x0600740D RID: 29709 RVA: 0x00311A64 File Offset: 0x0030FC64
	public virtual object fm()
	{
		bgn bgn = base.aa() as bgn;
		if (bgn != null)
		{
			return bgn.fm();
		}
		return null;
	}

	// Token: 0x0600740E RID: 29710 RVA: 0x00311A8C File Offset: 0x0030FC8C
	public virtual ci8? oi()
	{
		bgn bgn = base.aa() as bgn;
		if (bgn != null)
		{
			return bgn.oi();
		}
		return null;
	}

	// Token: 0x0600740F RID: 29711 RVA: 0x00311ABC File Offset: 0x0030FCBC
	public awx()
	{
	}

	// Token: 0x06007410 RID: 29712 RVA: 0x00311ACC File Offset: 0x0030FCCC
	public awx(string A_0) : base(A_0)
	{
	}

	// Token: 0x06007411 RID: 29713 RVA: 0x00311ADC File Offset: 0x0030FCDC
	public awx(IEnumerable<auv> A_0) : base(A_0)
	{
	}

	// Token: 0x06007412 RID: 29714 RVA: 0x00311AEC File Offset: 0x0030FCEC
	public awx(string A_0, IEnumerable<auv> A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007413 RID: 29715 RVA: 0x00311B00 File Offset: 0x0030FD00
	public bool sp()
	{
		return !this.a;
	}

	// Token: 0x04002F6F RID: 12143
	private new bool a = true;

	// Token: 0x04002F70 RID: 12144
	private int? b;

	// Token: 0x04002F71 RID: 12145
	private CharacterState? c;
}
