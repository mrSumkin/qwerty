using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x020010B7 RID: 4279
[eiz("MSDRJ")]
[Serializable]
public sealed class dwc : cze
{
	// Token: 0x060059EF RID: 23023 RVA: 0x0026D924 File Offset: 0x0026BB24
	private dwc(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (Guid)A_0.GetValue("MSDRJ:I", typeof(Guid));
		this.b = (A_0.GetValue("MSDRJ:L", typeof(bt4)) as bt4);
	}

	// Token: 0x060059F0 RID: 23024 RVA: 0x0026D984 File Offset: 0x0026BB84
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("MSDRJ:I", this.a);
		info.AddValue("MSDRJ:L", this.b);
	}

	// Token: 0x060059F1 RID: 23025 RVA: 0x0026D9B8 File Offset: 0x0026BBB8
	public Guid a()
	{
		return this.a;
	}

	// Token: 0x060059F2 RID: 23026 RVA: 0x0026D9C0 File Offset: 0x0026BBC0
	public void a(Guid A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060059F3 RID: 23027 RVA: 0x0026D9CC File Offset: 0x0026BBCC
	public bt4 b()
	{
		return this.b;
	}

	// Token: 0x060059F4 RID: 23028 RVA: 0x0026D9D4 File Offset: 0x0026BBD4
	public void a(bt4 A_0)
	{
		this.b = A_0;
	}

	// Token: 0x060059F5 RID: 23029 RVA: 0x0026D9E0 File Offset: 0x0026BBE0
	public dwc()
	{
	}

	// Token: 0x060059F6 RID: 23030 RVA: 0x0026D9F8 File Offset: 0x0026BBF8
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = A_0 as c5x;
		if (c5x == null)
		{
			c5x = (A_1 as c5x);
		}
		if (c5x != null)
		{
			EntityAspectReference<bja, bja> entityAspectReference = new EntityAspectReference<bja, bja>(c5x.Area, this.a);
			if (entityAspectReference != null && entityAspectReference.ao() != null)
			{
				entityAspectReference.ao().d(new asf(Guid.NewGuid(), this.b));
			}
		}
	}

	// Token: 0x04002418 RID: 9240
	private new Guid a;

	// Token: 0x04002419 RID: 9241
	private bt4 b = new bt4();
}
