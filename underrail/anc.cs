using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ouroboros.Common.Aspects;

// Token: 0x020012DD RID: 4829
[eiz("V0")]
[Serializable]
public class anc : Aspect<c5x>, ISerializable
{
	// Token: 0x06006AD0 RID: 27344 RVA: 0x002CF958 File Offset: 0x002CDB58
	protected anc(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		di7.ReadList<cze>("V0:J", ref this.a, A_0);
		this.b = A_0.GetBoolean("V0:A");
		this.c = A_0.GetBoolean("V0:E");
	}

	// Token: 0x06006AD1 RID: 27345 RVA: 0x002CF9B4 File Offset: 0x002CDBB4
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		di7.WriteList<cze>("V0:J", this.a, info);
		info.AddValue("V0:A", this.b);
		info.AddValue("V0:E", this.c);
	}

	// Token: 0x06006AD2 RID: 27346 RVA: 0x002CF9F4 File Offset: 0x002CDBF4
	public List<cze> a()
	{
		return this.a;
	}

	// Token: 0x06006AD3 RID: 27347 RVA: 0x002CF9FC File Offset: 0x002CDBFC
	public void a(List<cze> A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06006AD4 RID: 27348 RVA: 0x002CFA08 File Offset: 0x002CDC08
	public bool d()
	{
		return this.b;
	}

	// Token: 0x06006AD5 RID: 27349 RVA: 0x002CFA10 File Offset: 0x002CDC10
	public void b(bool A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06006AD6 RID: 27350 RVA: 0x002CFA1C File Offset: 0x002CDC1C
	public bool b()
	{
		return this.c;
	}

	// Token: 0x06006AD7 RID: 27351 RVA: 0x002CFA24 File Offset: 0x002CDC24
	public void a(bool A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06006AD8 RID: 27352 RVA: 0x002CFA30 File Offset: 0x002CDC30
	public anc(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x06006AD9 RID: 27353 RVA: 0x002CFA50 File Offset: 0x002CDC50
	public void a(c5x A_0)
	{
		if (this.c)
		{
			Dictionary<string, object> a_ = new Dictionary<string, object>();
			foreach (cze cze in this.a)
			{
				cze.ym(A_0, base.a8(), a_);
			}
			if (this.b)
			{
				this.c = false;
			}
		}
	}

	// Token: 0x04002BDE RID: 11230
	private List<cze> a = new List<cze>();

	// Token: 0x04002BDF RID: 11231
	private bool b;

	// Token: 0x04002BE0 RID: 11232
	private bool c = true;
}
