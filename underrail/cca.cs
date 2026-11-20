using System;
using System.Runtime.Serialization;

// Token: 0x020007DE RID: 2014
[eiz("OTPT")]
[Serializable]
public abstract class cca : ya, ISerializable
{
	// Token: 0x0600327B RID: 12923 RVA: 0x00139E64 File Offset: 0x00138064
	protected cca(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600327C RID: 12924 RVA: 0x00139E70 File Offset: 0x00138070
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x0600327D RID: 12925 RVA: 0x00139E7C File Offset: 0x0013807C
	protected override void jk(b0b A_0)
	{
		base.jk(A_0);
		c5x c5x = A_0 as c5x;
		if (c5x != null && ((c5x.Initialized && c5x.c(e2b.d)) || (!c5x.Initialized && c5x.h.b != null && c5x.h.b.@as())))
		{
			this.adf(c5x);
			base.o();
		}
	}

	// Token: 0x0600327E RID: 12926
	protected abstract void adf(c5x A_0);

	// Token: 0x0600327F RID: 12927 RVA: 0x00139EF4 File Offset: 0x001380F4
	public cca()
	{
	}
}
