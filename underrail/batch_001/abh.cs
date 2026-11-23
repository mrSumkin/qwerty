using System;
using System.Runtime.Serialization;
using Ouroboros.Common.Aspects;
using Ouroboros.Playfield.References;

// Token: 0x020012D8 RID: 4824
[eiz("XR0")]
[Serializable]
public sealed class abh : Aspect<c5x>, ISerializable, bp1
{
	// Token: 0x06006AAF RID: 27311 RVA: 0x002CEDCC File Offset: 0x002CCFCC
	private abh(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (A_0.GetValue("XR0:C", typeof(EntityAspectReference<c4k, c4k>)) as EntityAspectReference<c4k, c4k>);
		this.b = A_0.GetInt32("XR0:I");
	}

	// Token: 0x06006AB0 RID: 27312 RVA: 0x002CEE1C File Offset: 0x002CD01C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("XR0:C", this.a);
		info.AddValue("XR0:I", this.b);
	}

	// Token: 0x06006AB1 RID: 27313 RVA: 0x002CEE48 File Offset: 0x002CD048
	public abh(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x06006AB2 RID: 27314 RVA: 0x002CEE5C File Offset: 0x002CD05C
	public void mx()
	{
		if (base.a8().h.b != null)
		{
			base.a8().h.b.aa().a(new EventHandler<b8x>(this.a));
		}
	}

	// Token: 0x06006AB3 RID: 27315 RVA: 0x002CEEA4 File Offset: 0x002CD0A4
	public void my()
	{
		if (base.a8().h.b != null)
		{
			base.a8().h.b.aa().b(new EventHandler<b8x>(this.a));
		}
	}

	// Token: 0x06006AB4 RID: 27316 RVA: 0x002CEEEC File Offset: 0x002CD0EC
	private void a(object A_0, b8x A_1)
	{
		if (this.b > 0 && this.a != null && this.a.ao() != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null)
			{
				this.a.ao().b = new TimeSpan?(serviceOrThrow.aqu().p() + TimeSpan.FromMinutes((double)this.b));
			}
		}
	}

	// Token: 0x04002BCD RID: 11213
	public EntityAspectReference<c4k, c4k> a;

	// Token: 0x04002BCE RID: 11214
	public int b = 120;
}
